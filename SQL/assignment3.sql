--1.
CREATE VIEW view_product_order_meng
AS
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) TotalQuantity 
FROM [Order Details] od JOIN Products p ON od.ProductID=p.ProductID
GROUP BY p.ProductID, p.ProductName

--SELECT * FROM view_product_order_meng

--2.
CREATE PROC sp_product_order_quantity_meng
@ProductID INT,
@Total INT OUT
AS 
BEGIN
SELECT @Total=SUM(Quantity)
FROM [Order Details]
WHERE ProductID=@ProductID
GROUP BY ProductID
END

--BEGIN
--DECLARE @Count INT
--EXEC sp_product_order_quantity_meng 23, @Count OUT
--SELECT @Count
--END

--3.
CREATE PROC sp_product_order_city_meng
@ProductName VARCHAR(40)
AS
BEGIN
SELECT dt.ShipCity City, dt.TotalQuantity TotalQuantityOrdered
FROM (
    SELECT TOP 5 p.ProductName, o.ShipCity, SUM(od.Quantity) TotalQuantity
    FROM Orders o JOIN [Order Details] od ON o.OrderID=od.OrderID JOIN Products p ON od.ProductID=p.ProductID
    WHERE p.ProductName=@ProductName
    GROUP BY p.ProductName, o.ShipCity
    ORDER BY TotalQuantity DESC
) dt
END

--EXEC sp_product_order_city_meng 'Konbu'

--4.
CREATE TABLE City_Meng (
    ID INT,
    Name VARCHAR(15)
)
INSERT INTO City_Meng VALUES (1, 'Seattle'), (2, 'Green Bay')

CREATE TABLE People_Meng (
    ID INT,
    Name VARCHAR(30),
    City INT
)
INSERT INTO People_Meng VALUES (1,'Aaron Rodgers',2),(2,'Russell Wilson',1),(3,'Jody Nelson',2)

UPDATE People_Meng
SET People_Meng.City=3
FROM People_Meng p JOIN City_Meng c ON p.City=c.ID 
WHERE c.Name='Seattle'

DELETE FROM City_Meng WHERE Name='Seattle'
INSERT INTO City_Meng VALUES (3,'Madison')

CREATE VIEW Packers_Meng
AS
SELECT p.Name
FROM People_Meng p JOIN City_Meng c ON p.City=c.ID
WHERE c.Name='Green Bay'

--SELECT * FROM People_Meng
--SELECT * FROM City_Meng
--SELECT * FROM Packers_Meng

DROP TABLE People_Meng
DROP TABLE City_Meng
DROP VIEW Packers_Meng

--5.
CREATE PROC sp_birthday_employees_meng
AS
BEGIN
CREATE TABLE birthday_employees_meng (
    Name VARCHAR(40),
    Birthday DATETIME
)

INSERT INTO birthday_employees_meng
SELECT FirstName + ' ' + LastName, BirthDate
FROM Employees
WHERE MONTH(BirthDate)=2

SELECT * FROM birthday_employees_meng
END

EXEC sp_birthday_employees_meng

DROP TABLE birthday_employees_meng

--6.
--We can SELECT * FROM both tables and MINUS the result sets. If the two tables have the same data, this query should return nothing.
