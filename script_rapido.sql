CREATE DATABASE IF NOT EXISTS concesionaria;
USE concesionaria;

-- Crear la tabla
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Insertar datos de ejemplo
INSERT INTO coches (placa, marca, modelo, anio, tipo) VALUES
('ABC123', 'Toyota', 'RAV4', 2023, 'SUV'),
('XYZ789', 'Ford', 'F-150', 2022, 'PICK UP'),
('DEF456', 'Honda', 'Accord', 2024, 'SEDAN'),
('GHI789', 'Chevrolet', 'Tahoe', 2023, 'SUV'),
('JKL012', 'Nissan', 'Frontier', 2022, 'PICK UP');

-- Ver los datos insertados
SELECT * FROM coches;
