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
pchack_usuario int,
sevhack_usuario int,
vitapr_usuario int,
vitmulti_usuario int,
Primary key(cod_usuario),
);

CREATE TABLE HABILIDADES(
cod_habilidade int not null IDENTITY(1,1),
usr_habilidade varchar(80) not null,
pcs_habilidade int,
dpwb_habilidade int,
hack_habilidade int,
serv_habilidade int,
comp_habilidade int,
multi_habilidade int,
fact_habilidade int,
Primary key(cod_habilidade),
);

CREATE TABLE CPU(
cod_cpu int not null IDENTITY(1,1),
nome_cpu varchar(80) not null,
valor_cpu int not null,
forca_cpu int not null,
Primary key(cod_cpu),
);

CREATE TABLE PCM(
cod_pcm int not null IDENTITY(1,1),
nome_pcm varchar(80) not null,
valor_pcm int not null,
forca_pcm int not null,
Primary key(cod_pcm),
);

CREATE TABLE RAM(
cod_ram int not null IDENTITY(1,1),
nome_ram varchar(80) not null,
valor_ram int not null,
forca_ram int not null,
Primary key(cod_ram),
);

CREATE TABLE GPU(
cod_gpu int not null IDENTITY(1,1),
nome_gpu varchar(80) not null,
valor_gpu int not null,
forca_gpu int not null,
Primary key(cod_gpu),
);

CREATE TABLE FdA(
cod_fda int not null IDENTITY(1,1),
nome_fda varchar(80) not null,
valor_fda int not null,
forca_fda int not null,
Primary key(cod_fda),
);

CREATE TABLE GAB(
cod_gab int not null IDENTITY(1,1),
nome_gab varchar(80) not null,
valor_gab int not null,
forca_gab int not null,
Primary key(cod_gab),
);

CREATE TABLE SENHA(
cod_senha int not null IDENTITY(1,1),
nome_senha varchar(80),
sen_senha varchar(80),
Primary key(cod_senha),
);

CREATE TABLE MASC(
cod_masc int not null IDENTITY(1,1),
nome_masc varchar(80),
Primary key(cod_masc),
);

CREATE TABLE FEM(
cod_fem int not null IDENTITY(1,1),
nome_fem varchar(80),
Primary key(cod_fem),
);

CREATE TABLE MUSICAS(
cod_musica int not null IDENTITY(1,1),
nome_musica varchar(80) not null,
exten_musica varchar(80) not null,
Primary key(cod_musica),
); 


