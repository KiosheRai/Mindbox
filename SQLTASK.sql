
CREATE DATABASE MindBox;
USE MindBox;
GO

CREATE TABLE Products(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
CREATE TABLE Category(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
CREATE TABLE Products_Category(products_id INT NOT NULL, category_id INT NOT NULL);

INSERT INTO Products VALUES
(1, 'Яблоко'),
(2, 'Дыня'), 
(3, 'Арбуз');
INSERT INTO Category VALUES
(1, 'Фрукты'), 
(2, 'Спелые');
INSERT INTO Products_Category VALUES(1, 1), (2, 1), (3, 2);

SELECT products.name as 'Product', category.name as 'Category' FROM Products products
    LEFT JOIN Products_Category products_category ON products.id = products_category.products_id
    INNER JOIN Category category ON category.id = products_category.category_id
ORDER BY products.name;
