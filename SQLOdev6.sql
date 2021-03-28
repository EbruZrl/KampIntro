Select p.ProductName As [Ürün Adı],
Sum( p.UnitPrice  * od.Quantity ) As [Kazanılan Toplam Miktar]
From Products p
Inner Join [Order Details] od On p.ProductID = od.ProductId
Inner Join Orders o On o.OrderID = od.OrderID
Group By p.ProductName
Order By p.ProductName;