# Задание №1 (C#)

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

# Задание №2 (SQL)

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 

## Создание и заполнение таблиц

```sql
CREATE TABLE Product (
	Product_ID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(255) NOT NULL 
);


CREATE TABLE Category (
	Category_ID INT PRIMARY KEY IDENTITY, 
	Type VARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategory (
    ProductID INT NOT NULL, 
    CategoryID INT NOT NULL,
    PRIMARY KEY (ProductID, CategoryID), 
    FOREIGN KEY (ProductID) REFERENCES Product(Product_ID) ON DELETE CASCADE,
    FOREIGN KEY (CategoryID) REFERENCES Category(Category_ID) ON DELETE CASCADE 
);


INSERT INTO Product VALUES ('Яблоко'), ('Фундук'), ('Виноград'), ('Огурец'), ('Гурша');
INSERT INTO Category VALUES ('Фрукты'), ('Овощи'), ('Ягоды');
INSERT INTO ProductCategory VALUES (1, 1), (1, 3), (3, 3), (4, 2), (5, 1);

```


Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

## Решение 
```sql
SELECT Product.Name AS ProductName, Category.Type AS Type
FROM Product
LEFT JOIN ProductCategory ON Product.Product_ID = ProductCategory.ProductID
LEFT JOIN Category ON ProductCategory.CategoryID =  Category.Category_ID;
```

## Результат запроса

| <b>ProductName </b> | <b> Type </b>|
|-------------|--------------|
|Яблоко       |Фрукты        |
|Яблоко	      |Ягоды         |
|Фундук       |NULL          |
|Виноград     |Ягоды         |
|Огурец       |Овощи         |
|Груша	      |Фрукты        |
