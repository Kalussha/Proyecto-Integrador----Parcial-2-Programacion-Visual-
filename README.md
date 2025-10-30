<<<<<<< HEAD
# Sistema de Gesti�n de Veh�culos - Concesionaria

Sistema de gesti�n de veh�culos con operaciones CRUD (Crear, Leer, Actualizar, Eliminar) conectado a base de datos MySQL.

## ?? Requisitos Previos

- Visual Studio 2022 o superior
- .NET 8.0
- MySQL Server 8.0 o superior
- MySQL Workbench

## ?? Configuraci�n de la Base de Datos

### Paso 1: Instalar MySQL
1. Descarga e instala MySQL Server desde: https://dev.mysql.com/downloads/mysql/
2. Durante la instalaci�n, configura la contrase�a del usuario `root`

### Paso 2: Crear la Base de Datos
1. Abre MySQL Workbench
2. Con�ctate a tu servidor MySQL local
3. Abre el archivo `database_script.sql`
4. Ejecuta todo el script (presiona el bot�n "Execute" o Ctrl+Shift+Enter)

El script crear�:
- La base de datos `concesionaria`
- La tabla `coches` con los campos necesarios
- Algunos registros de ejemplo
- Procedimientos almacenados �tiles

### Paso 3: Configurar la Cadena de Conexi�n

Abre el archivo `DatabaseConnection.cs` y modifica la cadena de conexi�n seg�n tu configuraci�n:

```csharp
private static string connectionString = "Server=localhost;Database=concesionaria;Uid=root;Pwd=;";
```

**Par�metros:**
- `Server`: Direcci�n del servidor (normalmente `localhost`)
- `Database`: Nombre de la base de datos (`concesionaria`)
- `Uid`: Usuario de MySQL (por defecto `root`)
- `Pwd`: Contrase�a del usuario (si no tiene contrase�a, d�jalo vac�o)

**Ejemplos:**

Si tu usuario root tiene contrase�a "mi_password":
```csharp
private static string connectionString = "Server=localhost;Database=concesionaria;Uid=root;Pwd=mi_password;";
```

Si usas un puerto diferente al 3306:
```csharp
private static string connectionString = "Server=localhost;Port=3307;Database=concesionaria;Uid=root;Pwd=;";
```

## ?? Ejecutar la Aplicaci�n

1. Abre el proyecto en Visual Studio
2. Presiona F5 o click en "Start"
3. La aplicaci�n se conectar� autom�ticamente a la base de datos

## ?? Funcionalidades

### ALTA (Agregar Veh�culo)
- Registra nuevos veh�culos en la base de datos
- Valida que la placa no exista (clave �nica)
- Campos: Placa, Marca, Modelo, A�o, Tipo (SUV/PICK UP/SEDAN)

### BAJA (Eliminar Veh�culo)
- Busca un veh�culo por placa
- Muestra los datos del veh�culo antes de eliminar
- Solicita confirmaci�n antes de eliminar

### CAMBIOS (Modificar Veh�culo)
- Busca un veh�culo por placa
- Permite editar: Marca, Modelo, A�o y Tipo
- La placa no se puede modificar (es el identificador �nico)

### CONSULTAR (Buscar Veh�culo)
- Busca y muestra los datos de un veh�culo por placa
- Solo lectura, no permite editar

## ??? Estructura de la Base de Datos

### Tabla: coches
| Campo | Tipo | Descripci�n |
|-------|------|-------------|
| id | INT | ID autoincremental (Primary Key) |
| placa | VARCHAR(20) | Placa del veh�culo (UNIQUE) |
| marca | VARCHAR(50) | Marca del veh�culo |
| modelo | VARCHAR(50) | Modelo del veh�culo |
| anio | INT | A�o del veh�culo |
| tipo | VARCHAR(20) | Tipo (SUV, PICK UP, SEDAN) |
| fecha_registro | TIMESTAMP | Fecha de creaci�n del registro |
| fecha_actualizacion | TIMESTAMP | Fecha de �ltima actualizaci�n |

## ?? Estructura del Proyecto

```
Proyecto Unidad 1 Programacion Visual/
?
??? DatabaseConnection.cs      # Clase de conexi�n a MySQL
??? Coche.cs                   # Modelo de datos
??? CocheDAO.cs               # Operaciones CRUD (Data Access Object)
??? Form1.cs                  # Formulario principal (men�)
??? Alta.cs                   # Formulario de alta
??? frmbaja.cs               # Formulario de baja
??? frmcambios.cs            # Formulario de cambios
??? frmconsultar.cs          # Formulario de consulta
??? database_script.sql      # Script SQL de la base de datos
```

## ?? Consultas SQL �tiles

### Ver todos los veh�culos
```sql
SELECT * FROM coches;
```

### Buscar por placa
```sql
SELECT * FROM coches WHERE placa = 'ABC123';
```

### Contar veh�culos por tipo
```sql
SELECT tipo, COUNT(*) as cantidad 
FROM coches 
GROUP BY tipo;
```

### Veh�culos m�s recientes
```sql
SELECT * FROM coches ORDER BY anio DESC LIMIT 10;
```

## ?? Soluci�n de Problemas

### Error: "Unable to connect to any of the specified MySQL hosts"
**Soluci�n:** Verifica que MySQL Server est� ejecut�ndose:
- Windows: Abre "Servicios" y busca "MySQL80"
- O ejecuta: `net start MySQL80` en CMD como administrador

### Error: "Authentication to host 'localhost' failed"
**Soluci�n:** Verifica usuario y contrase�a en `DatabaseConnection.cs`

### Error: "Unknown database 'concesionaria'"
**Soluci�n:** Ejecuta el script `database_script.sql` en MySQL Workbench

### Error: "Duplicate entry for key 'placa'"
**Soluci�n:** La placa ya existe en la base de datos. Usa una placa diferente.

## ?? Notas Importantes

1. **Backup Regular:** Haz respaldos peri�dicos de tu base de datos
   ```bash
   mysqldump -u root -p concesionaria > backup.sql
   ```

2. **Seguridad:** En producci�n, NO uses el usuario root. Crea un usuario espec�fico:
   ```sql
   CREATE USER 'concesionaria_user'@'localhost' IDENTIFIED BY 'password_seguro';
   GRANT ALL PRIVILEGES ON concesionaria.* TO 'concesionaria_user'@'localhost';
   FLUSH PRIVILEGES;
   ```

3. **Performance:** La tabla tiene �ndices en placa, marca y a�o para mejorar b�squedas

## ????? Autor

Proyecto Unidad 1 - Programaci�n Visual
.NET 8.0 + MySQL

## ?? Licencia

Este proyecto es para fines educativos.
=======
# Proyecto-Integrador----Parcial-2-Programacion-Visual-
En este repositorio se encuentra el proyecto integrador de la unidad 1 que antes utilizaba vectores y matrices para el guardado de la informacion y en esta ocacion se uso el mismo proyecto pero con la conexion a una base de datos 
>>>>>>> cf24d552fdc06c1e2fc1b84e46dee834d62535a5
