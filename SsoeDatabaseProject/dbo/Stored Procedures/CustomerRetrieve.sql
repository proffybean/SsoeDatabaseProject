CREATE PROCEDURE [dbo].[CustomerRetrieve]
AS
	SELECT CustomerId,
		   LastName,
		   FirstName,
		   EmailAddress
	from SsoeTestDb.dbo.Customer
	order by LastName

RETURN 0