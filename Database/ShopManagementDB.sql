-- Creates the ShopManagementDB database, tables and stored procedures used by the app.
-- Run in SSMS (or: sqlcmd -S .\SQLEXPRESS -E -C -i ShopManagementDB.sql). Safe to re-run.

IF DB_ID('ShopManagementDB') IS NULL
    CREATE DATABASE ShopManagementDB;
GO
USE ShopManagementDB;
GO

-- ===== Tables =====
IF OBJECT_ID('dbo.Users') IS NULL
CREATE TABLE dbo.Users (
    UserID       INT IDENTITY(1,1) PRIMARY KEY,
    FullName     NVARCHAR(100) NOT NULL,
    Username     NVARCHAR(50)  NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    UserRole     NVARCHAR(30)  NOT NULL,
    CreatedAt    DATETIME      NOT NULL DEFAULT GETDATE()
);
GO

IF OBJECT_ID('dbo.Products') IS NULL
CREATE TABLE dbo.Products (
    ProductID       INT IDENTITY(1,1) PRIMARY KEY,
    ProductName     NVARCHAR(100) NOT NULL,
    Category        NVARCHAR(50)  NULL,
    UnitPrice       DECIMAL(10,2) NOT NULL,
    QuantityInStock INT           NOT NULL DEFAULT 0,
    ReorderLevel    INT           NOT NULL DEFAULT 0,
    SupplierName    NVARCHAR(100) NULL
);
GO

IF OBJECT_ID('dbo.Customers') IS NULL
CREATE TABLE dbo.Customers (
    CustomerID   INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(100) NOT NULL,
    Phone        NVARCHAR(20)  NULL,
    Email        NVARCHAR(100) NULL,
    Address      NVARCHAR(255) NULL
);
GO

IF OBJECT_ID('dbo.Employees') IS NULL
CREATE TABLE dbo.Employees (
    EmployeeID   INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName NVARCHAR(100) NOT NULL,
    Gender       NVARCHAR(10)  NULL,
    Phone        NVARCHAR(20)  NULL,
    Email        NVARCHAR(100) NULL,
    JobTitle     NVARCHAR(50)  NULL,
    Salary       DECIMAL(10,2) NOT NULL DEFAULT 0,
    HireDate     DATE          NOT NULL,
    IsActive     BIT           NOT NULL DEFAULT 1
);
GO

-- ===== Users =====
CREATE OR ALTER PROCEDURE sp_RegisterUser
    @FullName NVARCHAR(100), @Username NVARCHAR(50), @PasswordHash NVARCHAR(255), @UserRole NVARCHAR(30)
AS
BEGIN
    INSERT INTO Users (FullName, Username, PasswordHash, UserRole)
    VALUES (@FullName, @Username, @PasswordHash, @UserRole);
END
GO

CREATE OR ALTER PROCEDURE sp_LoginUser
    @Username NVARCHAR(50), @PasswordHash NVARCHAR(255)
AS
BEGIN
    SELECT UserID, FullName, Username, UserRole
    FROM Users
    WHERE Username = @Username AND PasswordHash = @PasswordHash;
END
GO

-- ===== Products =====
CREATE OR ALTER PROCEDURE sp_GetAllProducts
AS
BEGIN
    SELECT * FROM Products ORDER BY ProductID;
END
GO

CREATE OR ALTER PROCEDURE sp_AddProduct
    @ProductName NVARCHAR(100), @Category NVARCHAR(50), @UnitPrice DECIMAL(10,2),
    @QuantityInStock INT, @ReorderLevel INT, @SupplierName NVARCHAR(100)
AS
BEGIN
    INSERT INTO Products (ProductName, Category, UnitPrice, QuantityInStock, ReorderLevel, SupplierName)
    VALUES (@ProductName, @Category, @UnitPrice, @QuantityInStock, @ReorderLevel, @SupplierName);
END
GO

CREATE OR ALTER PROCEDURE sp_UpdateProduct
    @ProductID INT, @ProductName NVARCHAR(100), @Category NVARCHAR(50), @UnitPrice DECIMAL(10,2),
    @QuantityInStock INT, @ReorderLevel INT, @SupplierName NVARCHAR(100)
AS
BEGIN
    UPDATE Products
    SET ProductName = @ProductName, Category = @Category, UnitPrice = @UnitPrice,
        QuantityInStock = @QuantityInStock, ReorderLevel = @ReorderLevel, SupplierName = @SupplierName
    WHERE ProductID = @ProductID;
