--Select
--ANSII
Select * from Customers  


Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers


Select * from Customers where City ='London'

--case insensitive büyük harf küçük harf duyarsız.

select*from Products where CategoryID=1 or CategoryID=3

select*from Products where ProductName='Chai'

select*from Products where CategoryID=1 and UnitPrice>=30

select * from Products order by ProductName

select * from Products order by CategoryID, ProductName 

Select count (*) from Products

Select count (*) from Products where CategoryID=1

select count (*) from Customers where City='Berlin'

select CategoryID,count(*) from Products group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID

-- DTO = Data Transformation Object

select * from Customers c left join Orders o 
on c.CustomerID = o.CustomerID
where o.CustomerID is null

-- yada tam tersi syntax ile de yapılır

select * from Orders o right join Customers c
on o.CustomerID=c.CustomerID where o.CustomerID
is null
