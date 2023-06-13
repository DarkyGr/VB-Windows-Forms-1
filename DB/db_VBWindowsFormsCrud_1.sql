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


-- ============ Stored Procedures ===============
-- *** CREATE ***
create proc sp_CreateReader(
	@readerId varchar(13),
	@readerName varchar(50),
	@readerPhone int,
	@readerAddress varchar(100),
	@readerObservations varchar(100)
)
as
if EXISTS (Select readerId from Reader where readerId = @readerId)
	RAISERROR('The reader already exists', 16, 1)
else	
	insert into Reader values (
		@readerId,
		@readerName,
		@readerPhone,
		@readerAddress,
		@readerObservations
	)
