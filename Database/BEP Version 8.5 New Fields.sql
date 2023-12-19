
/****** Version 2.2 ******/

USE [BizPro]
GO

/****** Object:  Table [dbo].[Unit Information]    Script Date: 7/17/2018 10:24:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Unit Information](
	[Unit ID] [int] IDENTITY(1,1) NOT NULL,
	[Unit Name] [nvarchar](50) NOT NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Branch ID] [int] NULL,
	[Computer ID] [int] NULL,
	[User Account ID] [int] NULL,
 CONSTRAINT [PK_Unit Information] PRIMARY KEY CLUSTERED 
(
	[Unit ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


/****** Create Field to Products ******/

ALTER TABLE Products ADD [Unit ID] Int NULL ;

/****** Create Field to Sale Invoice ******/

ALTER TABLE [Sale Invoice] ADD [Remarks] Nvarchar(Max) NULL ;

/****** Create Field to Chart Of Account ******/

Alter Table [Chart Of Account] ADD [Transaction Limit] Money Null ;


/****** Create Field to Employee information ******/

Alter Table [Employee information] ADD [Chart of Account ID] Nvarchar(50) Null;


/****** Create Field to Bank Information ******/
Alter table [Bank Information] ADD [Chart of Account ID] Nvarchar(50) Null;



/****** Create Field to Ledger ******/
Alter table [Ledger] ADD [Pending Invoice] Nvarchar(50) Null;
Alter table [Ledger] ADD [Ledger Invoice ID 2] Nvarchar(50) Null;




/****** Object:  Table [dbo].[Ledger Invoice 2]    Script Date: 9/8/2018 11:40:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ledger Invoice 2](
	[Ledger Invoice ID 2] [bigint] IDENTITY(1,1) NOT NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[User Account ID] [int] NULL,
	[Computer ID] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[Chart of Account ID] [nvarchar](50) NULL,
	[Ledger Date] [date] NULL,
	[Branch ID] [int] NULL,



 CONSTRAINT [PK_Ledger Invoice 2] PRIMARY KEY CLUSTERED 
(
	[Ledger Invoice ID 2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [BizPro]
GO



/******Version 7.06  [Warranty portion] ******/