/*
--Inserts do BD
*/
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Atom',5000,500);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Pentium',6500,1000);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I3 1ºGer',7900,1500);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I3 2ºGer',10000,2000);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I3 3ºGer',13000,2500);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I5 1ºGer',15500,3000);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I5 2ºGer',17600,3500);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I5 3ºGer',19500,4000);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I7 1ºGer',22000,4500);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I7 2ºGer',25000,5000);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I7 3ºGer',27700,5500);
insert into CPU(nome_cpu, valor_cpu, forca_cpu) values('Intel Core I7 Extreme Edition',31000,6000);
/*Select*/
select * from CPU;
/*Select*/
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Gigabyte B150s',3500,500);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Gigabyte H150s',5500,1000);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Gigabyte Z150s',7800,1500);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Gigabyte ProGaming H1650',11000,2000);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Gigabyte ProGaming Z2300',13500,2500);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Gigabyte Extreme Edition Z3000',17500,3000);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Asus H280',4000,500);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Asus Y280s',6000,1000);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Asus A320',8300,1500);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Asus Professional Y3600s',11500,2000);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Asus Professional A4100',14000,2500);
insert into PCM(nome_pcm, valor_pcm, forca_pcm) values('Asus Edição Limitada A5200',18500,3000);
/*Select*/
select * from PCM;
/*Select*/
insert into RAM(nome_ram, valor_ram, forca_ram) values('HyperX RGB 2GB',1500,500);
insert into RAM(nome_ram, valor_ram, forca_ram) values('HyperX RGB 4GB',3500,1000);
insert into RAM(nome_ram, valor_ram, forca_ram) values('HyperX RGB 8GB',6000,1500);
insert into RAM(nome_ram, valor_ram, forca_ram) values('HyperX RGB 16GB',8500,2000);
insert into RAM(nome_ram, valor_ram, forca_ram) values('HyperX RGB 32GB',10500,2500);
insert into RAM(nome_ram, valor_ram, forca_ram) values('HyperX RGB 64GB',12000,3000);
insert into RAM(nome_ram, valor_ram, forca_ram) values('Corsair 2GB',2000,500);
insert into RAM(nome_ram, valor_ram, forca_ram) values('Corsair 4GB',4500,1000);
insert into RAM(nome_ram, valor_ram, forca_ram) values('Corsair 8GB',6000,1500);
insert into RAM(nome_ram, valor_ram, forca_ram) values('Corsair 16GB',9500,2000);
insert into RAM(nome_ram, valor_ram, forca_ram) values('Corsair 32GB',11000,2500);
insert into RAM(nome_ram, valor_ram, forca_ram) values('Corsair 64GB',13000,3000);
/*Select*/
select * from RAM;
/*Select*/
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GT 740 512MB',4000,500);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GT 840 1GB',5500,1000);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GTX 750 1.5GB',7500,1500);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GTX 950 2GB',9500,2000);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GTX 960 3GB',11000,2500);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GTX 970 4GB',13500,3000);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GTX 980 4.5GB',17500,3500);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GTX 1050 3GB',20000,4000);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GTX 1060 4GB',22500,4500);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GTX 1070 6GB',26500,5000);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('TITAN Z 8GB',29500,5500);
insert into GPU(nome_gpu, valor_gpu, forca_gpu) values('GTX 1080TI 11GB',32000,6000);
/*Select*/
select * from GPU;
/*Select*/
insert into FdA(nome_fda, valor_fda, forca_fda) values('XT 300W',2500,500);
insert into FdA(nome_fda, valor_fda, forca_fda) values('XT 450W',4000,1000);
insert into FdA(nome_fda, valor_fda, forca_fda) values('XT 600W Edição Bronze',7250,1500);
insert into FdA(nome_fda, valor_fda, forca_fda) values('XT 850W Edição Prata',10000,2000);
insert into FdA(nome_fda, valor_fda, forca_fda) values('XT 1050W Edição Dourada',12000,2500);
insert into FdA(nome_fda, valor_fda, forca_fda) values('XT 1250W Edição Platina',15000,3000);
insert into FdA(nome_fda, valor_fda, forca_fda) values('EVGA 300W',3000,500);
insert into FdA(nome_fda, valor_fda, forca_fda) values('EVGA 450W',4500,1000);
insert into FdA(nome_fda, valor_fda, forca_fda) values('EVGA 600W Edição Bronze',7750,1500);
insert into FdA(nome_fda, valor_fda, forca_fda) values('EVGA 850W Edição Prata',10500,2000);
insert into FdA(nome_fda, valor_fda, forca_fda) values('EVGA 1050W Edição Dourada',12500,2500);
insert into FdA(nome_fda, valor_fda, forca_fda) values('EVGA 1250W Edição Platina',15500,3000);
/*Select*/
select * from FdA;
/*Select*/
insert into GAB(nome_gab, valor_gab, forca_gab) values('Thermaltake Level 10',2500,500);
insert into GAB(nome_gab, valor_gab, forca_gab) values('Cooler Master HAF X',4000,1000);
insert into GAB(nome_gab, valor_gab, forca_gab) values('SilverStone Temjin TJ11',7250,1500);
insert into GAB(nome_gab, valor_gab, forca_gab) values('Themaltake VN 1000V',10000,2000);
insert into GAB(nome_gab, valor_gab, forca_gab) values('NZXT H2 Silent Midtower',12000,2500);
insert into GAB(nome_gab, valor_gab, forca_gab) values('Cooler Master Silencio 550',15000,3000);
insert into GAB(nome_gab, valor_gab, forca_gab) values('Java Cross 450',3000,1000);
insert into GAB(nome_gab, valor_gab, forca_gab) values('Mathes Uncle 320',4500,1500);
insert into GAB(nome_gab, valor_gab, forca_gab) values('Bluecase BG-024',7750,2000);
insert into GAB(nome_gab, valor_gab, forca_gab) values('Corsair Alpha',10500,2500);
insert into GAB(nome_gab, valor_gab, forca_gab) values('Sharkoon TG5',12500,3000);
insert into GAB(nome_gab, valor_gab, forca_gab) values('ATX MidTower',15500,3500);
/*Select*/
select * from GAB;
/*Select*/
insert into MASC(nome_masc) values('Guilherme');
insert into MASC(nome_masc) values('Matheus');
insert into MASC(nome_masc) values('Lucas');
insert into MASC(nome_masc) values('Luca');
insert into MASC(nome_masc) values('Pedro');
insert into MASC(nome_masc) values('Gabriel');
insert into MASC(nome_masc) values('Heitor');
insert into MASC(nome_masc) values('Gustavo');
insert into MASC(nome_masc) values('Felipe');
insert into MASC(nome_masc) values('Bruno');
insert into MASC(nome_masc) values('Diego');
insert into MASC(nome_masc) values('Edemir');
insert into MASC(nome_masc) values('Robert');
insert into MASC(nome_masc) values('João');
/*Select*/
select * from MASC;
/*Select*/
insert into FEM(nome_fem) values('Júlia');
insert into FEM(nome_fem) values('Nicolle');
insert into FEM(nome_fem) values('Gabriela');
insert into FEM(nome_fem) values('Ana Carolina');
insert into FEM(nome_fem) values('Ruth');
insert into FEM(nome_fem) values('Amanda');
insert into FEM(nome_fem) values('Julia');
/*Select*/
select * from FEM;
/*Select*/
insert into MUSICAS(nome_musica,exten_musica) values('Pumped Up','PumpedUp.mp3');
insert into MUSICAS(nome_musica,exten_musica) values('Meganovania','Megalovania.mp3');
insert into MUSICAS(nome_musica,exten_musica) values('Heathens','Heathens.mp3');
insert into MUSICAS(nome_musica,exten_musica) values('Sweet Dreams','Sweet Dreams.mp3');
insert into MUSICAS(nome_musica,exten_musica) values('I Got No Time','I Got No Time.mp3');
insert into MUSICAS(nome_musica,exten_musica) values('In The End','In The End.mp3');
insert into MUSICAS(nome_musica,exten_musica) values('Numb','Numb.mp3');
/*Select*/
select * from MUSICAS;
/*Select*/


