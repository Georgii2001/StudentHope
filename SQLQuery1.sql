CREATE DATABASE dbStudentHope
USE dbStudentHope


CREATE TABLE tAngajati(
 Firma varchar(50) constraint pk_Angajati PRIMARY KEY,
 Parola varchar(20)	NOT NULL,
 Email varchar(20) NOT NULL 
)

ALTER TABLE tAngajati
ADD UNIQUE(Email)


CREATE TABLE tJoburi(
 idJob int constraint pk_tJoburi PRIMARY KEY,
 Firma varchar(50) NOT NULL constraint fk_Angajati FOREIGN KEY references tAngajati(Firma) on DELETE CASCADE,
 Departament varchar(50) NOT NULL ,
 Studii varchar(20) NOT NULL,
 Oras varchar(20) NOT NULL,
 Post varchar(20) NOT NULL,
 Descriere char(1500) 
)

ALTER TABLE tJoburi
ALTER COLUMN Descriere char(1500) 

CREATE TABLE tStudenti(
 Email char(50) constraint pk_tStudenti PRIMARY KEY,
 Nume varchar(20)  NOT NULL,
 Gen  varchar(10)  ,
 Studii varchar(20)  NOT NULL,
 Poza char(150)  NOT NULL,
 Cv char(150)  NOT NULL,
 Parola varchar(20)  NOT NULL,
)

CREATE TABLE tAplicatii(
 idApp int constraint pk_tAplicatii PRIMARY KEY,
 idJob int NOT NULL constraint fk_tJoburi FOREIGN KEY references tJoburi(idJob) on DELETE CASCADE,
 EmailSt char(50) NOT NULL constraint fk_tStudenti FOREIGN KEY references tStudenti(Email)on DELETE CASCADE,
 StatusApp varchar(10)  ,
 DataApp smalldatetime 
)

-- sa se verifice daca emailul si parola se potrivesc
GO
CREATE PROC ps_existaAngajat @email varchar(20), @parola varchar(20) AS
BEGIN
  if exists(select * from tAngajati where @email=Email and @parola= Parola)
   (select Firma from tAngajati where @email=Email and @parola= Parola)
  END

exec ps_existaAngajat 'roweb@gmail.com','roweb'

GO 
CREATE PROC ps_existaStudent @email char(50), @parola varchar(20) AS
BEGIN
   if exists(select * from tStudenti where @email=Email and @parola= Parola)
   return 1
   else
   return 0
END

GO 
CREATE PROC ps_existaAplicatia @email char(50), @idJob varchar(20) AS
BEGIN
   if exists(select * from tAplicatii where @email=EmailSt and @idJob= idJob)
   return 1
   else
   return 0
END

DECLARE f int;  
 set f= ps_existaStudent 'roweb@gmail.com','roweb'

 select count(idJob) from tJoburi
 delete from tAngajati where Email=''

 
 GO
  select *   from tAplicatii
   select *  from tAngajati
  select * from tJoburi where firma='roweb'

  delete from tJoburi where idJob= '2'

  update tStudenti set Parola= 'georgiana' where Email= 'georiana.voicea@gmail.com' 
   update tAplicatii set StatusApp = 'Citit' where idApp= '1' 


   select * from tJoburi where Post like '%excel%' or Descriere like '%excel%'

drop table tAplicatii
drop table tJoburi
drop table tStudenti
drop table tAngajati