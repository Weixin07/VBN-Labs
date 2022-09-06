/*
create database Cafeteria_Management_System

Create table Tables(
Table_ID nvarchar(50) Not Null Primary Key,
Name nvarchar(50),
Contact_Number nvarchar(50)
);

Create table Orders(
Menu_ID nvarchar(50) Not Null Primary Key,
Name nvarchar(50),
Price int,
Table_ID nvarchar(50) Foreign Key References Tables(Table_ID)
);

Insert into Tables values
('A01','Pearson','0123456789'),
('A02','Deitel','0104356734'),
('B01','Rainbow','0189413678');

Insert into Orders values
('S01','Maths','50','A01'),
('S02','Science','100','B01'),
('S03','English','89','A02'),
('S04','Biology','150','A02');
*/