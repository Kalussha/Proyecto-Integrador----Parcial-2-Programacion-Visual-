# ?? Gu�a R�pida de Inicio

## Configuraci�n en 5 Pasos

### 1?? Instalar MySQL
- Descarga MySQL Server: https://dev.mysql.com/downloads/mysql/
- Durante la instalaci�n, recuerda la contrase�a que configures para el usuario `root`

### 2?? Crear la Base de Datos
1. Abre **MySQL Workbench**
2. Conecta a tu servidor local (localhost)
3. Abre el archivo **`database_script.sql`**
4. Ejecuta el script completo (Ctrl + Shift + Enter)
5. Verifica que se cre� la base de datos `concesionaria`

### 3?? Configurar la Conexi�n
Abre el archivo **`DatabaseConnection.cs`** y actualiza la l�nea 9:

```csharp
private static string connectionString = "Server=localhost;Database=concesionaria;Uid=root;Pwd=TU_CONTRASE�A_AQUI;";
```

**Importante:** 
- Si NO configuraste contrase�a, d�jala vac�a: `Pwd=;`
- Si S� configuraste contrase�a, ponla: `Pwd=mi_password;`

### 4?? Compilar el Proyecto
1. Abre el proyecto en Visual Studio
2. Presiona **Ctrl + Shift + B** para compilar
3. Verifica que no haya errores

### 5?? Ejecutar la Aplicaci�n
1. Presiona **F5** o click en el bot�n verde "Start"
2. �Listo! Ya puedes usar la aplicaci�n

---

## ? Verificar que Todo Funcione

### Probar ALTA (Agregar)
1. Click en bot�n "ALTA"
2. Llena los campos:
   - Placa: TEST001
   - Marca: Toyota
   - Modelo: Camry
   - A�o: 2024
   - Tipo: SEDAN
3. Click en "GUARDAR"
4. Deber�as ver: "Veh�culo registrado correctamente"

### Probar CONSULTAR
1. Click en bot�n "CONSULTAR"
2. Escribe la placa: TEST001
3. Click en "CONSULTAR"
4. Deber�as ver los datos del veh�culo

### Probar CAMBIOS
1. Click en bot�n "CAMBIOS"
2. Escribe la placa: TEST001
3. Click en "CONSULTAR"
4. Modifica alg�n campo (ej: Marca a "Honda")
5. Click en "GUARDAR CAMBIOS"
6. Deber�as ver: "Cambios guardados correctamente"

### Probar BAJA
1. Click en bot�n "BAJA"
2. Escribe la placa: TEST001
3. Click en "ELIMINAR"
4. Confirma la eliminaci�n
5. Deber�as ver: "Veh�culo eliminado correctamente"

---

## ? �Problemas? Soluciones R�pidas

### "No se puede conectar a la base de datos"
? **Soluci�n:**
1. Verifica que MySQL est� ejecut�ndose
2. Abre "Servicios" de Windows (tecla Windows + R, escribe `services.msc`)
3. Busca "MySQL80" o "MySQL"
4. Click derecho ? "Iniciar"

### "La placa ya existe"
? **Soluci�n:** Usa una placa diferente

### "Unknown database 'concesionaria'"
? **Soluci�n:** Ejecuta el script SQL nuevamente en MySQL Workbench

### "Authentication failed"
? **Soluci�n:** Verifica el usuario y contrase�a en `DatabaseConnection.cs`

---

## ?? Comandos �tiles de MySQL

### Verificar si MySQL est� corriendo (CMD como Administrador):
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

### Ver todos los veh�culos:
```sql
SELECT * FROM coches;
```

---

## ?? Datos de Ejemplo

El script incluye estos veh�culos de ejemplo:

| Placa | Marca | Modelo | A�o | Tipo |
|-------|-------|--------|-----|------|
| ABC123 | Toyota | RAV4 | 2023 | SUV |
| XYZ789 | Ford | F-150 | 2022 | PICK UP |
| DEF456 | Honda | Accord | 2024 | SEDAN |
| GHI789 | Chevrolet | Tahoe | 2023 | SUV |
| JKL012 | Nissan | Frontier | 2022 | PICK UP |

Puedes consultar, modificar o eliminar estos registros para probar.

---

## ?? Documentaci�n Completa

Para m�s informaci�n, consulta el archivo **README.md**

---

�Listo para usar! ??
