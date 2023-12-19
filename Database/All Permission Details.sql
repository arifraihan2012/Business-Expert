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
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (9, N'EMPLOYEE CATEGORY')
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
INSERT [dbo].[All Permission] ([Permission ID], [Name]) VALUES (72, N'LEDGER TRANSFER')
SET IDENTITY_INSERT [dbo].[All Permission] OFF
