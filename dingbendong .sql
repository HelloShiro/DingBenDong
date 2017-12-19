use Northwind
drop database dingbendong

create database dingbendong
go
use dingbendong
go

create table Stores
(
	StoreID int identity(1,1) primary key ,
	StoreType nvarchar(10),
	StoreName nvarchar(10) not null,
	StoreTel varchar(12),
	StoreAddress nvarchar(30),
	StoreNote nvarchar(150),
	StoreImage image	
)


create table Products
(
	StoreID int,
	ProductID int identity(1,1) primary key,
	ProductName nvarchar(10) not null,
	ProductPrice int not null,
	ProductNote nvarchar(20)

	foreign key(StoreID) references Stores(StoreID) on delete cascade
)

create table Students
(
	StudentID int identity(1,1) primary key,
	StudentSeat int,
	StudentName nvarchar(10) not null,
	StudentTel nvarchar(30),
	StudentClass nvarchar(10),
	StudentNotes nvarchar(30),
	
)

create table Orders
(
	OrderID int primary key,
	StoreID int,
	StarID int,
	OrderDate datetime default GetDate(),
	
	foreign key(StarID) references Students(StudentID) on delete cascade,
	foreign key(StoreID) references Stores(StoreID) on delete cascade
)

create table OrderDetails
(
	OrderID int,
	ProductID int,
	StudentID int,
	ProductName nvarchar(10) not null,
	Quantity int default 1 not null,
	Discount decimal(3,2) default 1.00,
	Paid bit default 0,

	--primary key (OrderID,ProductID,StudentID),
	--constraint chk_Discount check (Discount between 0 and 1),
	foreign key(OrderID) references Orders(OrderID) on delete cascade,
	--foreign key(ProductID) references Products(ProductID) on delete set null,
	--foreign key(StudentID) references Students(StudentID) on delete cascade
)
insert into Stores
values
(N'�t��',N'�����~��','07-1111111',N'������83��',N'����ݩ�ۤv���p�p���ַP�C���ɪ��Q�G��j�a�����ݵۭC�ϸ`����ӡA���~�ڭ̨S�������洫§���A�ӬO��ܤF�@�Ӥp�ӷŷx�C',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\�����~��.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'�t��',N'�����','07-2222222',N'�y梸�55��',N'�ӥB�R��ù�Ҹ��J���Pı�C����o����N�O���w�ʪ�o�Ӧr���A�b�S���ƥ��q�쪺���ΤU�A�M�w�٬O�i�h�դ@�աA���B���ڭ̤����Ԧ�A���W����l���C',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\�����.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'�馡',N'�����~��','07-11656511',N'������82��',N'�ܳ��w���f����񪺩۵P�A�ݦh�F���O���N�O�����۵P�A�o�˪��C��Ϧ������������@�G',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\�����~��.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'�馡',N'�ָt�F','07-11656588',N'�ִ���82��',N'�@�Ӧ]�����F�d�i�����Y�A��o����p�A�������㤻�ծy��A�]�O�]����Ӫ��ȤH���_�W���A�~���D��Ӧ��G�ӪŶ��A�\�U�������]�p��²�䮧�C',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\�ָt�F.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'����',N'��F����','07-1111111',N'������82��',N'��󥴵{���[�o�A�L�ۦh����ت��ͬ��A���Z�H�]��q²�檺�ͬ��A',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\��F����.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'����',N'���Q�P','07-11188888',N'������78��',N'�ڥh�x�_���n�Q�ۧO���f�l�A�L�ۦh����ت��ͬ��A���Z�H�]��q²�檺�ͬ��A',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\���Q�P.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'����',N'�M�ߺ֥�','07-1119999',N'������87��',N'�]���ڰ��W�N�^�ӤF�A�L�ۦh����ت��ͬ��A���Z�H�]��q²�檺�ͬ��A',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\�M�ߺ֥�.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'����',N'�g�J�L','07-1110000',N'������94��',N'�n�ĨĦY���ĨĨĺ�ı�A�L�ۦh����ت��ͬ��A���Z�H�]��q²�檺�ͬ��A',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\�g�J�L.jpg', SINGLE_BLOB) AS CategoryImage))


insert into Products(StoreID,ProductName,ProductPrice)
values
(1,N'�~��',50),
(1,N'����',50),
(1,N'���L',60),
(1,N'����',30),
(1,N'����',40),
(1,N'����',10),
(1,N'���',20),
(1,N'����',10),
(2,N'����',20),
(2,N'��l',70),
(2,N'���',80),
(2,N'�h��',30),
(2,N'���{',25),
(3,N'���',75),
(3,N'ī�G',25),
(3,N'�p��',65),
(4,N'�ڻ�',525),
(4,N'�غ�',125),
(4,N'����',95),
(5,N'���s����',245),
(5,N'�q�إ���',285),
(5,N'���e����',265),
(6,N'�i�Q����',65),
(6,N'�ٯ����K',95),
(6,N'�|�u�K',825),
(7,N'����',55),
(7,N'�Q�s���K',75),
(7,N'�ï]����',60),
(8,N'�j���������K',58),
(8,N'�B�﮳�K',55),
(8,N'���',25)

insert into Students(StudentSeat,StudentName,StudentTel,StudentClass)
values
(1,N'�L�L',091111111,'iii-096'),
(2,N'�߿�',093333333,'iii-096'),
(3,N'�ݹ�',095555555,'iii-096'),
(4,N'�ߨ�',096666666,'iii-096'),
(5,N'�͸�',097777777,'iii-096'),
(6,N'���',091231231,'iii-096'),
(7,N'���',099999999,'iii-096'),
(8,N'�j�j',098888888,'iii-096'),
(9,N'����',094444444,'iii-096'),
(10,N'����',092222222,'iii-096'),
(11,N'�L�L2',091111111,'iii-096'),
(12,N'�߿�2',093333333,'iii-096'),
(1,N'�ݹ�2',095555555,'iii-097'),
(2,N'�ߨ�2',096666666,'iii-097'),
(3,N'�͸�2',097777777,'iii-097'),
(4,N'���2',091231231,'iii-097'),
(5,N'���2',099999999,'iii-097'),
(6,N'�j�j2',098888888,'iii-097'),
(7,N'����2',094444444,'iii-097'),
(8,N'����2',092222222,'iii-097'),
(1,N'�L�L3',091111111,'iii-098'),
(2,N'�߿�3',093333333,'iii-098'),
(3,N'�ݹ�3',095555555,'iii-098'),
(4,N'�ߨ�3',096666666,'iii-098'),
(5,N'�͸�3',097777777,'iii-098'),
(6,N'���3',091231231,'iii-098'),
(7,N'���3',099999999,'iii-098'),
(8,N'�j�j3',098888888,'iii-098'),
(9,N'����3',094444444,'iii-098'),
(10,N'����3',092222222,'iii-098')


select*from Orders
select*from Stores
select*from Products
select*from Students 
select*from OrderDetails 

select 

select max(StudentSeat) from Students where StudentClass = 'iii-096'

select distinct Orders.OrderID as �q��s��,StudentClass as �Z��, 
(select StoreName from Stores where Stores.StoreID = Orders.StoreID) as ���a�W��, 
(select StoreTel from Stores where Stores.StoreID = Orders.StoreID) as ���a�q��,
(select StudentName from Students where Students.StudentID = Orders.StarID) as �Ȥ��,
Orders.OrderDate as �q�ʮɶ� 
from OrderDetails 
inner join Students on OrderDetails.StudentID = Students.StudentID 
right join Orders on OrderDetails.OrderID = Orders.OrderID

select OrderDetails.ProductName as ���~ ,Products.ProductPrice as ����,
OrderDetails.Quantity as �ƶq, OrderDetails.Discount as �馩, OrderDetails.Quantity *
Products.ProductPrice*OrderDetails.Discount as �`���B 
from OrderDetails
inner join Products on OrderDetails.ProductID = Products.ProductID
where OrderID = 2

select year(OrderDate) as y,month(OrderDate) as m, day(OrderDate) as d 
from Orders where StarID in 
(select StudentID from Students where StudentClass = 'iii-098')

select StoreName from Stores where StoreID=(select StoreID from Orders where OrderID = 2)