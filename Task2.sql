---CREATE TABLE Product_Category(
---Product_id INT FOREIGN KEY REFERENCES Products(Id) NULL,
---Category_id INT FOREIGN KEY REFERENCES Category(Id) NULL 
---)
SELECT Products.ProductName, Category.CategoryName
FROM Product_Category
RIGHT JOIN Products ON (Product_Category.Product_id = Products.Id)
LEFT JOIN Category ON (Product_Category.Category_id = Category.Id)