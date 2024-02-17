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
-- geo address type table

DROP TABLE IF EXISTS geo_address_type;
CREATE TABLE IF NOT EXISTS geo_address_type (
    addr_type_id TINYINT      AUTO_INCREMENT
  , addr_type    VARCHAR(15)  NOT NULL
  , active       BIT          NOT NULL   DEFAULT 1
  , CONSTRAINT gat_PK PRIMARY KEY(addr_type_id)
  , CONSTRAINT gat_UK UNIQUE     (addr_type ASC)
);
TRUNCATE TABLE geo_address_type;
INSERT INTO geo_address_type (addr_type)
VALUES                       ('Apartment')
                            ,('Building')
                            ,('Condominium')
                            ,('Head Office')
                            ,('Townhouse')
                            ,('Warehouse')
                            ,('Other')
;
SELECT gat.addr_type_id, gat.addr_type, gat.active
FROM geo_address_type gat
WHERE gat.active=1;

-- JOIN
                    


-- -------------------------------------------------------------------
-- geo country table
DROP TABLE IF EXISTS geo_country;
CREATE TABLE IF NOT EXISTS geo_country (
    co_id   TINYINT     AUTO_INCREMENT
  , co_name VARCHAR(60) NOT NULL
  , co_abbr CHAR(2)     NOT NULL
  , active  BIT         NOT NULL DEFAULT 1
  , CONSTRAINT gco_PK PRIMARY KEY(co_id)
  , CONSTRAINT gco_UK_name UNIQUE (co_name ASC)
  , CONSTRAINT gco_UK_abbr UNIQUE (co_abbr ASC)
);
TRUNCATE TABLE geo_country;
INSERT INTO geo_country (co_name, co_abbr)
VALUES            ('Canada','CA')
                , ('Japan','JP')
                , ('South Korea','KR')
                , ('United States of America','US');
SELECT gco.co_id, gco.co_name, gco.co_abbr
     , gco.active
FROM   geo_country gco
WHERE  gco.active=1;
-- JOIN

-- -------------------------------------------------------------------
-- geo region table
DROP TABLE IF EXISTS geo_region;
CREATE TABLE IF NOT EXISTS geo_region (
    rg_id     SMALLINT    AUTO_INCREMENT
  , rg_name   VARCHAR(50) NOT NULL
  , rg_abbr   CHAR(2) 
  , co_id     TINYINT     NOT NULL
  , active    BIT         NOT NULL  DEFAULT 1
  , CONSTRAINT grg_PK PRIMARY KEY(rg_id)
  , CONSTRAINT grg_UK 
        UNIQUE (co_id ASC, rg_name DESC)
);
TRUNCATE TABLE geo_region;
INSERT INTO geo_region (rg_name, rg_abbr, co_id)
VALUES                 ('Manitoba', 'MB', 1)
                     , ('Tokyo', '', 2)
                     , ('Osaka', '', 2)
                     , ('Gyeonggi', '', 3)
                     , ('California', '', 4)
                     , ('Texas', '', 4)
                     , ('Washington', '', 4);
SELECT grg.rg_id, grg.rg_name, grg.rg_abbr
     , grg.active
FROM   geo_region grg
WHERE  grg.active=1;

-- JOIN

-- -------------------------------------------------------------------
-- geo towncity table
DROP TABLE IF EXISTS geo_towncity;
CREATE TABLE IF NOT EXISTS geo_towncity (
    tc_id    MEDIUMINT    AUTO_INCREMENT
  , tc_name  VARCHAR(15)  NOT NULL
  , rg_id    SMALLINT     NOT NULL
  , active   BIT          NOT NULL DEFAULT 1
  , CONSTRAINT gtc_PK PRIMARY KEY(tc_id)
  , CONSTRAINT gtc_UK 
        UNIQUE (rg_id ASC, tc_name ASC)
);
TRUNCATE TABLE geo_towncity;
INSERT INTO geo_towncity (tc_name, rg_id)
VALUES                   ('Winnipeg', 1)
                       , ('Chiyoda', 2)
                       , ('Minato', 2)
                       , ('Kadoma', 3)
                       , ('Suwon', 4)
                       , ('Seoul', 4)
                       , ('Los Altos', 5)
                       , ('Santa Clara', 5)
                       , ('Round Rock', 6)
                       , ('Redmond', 7);
