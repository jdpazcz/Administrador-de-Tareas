USE [BdiExamen]
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR]    Script Date: 06/11/2023 02:15:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ACTUALIZAR](
@ID INT,
@Nombre VARCHAR(250),
@Actividad VARCHAR(250),
@Estatus VARCHAR (250)
)
AS
BEGIN
UPDATE TODOLIST_AGA SET   Nombre = @Nombre, Actividad = @Actividad, Estatus = @Estatus WHERE ID = @ID
END

SELECT COUNT(*) AS 'CANTIDAD DE REGISTROS'
FROM TODOLIST_AGA
WHERE (Estatus = 'Termindo')
GO