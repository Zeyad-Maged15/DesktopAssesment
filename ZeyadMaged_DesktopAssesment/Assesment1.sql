Create Table Userr
(
userid int Identity,
usUsername varchar(100),
usPassword varchar(100),
Age varchar(100),
Gender varchar(100),
Phonenumber varchar(11),
City varchar(100),
);

Insert Into Userr Values
('Zeyad','123','16','Male','01065225951','Giza'),
('Ali','1234','17','Male','01165225951','Cairo');

Create Table Adminn
(
admin_id int Primary Key identity,
admin_username varchar(100),
admin_pass varchar(100),
);

Insert Into Adminn Values
('zeyad123','123');