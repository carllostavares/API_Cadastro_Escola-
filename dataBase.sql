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

PRIMARY  KEY( id_cpf_professor)
);

SET SQL_SAFE_UPDATES = 0;

SELECT * FROM tb_aluno;
SELECT * FROM tb_professor;

select *from tb_aluno where id_cpf_aluno = "55555555555";

drop  table tb_aluno;
drop  table tb_professor;

DELETE FROM tb_aluno;
DELETE FROM tb_professor;

INSERT INTO tb_aluno ( id_cpf_aluno, nome, data_nascimento) VALUES("id_cpf_aluno","nome","2099-05-30");