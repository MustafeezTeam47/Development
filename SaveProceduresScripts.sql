DROP PROCEDURE SaveCompany
GO
CREATE PROCEDURE SaveCompany
	@CompanyID INTEGER,
	@CompanyCode [NullCode],
	@CompanyName [Name],
	@Address [Description],
	@MobileNo [Mobile],
	@PhoneNo [Mobile],
	@ReturnValue INTEGER OUTPUT

AS
	SET NOCOUNT ON
	IF(@CompanyID=0)
	BEGIN
		INSERT INTO Company(CompanyCode,Company,CompanyAddress,MobileNumber,PhoneNumber,IsActive,CreatedDate)
			SELECT @CompanyCode,@CompanyName,@Address,@MobileNo,@PhoneNo,1,GETDATE()

			SET @CompanyID=SCOPE_IDENTITY();
			SET @ReturnValue = 1
	END
	SET NOCOUNT OFF


GO

DROP PROCEDURE SaveCustomer
GO
CREATE PROCEDURE SaveCustomer
	@CustomerID INTEGER,
	@CustomerName [NullName],
	@Address [NullDESCRIPTION],
	@Town [NullName],
	@TransportName [NullName],
	@Mobile1 [Mobile],
	@Mobile2 [Mobile],
	@PhoneNo [Mobile],
	@GstNumber [NullNumber],
	@ReturnValue NVARCHAR(15) OUTPUT

AS
	SET NOCOUNT ON
	DECLARE @RandomCode INTEGER
		SET @RandomCode = ROUND(((300 - 1 -1) * RAND() + 1), 0)

	IF(@CustomerID=0)
	BEGIN
		INSERT INTO Customers(CustomerCode,CustomerName,CustomerAddress,Town,TransportName,MobileNumber1,MobileNumber2,PhoneNumber,GSTNumber,IsActive,CreatedDate)
			SELECT @RandomCode,@CustomerName,@Address,@Town,@TransportName,@Mobile1,@Mobile2,@PhoneNo,@GstNumber,1,GETDATE()
		SET @CustomerID=SCOPE_IDENTITY();
		SET @ReturnValue=1
	END
	ELSE
	BEGIN
		UPDATE Customers
			SET CustomerName=@CustomerName,
				CustomerAddress=@Address,
				Town=@Town,
				TransportName=@TransportName,
				MobileNumber1=@Mobile1,
				MobileNumber2=@Mobile2,
				PhoneNumber=@PhoneNo,
				GSTNumber=@GstNumber
		WHERE CustomerID=@CustomerID
	END

	--SELECT @ReturnValue=ERROR_MESSAGE();


	SET NOCOUNT OFF

GO

DROP PROCEDURE SaveItemMaster
GO
CREATE PROCEDURE SaveItemMaster
	@ItemID BIGINT,	
	@ItemName [Name],
	@CategoryID INTEGER,
	@IsActive BIT,
	@ReturnValue NVARCHAR(15) OUTPUT

AS

	SET NOCOUNT ON
	DECLARE @RandomCode INTEGER
		SET @RandomCode = ROUND(((200 - 1 -1) * RAND() + 1), 0)

	IF(@ItemID=0)
	BEGIN

		INSERT INTO Items(ItemCode,Item,CategoryID,IsActive,CreatedDate)
			SELECT @RandomCode,@ItemName,@CategoryID,@IsActive,GETDATE()

			SET @ItemID=SCOPE_IDENTITY();

			SET @ReturnValue=1		

	END
	ELSE
	BEGIN
		UPDATE Items
			SET Item=@ItemName,
				CategoryID=@CategoryID,
				IsActive=@IsActive
			WHERE ItemID=@ItemID
	END

	--SELECT @ReturnValue=ERROR_MESSAGE();
	SET NOCOUNT OFF
GO
DROP PROCEDURE SavePaymentMean
go
CREATE PROCEDURE SavePaymentMean
	@PaymentMeanID BIGINT,	
	@PaymentMeanName [Name],	
	@IsActive BIT,
	@ReturnValue NVARCHAR(15) OUTPUT

AS

	SET NOCOUNT ON
	DECLARE @RandomCode INTEGER
			SET @RandomCode = ROUND(((200 - 1 -1) * RAND() + 1), 0)

	IF(@PaymentMeanID=0)
	BEGIN

		INSERT INTO PaymentMean(PaymentMeanCode,PaymentMean,IsActive,CreatedDate)
			SELECT @RandomCode,@PaymentMeanName,@IsActive,GETDATE()

			SET @PaymentMeanID=SCOPE_IDENTITY();

			SET @ReturnValue=1		

	END
	ELSE
	BEGIN
		UPDATE PaymentMean
			SET PaymentMean=@PaymentMeanName,			
				IsActive=@IsActive
			WHERE PaymentMeanID=@PaymentMeanID
	END

	--SELECT @ReturnValue=ERROR_MESSAGE();
	SET NOCOUNT OFF

GO
DROP PROCEDURE SaveSection
GO
CREATE PROCEDURE SaveSection
	@SectionID BIGINT,
	@SectionName [Name],	
	@IsActive BIT,
	@ReturnValue NVARCHAR(15) OUTPUT

AS

	SET NOCOUNT ON
	DECLARE @RandomCode INTEGER
		SET @RandomCode = ROUND(((200 - 1 -1) * RAND() + 1), 0)

	IF(@SectionID=0)
	BEGIN

		INSERT INTO Section(SectionCode,Section,IsActive,CreatedDate)
			SELECT @RandomCode,@SectionName,@IsActive,GETDATE()

			SET @SectionID=SCOPE_IDENTITY();

			SET @ReturnValue=1		

	END
	ELSE
	BEGIN
		UPDATE Section
			SET Section=@SectionName,			
				IsActive=@IsActive
			WHERE SectionID=@SectionID
	END

	--SELECT @ReturnValue=ERROR_MESSAGE();
	SET NOCOUNT OFF

	
