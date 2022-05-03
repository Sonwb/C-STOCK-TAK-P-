create table product(
id int NOT NULL IDENTITY(1,1),
barcode varchar(50) NOT NULL,
product_name varchar(50) NOT NULL,
product_detail varchar(255) ,
product_money money,
product_piece int,
PRIMARY KEY (id)

);

create table user_login(
id int NOT NULL,
user_name varchar(10)NOT NULL,
user_password varchar(30)NOT NULL
PRIMARY KEY (id)
);
drop table product

