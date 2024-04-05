--1
SELECT
	[FirstName]
	,[LastName]
	,[BusinessEntityID] AS [Employee_id]
FROM [Person].[Person]
ORDER BY [LastName]

--2
SELECT
	[PPP].[BusinessEntityID]
	,[PP].[FirstName]
	,[PP].[LastName]
	,[PPP].[PhoneNumber]
FROM [Person].[PersonPhone] AS [PPP]
JOIN [Person].[Person] AS [PP] ON [PP].[BusinessEntityID] = [PPP].[BusinessEntityID]
WHERE [PP].[LastName] LIKE 'L%'
ORDER BY [LastName], [FirstName]

--3
SELECT
	[PP].[LastName]
	,[SSP].[SalesYTD]
	,[PA].[PostalCode]
FROM [Person].[Address] AS [PA] 
JOIN [Person].[StateProvince] AS [PSP] ON [PA].[StateProvinceID] = [PSP].[StateProvinceID]
JOIN [Sales].[SalesPerson] AS [SSP] ON [PSP].[TerritoryID] = [SSP].[TerritoryID]
JOIN [Person].[Person] AS [PP] ON [SSP].[BusinessEntityID] = [PP].[BusinessEntityID]
WHERE [SSP].[SalesYTD] > 0 AND [SSP].[TerritoryID] IS NOT NULL
GROUP BY  [PA].[PostalCode], [SSP].[SalesYTD], [PP].[LastName]
ORDER BY [SSP].[SalesYTD] DESC, [PA].[PostalCode] ASC


--4
SELECT
	[SSO].[SalesOrderID]
	,(SUM([SSO].[UnitPrice] * [SSO].[OrderQty])) AS [TotalCost]
FROM [Sales].[SalesOrderDetail] AS [SSO]
GROUP BY [SSO].[SalesOrderID]
HAVING SUM([SSO].[UnitPrice] * [SSO].[OrderQty]) > 100000
