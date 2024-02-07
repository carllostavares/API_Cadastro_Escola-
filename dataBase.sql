create schema db_escola character set utf8;

CREATE TABLE tb_aluno(
id_cpf_aluno VARCHAR(11) NOT NULL,
nome_aluno VARCHAR(200),	
data_nascimento DATE  NOT NULL,

PRIMARY  KEY( id_cpf_aluno)
);

CREATE TABLE tb_professor(
id_cpf_professor VARCHAR(11) NOT NULL,
nome_professor VARCHAR(200),	
data_nascimento DATE  NOT NULL,
disciplina VARCHAR(100) NOT NULL,

PRIMARY  KEY( id_cpf_professor)

);

CREATE TABLE tb_endereco(
cep VARCHAR(20) NOT NULL,
logradouro VARCHAR(200) NOT NULL,
numero VARCHAR(10) NOT NULL,
bairro VARCHAR(100) NOT NULL,
localidade VARCHAR(100),
uf VARCHAR(100) NOT NULL,
id_cpf_aluno VARCHAR(11),
id_cpf_professor VARCHAR(11),

CONSTRAINT fk_tb_aluno	
FOREIGN KEY (id_cpf_aluno)
REFERENCES tb_aluno (id_cpf_aluno),

CONSTRAINT fk_tb_professor	
FOREIGN KEY (id_cpf_professor)
REFERENCES tb_professor (id_cpf_professor)

);

CREATE TABLE tb_materia(
id_materia VARCHAR(200) NOT NULL,
nome VARCHAR(200) NOT NULL,
carga_horaria INT NOT NULL,
id_cpf_professor VARCHAR(11),

PRIMARY KEY (id_materia),
	
FOREIGN KEY (id_cpf_professor)
REFERENCES tb_professor (id_cpf_professor)
);

 
INSERT INTO tb_materia(id_materia,nome,carga_horaria,id_cpf_professor) VALUES("123", "Artes", 60,"22222222222222");

INSERT INTO tb_aluno ( id_cpf_aluno, nome_aluno, data_nascimento) VALUES("11122233366","nome","2099-05-30");

select * from tb_aluno where id_cpf_aluno = "55555555555";
select cep,logradouro,numero,bairro,localidade,uf from tb_endereco where id_cpf_aluno = "55555555555" OR id_cpf_professor = "55555555555";

select * FROM tb_endereco where id_cpf_aluno = 77788899944;

select * from tb_endereco;
SET SQL_SAFE_UPDATES =0;
SELECT *FROM tb_endereco;
SELECT * FROM tb_aluno;
SELECT * FROM tb_professor;
SELECT * FROM tb_materia;


drop  table tb_endereco;
drop  table tb_professor;

DELETE FROM tb_materia;
DELETE FROM tb_endereco;
DELETE FROM tb_aluno;
DELETE FROM tb_professor;

