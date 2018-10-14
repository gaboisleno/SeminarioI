-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: semifutbol
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `equipos`
--

DROP TABLE IF EXISTS `equipos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `equipos` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(30) NOT NULL,
  `LIGA` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `NOMBRE_UNIQUE` (`NOMBRE`),
  KEY `FK_LIGA_idx` (`LIGA`),
  KEY `FK_LIGUE_idx` (`LIGA`),
  CONSTRAINT `FK_LIGUE` FOREIGN KEY (`LIGA`) REFERENCES `ligas` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipos`
--

LOCK TABLES `equipos` WRITE;
/*!40000 ALTER TABLE `equipos` DISABLE KEYS */;
INSERT INTO `equipos` VALUES (1,'River Plate',1),(13,'Rosario Central',1),(14,'Newell\'s',1),(15,'Boca Juniors',1),(16,'Gimnasia',1),(17,'Aldosivi',1),(18,'Belgrano',1),(19,'Lanús',1),(20,'Independiente',1),(21,'Defensa y Justicia',1),(22,'Huracan',1),(23,'Argentinos Jrs',1),(24,'San Martin de Tucuman',1),(25,'Godoy Cruz',1),(26,'San Martin',1),(27,'Velez',1),(31,'Talleres',1),(32,'Estudiantes',1),(34,'Racing',1),(35,'Colón',1),(37,'Atlético Tucumán',1),(38,'Argentina',1),(39,'Irak',1),(40,'Unión',1),(41,'Tigre',1),(42,'Patronato',1);
/*!40000 ALTER TABLE `equipos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ligas`
--

DROP TABLE IF EXISTS `ligas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ligas` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(30) NOT NULL,
  `CAMPEON_ACTUAL` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `NOMBRE` (`NOMBRE`),
  KEY `FK_EQUIPO_idx` (`CAMPEON_ACTUAL`),
  CONSTRAINT `FK_EQUIPO` FOREIGN KEY (`CAMPEON_ACTUAL`) REFERENCES `equipos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ligas`
--

LOCK TABLES `ligas` WRITE;
/*!40000 ALTER TABLE `ligas` DISABLE KEYS */;
INSERT INTO `ligas` VALUES (1,'Superliga Argentina',NULL),(2,'Copa Argentina',NULL),(13,'Amistoso Internacional',NULL),(14,'Seleccion Nacional',NULL);
/*!40000 ALTER TABLE `ligas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partidos`
--

DROP TABLE IF EXISTS `partidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `partidos` (
  `FECHA` date NOT NULL,
  `HORARIO` time DEFAULT NULL,
  `LOCAL` int(11) NOT NULL,
  `VISITANTE` int(11) NOT NULL,
  `GOL_LOCAL` int(11) DEFAULT NULL,
  `GOL_VISITANTE` int(11) DEFAULT NULL,
  `LIGA` int(11) DEFAULT NULL,
  PRIMARY KEY (`FECHA`,`LOCAL`,`VISITANTE`),
  KEY `FK_LOCAL_idx` (`LOCAL`),
  KEY `FK_VISITANTE_idx` (`VISITANTE`),
  KEY `FK_LIGA_idx` (`LIGA`),
  CONSTRAINT `FK_LIGA` FOREIGN KEY (`LIGA`) REFERENCES `ligas` (`id`),
  CONSTRAINT `FK_LOCAL` FOREIGN KEY (`LOCAL`) REFERENCES `equipos` (`id`),
  CONSTRAINT `FK_VISITANTE` FOREIGN KEY (`VISITANTE`) REFERENCES `equipos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci ROW_FORMAT=DYNAMIC;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidos`
--

LOCK TABLES `partidos` WRITE;
/*!40000 ALTER TABLE `partidos` DISABLE KEYS */;
INSERT INTO `partidos` VALUES ('2018-09-23','15:30:00',15,1,0,2,1),('2018-09-23',NULL,16,13,1,1,1),('2018-09-24',NULL,17,18,2,0,1),('2018-09-28',NULL,19,1,0,0,1),('2018-10-06',NULL,17,24,0,0,1),('2018-10-07','15:00:00',13,40,0,4,1),('2018-10-07','13:15:00',37,19,0,0,1),('2018-10-08','19:00:00',41,32,1,0,1),('2018-10-19','19:00:00',21,31,0,0,1),('2018-10-19','19:00:00',27,16,0,0,1),('2018-10-19','21:15:00',35,1,0,0,1),('2018-10-20','20:00:00',14,41,0,0,1),('2018-10-20','17:45:00',15,13,0,0,1),('2018-10-20','15:30:00',19,42,0,0,1),('2018-10-20','13:15:00',25,17,0,0,1);
/*!40000 ALTER TABLE `partidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `partidos_ayer`
--

DROP TABLE IF EXISTS `partidos_ayer`;
/*!50001 DROP VIEW IF EXISTS `partidos_ayer`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `partidos_ayer` AS SELECT 
 1 AS `FECHA`,
 1 AS `LOCAL`,
 1 AS `L`,
 1 AS `VISITANTE`,
 1 AS `V`,
 1 AS `LIGA`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `partidos_hoy`
--

DROP TABLE IF EXISTS `partidos_hoy`;
/*!50001 DROP VIEW IF EXISTS `partidos_hoy`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `partidos_hoy` AS SELECT 
 1 AS `FECHA`,
 1 AS `LOCAL`,
 1 AS `L`,
 1 AS `VISITANTE`,
 1 AS `V`,
 1 AS `LIGA`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `partidos_todos`
--

DROP TABLE IF EXISTS `partidos_todos`;
/*!50001 DROP VIEW IF EXISTS `partidos_todos`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `partidos_todos` AS SELECT 
 1 AS `FECHA`,
 1 AS `HORARIO`,
 1 AS `LOCAL`,
 1 AS `L`,
 1 AS `VISITANTE`,
 1 AS `V`,
 1 AS `LIGA`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuarios` (
  `USUARIO` char(30) NOT NULL,
  `PASSWRD` char(30) NOT NULL,
  `ROL` char(10) NOT NULL DEFAULT 'USER',
  `ID_USR` int(11) NOT NULL AUTO_INCREMENT,
  `E_MAIL` varchar(45) NOT NULL,
  PRIMARY KEY (`ID_USR`),
  UNIQUE KEY `USUARIO_UNIQUE` (`USUARIO`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES ('GABRIEL','123','USR',1,'ISLENO.GABRIEL@GMAIL.COM'),('admin','admin','ADMIN',6,'admin@admin.com'),('gabomastr','rosario12','USR',12,'gabomastr@yahoo.com'),('','','USR',13,'');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `partidos_ayer`
--

/*!50001 DROP VIEW IF EXISTS `partidos_ayer`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `partidos_ayer` AS select date_format(`p`.`FECHA`,'%d/%m/%Y') AS `FECHA`,`e`.`NOMBRE` AS `LOCAL`,`p`.`GOL_LOCAL` AS `L`,`e2`.`NOMBRE` AS `VISITANTE`,`p`.`GOL_VISITANTE` AS `V`,`l`.`NOMBRE` AS `LIGA` from (((`partidos` `p` join `equipos` `e` on((`p`.`LOCAL` = `e`.`ID`))) join `equipos` `e2` on((`p`.`VISITANTE` = `e2`.`ID`))) join `ligas` `l` on((`p`.`LIGA` = `l`.`ID`))) where (`p`.`FECHA` = (curdate() - interval 1 day)) order by `p`.`FECHA` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `partidos_hoy`
--

/*!50001 DROP VIEW IF EXISTS `partidos_hoy`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `partidos_hoy` AS select date_format(`p`.`FECHA`,'%d/%m/%Y') AS `FECHA`,`e`.`NOMBRE` AS `LOCAL`,`p`.`GOL_LOCAL` AS `L`,`e2`.`NOMBRE` AS `VISITANTE`,`p`.`GOL_VISITANTE` AS `V`,`l`.`NOMBRE` AS `LIGA` from (((`partidos` `p` join `equipos` `e` on((`p`.`LOCAL` = `e`.`ID`))) join `equipos` `e2` on((`p`.`VISITANTE` = `e2`.`ID`))) join `ligas` `l` on((`p`.`LIGA` = `l`.`ID`))) where (`p`.`FECHA` = curdate()) order by `p`.`FECHA` desc */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `partidos_todos`
--

/*!50001 DROP VIEW IF EXISTS `partidos_todos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `partidos_todos` AS select date_format(`p`.`FECHA`,'%d/%m/%Y') AS `FECHA`,`p`.`HORARIO` AS `HORARIO`,`e`.`NOMBRE` AS `LOCAL`,`p`.`GOL_LOCAL` AS `L`,`e2`.`NOMBRE` AS `VISITANTE`,`p`.`GOL_VISITANTE` AS `V`,`l`.`NOMBRE` AS `LIGA` from (((`partidos` `p` join `equipos` `e` on((`p`.`LOCAL` = `e`.`ID`))) join `equipos` `e2` on((`p`.`VISITANTE` = `e2`.`ID`))) join `ligas` `l` on((`p`.`LIGA` = `l`.`ID`))) order by `p`.`FECHA` desc */;
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

-- Dump completed on 2018-10-14 19:07:19
