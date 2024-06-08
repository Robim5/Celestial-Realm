-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: trackeranime
-- ------------------------------------------------------
-- Server version	8.0.35

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
-- Table structure for table `lista`
--

DROP TABLE IF EXISTS `lista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lista` (
  `id_lista` int NOT NULL AUTO_INCREMENT,
  `user_id` int DEFAULT NULL,
  `anime_id` int DEFAULT NULL,
  `favoritos` varchar(255) DEFAULT NULL,
  `anime_aver` varchar(255) DEFAULT NULL,
  `anime_completos` varchar(255) DEFAULT NULL,
  `anime_pausa` varchar(255) DEFAULT NULL,
  `anime_dropados` varchar(255) DEFAULT NULL,
  `anime_paraassistir` varchar(255) DEFAULT NULL,
  `genero` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_lista`),
  KEY `id_user_idx` (`user_id`),
  KEY `id_anime_idx` (`anime_id`),
  CONSTRAINT `id_anime` FOREIGN KEY (`anime_id`) REFERENCES `animes` (`id_anime`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `id_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`id_user`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lista`
--

LOCK TABLES `lista` WRITE;
/*!40000 ALTER TABLE `lista` DISABLE KEYS */;
INSERT INTO `lista` VALUES (3,3,NULL,NULL,NULL,NULL,NULL,NULL,'Sword Art Online','Ação, Aventura, Romance'),(25,3,NULL,'Demon Slayer',NULL,NULL,NULL,NULL,NULL,NULL),(26,3,NULL,'Death Note',NULL,NULL,NULL,NULL,NULL,NULL),(38,15,NULL,'Fullmetal Alchemist: Brotherhood',NULL,NULL,NULL,NULL,NULL,NULL),(39,15,NULL,'Attack on Titan',NULL,NULL,NULL,NULL,NULL,NULL),(40,15,NULL,'Hunter x Hunter',NULL,NULL,NULL,NULL,NULL,NULL),(42,16,NULL,'Fullmetal Alchemist: Brotherhood',NULL,NULL,NULL,NULL,NULL,NULL),(43,16,NULL,'Vinland Saga',NULL,NULL,NULL,NULL,NULL,NULL),(51,3,NULL,NULL,NULL,NULL,NULL,'My Youth Romantic Comedy Is Wrong, As I Expected',NULL,'Ação, Aventura, Drama'),(52,3,NULL,NULL,NULL,NULL,'Re:Zero - Starting Life in Another World',NULL,NULL,'Ação, Sobrenatural, Shounen'),(54,18,NULL,'One Piece',NULL,NULL,NULL,NULL,NULL,NULL),(56,18,NULL,'Attack on Titan',NULL,NULL,NULL,NULL,NULL,NULL),(59,19,NULL,'Attack on Titan',NULL,NULL,NULL,NULL,NULL,NULL),(60,19,NULL,'Fullmetal Alchemist: Brotherhood',NULL,NULL,NULL,NULL,NULL,NULL),(62,19,NULL,NULL,NULL,'Fullmetal Alchemist: Brotherhood',NULL,NULL,NULL,'Ação, Aventura, Drama'),(65,19,NULL,NULL,NULL,NULL,'Hunter x Hunter',NULL,NULL,'Ação, Aventura, Fantasia'),(67,19,NULL,NULL,NULL,'Vinland Saga',NULL,NULL,NULL,'Ação, Demônios, Histórico');
/*!40000 ALTER TABLE `lista` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-29 15:24:56
