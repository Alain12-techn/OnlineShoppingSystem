using System.Data;
using MySqlConnector;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Data;

/// <summary>Small data-access helper. Parameters are passed as alternating name, value pairs:
/// Db.Query("SELECT * FROM users WHERE id=@id", "@id", 5)</summary>
public static class Db
{
    public static MySqlConnection CreateConnection() => new MySqlConnection(AppSettings.ConnectionString);

    internal static MySqlCommand Build(MySqlConnection c, MySqlTransaction tx, string sql, object[] args)
    {
        var cmd = new MySqlCommand(sql, c, tx);
        for (int i = 0; i + 1 < args.Length; i += 2)
            cmd.Parameters.AddWithValue((string)args[i], args[i + 1] ?? DBNull.Value);
        return cmd;
    }

    internal static DataTable ReadTable(MySqlDataReader r)
    {
        var dt = new DataTable();
        for (int i = 0; i < r.FieldCount; i++) dt.Columns.Add(r.GetName(i), r.GetFieldType(i));
        var vals = new object[r.FieldCount];
        dt.BeginLoadData();
        while (r.Read()) { r.GetValues(vals); dt.Rows.Add(vals); }
        dt.EndLoadData();
        return dt;
    }

    public static DataTable Query(string sql, params object[] args)
    {
        using var c = CreateConnection(); c.Open();
        using var cmd = Build(c, null, sql, args);
        using var r = cmd.ExecuteReader();
        return ReadTable(r);
    }

    public static int Execute(string sql, params object[] args)
    {
        using var c = CreateConnection(); c.Open();
        using var cmd = Build(c, null, sql, args);
        return cmd.ExecuteNonQuery();
    }

    public static long Insert(string sql, params object[] args)
    {
        using var c = CreateConnection(); c.Open();
        using var cmd = Build(c, null, sql, args);
        cmd.ExecuteNonQuery();
        return cmd.LastInsertedId;
    }

    public static object Scalar(string sql, params object[] args)
    {
        using var c = CreateConnection(); c.Open();
        using var cmd = Build(c, null, sql, args);
        return cmd.ExecuteScalar();
    }
}

/// <summary>Transaction wrapper - everything is rolled back unless Commit() is called.</summary>
public sealed class DbTx : IDisposable
{
    private readonly MySqlConnection _c;
    private readonly MySqlTransaction _t;
    private bool _done;

    public DbTx() { _c = Db.CreateConnection(); _c.Open(); _t = _c.BeginTransaction(); }

    public DataTable Query(string sql, params object[] args)
    {
        using var cmd = Db.Build(_c, _t, sql, args);
        using var r = cmd.ExecuteReader();
        return Db.ReadTable(r);
    }

    public int Execute(string sql, params object[] args)
    {
        using var cmd = Db.Build(_c, _t, sql, args);
        return cmd.ExecuteNonQuery();
    }

    public long Insert(string sql, params object[] args)
    {
        using var cmd = Db.Build(_c, _t, sql, args);
        cmd.ExecuteNonQuery();
        return cmd.LastInsertedId;
    }

    public object Scalar(string sql, params object[] args)
    {
        using var cmd = Db.Build(_c, _t, sql, args);
        return cmd.ExecuteScalar();
    }

    public void Commit() { _t.Commit(); _done = true; }

    public void Dispose()
    {
        if (!_done) { try { _t.Rollback(); } catch { } }
        _t.Dispose(); _c.Dispose();
    }
}
