CREATE PROCEDURE ShowCompanies
	AS
	SET NOCOUNT ON
		BEGIN
			SELECT CompanyCode,Company,CompanyAddress,MobileNumber,PhoneNumber FROM Company(NOLOCK)
		END
	SET NOCOUNT OFF
GO
CREATE PROCEDURE ShowCustomers
AS
	SET NOCOUNT ON

		SELECT CustomerCode,CustomerName,CustomerAddress [Address],Town,TransportName,MobileNumber1,MobileNumber2,PhoneNumber,GSTNumber FROM Customers(NOLOCK)

	SET NOCOUNT OFF
GO
CREATE PROCEDURE ShowItems
AS
	SET NOCOUNT ON

		SELECT ItemCode,Item,IsActive FROM Items(NOLOCK)

	SET NOCOUNT OFF
GO
CREATE PROCEDURE ShowPaymentMeans
AS
	SET NOCOUNT ON
		SELECT PaymentMeanCode,PaymentMean,IsActive FROM PaymentMean(NOLOCK)
	SET NOCOUNT OFF
GO
CREATE PROCEDURE ShowSections
AS
	SET NOCOUNT ON
		SELECT SectionCode,Section,IsActive FROM Section(NOLOCK)
	SET NOCOUNT OFF