# ?? Guía de Uso de MySQL Workbench

## ?? Instalación de MySQL

### Descargar e Instalar
1. Ve a: https://dev.mysql.com/downloads/mysql/
2. Descarga **MySQL Community Server**
3. Durante la instalación:
   - Tipo de instalación: **Developer Default**
   - Contraseña de root: **¡IMPORTANTE! Recuerda esta contraseña**
   - Puerto: **3306** (por defecto)
4. También instala **MySQL Workbench** si no viene incluido

---

## ?? Primera Configuración

### 1. Abrir MySQL Workbench
1. Abre **MySQL Workbench**
2. Verás una conexión por defecto: **Local instance MySQL80**
3. Click en esa conexión
4. Ingresa tu contraseña de root

### 2. Crear la Base de Datos
1. En MySQL Workbench, abre el archivo **`database_script.sql`**
   - File ? Open SQL Script...
   - Busca el archivo en tu proyecto
2. Verás todo el código SQL
3. Para ejecutarlo:
   - **Opción A:** Click en el ícono del rayo ? (Execute)
   - **Opción B:** Presiona `Ctrl + Shift + Enter`
4. Verás mensajes de éxito en el panel inferior

### 3. Verificar que se creó correctamente
Ejecuta estas consultas (una por una):
```sql
SHOW DATABASES;
```
Deberías ver `concesionaria` en la lista.

```sql
USE concesionaria;
```

```sql
SHOW TABLES;
```
Deberías ver la tabla `coches`.

```sql
SELECT * FROM coches;
```
Deberías ver 5 registros de ejemplo.

---

## ?? Usar el archivo consultas_ejemplo.sql

### Cómo ejecutar consultas

1. **Abrir el archivo:**
   - File ? Open SQL Script...
   - Selecciona `consultas_ejemplo.sql`

2. **Ejecutar una consulta específica:**
   - Selecciona las líneas de la consulta que quieres ejecutar
   - Presiona `Ctrl + Enter` o click en el rayo ? con una franja

3. **Ejecutar todo el archivo:**
   - `Ctrl + Shift + Enter`
   - ?? CUIDADO: Esto ejecutará TODAS las consultas

### Ejemplos prácticos:

#### Ver todos los vehículos
```sql
USE concesionaria;
SELECT * FROM coches;
```

#### Insertar un vehículo de prueba
```sql
INSERT INTO coches (placa, marca, modelo, anio, tipo) 
VALUES ('PRUEBA1', 'Toyota', 'Corolla', 2024, 'SEDAN');
```

#### Buscar ese vehículo
```sql
SELECT * FROM coches WHERE placa = 'PRUEBA1';
```

#### Actualizar ese vehículo
```sql
UPDATE coches 
SET marca = 'Honda', modelo = 'Civic' 
WHERE placa = 'PRUEBA1';
```

#### Eliminar ese vehículo
```sql
DELETE FROM coches WHERE placa = 'PRUEBA1';
```

---

## ?? Interface de MySQL Workbench

### Panel Principal
```
???????????????????????????????????????????
?  [File] [Edit] [Query] [Database]       ? ? Menú
???????????????????????????????????????????
?  ? ?? ?? ? ...                          ? ? Toolbar (botones)
???????????????????????????????????????????
?                                          ?
?  SELECT * FROM coches;   ? Editor SQL   ?
?                                          ?
???????????????????????????????????????????
?  Result Grid  ?  Output  ?  History     ? ? Pestañas de resultados
???????????????????????????????????????????
?  Query OK, 5 rows affected              ? ? Mensajes
???????????????????????????????????????????
```

### Botones importantes:
- **? Rayo completo:** Ejecuta todo el script
- **? Rayo con franja:** Ejecuta la consulta seleccionada
- **?? Disco:** Guardar script
- **?? Página:** Nuevo script
- **? Flecha circular:** Refrescar

---

## ?? Navegador de Esquemas (Izquierda)

```
SCHEMAS
??? concesionaria
    ??? Tables
        ??? coches
            ??? Columns
            ?   ??? id (PK, INT, AI)
            ?   ??? placa (VARCHAR, UNIQUE)
            ?   ??? marca (VARCHAR)
            ?   ??? modelo (VARCHAR)
            ?   ??? anio (INT)
            ?   ??? tipo (VARCHAR)
            ?   ??? fecha_registro (TIMESTAMP)
            ?   ??? fecha_actualizacion (TIMESTAMP)
            ??? Indexes
                ??? PRIMARY
                ??? placa (UNIQUE)
                ??? idx_placa
                ??? idx_marca
                ??? idx_anio
```

### Acciones rápidas (Click derecho en tabla):
- **Select Rows:** Ver todos los datos
- **Alter Table:** Modificar estructura
- **Table Inspector:** Ver información detallada
- **Truncate Table:** Vaciar tabla
- **Drop Table:** Eliminar tabla (¡CUIDADO!)

---

## ??? Operaciones Comunes

### 1. Ver datos de la tabla
```sql
SELECT * FROM coches;
```

### 2. Filtrar por condición
```sql
SELECT * FROM coches WHERE marca = 'Toyota';
```

### 3. Ordenar resultados
```sql
SELECT * FROM coches ORDER BY anio DESC;
```

### 4. Contar registros
```sql
SELECT COUNT(*) FROM coches;
```

### 5. Buscar con LIKE
```sql
SELECT * FROM coches WHERE marca LIKE '%ota%';
```

### 6. Insertar nuevo registro
```sql
INSERT INTO coches (placa, marca, modelo, anio, tipo) 
VALUES ('ABC999', 'Ford', 'Explorer', 2024, 'SUV');
```

