create database Tcc;
use Tcc;
drop database Tcc;

create table tb_login(
id_login int primary key auto_increment,
ds_email varchar(30),
ds_senha varchar(30),
ds_perfil varchar(50)
);

create table tb_cliente(
id_cliente int primary key auto_increment,
nm_cliente varchar(100),
dt_nascimento date,
ds_cpf varchar (15),
ds_rg varchar(15),
ds_cartao_credito varchar(100),
ds_endereco varchar(50),
ds_telefone varchar(50),

id_login int,
foreign key (id_login) references tb_login (id_login) 
);

create table tb_empregado(
id_empregado int primary key auto_increment,
nm_empregado varchar(100),
dt_nascimento date,
ds_cpf varchar(15),
ds_cep varchar(15),
ds_rg varchar(15),
ds_carteira_trabalho varchar(50),
ds_cargo varchar(50),
ds_carga_horaria_semanal varchar (100),
vl_salario decimal (15,2),

id_login int,
foreign key (id_login) references tb_login(id_login)
);

create table tb_livro (
id_livro int primary key auto_increment,
nm_livro varchar(50),
nm_autor varchar(50),
nr_serie varchar(50),
nm_editora varchar(50),
nr_paginas int,
ds_sinopse varchar(300),
dt_publicacao date,
tp_idioma_original varchar(100),
ds_edicao_livro varchar(100),
ds_genero varchar(100),
vl_preco decimal (15,2),
img_imagem varchar(100) default 'sem-imagem.jpg'
);

create table tb_compra(
id_compra int primary key auto_increment,
dt_compra date,
vl_total decimal (15,2) ,

id_cliente int,
foreign key (id_cliente) references tb_cliente(id_cliente)
);

create table tb_compra_livro(
id_compra_livro int primary key auto_increment,
id_livro int, 
id_compra int,

foreign key (id_livro) references tb_livro(id_livro),
foreign key (id_compra) references tb_compra(id_compra)
);

select * from tb_empregado;
select * from tb_login;
select * from tb_cliente;
select * from tb_livro;
select * from tb_compra;
select * from tb_compra_livro;

insert into tb_login (ds_email, ds_senha,ds_perfil)
values("chefe@gmail.com","1234","gerente");

insert into tb_login (ds_email, ds_senha,ds_perfil)
values("bruno@gmail.com","1313","cliente");

insert into tb_login (ds_email, ds_senha,ds_perfil)
values("funcionario@gmail.com","123456","funcionario");


insert into tb_cliente(nm_cliente,dt_nascimento,ds_cpf,ds_rg,id_login, ds_cartao_credito,ds_endereco,ds_telefone)
value("Bruno Gomes",'2002-11-22',"123.132.122-22","23443.23",2,"1244 2345 1345 4545","rua bofim n°31","(11) 92345-2345");


insert into tb_empregado(nm_empregado,dt_nascimento,ds_cpf,ds_cep,ds_rg,ds_carteira_trabalho,ds_cargo,ds_carga_horaria_semanal,vl_salario,id_login)
values ("joao rocha",'1999-11-12',"234.590.231-12","234.044.132-44","13423.22","APOD323","funcionario","44 horas",1200.90,3);

insert into tb_empregado(nm_empregado,dt_nascimento,ds_cpf,ds_cep,ds_rg,ds_carteira_trabalho,ds_cargo,ds_carga_horaria_semanal,vl_salario,id_login)
values ("guilherme santos",'1991-1-01',"234.590.231-12","234.234.311-44","23423.92","APOD323","gerente","50 horas",1800,1);


insert into tb_livro(nm_livro,nm_autor,nr_serie,nm_editora,nr_paginas,ds_sinopse,dt_publicacao,tp_idioma_original,ds_edicao_livro,ds_genero,vl_preco)
values("pequeno principe","antoine","volume 2","reyone",120,"um livro para criancas,sobre crescer",'2003-2-2',"portugues",'3',"aventura",110.90);

insert into tb_livro(nm_livro,nm_autor,nr_serie,nm_editora,nr_paginas,ds_sinopse,dt_publicacao,tp_idioma_original,ds_edicao_livro,ds_genero,vl_preco)
values("harry potter","j.k","volume 7","empresa 1",400,"um livro sobre magia",'2005-12-10',"ingles",'2',"aventura",140.90);


insert into tb_compra(dt_compra,vl_total,id_cliente)
values("2020-01-01",251.80,1);


insert into tb_compra_livro(id_livro,id_compra)
values(2,1);

insert into tb_compra_livro(id_livro,id_compra)
values(1,1);
