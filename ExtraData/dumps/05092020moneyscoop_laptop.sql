-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: moneyscoop
-- ------------------------------------------------------
-- Server version	8.0.21

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
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `info` varchar(1023) DEFAULT NULL,
  `lastModified` timestamp NULL DEFAULT NULL,
  `addressLine1` varchar(45) DEFAULT NULL,
  `addressLine2` varchar(45) DEFAULT NULL,
  `vatNumber` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'UNKNOWN',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2,'GALENUS BVBA','Galenus BVBA','','2020-03-11 21:54:33','Heist-Goorstraat 23a','2220 Heist-op-den-Berg','BE0842.797.267','info@galenus.be',''),(3,'PIETER THYS BVBA','Pieter Thys Laswerken','','2020-03-27 10:22:03','A. Van Looplein 29','2235 Westmeerbeek','BE0678.872.613','info@pieterthys.be','0473243953'),(4,'COOLBLUE','Coolblue','','2020-03-14 14:31:57','','','','',''),(5,'PIDPA','Water in beweging','','2020-03-14 21:04:40','Desguinlei 246','2018 Antwerpen','BE0204.908.936','','080090300'),(6,'ENECO','Eneco','','2020-03-14 21:07:03','Battelsesteenweg 455i','2800 Mechelen','','','015256677'),(7,'ALTERNATE','Alternate BVBA','','2020-03-20 07:23:37','Oeyvaertsbosch 16 - 18','2630 ','Aartselaar','sales@alternate.be','038711111'),(8,'ALLEKABELS','Alle kabels','','2020-03-26 08:14:30','Kerkrade','6460 BB','NL8214.73.013.B01','www.allekabels.be','0455717001'),(9,'NONNEMANWOLFS','Psycholoog','','2020-03-26 08:47:53','Hoge Heide 3','2223 Schriek','0808.7357.18','jan@nonnemanwolfs.be',''),(10,'MULTIBUSY','Bedrijfsorganisatie','','2020-04-06 10:02:26','Guido Gezellelaan 26','2920 Kalmthout','BE0849.283.597','Lieven@multibusy.be','+32 3 666 84 27'),(11,'MOUSER','Electronics','','2020-04-06 10:41:07','','','FR 27512466913','',''),(12,'TELENET','Telenet','','2020-04-14 14:47:00','Liersesteenweg 4','2800 Mechelen','BE0473.416.418','www.telenet.be','015/66.66.66'),(13,'PARADIGIT','','','2020-04-16 16:21:45','','','','',''),(14,'PETER THYS','Peer beer','','2020-04-28 19:43:15','Putte','','123654','email','213987'),(15,'ONE.COM','Domain name site','','2020-04-29 12:57:37','Strawinskylaan 3051','1077 ZX Amsterdam','SE559205240001','sales@one.com',''),(16,'EUROCIRCTUIS','PCB Manufacturer','','2020-05-07 15:45:28','Antwerpsesteenweg 66 ','2800 Mechelen','BE0 444 188 140 ','euro@eurocircuits.com','+3215281630'),(17,'BOEKHOUDER','Accountants en Belastingsconsulenten','','2020-05-02 14:34:42','','','','',''),(18,'XERIUS','Sociaal verzekeringsfonds','','2020-05-15 12:57:02','Vogelzanglaan 1','2300 Turnhout','','turnhout@xerius.be','078150552');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoicelines`
--

DROP TABLE IF EXISTS `invoicelines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoicelines` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `info` varchar(1023) DEFAULT NULL,
  `lastModified` timestamp NULL DEFAULT NULL,
  `invoiceId` int DEFAULT NULL,
  `dateCreated` timestamp NULL DEFAULT NULL,
  `unitPrice` decimal(10,2) DEFAULT NULL,
  `multiplier` double DEFAULT NULL,
  `showUnitPrice` tinyint(1) DEFAULT NULL,
  `showDate` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_line_invoice_idx` (`invoiceId`),
  CONSTRAINT `fk_line_invoice` FOREIGN KEY (`invoiceId`) REFERENCES `invoices` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoicelines`
--

LOCK TABLES `invoicelines` WRITE;
/*!40000 ALTER TABLE `invoicelines` DISABLE KEYS */;
INSERT INTO `invoicelines` VALUES (1,'UNKNOWN',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(5,'WORKWATCH','Geleverde prestaties project WorkWatch tem November 2019','','2020-03-11 21:55:38',4,'2020-03-11 21:55:19',3000.00,1,0,0),(6,'LASSEN','Trappen antwerpen','','2020-03-14 20:44:43',5,'2020-03-11 21:57:43',87.50,1,1,1),(7,'LASSEN','Lassen hal','','2020-03-14 11:20:25',5,'2020-03-11 21:58:59',75.00,1,0,0),(10,'WORKWATCH','Geleverde prestaties WorkWatch december 2019','','2020-03-14 20:49:03',50,'2020-03-14 20:48:14',35.00,8,1,1),(11,'WORKWATCH','Geleverde prestaties WorkWatch Januari','','2020-03-14 20:51:29',51,'2020-03-14 20:50:04',35.00,18,1,1),(12,'WORKWATCH','Geleverde prestaties WorkWatch Febfruari','','2020-03-14 20:55:44',52,'2020-03-14 20:55:03',35.00,15,1,1),(13,'LASSEN','27/01','','2020-03-14 20:57:10',53,'2020-03-14 20:56:47',25.00,3,1,1),(14,'LASSEN','31/01','','2020-03-14 20:57:34',53,'2020-03-14 20:57:11',25.00,4,1,1),(15,'TENTPALEN','14/02','','2020-03-14 20:58:04',53,'2020-03-14 20:57:35',32.00,4,1,1),(16,'TENTPALEN','19/21','','2020-03-14 20:58:35',53,'2020-03-14 20:58:04',32.00,3.5,1,1),(19,'TERMINAL','Debug versie, Layout, Registratie dialoog','','2020-04-06 10:07:23',71,'2020-04-06 10:03:05',80.00,7.5,0,0),(20,'CONTROLE CENTER','Meerdere gebruikers','','2020-04-06 10:05:49',71,'2020-04-06 10:05:17',80.00,3,0,0),(21,'TESTISOTECH','Test Isotech Database naar live versie omzetten','','2020-04-06 10:08:34',71,'2020-04-06 10:08:01',80.00,0.5,0,0),(22,'SERVER','Registraties','','2020-04-06 10:09:47',71,'2020-04-06 10:08:45',80.00,2,0,0),(23,'TERMINAL','Bug fixes','','2020-04-26 12:54:48',76,'2020-04-26 12:52:39',80.00,11,0,0),(24,'MONITOR','Ontwikkeling','','2020-04-26 13:10:53',76,'2020-04-26 12:53:08',80.00,94.5,0,0),(25,'ISOTECH','24/04/2020','','2020-04-26 12:54:04',76,'2020-04-26 12:53:37',80.00,2,0,0),(26,'ANDERE','Meetings','','2020-04-26 12:54:28',76,'2020-04-26 12:54:07',80.00,2.5,0,0),(27,'LASSEN','10/04','','2020-04-27 07:19:48',77,'2020-04-26 12:57:47',35.00,2,0,0),(28,'PROFIEL','Profiel plaatsen','','2020-04-26 12:58:32',77,'2020-04-26 12:58:07',72.00,2,0,0),(29,'LASSEN','13/04','','2020-04-27 07:19:55',77,'2020-04-26 12:58:38',35.00,3,0,0),(30,'LASSEN','17/04','','2020-04-27 07:20:01',77,'2020-04-26 12:59:02',35.00,4,0,0),(31,'LASSEN','20/04','','2020-04-27 07:20:13',77,'2020-04-26 12:59:21',35.00,2,0,0),(32,'PLAATSEN','25/04','','2020-04-27 07:20:18',77,'2020-04-26 12:59:39',35.00,5,0,0),(42,'TERMINAL','Isotech & HTMS updates','','2020-05-31 09:11:00',91,'2020-05-31 09:09:39',80.00,81.5,0,0),(43,'CONTROLCENTER','Updates HTMS','','2020-05-31 09:11:37',91,'2020-05-31 09:11:15',80.00,8,0,0),(44,'ANDERE','Server, DB, Updates','','2020-05-31 09:12:34',91,'2020-05-31 09:12:06',80.00,2.5,0,0),(45,'PLAATSEN','11/05, 25/05, 30/05','','2020-05-31 09:16:20',92,'2020-05-31 09:14:36',35.00,31,0,0),(46,'LASSEN','Lassen','','2020-05-31 09:17:18',92,'2020-05-31 09:16:22',25.00,13.5,0,0),(47,'TERMINAL','HTMS & Bug fixes','','2020-07-04 16:53:08',99,'2020-07-04 16:50:36',80.00,51,0,0),(48,'CONTROL CENTER','HTMS & auto updates','','2020-07-04 16:58:17',99,'2020-07-04 16:51:01',80.00,18,0,0),(49,'MONITOR','HTMS','','2020-07-04 16:58:06',99,'2020-07-04 16:51:34',80.00,6,0,0),(50,'ANDERE','Meetings','','2020-07-04 16:52:21',99,'2020-07-04 16:51:58',80.00,12,0,0),(51,'LASSEN','Gepresteerde uren ','','2020-07-04 16:56:57',100,'2020-07-04 16:53:17',35.00,15,0,0),(52,'PLAATSEN','Plaatsen','','2020-07-04 16:56:16',100,'2020-07-04 16:55:41',35.00,26,0,0),(53,'LASSEN','Gepresteerde uren hal','','2020-08-03 16:24:45',101,'2020-08-03 16:21:42',25.00,15,0,0),(54,'PLAATSEN','Gepresteerde uren','','2020-08-03 16:24:00',101,'2020-08-03 16:23:30',35.00,19,0,0),(55,'TERMINAL','HTMS','','2020-08-03 16:26:48',102,'2020-08-03 16:26:05',80.00,24,0,0),(56,'CONTROLCENTER','HTMS','','2020-08-03 16:27:40',102,'2020-08-03 16:26:52',80.00,8,0,0),(57,'MONITOR','HTMS','','2020-08-03 16:28:01',102,'2020-08-03 16:27:44',80.00,4,0,0),(58,'SERVER','HTMS & Isotech','','2020-08-03 16:28:34',102,'2020-08-03 16:28:05',80.00,4,0,0),(59,'ANDERE','Releases','','2020-08-03 16:28:49',102,'2020-08-03 16:28:37',80.00,2,0,0);
/*!40000 ALTER TABLE `invoicelines` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoices`
--

