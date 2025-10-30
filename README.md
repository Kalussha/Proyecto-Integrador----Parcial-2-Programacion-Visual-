<<<<<<< HEAD
# Sistema de Gestión de Vehículos - Concesionaria

Sistema de gestión de vehículos con operaciones CRUD (Crear, Leer, Actualizar, Eliminar) conectado a base de datos MySQL.

## ?? Requisitos Previos

- Visual Studio 2022 o superior
- .NET 8.0
- MySQL Server 8.0 o superior
- MySQL Workbench

## ?? Configuración de la Base de Datos

### Paso 1: Instalar MySQL
1. Descarga e instala MySQL Server desde: https://dev.mysql.com/downloads/mysql/
2. Durante la instalación, configura la contraseña del usuario `root`

### Paso 2: Crear la Base de Datos
1. Abre MySQL Workbench
2. Conéctate a tu servidor MySQL local
3. Abre el archivo `database_script.sql`
4. Ejecuta todo el script (presiona el botón "Execute" o Ctrl+Shift+Enter)

El script creará:
- La base de datos `concesionaria`
- La tabla `coches` con los campos necesarios
- Algunos registros de ejemplo
- Procedimientos almacenados útiles

### Paso 3: Configurar la Cadena de Conexión

Abre el archivo `DatabaseConnection.cs` y modifica la cadena de conexión según tu configuración:

```csharp
private static string connectionString = "Server=localhost;Database=concesionaria;Uid=root;Pwd=;";
```

**Parámetros:**
- `Server`: Dirección del servidor (normalmente `localhost`)
- `Database`: Nombre de la base de datos (`concesionaria`)
- `Uid`: Usuario de MySQL (por defecto `root`)
- `Pwd`: Contraseña del usuario (si no tiene contraseña, déjalo vacío)

**Ejemplos:**

Si tu usuario root tiene contraseña "mi_password":
```csharp
private static string connectionString = "Server=localhost;Database=concesionaria;Uid=root;Pwd=mi_password;";
```

Si usas un puerto diferente al 3306:
```csharp
private static string connectionString = "Server=localhost;Port=3307;Database=concesionaria;Uid=root;Pwd=;";
```

## ?? Ejecutar la Aplicación

1. Abre el proyecto en Visual Studio
2. Presiona F5 o click en "Start"
3. La aplicación se conectará automáticamente a la base de datos

## ?? Funcionalidades

### ALTA (Agregar Vehículo)
- Registra nuevos vehículos en la base de datos
- Valida que la placa no exista (clave única)
- Campos: Placa, Marca, Modelo, Año, Tipo (SUV/PICK UP/SEDAN)

### BAJA (Eliminar Vehículo)
- Busca un vehículo por placa
- Muestra los datos del vehículo antes de eliminar
- Solicita confirmación antes de eliminar

### CAMBIOS (Modificar Vehículo)
- Busca un vehículo por placa
- Permite editar: Marca, Modelo, Año y Tipo
- La placa no se puede modificar (es el identificador único)

### CONSULTAR (Buscar Vehículo)
- Busca y muestra los datos de un vehículo por placa
- Solo lectura, no permite editar

## ??? Estructura de la Base de Datos

### Tabla: coches
| Campo | Tipo | Descripción |
|-------|------|-------------|
| id | INT | ID autoincremental (Primary Key) |
| placa | VARCHAR(20) | Placa del vehículo (UNIQUE) |
| marca | VARCHAR(50) | Marca del vehículo |
| modelo | VARCHAR(50) | Modelo del vehículo |
| anio | INT | Año del vehículo |
| tipo | VARCHAR(20) | Tipo (SUV, PICK UP, SEDAN) |
| fecha_registro | TIMESTAMP | Fecha de creación del registro |
| fecha_actualizacion | TIMESTAMP | Fecha de última actualización |

## ?? Estructura del Proyecto

```
Proyecto Unidad 1 Programacion Visual/
?
??? DatabaseConnection.cs      # Clase de conexión a MySQL
??? Coche.cs                   # Modelo de datos
??? CocheDAO.cs               # Operaciones CRUD (Data Access Object)
??? Form1.cs                  # Formulario principal (menú)
??? Alta.cs                   # Formulario de alta
??? frmbaja.cs               # Formulario de baja
??? frmcambios.cs            # Formulario de cambios
??? frmconsultar.cs          # Formulario de consulta
??? database_script.sql      # Script SQL de la base de datos
```

## ?? Consultas SQL Útiles

### Ver todos los vehículos
```sql
SELECT * FROM coches;
```

### Buscar por placa
```sql
SELECT * FROM coches WHERE placa = 'ABC123';
```

### Contar vehículos por tipo
```sql
SELECT tipo, COUNT(*) as cantidad 
FROM coches 
GROUP BY tipo;
```

### Vehículos más recientes
```sql
SELECT * FROM coches ORDER BY anio DESC LIMIT 10;
```

## ?? Solución de Problemas

### Error: "Unable to connect to any of the specified MySQL hosts"
**Solución:** Verifica que MySQL Server esté ejecutándose:
- Windows: Abre "Servicios" y busca "MySQL80"
- O ejecuta: `net start MySQL80` en CMD como administrador

### Error: "Authentication to host 'localhost' failed"
**Solución:** Verifica usuario y contraseña en `DatabaseConnection.cs`

### Error: "Unknown database 'concesionaria'"
**Solución:** Ejecuta el script `database_script.sql` en MySQL Workbench

### Error: "Duplicate entry for key 'placa'"
**Solución:** La placa ya existe en la base de datos. Usa una placa diferente.

## ?? Notas Importantes

1. **Backup Regular:** Haz respaldos periódicos de tu base de datos
   ```bash
   mysqldump -u root -p concesionaria > backup.sql
   ```

2. **Seguridad:** En producción, NO uses el usuario root. Crea un usuario específico:
   ```sql
   CREATE USER 'concesionaria_user'@'localhost' IDENTIFIED BY 'password_seguro';
   GRANT ALL PRIVILEGES ON concesionaria.* TO 'concesionaria_user'@'localhost';
   FLUSH PRIVILEGES;
   ```

3. **Performance:** La tabla tiene índices en placa, marca y año para mejorar búsquedas

## ????? Autor

Proyecto Unidad 1 - Programación Visual
.NET 8.0 + MySQL

## ?? Licencia

Este proyecto es para fines educativos.
=======
# Proyecto-Integrador----Parcial-2-Programacion-Visual-
En este repositorio se encuentra el proyecto integrador de la unidad 1 que antes utilizaba vectores y matrices para el guardado de la informacion y en esta ocacion se uso el mismo proyecto pero con la conexion a una base de datos 
>>>>>>> cf24d552fdc06c1e2fc1b84e46dee834d62535a5
