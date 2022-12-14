USE [master]
GO
/****** Object:  Database [restaurant]    Script Date: 1/3/2023 10:31:47 PM ******/
CREATE DATABASE [restaurant]
GO
ALTER DATABASE [restaurant] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [restaurant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [restaurant] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [restaurant] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [restaurant] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [restaurant] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [restaurant] SET ARITHABORT OFF 
GO
ALTER DATABASE [restaurant] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [restaurant] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [restaurant] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [restaurant] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [restaurant] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [restaurant] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [restaurant] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [restaurant] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [restaurant] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [restaurant] SET  DISABLE_BROKER 
GO
ALTER DATABASE [restaurant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [restaurant] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [restaurant] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [restaurant] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [restaurant] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [restaurant] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [restaurant] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [restaurant] SET RECOVERY FULL 
GO
ALTER DATABASE [restaurant] SET  MULTI_USER 
GO
ALTER DATABASE [restaurant] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [restaurant] SET DB_CHAINING OFF 
GO
ALTER DATABASE [restaurant] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [restaurant] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [restaurant] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'restaurant', N'ON'
GO
ALTER DATABASE [restaurant] SET QUERY_STORE = OFF
GO
USE [restaurant]
GO
/****** Object:  Table [dbo].[CustOrder]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustOrder](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[OrderTotalPrice] [int] NULL,
	[OrderDate] [date] NULL,
	[OrderType] [nchar](10) NULL,
	[StaffID] [int] NULL,
	[PaymentMethod] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpecialOrder]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecialOrder](
	[orderID] [int] NOT NULL,
	[CustPhone] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_SpecialOrder] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC,
	[CustPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[searchOrderByPhone]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[searchOrderByPhone] (@phone nvarchar(11))
returns table
as
	return(
		select n.OrderId,n.OrderDate,n.OrderTotalPrice,n.OrderType from CustOrder n,SpecialOrder s where n.OrderId=s.orderID and s.CustPhone=@phone
	)
GO
/****** Object:  UserDefinedFunction [dbo].[searchOrderByType]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[searchOrderByType] (@type nvarchar(10))
returns table
as
	return(
			select * from CustOrder n where n.OrderType=@type
		)
GO
/****** Object:  Table [dbo].[Order-Meal]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order-Meal](
	[OrderId] [int] NOT NULL,
	[MealName] [nvarchar](20) NOT NULL,
	[quantity] [int] NULL,
 CONSTRAINT [PK_Order-Meal] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[MealName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[getMealsByOrdId]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[getMealsByOrdId] (@id int)
returns table
as
	return(
			select n.MealName,n.quantity from [Order-Meal] n where n.OrderId=@id
		)
	
GO
/****** Object:  Table [dbo].[Meal]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meal](
	[MealName] [nvarchar](20) NOT NULL,
	[mealType] [nvarchar](20) NULL,
	[mealPrice] [int] NULL,
	[mealDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Meal] PRIMARY KEY CLUSTERED 
(
	[MealName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[showAllMealsNames]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[showAllMealsNames]
as
	select MealName from Meal
GO
/****** Object:  View [dbo].[showAllMeals]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[showAllMeals]
as
	select * from Meal
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[PhNumber] [nvarchar](11) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[City] [nvarchar](20) NULL,
	[Street] [nvarchar](30) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[PhNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[findCust]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[findCust]( @phone nvarchar(11))
returns table
as
	return(select * from Customer where PhNumber=@phone)
	

GO
/****** Object:  UserDefinedFunction [dbo].[searchOrderByDate]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[searchOrderByDate] (@dat Date)
returns table
as
	return(
		select * from CustOrder where OrderDate=@dat
	)
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffId] [int] IDENTITY(1,1) NOT NULL,
	[StaffName] [nvarchar](50) NULL,
	[StaffPassword] [int] NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_City]  DEFAULT ('Cairo') FOR [City]
GO
ALTER TABLE [dbo].[CustOrder]  WITH CHECK ADD  CONSTRAINT [FK_CustOrder_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffId])
GO
ALTER TABLE [dbo].[CustOrder] CHECK CONSTRAINT [FK_CustOrder_Staff]
GO
ALTER TABLE [dbo].[Order-Meal]  WITH CHECK ADD  CONSTRAINT [FK_Order-Meal_Meal] FOREIGN KEY([MealName])
REFERENCES [dbo].[Meal] ([MealName])
GO
ALTER TABLE [dbo].[Order-Meal] CHECK CONSTRAINT [FK_Order-Meal_Meal]
GO
ALTER TABLE [dbo].[Order-Meal]  WITH CHECK ADD  CONSTRAINT [FK_Order-Meal_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[CustOrder] ([OrderId])
GO
ALTER TABLE [dbo].[Order-Meal] CHECK CONSTRAINT [FK_Order-Meal_Order]
GO
ALTER TABLE [dbo].[SpecialOrder]  WITH CHECK ADD  CONSTRAINT [FK_SpecialOrder_Customer] FOREIGN KEY([CustPhone])
REFERENCES [dbo].[Customer] ([PhNumber])
GO
ALTER TABLE [dbo].[SpecialOrder] CHECK CONSTRAINT [FK_SpecialOrder_Customer]
GO
ALTER TABLE [dbo].[SpecialOrder]  WITH CHECK ADD  CONSTRAINT [FK_SpecialOrder_Order] FOREIGN KEY([orderID])
REFERENCES [dbo].[CustOrder] ([OrderId])
GO
ALTER TABLE [dbo].[SpecialOrder] CHECK CONSTRAINT [FK_SpecialOrder_Order]
GO
ALTER TABLE [dbo].[Meal]  WITH CHECK ADD  CONSTRAINT [mealTypes] CHECK  (([mealType]='Drinks' OR [mealType]='Dinner' OR [mealType]='Lunch' OR [mealType]='Breakfast'))
GO
ALTER TABLE [dbo].[Meal] CHECK CONSTRAINT [mealTypes]
GO
/****** Object:  StoredProcedure [dbo].[addCustomer]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addCustomer] @phone nvarchar(11), @name nvarchar(30), @city nvarchar(20), @street nvarchar(30),@y int out
as
	if exists (select * from Customer where PhNumber=@phone)
		set @y=0;
	else 
		begin
			insert into Customer(PhNumber,Name,City,Street)
			values(@phone,@name,@city,@street)
			set @y=1;
		end
GO
/****** Object:  StoredProcedure [dbo].[addDeliveryOrder]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addDeliveryOrder]  @totalprice int,@CustPhone nvarchar(11),@staffID int,@y int out
as
		begin
			set @y=0;
			insert into CustOrder(OrderTotalPrice,OrderDate,OrderType,StaffID,PaymentMethod)
			values(@totalprice,GETDATE(),'Delivery',@staffID,'Cash');
			
			set @y=(select top 1 OrderId
					from CustOrder
					order by OrderId desc)

			insert into SpecialOrder
			values( @y,@CustPhone)
		end
GO
/****** Object:  StoredProcedure [dbo].[addNormalOrder]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addNormalOrder]  @totalprice int,@staffID int,@pay nvarchar(20),@y int out
as
		begin
			insert into CustOrder(OrderTotalPrice,OrderDate,OrderType,StaffID,PaymentMethod)
			values(@totalprice,GETDATE(),'Normal',@staffID,@pay);
			set @y=0
			set @y=(select top 1 OrderId
					from CustOrder
					order by OrderId desc)
		end
GO
/****** Object:  StoredProcedure [dbo].[addOnlineOrder]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addOnlineOrder]  @totalprice int,@CustPhone nvarchar(11),@staffID int,@pay nvarchar(20),@y int out
as
		begin
			set @y=0;
			insert into CustOrder(OrderTotalPrice,OrderDate,OrderType,StaffID,PaymentMethod)
			values(@totalprice,GETDATE(),'Online',@staffID,@pay);
			
			set @y=(select top 1 OrderId
					from CustOrder
					order by OrderId desc)

			insert into SpecialOrder
			values( @y,@CustPhone)
		end
GO
/****** Object:  StoredProcedure [dbo].[addOrderMeal]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addOrderMeal] @orderId int, @mealname varchar(20),@quant int, @y int output
as
	declare @x int;
	select @x=OrderId from CustOrder where OrderId=@orderId
	if (@x is null)---order doesn't exist
		set @y =0  --fail
	else
		begin
		insert into [Order-Meal]
		values(@orderId,@mealname,@quant)
		set @y=1
		end
GO
/****** Object:  StoredProcedure [dbo].[addStaff]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[addStaff]  @name nvarchar(50) ,@password int,@y int out
as
		begin
			
			if exists (select StaffId from Staff where Staffname=@name and StaffPassword=@password)
				set @y=-1
			else
				begin
				insert into Staff(StaffName,StaffPassword)
				values(@name,@password)
				set @y=(select top 1 StaffId
					from Staff
					order by StaffId desc);
				end
				
		end
GO
/****** Object:  StoredProcedure [dbo].[check_admin]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[check_admin] @username varchar(10), @pass varchar(10) , @check int out
as
	if (@username='sara' and @pass='1')	
		 set @check=1;	
	else
		 set @check =0;

GO
/****** Object:  StoredProcedure [dbo].[check_meal]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[check_meal] @mealname varchar(20), @check int out
as
	if exists( select MealName from Meal where MealName=@mealname)
		set @check =1
	else set @check=0;

		
GO
/****** Object:  StoredProcedure [dbo].[insert_meal]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insert_meal] @mealname nvarchar(20),@mealType nvarchar(20),@price int,@desc nvarchar(100),@y int out
as
	
	declare @x int;
	exec check_meal @mealname, @x output;
	if (@x=1)
		set @y =0 ---meal name already exitst
	else
		begin
			insert into Meal
			values(@mealname,@mealType,@price,@desc)
			set @y=1;
		end
GO
/****** Object:  StoredProcedure [dbo].[remove_meal]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[remove_meal] @mealname nvarchar(20),@y int out
as
	
	declare @x int;
	exec check_meal @mealname, @x output;
	if (@x=0)
		set @y =0 ---meal name doesn't exist
	else
		begin
			delete from Meal
			where MealName=@mealname;
			set @y=1;
		end
GO
/****** Object:  StoredProcedure [dbo].[removeStaff]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[removeStaff] @name nvarchar(50) ,@password int,@y int out
as
		begin
			set @y=1;
			if not exists (select StaffId from Staff where Staffname=@name and StaffPassword=@password)
				set @y=0
			else 
				delete from Staff
				where Staffname=@name and StaffPassword=@password
		end
GO
/****** Object:  StoredProcedure [dbo].[update_meal]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[update_meal] @mealname nvarchar(20),@mealType nvarchar(20),@price int,@desc nvarchar(100),@y int out
as
	
	declare @x int;
	exec check_meal @mealname, @x output;
	if (@x=0)---meal name doesn't exist
		set @y =0  --fail
	else
		begin
			update Meal
			set mealType=@mealType, mealDescription=@desc,mealPrice=@price
			where MealName=@mealname;

			set @y=1;
		end
GO
/****** Object:  StoredProcedure [dbo].[valid_staff]    Script Date: 1/3/2023 10:31:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[valid_staff]  @name nvarchar(50) ,@password int,@y int out
as
		begin
			
			set @y=-1;
			select  @y=StaffId from Staff where Staffname=@name and StaffPassword=@password
	      
		end
GO
USE [master]
GO
ALTER DATABASE [restaurant] SET  READ_WRITE 
GO
