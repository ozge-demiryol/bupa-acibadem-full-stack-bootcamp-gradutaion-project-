USE [master]
GO
/****** Object:  Database [Health_Insurance_Db]    Script Date: 14.02.2022 03:55:10 ******/
CREATE DATABASE [Health_Insurance_Db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Health_Insurance_Db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Health_Insurance_Db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Health_Insurance_Db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Health_Insurance_Db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Health_Insurance_Db] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Health_Insurance_Db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Health_Insurance_Db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET ARITHABORT OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Health_Insurance_Db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Health_Insurance_Db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Health_Insurance_Db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Health_Insurance_Db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Health_Insurance_Db] SET  MULTI_USER 
GO
ALTER DATABASE [Health_Insurance_Db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Health_Insurance_Db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Health_Insurance_Db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Health_Insurance_Db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Health_Insurance_Db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Health_Insurance_Db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Health_Insurance_Db] SET QUERY_STORE = OFF
GO
USE [Health_Insurance_Db]
GO
/****** Object:  Table [dbo].[PaymentTypes]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTypes](
	[paymentId] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[paymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[detailId] [int] IDENTITY(1,1) NOT NULL,
	[customerId] [int] NOT NULL,
	[statusId] [int] NOT NULL,
	[paymentId] [int] NOT NULL,
	[cardId] [int] NOT NULL,
	[orderId] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[detailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[statusId] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](250) NULL,
 CONSTRAINT [PK_OrderStatus] PRIMARY KEY CLUSTERED 
(
	[statusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customerId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](40) NOT NULL,
	[surname] [nvarchar](40) NOT NULL,
	[identityNo] [char](11) NOT NULL,
	[birthDate] [date] NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[phone] [char](10) NOT NULL,
	[gender] [nvarchar](20) NOT NULL,
	[address] [nvarchar](250) NOT NULL,
	[cityId] [int] NOT NULL,
	[regionId] [int] NOT NULL,
	[height] [int] NOT NULL,
	[weight] [int] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[customerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Applications]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Applications] as 
SELECT dbo.Customers.identityNo, dbo.Customers.name, dbo.Customers.surname, dbo.PaymentTypes.title, dbo.OrderStatus.title AS status
FROM     dbo.Customers INNER JOIN
                  dbo.OrderDetails ON dbo.Customers.customerId = dbo.OrderDetails.customerId INNER JOIN
                  dbo.OrderStatus ON dbo.OrderDetails.statusId = dbo.OrderStatus.statusId INNER JOIN
                  dbo.PaymentTypes ON dbo.OrderDetails.paymentId = dbo.PaymentTypes.paymentId
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[orderId] [int] IDENTITY(1,1) NOT NULL,
	[customerId] [int] NOT NULL,
	[policyId] [int] NOT NULL,
	[createdAt] [date] NOT NULL,
	[paymentId] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[orderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Policies]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Policies](
	[policyId] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](250) NULL,
	[price] [money] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[policyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Orders_Customers]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[Orders_Customers] as 
SELECT dbo.Customers.identityNo, dbo.Customers.name, dbo.Customers.surname, dbo.Policies.title, dbo.Policies.price, dbo.PaymentTypes.title AS paymentType, dbo.Orders.createdAt
FROM     dbo.Customers INNER JOIN
                  dbo.Orders ON dbo.Customers.customerId = dbo.Orders.customerId INNER JOIN
                  dbo.Policies ON dbo.Orders.policyId = dbo.Policies.policyId INNER JOIN
                  dbo.PaymentTypes ON dbo.Orders.paymentId = dbo.PaymentTypes.paymentId
GO
/****** Object:  Table [dbo].[Cities]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[cityId] [int] NOT NULL,
	[cityName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[cityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CreditCards]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCards](
	[cardId] [int] NOT NULL,
	[cardNumber] [char](16) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[expDate] [date] NOT NULL,
	[cvv] [char](4) NOT NULL,
 CONSTRAINT [PK_CreditCards] PRIMARY KEY CLUSTERED 
(
	[cardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regions]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regions](
	[regionId] [int] IDENTITY(1,1) NOT NULL,
	[regionName] [nvarchar](100) NOT NULL,
	[cityId] [int] NOT NULL,
 CONSTRAINT [PK_Regions] PRIMARY KEY CLUSTERED 
(
	[regionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Cities1] FOREIGN KEY([cityId])
REFERENCES [dbo].[Cities] ([cityId])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customer_Cities1]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Regions] FOREIGN KEY([regionId])
REFERENCES [dbo].[Regions] ([regionId])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Regions]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_CreditCards] FOREIGN KEY([cardId])
REFERENCES [dbo].[CreditCards] ([cardId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_CreditCards]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([orderId])
REFERENCES [dbo].[Orders] ([orderId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_OrderStatus] FOREIGN KEY([statusId])
REFERENCES [dbo].[OrderStatus] ([statusId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_OrderStatus]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_PaymentTypes] FOREIGN KEY([paymentId])
REFERENCES [dbo].[PaymentTypes] ([paymentId])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_PaymentTypes]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([customerId])
REFERENCES [dbo].[Customers] ([customerId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Regions]  WITH CHECK ADD  CONSTRAINT [FK_Regions_Cities] FOREIGN KEY([cityId])
REFERENCES [dbo].[Cities] ([cityId])
GO
ALTER TABLE [dbo].[Regions] CHECK CONSTRAINT [FK_Regions_Cities]
GO
/****** Object:  StoredProcedure [dbo].[AddCustomer]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE SelectACity @cityId char(2)
--AS
--SELECT * FROM Cities WHERE cityId = @cityId
--GO;

--exec SelectACity @cityId = 34;

--CREATE PROCEDURE SelectRegionByCityId @cityId char(2)
--AS
--SELECT * FROM Regions WHERE cityId = @cityId

--CREATE PROCEDURE GetAllCustomers 
--AS
--SELECT * FROM Customers 

--exec GetAllCustomers

--CREATE PROCEDURE GetCustomersById @customerId int
--AS
--SELECT * FROM Customers WHERE customerId = @customerId

--exec GetCustomersById @customerId = 4

--CREATE PROCEDURE GetAllProducts 
--AS
--SELECT * FROM Products 

CREATE PROCEDURE [dbo].[AddCustomer](@customerId int, @name nvarchar(40), @surname nvarchar(40), @email nvarchar(100), @phone char(11), @address nvarchar(250), @birthDate date, @cityId char(2), @regionId int, @identityNo char(11), @gender nvarchar(20), @height int, @weight int)
AS
BEGIN
insert Customers(customerId, name, surname, email, phone, address, birthDate, cityId, regionId, identityNo, gender, height, weight) values(@customerId, @name, @surname, @email, @phone, @address, @birthDate, @cityId, @regionId, @identityNo, @gender, @height, @weight)
end
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE SelectACity @cityId char(2)
--AS
--SELECT * FROM Cities WHERE cityId = @cityId
--GO;

--exec SelectACity @cityId = 34;

--CREATE PROCEDURE SelectRegionByCityId @cityId char(2)
--AS
--SELECT * FROM Regions WHERE cityId = @cityId

--CREATE PROCEDURE GetAllCustomers 
--AS
--SELECT * FROM Customers 

--exec GetAllCustomers

--CREATE PROCEDURE GetCustomersById @customerId int
--AS
--SELECT * FROM Customers WHERE customerId = @customerId

--exec GetCustomersById @customerId = 4

--CREATE PROCEDURE GetAllProducts 
--AS
--SELECT * FROM Products 

--CREATE PROCEDURE AddCustomer(@customerId int, @name nvarchar(40), @surname nvarchar(40), @email nvarchar(100), @phone char(11), @address nvarchar(250), @birthDate date, @cityId char(2), @regionId int, @identityNo char(11), @gender nvarchar(20), @height int, @weight int)
--AS
--BEGIN
--insert Customers(customerId, name, surname, email, phone, address, birthDate, cityId, regionId, identityNo, gender, height, weight) values(@customerId, @name, @surname, @email, @phone, @address, @birthDate, @cityId, @regionId, @identityNo, @gender, @height, @weight)
--end

CREATE PROC [dbo].[AddProduct](@productId int, @title nvarchar(250), @price money)
as
begin
insert into Products (productId, title, price) values (@productId, @title, @price )
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE SelectACity @cityId char(2)
--AS
--SELECT * FROM Cities WHERE cityId = @cityId
--GO;

--exec SelectACity @cityId = 34;

--CREATE PROCEDURE SelectRegionByCityId @cityId char(2)
--AS
--SELECT * FROM Regions WHERE cityId = @cityId

--CREATE PROCEDURE GetAllCustomers 
--AS
--SELECT * FROM Customers 

--exec GetAllCustomers

--CREATE PROCEDURE GetCustomersById @customerId int
--AS
--SELECT * FROM Customers WHERE customerId = @customerId

--exec GetCustomersById @customerId = 4

--CREATE PROCEDURE GetAllProducts 
--AS
--SELECT * FROM Products 

--CREATE PROCEDURE AddCustomer(@customerId int, @name nvarchar(40), @surname nvarchar(40), @email nvarchar(100), @phone char(11), @address nvarchar(250), @birthDate date, @cityId char(2), @regionId int, @identityNo char(11), @gender nvarchar(20), @height int, @weight int)
--AS
--BEGIN
--insert Customers(customerId, name, surname, email, phone, address, birthDate, cityId, regionId, identityNo, gender, height, weight) values(@customerId, @name, @surname, @email, @phone, @address, @birthDate, @cityId, @regionId, @identityNo, @gender, @height, @weight)
--end

--CREATE PROC AddProduct(@productId int, @title nvarchar(250), @price money)
--as
--begin
--insert Products (productId, title, price) values (@productId, @title, @price)
--end

--create proc UpdateProduct(@productId int, @title nvarchar(250), @price money)
--as
--BEGIN
--    UPDATE Products
--    SET    title = @title,
--            price = @price
--    WHERE  productId = @productId
--END

create proc [dbo].[DeleteProduct](@productId int)
as
BEGIN
    DELETE FROM Products
    WHERE  productId = @productId
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllCities]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetAllCities]
AS
BEGIN
select * from Cities
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllCustomers]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE SelectACity @cityId char(2)
--AS
--SELECT * FROM Cities WHERE cityId = @cityId
--GO;

--exec SelectACity @cityId = 34;

--CREATE PROCEDURE SelectRegionByCityId @cityId char(2)
--AS
--SELECT * FROM Regions WHERE cityId = @cityId

CREATE PROCEDURE [dbo].[GetAllCustomers] 
AS
SELECT * FROM Customers 
GO
/****** Object:  StoredProcedure [dbo].[GetAllProducts]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE SelectACity @cityId char(2)
--AS
--SELECT * FROM Cities WHERE cityId = @cityId
--GO;

--exec SelectACity @cityId = 34;

--CREATE PROCEDURE SelectRegionByCityId @cityId char(2)
--AS
--SELECT * FROM Regions WHERE cityId = @cityId

--CREATE PROCEDURE GetAllCustomers 
--AS
--SELECT * FROM Customers 

--exec GetAllCustomers

--CREATE PROCEDURE GetCustomersById @customerId int
--AS
--SELECT * FROM Customers WHERE customerId = @customerId

--exec GetCustomersById @customerId = 4

CREATE PROCEDURE [dbo].[GetAllProducts] 
AS
SELECT * FROM Products  
GO
/****** Object:  StoredProcedure [dbo].[GetAllRegions]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE SelectACity @cityId char(2)
--AS
--SELECT * FROM Cities WHERE cityId = @cityId
--GO;

--exec SelectACity @cityId = 34;

--CREATE PROCEDURE SelectRegionByCityId @cityId char(2)
--AS
--SELECT * FROM Regions WHERE cityId = @cityId

CREATE PROCEDURE [dbo].[GetAllRegions]
AS
SELECT * FROM Regions
GO
/****** Object:  StoredProcedure [dbo].[GetCity]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCity] @cityId char(2)
AS
SELECT * FROM Cities WHERE cityId = @cityId
--GO;
GO
/****** Object:  StoredProcedure [dbo].[GetCustomersById]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE SelectACity @cityId char(2)
--AS
--SELECT * FROM Cities WHERE cityId = @cityId
--GO;

--exec SelectACity @cityId = 34;

--CREATE PROCEDURE SelectRegionByCityId @cityId char(2)
--AS
--SELECT * FROM Regions WHERE cityId = @cityId

--CREATE PROCEDURE GetAllCustomers 
--AS
--SELECT * FROM Customers 

--exec GetAllCustomers

CREATE PROCEDURE [dbo].[GetCustomersById] @customerId int
AS
SELECT * FROM Customers WHERE customerId = @customerId
GO
/****** Object:  StoredProcedure [dbo].[GetRegionByCityId]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE SelectACity @cityId char(2)
--AS
--SELECT * FROM Cities WHERE cityId = @cityId
--GO;

--exec SelectACity @cityId = 34;

CREATE PROCEDURE [dbo].[GetRegionByCityId] @cityId char(2)
AS
SELECT * FROM Regions WHERE cityId = @cityId
GO
/****** Object:  StoredProcedure [dbo].[UpdateProduct]    Script Date: 14.02.2022 03:55:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CREATE PROCEDURE SelectACity @cityId char(2)
--AS
--SELECT * FROM Cities WHERE cityId = @cityId
--GO;

--exec SelectACity @cityId = 34;

--CREATE PROCEDURE SelectRegionByCityId @cityId char(2)
--AS
--SELECT * FROM Regions WHERE cityId = @cityId

--CREATE PROCEDURE GetAllCustomers 
--AS
--SELECT * FROM Customers 

--exec GetAllCustomers

--CREATE PROCEDURE GetCustomersById @customerId int
--AS
--SELECT * FROM Customers WHERE customerId = @customerId

--exec GetCustomersById @customerId = 4

--CREATE PROCEDURE GetAllProducts 
--AS
--SELECT * FROM Products 

--CREATE PROCEDURE AddCustomer(@customerId int, @name nvarchar(40), @surname nvarchar(40), @email nvarchar(100), @phone char(11), @address nvarchar(250), @birthDate date, @cityId char(2), @regionId int, @identityNo char(11), @gender nvarchar(20), @height int, @weight int)
--AS
--BEGIN
--insert Customers(customerId, name, surname, email, phone, address, birthDate, cityId, regionId, identityNo, gender, height, weight) values(@customerId, @name, @surname, @email, @phone, @address, @birthDate, @cityId, @regionId, @identityNo, @gender, @height, @weight)
--end

--CREATE PROC AddProduct(@productId int, @title nvarchar(250), @price money)
--as
--begin
--insert Products (productId, title, price) values (@productId, @title, @price)
--end

create proc [dbo].[UpdateProduct](@productId int, @title nvarchar(250), @price money)
as
BEGIN
    UPDATE Products
    SET    title = @title,
            price = @price
    WHERE  productId = @productId
END
GO
USE [master]
GO
ALTER DATABASE [Health_Insurance_Db] SET  READ_WRITE 
GO
