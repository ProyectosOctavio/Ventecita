CREATE PROCEDURE USP_LISTADO_ME
AS
SELECT DESCRIPCION_ME,
CODIGO_ME 
FROM TB_MEDIDAS
WHERE ACTIVO=1;
GO

CREATE PROCEDURE USP_LISTADO_CA
AS
SELECT descripcion_ca,
codigo_ca
FROM TB_CATEGORIAS
WHERE ACTIVO=1;
GO

CREATE PROCEDURE USP_LISTADO_PR
@cTexto varchar(80)=''
AS
SELECT a.codigo_pr,
a.descripcion_pr,
a.marca_pr,
b.descripcion_me,
c.descripcion_ca,
a.stock_actual,
a.codigo_me,
a.codigo_ca
FROM TB_PRODUCTOS a
inner join TB_MEDIDAS b on a.codigo_me=b.codigo_me
inner join TB_CATEGORIAS c on a.codigo_ca=c.codigo_ca
where a.activo=1 and
upper(trim(a.descripcion_pr) +trim(a.marca_pr)) like '%' +upper(trim(@cTexto))+'%'
order by a.codigo_pr;
GO
