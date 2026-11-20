# Online Shopping System - WinForms + MySQL (MVC)

Lab 3 desktop implementation of the SRS "Online Shopping System".

## Requirements
- Windows 10/11, **Visual Studio 2022** with the ".NET desktop development" workload (.NET 8)
- **MySQL Server 8** (+ MySQL Workbench)

## Quick start
1. In MySQL Workbench open `Database/oss_db.sql` and run it (lightning-bolt icon). It creates the `oss_db` database, tables and sample data.
2. Open `OnlineShoppingSystem.sln` in Visual Studio.
3. Edit `OnlineShoppingSystem/appsettings.json` and replace `YOUR_MYSQL_PASSWORD` with your MySQL root password.
4. Press **F5**. NuGet restores `MySqlConnector` automatically.
5. Log in as admin: `admin@oss.com` / `Admin@123` (created automatically on first start). Customers register themselves.

## MVC structure
| Folder | Role |
|---|---|
| `Models/` | Entities (User, Product, Address, Coupon, ...) |
| `Views/` | WinForms screens: `*.cs` + `*.Designer.cs` (open them in the Designer and edit visually) |
| `Controllers/` | Business rules + SQL (Auth, Product, Cart, Order, Coupon, Review, Report ...) |
| `Data/` | `Db` helper (MySQL access, transactions) |
| `Helpers/` | Session, password hashing, validation, pricing, printing/CSV, notifier |

Views never talk to the database directly - they call a Controller, which uses `Db`.

## Editing the UI
Double-click any file in `Views/` (e.g. `ProductsControl.cs`) to open the Designer. Controls use Dock/Anchor, so
they resize with the window. Add or move controls freely; to add behaviour double-click a control to create its handler.

## Upload to GitHub (Lab 3)
```
git init
git add .
git commit -m "Online Shopping System - WinForms MVC with MySQL"
git branch -M main
git remote add origin https://github.com/<your-user>/<your-repo>.git
git push -u origin main
```
**Before pushing**, change the password in `appsettings.json` back to a placeholder so you do not publish it.
