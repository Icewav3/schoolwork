/* 
** Name: Cole Dorman
** Assignment: Boxstore
** Date: 2024-01-24
** History:
**           - 1/23/2024 added changelog
**           - 1/26/2024 added database loading
**/

-- -------------------------------------------------------------------
-- DROP/CREATE/USE boxstore DATABASE
USE sys;

DROP DATABASE IF EXISTS cd_0385010_boxstore;
CREATE DATABASE IF NOT EXISTS cd_0385010_boxstore
CHARSET='utf8mb4'
COLLATE='utf8mb4_unicode_ci';

USE cd_0385010_boxstore;
-- create people table
DROP TABLE IF EXISTS people;
CREATE TABLE IF NOT EXISTS people (
  p_id MEDIUMINT AUTO_INCREMENT
  , CONSTRAINT people___PK PRIMARY KEY(p_id)
  , CONSTRAINT people___PK UNIQUE(p_id ASC)
  , full_name VARCHAR(100) NULL
);

-- import csv file into the people table

LOAD DATA INFILE '\_data\_imports/coledorman_0385010_boxstore_people_10000.csv'
INTO TABLE people
FIELDS TERMINATED BY '\n'(
full_name);

SELECT p_id, full_name
FROM people
ORDER BY p_id DESC
LIMIT 100;