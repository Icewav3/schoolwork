/* 
** Name:
** Assignment:
** Date: 
** History:  YYYY-MM-DD
**           Description and list of changes
**           - change 1
**           - change 2
**           - change n
**
**           YYYY-MM-DD
**           Latest description and list of changes
**           - latest change n
**/

--Maria Db location:
cd '.\Program Files\MariaDB 11.4\bin'

--Open Maria DB:
.\mysql -u root -p

--Show databases:
SHOW DATABASES;

--use database:
USE <database name>;

--get database
SELECT DATABASE();

--example 1:
SELECT collation_name, character_set_name
FROM collations
WHERE character_set_name='utf8mb4'
ORDER BY collation_name;

-- DROP DATABASE IF EXISTS database_name;
CREATE DATABASE IF NOT EXISTS database_name
CHARSET='utf8mb4'
COLLATE='utf8mb4_unicode_ci';
