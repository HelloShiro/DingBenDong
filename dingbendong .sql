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
(N'速食',N'丹丹漢堡','07-1111111',N'中正路83號',N'找到屬於自己的小小幸福感。溫馨的十二月大家都期待著耶誕節的到來，今年我們沒有彼此交換禮物，而是選擇了一個小而溫暖。',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\丹丹漢堡.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'速食',N'麥當勞','07-2222222',N'宜璇路55號',N'而且充滿羅曼蒂克的感覺。不曉得為何就是喜歡戀花這個字眼，在沒有事先訂位的情形下，決定還是進去試一試，幸運的我們不必候位，馬上有位子坐。',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\麥當勞.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'日式',N'摩斯漢堡','07-11656511',N'摩斯路82號',N'很喜歡門口湖水綠的招牌，看多了不是紅就是黃的招牌，這樣的顏色反而讓眼睛為之一亮',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\摩斯漢堡.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'日式',N'福聖亭','07-11656588',N'福斯路82號',N'一樓因為有了櫃檯的關係，顯得比較小，約莫五～六組座位，也是因為後來的客人不斷上門，才知道原來有二樓空間，餐廳的內部設計很簡潔息。',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\福聖亭.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'飲料',N'樺達奶茶','07-1111111',N'中正路82號',N'鼻鼻打程式加油，過著多麼奢華的生活，平凡人也能從簡單的生活，',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\樺達奶茶.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'飲料',N'五十嵐','07-11188888',N'中正路78號',N'我去台北不要想著別的妹子，過著多麼奢華的生活，平凡人也能從簡單的生活，',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\五十嵐.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'飲料',N'清心福全','07-1119999',N'中正路87號',N'因為我馬上就回來了，過著多麼奢華的生活，平凡人也能從簡單的生活，',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\清心福全.jpg', SINGLE_BLOB) AS CategoryImage)),
(N'飲料',N'迷克夏','07-1110000',N'中正路94號',N'要乖乖吃中藥乖乖睡覺，過著多麼奢華的生活，平凡人也能從簡單的生活，',(SELECT * FROM OPENROWSET(BULK N'C:\Users\iii\Desktop\Dingbendong\images\迷克夏.jpg', SINGLE_BLOB) AS CategoryImage))


insert into Products(StoreID,ProductName,ProductPrice)
values
(1,N'漢堡',50),
(1,N'薯條',50),
(1,N'雞腿',60),
(1,N'雞翅',30),
(1,N'雞胸',40),
(1,N'紅茶',10),
(1,N'綠茶',20),
(1,N'奶茶',10),
(2,N'葡萄',20),
(2,N'桃子',70),
(2,N'草莓',80),
(2,N'榴槤',30),
(2,N'釋迦',25),
(3,N'鳳梨',75),
(3,N'蘋果',25),
(3,N'小米',65),
(4,N'歐頗',525),
(4,N'華碩',125),
(4,N'宏碁',95),
(5,N'紅龍奶茶',245),
(5,N'益壽奶茶',285),
(5,N'美容奶茶',265),
(6,N'波霸奶茶',65),
(6,N'抹茶拿鐵',95),
(6,N'四季春',825),
(7,N'紅茶',55),
(7,N'烏龍拿鐵',75),
(7,N'珍珠奶綠',60),
(8,N'大正紅茶拿鐵',58),
(8,N'伯爵拿鐵',55),
(8,N'綠茶',25)

insert into Students(StudentSeat,StudentName,StudentTel,StudentClass)
values
(1,N'汪汪',091111111,'iii-096'),
(2,N'貓貓',093333333,'iii-096'),
(3,N'屬鼠',095555555,'iii-096'),
(4,N'兔兔',096666666,'iii-096'),
(5,N'裊裊',097777777,'iii-096'),
(6,N'花花',091231231,'iii-096'),
(7,N'毛毛',099999999,'iii-096'),
(8,N'夸夸',098888888,'iii-096'),
(9,N'咻咻',094444444,'iii-096'),
(10,N'邱秋',092222222,'iii-096'),
(11,N'汪汪2',091111111,'iii-096'),
(12,N'貓貓2',093333333,'iii-096'),
(1,N'屬鼠2',095555555,'iii-097'),
(2,N'兔兔2',096666666,'iii-097'),
(3,N'裊裊2',097777777,'iii-097'),
(4,N'花花2',091231231,'iii-097'),
(5,N'毛毛2',099999999,'iii-097'),
(6,N'夸夸2',098888888,'iii-097'),
(7,N'咻咻2',094444444,'iii-097'),
(8,N'邱秋2',092222222,'iii-097'),
(1,N'汪汪3',091111111,'iii-098'),
(2,N'貓貓3',093333333,'iii-098'),
(3,N'屬鼠3',095555555,'iii-098'),
(4,N'兔兔3',096666666,'iii-098'),
(5,N'裊裊3',097777777,'iii-098'),
(6,N'花花3',091231231,'iii-098'),
(7,N'毛毛3',099999999,'iii-098'),
(8,N'夸夸3',098888888,'iii-098'),
(9,N'咻咻3',094444444,'iii-098'),
(10,N'邱秋3',092222222,'iii-098')


select*from Orders
select*from Stores
select*from Products
select*from Students 
select*from OrderDetails 

select 

select max(StudentSeat) from Students where StudentClass = 'iii-096'

select distinct Orders.OrderID as 訂單編號,StudentClass as 班級, 
(select StoreName from Stores where Stores.StoreID = Orders.StoreID) as 店家名稱, 
(select StoreTel from Stores where Stores.StoreID = Orders.StoreID) as 店家電話,
(select StudentName from Students where Students.StudentID = Orders.StarID) as 值日生,
Orders.OrderDate as 訂購時間 
from OrderDetails 
inner join Students on OrderDetails.StudentID = Students.StudentID 
right join Orders on OrderDetails.OrderID = Orders.OrderID

select OrderDetails.ProductName as 產品 ,Products.ProductPrice as 價格,
OrderDetails.Quantity as 數量, OrderDetails.Discount as 折扣, OrderDetails.Quantity *
Products.ProductPrice*OrderDetails.Discount as 總金額 
from OrderDetails
inner join Products on OrderDetails.ProductID = Products.ProductID
where OrderID = 2

select year(OrderDate) as y,month(OrderDate) as m, day(OrderDate) as d 
from Orders where StarID in 
(select StudentID from Students where StudentClass = 'iii-098')

select StoreName from Stores where StoreID=(select StoreID from Orders where OrderID = 2)