DROP TABLE IF EXISTS `invoices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoices` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `info` varchar(1023) DEFAULT NULL,
  `lastModified` timestamp NULL DEFAULT NULL,
  `outgoing` tinyint(1) DEFAULT NULL,
  `dateCreated` timestamp NULL DEFAULT NULL,
  `dateSend` timestamp NULL DEFAULT NULL,
  `dateSendToBooky` timestamp NULL DEFAULT NULL,
  `datePayed` timestamp NULL DEFAULT NULL,
  `vat` int DEFAULT NULL,
  `vatShifted` tinyint(1) DEFAULT NULL,
  `customerId` int DEFAULT NULL,
  `savePath` varchar(255) DEFAULT NULL,
  `bookySavePath` varchar(255) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_invoice_customer_idx` (`customerId`),
  CONSTRAINT `fk_invoice_customer` FOREIGN KEY (`customerId`) REFERENCES `customers` (`id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoices`
--

LOCK TABLES `invoices` WRITE;
/*!40000 ALTER TABLE `invoices` DISABLE KEYS */;
INSERT INTO `invoices` VALUES (1,'UNKNOWN',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,'2020-001','Workwatch','','2020-04-16 06:51:30',0,'2020-01-27 23:00:00','2020-03-11 22:01:05','2020-04-16 06:51:30','2020-04-11 09:49:25',21,0,2,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-001.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',3630.00),(5,'2020-002','Lassen','','2020-04-16 06:51:30',0,'2020-01-04 21:57:01','2020-03-11 21:57:20','2020-04-16 06:51:30','2020-03-11 21:57:34',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-002.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',162.50),(50,'2020-003','Lassen','','2020-04-16 06:51:30',0,'2020-01-28 20:47:27','2020-03-14 20:47:47','2020-04-16 06:51:30','2020-03-14 21:01:00',21,0,2,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-003.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',338.80),(51,'2020-004','WorkWatch','','2020-04-16 06:51:30',0,'2020-02-17 23:00:00','2020-03-14 20:50:00','2020-04-16 06:51:30','2020-03-14 21:01:10',21,0,2,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-004.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',762.30),(52,'2020-005','WorkWatch','','2020-04-16 06:51:31',0,'2020-02-18 20:54:41','2020-03-14 20:54:58','2020-04-16 06:51:30','2020-03-14 21:01:18',21,0,2,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-005.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',635.25),(53,'2020-006','Lassen','','2020-04-16 06:51:31',0,'2020-03-14 20:56:29','2020-03-26 14:29:10','2020-04-16 06:51:30','2020-03-14 20:56:43',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-006.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',415.00),(57,'1110344802','Samsung Galaxy A40','','2020-04-16 06:51:31',1,'2020-03-14 08:53:32','2020-03-14 08:53:32','2020-04-16 06:51:30','2020-03-26 08:11:21',21,0,4,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Coolblue_Factuur_1110344802.pdf','',260.94),(58,'0050568B6FBE1EDA91D912BA924E00D9','Voorschot','','2020-04-16 06:51:31',1,'2020-02-29 07:10:40','2020-02-29 07:10:40','2020-04-16 06:51:30','2020-03-20 07:20:37',21,0,5,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\pidpa_0050568B6FBE1EDA91D912BA924E00D9.pdf','',38.00),(62,'182211304090','Voorschot','','2020-04-16 06:51:31',1,'2020-03-14 08:53:39','2020-03-14 08:53:39','2020-04-16 06:51:30','2020-03-14 08:53:39',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182211304090.pdf','',138.31),(63,'422777678','QWERTY Keyboard','','2020-04-16 06:51:31',1,'2020-03-20 06:20:32','2020-03-20 06:20:32','2020-04-16 06:51:30','2020-03-26 08:11:46',21,0,7,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Alternate_422777678.pdf','',23.97),(64,'5839185','Arduino Uno','','2020-04-16 06:51:31',1,'2020-03-26 08:10:59','2020-03-26 08:10:59','2020-04-16 06:51:30','2020-03-26 08:14:47',21,0,8,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Allekabels_5839185.pdf','',28.88),(67,'Nonnemanwolfs_104_10','Psycholoog','','2020-04-16 06:51:31',1,'2020-03-26 14:13:26','2020-03-26 14:13:26','2020-04-16 06:51:30','2020-03-26 14:13:26',21,0,9,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Nonnemanwolfs_104_10.pdf','',60.00),(68,'182151411921','Voorschot','','2020-04-16 06:51:31',1,'2020-03-30 09:51:52','2020-03-30 09:51:52','2020-04-16 06:51:30','2020-04-10 09:52:09',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182151411921.pdf','',138.31),(71,'2020-008','WorkWatch Maart','','2020-04-26 12:46:32',0,'2020-04-06 10:02:34','2020-04-06 10:38:59','2020-04-16 06:51:30','2020-04-26 12:46:31',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-008.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',1258.40),(72,'18719514','Componenten power supply','','2020-04-16 06:51:31',1,'2020-04-05 14:06:55','2020-04-05 14:06:55','2020-04-16 06:51:30','2020-04-05 14:06:55',21,0,11,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Mouser_18719514.pdf','',90.36),(73,'Nonnemanwolfs_104_14','Psycholoog','','2020-04-16 06:51:31',1,'2020-04-10 07:48:24','2020-04-10 07:48:24','2020-04-16 06:51:30','2020-04-10 07:48:24',21,0,9,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Nonnemanwolfs_104_14.pdf','',60.00),(74,'telenet_1415186859','Factuur','','2020-04-16 06:51:30',1,'2020-04-14 14:45:18','2020-04-14 14:45:18','2020-04-16 06:51:30','2020-04-14 14:45:18',21,0,12,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\telenet_1415186859.pdf','',119.96),(75,'KBVF20041272','Laptop','','2020-07-09 11:45:03',1,'2020-04-16 16:21:19','2020-04-16 16:21:19','2020-07-09 11:45:00','2020-04-16 16:21:19',21,0,13,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\KBVF20041272.pdf','',1578.98),(76,'2020-009','WorkWatch','','2020-07-09 11:45:02',0,'2020-04-26 12:51:50','2020-04-26 13:15:58','2020-07-09 11:45:00','2020-05-31 08:53:08',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-009.pdf','',10648.00),(77,'2020-010','Lassen','','2020-07-09 11:45:02',0,'2020-04-26 12:57:09','2020-04-27 07:44:43','2020-07-09 11:45:00','2020-05-10 13:13:06',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-010.pdf','',704.00),(79,'182191459766','Voorschot','','2020-07-09 11:45:03',1,'2020-04-29 10:35:00','2020-04-29 10:35:00','2020-07-09 11:45:00','2020-04-29 10:35:00',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182191459766.pdf','',138.31),(80,'001304577197','Voorschot','','2020-07-09 11:45:03',1,'2020-04-29 10:34:05','2020-04-29 10:34:05','2020-07-09 11:45:00','2020-04-29 10:34:05',21,0,5,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\pidpa_001304577197.pdf','',38.00),(81,'26413982','Aanmaak eigen domein','','2020-07-09 11:45:04',1,'2020-04-29 12:51:08','2020-04-29 12:51:08','2020-07-09 11:45:00','2020-04-29 12:51:08',21,0,15,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\one_invoice.pdf','',13.14),(82,'boekhourder_844','prestaties 03/2020 ','','2020-07-09 11:45:04',1,'2020-05-02 07:47:05','2020-05-02 07:47:05','2020-07-09 11:45:00','2020-05-02 07:47:05',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhourder_844.pdf','',33.28),(83,'56664798','Power Supply bestelling','','2020-07-09 11:45:04',1,'2020-05-07 06:19:19','2020-05-07 06:19:19','2020-07-09 11:45:00','2020-05-07 06:19:19',21,0,11,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\56664798.pdf','',102.00),(84,'1424493268','Voorschot','','2020-07-09 11:45:04',1,'2020-05-06 01:53:59','2020-05-06 01:53:59','2020-07-09 11:45:00','2020-05-06 01:53:59',21,0,12,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\telenet.pdf','',54.79),(85,'EN20-317119','PCB MainGLCDController','','2020-07-09 11:45:04',1,'2020-05-07 15:45:04','2020-05-07 15:45:04','2020-07-09 11:45:00','2020-05-07 15:45:04',21,0,16,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\EN20-317119.pdf','',97.53),(88,'xerius','Inschrijving','','2020-07-09 11:45:04',1,'2020-05-15 12:53:05','2020-05-15 12:53:05','2020-07-09 11:45:00','2020-05-15 12:53:05',21,0,18,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\xerius.pdf','',657.29),(89,'boekhouder_1082','Prestaties april 2020','','2020-07-09 11:45:04',1,'2020-05-27 07:58:42','2020-05-27 07:58:42','2020-07-09 11:45:00','2020-05-27 07:58:42',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_1082.pdf','',18.33),(90,'182054785682','Voorschot','','2020-07-09 11:45:04',1,'2020-05-31 08:57:11','2020-05-31 08:57:11','2020-07-09 11:45:00','2020-05-31 08:57:11',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182054785682.pdf','',138.31),(91,'2020-011','WorkWatch Mei','','2020-07-09 11:45:02',0,'2020-05-31 09:08:51','2020-05-31 09:55:30','2020-07-09 11:45:00','2020-07-08 09:02:49',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-011.pdf','',8905.60),(92,'2020-012','Lassen','','2020-07-09 11:45:02',0,'2020-05-31 09:13:34','2020-05-31 17:44:29','2020-07-09 11:45:00','2020-06-16 14:57:33',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-012.pdf','',1422.50),(93,'Coolblue_Factuur_1178865502','Scheermachien em Bluetooth box','','2020-07-09 11:45:04',1,'2020-06-02 06:36:51','2020-06-02 06:36:51','2020-07-09 11:45:00','2020-06-02 06:36:51',21,0,4,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Coolblue_Factuur_1178865502.pdf','',252.98),(94,'telenet_05062020','Voorschot','','2020-07-09 11:45:04',1,'2020-06-06 01:23:41','2020-06-06 01:23:41','2020-07-09 11:45:00','2020-06-09 14:19:42',21,0,12,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\telenet_05062020.pdf','',54.79),(95,'MOUSER_Invoice_57050447','PowerSupply Main Controller','','2020-07-09 11:45:04',1,'2020-06-08 18:14:42','2020-06-08 18:14:42','2020-07-09 11:45:00','2020-06-08 18:14:42',21,0,11,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\MOUSER_Invoice_57050447.pdf','',88.94),(96,'Eneco_voorschot_182141425435','Voorschot','','2020-07-09 11:45:04',1,'2020-06-29 08:18:48','2020-06-29 08:18:48','2020-07-09 11:45:00','2020-06-29 08:18:48',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182141425435.pdf','',138.31),(97,'Invoice_P2541365','Devexpress winforms licentie','','2020-07-09 11:45:03',1,'2020-06-23 15:30:10','2020-06-23 15:30:10','2020-07-09 11:45:00','2020-06-23 15:30:10',21,0,1,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Invoice_P2541365.pdf','',999.99),(98,'ENECO_VOORSCHOT','Voorschot','','2020-07-09 11:45:02',1,'2020-06-29 08:18:32','2020-06-29 08:18:32','2020-07-09 11:45:00','2020-06-29 08:18:32',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\E.pdf','',138.31),(99,'2020-013','Workwatch Juni/Juli','','2020-07-09 11:45:03',0,'2020-07-04 16:47:06','2020-07-04 16:59:47','2020-07-09 11:45:00','0000-00-00 00:00:00',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-013.pdf','',8421.60),(100,'2020-014','Lassen','','2020-07-09 11:45:03',0,'2020-07-04 16:49:22','2020-07-04 16:59:57','2020-07-09 11:45:00','2020-07-08 09:02:59',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-014.pdf','',1435.00),(101,'2020-015','Lassen','','2020-08-07 06:16:43',0,'2020-08-03 16:21:17','2020-08-07 06:16:43','0000-00-00 00:00:00','0000-00-00 00:00:00',0,1,3,'D:\\Zaakjes\\Facturen\\2020-015.pdf','',1040.00),(102,'2020-016','Workwatch ','','2020-08-07 06:15:35',0,'2020-08-03 16:25:30','2020-08-03 16:29:42','0000-00-00 00:00:00','0000-00-00 00:00:00',21,0,10,'D:\\Zaakjes\\Facturen\\2020-016.pdf','',4065.60);
/*!40000 ALTER TABLE `invoices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'moneyscoop'
--

