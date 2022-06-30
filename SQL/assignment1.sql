--1.
SELECT ProductID, Name, Color, ListPrice 
FROM Production.Product

--2.
SELECT ProductID, Name, Color, ListPrice 
FROM Production.Product 
WHERE ListPrice != 0

--3.
SELECT ProductID, Name, Color, ListPrice 
FROM Production.Product 
WHERE Color IS NOT NULL

--4.
SELECT ProductID, Name, Color, ListPrice 
FROM Production.Product 
WHERE Color IS NOT NULL AND ListPrice > 0

--5.
SELECT Name + ' ' + Color 
FROM Production.Product 
WHERE Color IS NOT NULL

--6.
SELECT 'NAME: '+ Name + ' -- COLOR: ' + Color 
FROM Production.Product 
WHERE Name IN ('LL Crankarm', 'ML Crankarm', 'HL Crankarm', 'Chainring Bolts', 'Chainring Nut', 'Chainring') AND Color IN ('Black','Silver')

--7.
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

--8.
SELECT ProductID, Name, Color
FROM Production.Product
WHERE Color IN ('Black','Blue')

--9.
SELECT Name
FROM Production.Product
WHERE Name LIKE 'S%'

--10.
SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE 'A%' OR Name LIKE 'S%'
ORDER BY Name

--11.
SELECT Name
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%'
ORDER BY Name

--12.
SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL AND Color IS NOT NULL