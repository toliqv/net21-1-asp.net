CREATE TABLE Products (
	Id int not null identity primary key,
	Name nvarchar(150) not null,
	Description nvarchar(1024) not null,
	ImageUrl nvarchar(max) null,
	Price decimal(38) not null,
	Category nvarchar(150) not null,
	Vendor nvarchar(150) not null
)
