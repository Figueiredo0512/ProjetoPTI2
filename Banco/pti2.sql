create database pti2;
use pti2;
-- drop database pti2;

create table ticket (
Id_ticket int NOT NULL auto_increment primary key,
Titulo varchar(255),
Descricao text,
Dt_abertura datetime,
Dt_fechamento datetime,
Resolucao text
);

create table login (
Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
Usuario varchar (55),
Email varchar (100),
Senha varchar (100),
Tipo INT
);

create table funcionario (
Id INT NOT NULL,
Matricula int PRIMARY KEY NOT NULL AUTO_INCREMENT,
Cpf varchar(12),
Nome varchar(100),
Dt_contratacao date,
Dt_nascimento date,
Cargo int
);

create table cargo (
Id int not null primary key auto_increment,
descricao varchar(255),
titulo varchar(150)
);

create table cliente (
Id int not null,
Nome varchar(155) not null,
Cnpj varchar(155) not null primary key,
Dt_cadastro date not null,
Email varchar(255) not null,
Telefone varchar(20) not null
);

create table endereco (
Id int primary key not null auto_increment,
Logradouro varchar(255),
Cep varchar(15) not null,
Numero int not null,
Bairro varchar(255) not null,
Cidade varchar(255)not null,
Estado varchar(5) not null,
Referencia varchar(255)
);