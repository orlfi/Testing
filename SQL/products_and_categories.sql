create database Test;
USE Test;

CREATE TABLE products(
	id INT NOT NULL PRIMARY KEY,
	name NVARCHAR(20)
);

CREATE TABLE categories(
	id INT NOT NULL PRIMARY KEY,
	name NVARCHAR(20)
);

CREATE TABLE categories_products(
	product_id INT NOT NULL,
	category_id INT NOT NULL,
	PRIMARY KEY(product_id, category_id)
);

ALTER TABLE categories_products
	ADD CONSTRAINT categories_products_product_id_fk
	FOREIGN KEY (product_id)
	REFERENCES products(id);

ALTER TABLE categories_products
	ADD CONSTRAINT categories_products_category_id_fk
	FOREIGN KEY (category_id)
	REFERENCES categories(id);

INSERT INTO products 
		(id, name)
	VALUES 
		(1, '���������'), (2, '����������'), (3, '����������� �����'), (4, '������� HP'),
		(5, '������� HP'), (6, '������� DELL'), (7, '������� Samsung'), (8, '��� APC'),
		(9, 'HDD Seagate'), (10, '�������� Hyper'), (11, 'SSD Intel'), (12, 'SD ����� Sony');


INSERT INTO categories
		(id, name)
	VALUES 
		(1, '����������'), (2, '�������������'), (3, '��������'),
		(4, '����������'),(5, '��������'), (6, '����������');

INSERT INTO categories_products 
		(product_id, category_id)
	VALUES
		(1, 1), (1, 2), (2, 1), (2, 2),(3, 1), (3, 2), (4, 3), (5, 3),(6, 1), (6, 5), 
		(7, 1), (7, 5), (9, 1), (9, 2), (9, 4), (11, 1), (11, 2), (11, 4),(12, 4);

SELECT 
	products.name as product_name,
	categories.name as category_name
FROM products
	LEFT JOIN categories_products 
		ON products.id =  categories_products.product_id
	LEFT JOIN categories
		ON categories.id =  categories_products.category_id;