END
GO

CREATE OR ALTER PROCEDURE sp_DeleteProduct
    @ProductID INT
AS
BEGIN
    DELETE FROM Products WHERE ProductID = @ProductID;
END
GO

CREATE OR ALTER PROCEDURE sp_SearchProducts
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Products
    WHERE ProductName LIKE '%' + @Keyword + '%'
       OR Category LIKE '%' + @Keyword + '%'
       OR SupplierName LIKE '%' + @Keyword + '%'
    ORDER BY ProductID;
END
GO

-- ===== Customers =====
CREATE OR ALTER PROCEDURE sp_GetAllCustomers
AS
BEGIN
    SELECT * FROM Customers ORDER BY CustomerID;
END
GO

CREATE OR ALTER PROCEDURE sp_AddCustomer
    @CustomerName NVARCHAR(100), @Phone NVARCHAR(20), @Email NVARCHAR(100), @Address NVARCHAR(255)
AS
BEGIN
    INSERT INTO Customers (CustomerName, Phone, Email, Address)
    VALUES (@CustomerName, @Phone, @Email, @Address);
END
GO

CREATE OR ALTER PROCEDURE sp_UpdateCustomer
    @CustomerID INT, @CustomerName NVARCHAR(100), @Phone NVARCHAR(20), @Email NVARCHAR(100), @Address NVARCHAR(255)
AS
BEGIN
    UPDATE Customers
    SET CustomerName = @CustomerName, Phone = @Phone, Email = @Email, Address = @Address
    WHERE CustomerID = @CustomerID;
END
GO

CREATE OR ALTER PROCEDURE sp_DeleteCustomer
    @CustomerID INT
AS
BEGIN
    DELETE FROM Customers WHERE CustomerID = @CustomerID;
END
GO

CREATE OR ALTER PROCEDURE sp_SearchCustomers
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Customers
    WHERE CustomerName LIKE '%' + @Keyword + '%'
       OR Phone LIKE '%' + @Keyword + '%'
       OR Email LIKE '%' + @Keyword + '%'
    ORDER BY CustomerID;
END
GO

-- ===== Employees =====
CREATE OR ALTER PROCEDURE sp_GetAllEmployees
AS
BEGIN
    SELECT * FROM Employees ORDER BY EmployeeID;
END
GO

CREATE OR ALTER PROCEDURE sp_AddEmployee
    @EmployeeName NVARCHAR(100), @Gender NVARCHAR(10), @Phone NVARCHAR(20), @Email NVARCHAR(100),
    @JobTitle NVARCHAR(50), @Salary DECIMAL(10,2), @HireDate DATE
AS
BEGIN
    INSERT INTO Employees (EmployeeName, Gender, Phone, Email, JobTitle, Salary, HireDate)
    VALUES (@EmployeeName, @Gender, @Phone, @Email, @JobTitle, @Salary, @HireDate);
END
GO

CREATE OR ALTER PROCEDURE sp_UpdateEmployee
    @EmployeeID INT, @EmployeeName NVARCHAR(100), @Gender NVARCHAR(10), @Phone NVARCHAR(20), @Email NVARCHAR(100),
    @JobTitle NVARCHAR(50), @Salary DECIMAL(10,2), @HireDate DATE, @IsActive BIT
AS
BEGIN
    UPDATE Employees
    SET EmployeeName = @EmployeeName, Gender = @Gender, Phone = @Phone, Email = @Email,
        JobTitle = @JobTitle, Salary = @Salary, HireDate = @HireDate, IsActive = @IsActive
    WHERE EmployeeID = @EmployeeID;
END
GO

CREATE OR ALTER PROCEDURE sp_DeleteEmployee
    @EmployeeID INT
AS
BEGIN
    DELETE FROM Employees WHERE EmployeeID = @EmployeeID;
END
GO

CREATE OR ALTER PROCEDURE sp_SearchEmployees
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Employees
    WHERE EmployeeName LIKE '%' + @Keyword + '%'
       OR JobTitle LIKE '%' + @Keyword + '%'
       OR Phone LIKE '%' + @Keyword + '%'
    ORDER BY EmployeeID;
END
GO

-- ===== Default login: admin / admin123 =====
IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'admin')
    INSERT INTO Users (FullName, Username, PasswordHash, UserRole)
    VALUES ('Administrator', 'admin', 'admin123', 'Admin');
GO
