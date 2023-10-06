create table managers(
	id int primary key identity,
	name nvarchar (255) NULL,
);

create table orders(
	id int primary key identity,
	amount decimal(18, 2) NOT NULL,
	customerId int references customer (Id) NOT NULL,
	creationDate datetimeoffset (7) NOT NULL,
);

create table customers(
	id int primary key identity,
	name nvarchar (255) NULL,
	creationDate datetimeoffset (7) NOT NULL,
	managerId int references managers (Id) NOT NULL,
);

select Customers.Name as customer, Managers.Name as manager from Orders 
left join Customers on Customers.Id = Orders.CustomerId
left join Managers on Managers.Id = Customers.ManagerId
where Orders.Amount > 1000 and Orders.CreationDate > '01.01.2023'