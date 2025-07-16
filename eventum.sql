-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-07-2025 a las 10:36:59
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
-- Base de datos: `eventum`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entradas`
--

CREATE TABLE `entradas` (
  `id` int(11) NOT NULL,
  `evento_id` int(11) NOT NULL,
  `participante_id` int(11) NOT NULL,
  `codigo_entrada` varchar(20) NOT NULL,
  `fecha_compra` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `entradas`
--

INSERT INTO `entradas` (`id`, `evento_id`, `participante_id`, `codigo_entrada`, `fecha_compra`) VALUES
(1, 1, 1, '9A44809D', '0001-01-01 00:00:00'),
(2, 1, 1, '68D52465', '0001-01-01 00:00:00'),
(3, 1, 16, '88204C1E', '0001-01-01 00:00:00'),
(4, 1, 5, '98EA9E10', '0001-01-01 00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `eventos`
--

CREATE TABLE `eventos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `fecha` date NOT NULL,
  `lugar` varchar(150) NOT NULL,
  `capacidad` int(11) NOT NULL,
  `precio` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `eventos`
--

INSERT INTO `eventos` (`id`, `nombre`, `descripcion`, `fecha`, `lugar`, `capacidad`, `precio`) VALUES
(1, 'CONCIERTO THE WEEKEND', 'UIO, ATAHUALPA', '2025-10-23', 'ESTADIO OLIMPICO ATAHUALPA', 100, 100.00),
(2, 'Festival de Jazz', 'Evento con músicos internacionales de jazz.', '2025-11-05', 'Teatro Nacional', 500, 50.00),
(3, 'Exposición de Arte', 'Exposición de arte moderno en el museo local.', '2025-11-12', 'Museo Nacional', 200, 20.00),
(4, 'Concierto de Metal', 'Concierto de bandas de metal, con la participación de grupos internacionales.', '2025-11-15', 'Estadio Olímpico', 10000, 150.00),
(5, 'Feria de Emprendedores', 'Feria de negocios y startups con conferencias y paneles.', '2025-11-18', 'Centro de Convenciones', 1000, 30.00),
(6, 'Maratón Internacional', 'Maratón para recaudar fondos para obras benéficas.', '2025-11-22', 'Parque Central', 5000, 10.00),
(7, 'Carnaval de Invierno', 'Carnaval con desfiles, bailes y actividades familiares.', '2025-12-10', 'Plaza Mayor', 2000, 5.00),
(8, 'Teatro Clásico', 'Obra teatral basada en clásicos de la literatura mundial.', '2025-12-15', 'Teatro Municipal', 300, 40.00),
(9, 'Festival de Cine', 'Proyección de películas nacionales e internacionales de cine independiente.', '2025-12-20', 'Cine Multicines', 400, 25.00),
(10, 'Torneo de Fútbol 7', 'Torneo amateur de fútbol 7 con equipos locales.', '2026-01-10', 'Estadio Municipal', 500, 15.00),
(11, 'Exposición de Tecnología', 'Muestra de las últimas innovaciones tecnológicas.', '2026-01-15', 'Centro de Convenciones', 1000, 40.00),
(12, 'Festival Gastronómico', 'Muestra gastronómica con los mejores chefs del país.', '2026-01-20', 'Parque Central', 1500, 20.00),
(13, 'Feria de Vinos', 'Degustación de vinos nacionales e internacionales.', '2026-01-25', 'Hotel Plaza', 200, 100.00),
(14, 'Espectáculo de Magia', 'Gran show de magia con ilusionistas de renombre.', '2026-02-05', 'Teatro Principal', 300, 35.00),
(15, 'Feria del Libro Infantil', 'Exposición de libros para niños con actividades interactivas.', '2026-02-10', 'Centro Cultural', 500, 10.00),
(16, 'Concierto de Música Electrónica', 'Concierto de DJs internacionales y locales.', '2026-02-15', 'Parque de los Niños', 8000, 80.00),
(17, 'Exposición de Moda', 'Desfile de alta costura y moda de diseñadores nacionales.', '2026-02-18', 'Centro de Exposiciones', 400, 60.00),
(18, 'Torneo Internacional de Ajedrez', 'Competencia de ajedrez con jugadores de todo el mundo.', '2026-02-20', 'Auditorio Nacional', 500, 25.00),
(19, 'Festival de Teatro Independiente', 'Muestra de obras de teatro independiente.', '2026-02-25', 'Teatro Moderno', 300, 20.00),
(20, 'Carrera de Autos Clásicos', 'Competencia de autos clásicos y antiguos.', '2026-03-05', 'Circuito de Carreras', 200, 50.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagoproductos`
--

CREATE TABLE `pagoproductos` (
  `id` int(11) NOT NULL,
  `pago_id` int(11) DEFAULT NULL,
  `producto_id` int(11) DEFAULT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pagos`
--

CREATE TABLE `pagos` (
  `id` int(11) NOT NULL,
  `entrada_id` int(11) NOT NULL,
  `monto` decimal(10,2) NOT NULL,
  `metodo_pago` enum('Efectivo','Tarjeta','Transferencia','Otro') NOT NULL,
  `estado_pago` enum('Pendiente','Pagado','Rechazado') DEFAULT 'Pendiente',
  `fecha_pago` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `pagos`
--

INSERT INTO `pagos` (`id`, `entrada_id`, `monto`, `metodo_pago`, `estado_pago`, `fecha_pago`) VALUES
(2, 2, 100.00, '', 'Pendiente', '2025-07-16 02:22:30'),
(3, 2, 100.00, '', 'Pendiente', '2025-07-16 02:22:35'),
(4, 2, 100.00, '', 'Pendiente', '2025-07-16 02:31:29'),
(7, 4, 344.00, 'Efectivo', 'Pendiente', '2025-07-16 03:13:36'),
(8, 2, 343.00, '', 'Pendiente', '2025-07-16 03:30:32'),
(9, 2, 566.00, '', 'Pendiente', '2025-07-16 03:33:54');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `participantes`
--

CREATE TABLE `participantes` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `documento_identidad` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `participantes`
--

INSERT INTO `participantes` (`id`, `nombre`, `correo`, `telefono`, `documento_identidad`) VALUES
(1, 'DAVID', 'DAV@GMAIL,COM', '098099032', '172156473'),
(2, 'Carlos', 'carlos@example.com', '0988776655', '172156474'),
(3, 'María', 'maria@example.com', '0998776655', '172156475'),
(4, 'Pedro', 'pedro@example.com', '0987665544', '172156476'),
(5, 'Ana', 'ana@example.com', '0987554433', '172156477'),
(6, 'Lucía', 'lucia@example.com', '0997443322', '172156478'),
(7, 'Jorge', 'jorge@example.com', '0977332211', '172156479'),
(8, 'Elena', 'elena@example.com', '0967221100', '172156480'),
(9, 'Miguel', 'miguel@example.com', '0957110999', '172156481'),
(10, 'Sofía', 'sofia@example.com', '0947009888', '172156482'),
(11, 'David', 'david@example.com', '0936898777', '172156483'),
(12, 'Carlos', 'carlos2@example.com', '0926787666', '172156484'),
(13, 'Pedro', 'pedro2@example.com', '0916676555', '172156485'),
(14, 'María', 'maria2@example.com', '0906565444', '172156486'),
(15, 'Ana', 'ana2@example.com', '0896454333', '172156487'),
(16, 'Lucía', 'lucia2@example.com', '0886343222', '172156488'),
(17, 'Jorge', 'jorge2@example.com', '0876232111', '172156489'),
(18, 'Elena', 'elena2@example.com', '0866121000', '172156490'),
(19, 'Miguel', 'miguel2@example.com', '0856010999', '172156491'),
(20, 'Sofía', 'sofia2@example.com', '0845909888', '172156492'),
(21, 'David', 'david2@example.com', '0835798777', '172156493'),
(22, 'Carlos', 'carlos3@example.com', '0825687666', '172156494'),
(23, 'Pedro', 'pedro3@example.com', '0815576555', '172156495'),
(24, 'María', 'maria3@example.com', '0805465444', '172156496'),
(25, 'Ana', 'ana3@example.com', '0795354333', '172156497'),
(26, 'Lucía', 'lucia3@example.com', '0785243222', '172156498'),
(27, 'Jorge', 'jorge3@example.com', '0775132111', '172156499'),
(28, 'Elena', 'elena3@example.com', '0765021000', '172156500'),
(29, 'Miguel', 'miguel3@example.com', '0754910999', '172156501'),
(30, 'Sofía', 'sofia3@example.com', '0744809888', '172156502'),
(100, 'Camila', 'camila100@example.com', '0900999777', '172157573');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reportes`
--

CREATE TABLE `reportes` (
  `Id` int(11) NOT NULL,
  `EventoId` int(11) NOT NULL,
  `FechaInicio` datetime NOT NULL,
  `FechaFin` datetime NOT NULL,
  `BoletosVendidos` int(11) NOT NULL,
  `TotalVendido` decimal(10,2) NOT NULL,
  `FechaGeneracion` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `apellidos` varchar(100) NOT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  `correo` varchar(100) NOT NULL,
  `contrasena` varchar(255) DEFAULT NULL,
  `fecha_creacion` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `apellidos`, `telefono`, `correo`, `contrasena`, `fecha_creacion`) VALUES
(1, 'Juan', 'Pérez', '0991234567', 'juan.perez@example.com', 'a9e34565c4001bc8b5283658b8e30c1d5d67b5da240dcf719ca67307344335da', '2025-07-15 23:46:09'),
(3, 'María', 'González', '0987654321', 'maria.gonzalez@example.com', '123', '2025-07-15 23:48:05'),
(4, 'JUAN', 'ALBUJA', '0980029658', 'Albexp@gmail.com', '123', '2025-07-16 00:50:43');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `entradas`
--
ALTER TABLE `entradas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `codigo_entrada` (`codigo_entrada`),
  ADD KEY `evento_id` (`evento_id`),
  ADD KEY `participante_id` (`participante_id`);

--
-- Indices de la tabla `eventos`
--
ALTER TABLE `eventos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `pagoproductos`
--
ALTER TABLE `pagoproductos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pago_id` (`pago_id`),
  ADD KEY `producto_id` (`producto_id`);

--
-- Indices de la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD PRIMARY KEY (`id`),
  ADD KEY `entrada_id` (`entrada_id`);

--
-- Indices de la tabla `participantes`
--
ALTER TABLE `participantes`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `correo` (`correo`),
  ADD UNIQUE KEY `documento_identidad` (`documento_identidad`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `reportes`
--
ALTER TABLE `reportes`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `EventoId` (`EventoId`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `correo` (`correo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `entradas`
--
ALTER TABLE `entradas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `eventos`
--
ALTER TABLE `eventos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de la tabla `pagoproductos`
--
ALTER TABLE `pagoproductos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `pagos`
--
ALTER TABLE `pagos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `participantes`
--
ALTER TABLE `participantes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `reportes`
--
ALTER TABLE `reportes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `entradas`
--
ALTER TABLE `entradas`
  ADD CONSTRAINT `entradas_ibfk_1` FOREIGN KEY (`evento_id`) REFERENCES `eventos` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `entradas_ibfk_2` FOREIGN KEY (`participante_id`) REFERENCES `participantes` (`id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `pagoproductos`
--
ALTER TABLE `pagoproductos`
  ADD CONSTRAINT `pagoproductos_ibfk_1` FOREIGN KEY (`pago_id`) REFERENCES `pagos` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `pagoproductos_ibfk_2` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `pagos`
--
ALTER TABLE `pagos`
  ADD CONSTRAINT `pagos_ibfk_1` FOREIGN KEY (`entrada_id`) REFERENCES `entradas` (`id`) ON DELETE CASCADE;

--
-- Filtros para la tabla `reportes`
--
ALTER TABLE `reportes`
  ADD CONSTRAINT `reportes_ibfk_1` FOREIGN KEY (`EventoId`) REFERENCES `eventos` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
