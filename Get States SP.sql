USE [RTMDB]
GO

/****** Object:  StoredProcedure [dbo].[usp_GetAllStatesAndRowId]    Script Date: 09/18/2015 16:26:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Lee Green
-- Create date: 09/16/2015
-- Description:	Get All States and Row Id
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetAllStatesAndRowId]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT StateId, StateName
	FROM T_CD_States
	
END

GO

