
ALTER PROCEDURE [dbo].[proc_IssueDocUpdate]
(
	@ID int,
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
	@RecipientName varchar(200) =null
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [IssueDoc]
	SET
		[ItemID] = @ItemID,
		[StoreId] = @StoreId,
		[ReceivingUnitID] = @ReceivingUnitID,
		[LocalBatchNo] = @LocalBatchNo,
		[Quantity] = @Quantity,
		[Date] = @Date,
		[IsTransfer] = @IsTransfer,
		[IssuedBy] = @IssuedBy,
		[Remark] = @Remark,
		[RefNo] = @RefNo,
		[BatchNo] = @BatchNo,
		[IsApproved] = @IsApproved,
		[Cost] = @Cost,
		[NoOfPack] = @NoOfPack,
		[QtyPerPack] = @QtyPerPack,
		[DUSOH] = @DUSOH,
		[DURequestedQty] = @DURequestedQty,
		[RecomendedQty] = @RecomendedQty,
		[RecievDocID] = @RecievDocID,
		[EurDate] = @EurDate,
		[OrderID] = @OrderID,
		[UnitID] =@UnitID,
		[RecipientName] =@RecipientName
	WHERE
		[ID] = @ID


	SET @Err = @@Error


	RETURN @Err
END