/****** Object:  Table [dbo].[Warranty]    Script Date: 12/5/2018 12:44:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Warranty](
	[Warranty ID] [int] IDENTITY(1,1) NOT NULL,
	[Warranty Invoice No] [nvarchar](50) NOT NULL,
	[Product ID] [int] NOT NULL,
	[Warranty Quantity] [decimal](10, 2) NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Branch ID] [int] NULL,
	[Computer ID] [int] NULL,
	[User Account ID] [int] NULL,
 CONSTRAINT [PK_Warranty] PRIMARY KEY CLUSTERED 
(
	[Warranty ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


USE [BizPro]
GO

/****** Object:  Table [dbo].[Warranty Delivery]    Script Date: 12/5/2018 12:44:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Warranty Delivery](
	[Warranty Delivery ID] [int] IDENTITY(1,1) NOT NULL,
	[Warranty Delivery Invoice No] [nvarchar](50) NOT NULL,
	[Product ID] [int] NOT NULL,
	[Delivery Quantity] [decimal](10, 2) NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Branch ID] [int] NULL,
	[Computer ID] [int] NULL,
	[User Account ID] [int] NULL,
 CONSTRAINT [PK_Warranty Delivery] PRIMARY KEY CLUSTERED 
(
	[Warranty Delivery ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [BizPro]
GO

/****** Object:  Table [dbo].[Warranty Delivery Invoice]    Script Date: 12/5/2018 12:44:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Warranty Delivery Invoice](
	[Warranty Delivery Invoice No] [int] IDENTITY(1,1) NOT NULL,
	[Warranty Invoice No] [int] NOT NULL,
	[Delivery Date] [date] NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Branch ID] [int] NULL,
	[Computer ID] [int] NULL,
	[User Account ID] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[Remarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_Warranty Delivery Invoice] PRIMARY KEY CLUSTERED 
(
	[Warranty Delivery Invoice No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [BizPro]
GO

/****** Object:  Table [dbo].[Warranty Delivery Serial]    Script Date: 12/5/2018 12:45:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Warranty Delivery Serial](
	[Delivery Serial ID] [int] IDENTITY(1,1) NOT NULL,
	[Warranty Delivery Invoice No] [nvarchar](50) NULL,
	[Product ID] [int] NOT NULL,
	[Delivery Serial Number] [nvarchar](50) NOT NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Branch ID] [int] NULL,
	[Computer ID] [int] NULL,
	[User Account ID] [int] NULL,
	[Replacement Product ID] [int] NULL,
	[Replacement Serial Number] [nvarchar](50) NULL,
 CONSTRAINT [PK_Delivery Serial] PRIMARY KEY CLUSTERED 
(
	[Delivery Serial ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [BizPro]
GO

/****** Object:  Table [dbo].[Warranty Invoice Number]    Script Date: 12/5/2018 12:45:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Warranty Invoice Number](
	[Warranty Invoice No] [int] IDENTITY(1,1) NOT NULL,
	[Customer ID] [int] NULL,
	[Complainer Name] [nvarchar](50) NULL,
	[Complainer Mobile No] [nvarchar](50) NULL,
	[Address] [nvarchar](max) NULL,
	[Received Date] [date] NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Branch ID] [int] NULL,
	[Computer ID] [int] NULL,
	[User Account ID] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[Remarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_Warranty Invoice Number] PRIMARY KEY CLUSTERED 
(
	[Warranty Invoice No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [BizPro]
GO

/****** Object:  Table [dbo].[Warranty Problem Details]    Script Date: 12/5/2018 12:45:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Warranty Problem Details](
	[Warranty Problem ID] [int] IDENTITY(1,1) NOT NULL,
	[Product ID] [int] NULL,
	[Problem ID] [int] NOT NULL,
	[Warranty Serial ID] [int] NOT NULL,
	[Warranty Invoice No] [nvarchar](50) NOT NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Branch ID] [int] NULL,
	[Computer ID] [int] NULL,
	[User Account ID] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[Remarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_Warranty Problem Details] PRIMARY KEY CLUSTERED 
(
	[Warranty Problem ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [BizPro]
GO

/****** Object:  Table [dbo].[Warranty Serial]    Script Date: 12/5/2018 12:45:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Warranty Serial](
	[Warranty Serial ID] [int] IDENTITY(1,1) NOT NULL,
	[Warranty Invoice No] [nvarchar](50) NULL,
	[Product ID] [int] NOT NULL,
	[Warranty Serial Number] [nvarchar](50) NOT NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Branch ID] [int] NULL,
	[Computer ID] [int] NULL,
	[User Account ID] [int] NULL,
	[Received Item] [nvarchar](max) NULL,
	[Delivery Date] [date] NULL,
 CONSTRAINT [PK_Warranty Serial Number] PRIMARY KEY CLUSTERED 
(
	[Warranty Serial ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [BizPro]
GO

/****** Object:  Table [dbo].[Problem Category]    Script Date: 12/5/2018 12:45:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Problem Category](
	[Problem Category ID] [int] IDENTITY(1,1) NOT NULL,
	[Problem Category Name] [nvarchar](max) NULL,
	[User Account ID] [int] NULL,
	[Computer ID] [int] NULL,
	[Current Date] [date] NULL,
	[Current Time] [time](7) NULL,
	[Branch ID] [int] NULL,
 CONSTRAINT [PK_Problem Category] PRIMARY KEY CLUSTERED 
(
	[Problem Category ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO




/****** Version 7.7 ******/


/****** New field add to purchase ******/
Alter table [purchase] ADD [Transfer Status] Nvarchar(50) Null;



/****** Version 7.9 ******/


/****** New field add to purchase ******/
Alter table [Sale Serial Number] ADD [Sale ID] int Null;


/****** Version 8.2 ******/

