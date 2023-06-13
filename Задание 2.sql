/* Создание и заполнение таблицы
CREATE TABLE category (
  cid INT PRIMARY KEY,
  category_name varchar(100)
);
-- create
CREATE TABLE product (
  pid INT PRIMARY KEY,
  product_name varchar(100)
);
-- create
CREATE TABLE category_product (
  category_id INT,
  product_id INT,
  FOREIGN KEY (category_id)  REFERENCES category (cid),
  FOREIGN KEY (product_id)  REFERENCES product (pid)
);

INSERT INTO category (cid,category_name) VALUES 
('1','category1'),('2','category2'),('3','category3'),('4','category4'); 

INSERT INTO product (pid,product_name) VALUES 
('1','product1'),('2','product2'),('3','product3'),('4','product4'); 


INSERT INTO category_product (category_id, product_id) VALUES 
('1', '1' ),( '1', '2' ),( '1', '3' ),( '2', '3' ); 
*/

SELECT p.product_name, c.category_name FROM product p
left join category_product cp on cp.product_id = p.pid
left join category c on c.cid = cp.category_id;