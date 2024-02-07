create schema db_escola character set utf8;

CREATE TABLE tb_aluno(
id_cpf_aluno VARCHAR(14) NOT NULL,
nome_aluno VARCHAR(200),	
data_nascimento DATE  NOT NULL,

PRIMARY  KEY( id_cpf_aluno)
);

CREATE TABLE tb_professor(
id_cpf_professor VARCHAR(14) NOT NULL,
nome_professor VARCHAR(200),	
data_nascimento DATE  NOT NULL,
disciplina VARCHAR(100) NOT NULL,
id_cpf_aluno VARCHAR(14) NOT NULL,

PRIMARY  KEY( id_cpf_professor)

);

CREATE TABLE tb_endereco(
cep VARCHAR(20) NOT NULL,
logradouro VARCHAR(200) NOT NULL,
numero INT NOT NULL,
bairro VARCHAR(100) NOT NULL,
localidade VARCHAR(100),
uf VARCHAR(100) NOT NULL,
id_cpf_aluno VARCHAR(14) NOT NULL,


CONSTRAINT fk_tb_aluno	
FOREIGN KEY (id_cpf_aluno)
REFERENCES tb_aluno (id_cpf_aluno)

);

INSERT INTO tb_endereco(cep,logradouro, complemento,bairro,localidade,uf,ibge,gia,ddd,siafi)
 VALUES("53190000","Rua Tijuca", "Casa","Aguas Compridas","Alto","pe"," ", " ",81," ");



SET SQL_SAFE_UPDATES =0;
SELECT *FROM tb_endereco;
SELECT * FROM tb_aluno;
SELECT * FROM tb_professor;

select *from tb_aluno where id_cpf_aluno = "55555555555";

drop  table tb_endereco;
drop  table tb_professor;

DELETE FROM tb_endereco;
DELETE FROM tb_aluno;
DELETE FROM tb_professor;

INSERT INTO tb_aluno ( id_cpf_aluno, nome_aluno, data_nascimento) VALUES("11122233366","nome","2099-05-30");