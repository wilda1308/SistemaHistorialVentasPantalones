# Sistema Historial de Ventas
 
Aplicación de escritorio para registrar y gestionar ventas de pantalones (talla, tela, color y género), construida en **C# (.NET Framework 4.7.2)** con **Windows Forms**.
 
Este proyecto fue desarrollado como **proyecto final** y permite registrar nuevas ventas, visualizar el historial completo, editar o eliminar registros, y obtener estadísticas básicas como la ganancia total, la tela más vendida y el color más vendido.
 
## Capturas / Funcionalidades
 
La aplicación cuenta con un formulario principal (`FrmMain`) con un menú de navegación que carga las siguientes vistas dentro de un panel de contenido:
 
- **Home**: pantalla de bienvenida (`frmHome`).
- **Registrar Venta** (`frmAgregarVenta`): formulario para registrar una nueva venta con cliente, talla, tela, color, cantidad, precio y género. Muestra una imagen de referencia del producto según el color y género seleccionados.
- **Historial de Ventas** (`frmListarHistorialVentas`): tabla (`DataGridView`) con todas las ventas registradas. Permite:
  - Editar campos haciendo doble clic sobre una celda (nombre del cliente, talla, tela, color, cantidad o precio).
  - Eliminar una venta seleccionada.
  - Calcular la ganancia total de todas las ventas.
  - Calcular la tela más vendida.
  - Calcular el color más vendido.
## Tecnologías utilizadas
 
- **Lenguaje:** C#
- **Framework:** .NET Framework 4.7.2
- **UI:** Windows Forms (WinForms)
- **IDE:** Visual Studio 2022
- **Almacenamiento:** en memoria (una lista estática `List<Ventas>` dentro de `FrmMain`). El proyecto **no usa base de datos**; al cerrar la aplicación, el historial se pierde.
## Estructura del proyecto
 
```
SistemaHistorialVentasProyectoFinal/
├── SistemaHistorialVentasProyectoFinal.sln        # Solución de Visual Studio
└── SistemaHistorialVentasProyectoFinal/
    ├── Program.cs                                  # Punto de entrada de la app
    ├── Form1.cs (FrmMain)                           # Formulario principal / menú de navegación
    ├── frmHome.cs                                   # Pantalla de inicio
    ├── frmAgregarVenta.cs                           # Formulario para registrar ventas
    ├── frmListarHistorialVentas.cs                  # Formulario de historial y estadísticas
    ├── Models/
    │   └── Ventas.cs                                # Modelo de datos de una venta
    ├── Resources/                                   # Imágenes usadas en la UI
    ├── Properties/                                  # AssemblyInfo, Settings, Resources
    └── App.config
```
 
## Requisitos para ejecutar el proyecto
 
- Windows con **Visual Studio 2019/2022** instalado.
- Componente **.NET Framework 4.7.2** (Developer Pack) instalado.
- Carga de trabajo **"Desarrollo de escritorio de .NET"** habilitada en Visual Studio.
## Cómo ejecutar el proyecto
 
### Opción 1: Desde el código fuente (recomendado)
 
1. Clona o descarga este repositorio.
2. Abre el archivo `SistemaHistorialVentasProyectoFinal.sln` con Visual Studio.
3. Espera a que se restauren las dependencias/paquetes NuGet (si aplica).
4. Presiona `F5` o el botón **Iniciar** para compilar y ejecutar la aplicación.
### Opción 2: Ejecutable directo
 
Si no quieres compilar el proyecto, puedes ejecutar directamente el archivo `.exe` generado (ubicado en `bin/Debug/` o `bin/Release/` según la versión que se distribuya), siempre que tengas el .NET Framework 4.7.2 instalado en tu equipo.
 
> ⚠️ El `.exe` no debería subirse al repositorio de GitHub (ver sección siguiente). Si quieres compartir el ejecutable, considera adjuntarlo en una **Release** de GitHub en lugar de incluirlo en el código fuente.
 
## Uso de la aplicación
 
1. Al abrir la aplicación, se muestra la pantalla **Home**.
2. Ve al menú **venta**, luego a **Registrar Venta** para ingresar los datos de una nueva venta (cliente, talla, tela, color, cantidad, precio y género).
3. Ve al menú **venta**, luego a **Historial de Ventas** para ver todas las ventas registradas en la sesión actual.
4. Dentro del historial puedes:
   - Hacer doble clic en una celda para editarla.
   - Seleccionar una fila y eliminarla con el botón correspondiente.
   - Usar los botones de estadísticas para calcular ganancias totales, la tela más vendida y el color más vendido.

## Visualización del programa
![Interfaz Gráfica de la Ventana Home](/Imagenes/VentanaHome.png)
![Interfaz Gráfica de la Ventana de Registrar una venta](/Imagenes/VentanaRegistrarVenta.png)
![Interfaz Gráfica de la Ventana de Registrar una venta con un color de pantalon negro y para genero femenino](/Imagenes/Venta1NegroFemenino.png)
![Interfaz Gráfica de la Ventana de Registrar una venta con un color de pantalon negro y para genero Masculino](/Imagenes/Venta1NegroMasculino.png)
![Interfaz Gráfica de la Ventana de Registrar una venta con un color de pantalon Azul y para genero Masculino](/Imagenes/Venta1AzulMasculino.png)
![Interfaz Gráfica de la Ventana de Registrar una venta con un color de pantalon Azul y para genero Masculino Registrado en el sistema](/Imagenes/Venta1Resgitrado.png)
![Interfaz Gráfica de la Ventana Historial ventas actualizada](/Imagenes/VentanaHistorialVentas.png)
![Interfaz Gráfica de la Ventana emergente de información de color mas vendido](/Imagenes/VentanaInfoColorMasVendido.png)
![Interfaz Gráfica de la Ventana emergente de información de Tela mas vendida](/Imagenes/VentanaInfoTelaMasVendida.png)
![Interfaz Gráfica de la Ventana emergente de información de calculo de ganacias totales](/Imagenes/VentanaInfoCalculoGanancias.png)
![Interfaz Gráfica de la Ventana emergente de información de calculo de ganacias totales de varios registros](/Imagenes/CalculoGanaciasVariosRegistros.png)
![Interfaz Gráfica de la Ventana emergente de eliminar registro de venta](/Imagenes/EliminarVenta.png)
![Interfaz Gráfica de la Ventana aceptar eliminación y actualizar el historial de ventas](/Imagenes/ActualizarHistorialVentas.png)

## Limitaciones conocidas
 
- El historial de ventas **no se persiste**: se almacena en memoria y se pierde al cerrar la aplicación.
- No cuenta con conexión a base de datos ni validaciones avanzadas de entrada más allá del manejo básico de errores de formato.
## Posibles mejoras futuras
 
- Persistencia de datos con una base de datos (SQL Server, SQLite, etc.).
- Validaciones de formulario más robustas.
## Autor
Wilson David Monroy Ramirez

Proyecto final académico desarrollado en C# con Windows Forms.
 
## Licencia
 
Este proyecto se distribuye con fines educativos.