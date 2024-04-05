--1
--Add new product review for product with id 316
--BEGIN TRANSACTION

--BEGIN TRY
--	INSERT INTO [Production].[Culture]
--	VALUES('bg', 'Bulgarian', '2024-04-30')

--	INSERT INTO [Production].[ProductReview]
--	VALUES(316, 'Vernon Dursley', '2024-03-04', 'vernon@mail.com', 4, 'The best blade in the world', '2024-03-04');
--END TRY

--BEGIN CATCH
--	ROLLBACK TRANSACTION
--END CATCH

--2
--Add new department for artificial intelligence
--Then update department id in EmployeeDepartmentHistory
--BEGIN TRANSACTION

--BEGIN TRY
--	INSERT INTO [HumanResources].[Department]
--	VALUES('AI', 'Artificial Intelligence', '2024-04-03');

--	UPDATE [HumanResources].[EmployeeDepartmentHistory]
--	SET [DepartmentID] = 18
--	WHERE [BusinessEntityID] = 1
--END TRY

--BEGIN CATCH
--	ROLLBACK TRANSACTION
--END CATCH

--3
--Person Ken update his email address 
--BEGIN TRANSACTION

--BEGIN TRY
--	UPDATE [Person].[EmailAddress]
--	SET [EmailAddress] = 'ken@gmail.com'
--	WHERE [BusinessEntityID] = 1

--	UPDATE [Person].[Person]
--	SET [EmailPromotion] = 2
--	WHERE [BusinessEntityID] = 1
--END TRY

--BEGIN CATCH
--	ROLLBACK TRANSACTION
--END CATCH

--4
--Updated special offer with id 9
--BEGIN TRANSACTION

--BEGIN TRY
--	UPDATE [Sales].[SpecialOffer]
--	SET [DiscountPct] = 0.35
--	WHERE [SpecialOfferID] = 9

--	UPDATE [Sales].[SpecialOfferProduct]
--	SET [SpecialOfferID] = 4
--	WHERE [ProductID] = 912
--END TRY

--BEGIN CATCH
--	ROLLBACK TRANSACTION
--END CATCH

--5
--Delete sales person with lower sales YTD 
--BEGIN TRANSACTION

--BEGIN TRY
--	DELETE
--	FROM [Sales].[SalesPerson] 
--	WHERE [BusinessEntityID] = 
--	(
--		SELECT TOP(1)
--		[BusinessEntityID]
--		FROM [Sales].[SalesPerson]
--		ORDER BY [SalesYTD] 
--	)

--	CREATE TABLE [Posts]
--	(
--		[Id] INT PRIMARY KEY IDENTITY
--		,[FromDestination] NVARCHAR(50) NOT NULL
--		,[ToDestination] NVARCHAR(50) NOT NULL
--		,[Description] NVARCHAR(500) NOT NULL
--		,[PriceForSeat] DECIMAL(18,2)
--		,[FreeSeats] INT
--		,[Baggage] BIT
--		,[Pets] BIT
--		,[IsCompleted] BIT
--		,[DateAndTime] DATETIME2
--		,[IsActive] BIT
--	)
--END TRY

--BEGIN CATCH
--	ROLLBACK TRANSACTION
--END CATCH

--6
--Delete shopping cart with id 2
--BEGIN TRANSACTION

--BEGIN TRY
--	DELETE
--	FROM [Sales].[ShoppingCartItem] 
--	WHERE [ShoppingCartID] = 2

--	TRUNCATE TABLE [Posts]
--	DROP TABLE [Posts];
--END TRY

--BEGIN CATCH
--	ROLLBACK TRANSACTION
--END CATCH

--7
--Should throw FOREIGN KEY constraint conflict with product id
--BEGIN TRANSACTION

--BEGIN TRY
--	INSERT INTO [Sales].[SpecialOfferProduct]
--	VALUES (1, 1000, 'ECFED6CB-51FF-49B5-B06C-7D8AC834DB8B', '2024-04-01')

--	UPDATE [Person].[EmailAddress]
--	SET [EmailAddress] = 'ken@gmail.com'
--	WHERE [BusinessEntityID] = 1
--END TRY

--BEGIN CATCH
--	ROLLBACK TRANSACTION
--END CATCH

--8
--BEGIN TRANSACTION

--BEGIN TRY
--	INSERT INTO [Person].[EmailAddress] ([BusinessEntityID], [EmailAddressID], [EmailAddress], [rowguid], [ModifiedDate])
--	VALUES (30000, 30000, 'test@mail.com', '8A1901E4-671B-431A-871C-EADB2942E9EE', '2024-01-07')

--	INSERT INTO [Person].[Password]([BusinessEntityID], [PasswordHash], [PasswordSalt], [rowguid], [ModifiedDate])
--	VALUES (30000, 'pbFwXWE99vobT6g+vPWFy93NtUU/orrIWafF01hccfM=', 'bE3XiWw=', '8A1901E4-671B-431A-871C-EADB2942E9EE', '2024-01-07')
--END TRY

--BEGIN CATCH
--	ROLLBACK TRANSACTION
--END CATCH