### 7. Actualizar registro
```sql
UPDATE coches 
SET anio = 2025 
WHERE placa = 'ABC999';
```

### 8. Eliminar registro
```sql
DELETE FROM coches WHERE placa = 'ABC999';
```

---

## ?? Editar datos visualmente (sin SQL)

### Modo de edición de tabla:
1. Click derecho en la tabla `coches`
2. Selecciona **"Select Rows - Limit 1000"**
3. Se abre una vista de tabla
4. Click en una celda para editar
5. Presiona **Apply** para guardar cambios

### Insertar fila:
1. En la vista de tabla
2. Última fila vacía
3. Llena los campos
4. Presiona **Apply**

### Eliminar fila:
1. Click derecho en la fila
2. Selecciona **"Delete Row(s)"**
3. Presiona **Apply**

---

## ?? Exportar Datos

### Método 1: Exportar tabla completa
1. Server ? Data Export
2. Selecciona `concesionaria`
3. Marca la tabla `coches`
4. Elige destino del archivo
5. Click en **Start Export**

### Método 2: Exportar resultados de consulta
1. Ejecuta una consulta: `SELECT * FROM coches;`
2. En los resultados, click en **Export**
3. Elige formato (CSV, JSON, SQL, etc.)
4. Guarda el archivo

### Método 3: Exportar con SQL
```sql
SELECT * FROM coches
INTO OUTFILE 'C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/coches.csv'
FIELDS TERMINATED BY ','
ENCLOSED BY '"'
LINES TERMINATED BY '\n';
```
?? **Nota:** La ruta debe tener permisos de escritura

---

## ?? Importar Datos

### Desde archivo SQL:
1. File ? Open SQL Script...
2. Selecciona tu archivo .sql
3. Ejecuta el script

### Desde CSV:
1. Click derecho en tabla `coches`
2. **Table Data Import Wizard**
3. Selecciona archivo CSV
4. Mapea columnas
5. Click en **Next** hasta finalizar

---

## ?? Gestión de Usuarios

### Crear usuario para la aplicación:
```sql
-- Crear usuario
CREATE USER 'concesionaria_app'@'localhost' 
IDENTIFIED BY 'password_seguro123';

-- Dar permisos
GRANT ALL PRIVILEGES ON concesionaria.* 
TO 'concesionaria_app'@'localhost';

-- Aplicar cambios
FLUSH PRIVILEGES;
```

### Usar ese usuario en la aplicación:
En `DatabaseConnection.cs`:
```csharp
private static string connectionString = 
    "Server=localhost;Database=concesionaria;Uid=concesionaria_app;Pwd=password_seguro123;";
```

---

## ?? Solución de Problemas

### Error: "Can't connect to MySQL server"
**Causa:** MySQL Server no está ejecutándose

**Solución:**
1. Abre Servicios de Windows (`Win + R` ? `services.msc`)
2. Busca "MySQL80"
3. Click derecho ? Iniciar

O desde CMD como administrador:
```cmd
net start MySQL80
```

---

### Error: "Access denied for user 'root'@'localhost'"
**Causa:** Contraseña incorrecta

**Solución:**
1. Verifica la contraseña en MySQL Workbench
2. Si olvidaste la contraseña, deberás reiniciarla:
   - Detén el servicio MySQL
   - Inicia MySQL sin validación de contraseñas
   - Cambia la contraseña
   - Reinicia MySQL normal

---

### Error: "Unknown database 'concesionaria'"
**Causa:** No se ha ejecutado el script de creación

**Solución:**
1. Ejecuta `database_script.sql` completo
2. Verifica con: `SHOW DATABASES;`

---

### Error: "Table 'coches' doesn't exist"
**Causa:** No se creó la tabla

**Solución:**
```sql
USE concesionaria;
SHOW TABLES;
```
Si no aparece `coches`, ejecuta de nuevo el script de creación.

---

## ?? Atajos de Teclado Útiles

| Atajo | Acción |
|-------|--------|
| `Ctrl + Enter` | Ejecutar consulta actual/seleccionada |
| `Ctrl + Shift + Enter` | Ejecutar todo el script |
| `Ctrl + T` | Nuevo tab |
| `Ctrl + W` | Cerrar tab |
| `Ctrl + /` | Comentar/descomentar línea |
| `Ctrl + B` | Formatear SQL (beautify) |
| `Ctrl + Space` | Autocompletar |
| `F5` | Refrescar esquemas |
| `Ctrl + U` | Convertir a mayúsculas |
| `Ctrl + Shift + U` | Convertir a minúsculas |

---

## ?? Recursos Adicionales

### Documentación oficial:
- MySQL: https://dev.mysql.com/doc/
- MySQL Workbench: https://dev.mysql.com/doc/workbench/en/

### Tutoriales en video:
- YouTube: "MySQL Workbench tutorial"
- MySQL oficial: https://www.mysql.com/training/

---

## ? Checklist de Configuración

- [ ] MySQL Server instalado
- [ ] MySQL Workbench instalado
- [ ] Conexión creada en Workbench
- [ ] Script `database_script.sql` ejecutado
- [ ] Base de datos `concesionaria` creada
- [ ] Tabla `coches` creada
- [ ] 5 registros de ejemplo insertados
- [ ] Contraseña configurada en `DatabaseConnection.cs`
- [ ] Aplicación C# compila sin errores
- [ ] Prueba de ALTA exitosa
- [ ] Prueba de CONSULTA exitosa
- [ ] Prueba de CAMBIOS exitosa
- [ ] Prueba de BAJA exitosa

---

¡Ya estás listo para usar MySQL Workbench con tu aplicación! ??
