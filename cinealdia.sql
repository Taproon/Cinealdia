-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.4.13-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para cinealdia
CREATE DATABASE IF NOT EXISTS `cinealdia` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `cinealdia`;

-- Volcando estructura para tabla cinealdia.actores
CREATE TABLE IF NOT EXISTS `actores` (
  `nombre` varchar(100) DEFAULT NULL,
  `apellidos` varchar(100) DEFAULT NULL,
  `personaje` varchar(100) DEFAULT NULL,
  `idpelicula` int(11) NOT NULL,
  KEY `FK_actores_peliculas` (`idpelicula`),
  CONSTRAINT `FK_actores_peliculas` FOREIGN KEY (`idpelicula`) REFERENCES `peliculas` (`idpelicula`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla cinealdia.actores: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `actores` DISABLE KEYS */;
/*!40000 ALTER TABLE `actores` ENABLE KEYS */;

-- Volcando estructura para tabla cinealdia.bso
CREATE TABLE IF NOT EXISTS `bso` (
  `idpelicula` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  KEY `FK_bso_peliculas` (`idpelicula`),
  CONSTRAINT `FK_bso_peliculas` FOREIGN KEY (`idpelicula`) REFERENCES `peliculas` (`idpelicula`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla cinealdia.bso: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `bso` DISABLE KEYS */;
INSERT INTO `bso` (`idpelicula`, `nombre`) VALUES
	(19, 'tino'),
	(20, 'nana');
/*!40000 ALTER TABLE `bso` ENABLE KEYS */;

-- Volcando estructura para tabla cinealdia.directores
CREATE TABLE IF NOT EXISTS `directores` (
  `idpelicula` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  KEY `FK1_directores` (`idpelicula`),
  CONSTRAINT `FK1_directores` FOREIGN KEY (`idpelicula`) REFERENCES `peliculas` (`idpelicula`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla cinealdia.directores: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `directores` DISABLE KEYS */;
INSERT INTO `directores` (`idpelicula`, `nombre`) VALUES
	(19, 'Tarantino'),
	(20, 'Papa');
/*!40000 ALTER TABLE `directores` ENABLE KEYS */;

-- Volcando estructura para tabla cinealdia.guionistas
CREATE TABLE IF NOT EXISTS `guionistas` (
  `idpelicula` int(11) NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  KEY `FK1_guionistas` (`idpelicula`),
  CONSTRAINT `FK1_guionistas` FOREIGN KEY (`idpelicula`) REFERENCES `peliculas` (`idpelicula`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla cinealdia.guionistas: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `guionistas` DISABLE KEYS */;
INSERT INTO `guionistas` (`idpelicula`, `nombre`) VALUES
	(19, 'Taran'),
	(20, 'lala');
/*!40000 ALTER TABLE `guionistas` ENABLE KEYS */;

-- Volcando estructura para tabla cinealdia.peliculas
CREATE TABLE IF NOT EXISTS `peliculas` (
  `titulo` varchar(100) DEFAULT 'sin datos',
  `estudio` varchar(100) DEFAULT 'sin datos',
  `año` int(11) DEFAULT 0,
  `puntuacion` int(11) DEFAULT 0,
  `duracion` int(11) DEFAULT 0,
  `estado` varchar(100) DEFAULT 'sin datos',
  `generos` varchar(100) DEFAULT 'sin datos',
  `publico` varchar(100) DEFAULT 'sin datos',
  `tipo` varchar(100) DEFAULT 'sin datos',
  `portada` blob DEFAULT '0',
  `comentario` varchar(200) DEFAULT NULL,
  `idpelicula` int(11) NOT NULL AUTO_INCREMENT,
  `idusuario` varchar(100) DEFAULT 'sin datos',
  PRIMARY KEY (`idpelicula`),
  KEY `idusuario` (`idusuario`),
  CONSTRAINT `FK_peliculas_usuarios` FOREIGN KEY (`idusuario`) REFERENCES `usuarios` (`nombreuser`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla cinealdia.peliculas: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `peliculas` DISABLE KEYS */;
INSERT INTO `peliculas` (`titulo`, `estudio`, `año`, `puntuacion`, `duracion`, `estado`, `generos`, `publico`, `tipo`, `portada`, `comentario`, `idpelicula`, `idusuario`) VALUES
	('AFK', 'Warner', 1209, 8, 150, 'En coleccion, Vista, ', 'Aventura, Comedia, ', 'PG-12', 'Pelicula', _binary 0x53797374656D2E57696E646F77732E466F726D732E50696374757265426F782C2053697A654D6F64653A2053747265746368496D616765, 'Hola', 19, 'Taproon'),
	('Tuto', 'Ala', 1209, 7, 8, 'La quiero, En venta, ', 'Fantasía, Thriller, ', 'PG-16', 'Pelicula', _binary 0x53797374656D2E57696E646F77732E466F726D732E50696374757265426F782C2053697A654D6F64653A2053747265746368496D616765, 'Adios', 20, 'Taproon');
/*!40000 ALTER TABLE `peliculas` ENABLE KEYS */;

-- Volcando estructura para tabla cinealdia.provincias
CREATE TABLE IF NOT EXISTS `provincias` (
  `id` int(2) NOT NULL AUTO_INCREMENT,
  `provincia` varchar(255) COLLATE latin1_spanish_ci NOT NULL,
  KEY `id` (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=53 DEFAULT CHARSET=latin1 COLLATE=latin1_spanish_ci;

-- Volcando datos para la tabla cinealdia.provincias: 52 rows
/*!40000 ALTER TABLE `provincias` DISABLE KEYS */;
INSERT INTO `provincias` (`id`, `provincia`) VALUES
	(1, 'Álava'),
	(2, 'Albacete'),
	(3, 'Alicante'),
	(4, 'Almería'),
	(5, 'Ávila'),
	(6, 'Badajoz'),
	(7, 'Baleares (Illes)'),
	(8, 'Barcelona'),
	(9, 'Burgos'),
	(10, 'Cáceres'),
	(11, 'Cádiz'),
	(12, 'Castellón'),
	(13, 'Ciudad Real'),
	(14, 'Córdoba'),
	(15, 'A Coruña'),
	(16, 'Cuenca'),
	(17, 'Girona'),
	(18, 'Granada'),
	(19, 'Guadalajara'),
	(20, 'Guipúzcoa'),
	(21, 'Huelva'),
	(22, 'Huesca'),
	(23, 'Jaén'),
	(24, 'León'),
	(25, 'Lleida'),
	(26, 'La Rioja'),
	(27, 'Lugo'),
	(28, 'Madrid'),
	(29, 'Málaga'),
	(30, 'Murcia'),
	(31, 'Navarra'),
	(32, 'Ourense'),
	(33, 'Asturias'),
	(34, 'Palencia'),
	(35, 'Las Palmas'),
	(36, 'Pontevedra'),
	(37, 'Salamanca'),
	(38, 'Santa Cruz de Tenerife'),
	(39, 'Cantabria'),
	(40, 'Segovia'),
	(41, 'Sevilla'),
	(42, 'Soria'),
	(43, 'Tarragona'),
	(44, 'Teruel'),
	(45, 'Toledo'),
	(46, 'Valencia'),
	(47, 'Valladolid'),
	(48, 'Vizcaya'),
	(49, 'Zamora'),
	(50, 'Zaragoza'),
	(51, 'Ceuta'),
	(52, 'Melilla');
/*!40000 ALTER TABLE `provincias` ENABLE KEYS */;

-- Volcando estructura para tabla cinealdia.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `nombreuser` varchar(100) NOT NULL,
  `correo` varchar(100) DEFAULT NULL,
  `provincia` varchar(100) DEFAULT NULL,
  `fechanac` varchar(100) DEFAULT NULL,
  `contraseña` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`nombreuser`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Volcando datos para la tabla cinealdia.usuarios: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`nombreuser`, `correo`, `provincia`, `fechanac`, `contraseña`) VALUES
	('Taproon', 'nstm_worship@hotmail.com', 'Huelva', '05/04/2021 13:06:08', '1234');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
