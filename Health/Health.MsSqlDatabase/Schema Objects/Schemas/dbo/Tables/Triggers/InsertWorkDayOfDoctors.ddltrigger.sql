CREATE TRIGGER [dbo].[InsertWorkDayOfDoctors4]
ON [dbo].[WorkWeeks]
AFTER INSERT 
AS 
BEGIN	
	DECLARE @DAYINWEEK INT
	DECLARE @DOCTORID INT
	DECLARE @ROWS_IN_TABLE INT
	
	SET @DAYINWEEK = (SELECT inserted.DayInWeek FROM inserted)
	SET @DOCTORID = (SELECT inserted.DoctorId FROM inserted)
	
	SET @ROWS_IN_TABLE = (SELECT COUNT(*) FROM WorkWeeks
	WHERE WorkWeeks.DayInWeek = @DAYINWEEK AND
	WorkWeeks.DoctorId = @DOCTORID)
	
	IF @ROWS_IN_TABLE > 1 
	BEGIN
	ROLLBACK TRAN
	PRINT 'ОШИБКА. У доктора не может быть несколько расписаний на один рабочий день'
	END
END