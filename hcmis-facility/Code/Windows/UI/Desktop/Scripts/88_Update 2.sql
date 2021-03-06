/*
   Tuesday, October 02, 20127:05:07 PM
   User: 
   Server: TOSHIBA-PC\SQLEXPRESS
   Database: E:\ADWAHPHCMISDB\PHARMINVENTORY.MDF
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
ALTER TABLE dbo.SupplyCategory
	DROP CONSTRAINT DF_ConsumablesCategory_ParentId
GO
CREATE TABLE dbo.Tmp_SupplyCategory
	(
	ID int NOT NULL,
	Name varchar(50) NULL,
	ParentId int NULL,
	Code varchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_SupplyCategory ADD CONSTRAINT
	DF_ConsumablesCategory_ParentId DEFAULT ((0)) FOR ParentId
GO
IF EXISTS(SELECT * FROM dbo.SupplyCategory)
	 EXEC('INSERT INTO dbo.Tmp_SupplyCategory (ID, Name, ParentId, Code)
		SELECT ID, Name, ParentId, Code FROM dbo.SupplyCategory WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.ItemSupplyCategory
	DROP CONSTRAINT FK_ItemSupplyCategory_SupplyCategory
GO
DROP TABLE dbo.SupplyCategory
GO
EXECUTE sp_rename N'dbo.Tmp_SupplyCategory', N'SupplyCategory', 'OBJECT' 
GO
ALTER TABLE dbo.SupplyCategory ADD CONSTRAINT
	PK_ConsumablesCategory PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
select Has_Perms_By_Name(N'dbo.SupplyCategory', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.SupplyCategory', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.SupplyCategory', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.ItemSupplyCategory ADD CONSTRAINT
	FK_ItemSupplyCategory_SupplyCategory FOREIGN KEY
	(
	CategoryID
	) REFERENCES dbo.SupplyCategory
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
select Has_Perms_By_Name(N'dbo.ItemSupplyCategory', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.ItemSupplyCategory', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.ItemSupplyCategory', 'Object', 'CONTROL') as Contr_Per 