USE [BizPro]
GO
/****** Object:  Table [dbo].[All Permission]    Script Date: 3/16/2019 4:51:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[All Permission](
	[Permission ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_All Permission] PRIMARY KEY CLUSTERED 
(
	[Permission ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[All Permission] ON 

INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (3, N'COMPUTER ACCOUNT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (4, N'CUSTOMER CATEGORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (5, N'CUSTOMER INFORMATION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (6, N'COLLECTION/PAYMENT HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (7, N'EMPLOYEE SALARY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (8, N'EMPLOYEE ATTENDANCE DETAILS')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (9, N'EMPLOYEE INFORMATION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (10, N'LEDGER')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (11, N'LEDGER DETAILS')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (12, N'LANGUAGE INFORMATION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (13, N'LOCATION INFORMATION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (14, N'LOG DETAILS')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (15, N'PAYMENT METHOD')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (16, N'PERMISSION SETUP')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (17, N'PRODUCT CATEGORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (18, N'PRODUCT SUBCATEGORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (19, N'PRODUCT GROUP')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (20, N'PRODUCT INFORMATION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (21, N'PRODUCT TRANSFER')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (22, N'PRODUCT TRANSFER HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (23, N'PURCHASE')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (24, N'PURCHASE HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (25, N'PURCHASE RETURN')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (26, N'PURCHASE RETURN HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (27, N'PROBLEM DETAILS')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (28, N'PRODUCT LIFE CYCLE')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (29, N'QUOTATIONS')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (30, N'QUOTATION HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (31, N'SALE')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (32, N'SALE HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (33, N'SALE RETURN')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (34, N'SALE RETURN HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (35, N'SEARCH')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (36, N'SERVICES')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (37, N'SMS NOTICE BOARD')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (38, N'SUMMARY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (39, N'SUPPLIER CATEGORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (40, N'SUPPLIER INFORMATION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (41, N'TO DO LIST')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (42, N'USER ACCOUNT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (43, N'UNIT INFORMATION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (44, N'VIEW TO DO LIST')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (45, N'VOUCHER')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (46, N'VOUCHER HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (47, N'VOUCHER PURPOSE')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (48, N'VOUCHER SUBCATEGORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (49, N'WARRANTY LOOK UP')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (50, N'WARRANTY HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (51, N'WARRANTY DELIVERY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (52, N'WARRANTY DELIVERY HISTORY')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (53, N'WARRANTY PROCESSING')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (54, N'CHART OF ACCOUNT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (55, N'HEAD OF ACCOUNT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (56, N'COLLECTION/PAYMENT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (57, N'SERVER INFORMATION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (58, N'LEDGER REPORT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (59, N'CHECK PROCESSING')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (60, N'STOCK REPORT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (61, N'SALE REPORT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (62, N'CASH FLOW REPORT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (63, N'ACCOUNTS RECEIVABLE / PAYABLE')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (64, N'BACKUP')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (65, N'RESTORE')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (66, N'VIEW PRICE PERMISSION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (67, N'VIEW SUPPLIER PERMISSION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (68, N'VIEW ALL BRANCH CHECK PERMISSION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (69, N'LEDGER COLLECTION')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (70, N'LEDGER PAYMENT')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (71, N'LEDGER EXPENSE')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (73, N'LEDGER TRANSFER')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (74, N'LEDGER DETAILS')
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (75, N'LEDGER DETAILS')
SET IDENTITY_INSERT [dbo].[All Permission] OFF




/****** Version 8.4 ******/


/****** New field add to sale ******/
Alter table [sale] ADD [Bonus Status] Nvarchar(50) Null;




/****** Object:  Table [dbo].[Customer Comments]    Script Date: 4/3/2019 12:15:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer Comments](
	[Comment ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer ID] [int] NOT NULL,
	[Comment] [nvarchar](max) NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Device Details] [nvarchar](max) NULL,
	[User Account ID] [int] NULL,
	[Comment Date] [date] NULL,
 CONSTRAINT [PK_Customer Comments] PRIMARY KEY CLUSTERED 
(
	[Comment ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO



/****** Create Field to Product Group ******/

ALTER TABLE [Product Group] ADD [User Account ID] Int NULL ;
ALTER TABLE [Product Group] ADD [Computer ID] Int NULL ;

/****** Create Field to Product category ******/

ALTER TABLE [Product category] ADD [User Account ID] Int NULL ;
ALTER TABLE [Product category] ADD [Computer ID] Int NULL ;

/****** Create Field to Product Subcategory ******/

