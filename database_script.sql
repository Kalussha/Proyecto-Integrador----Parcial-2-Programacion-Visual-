-- ====================================================
-- Script SQL para la base de datos de Concesionaria
-- Sistema de gestión de vehículos
-- MySQL Workbench
-- ====================================================

-- Crear la base de datos
CREATE DATABASE IF NOT EXISTS concesionaria;

-- Usar la base de datos
USE concesionaria;

-- Eliminar la tabla si existe (para reiniciar)
DROP TABLE IF EXISTS coches;

-- Crear la tabla de coches
CREATE TABLE coches (
    id INT AUTO_INCREMENT PRIMARY KEY,
    placa VARCHAR(20) NOT NULL UNIQUE,
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    anio INT NOT NULL,
    tipo VARCHAR(20) NOT NULL,
    fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    fecha_actualizacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    INDEX idx_placa (placa),
    INDEX idx_marca (marca),
    INDEX idx_anio (anio)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Insertar datos de ejemplo (opcional)
INSERT INTO coches (placa, marca, modelo, anio, tipo) VALUES
('ABC123', 'Toyota', 'RAV4', 2023, 'SUV'),
('XYZ789', 'Ford', 'F-150', 2022, 'PICK UP'),
('DEF456', 'Honda', 'Accord', 2024, 'SEDAN'),
('GHI789', 'Chevrolet', 'Tahoe', 2023, 'SUV'),
('JKL012', 'Nissan', 'Frontier', 2022, 'PICK UP');

-- Consultar todos los registros
SELECT * FROM coches;

-- ====================================================
-- CONSULTAS ÚTILES
-- ====================================================

-- Ver la estructura de la tabla
DESCRIBE coches;

-- Contar total de vehículos
SELECT COUNT(*) as total_vehiculos FROM coches;

-- Contar vehículos por tipo
SELECT tipo, COUNT(*) as cantidad 
FROM coches 
GROUP BY tipo;

-- Buscar por placa
SELECT * FROM coches WHERE placa = 'ABC123';

-- Buscar por marca
SELECT * FROM coches WHERE marca LIKE '%Toyota%';

-- Vehículos más recientes
SELECT * FROM coches ORDER BY anio DESC LIMIT 10;

-- ====================================================
-- PROCEDIMIENTOS ALMACENADOS (opcional)
-- ====================================================

-- Procedimiento para insertar un coche
DELIMITER //
CREATE PROCEDURE sp_insertar_coche(
    IN p_placa VARCHAR(20),
    IN p_marca VARCHAR(50),
    IN p_modelo VARCHAR(50),
    IN p_anio INT,
    IN p_tipo VARCHAR(20)
)
BEGIN
    INSERT INTO coches (placa, marca, modelo, anio, tipo)
    VALUES (p_placa, p_marca, p_modelo, p_anio, p_tipo);
END //
DELIMITER ;

-- Procedimiento para actualizar un coche
DELIMITER //
CREATE PROCEDURE sp_actualizar_coche(
    IN p_placa VARCHAR(20),
    IN p_marca VARCHAR(50),
    IN p_modelo VARCHAR(50),
    IN p_anio INT,
    IN p_tipo VARCHAR(20)
)
BEGIN
    UPDATE coches 
    SET marca = p_marca, 
        modelo = p_modelo, 
        anio = p_anio, 
        tipo = p_tipo
    WHERE placa = p_placa;
END //
DELIMITER ;

-- Procedimiento para eliminar un coche
DELIMITER //
CREATE PROCEDURE sp_eliminar_coche(IN p_placa VARCHAR(20))
BEGIN
    DELETE FROM coches WHERE placa = p_placa;
END //
DELIMITER ;

-- Procedimiento para buscar un coche por placa
DELIMITER //
CREATE PROCEDURE sp_buscar_coche(IN p_placa VARCHAR(20))
BEGIN
    SELECT * FROM coches WHERE placa = p_placa;
END //
DELIMITER ;

-- ====================================================
-- BACKUP Y RESTORE (comandos de ejemplo)
-- ====================================================

-- Para hacer backup desde la línea de comandos:
-- mysqldump -u root -p concesionaria > backup_concesionaria.sql

-- Para restaurar desde la línea de comandos:
-- mysql -u root -p concesionaria < backup_concesionaria.sql

-- ====================================================
-- FIN DEL SCRIPT
-- ====================================================
