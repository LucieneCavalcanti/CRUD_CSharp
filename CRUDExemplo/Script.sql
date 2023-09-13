create database bdExemploCrud
use bdExemploCrud

create table tbTarefas(
id int not null primary key auto_increment,
descricao varchar(100) not null,
dataInicio date not null,
dataFinal date null,
nomeResponsavel varchar(100) null,
categoria varchar(20),
status varchar(20),
observacoes text
)