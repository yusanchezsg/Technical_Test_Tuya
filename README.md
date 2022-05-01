# Technical_Test_Tuya

### Pre-requisitios 

#### Configuración
Una vez descargado/clonado el repositorio configurar la siguiente variable en las propiedades del proyecto **Payment.Test.Tuya.API****.
Par ello, vaya a la pestaña de Build.
- Deselecciones y seleccione el **XML documentation file**  checkbox. Esto volverá a calcular el Output path del archivo XML.

![Build](https://user-images.githubusercontent.com/51092136/166168440-89428e6c-065b-4ab2-a1be-5c8fb36073e4.png)

Luego, vaya a la pestaña de **Debug** y valide que el valor del Launch browser sera **swagger****.

![Debug](https://user-images.githubusercontent.com/51092136/166168471-718faf5e-d574-45ea-b240-dd6bbbe1757f.png)

El proyecto **Payment.Test.Tuya.API**** debe estar como principal.


### Cadena de conexión
Editar la cadena de conexión que se encuentra en el archivo appsettings.json
```json
{
 "ConnectionStrings": {
    "ApplicationContext": "Server=DESKTOP-0CDTA68\\SQLEXPRESS;Database=PaymentsTuya;Trusted_Connection=True;MultipleActiveResultSets=true"
}

```
![appsettings](https://user-images.githubusercontent.com/51092136/166168395-d2bd59cd-621c-4b18-b45b-2c507143cd6f.png)


### Creación de la base de datos

Abrir el Package  Manager Console y ejecutar el siguiente comando sobre el proyecto Payment.Test.Tuya.DAL
```c
Add-migration CreateDatabase
```
![Add-migra](https://user-images.githubusercontent.com/51092136/166167782-64799a4a-d4c2-4302-9784-09185e4a59e6.png)

Una vez ejecutado, se debería crear la base de datos con las siguientes tablas
- Products
- Clients

###Librerias
Se utilizaron las siguientes librerias :
-**Swagger**: Permite documentar las APIs y mostrar una inerfaz mas amigable.
-**EntityFramework**: Es la solución open-source ORM. Se realizo codefirst para generar la base desde nuestro codigo utilizando los migrations.

> **Observaciones**
Por temas de tiempo no logre general un modelo entidad relacion con todos los objetos necesarios para la prueba.
Como por ejemplo: 
-Factura
-Factura Detalle
-Pedido
-Pedido Detalle
Adicional a esto no tengo mucho conocimiewnto en el tema de pruebas unitarias, pero se que existe XUnit y puedo utilizar Mock para los test.
