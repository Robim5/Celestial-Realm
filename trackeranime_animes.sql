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
-- Table structure for table `animes`
--

DROP TABLE IF EXISTS `animes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `animes` (
  `id_anime` int NOT NULL,
  `titulo` varchar(100) NOT NULL,
  `genero` varchar(50) DEFAULT NULL,
  `sinopse` text,
  `episodes` double DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  `temporadas` int DEFAULT NULL,
  `avaliação` decimal(3,2) DEFAULT NULL,
  PRIMARY KEY (`id_anime`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `animes`
--

LOCK TABLES `animes` WRITE;
/*!40000 ALTER TABLE `animes` DISABLE KEYS */;
INSERT INTO `animes` VALUES (1,'Naruto','Ação, Aventura, Fantasia','Naruto Uzumaki, um jovem ninja com o sonho de se tornar o Hokage, líder da Vila da Folha, embarca em uma jornada para provar seu valor e proteger seus amigos.',220,'Concluído',5,4.50),(2,'One Piece','Ação, Aventura, Comédia','Monkey D. Luffy, um jovem com o poder da fruta do diabo que o transformou em um homem-borracha, parte em uma jornada para se tornar o Rei dos Piratas e encontrar o lendário tesouro, One Piece.',1000,'Em andamento',20,4.80),(3,'Attack on Titan','Ação, Drama, Fantasia','Eren Yeager se une à Tropa de Exploração para combater os Titãs, criaturas gigantes que ameaçam a sobrevivência da humanidade em um mundo murado. Uma história de ação e mistério.',75,'Concluído',4,4.90),(4,'My Hero Academia','Ação, Superpoder, Escolar','Em um mundo onde quase todos têm superpoderes, Izuku Midoriya luta para se tornar o maior herói, apesar de nascer sem poderes. Uma história de superação e heroísmo.',113,'Em andamento',6,4.70),(5,'Demon Slayer','Ação, Demônios, Histórico','Tanjiro Kamado embarca em uma jornada para vingar sua família e salvar sua irmã Nezuko, transformada em um demônio. Uma história de ação e determinação.',55,'Concluído',3,4.90),(6,'Death Note','Mistério, Psicológico, Sobrenatural','Light Yagami encontra um caderno que lhe dá o poder de matar qualquer pessoa. Ele decide usar esse poder para criar um mundo sem criminosos. Uma história de suspense e moralidade.',37,'Concluído',1,4.80),(7,'Fullmetal Alchemist: Brotherhood','Ação, Aventura, Drama','Os irmãos Alphonse e Edward Elric buscam a Pedra Filosofal para recuperar seus corpos após uma alquimia mal sucedida. Uma história de redenção e sacrifício.',64,'Concluído',5,4.90),(8,'Sword Art Online','Ação, Aventura, Romance','Jogadores ficam presos em um jogo de realidade virtual, e Kirito luta pela sobrevivência e para liberar os jogadores. Uma história de aventura e romance virtual.',96,'Em andamento',4,4.60),(9,'Hunter x Hunter','Ação, Aventura, Fantasia','Gon Freecss busca se tornar um caçador para encontrar seu pai e descobrir os mistérios do mundo. Uma história de aventura e amizade.',148,'Concluído',6,4.90),(10,'One Punch Man','Ação, Comédia, Superpoder','Saitama, um herói entediado, derrota todos os inimigos com um único soco. Uma história de comédia e ação superpoderosa.',24,'Em andamento',2,4.70),(11,'Cowboy Bebop','Ação, Aventura, Drama','Spike Spiegel e sua equipe de caçadores de recompensas viajam pelo espaço em busca de criminosos. Uma história de ação e jazz espacial.',26,'Concluído',1,4.80),(12,'Black Clover','Ação, Magia, Fantasia','Asta, um jovem sem magia em um mundo onde todos têm poderes mágicos, busca se tornar o Rei Mago. Uma história de superação e magia.',170,'Em andamento',5,4.60),(13,'Haikyuu!!','Desporto, Comédia, Drama','Shoyo Hinata, um entusiasta do vôlei, se junta à equipe da escola para superar adversários talentosos. Uma história emocionante de esportes e amizade.',85,'Concluído',4,4.90),(14,'Tokyo Ghoul','Ação, Horror, Psicológico','Kaneki Ken, após um encontro fatal, se torna meio ghoul e meio humano. Uma história sombria de sobrevivência e identidade.',24,'Concluído',2,4.70),(15,'The Promised Neverland','Mistério, Thriller, Sobrenatural','Emma, Norman e Ray descobrem a terrível verdade por trás do orfanato em que vivem. Uma história de suspense e fuga.',23,'Concluído',2,4.80),(16,'Fruits Basket','Comédia, Drama, Romance','Tohru Honda descobre que a família Soma é amaldiçoada a se transformar em animais do zodíaco chinês. Uma história de amor e aceitação.',63,'Concluído',3,4.90),(17,'Re:Zero - Starting Life in Another World','Ação, Sobrenatural, Shounen','Subaru Natsuki, transportado para um mundo de fantasia, descobre a habilidade de retornar à vida após a morte. Uma história de aventura e resiliência.',36,'Concluído',3,4.80),(18,'My Youth Romantic Comedy Is Wrong, As I Expected','Ação, Aventura, Drama','Hachiman Hikigaya, um estudante cínico, é forçado a se juntar ao Clube de Serviço Voluntário. Uma história de amadurecimento e relacionamentos.',26,'Concluído',3,4.70),(19,'Fire Force','Ação, Comédia, Sobrenatural','Shinra Kusakabe se junta à Special Fire Force para combater combustões humanas espontâneas. Uma história de ação e mistério sobrenatural.',48,'Em andamento',2,4.80),(20,'Vinland Saga','Ação, Demônios, Histórico','Thorfinn busca vingança pela morte de seu pai em uma narrativa épica sobre a era viking. Uma história de guerra e redenção.',24,'Concluído',1,4.90);
/*!40000 ALTER TABLE `animes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-29 15:24:55
