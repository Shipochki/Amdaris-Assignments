--1
--Get employee count of each department with shift at night
SELECT
	[HREDH].[DepartmentID]
	,[HRD].[Name] AS [Department]
	,[HRS].[Name] AS [Shift]
	,COUNT([HREDH].[BusinessEntityID]) AS [CountEmployes]
FROM [HumanResources].[EmployeeDepartmentHistory] AS [HREDH]
JOIN [HumanResources].[Shift] AS [HRS] ON [HREDH].[ShiftID] = [HRS].[ShiftID]
JOIN [HumanResources].[Department] AS [HRD] ON [HREDH].[DepartmentID] = [HRD].[DepartmentID]
GROUP BY [HREDH].[DepartmentID], [HRS].[Name], [HRD].[Name]
HAVING [HRS].[Name] = 'Night'

--2
--Get Business with FirstName and count for the territory they have
SELECT
	[PP].[BusinessEntityID]
	,[PP].[FirstName]
	,COUNT([SSP].[TerritoryID]) AS [CountTerritory]
FROM [Person].[Person] AS [PP]
JOIN [Sales].[SalesPerson] AS [SSP] ON [PP].[BusinessEntityID] = [SSP].[BusinessEntityID]
JOIN [Person].[StateProvince] AS [PSP] ON [SSP].[TerritoryID] = [PSP].[TerritoryID]
GROUP BY [PP].[BusinessEntityID], [PP].[FirstName]

--3
--Get top 10 employee bonuses
SELECT TOP(10)
	[PP].[BusinessEntityID]
	,[PP].[FirstName]
	,MAX([SSP].[Bonus]) AS [Bonus]
FROM [Person].[Person] AS [PP]
JOIN [Sales].[SalesPerson] AS [SSP] ON [PP].[BusinessEntityID] = [SSP].[BusinessEntityID]
JOIN [Person].[StateProvince] AS [PSP] ON [SSP].[TerritoryID] = [PSP].[TerritoryID]
GROUP BY [PP].[BusinessEntityID], [PP].[FirstName]
ORDER BY(MAX([SSP].[Bonus])) DESC

--4
--Get all account numbers with stores starts wtih N
SELECT 
	[SC].[AccountNumber]
	,[SS].[Name] AS [StoreName]
FROM [Sales].[Customer] AS [SC]
JOIN [Sales].[Store] AS [SS] ON [SC].[StoreID] = [SS].[BusinessEntityID]
WHERE [SC].[PersonID] IS NOT NULL AND [SS].[Name] LIKE 'N%'
ORDER BY [SS].[Name]

--5
--Get all country region average rate with to currency code equal to eur
SELECT
	[SCRC].[CountryRegionCode]
	,[SCR].[FromCurrencyCode]
	,AVG([SCR].[AverageRate]) AS [AverageRate]
	,[SCRC].[CurrencyCode]
FROM [Sales].[CountryRegionCurrency] AS [SCRC]
JOIN [Sales].[CurrencyRate] AS [SCR] ON [SCRC].[CurrencyCode] = [SCR].[ToCurrencyCode]
GROUP BY [SCRC].[CountryRegionCode], [SCR].[FromCurrencyCode], [SCRC].[CurrencyCode]
HAVING [SCRC].[CurrencyCode] LIKE 'EUR'

--6
--Get work order count for each product name and standrad cost
SELECT
	[PP].[Name]
	,[PP].[StandardCost]
	,COUNT([PWO].[WorkOrderID]) AS [CountWorkOrder]
FROM [Production].[WorkOrder] AS [PWO]
JOIN [Production].[Product] AS [PP] ON [PWO].[ProductID] = [PP].[ProductID]
GROUP BY [PP].[Name], [PP].[StandardCost]
ORDER BY [PP].[StandardCost] DESC

--7
--Get Employee with file with extension .doc and summary is not null
SELECT
	[PP].[FirstName]
	,[PP].[LastName]
	,[PD].[FileName]
	,[PD].[DocumentSummary]
FROM [HumanResources].[Employee] AS [HRE]
JOIN [Production].[Document] AS [PD] ON [HRE].[BusinessEntityID] = [PD].[Owner]
JOIN [Person].[Person] AS [PP] ON [HRE].[BusinessEntityID] = [PP].[BusinessEntityID]
WHERE [PD].[FileExtension] = '.doc' AND [PD].[DocumentSummary] IS NOT NULL

--8
--Get all phone numbers for each person with phone name type 
SELECT
	[PP].[FirstName]
	,[PP].[LastName]
	,[PPP].[PhoneNumber]
	,[PPNT].[Name] AS [PhoneNameType]
FROM [Person].[PersonPhone] AS [PPP]
JOIN [Person].[Person] AS [PP] ON [PPP].[BusinessEntityID] = [PP].[BusinessEntityID]
JOIN [Person].[PhoneNumberType] AS [PPNT] ON [PPP].[PhoneNumberTypeID] = [PPNT].[PhoneNumberTypeID]