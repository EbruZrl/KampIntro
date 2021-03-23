--Select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers
Select * from Customers where City ='Berlin'

--case insensitive
Select * from Products where CategoryID= 1 OR CategoryID=3

select * from Products where CategoryID= 1 and UnitPrice>=10

select * from Products order by UnitPrice asc --ascending
select * from Products order by UnitPrice desc --decending

select * from Products where CategoryID=1 order by UnitPrice desc --1.ıdde olanları fiyatı azalana göre sırala

Select count(*) from Products --productta kaç ürün var

select count(*) Adet from Products
select categoryID, count(*) from Products group by CategoryID 
select categoryID, count(*) from Products group by CategoryID having count(*)<10

select categoryID, count() from products where UnitPrice>20 group by CategoryID having count(*)<10