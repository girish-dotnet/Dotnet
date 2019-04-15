declare @name varchar(30) 
set @name='Arun' 
print 'Name is ' +@name 
GO

DECLARE 
	@age int 
BEGIN
	SET @age=21
	PRINT 'AGE IS ' +Convert(varchar(5),@age)
END
GO

DECLARE
	@total_records int
BEGIN
	SELECT @total_records=COUNT(*) FROM EMP 
	PRINT 'Total Records ' +CONVERT(VARCHAR(10),@total_records)
END

