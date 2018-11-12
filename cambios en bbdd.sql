-- Paso 1
-- Creación de la nueva tabla de entregas
CREATE TABLE [dbo].[entrega] (
    [id]            INT  IDENTITY (1, 1) NOT NULL,
    [fecha]         DATE NOT NULL,
    [producto]      INT  NOT NULL,
    [cantidad]      INT  NOT NULL,
    [id_vendedor]   INT  NOT NULL,
    [id_almacenero] INT  NOT NULL
);

-- Paso 2
-- Creación de la nueva tabla de bajas
CREATE TABLE [dbo].[bajas] (
    [id]                 INT            NOT NULL,
    [codigo]             VARCHAR (60)   NOT NULL,
    [nombre_producto]    VARCHAR (60)   NOT NULL,
    [marca]              VARCHAR (30)   NOT NULL,
    [valor_compra]       MONEY          NOT NULL,
    [valor_venta]        MONEY          NOT NULL,
    [valor_mayorista]    MONEY          NULL,
    [valor_constructora] MONEY          NULL,
    [valor_familia]      MONEY          NULL,
    [fecha_compra]       DATE           NOT NULL,
    [fecha_vencimiento]  DATE           NOT NULL,
    [stock]              INT            NOT NULL,
    [stock_minimo]       INT            NOT NULL,
    [descripcion]        VARCHAR (1000) NULL,
    [imagen]             IMAGE          NULL,
    [id_proveedor]       INT            NOT NULL,
    [id_categoria]       INT            NOT NULL
);

-- Paso 3
-- Creación del procedimiento almacenado que se encarga de insertar el/los productos
-- seleccionados en la tabla de bajas y eliminarlos de la tabla de productos
Create Procedure spbajas
@id int
as
	Insert Into bajas
	Select * From producto Where id = @id
	Delete From producto Where id = @id