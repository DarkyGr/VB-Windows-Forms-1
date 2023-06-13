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

-- *** UPDATE ***
create proc sp_UpdateReader(
	@readerId varchar(13),
	@readerName varchar(50),
	@readerPhone int,
	@readerAddress varchar(100),
	@readerObservations varchar(100)
)
as
update Reader set 
	readerName = @readerName,
	readerPhone = @readerPhone,
	readerAddress = @readerAddress,
	readerObservations = @readerObservations
where readerId = @readerId

-- *** READ ***
create proc sp_ShowReader
as
select
	readerId as [Reader ID],
	readerName as [Reader Name],
	readerPhone as [Reader Phone],
	readerAddress as [Reader Address],
	readerObservations as [Reader Observations]
from Reader

create proc sp_SearchReader
@Search varchar(50)
as
select
	readerId as [Reader ID],
	readerName as [Reader Name],
	readerPhone as [Reader Phone],
	readerAddress as [Reader Address],
	readerObservations as [Reader Observations]
from Reader where readerId + readerName LIKE '%' + @Search + '%'

-- *** DELETE ***
create proc sp_DeleteReader
	@readerId varchar(13)
as
	delete from Reader
	where readerId = @readerId