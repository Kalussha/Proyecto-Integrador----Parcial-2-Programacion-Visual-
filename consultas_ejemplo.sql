-- ====================================================
-- CONSULTAS DE EJEMPLO PARA MYSQL WORKBENCH
-- Sistema de Gesti�n de Veh�culos - Concesionaria
-- ====================================================

-- Seleccionar la base de datos
USE concesionaria;

-- ====================================================
-- CONSULTAS B�SICAS
-- ====================================================

-- 1. Ver todos los veh�culos
SELECT * FROM coches;

-- 2. Ver solo placas y marcas
SELECT placa, marca FROM coches;

-- 3. Contar total de veh�culos
SELECT COUNT(*) as total_vehiculos FROM coches;

-- 4. Ver veh�culos ordenados por a�o (m�s recientes primero)
SELECT * FROM coches ORDER BY anio DESC;

-- 5. Ver veh�culos ordenados por marca
SELECT * FROM coches ORDER BY marca ASC;

-- ====================================================
-- B�SQUEDAS ESPEC�FICAS
-- ====================================================

-- 6. Buscar un veh�culo por placa exacta
SELECT * FROM coches WHERE placa = 'ABC123';

-- 7. Buscar veh�culos por marca
SELECT * FROM coches WHERE marca = 'Toyota';

-- 8. Buscar veh�culos por tipo
SELECT * FROM coches WHERE tipo = 'SUV';

-- 9. Buscar veh�culos por a�o espec�fico
SELECT * FROM coches WHERE anio = 2023;

-- 10. Buscar veh�culos de a�os recientes (2022 en adelante)
SELECT * FROM coches WHERE anio >= 2022;

-- ====================================================
-- B�SQUEDAS CON LIKE (b�squeda parcial)
-- ====================================================

-- 11. Buscar marcas que contengan "ota"
SELECT * FROM coches WHERE marca LIKE '%ota%';

-- 12. Buscar modelos que empiecen con "F"
SELECT * FROM coches WHERE modelo LIKE 'F%';

-- 13. Buscar placas que terminen con "123"
SELECT * FROM coches WHERE placa LIKE '%123';

-- ====================================================
-- ESTAD�STICAS Y AGRUPACIONES
-- ====================================================

-- 14. Contar veh�culos por tipo
SELECT tipo, COUNT(*) as cantidad 
FROM coches 
GROUP BY tipo;

-- 15. Contar veh�culos por marca
SELECT marca, COUNT(*) as cantidad 
FROM coches 
GROUP BY marca 
ORDER BY cantidad DESC;

-- 16. Contar veh�culos por a�o
SELECT anio, COUNT(*) as cantidad 
FROM coches 
GROUP BY anio 
ORDER BY anio DESC;

-- 17. Promedio de a�o de los veh�culos
SELECT AVG(anio) as promedio_anio FROM coches;

-- 18. Veh�culo m�s antiguo y m�s reciente
SELECT MIN(anio) as mas_antiguo, MAX(anio) as mas_reciente FROM coches;

-- ====================================================
-- CONSULTAS COMBINADAS (AND, OR)
-- ====================================================

-- 19. SUVs del a�o 2023
SELECT * FROM coches WHERE tipo = 'SUV' AND anio = 2023;

-- 20. Toyota o Honda
SELECT * FROM coches WHERE marca = 'Toyota' OR marca = 'Honda';

-- 21. Veh�culos recientes (2023 o 2024) que sean SUV
SELECT * FROM coches WHERE anio IN (2023, 2024) AND tipo = 'SUV';

-- 22. Pick-ups de Ford o Chevrolet
SELECT * FROM coches WHERE tipo = 'PICK UP' AND marca IN ('Ford', 'Chevrolet');

-- ====================================================
-- CONSULTAS CON L�MITE
-- ====================================================

-- 23. Los 5 veh�culos m�s recientes
SELECT * FROM coches ORDER BY anio DESC LIMIT 5;

-- 24. Los 3 primeros registros
SELECT * FROM coches LIMIT 3;

-- 25. Registros del 4 al 6
SELECT * FROM coches LIMIT 3 OFFSET 3;

-- ====================================================
-- OPERACIONES DE MANTENIMIENTO
-- ====================================================

-- 26. Ver estructura de la tabla
DESCRIBE coches;

-- 27. Ver �ndices de la tabla
SHOW INDEX FROM coches;

-- 28. Ver tama�o de la tabla
SELECT 
    table_name AS 'Tabla',
    ROUND(((data_length + index_length) / 1024 / 1024), 2) AS 'Tama�o (MB)'
FROM information_schema.TABLES
WHERE table_schema = 'concesionaria' AND table_name = 'coches';

-- ====================================================
-- INSERTAR DATOS DE PRUEBA ADICIONALES
-- ====================================================

-- 29. Insertar un veh�culo individual
INSERT INTO coches (placa, marca, modelo, anio, tipo) 
VALUES ('TEST001', 'Mazda', 'CX-5', 2024, 'SUV');

-- 30. Insertar m�ltiples veh�culos
INSERT INTO coches (placa, marca, modelo, anio, tipo) VALUES
('MNO345', 'Volkswagen', 'Tiguan', 2023, 'SUV'),
('PQR678', 'Ram', '1500', 2024, 'PICK UP'),
('STU901', 'BMW', '320i', 2023, 'SEDAN');

-- ====================================================
-- ACTUALIZAR DATOS
-- ====================================================

-- 31. Actualizar la marca de un veh�culo
UPDATE coches SET marca = 'TOYOTA' WHERE placa = 'ABC123';