/*
--Fim do inserts do BD
*/

select * from USUARIO; 
select * from HABILIDADES;

insert into USUARIO(usr_usuario,sen_usuario,ano_usuario,sexo_usuario,din_usuario,vit_usuario,bitm_usuario,upg_usuario,pchack_usuario,sevhack_usuario,vitapr_usuario,vitmulti_usuario) values('Admin','123','Admin','Admin',100000000,4,1000,100,0,0,0,0);
insert into USUARIO(usr_usuario,sen_usuario,ano_usuario,sexo_usuario,din_usuario,vit_usuario,bitm_usuario,upg_usuario,pchack_usuario,sevhack_usuario,vitapr_usuario,vitmulti_usuario) values('Joel','123','Admin','Admin',100000000,4,1000,100,0,0,0,0);
insert into USUARIO(usr_usuario,sen_usuario,ano_usuario,sexo_usuario,din_usuario,vit_usuario,bitm_usuario,upg_usuario,pchack_usuario,sevhack_usuario,vitapr_usuario,vitmulti_usuario) values('Jajadogão','123','Admin','Admin',100000000,4,1000,100,0,0,0,0);
insert into USUARIO(usr_usuario,sen_usuario,ano_usuario,sexo_usuario,din_usuario,vit_usuario,bitm_usuario,upg_usuario,pchack_usuario,sevhack_usuario,vitapr_usuario,vitmulti_usuario) values('lucaspvpbr2','123','Admin','Admin',100000000,4,1000,100,0,0,0,0);