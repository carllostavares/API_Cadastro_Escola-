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
REFERENCES tb_aluno (id_cpf_aluno)
ON DELETE NO ACTION
ON UPDATE NO ACTION,

CONSTRAINT fk_tb_professor	
FOREIGN KEY (id_cpf_professor)
REFERENCES tb_professor (id_cpf_professor)
ON DELETE NO ACTION
ON UPDATE NO ACTION

);

CREATE TABLE tb_materia(
id_materia INT NOT NULL,
nome VARCHAR(200) NOT NULL,
carga_horaria INT NOT NULL,
id_cpf_professor VARCHAR(11),

PRIMARY KEY (id_materia),
	
FOREIGN KEY (id_cpf_professor)
REFERENCES tb_professor (id_cpf_professor)
ON DELETE NO ACTION
ON UPDATE NO ACTION


);

CREATE TABLE tb_classe(
sala INT NOT NULL,
id_materia INT NOT NULL,
id_cpf_aluno VARCHAR(11) NOT NULL,

PRIMARY KEY (id_materia,id_cpf_aluno),

FOREIGN KEY (id_cpf_aluno)
REFERENCES tb_aluno (id_cpf_aluno)
ON DELETE NO ACTION
ON UPDATE NO ACTION,

FOREIGN KEY (id_materia)
REFERENCES tb_materia (id_materia)
ON DELETE NO ACTION
ON UPDATE NO ACTION
);
INSERT INTO tb_classe (sala,id_materia, id_cpf_aluno) VALUES(01,"12", "11756898974"),(01,"12", "88888888888");
 INSERT INTO tb_materia (id_materia,nome,carga_horaria,id_cpf_professor)VALUES
 ("12","Historia da Amériaca",60,"66548798512"),("13","Geologia",40,"55555555577");

INSERT INTO tb_professor(id_cpf_professor,nome_professor,data_nascimento,disciplina) 
VALUES("55555555577","Fia","1998-07-15","geografia"),("89555555501","Otavio","1998-07-15","historia"),
("00555555501","Otavio","1998-07-15","historia") ;

INSERT INTO tb_aluno ( id_cpf_aluno, nome_aluno, data_nascimento,id_materia) 
VALUES("11122233366","Ricardo","2099-05-30","01"),("11122233377","Paulo","2099-05-22","13"),
("11122233300","Monica","2199-10-30","12");

select * from tb_aluno where id_cpf_aluno = "55555555555";
select cep,logradouro,numero,bairro,localidade,uf from tb_endereco 
	where id_cpf_aluno = "55555555555" OR id_cpf_professor = "55555555555";

select * FROM tb_endereco where id_cpf_aluno = 77788899944;

SELECT tb_aluno.id_cpf_aluno "CPF Aluno", tb_aluno.nome_aluno "Nome Aluno", 
		tb_materia.nome "Materia", tb_materia.carga_horaria "Carga Horária",
			tb_professor.nome_professor "Nome Professor", tb_professor.disciplina "Discuplina"
				FROM tb_materia
					INNER JOIN tb_aluno ON tb_aluno.id_materia = tb_materia.id_materia
						INNER JOIN tb_professor ON tb_professor.id_cpf_professor = tb_materia.id_cpf_professor
							WHERE tb_materia.id_materia = "14";
                            
SELECT id_materia,nome, carga_horaria,id_cpf_professor FROM tb_materia;

select * from tb_materia;
select * from tb_classe;
SET SQL_SAFE_UPDATES =0;
SELECT *FROM tb_endereco;
SELECT * FROM tb_aluno;
SELECT * FROM tb_professor;
SELECT * FROM tb_materia;

drop table tb_materia;

drop  table tb_endereco;
drop  table tb_professor;

DELETE FROM tb_materia;
DELETE FROM tb_endereco;
DELETE FROM tb_aluno;
DELETE FROM tb_professor;

select id_cpf_aluno, nome_aluno, data_nascimento,id_materia from tb_aluno;