# Sistema de Prestamos de Biblioteca

Aplicacion de consola en C# (.NET 6) para gestionar lectores, libros y
prestamos de una biblioteca, con persistencia en una base de datos SQLite.

## Arquitectura

El proyecto esta organizado en tres capas:

- **Dominio** (`Dominio/`): las clases del negocio.
  - `Persona` (clase base abstracta) y `Lector` (hereda de `Persona`),
    que demuestran herencia y polimorfismo mediante el metodo
    `ObtenerInformacion()`.
  - `Libro` y `Prestamo`.
- **Persistencia** (`Persistencia/`): acceso a datos con SQLite.
  - `InicializadorBaseDatos`: crea el archivo `biblioteca.db` y las tablas
    (a partir del script `BaseDatos/crear_tablas.sql`) la primera vez que
    arranca el programa.
  - `RepositorioBiblioteca`: todas las operaciones CRUD y las reglas de
    negocio (disponibilidad de ejemplares, prestamos vencidos, etc.).
- **Aplicacion** (`Aplicacion/`): `MenuBiblioteca`, el menu de consola que
  conecta al usuario con el repositorio.

## Funcionalidad

- **Lectores:** crear, listar, actualizar, eliminar.
- **Libros:** crear, listar (con ejemplares disponibles calculados),
  actualizar, eliminar.
- **Prestamos:** crear (valida que haya ejemplares disponibles), listar
  (con estado: Prestado, Devuelto o Vencido), actualizar, registrar
  devolucion, eliminar.
- Opcion de menu dedicada a demostrar el polimorfismo entre `Persona` y
  `Lector`.

## Como ejecutarlo

Requiere el [SDK de .NET 6](https://dotnet.microsoft.com/download/dotnet/6.0)
o superior instalado.

```bash
git clone <url-de-este-repositorio>
cd PrestamosBiblioteca
dotnet run
```

La primera vez que se ejecuta, se crea automaticamente el archivo
`biblioteca.db` (SQLite) en la carpeta de salida, con las tablas ya
listas para usarse.

## Base de datos

El motor usado es **SQLite** mediante el paquete `Microsoft.Data.Sqlite`.
El esquema (tablas `Lectores`, `Libros` y `Prestamos`, con llaves foraneas)
se encuentra en `BaseDatos/crear_tablas.sql`.
