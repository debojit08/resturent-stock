Create Table Config.[Supplier]
(
 [SupplierID] bigint identity(1,1) Constraint Pk_SupplierID Primary key,
 [SupplierName] varchar(max),
 [Address] varchar(max), 
 [Mobile_no] bigint,
 [Email] varchar(max),
 [IsActive] bit DEFAULT (0),
 [eDate] datetime,
 [mDate] datetime
)

-------------------------------------------------
Create Table Config.[StockPurches]
(
 [PurchesItemID] bigint identity(1,1) Constraint Pk_PurchesItemID Primary key,
 [SupplierID] bigint,
 [ItemName] varchar(max),
 [Qty] bigint, 
 [Unit] varchar(max),
 [PricePerUnit] varchar(max),
 [Amount] bigint,
 [CGST] bigint,
 [SGST] bigint,
 [TotalAmount] bigint,
 [PaymentType] bit DEFAULT(0), 
 [eDate] datetime,
 [mDate] datetime
)
