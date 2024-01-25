/* 
** Name: Cole Dorman
** Assignment: Boxstore
** Date: 2024-01-24
** History:  YYYY-MM-DD
**           Description and list of changes
**           - added changelist
**           - change 2
**           - change n
**
**           2024-01-25
**           Latest description and list of changes:
**           - 
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
DROP TABLE IF NOT exists people;
CREATE TABLE IF not EXISTS people (
  p_id MEDIUMINT AUTO_INCREMENT
  , full_name VARCHAR(100) NOT NULL
  , CONSTRAINT people___PK PRIMARY KEY(p_id)
  , CONSTRAINT people___UK_fullname UNIQUE(full_name ASC)
);
-- import csv file into the people table

LOAD DATA INFILE 'C:\Users\coled\Desktop\Github\schoolwork\RRC\Comp-1701\_data_imports.lnk'
INTO TABLE people
FIELDS TERMINATED BY '