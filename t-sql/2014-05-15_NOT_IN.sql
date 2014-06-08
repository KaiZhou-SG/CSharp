-- Select driver
SELECT * FROM [dbo].[TPT_Driver_Tbl] WHERE [Driver_Code] IN
                -- Select all driver code from [dbo].[TPT_PLAN_DEPT_DRIVER_TBL] on a certain date
                 (SELECT [DRIVER_CODE] FROM [dbo].[TPT_PLAN_DEPT_DRIVER_TBL] WHERE
				 ([dbo].[TPT_PLAN_DEPT_DRIVER_TBL].[SCHEDULE_DATE] = '2014-05-12' AND
				 [Driver_Code] NOT IN 
				 -- Select all driver code from [dbo].[TRK_PLAN_TRIP_TBL] on that same date
				( SELECT [DRIVER_NO] FROM [dbo].[TRK_PLAN_TRIP_TBL] WHERE 
                 [dbo].[TRK_PLAN_TRIP_TBL].[SCHEDULE_DATE] = '2014-05-12') AND 
				 [Driver_Code] NOT IN
				 -- Select all driver code from [dbo].[TPT_PLAN_TRIP_TBL] on that same date
				(SELECT [DRIVER_NO] FROM [dbo].[TPT_PLAN_TRIP_TBL] WHERE 
                 [dbo].[TPT_PLAN_TRIP_TBL].[SCHEDULE_DATE] = '2014-05-12')
				))