SELECT gtc.tc_id, gtc.tc_name, gtc.rg_id
     , gtc.active
FROM   geo_towncity gtc
WHERE  gtc.active=1;

-- JOIN
-- -------------------------------------------------------------------
-- create geo_addr_type table
DROP TABLE IF EXISTS geo_addr_type;
CREATE TABLE IF NOT EXISTS geo_addr_type (
    addr_type_id TINYINT UNSIGNED AUTO_INCREMENT PRIMARY KEY,
    addr_type VARCHAR(15) NOT NULL,
    active BIT NOT NULL DEFAULT 1
);

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

LOAD DATA INFILE 'C:/_data/_imports/coledorman_0385010_boxstore_people_10000.csv'
INTO TABLE people
FIELDS TERMINATED BY '\n'
(full_name);

SELECT p_id, full_name
FROM people
ORDER BY p_id DESC
LIMIT 100;

ALTER TABLE people
  ADD COLUMN  IF NOT EXISTS first_name VARCHAR(35) NULL,
  ADD COLUMN IF NOT EXISTS last_name VARCHAR(35) NULL;
UPDATE people

--Data split
SET first_name = MID(full_name, 1, INSTR(full_name, ' ') - 1),
  last_name = MID(full_name, INSTR(full_name, ' ') + 1, CHAR_LENGTH(full_name))
WHERE 1=1;
----- modify tables

ALTER TABLE people 
    DROP COLUMN   full_name
  , MODIFY COLUMN first_name VARCHAR(40) NOT NULL
  , MODIFY COLUMN last_name  VARCHAR(40)
  , ADD COLUMN email_addr    VARCHAR(50)
  , ADD COLUMN password      CHAR(32)
  , ADD COLUMN phone_pri     VARCHAR(15)
  , ADD COLUMN phone_sec     VARCHAR(15) 
  , ADD COLUMN phone_fax     VARCHAR(15) 
  , ADD COLUMN addr_prefix   VARCHAR(10) 
  , ADD COLUMN addr          VARCHAR(60) 
  , ADD COLUMN addr_code     CHAR(7) 
  , ADD COLUMN addr_info     VARCHAR(191) 
  , ADD COLUMN addr_delivery VARCHAR(191) 
  , ADD COLUMN addr_type_id  TINYINT(4)   -- FK geo_address_type
  , ADD COLUMN tc_id         INT(11)      -- FK geo_towncity
  , ADD COLUMN user_mod      INT(11) DEFAULT 2
  , ADD COLUMN date_mod      DATETIME DEFAULT CURRENT_TIMESTAMP
  , ADD COLUMN user_act      INT(11) DEFAULT 1
  , ADD COLUMN date_act      DATETIME DEFAULT CURRENT_TIMESTAMP
  , ADD COLUMN active BIT(1) DEFAULT 1
;
-- Update my info
UPDATE people-
  SET email_addr = 'coledorman12@gmail.com'
, password = '12345!'
, phone_pri = '204-998-8874'
, addr_prefix = '809A'
, addr = '504 main st'
, addr_code = 'R3B 0T1'
, addr_type_id = "1"
, date_mod = CURRENT_TIMESTAMP
WHERE p_id=1;

-- Update brad info

UPDATE people-
  SET email_addr = 'bvincelette@rrc.ca'
, password = '12345!'
, phone_pri = '204-845-1253'
, addr = '123 main street'
, addr_code 'n0m 2j6'
, addr_type_id = "2"
, date_mod = CURRENT_TIMESTAMP
WHERE p_id=2;

-- -------------------------------------------------------------------
-- JOINS



SELECT p_id, full_name, first_name, last_name
FROM people
ORDER BY p_id
LIMIT *;