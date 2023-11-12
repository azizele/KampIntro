--Select

SELECT ContactName Adi,CompanyName Sırketadi,City Sehir FROM Customers

Select * from Customers where City ='Berlin'

--case insensitive
select *from Products where CategoryID=1 or CategoryID=3

select *from Products where CategoryID=1 and UnitPrice>=10

select *from Products where CategoryID=1 or UnitsInStock=1


Select * from Customers where City='Mannheim'

select * from Products where CategoryID=3 order by UnitPrice desc --ascending artan demek --descending azalan düşen diye kodla

Select COUNT(*) from Products --tüm satırları say demektir count(*) kaçtane ürün listeliyoruz derse bu sorguyu atıyoruz

Select Count(*)  Adet from Products  where CategoryID=2

Select Count(*) CategoriSayisi from Categories -- kendim yazdım 

Select COUNT(*) Adet from Products

Select * from Products group by CategoryID

Select CategoryId,COUNT(*) from Products group by CategoryID -- gruop by nedemek -- bana verileri tekrar etmeyecek şekilde getir demektir group by 

select ProductId from Products group by ProductID --kendim yazdım 

Select CategoryId,COUNT(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

Select CategoryId,COUNT(*) from Products group by CategoryID

Select  Products.ProductId,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories -- burda hem products hemde categories bir araya getirir inner join
on Products.CategoryID = Categories.CategoryID --neye göre biraraya getirecem on ile tabloları birleşriyoruz 
where Products.UnitPrice>10
-- DTO Data Transformation object ilerde c# da bunu göreceğiz joinler 
-- işte dto olarak karşımıza çıkıyor angular ile bu tabloları güzelleştireceğiz ilerde 

Select * from Products p inner join [Order Details] od --left solda olup sağda olmayanları getirir
on p.ProductID=od.ProductID
inner join Orders o 
on o.OrderID= od.OrderID

Select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerID is null







