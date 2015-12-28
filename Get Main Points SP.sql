USE [RTMDB]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetMainPointDescriptionByRowId]    Script Date: 09/18/2015 16:27:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Lee Green
-- Create date: 09/15/2015
-- Description:	Get the Main Point Description by the row Id.
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetMainPointDescriptionByRowId] 
	-- Add the parameters for the stored procedure here
	@MainPointId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MainPoints.MainPointId, MainPoints.MainPointDescription 
	FROM MainPoints
	WHERE MainPoints.MainPointId = @MainPointId
	
END

GO

