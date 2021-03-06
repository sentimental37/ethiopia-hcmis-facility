ALTER PROCEDURE [dbo].[proc_IssueDocInsert]
(
	@ID int = NULL output,
	@ItemID int = NULL,
	@StoreId int = NULL,
	@ReceivingUnitID int = NULL,
	@LocalBatchNo varchar(50) = NULL,
	@Quantity bigint = NULL,
	@Date datetime = NULL,
	@IsTransfer bit = NULL,
	@IssuedBy varchar(50) = NULL,
	@Remark text = NULL,
	@RefNo varchar(50) = NULL,
	@BatchNo varchar(50) = NULL,
	@IsApproved bit = NULL,
	@Cost float = NULL,
	@NoOfPack int = NULL,
	@QtyPerPack int = NULL,
	@DUSOH bigint = NULL,
	@DURequestedQty bigint = NULL,
	@RecomendedQty bigint = NULL,
	@RecievDocID int = NULL,
	@EurDate datetime = NULL,
	@OrderID int = NULL,
	@UnitID int =null,
	@RecipientName varchar(200)=null
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [IssueDoc]
	(
		[ItemID],
		[StoreId],
		[ReceivingUnitID],
		[LocalBatchNo],
		[Quantity],
		[Date],
		[IsTransfer],
		[IssuedBy],
		[Remark],
		[RefNo],
		[BatchNo],
		[IsApproved],
		[Cost],
		[NoOfPack],
		[QtyPerPack],
		[DUSOH],
		[DURequestedQty],
		[RecomendedQty],
		[RecievDocID],
		[EurDate],
		[OrderID],
		[UnitID],
		[RecipientName]
	)
	VALUES
	(
		@ItemID,
		@StoreId,
		@ReceivingUnitID,
		@LocalBatchNo,
		@Quantity,
		@Date,
		@IsTransfer,
		@IssuedBy,
		@Remark,
		@RefNo,
		@BatchNo,
		@IsApproved,
		@Cost,
		@NoOfPack,
		@QtyPerPack,
		@DUSOH,
		@DURequestedQty,
		@RecomendedQty,
		@RecievDocID,
		@EurDate,
		@OrderID,
		@UnitID,
		@RecipientName
	)

	SET @Err = @@Error

	SELECT @ID = SCOPE_IDENTITY()

	RETURN @Err
END
