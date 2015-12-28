USE [RTMDB]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetHelpLineMessageById]    Script Date: 09/18/2015 16:26:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Lee Green
-- Create date: 09/14/2015
-- Description:	Get the help message by the row id
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetHelpLineMessageById] 
	-- Add the parameters for the stored procedure here
	@paramHelpLineId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT HelpLines.HelpLineMessage 
	FROM HelpLines
	WHERE HelpLines.HelpLineId = @paramHelpLineId
	
END

GO

