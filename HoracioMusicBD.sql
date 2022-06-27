create database HoracioMusic;
use HoracioMusic;

create table login(

CodigoLogin int not null auto_increment primary key,
usuario varchar(100) not null,
senha varchar(100) not null

)Engine = InnoDB

select * from login;

create table cadastro(

CodigoCadastro int not null  auto_increment primary key,
nomeCompleto varchar (100) not null,
usuario varchar (100) not null,
senha varchar (25) not null

)Engine = InnoDB;

select * from cadastro;