--
-- Dumping routines for database 'moneyscoop'
--
/*!50003 DROP PROCEDURE IF EXISTS `customersDelete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `customersDelete`(
	deleteId int(11)
)
BEGIN

	delete from customers where id = deleteId;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `customersInsert` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `customersInsert`(
    code varchar(45),
    description varchar(255), 
    info varchar(1023),
    addressLine1 varchar(45),
    addressLine2 varchar(45),
    vatNumber varchar(45),
    email varchar(45),
    phone varchar(45),
    out lid int)
BEGIN
	INSERT INTO customers (
		code,
		description,
        info,
        lastModified,
        addressLine1,
        addressLine2,
        vatNumber,
        email,
        phone)
	 VALUES (
		code,
		description,
        info,
        now(),
        addressLine1,
        addressLine2,
        vatNumber,
        email,
        phone);
    SET lid = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `customersSelectAll` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `customersSelectAll`()
BEGIN

	select * from customers;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `customersUpdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `customersUpdate`(
    code varchar(45),
    description varchar(255), 
    info varchar(1023),
    addressLine1 varchar(45),
    addressLine2 varchar(45),
    vatNumber varchar(45),
    email varchar(45),
    phone varchar(45),
	updateId int)
BEGIN
	UPDATE
		customers
	SET	
		code = code,
		description = description,
        info = info,
        lastModified = now(),
        addressLine1 = addressLine1,
        addressLine2 = addressLine2,
        vatNumber = vatNumber,
        email = email,
        phone = phone
	WHERE
		id = updateId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `invoicelinesDelete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `invoicelinesDelete`(
	deleteId int(11)
)
BEGIN

	delete from invoicelines where id = deleteId;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `invoicelinesInsert` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `invoicelinesInsert`(
    code varchar(45),
    description varchar(255), 
    info varchar(1023),
    invoiceId int(11),
    dateCreated timestamp,
    unitPrice decimal(10,2),
    multiplier double,
    showUnitPrice tinyint(1),
    showDate tinyint(1),
    out lid int)
BEGIN
	INSERT INTO invoicelines (
		code,
		description,
        info,
        lastModified,
        invoiceId,
        dateCreated,
        unitPrice,
        multiplier,
        showUnitPrice,
        showDate)
	 VALUES (
		code,
		description,
        info,
        now(),
        invoiceId,
        dateCreated,
        unitPrice,
        multiplier,
        showUnitPrice,
        showDate);
    SET lid = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `invoicelinesSelectAll` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `invoicelinesSelectAll`()
BEGIN

	select * from invoicelines;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `invoicelinesUpdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `invoicelinesUpdate`(
    code varchar(45),
    description varchar(255), 
    info varchar(1023),
    invoiceId int(11),
    dateCreated timestamp,
    unitPrice decimal(10,2),
    multiplier double,
    showUnitPrice tinyint(1),
    showDate tinyint(1),
    updateId int)
BEGIN
	UPDATE
		invoicelines
	SET	
		code = code,
		description = description,
        info = info,
        lastModified = now(),
        invoiceId = invoiceId,
        dateCreated = dateCreated,
        unitPrice = unitPrice,
        multiplier = multiplier,
        showUnitPrice = showUnitPrice,
        showDate = showDate
	WHERE
		id = updateId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `invoicesDelete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `invoicesDelete`(
	deleteId int(11)
)
BEGIN

	delete from invoices where id = deleteId;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `invoicesInsert` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `invoicesInsert`(
    code varchar(45),
    description varchar(255), 
    info varchar(1023),
    outgoing tinyint(1),
    dateCreated timestamp,
    dateSend timestamp,
    datePayed timestamp,
    dateSendToBooky timestamp,
    vat int,
    vatShifted tinyint(1),
    customerId int(11),
    savePath varchar(255),
    bookySavePath varchar(255),
    total decimal(10,2),
    out lid int)
BEGIN
	INSERT INTO invoices (
		code,
		description,
        info,
        lastModified,
        outgoing,
        dateCreated,
        dateSend,
        datePayed,
        dateSendToBooky,
        vat,
        vatShifted,
        customerId,
        savePath,
        bookySavePath,
        total)
	 VALUES (
		code,
		description,
        info,
        now(),
        outgoing,
        dateCreated,
        dateSend,
        datePayed,
        dateSendToBooky,
        vat,
        vatShifted,
        customerId,
		savePath,
		bookySavePath,
        total);
    SET lid = last_insert_id();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `invoicesSelectAll` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `invoicesSelectAll`()
BEGIN

	select * from invoices;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `invoicesUpdate` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = '' */ ;
DELIMITER ;;
CREATE DEFINER=`waldo`@`%` PROCEDURE `invoicesUpdate`(
    code varchar(45),
    description varchar(255), 
    info varchar(1023),
    outgoing tinyint(1),
    dateCreated timestamp,
    dateSend timestamp,
    datePayed timestamp,
    dateSendToBooky timestamp,
    vat int,
    vatShifted tinyint(1),
    customerId int(11),
    savePath varchar(255),
    bookySavePath varchar(255),
    total decimal(10,2),
	updateId int)
BEGIN
	UPDATE
		invoices
	SET	
		code = code,
		description = description,
        info = info,
        lastModified = now(),
        outgoing = outgoing,
        dateCreated = dateCreated,
        dateSend = dateSend,
        datePayed = datePayed,
        dateSendToBooky = dateSendToBooky,
        vat = vat,
        vatShifted = vatShifted,
        customerId = customerId,
        savePath = savePath,
        bookySavePath = bookySavePath,
        total = total
	WHERE
		id = updateId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-05 15:51:12
