-- ============ DATABASE ===============
create database db_VBWindowsFormsCrud_1

use db_VBWindowsFormsCrud_1

-- ============ TABLES ===============
create table Reader(
	readerId varchar(13) primary key,
	readerName varchar(50),
	readerPhone int,
	readerAddress varchar(100),
	readerObservations varchar(100)
)
