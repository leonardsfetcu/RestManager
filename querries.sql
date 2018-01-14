-- trigger - la insert in invoice units se actualizeaza units in stre din Products
if exists (select * from sysobjects where name = 'updateProd' and type = 'TR')
drop trigger updateProd
go
create trigger updateProd on InvoiceUnit
AFTER INSERT
AS
begin
	declare @prod int;
	declare @quan int;
	
	select @prod = ProductID, @quan = Quantity from inserted

	update Products
	set UnitsInStore += @quan
	where ProductID = @prod
	print 'called'

end


-- procedura stocata la update pt Employee din login
CREATE PROCEDURE updateEmployee (
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@userName nvarchar(50),
	@pass nvarchar(50)
) AS
BEGIN
	UPDATE Employees
	SET Employees.Username = @userName,
		Employees.Password = @pass
	where Employees.FirstName = @firstName AND Employees.LastName=@lastName
END
GO



