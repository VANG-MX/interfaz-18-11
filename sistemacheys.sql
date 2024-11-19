-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 19-11-2024 a las 01:05:36
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sistemacheys`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE `empleados` (
  `No_reloj` int(11) NOT NULL,
  `Nombre` varchar(75) NOT NULL,
  `A_paterno` varchar(50) NOT NULL,
  `A_materno` varchar(50) NOT NULL,
  `Carrera` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`No_reloj`, `Nombre`, `A_paterno`, `A_materno`, `Carrera`) VALUES
(2, 'Angel Ivan ', 'Modeto', 'Hernandez', 'Industrial'),
(19111716, 'Andiel', 'Valdiviezo', 'Garcia', 'TICS'),
(20112079, 'Gabriel', 'Antonio', 'Garcia', 'Sistemanco');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historial_manual`
--

CREATE TABLE `historial_manual` (
  `ID_Manual` int(11) NOT NULL,
  `no_Reloj` int(11) NOT NULL,
  `Motivo` varchar(30) NOT NULL,
  `Hora` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `historial_manual`
--

INSERT INTO `historial_manual` (`ID_Manual`, `no_Reloj`, `Motivo`, `Hora`) VALUES
(21, 2, 'Se te olvido', '07:40:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historial_retardos`
--

CREATE TABLE `historial_retardos` (
  `ID_Retardos` int(11) NOT NULL,
  `no_Reloj` int(11) NOT NULL,
  `Hora` varchar(10) NOT NULL,
  `Motivo` varchar(50) NOT NULL,
  `Planeado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `historial_retardos`
--

INSERT INTO `historial_retardos` (`ID_Retardos`, `no_Reloj`, `Hora`, `Motivo`, `Planeado`) VALUES
(12, 19111716, '19:40:14', 'zzzzzz', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historial_salidas`
--

CREATE TABLE `historial_salidas` (
  `id_historial` int(11) NOT NULL,
  `no_reloj` int(11) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `hora_salida` varchar(10) NOT NULL,
  `regresa` tinyint(1) DEFAULT NULL,
  `Hora_regreso` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `historial_salidas`
--

INSERT INTO `historial_salidas` (`id_historial`, `no_reloj`, `correo`, `hora_salida`, `regresa`, `Hora_regreso`) VALUES
(42, 2, 'dgsfg', '8:00', 0, NULL),
(43, 19111716, 'grsg', '10:00', 1, '12:00'),
(44, 2, 'zzzz', '10:00', 1, ''),
(45, 2, 'gzdfg', '7:00', 1, '11:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registros`
--

CREATE TABLE `registros` (
  `id_registro` int(11) NOT NULL,
  `no_reloj` int(11) NOT NULL,
  `hora` varchar(20) NOT NULL,
  `fecha` varchar(20) NOT NULL,
  `Nombre` varchar(255) DEFAULT NULL,
  `Carrera` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `registros`
--

INSERT INTO `registros` (`id_registro`, `no_reloj`, `hora`, `fecha`, `Nombre`, `Carrera`) VALUES
(109, 2, '03:23 p. m.', '18/11/2024', 'Angel Ivan ', 'Industrial'),
(110, 19111716, '03:24 p. m.', '18/11/2024', 'Andiel', 'TICS'),
(111, 20112079, '03:25 p. m.', '18/11/2024', 'Gabriel', 'Sistemanco');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`No_reloj`),
  ADD KEY `No_reloj` (`No_reloj`,`Nombre`,`A_paterno`,`A_materno`,`Carrera`);

--
-- Indices de la tabla `historial_manual`
--
ALTER TABLE `historial_manual`
  ADD PRIMARY KEY (`ID_Manual`),
  ADD KEY `ID_Manual` (`ID_Manual`,`no_Reloj`,`Motivo`,`Hora`),
  ADD KEY `no_Reloj` (`no_Reloj`);

--
-- Indices de la tabla `historial_retardos`
--
ALTER TABLE `historial_retardos`
  ADD PRIMARY KEY (`ID_Retardos`),
  ADD KEY `ID_Retardos` (`ID_Retardos`,`no_Reloj`,`Hora`,`Motivo`,`Planeado`),
  ADD KEY `no_Reloj` (`no_Reloj`);

--
-- Indices de la tabla `historial_salidas`
--
ALTER TABLE `historial_salidas`
  ADD PRIMARY KEY (`id_historial`),
  ADD KEY `no_reloj` (`no_reloj`),
  ADD KEY `id_historial` (`id_historial`,`no_reloj`,`correo`,`hora_salida`,`regresa`),
  ADD KEY `Hora_regreso` (`Hora_regreso`);

--
-- Indices de la tabla `registros`
--
ALTER TABLE `registros`
  ADD PRIMARY KEY (`id_registro`),
  ADD KEY `no_reloj` (`no_reloj`),
  ADD KEY `id_registro` (`id_registro`,`no_reloj`,`hora`,`fecha`),
  ADD KEY `Nombre` (`Nombre`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `No_reloj` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20112080;

--
-- AUTO_INCREMENT de la tabla `historial_manual`
--
ALTER TABLE `historial_manual`
  MODIFY `ID_Manual` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT de la tabla `historial_retardos`
--
ALTER TABLE `historial_retardos`
  MODIFY `ID_Retardos` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `historial_salidas`
--
ALTER TABLE `historial_salidas`
  MODIFY `id_historial` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=46;

--
-- AUTO_INCREMENT de la tabla `registros`
--
ALTER TABLE `registros`
  MODIFY `id_registro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=112;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `historial_manual`
--
ALTER TABLE `historial_manual`
  ADD CONSTRAINT `historial_manual_ibfk_1` FOREIGN KEY (`no_Reloj`) REFERENCES `empleados` (`No_reloj`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `historial_retardos`
--
ALTER TABLE `historial_retardos`
  ADD CONSTRAINT `historial_retardos_ibfk_1` FOREIGN KEY (`no_Reloj`) REFERENCES `empleados` (`No_reloj`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `historial_salidas`
--
ALTER TABLE `historial_salidas`
  ADD CONSTRAINT `historial_salidas_ibfk_1` FOREIGN KEY (`no_reloj`) REFERENCES `empleados` (`No_reloj`) ON UPDATE CASCADE;

--
-- Filtros para la tabla `registros`
--
ALTER TABLE `registros`
  ADD CONSTRAINT `fk_no_reloj` FOREIGN KEY (`no_reloj`) REFERENCES `empleados` (`No_reloj`),
  ADD CONSTRAINT `registros_ibfk_1` FOREIGN KEY (`no_reloj`) REFERENCES `empleados` (`No_reloj`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
