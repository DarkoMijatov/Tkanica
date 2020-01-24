create database Folklor
collate Serbian_Latin_100_CI_AS
go

use Folklor
go

create table Log(
	UserName varchar(50) not null,
	DateTime datetime not null,
	Activity nvarchar(200) not null
)
go

create table Users(
	ID int identity(1,1) not null,
	UserName varchar(50) not null,
	Password binary(64) not null,
	FirstName nvarchar(30),
	LastName nvarchar(30),
	UserType nvarchar(20) not null,
	DateCreated datetime not null
)
go

create table MemberGroups(
	ID int identity(1,1) not null,
	Name nvarchar(50) not null,
	Count int not null
)
go

create table MembershipStatuses(
	ID int identity(1,1) not null,
	Status nvarchar(50) not null
)
go

insert into MembershipStatuses values ('aktivan')
go
insert into MembershipStatuses values ('neaktivan')
go

create table Members(
	ID int identity(1,1) not null,
	FirstName nvarchar(30) not null,
	LastName nvarchar(50) not null,
	Address nvarchar(50) not null,
	Location nvarchar(30) not null,
	DateOfBirth datetime not null,
	MobilePhone varchar(10) not null,
	Email nvarchar(50) not null,
	YearsOfExperience int,
	MembershipMonths int not null,
	DateOfEntry datetime not null,
	Status int not null,
	MemberGroup int not null,
	MembershipFeeID int not null,
	DebtAmount decimal(18,2) not null,
	Reservations varchar(100)
)
go

CREATE TRIGGER tg_updateGroupCountNewMember
    ON Members
    AFTER INSERT
    AS
    BEGIN
    SET NOCOUNT ON
		update MemberGroups set Count=Count+1 where ID=(select MemberGroup from inserted)
    END
go

CREATE TRIGGER tg_updateGroupCountDeleteMember
    ON Members
    AFTER DELETE
    AS
    BEGIN
    SET NOCOUNT ON
		update MemberGroups set Count=Count-1 where ID=(select MemberGroup from deleted)
    END
go

CREATE TRIGGER tg_updateGroupCountUpdateMemberGroup
    ON Members
    AFTER UPDATE
    AS
    BEGIN
    SET NOCOUNT ON
		update MemberGroups set Count=Count+1 where ID=(select MemberGroup from inserted)
		update MemberGroups set Count=Count-1 where ID=(select MemberGroup from deleted)
    END
go

create table ClothingKinds(
	ID int identity(1,1) not null,
	Kind  nvarchar(30) not null
)
go

insert into ClothingKinds values('čarape')
insert into ClothingKinds values('čizme')
insert into ClothingKinds values('cipele')
insert into ClothingKinds values('fes')
insert into ClothingKinds values('futa')
insert into ClothingKinds values('haljina')
insert into ClothingKinds values('jelek')
insert into ClothingKinds values('kapa')
insert into ClothingKinds values('kaput')
insert into ClothingKinds values('kecelja')
insert into ClothingKinds values('košulja')
insert into ClothingKinds values('marama')
insert into ClothingKinds values('nakit')
insert into ClothingKinds values('opanci')
insert into ClothingKinds values('pantalone')
insert into ClothingKinds values('pargar')
insert into ClothingKinds values('pojas')
insert into ClothingKinds values('šajkača')
insert into ClothingKinds values('šešir')
insert into ClothingKinds values('šubara')
insert into ClothingKinds values('suknja')
insert into ClothingKinds values('zubun')

create table Clothings(
	ID int identity(1,1) not null,
	Kind int not null,
	Region nvarchar(50),
	Gender int, /*1 - male, 2 - female*/
	Age int, /*1 - adult, 2 - child*/
	Size nvarchar(5),
	ReservationID int
)
go

create table Reservations(
	ID int identity(1,1) not null,
	MemberID int not null,
	ClothingIDs nvarchar(200) not null,
	ReservationDate datetime not null,
	Status int not null /*0-deleted, 1-active*/
)
go

create table Reservations_arch(
	ID int not null,
	MemberID int not null,
	ClothingIDs nvarchar(200) not null,
	ReservationDate datetime not null,
	Status int not null, /*0-deleted, 1-active*/
	ArchiveDate datetime not null
)
go

CREATE TRIGGER tg_UpdateReservations
    ON Reservations
    FOR INSERT
    AS
    BEGIN
    SET NOCOUNT ON
		declare @res nvarchar(100)
		set @res = (select Reservations from Members where ID = (select MemberID from inserted))
		if @res='' set @res = (select cast(ID as nvarchar) from inserted)
		else set @res = (select concat(@res,',',(select cast(ID as nvarchar) from inserted)))
		update Members set Reservations = @res where ID = ((select MemberID from inserted))

		declare @clothings nvarchar(200)
		set @clothings = (select ClothingIDs from inserted)
		update Clothings set ReservationID = (select ID from inserted) where ID in (select cast(value as int) from string_split(@clothings,','))
    END
go

create table MembershipFees(
	ID int identity(1,1) not null,
	MemberGroupID int not null,
	Discount int not null, /*0-no, 1-yes*/
	Amount decimal(18,2) not null
)
go

create table Transactions(
	ID int identity(1,1) not null,
	Kind int not null, /*1-incoming, 2-outgoing*/
	Debtor nvarchar(50) not null,
	Creditor nvarchar(50) not null,
	Amount decimal(18,2) not null,
	TransactionDate datetime not null,
	IsBankTransaction int not null, /*0-no, 1-yes*/
	Description nvarchar(100)
)
go

create table Transactions_arch(
	ID int not null,
	Kind int not null, /*1-incoming, 2-outgoing*/
	Debtor nvarchar(50) not null,
	Creditor nvarchar(50) not null,
	Amount decimal(18,2) not null,
	TransactionDate datetime not null,
	IsBankTransaction int not null, /*0-no, 1-yes*/
	Description nvarchar(100),
	ArchiveDate datetime not null
)
go

create table Balances(
	BalanceName nvarchar(50) not null,
	Amount decimal(18,2)
)
go

insert into Balances(BalanceName,Amount) values ('Banka',0.00)
insert into Balances(BalanceName,Amount) values ('Kasa',0.00)
go

CREATE TRIGGER tg_UpdateBalance
    ON Transactions
    AFTER INSERT
    AS
    BEGIN
    SET NOCOUNT ON
		declare @kind int
		set @kind = (select Kind from inserted)
		declare @amount decimal(18,2)
		set @amount = (select Amount from inserted)
		declare @isBank int
		set @isBank = (select IsBankTransaction from inserted)

		if @kind=1
		begin
			if @isBank=1
			begin
				update Balances set Amount = Amount + @amount where BalanceName = 'Banka'
			end else
			begin
				update Balances set Amount = Amount + @amount where BalanceName = 'Kasa'
			end
		end else
		begin
			if @isBank=1
			begin
				update Balances set Amount = Amount - @amount where BalanceName = 'Banka'
			end else
			begin
				update Balances set Amount = Amount - @amount where BalanceName = 'Kasa'
			end
		end
    END
go

create table DebtUpdates(
	DebtYear int not null, /*2020-*/
	DebtMonth int not null /*1-12*/
)
go