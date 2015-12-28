USE [RTMDB]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllMainPoints]    Script Date: 09/18/2015 16:25:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Lee Green
-- Create date: 09/14/2015
-- Description:	Get all main points
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetAllMainPoints]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT MainPoints.MainPointId, MainPoints.MainPoint
	FROM MainPoints
END

GO

