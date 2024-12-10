CREATE DATABASE library;
USE library;
CREATE TABLE films (
    id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(50)
);


ALTER TABLE films ADD COLUMN year INT;

INSERT INTO films (title, year) VALUES 
('Interstellar', 2014),
('Transformers', 2007),
('Hackaw Ridge', 2013),
('Deadpool', 2016),
('1+1', 2011);

SELECT * FROM films;

CREATE PROCEDURE get_odd_year_films()
SELECT * FROM films WHERE year % 2 != 0;

CALL get_odd_year_films();