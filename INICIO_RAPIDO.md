# ?? Guía Rápida de Inicio

## Configuración en 5 Pasos

### 1?? Instalar MySQL
- Descarga MySQL Server: https://dev.mysql.com/downloads/mysql/
- Durante la instalación, recuerda la contraseña que configures para el usuario `root`

### 2?? Crear la Base de Datos
1. Abre **MySQL Workbench**
2. Conecta a tu servidor local (localhost)
3. Abre el archivo **`database_script.sql`**
4. Ejecuta el script completo (Ctrl + Shift + Enter)
5. Verifica que se creó la base de datos `concesionaria`

### 3?? Configurar la Conexión
Abre el archivo **`DatabaseConnection.cs`** y actualiza la línea 9:

```csharp
private static string connectionString = "Server=localhost;Database=concesionaria;Uid=root;Pwd=TU_CONTRASEÑA_AQUI;";
```

**Importante:** 
- Si NO configuraste contraseña, déjala vacía: `Pwd=;`
- Si SÍ configuraste contraseña, ponla: `Pwd=mi_password;`

### 4?? Compilar el Proyecto
1. Abre el proyecto en Visual Studio
2. Presiona **Ctrl + Shift + B** para compilar
3. Verifica que no haya errores

### 5?? Ejecutar la Aplicación
1. Presiona **F5** o click en el botón verde "Start"
2. ¡Listo! Ya puedes usar la aplicación

---

## ? Verificar que Todo Funcione

### Probar ALTA (Agregar)
1. Click en botón "ALTA"
2. Llena los campos:
   - Placa: TEST001
   - Marca: Toyota
   - Modelo: Camry
   - Año: 2024
   - Tipo: SEDAN
3. Click en "GUARDAR"
4. Deberías ver: "Vehículo registrado correctamente"

### Probar CONSULTAR
1. Click en botón "CONSULTAR"
2. Escribe la placa: TEST001
3. Click en "CONSULTAR"
4. Deberías ver los datos del vehículo

### Probar CAMBIOS
1. Click en botón "CAMBIOS"
2. Escribe la placa: TEST001
3. Click en "CONSULTAR"
4. Modifica algún campo (ej: Marca a "Honda")
5. Click en "GUARDAR CAMBIOS"
6. Deberías ver: "Cambios guardados correctamente"

### Probar BAJA
1. Click en botón "BAJA"
2. Escribe la placa: TEST001
3. Click en "ELIMINAR"
4. Confirma la eliminación
5. Deberías ver: "Vehículo eliminado correctamente"

---

## ? ¿Problemas? Soluciones Rápidas

### "No se puede conectar a la base de datos"
? **Solución:**
1. Verifica que MySQL esté ejecutándose
2. Abre "Servicios" de Windows (tecla Windows + R, escribe `services.msc`)
3. Busca "MySQL80" o "MySQL"
4. Click derecho ? "Iniciar"

### "La placa ya existe"
? **Solución:** Usa una placa diferente

### "Unknown database 'concesionaria'"
? **Solución:** Ejecuta el script SQL nuevamente en MySQL Workbench

### "Authentication failed"
? **Solución:** Verifica el usuario y contraseña en `DatabaseConnection.cs`

---

## ?? Comandos Útiles de MySQL

### Verificar si MySQL está corriendo (CMD como Administrador):
```cmd
net start MySQL80
```

### Detener MySQL:
```cmd
net stop MySQL80
```

### Conectar desde terminal:
```cmd
mysql -u root -p
```

### Ver bases de datos:
```sql
SHOW DATABASES;
```

### Usar la base de datos:
```sql
USE concesionaria;
```

### Ver tablas:
```sql
SHOW TABLES;
```

### Ver todos los vehículos:
```sql
SELECT * FROM coches;
```

---

## ?? Datos de Ejemplo

El script incluye estos vehículos de ejemplo:

| Placa | Marca | Modelo | Año | Tipo |
|-------|-------|--------|-----|------|
| ABC123 | Toyota | RAV4 | 2023 | SUV |
| XYZ789 | Ford | F-150 | 2022 | PICK UP |
| DEF456 | Honda | Accord | 2024 | SEDAN |
| GHI789 | Chevrolet | Tahoe | 2023 | SUV |
| JKL012 | Nissan | Frontier | 2022 | PICK UP |

Puedes consultar, modificar o eliminar estos registros para probar.

---

## ?? Documentación Completa

Para más información, consulta el archivo **README.md**

---

¡Listo para usar! ??
