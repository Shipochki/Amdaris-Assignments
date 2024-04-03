--1
--Get product name where product id not in work order between 1 and 100 id
SELECT 
[PP].[Name]
FROM [Production].[Product] AS [PP]
WHERE [PP].[ProductID] NOT IN 
	(
		SELECT [PWO].[ProductID]
		FROM [Production].[WorkOrder] AS [PWO]
		WHERE [PWO].[WorkOrderID] BETWEEN 1 AND 100
	)

--2
--Get first person with last name Brown order by firstname ascending
SELECT
	[PP].[BusinessEntityID]
	,[PP].[PersonType]
	,[PP].[FirstName]
FROM [Person].[Person] AS [PP]
WHERE [PP].[BusinessEntityID] =
	(
		SELECT TOP(1)
		[NPP].[BusinessEntityID]
		FROM [Person].[Person] AS [NPP]
		WHERE [NPP].[LastName] = 'Brown'
		ORDER BY [NPP].[FirstName]
	)

--3
--Get sales person with biggest bonus in the table
SELECT
	[SSP].[BusinessEntityID]
	,[SSP].[Bonus]
	,[SSP].[SalesQuota]
FROM [Sales].[SalesPerson] AS [SSP]
WHERE [SSP].[BusinessEntityID] = 
	(
		SELECT TOP(1)
			[NSSP].[BusinessEntityID]
		FROM [Sales].[SalesPerson] AS [NSSP]
		GROUP BY [NSSP].[BusinessEntityID]
		ORDER BY MAX([NSSP].[Bonus]) DESC
	)

--4
--Get all countries with country code and name with currency code EUR
SELECT
	[SCRC].[CountryRegionCode]
	,(
		CASE [SCRC].[CountryRegionCode]
		WHEN 'AT' THEN 'Austria'
		WHEN 'BE' THEN 'Belgium'
		WHEN 'DE' THEN 'Germany'
		WHEN 'ES' THEN 'Spain'
		WHEN 'FI' THEN 'Finland'
		WHEN 'FR' THEN 'France'
		WHEN 'GR' THEN 'Greece'
		WHEN 'IE' THEN 'Ireland'
		WHEN 'IT' THEN 'Italy'
		WHEN 'LU' THEN 'Lithuania'
		WHEN 'NL' THEN 'Netherlands'
		WHEN 'PT' THEN 'Portugal'
		END
	) AS [CountryName]
FROM [Sales].[CountryRegionCurrency] AS [SCRC]
WHERE [SCRC].[CurrencyCode] = 'EUR'

--5
--Get all business entity with person first name ordered by business id
SELECT
	[PBE].[BusinessEntityID]
	,(
		SELECT 
		[PP].[FirstName]
		FROM [Person].[Person] AS [PP]
		WHERE [PP].[BusinessEntityID] = [PBE].[BusinessEntityID]
	) AS [PersonFirstName]
FROM [Person].[BusinessEntity] AS [PBE]
ORDER BY [PBE].[BusinessEntityID]

--6
--Get planned cost, actual cost and actual resource hrs for each work order routing 
--where in work order has scrap reason ordered by actual resouce hrs descending
SELECT 
	[PWOR].[WorkOrderID]
	,[PWOR].[PlannedCost]
	,[PWOR].[ActualCost]
	,[PWOR].[ActualResourceHrs]
FROM [Production].[WorkOrderRouting] AS [PWOR]
WHERE [PWOR].[WorkOrderID] IN
	(
		SELECT [PWO].[WorkOrderID]
		FROM [Production].[WorkOrder] AS [PWO]
		WHERE [PWO].[ScrapReasonID] IN
			(
				SELECT [PSR].[ScrapReasonID]
				FROM [Production].[ScrapReason] AS [PSR]
			)
		)
ORDER BY [PWOR].[ActualResourceHrs] DESC

--7
--Get customer count for each territory with person and store is not null
SELECT
	(
		SELECT [SST].[Name]
		FROM [Sales].[SalesTerritory] AS [SST]
		WHERE [SC].[TerritoryID] = [SST].[TerritoryID]
	) AS [TeritoryName]
	,COUNT([SC].[CustomerID]) AS [CountCustomers]
FROM [Sales].[Customer] AS [SC]
WHERE [SC].[PersonID] IN 
	(
		SELECT [PP].[BusinessEntityID]
		FROM [Person].[Person] AS [PP]
	)
	AND
	[SC].[StoreID] IN
	(
		SELECT [SS].[BusinessEntityID]
		FROM [Sales].[Store] AS [SS]
	)
GROUP BY [SC].[TerritoryID]

--8
--Update bonuses for salses person which territory is not in north america 
SELECT *
FROM [Sales].[SalesPerson] AS [SSP]
WHERE [SSP].[TerritoryID] NOT IN
		(
			SELECT 
				[SST].[TerritoryID]
			FROM [Sales].[SalesTerritory] AS [SST]
			WHERE [SST].[Group] != 'North America'
		)

UPDATE [Sales].[SalesPerson]
SET [Bonus] += 50
WHERE [TerritoryID] NOT IN
		(
			SELECT 
				[SST].[TerritoryID]
			FROM [Sales].[SalesTerritory] AS [SST]
			WHERE [SST].[Group] != 'North America'
		)


