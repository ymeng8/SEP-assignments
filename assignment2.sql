--1. 
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode

--2.
SELECT c.Name AS Country, s.Name AS Province
FROM Person.CountryRegion c JOIN Person.StateProvince s ON c.CountryRegionCode = s.CountryRegionCode
WHERE c.Name IN ('Germany','Canada')

--3.
DECLARE @today DATETIME
SELECT @today = GETDATE()

SELECT DISTINCT p.ProductID, p.ProductName,o.OrderDate
FROM Orders o JOIN [Order Details] od ON o.OrderID=od.OrderID JOIN Products p ON p.ProductID=od.ProductID
WHERE DATEDIFF(year, @today, o.OrderDate) < 25
ORDER BY o.OrderDate

--4.
DECLARE @today DATETIME
SELECT @today = GETDATE()

SELECT TOP 5 ShipPostalCode, COUNT(OrderID) OrderCount
FROM Orders
WHERE ShipPostalCode IS NOT NULL AND DATEDIFF(year, @today, OrderDate) < 25
GROUP BY ShipPostalCode
ORDER BY OrderCount DESC

--5.
SELECT City, COUNT(CustomerID) NumOfCustomers
FROM Customers
GROUP BY City

--6.
SELECT City, COUNT(CustomerID) NumOfCustomers
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2

--7.
SELECT c.ContactName, SUM(od.Quantity) as ProductCounts
FROM Customers c JOIN Orders o ON c.CustomerID=o.CustomerID JOIN [Order Details] od ON o.OrderID=od.OrderID
GROUP BY c.CustomerID, c.ContactName 

--8.
SELECT c.CustomerID, SUM(od.Quantity) as ProductCounts
FROM Customers c JOIN Orders o ON c.CustomerID=o.CustomerID JOIN [Order Details] od ON o.OrderID=od.OrderID
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) > 100

--9.
SELECT su.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name]
FROM Suppliers su CROSS JOIN Shippers sh

--10.
SELECT o.OrderDate, p.ProductName
FROM Orders o JOIN [Order Details] od ON o.OrderID=od.OrderID JOIN Products p ON p.ProductID=od.ProductID
ORDER BY o.OrderDate

--11.
SELECT e1.FirstName+' '+e1.LastName Employee1, e2.FirstName+' '+e2.LastName Employee2
FROM Employees e1 JOIN Employees e2 ON e1.Title=e2.Title
WHERE e1.EmployeeID > e2.EmployeeID

--12.
SELECT m.EmployeeID ManagerID, COUNT(e.EmployeeID) NumOfEmployees
FROM Employees e JOIN Employees m ON e.ReportsTo = m.EmployeeID
GROUP BY m.EmployeeID
HAVING COUNT(e.EmployeeID) > 2

--13.
SELECT City, ContactName, 'Customer' Type
FROM Customers
UNION ALL
SELECT City, ContactName, 'Supplier' Type
FROM Suppliers

--14.
SELECT e.City
FROM Employees e JOIN Customers c ON e.City=c.City

--15.
--a. using subquery
SELECT City
FROM Customers 
WHERE City NOT IN (SELECT City FROM Employees)
--b. not using subquery
SELECT c.City
FROM Customers c LEFT JOIN Employees e ON c.City=e.City
WHERE e.EmployeeID IS NULL

--16.
SELECT od.ProductID, p.ProductName, SUM(od.ProductID) TotalOrders
FROM [Order Details] od JOIN Products p ON od.ProductID=p.ProductID 
GROUP BY p.ProductName, od.ProductID

--17.
--a. using union
SELECT City 
FROM (
    SELECT CustomerID, City, RANK() OVER(PARTITION BY City ORDER BY CustomerID) RNK
    FROM Customers) dt
WHERE RNK>2
UNION
SELECT City 
FROM (
    SELECT CustomerID, City, RANK() OVER(PARTITION BY City ORDER BY CustomerID) RNK
    FROM Customers) dt
WHERE RNK>2
--b. not using union
SELECT City, COUNT(CustomerID) NumOfCustomers
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) > 2

--18.
SELECT c.City, COUNT(DISTINCT od.ProductID) NumOfProducts
FROM Orders o JOIN Customers c ON o.CustomerID=c.CustomerID JOIN [Order Details] od ON od.OrderID=o.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID)>2

--19.
SELECT dt2.ProductID, dt2.ProductName, dt2.TotalOrders, dt2.AvgPrice, dt.City 
FROM (
    SELECT c.CustomerID, c.City, od.ProductID, SUM(od.Quantity) TotalOrders, RANK() OVER(PARTITION BY od.ProductID ORDER BY SUM(od.Quantity) DESC) Ranking
    FROM Orders o JOIN Customers c ON o.CustomerID=c.CustomerID JOIN [Order Details] od ON o.OrderID=od.OrderID
    GROUP BY c.CustomerID, c.City, od.ProductID) dt JOIN (
        SELECT TOP 5 p.ProductID, p.ProductName, SUM(od.Quantity) TotalOrders, AVG(od.UnitPrice) AvgPrice
        FROM [Order Details] od JOIN Products p ON od.ProductID=p.ProductID
        GROUP BY p.ProductID, p.ProductName
        ORDER BY TotalOrders DESC        
    ) dt2 ON dt.ProductID=dt2.ProductID
WHERE dt.Ranking=1

--20. 
SELECT dt1.City
FROM (SELECT TOP 1 e.City, COUNT(o.OrderID) AS TotalOrders
FROM Orders o JOIN Employees e ON o.EmployeeID=e.EmployeeID
GROUP BY e.City
ORDER BY TotalOrders DESC) dt1 JOIN (
SELECT TOP 1 e.City, SUM(od.Quantity) AS TotalQuantity
FROM Orders o JOIN [Order Details] od ON o.OrderID=od.OrderID JOIN Employees e ON o.EmployeeID=e.EmployeeID
GROUP BY e.City
ORDER BY TotalQuantity DESC) dt2 ON dt1.City=dt2.City

--21.
--I can use the rank function with the partition by clause to group duplicate rows together and rank each row within each group. Then delete rows with rank > 1.