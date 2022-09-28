create database pti2;
use pti2;
-- drop database pti2;

create table tbLogin (
Id_login INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
Usuario varchar (55),
Email varchar (100),
Senha varchar (100),
Dt_login datetime
);

create table tbCargo(
Id_cargo int not null primary key auto_increment,
Descricao varchar(255),
Titulo varchar(150),
Salario double not null
);

create table tbFuncionario (
Id_funcionario INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
Matricula int NOT NULL,
Cpf varchar(12) not null,
Nome varchar(100) not null,
Dt_contratacao date not null,
email varchar(100),
telefone varchar(20),
TipoLogin int not null,
Fk_id_cargo int not null,
Fk_id_ticket int,
Fk_id_login int not null
);

create table tbCliente (
Id_cliente int not null primary key auto_increment,
Nome varchar(155) not null,
Cnpj varchar(155) not null,
Dt_cadastro date not null,
Email varchar(255) not null,
Telefone varchar(20) not null,
TipoLogin int not null,
Fk_id_endereco int not null,
Fk_id_ticket int,
Fk_id_login int not null
);

create table tbEndereco (
Id_endereco int primary key not null auto_increment,
Logradouro varchar(255),
Cep varchar(15) not null,
Numero int not null,
Bairro varchar(255) not null,
Cidade varchar(255)not null,
Estado varchar(5) not null,
Referencia varchar(255)
);

create table tbTicket (
Id_ticket int NOT NULL auto_increment primary key,
Titulo varchar(255) NOT NULL,
Descricao text NOT NULL,
Dt_abertura datetime NOT NULL,
Dt_fechamento datetime NOT NULL,
Resolucao text NOT NULL,
Resolvedor int NOT NULL,
Solicitante int NOT NULL
);


ALTER TABLE tbFuncionario
ADD CONSTRAINT Fk_cargo_funcionario
FOREIGN KEY (Fk_Id_cargo)
REFERENCES tbCargo(Id_cargo);

ALTER table tbFuncionario
ADD CONSTRAINT Fk_ticket_funcionario
FOREIGN KEY (Fk_id_ticket)
REFERENCES tbTicket(Id_ticket);

ALTER TABLE tbCliente
ADD CONSTRAINT Fk_endereco_cliente
FOREIGN KEY (Fk_id_endereco)
REFERENCES tbEndereco(Id_endereco);

ALTER TABLE tbCliente
ADD CONSTRAINT Fk_ticket_cliente
FOREIGN KEY (Fk_id_ticket)
REFERENCES tbTicket(Id_ticket);

ALTER TABLE tbCliente
ADD CONSTRAINT Fk_login_cliente
FOREIGN KEY (Fk_id_login)
REFERENCES tbLogin(Id_login);

ALTER TABLE tbFuncionario
ADD CONSTRAINT Fk_login_funcionario
FOREIGN KEY (Fk_id_login)
REFERENCES tbLogin(Id_login);


-- select * from tbCargo