-- 32. Actualizar m�ltiples campos
UPDATE coches 
SET marca = 'Honda', modelo = 'CR-V', anio = 2024 
WHERE placa = 'XYZ789';

-- 33. Actualizar todos los veh�culos de un tipo
UPDATE coches SET tipo = 'SUV/CAMIONETA' WHERE tipo = 'SUV';

-- ====================================================
-- ELIMINAR DATOS
-- ====================================================

-- 34. Eliminar un veh�culo por placa
DELETE FROM coches WHERE placa = 'TEST001';

-- 35. Eliminar veh�culos antiguos (antes de 2020)
DELETE FROM coches WHERE anio < 2020;

-- 36. PELIGRO: Eliminar todos los registros (�Usar con cuidado!)
-- DELETE FROM coches;

-- ====================================================
-- CONSULTAS AVANZADAS
-- ====================================================

-- 37. Veh�culos con informaci�n completa formateada
SELECT 
    CONCAT(marca, ' ', modelo, ' (', anio, ')') as vehiculo,
    placa,
    tipo,
    DATE_FORMAT(fecha_registro, '%d/%m/%Y %H:%i') as registrado
FROM coches;

-- 38. Edad aproximada de los veh�culos
SELECT 
    placa,
    marca,
    modelo,
    anio,
    (YEAR(CURDATE()) - anio) as edad_anos
FROM coches
ORDER BY edad_anos ASC;

-- 39. Veh�culos registrados hoy
SELECT * FROM coches WHERE DATE(fecha_registro) = CURDATE();

-- 40. Veh�culos registrados en los �ltimos 7 d�as
SELECT * FROM coches WHERE fecha_registro >= DATE_SUB(NOW(), INTERVAL 7 DAY);

-- 41. Reporte de inventario por tipo
SELECT 
    tipo,
    COUNT(*) as cantidad,
    GROUP_CONCAT(marca ORDER BY marca) as marcas,
    MIN(anio) as anio_mas_antiguo,
    MAX(anio) as anio_mas_reciente
FROM coches
GROUP BY tipo;

-- 42. Buscar veh�culos duplicados por marca y modelo
SELECT marca, modelo, COUNT(*) as duplicados
FROM coches
GROUP BY marca, modelo
HAVING COUNT(*) > 1;

-- ====================================================
-- BACKUP Y RESTORE (Informaci�n)
-- ====================================================

-- Para hacer backup completo desde CMD/Terminal:
-- mysqldump -u root -p concesionaria > backup_concesionaria.sql

-- Para hacer backup solo de la tabla coches:
-- mysqldump -u root -p concesionaria coches > backup_coches.sql

-- Para restaurar desde CMD/Terminal:
-- mysql -u root -p concesionaria < backup_concesionaria.sql

-- ====================================================
-- LIMPIAR Y REINICIAR
-- ====================================================

-- 43. Eliminar todos los registros pero mantener la estructura
TRUNCATE TABLE coches;

-- 44. Resetear el auto_increment
ALTER TABLE coches AUTO_INCREMENT = 1;

-- 45. Reiniciar con datos de ejemplo
INSERT INTO coches (placa, marca, modelo, anio, tipo) VALUES
('ABC123', 'Toyota', 'RAV4', 2023, 'SUV'),
('XYZ789', 'Ford', 'F-150', 2022, 'PICK UP'),
('DEF456', 'Honda', 'Accord', 2024, 'SEDAN'),
('GHI789', 'Chevrolet', 'Tahoe', 2023, 'SUV'),
('JKL012', 'Nissan', 'Frontier', 2022, 'PICK UP');

-- ====================================================
-- VERIFICAR INTEGRIDAD
-- ====================================================

-- 46. Verificar que no haya placas duplicadas
SELECT placa, COUNT(*) as veces
FROM coches
GROUP BY placa
HAVING COUNT(*) > 1;

-- 47. Verificar campos vac�os o nulos
SELECT * FROM coches 
WHERE placa IS NULL OR marca IS NULL OR modelo IS NULL OR anio IS NULL OR tipo IS NULL;

-- 48. Verificar a�os v�lidos (entre 1900 y a�o actual + 1)
SELECT * FROM coches 
WHERE anio < 1900 OR anio > YEAR(CURDATE()) + 1;

-- ====================================================
-- EXPORTAR DATOS
-- ====================================================

-- 49. Exportar a CSV (ejecutar en MySQL Workbench)
SELECT placa, marca, modelo, anio, tipo
INTO OUTFILE 'C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/coches.csv'
FIELDS TERMINATED BY ','
ENCLOSED BY '"'
LINES TERMINATED BY '\n'
FROM coches;

-- Nota: Ajusta la ruta seg�n tu configuraci�n de MySQL

-- ====================================================
-- INFORMACI�N DEL SISTEMA
-- ====================================================

-- 50. Ver versi�n de MySQL
SELECT VERSION();

-- 51. Ver configuraci�n de la base de datos
SHOW VARIABLES LIKE 'character_set%';

-- 52. Ver todas las tablas en la base de datos
SHOW TABLES;

-- 53. Ver informaci�n de la base de datos
SELECT 
    table_name,
    table_rows,
    ROUND(((data_length + index_length) / 1024 / 1024), 2) AS 'Size (MB)'
FROM information_schema.TABLES
WHERE table_schema = 'concesionaria';

-- ====================================================
-- FIN DE CONSULTAS DE EJEMPLO
-- ====================================================

-- TIP: Selecciona solo las l�neas que quieras ejecutar
-- y presiona Ctrl+Enter o el bot�n del rayo ?
