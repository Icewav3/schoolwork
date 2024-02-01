/* 
* Name: Cole Dorman
* Assignment: Boxstore
* Date: 2024-01-24
* History:
*           -2024-01-23
*               - added changelog
*               - use system to ensure not running from boxstore
*               - check if DB exist if not create
*
*
*           - 2024-01-23
*               - added database loading
*               - create people table
*               - add brad and me
*/

-- -------------------------------------------------------------------
-- DROP/CREATE/USE boxstore DATABASE
USE sys;

DROP DATABASE IF EXISTS cd_0385010_boxstore;
CREATE DATABASE IF NOT EXISTS cd_0385010_boxstore
CHARSET='utf8mb4'
COLLATE='utf8mb4_unicode_ci';

USE cd_0385010_boxstore;



-- -------------------------------------------------------------------
-- create people table

DROP TABLE IF EXISTS people;
CREATE TABLE IF NOT EXISTS people (
    p_id MEDIUMINT UNSIGNED AUTO_INCREMENT
  , full_name VARCHAR(100) NOT NULL
  , CONSTRAINT people___PK PRIMARY KEY(p_id)
--  , CONSTRAINT people___PK UNIQUE(p_id ASC)

);

TRUNCATE TABLE people;

INSERT INTO people (fullname) VALUES
    ('Cole Dorman'),
    ('Brad Vincelette');
    

-- import csv file into the people table
/*
LOAD DATA INFILE 'C:/_data/_imports/coledorman_0385010_boxstore_people_10000.csv'
INTO TABLE people
FIELDS TERMINATED BY '\n'
(full_name);

SELECT p_id, full_name
FROM people
ORDER BY p_id DESC
LIMIT 100;
*/
ALTER TABLE people
  ADD COLUMN  IF NOT EXISTS first_name VARCHAR(35) NULL,
  ADD COLUMN IF NOT EXISTS last_name VARCHAR(35) NULL;
/*
SELECT p_id, full_name
  , INSTR(full_name, ' ') AS space_loc, 1
  , INSTR(full_name, ' ') + 1 AS first_name_begin
  , INSTR(full_name, ' ') - 1 AS first_name_end
  , INSTR(full_name, ' ') + 1 AS last_name_begin
  , CHAR_LENGTH(full_name) AS last_name_end
  , MID(full_name, 1, INSTR(full_name, ' ') - 1) AS first_name
  , MID(full_name, INSTR(full_name, ' ') + 1, CHAR_LENGTH(full_name) - INSTR(full_name, ' ') - 1) AS last_name;
*/
UPDATE people
SET first_name = MID(full_name, 1, INSTR(full_name, ' ') - 1)
, last_name MID(full_name, INSTR(full_name, ' ') + 1, CHAR_LENGTH(full_name)
WHERE 1=1

SELECT p_id, full_name, first_name, last_name
FROM people
ORDER BY p_id
LIMIT 2;