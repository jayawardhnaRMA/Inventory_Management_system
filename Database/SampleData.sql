-- Optional demo data for screenshots and the demonstration video.
-- Run after ShopManagementDB.sql. Safe to re-run: rows are only added if missing.

USE ShopManagementDB;
GO

-- Products (a few are deliberately at or below their reorder level)
INSERT INTO Products (ProductName, Category, UnitPrice, QuantityInStock, ReorderLevel, SupplierName)
SELECT v.ProductName, v.Category, v.UnitPrice, v.QuantityInStock, v.ReorderLevel, v.SupplierName
FROM (VALUES
    ('Basmati Rice 5kg',      'Grocery',     2450.00, 40, 10, 'Lanka Traders'),
    ('Sunflower Oil 1L',      'Grocery',      890.00,  6, 10, 'Ceylon Foods'),
    ('Milk Powder 400g',      'Dairy',       1150.00, 25,  8, 'Highland Dairies'),
    ('Ceylon Tea 200g',       'Beverages',    780.00, 60, 15, 'Dilmah Distributors'),
    ('Laundry Soap Bar',      'Household',    120.00,  3, 20, 'CleanCo'),
    ('Toothpaste 120g',       'Personal Care',350.00, 32, 10, 'Smile Supplies'),
    ('LED Bulb 9W',           'Electrical',   650.00,  8,  8, 'BrightLite'),
    ('Notebook A4 (Pack of 5)','Stationery',  900.00, 18,  5, 'Atlas Stationers')
) AS v (ProductName, Category, UnitPrice, QuantityInStock, ReorderLevel, SupplierName)
WHERE NOT EXISTS (SELECT 1 FROM Products p WHERE p.ProductName = v.ProductName);
GO

-- Customers
INSERT INTO Customers (CustomerName, Phone, Email, Address)
SELECT v.CustomerName, v.Phone, v.Email, v.Address
FROM (VALUES
    ('Nimal Perera',      '077-1234567', 'nimal.perera@example.com',   '12 Galle Road, Colombo 03'),
    ('Kumari Silva',      '071-2345678', 'kumari.silva@example.com',   '45 Kandy Road, Kadawatha'),
    ('Ruwan Fernando',    '076-3456789', 'ruwan.f@example.com',        '8 Temple Street, Negombo'),
    ('Fathima Rizwan',    '075-4567890', 'fathima.r@example.com',      '22 Main Street, Kandy'),
    ('Saman Jayasinghe',  '078-5678901', 'saman.j@example.com',        '3 Lake View, Kurunegala')
) AS v (CustomerName, Phone, Email, Address)
WHERE NOT EXISTS (SELECT 1 FROM Customers c WHERE c.CustomerName = v.CustomerName);
GO

-- Employees
INSERT INTO Employees (EmployeeName, Gender, Phone, Email, JobTitle, Salary, HireDate, IsActive)
SELECT v.EmployeeName, v.Gender, v.Phone, v.Email, v.JobTitle, v.Salary, v.HireDate, v.IsActive
FROM (VALUES
    ('Dilani Wickramasinghe', 'Female', '077-1112233', 'dilani@shop.example', 'Store Manager', 150000.00, '2021-03-15', 1),
    ('Kasun Rathnayake',      'Male',   '071-2223344', 'kasun@shop.example',  'Cashier',        65000.00, '2022-07-01', 1),
    ('Tharindu Bandara',      'Male',   '076-3334455', 'tharindu@shop.example','Stock Keeper',  58000.00, '2023-01-10', 1),
    ('Ishara Gunawardena',    'Female', '075-4445566', 'ishara@shop.example', 'Cashier',        62000.00, '2023-09-20', 1),
    ('Mahesh Kumara',         'Male',   '078-5556677', 'mahesh@shop.example', 'Delivery Driver',55000.00, '2020-11-05', 0)
) AS v (EmployeeName, Gender, Phone, Email, JobTitle, Salary, HireDate, IsActive)
WHERE NOT EXISTS (SELECT 1 FROM Employees e WHERE e.EmployeeName = v.EmployeeName);
GO
