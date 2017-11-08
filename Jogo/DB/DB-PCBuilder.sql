CREATE DATABASE [DB-PCBuilder-Usrs];
USE [DB-PCBuilder-Usrs];

CREATE TABLE COMPT(
cod_compt int not null IDENTITY(1,1),
usr_compt varchar(80) not null,
pcn_compt varchar(80) not null,
cpu_compt varchar(80) not null,
pcm_compt varchar(80) not null,
fda_compt varchar(80) not null,
ram_compt varchar(80) not null,
gpu_compt varchar(80) not null,
gab_compt varchar(80) not null,
for_compt int not null,
Primary key(cod_compt),
);

CREATE TABLE USUARIO(
cod_usuario int not null IDENTITY(1,1),
usr_usuario varchar(80) not null,
sen_usuario varchar(80) not null,
ano_usuario varchar(80) not null,
sexo_usuario varchar(80) not null,
din_usuario int,
bitm_usuario int,
vit_usuario int,
upg_usuario int not null,
Primary key(cod_usuario),
);