ALTER TABLE [Product Subcategory] ADD [User Account ID] Int NULL ;
ALTER TABLE [Product Subcategory] ADD [Computer ID] Int NULL ;

/****** Create Field to SMS Notice Board ******/

ALTER TABLE [SMS Notice Board] ADD [Customer ID] Int NULL ;





/****** Online SMS Service  ******/



/****** Object:  Table [dbo].[SMS Notice Board]    Script Date: 5/7/2019 2:32:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SMS Notice Board](
	[SMS ID] [int] IDENTITY(1,1) NOT NULL,
	[Company Name] [nvarchar](max) NULL,
	[SMS Description] [nvarchar](max) NULL,
	[Send Date] [date] NULL,
	[Send Time] [time](7) NULL,
	[User Account ID] [int] NULL,
	[Computer ID] [int] NULL,
	[Prepared date] [date] NULL,
	[Prepared Time] [time](7) NULL,
	[Status] [nvarchar](50) NULL,
	[SMS Number] [nvarchar](50) NULL,
	[Delivery Date] [date] NULL,
	[Delivery Time] [time](7) NULL,
	[Mobile No] [nvarchar](50) NULL,
	[Teacher ID] [int] NULL,
 CONSTRAINT [PK_SMS Notice Board] PRIMARY KEY CLUSTERED 
(
	[SMS ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO



/***** Create Field to Log*****/
Alter Table [Log Details] Add [Form Name] Nvarchar(50)




/***** Create Field to Branch Information*****/
Alter Table [Branch Information] Add [User Account ID] int
Alter Table [Branch Information] Add [Computer ID] int



/***** Create Field to Company Details*****/
Alter Table [Company Details] Add [User Account ID] int
Alter Table [Company Details] Add [Computer ID] int

/***** Create Field to Customer Category*****/
Alter Table [Customer Category] Add [User Account ID] int
Alter Table [Customer Category] Add [Computer ID] int



/***** Create Field to Employee Information*****/
Alter Table [Employee Information] Add [User Account ID] int
Alter Table [Employee Information] Add [Computer ID] int


/***** Create Field to HEAD OF ACCOUNT*****/
Alter Table [HEAD OF ACCOUNT] Add [User Account ID] int
Alter Table [HEAD OF ACCOUNT] Add [Computer ID] int


/***** Create Field to Language Information*****/
Alter Table [Language Information] Add [User Account ID] int
Alter Table [Language Information] Add [Computer ID] int



/****** Create Field to Chart of Account ID in Bank Information ******/
ALTER TABLE [Bank Information] ADD [Chart of Account ID] Int NULL ;

/***** Create Field to Permission Setup*****/
Alter Table [Permission Setup] Add [Log User Account ID] int
Alter Table [Permission Setup] Add [Computer ID] int



/***** Add Column to Sale Return and purchase return*****/
alter table [purchase Return] add [product ID] int null;
alter table [Sale Return] add [product ID] int null;



/***** Create Field to Supplier Category*****/
Alter Table [Supplier Category] Add [User Account ID] int
Alter Table [Supplier Category] Add [Computer ID] int


/***** Create Field to User Account*****/
Alter Table [User Account] Add [Log User Account ID] int
Alter Table [User Account] Add [Computer ID] int

/*[Account Full Name] Feild updated in User Account*/

Alter Table [user Account] Add [Employee ID] int 


/*Create field to Customer Information*/

Alter Table [Customer Information] add [Employee ID] int


USE [BizPro]
GO

/****** Object:  Table [dbo].[Employee Category]    Script Date: 7/1/2019 7:57:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee Category](
	[Employee Category ID] [int] IDENTITY(1,1) NOT NULL,
	[Employee Category Name] [nvarchar](50) NOT NULL,
	[Computer ID] [int] NULL,
	[User Account ID] [int] NULL,
	[Branch ID] [int] NULL,
	[Prepared Date] [date] NULL,
	[Prepared Time] [time](7) NULL,
 CONSTRAINT [PK_Employee Category] PRIMARY KEY CLUSTERED 
(
	[Employee Category ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



/*Create field to Employee information*/

Alter Table [Employee Information] add [Employee Category ID] int


/*Create field to PUrchase return serial number*/
Alter Table [Purchase Return Serial] add [Purchase ID] int