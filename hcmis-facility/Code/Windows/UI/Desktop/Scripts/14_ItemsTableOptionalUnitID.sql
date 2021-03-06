/*
   Monday, October 01, 201211:13:06 AM
   User: 
   Server: .
   Database: FE
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Items
	DROP CONSTRAINT FK_Items_VEN
GO
ALTER TABLE dbo.VEN SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.VEN', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.VEN', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.VEN', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Items
	DROP CONSTRAINT FK_Items_Unit
GO
ALTER TABLE dbo.Unit SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Unit', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Unit', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Unit', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Items
	DROP CONSTRAINT FK_Items_StorageType
GO
ALTER TABLE dbo.StorageType SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.StorageType', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.StorageType', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.StorageType', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Items
	DROP CONSTRAINT FK_Items_DosageForm
GO
ALTER TABLE dbo.DosageForm SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.DosageForm', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.DosageForm', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.DosageForm', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Items
	DROP CONSTRAINT FK_Items_ABC
GO
ALTER TABLE dbo.ABC SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ABC', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ABC', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ABC', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Items
	DROP CONSTRAINT FK_Items_INN
GO
ALTER TABLE dbo.Product SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Product', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Product', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Product', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Items
	(
	ID int NOT NULL IDENTITY (1, 1),
	StockCode varchar(50) NULL,
	Strength varchar(1500) NULL,
	DosageFormID int NULL,
	UnitID int NULL,
	VEN int NULL,
	ABC int NULL,
	IsFree bit NULL,
	IsDiscontinued bit NULL,
	Cost decimal(18, 0) NULL,
	EDL bit NULL,
	Refrigeratored bit NULL,
	Pediatric bit NULL,
	IINID int NULL,
	IsInHospitalList bit NULL,
	NeedExpiryBatch bit NULL,
	Code varchar(50) NULL,
	StockCodeDACA varchar(50) NULL,
	NearExpiryTrigger float(53) NULL,
	StorageTypeID int NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Items SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Items ON
GO
IF EXISTS(SELECT * FROM dbo.Items)
	 EXEC('INSERT INTO dbo.Tmp_Items (ID, StockCode, Strength, DosageFormID, UnitID, VEN, ABC, IsFree, IsDiscontinued, Cost, EDL, Refrigeratored, Pediatric, IINID, IsInHospitalList, NeedExpiryBatch, Code, StockCodeDACA, NearExpiryTrigger, StorageTypeID)
		SELECT ID, StockCode, Strength, DosageFormID, UnitID, VEN, ABC, IsFree, IsDiscontinued, Cost, EDL, Refrigeratored, Pediatric, IINID, IsInHospitalList, NeedExpiryBatch, Code, StockCodeDACA, NearExpiryTrigger, StorageTypeID FROM dbo.Items WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_Items OFF
GO
ALTER TABLE dbo.ItemPrefferedLocation
	DROP CONSTRAINT FK_ItemShelf_Items
GO
ALTER TABLE dbo.ReceiveDoc
	DROP CONSTRAINT FK_ReceiveDoc_Items
GO
ALTER TABLE dbo.ItemManufacturer
	DROP CONSTRAINT FK_ItemManufacturer_Items
GO
ALTER TABLE dbo.Disposal
	DROP CONSTRAINT FK_Disposal_Items
GO
ALTER TABLE dbo.ProgramProduct
	DROP CONSTRAINT FK_ProgramProduct_Items
GO
ALTER TABLE dbo.ItemSupplier
	DROP CONSTRAINT FK_ItemSupplier_Items
GO
ALTER TABLE dbo.ItemSupplyCategory
	DROP CONSTRAINT FK_ItemSupplyCategory_Items
GO
ALTER TABLE dbo.OrderDetail
	DROP CONSTRAINT FK_OrderDetail_Items
GO
ALTER TABLE dbo.Balance
	DROP CONSTRAINT FK_Balance_Items
GO
ALTER TABLE dbo.YearEnd
	DROP CONSTRAINT FK_YearEnd_Items
GO
ALTER TABLE dbo.IssueDoc
	DROP CONSTRAINT FK_IssueDoc_Items
GO
ALTER TABLE dbo.RRFDetail
	DROP CONSTRAINT FK_RRFDetail_Items
GO
DROP TABLE dbo.Items
GO
EXECUTE sp_rename N'dbo.Tmp_Items', N'Items', 'OBJECT' 
GO
ALTER TABLE dbo.Items ADD CONSTRAINT
	PK_ITem PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Items ADD CONSTRAINT
	FK_Items_INN FOREIGN KEY
	(
	IINID
	) REFERENCES dbo.Product
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Items WITH NOCHECK ADD CONSTRAINT
	FK_Items_ABC FOREIGN KEY
	(
	ABC
	) REFERENCES dbo.ABC
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Items WITH NOCHECK ADD CONSTRAINT
	FK_Items_DosageForm FOREIGN KEY
	(
	DosageFormID
	) REFERENCES dbo.DosageForm
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Items WITH NOCHECK ADD CONSTRAINT
	FK_Items_StorageType FOREIGN KEY
	(
	StorageTypeID
	) REFERENCES dbo.StorageType
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Items WITH NOCHECK ADD CONSTRAINT
	FK_Items_Unit FOREIGN KEY
	(
	UnitID
	) REFERENCES dbo.Unit
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Items WITH NOCHECK ADD CONSTRAINT
	FK_Items_VEN FOREIGN KEY
	(
	VEN
	) REFERENCES dbo.VEN
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Items', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Items', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Items', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.RRFDetail ADD CONSTRAINT
	FK_RRFDetail_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.RRFDetail SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.RRFDetail', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.RRFDetail', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.RRFDetail', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.IssueDoc WITH NOCHECK ADD CONSTRAINT
	FK_IssueDoc_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.IssueDoc SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.IssueDoc', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.IssueDoc', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.IssueDoc', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.YearEnd WITH NOCHECK ADD CONSTRAINT
	FK_YearEnd_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.YearEnd SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.YearEnd', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.YearEnd', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.YearEnd', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Balance WITH NOCHECK ADD CONSTRAINT
	FK_Balance_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Balance SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Balance', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Balance', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Balance', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.OrderDetail WITH NOCHECK ADD CONSTRAINT
	FK_OrderDetail_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.OrderDetail SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.OrderDetail', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.OrderDetail', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.OrderDetail', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ItemSupplyCategory WITH NOCHECK ADD CONSTRAINT
	FK_ItemSupplyCategory_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ItemSupplyCategory SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ItemSupplyCategory', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ItemSupplyCategory', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ItemSupplyCategory', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ItemSupplier WITH NOCHECK ADD CONSTRAINT
	FK_ItemSupplier_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ItemSupplier SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ItemSupplier', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ItemSupplier', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ItemSupplier', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ProgramProduct WITH NOCHECK ADD CONSTRAINT
	FK_ProgramProduct_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ProgramProduct SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ProgramProduct', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ProgramProduct', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ProgramProduct', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.Disposal WITH NOCHECK ADD CONSTRAINT
	FK_Disposal_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Disposal SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Disposal', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Disposal', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Disposal', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ItemManufacturer WITH NOCHECK ADD CONSTRAINT
	FK_ItemManufacturer_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ItemManufacturer SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ItemManufacturer', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ItemManufacturer', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ItemManufacturer', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ReceiveDoc ADD CONSTRAINT
	FK_ReceiveDoc_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.ReceiveDoc SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ReceiveDoc', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ReceiveDoc', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ReceiveDoc', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ItemPrefferedLocation ADD CONSTRAINT
	FK_ItemShelf_Items FOREIGN KEY
	(
	ItemID
	) REFERENCES dbo.Items
	(
	ID
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
ALTER TABLE dbo.ItemPrefferedLocation SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ItemPrefferedLocation', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ItemPrefferedLocation', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ItemPrefferedLocation', 'Object', 'CONTROL') as Contr_Per 
GO


ALTER TABLE [dbo].[ProductsCategory] DROP CONSTRAINT [FK_ProductsCategory_SubCategory]
GO

UPDATE Product set TypeID = 7 where TypeID = 1
GO

Update [Type] set ID = 7 where ID = 1
GO

update [Type] set ID = 8 where ID = 2
GO