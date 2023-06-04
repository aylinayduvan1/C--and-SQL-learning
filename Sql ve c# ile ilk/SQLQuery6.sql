create database Users
use Users

create table Bilgi(
ID int primary key,
KullaniciAdi Varchar(50),
Sifre Varchar(50),
);

 insert into Bilgi(ID, KullaniciAdi, Sifre) 
 Values (1,  'aylin ', '123 ');


 ALTER TABLE Bilgi
DROP CONSTRAINT PK__Bilgi__3214EC274DD6472C;

 ALTER TABLE Bilgi
DROP COLUMN ID;
select * from Bilgi