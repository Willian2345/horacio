create database Bdlogin;
use Bdlogin;
create table Cadastro(
	codigo int not null auto_increment primary key,
    nomeCompleto varchar(50) not null,
    usuario varchar(50) not null,
    senha varchar(30) not null
    )engine = InnoDB;
    
    
select* from Cadastro

