ALTER PROCEDURE [dbo].[proc_StoresLoadByPrimaryKey]
(
	@ID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ID],
		[HospitalID],
		[StoreName],
		[IsActive],
		[SupplierID],
		[ReceivingUnitID]
	FROM [Stores]
	WHERE
		([ID] = @ID)

	SET @Err = @@Error

	RETURN @Err
END
