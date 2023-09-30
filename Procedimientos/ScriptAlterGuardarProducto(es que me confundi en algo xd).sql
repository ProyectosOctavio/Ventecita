  
alter PROCEDURE USP_GUARDAR_PR  
@Opcion int =1, --Nuevo Registro / 2=Actualizar Registro  
@nCodigo_pr int,  
@cDescripcion_pr varchar(80),  
@cMarca_pr varchar(30),  
@nCodigo_me int,  
@nCodigo_ca int,  
@nStock_actual decimal(18,2)  
AS  
if @Opcion=1 --Nuevo Registro  
 begin  
   INSERT INTO TB_PRODUCTOS(descripcion_pr,  
                            marca_pr,  
       codigo_me,  
       codigo_ca,  
       stock_actual,  
       fecha_crea,  
       activo)  
       values(@cDescripcion_pr,  
              @cMarca_pr,  
           @nCodigo_me,  
           @nCodigo_ca,  
           @nStock_actual,  
           getdate(),  
           1);  
   end;  
else --Actualizar Registro  
   begin  
   UPDATE TB_PRODUCTOS SET descripcion_pr=@cDescripcion_pr,  
                           marca_pr=@cMarca_pr,  
         codigo_me=@nCodigo_me,  
         codigo_ca=@nCodigo_ca,  
         stok_actual=@nStock_actual  
         where codigo_pr=@nCodigo_pr;  
   end;  