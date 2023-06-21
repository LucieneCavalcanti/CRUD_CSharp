create database bdPOO;
use database bdPOO;

create table tbAlunos
(
id int not null auto_increment primary key,
nome varchar(200) not null,
email varchar(200) not null,
escola varchar(100) not null,
anoEscolar varchar(10) not null,
turma varchar(10) not null
)

select * from tbalunos t 
insert into tbalunos (nome,email,escola,anoEscolar,turma) values ('Ricardo','asfasfsadfulher@gmail','IFSP','2','A')

create table tbAulas
(
id int not null auto_increment primary key,
descricao varchar(200) not null,
anoEscolar varchar(10) not null,
turma varchar(10) not null
)

select * from tbaulas

create table tbhorarios(
id int not null auto_increment primary key,
disciplina varchar(200) not null,
horarioEntrada varchar(5) not null,
horarioSaida varchar(5) not null,
diaSemana varchar(15) not null
)