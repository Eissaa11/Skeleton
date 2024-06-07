USE [p2735061]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_OrdIN_FilterByOrd_id]
		@Ord_id = 2

SELECT	@return_value as 'Return Value'

GO
