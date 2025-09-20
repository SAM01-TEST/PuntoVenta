CREATE DATABASE  IF NOT EXISTS `puntoventa` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `puntoventa`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: puntoventa
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categoria`
--

DROP TABLE IF EXISTS `categoria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categoria` (
  `idCategoria` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(255) NOT NULL,
  PRIMARY KEY (`idCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categoria`
--

LOCK TABLES `categoria` WRITE;
/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` VALUES (1,'Abrasivos'),(2,'Accesorios Audio y Video'),(3,'Artículos Perro'),(4,'Artículos Tienda'),(5,'Cerrajería'),(6,'Construcción'),(7,'Eléctrico'),(8,'Empaques'),(9,'Ferretería'),(10,'Grifería'),(11,'Herramienta'),(12,'Jarciería'),(13,'Jardinería'),(14,'Neumático'),(15,'Papelería'),(16,'Plomería'),(17,'Refacciones'),(18,'Seguridad'),(19,'Tornillería'),(20,'Adhesivos y Selladores'),(21,'Pinturas y Recubrimientos'),(22,'Material de Fijación'),(23,'Automotriz'),(24,'Iluminación'),(25,'Corte y Desbaste'),(26,'Estructuras Metálicas'),(27,'Fontanería'),(28,'Equipos de Protección Personal'),(29,'Sistemas de Riego');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(255) NOT NULL,
  `Apellidos` varchar(255) DEFAULT NULL,
  `TelefonoContacto` varchar(15) DEFAULT NULL,
  `Direccion` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compra`
--

DROP TABLE IF EXISTS `compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compra` (
  `idCompra` int NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `idProveedor` int NOT NULL,
  `Monto` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idCompra`),
  KEY `idProveedor` (`idProveedor`),
  CONSTRAINT `compra_ibfk_1` FOREIGN KEY (`idProveedor`) REFERENCES `proveedor` (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compra`
--

LOCK TABLES `compra` WRITE;
/*!40000 ALTER TABLE `compra` DISABLE KEYS */;
/*!40000 ALTER TABLE `compra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallecompra`
--

DROP TABLE IF EXISTS `detallecompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallecompra` (
  `idDetalleCompra` int NOT NULL AUTO_INCREMENT,
  `idCompra` int NOT NULL,
  `idProducto` int NOT NULL,
  `Cantidad` int NOT NULL,
  `PrecioCompra` decimal(10,2) NOT NULL,
  `Importe` decimal(10,2) GENERATED ALWAYS AS ((`Cantidad` * `PrecioCompra`)) STORED,
  PRIMARY KEY (`idDetalleCompra`),
  KEY `idCompra` (`idCompra`),
  KEY `idProducto` (`idProducto`),
  CONSTRAINT `detallecompra_ibfk_1` FOREIGN KEY (`idCompra`) REFERENCES `compra` (`idCompra`),
  CONSTRAINT `detallecompra_ibfk_2` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallecompra`
--

LOCK TABLES `detallecompra` WRITE;
/*!40000 ALTER TABLE `detallecompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `detallecompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleventa`
--

DROP TABLE IF EXISTS `detalleventa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalleventa` (
  `idDetalleVenta` int NOT NULL AUTO_INCREMENT,
  `idVenta` int NOT NULL,
  `idProducto` int NOT NULL,
  `Cantidad` int NOT NULL,
  `PrecioVenta` decimal(10,2) NOT NULL,
  `Importe` decimal(10,2) GENERATED ALWAYS AS ((`Cantidad` * `PrecioVenta`)) STORED,
  PRIMARY KEY (`idDetalleVenta`),
  KEY `idVenta` (`idVenta`),
  KEY `idProducto` (`idProducto`),
  CONSTRAINT `detalleventa_ibfk_1` FOREIGN KEY (`idVenta`) REFERENCES `venta` (`idVenta`),
  CONSTRAINT `detalleventa_ibfk_2` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`idProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventa`
--

LOCK TABLES `detalleventa` WRITE;
/*!40000 ALTER TABLE `detalleventa` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalleventa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `idProducto` int NOT NULL AUTO_INCREMENT,
  `CodigoBarras` varchar(255) DEFAULT NULL,
  `idCategoria` int NOT NULL,
  `idTipoProducto` int NOT NULL,
  `Marca` varchar(255) DEFAULT NULL,
  `StockCritico` int DEFAULT '0',
  `Stock` int DEFAULT '0',
  `Codigo` varchar(50) DEFAULT NULL,
  `Clave` varchar(50) DEFAULT NULL,
  `Descripcion` text,
  `PrecioCompraSinIVA` decimal(10,2) NOT NULL,
  `PrecioCompraConIVA` decimal(10,2) GENERATED ALWAYS AS ((`PrecioCompraSinIVA` * 1.16)) STORED,
  `PrecioVentaSinIVA` decimal(10,2) NOT NULL,
  `PrecioVentaConIVA` decimal(10,2) GENERATED ALWAYS AS ((`PrecioVentaSinIVA` * 1.16)) STORED,
  `idUnidad` int NOT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `idCategoria` (`idCategoria`),
  KEY `idTipoProducto` (`idTipoProducto`),
  KEY `idUnidad` (`idUnidad`),
  CONSTRAINT `producto_ibfk_2` FOREIGN KEY (`idCategoria`) REFERENCES `categoria` (`idCategoria`),
  CONSTRAINT `producto_ibfk_3` FOREIGN KEY (`idTipoProducto`) REFERENCES `tipoproducto` (`idTipoProducto`),
  CONSTRAINT `producto_ibfk_4` FOREIGN KEY (`idUnidad`) REFERENCES `unidad` (`idUnidad`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` (`idProducto`, `CodigoBarras`, `idCategoria`, `idTipoProducto`, `Marca`, `StockCritico`, `Stock`, `Codigo`, `Clave`, `Descripcion`, `PrecioCompraSinIVA`, `PrecioVentaSinIVA`, `idUnidad`) VALUES (3,'7501206643181',11,224,'PRETUL',1,10,'22614','','pinza de punta y corte',40.00,60.00,5),(4,'7501206685150',19,282,'FIERO',3,3,'44339','PIJ-638','Pija de acero pavonado Multiusos #6 * 1 1/2',18.97,30.17,6),(5,'7501206685150',19,282,'FIERO',3,3,'44339','PIJ-638','Pija de acero pavonado Multiusos #6 * 1 1/2, PIEZA',0.18,0.43,5);
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `idProveedor` int NOT NULL AUTO_INCREMENT,
  `Telefono1` varchar(15) NOT NULL,
  `Telefono2` varchar(15) DEFAULT NULL,
  `RazonSocial` varchar(255) NOT NULL,
  `TipoProveedor` varchar(255) DEFAULT NULL,
  `Contacto` varchar(255) DEFAULT NULL,
  `TelefonoContacto` varchar(15) DEFAULT NULL,
  `Direccion` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `SitioWeb` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoproducto`
--

DROP TABLE IF EXISTS `tipoproducto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipoproducto` (
  `idTipoProducto` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(255) NOT NULL,
  PRIMARY KEY (`idTipoProducto`)
) ENGINE=InnoDB AUTO_INCREMENT=290 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoproducto`
--

LOCK TABLES `tipoproducto` WRITE;
/*!40000 ALTER TABLE `tipoproducto` DISABLE KEYS */;
INSERT INTO `tipoproducto` VALUES (1,'Abrasivo'),(2,'Abrazadera'),(3,'Accesorio'),(4,'Accesorio eléctrico'),(5,'Accesorio de plomería'),(6,'Accesorio para baño'),(7,'Accesorio para tinaco'),(8,'Aceite'),(9,'Acople de reparación'),(10,'Adhesivo'),(11,'Aislante'),(12,'Alambre'),(13,'Aldaba'),(14,'Amarrador'),(15,'Antena'),(16,'Antigrasa'),(17,'Apagador'),(18,'Apagador escalera'),(19,'Arco'),(20,'Artículo de limpieza'),(21,'Aspersor'),(22,'Aspiradora'),(23,'Atomizador'),(24,'Automotriz'),(25,'Azadón'),(26,'Balón'),(27,'Bandeja'),(28,'Barniz'),(29,'Barreta'),(30,'Báscula'),(31,'Base boiler'),(32,'Base medidor'),(33,'Bastón'),(34,'Bicolor'),(35,'Bisagra'),(36,'Bolsa'),(37,'Bomba'),(38,'Bomba WC'),(39,'Bozal'),(40,'Bote hexagonal'),(41,'Bote integral'),(42,'Bote spot'),(43,'Botón timbre'),(44,'Broca'),(45,'Broquero'),(46,'Cable'),(47,'Cabo'),(48,'Cadena'),(49,'Caja'),(50,'Caja de seguridad'),(51,'Calentador'),(52,'Calibrador'),(53,'Calzado'),(54,'Campana'),(55,'Canaleta'),(56,'Candado'),(57,'Carbón'),(58,'Careta'),(59,'Cargador'),(60,'Carretilla'),(61,'Catálogo'),(62,'Cautín'),(63,'Cemento'),(64,'Centro de carga'),(65,'Cepillo'),(66,'Cepillo eléctrico'),(67,'Cerrojo'),(68,'Céspol'),(69,'Chalupa'),(70,'Chapopote'),(71,'Chiflón'),(72,'Cilindro'),(73,'Cincel'),(74,'Cinta'),(75,'Clavadora'),(76,'Clavera'),(77,'Clavija'),(78,'Clavillo'),(79,'Clavo'),(80,'Codo'),(81,'Coladera'),(82,'Colgador'),(83,'Collar'),(84,'Comal'),(85,'Conector'),(86,'Conector varilla'),(87,'Conexión'),(88,'Contacto'),(89,'Contacto dúplex'),(90,'Contacto triple'),(91,'Contacto y apagador'),(92,'Contacto y escalera'),(93,'Contracanasta'),(94,'Control de fauna'),(95,'Control de plagas'),(96,'Cople'),(97,'Correa'),(98,'Corta vidrio'),(99,'Cortador'),(100,'Cortador tubo'),(101,'Crayón'),(102,'Cubeta'),(103,'Cubrebocas'),(104,'Cuchara'),(105,'Cuchilla'),(106,'Cuña'),(107,'Cutter'),(108,'Dado'),(109,'Desarmador'),(110,'Desbrozadora'),(111,'Desodorante'),(112,'Destapacaños'),(113,'Destornillador'),(114,'Diamante'),(115,'Disco'),(116,'Divisor coaxial'),(117,'Eléctrico'),(118,'Embudo'),(119,'Empaque'),(120,'Encendedor'),(121,'Engrapadora'),(122,'Escalera'),(123,'Escobeta'),(124,'Escoba'),(125,'Escuadra carpintero'),(126,'Esmeriladora'),(127,'Espátula'),(128,'Esponja'),(129,'Espuma de poliuretano'),(130,'Estopa'),(131,'Estufa'),(132,'Exprimidor'),(133,'Extensión'),(134,'Extensión eléctrica'),(135,'Extractor'),(136,'Faja'),(137,'Fibra'),(138,'Flexómetro'),(139,'Flotador'),(140,'Foco'),(141,'Formón'),(142,'Fotocelda'),(143,'Franela'),(144,'Fregón'),(145,'Fusible'),(146,'Gancho'),(147,'Gaveta'),(148,'Grapa'),(149,'Grasa'),(150,'Grifa'),(151,'Grifería'),(152,'Guante'),(153,'Guía'),(154,'Hacha'),(155,'Herraje'),(156,'Herramienta'),(157,'Hidrolavadora'),(158,'Hilo'),(159,'Hoz'),(160,'Impermeabilizante'),(161,'Insecticida'),(162,'Interruptor'),(163,'Interruptor contacto'),(164,'Inversor'),(165,'Jabonera'),(166,'Jalador'),(167,'Jarciería'),(168,'Jardinería'),(169,'Jerga'),(170,'Juego de pinzas'),(171,'Lámina'),(172,'Lámpara'),(173,'Lazo'),(174,'Lentes'),(175,'Lijadora'),(176,'Lima'),(177,'Limpiador'),(178,'Linterna'),(179,'Listón'),(180,'Llana'),(181,'Llave'),(182,'Lona'),(183,'Maceta'),(184,'Machete'),(185,'Malla'),(186,'Maneral'),(187,'Mango'),(188,'Manguera'),(189,'Manta'),(190,'Marro'),(191,'Martillo'),(192,'Matamoscas'),(193,'Mazo'),(194,'Mechudo'),(195,'Mensula'),(196,'Mezcladora'),(197,'Mini arco'),(198,'Monomando'),(199,'Mop'),(200,'Mufa'),(201,'Multiconector'),(202,'Multicontacto'),(203,'Multímetro'),(204,'Niple'),(205,'Nivel'),(206,'Organizador'),(207,'Overol'),(208,'Pala'),(209,'Parche'),(210,'Parrilla'),(211,'Pasador'),(212,'Pasta'),(213,'Pastilla'),(214,'Pata de cabra'),(215,'Pechera'),(216,'Pegamento'),(217,'Pelador'),(218,'Pelota'),(219,'Perico'),(220,'Pichancha'),(221,'Picoleta'),(222,'Pila'),(223,'Pintura'),(224,'Pinza'),(225,'Piola'),(226,'Pisón'),(227,'Pistola'),(228,'Placa'),(229,'Plumero'),(230,'Poliducto'),(231,'Portalámpara'),(232,'Prensa'),(233,'Probador'),(234,'Pulidor'),(235,'Punta'),(236,'Punzon'),(237,'Rafia'),(238,'Rastrillo'),(239,'Ratonera'),(240,'Recogedor'),(241,'Reducción bushing'),(242,'Refacción'),(243,'Regadera'),(244,'Registro'),(245,'Rejilla'),(246,'Remachadora'),(247,'Removedor'),(248,'Resbalón'),(249,'Resistencia'),(250,'Rodaja'),(251,'Rotomartillo'),(252,'Router'),(253,'Sacate'),(254,'Sellador'),(255,'Separador'),(256,'Serrote'),(257,'Sierra circular'),(258,'Silicón'),(259,'Soldadura'),(260,'Solvente'),(261,'Soplador'),(262,'Soplete'),(263,'Soporte'),(264,'Soquet'),(265,'Sosa'),(266,'Stilson'),(267,'Super resina'),(268,'Tachuela'),(269,'Talacho'),(270,'Tapa'),(271,'Tapete'),(272,'Tapón'),(273,'Taquete'),(274,'Tarja'),(275,'Tensor'),(276,'Terminal'),(277,'Tierra'),(278,'Tijera'),(279,'Timbre'),(280,'Tinaco'),(281,'Tiralíneas'),(282,'Tornillería'),(283,'Trapo'),(284,'Tubo'),(285,'Válvula'),(286,'Varilla'),(287,'Veneno'),(288,'Volteador'),(289,'Zapapico');
/*!40000 ALTER TABLE `tipoproducto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidad`
--

DROP TABLE IF EXISTS `unidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unidad` (
  `idUnidad` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`idUnidad`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidad`
--

LOCK TABLES `unidad` WRITE;
/*!40000 ALTER TABLE `unidad` DISABLE KEYS */;
INSERT INTO `unidad` VALUES (1,'Kilogramos'),(2,'Gramos'),(3,'Litros'),(4,'Mililitros'),(5,'Pieza'),(6,'Bolsa'),(7,'Paquete'),(8,'Metro'),(9,'Centímetro'),(10,'Caja');
/*!40000 ALTER TABLE `unidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `idVenta` int NOT NULL AUTO_INCREMENT,
  `Fecha` date NOT NULL,
  `idCliente` int DEFAULT NULL,
  `Monto` decimal(10,2) NOT NULL,
  `tipoPago` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idVenta`),
  KEY `idCliente` (`idCliente`),
  CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vistacompras`
--

DROP TABLE IF EXISTS `vistacompras`;
/*!50001 DROP VIEW IF EXISTS `vistacompras`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vistacompras` AS SELECT 
 1 AS `idCompra`,
 1 AS `Fecha`,
 1 AS `Descripcion`,
 1 AS `Cantidad`,
 1 AS `PrecioCompra`,
 1 AS `Importe`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vistaproductos`
--

DROP TABLE IF EXISTS `vistaproductos`;
/*!50001 DROP VIEW IF EXISTS `vistaproductos`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vistaproductos` AS SELECT 
 1 AS `idProducto`,
 1 AS `CodigoBarras`,
 1 AS `Codigo`,
 1 AS `Descripcion`,
 1 AS `PrecioVenta`,
 1 AS `PrecioCompra`,
 1 AS `Stock`,
 1 AS `StockCritico`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `vistaventas`
--

DROP TABLE IF EXISTS `vistaventas`;
/*!50001 DROP VIEW IF EXISTS `vistaventas`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vistaventas` AS SELECT 
 1 AS `idVenta`,
 1 AS `Fecha`,
 1 AS `Descripcion`,
 1 AS `Cantidad`,
 1 AS `PrecioVenta`,
 1 AS `Importe`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vistacompras`
--

/*!50001 DROP VIEW IF EXISTS `vistacompras`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vistacompras` AS select `dc`.`idCompra` AS `idCompra`,`c`.`Fecha` AS `Fecha`,`p`.`Descripcion` AS `Descripcion`,`dc`.`Cantidad` AS `Cantidad`,`dc`.`PrecioCompra` AS `PrecioCompra`,`dc`.`Importe` AS `Importe` from ((`detallecompra` `dc` join `producto` `p` on((`dc`.`idProducto` = `p`.`idProducto`))) join `compra` `c` on((`dc`.`idCompra` = `c`.`idCompra`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vistaproductos`
--

/*!50001 DROP VIEW IF EXISTS `vistaproductos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vistaproductos` AS select `p`.`idProducto` AS `idProducto`,`p`.`CodigoBarras` AS `CodigoBarras`,`p`.`Codigo` AS `Codigo`,`p`.`Descripcion` AS `Descripcion`,`p`.`PrecioVentaConIVA` AS `PrecioVenta`,`p`.`PrecioCompraConIVA` AS `PrecioCompra`,`p`.`Stock` AS `Stock`,`p`.`StockCritico` AS `StockCritico` from `producto` `p` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vistaventas`
--

/*!50001 DROP VIEW IF EXISTS `vistaventas`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vistaventas` AS select `dv`.`idVenta` AS `idVenta`,`v`.`Fecha` AS `Fecha`,`p`.`Descripcion` AS `Descripcion`,`dv`.`Cantidad` AS `Cantidad`,`dv`.`PrecioVenta` AS `PrecioVenta`,`dv`.`Importe` AS `Importe` from ((`detalleventa` `dv` join `producto` `p` on((`dv`.`idProducto` = `p`.`idProducto`))) join `venta` `v` on((`dv`.`idVenta` = `v`.`idVenta`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-19 11:20:13
