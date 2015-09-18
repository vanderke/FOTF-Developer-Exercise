USE [RTMDB]
GO

/****** Object:  StoredProcedure [dbo].[usp_AddCustomer]    Script Date: 09/18/2015 16:25:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Lee Green
-- Create date: 09/16/2015
-- Description:	Insert a Customer info into the customer table
-- =============================================
CREATE PROCEDURE [dbo].[usp_AddCustomer]
	-- Add the parameters for the stored procedure here
	
	@paraFirstName varchar(50),
	@paraMiddleName varchar(50),
	@paraLastName varchar(50),
	@paraAddress1 varchar(50),
	@paraAddress2 varchar(50),
	@paraCity varchar(50),
	@paraStateId int,
	@paraZip4 varchar(4),
	@paraZip5 varchar(5),
	@paraAreaCode varchar(3),
	@paraPhoneNumber varchar(7)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Customers (FirstName, MiddleName, LastName, Address1, Address2, City, StateId, Zip4, Zip5, AreaCode, PhoneNumber)
	VALUES (@paraFirstName, @paraMiddleName, @paraLastName, @paraAddress1, @paraAddress2, @paraCity, @paraStateId, @paraZip4, @paraZip5, @paraAreaCode, @paraPhoneNumber)
END

GO

