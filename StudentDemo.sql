IF EXISTS(SELECT * FROM SYSOBJECTS WHERE Name='StudentDemo') 
DROP TABLE StudentDemo 
GO

CREATE TABLE StudentDemo
(
     StudentID int PRIMARY KEY,
     StudentName varchar(30),
     Mobile bigint,
     Email varchar(75)
)

INSERT INTO StudentDemo
VALUES(1,'Amit',9953412789,'amit@yahoo.com')

INSERT INTO StudentDemo
VALUES(2,'Manoj',9851243678,'manoj@gmail.com')

INSERT INTO StudentDemo
VALUES(3,'Ketaki',7724136541,'ketaki@rediffmail.com')

INSERT INTO StudentDemo
VALUES(4,'Sanjana',8876214534,'sanjana@live.in')
