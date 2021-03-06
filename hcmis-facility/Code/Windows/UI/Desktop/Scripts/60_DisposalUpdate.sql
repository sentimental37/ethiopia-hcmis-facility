ALTER PROCEDURE [dbo].[proc_DisposalUpdate]
(
	@ID int,
	@ItemID int = NULL,
	@StoreId int = NULL,
	@ReasonId int = NULL,
	@Quantity bigint = NULL,
	@Date datetime = NULL,
	@ApprovedBy varchar(50) = NULL,
	@Losses bit = NULL,
	@BatchNo varchar(50) = NULL,
	@Remark text = NULL,
	@Cost float = NULL,
	@RefNo varchar(50) = NULL,
	@EurDate datetime = NULL,
	@RecID int = NULL,
	@UnitID int =null
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [Disposal]
	SET
		[ItemID] = @ItemID,
		[StoreId] = @StoreId,
		[ReasonId] = @ReasonId,
		[Quantity] = @Quantity,
		[Date] = @Date,
		[ApprovedBy] = @ApprovedBy,
		[Losses] = @Losses,
		[BatchNo] = @BatchNo,
		[Remark] = @Remark,
		[Cost] = @Cost,
		[RefNo] = @RefNo,
		[EurDate] = @EurDate,
		[RecID] = @RecID,
		[UnitID] =@UnitID
	WHERE
		[ID] = @ID


	SET @Err = @@Error


	RETURN @Err
END
