-- Online Shopping System - MySQL 8 schema + sample data
CREATE DATABASE IF NOT EXISTS oss_db CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE oss_db;

CREATE TABLE IF NOT EXISTS users (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100) NOT NULL,
  email VARCHAR(150) NOT NULL UNIQUE,
  phone VARCHAR(30) NULL,
  password_hash VARCHAR(200) NOT NULL,
  role ENUM('Admin','Customer') NOT NULL DEFAULT 'Customer',
  is_active TINYINT(1) NOT NULL DEFAULT 1,
  reset_code VARCHAR(10) NULL,
  reset_expiry DATETIME NULL,
  created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS categories (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100) NOT NULL,
  parent_category_id INT NULL,
  FOREIGN KEY (parent_category_id) REFERENCES categories(id) ON DELETE SET NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS brands (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100) NOT NULL UNIQUE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS products (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(150) NOT NULL,
  sku VARCHAR(50) NOT NULL UNIQUE,
  description TEXT NULL,
  price DECIMAL(12,2) NOT NULL,
  stock_qty INT NOT NULL DEFAULT 0,
  low_stock_level INT NOT NULL DEFAULT 5,
  category_id INT NULL,
  brand_id INT NULL,
  image_url VARCHAR(255) NULL,
  created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (category_id) REFERENCES categories(id) ON DELETE SET NULL,
  FOREIGN KEY (brand_id) REFERENCES brands(id) ON DELETE SET NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS addresses (
  id INT AUTO_INCREMENT PRIMARY KEY,
  user_id INT NOT NULL,
  street VARCHAR(200) NOT NULL,
  city VARCHAR(100) NOT NULL,
  phone VARCHAR(30) NOT NULL,
  FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS cart_items (
  id INT AUTO_INCREMENT PRIMARY KEY,
  user_id INT NOT NULL,
  product_id INT NOT NULL,
  quantity INT NOT NULL,
  UNIQUE KEY uq_cart (user_id, product_id),
  FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE,
  FOREIGN KEY (product_id) REFERENCES products(id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS wishlist (
  id INT AUTO_INCREMENT PRIMARY KEY,
  user_id INT NOT NULL,
  product_id INT NOT NULL,
  UNIQUE KEY uq_wish (user_id, product_id),
  FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE,
  FOREIGN KEY (product_id) REFERENCES products(id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS coupons (
  id INT AUTO_INCREMENT PRIMARY KEY,
  code VARCHAR(30) NOT NULL UNIQUE,
  discount_percent DECIMAL(5,2) NOT NULL,
  expiry_date DATE NOT NULL,
  is_active TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS orders (
  id INT AUTO_INCREMENT PRIMARY KEY,
  user_id INT NOT NULL,
  order_date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  status ENUM('Pending','Processing','Shipped','Delivered','Cancelled') NOT NULL DEFAULT 'Pending',
  subtotal DECIMAL(12,2) NOT NULL,
  discount DECIMAL(12,2) NOT NULL DEFAULT 0,
  tax DECIMAL(12,2) NOT NULL DEFAULT 0,
  shipping_fee DECIMAL(12,2) NOT NULL DEFAULT 0,
  total_amount DECIMAL(12,2) NOT NULL,
  address_id INT NULL,
  shipping_method VARCHAR(60) NULL,
  coupon_code VARCHAR(30) NULL,
  return_status VARCHAR(20) NULL,
  FOREIGN KEY (user_id) REFERENCES users(id),
  FOREIGN KEY (address_id) REFERENCES addresses(id) ON DELETE SET NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS order_items (
  id INT AUTO_INCREMENT PRIMARY KEY,
  order_id INT NOT NULL,
  product_id INT NULL,
  product_name VARCHAR(150) NOT NULL,
  quantity INT NOT NULL,
  unit_price DECIMAL(12,2) NOT NULL,
  FOREIGN KEY (order_id) REFERENCES orders(id) ON DELETE CASCADE,
  FOREIGN KEY (product_id) REFERENCES products(id) ON DELETE SET NULL
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS payments (
  id INT AUTO_INCREMENT PRIMARY KEY,
  order_id INT NOT NULL,
  method ENUM('Card','Cash on Delivery') NOT NULL,
  amount DECIMAL(12,2) NOT NULL,
  status ENUM('Paid','Pending','Refunded','Failed','Cancelled') NOT NULL DEFAULT 'Pending',
  paid_on DATETIME NULL,
  FOREIGN KEY (order_id) REFERENCES orders(id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS reviews (
  id INT AUTO_INCREMENT PRIMARY KEY,
  product_id INT NOT NULL,
  user_id INT NOT NULL,
  rating TINYINT NOT NULL,
  comment VARCHAR(1000) NULL,
  is_approved TINYINT(1) NOT NULL DEFAULT 0,
  created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  UNIQUE KEY uq_review (product_id, user_id),
  FOREIGN KEY (product_id) REFERENCES products(id) ON DELETE CASCADE,
  FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
) ENGINE=InnoDB;

-- In-app "email outbox" (also used when SMTP is switched off)
CREATE TABLE IF NOT EXISTS notifications (
  id INT AUTO_INCREMENT PRIMARY KEY,
  user_id INT NOT NULL,
  email VARCHAR(150) NOT NULL,
  subject VARCHAR(200) NOT NULL,
  message TEXT NOT NULL,
  created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
) ENGINE=InnoDB;

-- ---------- Sample data (the admin account is created by the app on first start) ----------
INSERT IGNORE INTO categories(id,name,parent_category_id) VALUES
 (1,'Electronics',NULL),(2,'Clothing',NULL),(3,'Books',NULL),(4,'Home & Kitchen',NULL),
 (5,'Phones',1),(6,'Laptops',1),(7,'Accessories',1),(8,'Men',2),(9,'Women',2);

INSERT IGNORE INTO brands(id,name) VALUES
 (1,'Samsung'),(2,'Apple'),(3,'HP'),(4,'Nike'),(5,'Penguin'),(6,'Tefal'),(7,'Logitech');

INSERT IGNORE INTO products(id,name,sku,description,price,stock_qty,low_stock_level,category_id,brand_id) VALUES
 (1,'Galaxy A15 Smartphone','PH-SAM-A15','6.5 inch display, 128GB storage, 50MP camera',249.99,25,5,5,1),
 (2,'iPhone 13 128GB','PH-APL-13','6.1 inch Super Retina display, A15 chip',599.00,10,3,5,2),
 (3,'HP Pavilion 15 Laptop','LP-HP-PAV15','Core i5, 16GB RAM, 512GB SSD',749.50,8,3,6,3),
 (4,'Logitech Wireless Mouse M185','AC-LOG-M185','Compact wireless mouse with long battery life',14.99,60,10,7,7),
 (5,'Nike Air Zoom Running Shoes','CL-NIK-AZ','Lightweight running shoes for men',89.90,30,5,8,4),
 (6,'Women Summer Dress','CL-GEN-SD01','Cotton floral summer dress',34.50,40,8,9,NULL),
 (7,'Learning C# - Programming Book','BK-PEN-CS01','Beginner-friendly guide to C# and .NET',29.99,50,10,3,5),
 (8,'Tefal Non-stick Frying Pan 28cm','HK-TEF-FP28','Non-stick coated pan (low-stock demo item)',24.00,4,5,4,6),
 (9,'USB-C Charging Cable 1m','AC-GEN-USBC','Fast-charging braided cable (out-of-stock demo item)',5.99,0,10,7,NULL);

INSERT IGNORE INTO coupons(code,discount_percent,expiry_date,is_active) VALUES
 ('WELCOME10',10,'2030-12-31',1),('SAVE20',20,'2030-12-31',1),('EXPIRED5',5,'2020-01-01',1);
