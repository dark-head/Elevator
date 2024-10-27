-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: elevator
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `elevator_log`
--

DROP TABLE IF EXISTS `elevator_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `elevator_log` (
  `id` int NOT NULL AUTO_INCREMENT,
  `task` varchar(45) DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `elevator_log`
--

LOCK TABLES `elevator_log` WRITE;
/*!40000 ALTER TABLE `elevator_log` DISABLE KEYS */;
INSERT INTO `elevator_log` VALUES (1,'close',NULL),(12,'close','2023-11-04 16:31:49'),(23,'close','2023-11-04 16:35:10'),(24,'close','2023-11-04 16:40:40'),(25,'close','2023-11-04 16:40:43'),(26,'close','2023-11-04 16:42:02'),(27,'close','2023-11-04 17:11:31'),(28,'close','2023-11-04 17:11:34'),(29,'close','2023-11-04 17:11:38'),(30,'close','2023-11-04 18:24:38'),(31,'close','2023-11-04 19:00:17'),(32,'close','2023-11-04 19:01:22'),(33,'close','2023-11-04 19:02:34'),(34,'close','2023-11-04 19:03:02'),(35,'close','2023-11-04 19:03:25'),(36,'close','2023-11-04 19:04:21'),(37,'close','2023-11-04 19:10:59'),(38,'close','2023-11-04 19:16:50'),(39,'close','2023-11-04 20:15:37'),(40,'close','2023-11-05 14:26:39'),(41,'close','2023-11-05 16:52:11'),(42,'close','2023-11-05 16:52:28'),(43,'close','2023-11-05 17:12:05'),(44,'close','2023-11-05 17:12:09'),(45,'close','2023-11-05 17:12:12'),(46,'close','2023-11-05 17:19:08');
/*!40000 ALTER TABLE `elevator_log` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-05 17:27:42
