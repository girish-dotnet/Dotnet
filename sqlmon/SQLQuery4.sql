DECLARE
	@empno INT,
	@nam VARCHAR(30),
	@basic INT
BEGIN
	SET @empno=1444
	IF EXISTS(SELECT * FROM EMP WHERE empno=@empno) 
	BEGIN
		SELECT 
			@nam=nam,
			@basic=basic
			FROM EMP WHERE EMPNO=@empno
		PRINT 'Name is ' +@nam 
		PRINT 'Salary is ' +CONVERT(VARCHAR(10),@basic)
	END
	ELSE
	BEGIN
		PRINT 'Empno Not Found'
	END
END

