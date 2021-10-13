-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: 192.168.1.5    Database: moneyscoop
-- ------------------------------------------------------
-- Server version	5.5.62-0+deb8u1

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
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `info` varchar(1023) DEFAULT NULL,
  `lastModified` timestamp NULL DEFAULT NULL,
  `addressLine1` varchar(45) DEFAULT NULL,
  `addressLine2` varchar(45) DEFAULT NULL,
  `vatNumber` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `website` varchar(128) DEFAULT NULL,
  `defaultUnitPrice` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'UNKNOWN',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2,'GALENUS BVBA','Galenus BVBA','','2020-03-11 21:54:33','Heist-Goorstraat 23a','2220 Heist-op-den-Berg','BE0842.797.267','info@galenus.be','',NULL,NULL),(3,'PIETER THYS BVBA','Pieter Thys Laswerken','','2021-03-30 07:12:02','A. Van Looplein 29','2235 Westmeerbeek','BE0678.872.613','info@pieterthys.be','0473243953','',35.00),(4,'COOLBLUE','Coolblue','','2020-03-14 14:31:57','','','','','',NULL,NULL),(5,'PIDPA','Water in beweging','','2020-03-14 21:04:40','Desguinlei 246','2018 Antwerpen','BE0204.908.936','','080090300',NULL,NULL),(6,'ENECO','Eneco','','2020-03-14 21:07:03','Battelsesteenweg 455i','2800 Mechelen','','','015256677',NULL,NULL),(7,'ALTERNATE','Alternate BVBA','','2020-03-20 07:23:37','Oeyvaertsbosch 16 - 18','2630 ','Aartselaar','sales@alternate.be','038711111',NULL,NULL),(8,'ALLEKABELS','Alle kabels','','2020-03-26 08:14:30','Kerkrade','6460 BB','NL8214.73.013.B01','www.allekabels.be','0455717001',NULL,NULL),(9,'NONNEMANWOLFS','Psycholoog','','2020-03-26 08:47:53','Hoge Heide 3','2223 Schriek','0808.7357.18','jan@nonnemanwolfs.be','',NULL,NULL),(10,'MULTIBUSY','Bedrijfsorganisatie','','2021-03-30 07:28:21','Guido Gezellelaan 26','2920 Kalmthout','BE0849.283.597','Lieven@multibusy.be','+32 3 666 84 27','',80.00),(11,'MOUSER','Electronics','','2020-04-06 10:41:07','','','FR 27512466913','','',NULL,NULL),(12,'TELENET','Telenet','','2020-04-14 14:47:00','Liersesteenweg 4','2800 Mechelen','BE0473.416.418','www.telenet.be','015/66.66.66',NULL,NULL),(13,'PARADIGIT','IT stuff','','2020-09-05 15:32:42','','','','','',NULL,NULL),(14,'PETER THYS','Peer beer','','2020-04-28 19:43:15','Putte','','123654','email','213987',NULL,NULL),(15,'ONE.COM','Domain name site','','2020-04-29 12:57:37','Strawinskylaan 3051','1077 ZX Amsterdam','SE559205240001','sales@one.com','',NULL,NULL),(16,'EUROCIRCTUIS','PCB Manufacturer','','2020-05-07 15:45:28','Antwerpsesteenweg 66 ','2800 Mechelen','BE0 444 188 140 ','euro@eurocircuits.com','+3215281630',NULL,NULL),(17,'BOEKHOUDER','Accountants en Belastingsconsulenten','','2020-05-02 14:34:42','','','','','',NULL,NULL),(18,'XERIUS','Sociaal verzekeringsfonds','','2020-05-15 12:57:02','Vogelzanglaan 1','2300 Turnhout','','turnhout@xerius.be','078150552',NULL,NULL),(20,'THOMANN','Audo stuff','','2020-10-07 14:13:28','','','','','',NULL,NULL),(21,'PROXIMUS','Telefon en Internet','','2020-11-24 09:34:52','','','','','',NULL,NULL),(22,'DEVEXPRESS','Devexpress GUI library C#','','2021-03-09 08:49:56','','','','','',NULL,NULL),(23,'GUNSBLAZE','Gunsblaze',NULL,'2021-03-30 07:49:56',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(24,'MICROSOFT','Microsoft','','2021-06-08 11:11:52','','','','','','',0.00);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoicelines`
--

DROP TABLE IF EXISTS `invoicelines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoicelines` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `info` varchar(1023) DEFAULT NULL,
  `lastModified` timestamp NULL DEFAULT NULL,
  `invoiceId` int(11) DEFAULT NULL,
  `dateCreated` timestamp NULL DEFAULT NULL,
  `unitPrice` decimal(10,2) DEFAULT NULL,
  `multiplier` double DEFAULT NULL,
  `showUnitPrice` tinyint(1) DEFAULT NULL,
  `showDate` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_line_invoice_idx` (`invoiceId`),
  CONSTRAINT `fk_line_invoice` FOREIGN KEY (`invoiceId`) REFERENCES `invoices` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=125 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoicelines`
--

LOCK TABLES `invoicelines` WRITE;
/*!40000 ALTER TABLE `invoicelines` DISABLE KEYS */;
INSERT INTO `invoicelines` VALUES (1,'UNKNOWN',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(5,'WORKWATCH','Geleverde prestaties project WorkWatch tem November 2019','','2020-03-11 21:55:38',4,'2020-03-11 21:55:19',3000.00,1,0,0),(6,'LASSEN','Trappen antwerpen','','2020-03-14 20:44:43',5,'2020-03-11 21:57:43',87.50,1,1,1),(7,'LASSEN','Lassen hal','','2020-03-14 11:20:25',5,'2020-03-11 21:58:59',75.00,1,0,0),(10,'WORKWATCH','Geleverde prestaties WorkWatch december 2019','','2020-03-14 20:49:03',50,'2020-03-14 20:48:14',35.00,8,1,1),(11,'WORKWATCH','Geleverde prestaties WorkWatch Januari','','2020-03-14 20:51:29',51,'2020-03-14 20:50:04',35.00,18,1,1),(12,'WORKWATCH','Geleverde prestaties WorkWatch Febfruari','','2020-03-14 20:55:44',52,'2020-03-14 20:55:03',35.00,15,1,1),(13,'LASSEN','27/01','','2020-03-14 20:57:10',53,'2020-03-14 20:56:47',25.00,3,1,1),(14,'LASSEN','31/01','','2020-03-14 20:57:34',53,'2020-03-14 20:57:11',25.00,4,1,1),(15,'TENTPALEN','14/02','','2020-03-14 20:58:04',53,'2020-03-14 20:57:35',32.00,4,1,1),(16,'TENTPALEN','19/21','','2020-03-14 20:58:35',53,'2020-03-14 20:58:04',32.00,3.5,1,1),(19,'TERMINAL','Debug versie, Layout, Registratie dialoog','','2020-04-06 10:07:23',71,'2020-04-06 10:03:05',80.00,7.5,0,0),(20,'CONTROLE CENTER','Meerdere gebruikers','','2020-04-06 10:05:49',71,'2020-04-06 10:05:17',80.00,3,0,0),(21,'TESTISOTECH','Test Isotech Database naar live versie omzetten','','2020-04-06 10:08:34',71,'2020-04-06 10:08:01',80.00,0.5,0,0),(22,'SERVER','Registraties','','2020-04-06 10:09:47',71,'2020-04-06 10:08:45',80.00,2,0,0),(23,'TERMINAL','Bug fixes','','2020-04-26 12:54:48',76,'2020-04-26 12:52:39',80.00,11,0,0),(24,'MONITOR','Ontwikkeling','','2020-04-26 13:10:53',76,'2020-04-26 12:53:08',80.00,94.5,0,0),(25,'ISOTECH','24/04/2020','','2020-04-26 12:54:04',76,'2020-04-26 12:53:37',80.00,2,0,0),(26,'ANDERE','Meetings','','2020-04-26 12:54:28',76,'2020-04-26 12:54:07',80.00,2.5,0,0),(27,'LASSEN','10/04','','2020-04-27 07:19:48',77,'2020-04-26 12:57:47',35.00,2,0,0),(28,'PROFIEL','Profiel plaatsen','','2020-04-26 12:58:32',77,'2020-04-26 12:58:07',72.00,2,0,0),(29,'LASSEN','13/04','','2020-04-27 07:19:55',77,'2020-04-26 12:58:38',35.00,3,0,0),(30,'LASSEN','17/04','','2020-04-27 07:20:01',77,'2020-04-26 12:59:02',35.00,4,0,0),(31,'LASSEN','20/04','','2020-04-27 07:20:13',77,'2020-04-26 12:59:21',35.00,2,0,0),(32,'PLAATSEN','25/04','','2020-04-27 07:20:18',77,'2020-04-26 12:59:39',35.00,5,0,0),(42,'TERMINAL','Isotech & HTMS updates','','2020-05-31 09:11:00',91,'2020-05-31 09:09:39',80.00,81.5,0,0),(43,'CONTROLCENTER','Updates HTMS','','2020-05-31 09:11:37',91,'2020-05-31 09:11:15',80.00,8,0,0),(44,'ANDERE','Server, DB, Updates','','2020-05-31 09:12:34',91,'2020-05-31 09:12:06',80.00,2.5,0,0),(45,'PLAATSEN','11/05, 25/05, 30/05','','2020-05-31 09:16:20',92,'2020-05-31 09:14:36',35.00,31,0,0),(46,'LASSEN','Lassen','','2020-05-31 09:17:18',92,'2020-05-31 09:16:22',25.00,13.5,0,0),(47,'TERMINAL','HTMS & Bug fixes','','2020-07-04 16:53:08',99,'2020-07-04 16:50:36',80.00,51,0,0),(48,'CONTROL CENTER','HTMS & auto updates','','2020-07-04 16:58:17',99,'2020-07-04 16:51:01',80.00,18,0,0),(49,'MONITOR','HTMS','','2020-07-04 16:58:06',99,'2020-07-04 16:51:34',80.00,6,0,0),(50,'ANDERE','Meetings','','2020-07-04 16:52:21',99,'2020-07-04 16:51:58',80.00,12,0,0),(51,'LASSEN','Gepresteerde uren ','','2020-07-04 16:56:57',100,'2020-07-04 16:53:17',35.00,15,0,0),(52,'PLAATSEN','Plaatsen','','2020-07-04 16:56:16',100,'2020-07-04 16:55:41',35.00,26,0,0),(53,'LASSEN','Gepresteerde uren hal','','2020-08-03 16:24:45',101,'2020-08-03 16:21:42',25.00,15,0,0),(54,'PLAATSEN','Gepresteerde uren','','2020-08-03 16:24:00',101,'2020-08-03 16:23:30',35.00,19,0,0),(55,'TERMINAL','HTMS','','2020-08-03 16:26:48',102,'2020-08-03 16:26:05',80.00,24,0,0),(56,'CONTROLCENTER','HTMS','','2020-08-03 16:27:40',102,'2020-08-03 16:26:52',80.00,8,0,0),(57,'MONITOR','HTMS','','2020-08-03 16:28:01',102,'2020-08-03 16:27:44',80.00,4,0,0),(58,'SERVER','HTMS & Isotech','','2020-08-03 16:28:34',102,'2020-08-03 16:28:05',80.00,4,0,0),(59,'ANDERE','Releases','','2020-08-03 16:28:49',102,'2020-08-03 16:28:37',80.00,2,0,0),(60,'LASSEN','Gepresteerde uren 22/07 - 20/09','','2020-09-20 09:01:16',108,'2020-09-20 08:57:14',25.00,10,0,0),(61,'PLAATSEN','Gepresteerde uren 22/07 - 20/09','','2020-09-20 08:59:35',108,'2020-09-20 08:58:24',35.00,29,0,0),(62,'TERMINAL','HTMS en Isotech','','2020-09-20 09:15:02',109,'2020-09-20 09:14:39',80.00,3,0,0),(63,'CONTROLCENTER','HTMS en Isotech','','2020-09-20 09:15:19',109,'2020-09-20 09:15:05',80.00,7,0,0),(64,'MONITOR','HTMS','','2020-09-20 09:15:35',109,'2020-09-20 09:15:21',80.00,4,0,0),(65,'TERMINAL','HTMS','','2020-10-07 14:28:31',113,'2020-10-07 12:28:19',80.00,14,0,0),(66,'CONTROLCENTER','HTMS','','2020-10-07 14:28:55',113,'2020-10-07 12:28:36',80.00,5,0,0),(67,'TERMINAL','ITL HTMS','','2020-11-03 14:33:21',115,'2020-11-03 14:32:55',80.00,11,0,0),(68,'CONTROLCENTER','ITL HTMS','','2020-11-03 14:33:40',115,'2020-11-03 14:33:25',80.00,19.5,0,0),(69,'ANDERE','Meetings','','2020-11-03 14:34:03',115,'2020-11-03 14:33:46',80.00,4,0,0),(70,'TERMINAL','HTMS & Isotech','','2020-11-30 18:55:35',119,'2020-11-30 18:52:36',80.00,15,0,0),(71,'CONTROLCENTER','ISOTECH MasterList & Nacalculatie','','2020-11-30 18:55:41',119,'2020-11-30 18:53:05',80.00,28,0,0),(72,'MONITOR','HTMS','','2020-11-30 18:55:48',119,'2020-11-30 18:53:59',80.00,29.5,0,0),(73,'ANDERE','Meetings','','2020-11-30 18:54:45',119,'2020-11-30 18:54:25',80.00,5,0,0),(74,'LASSEN','Lassen','','2020-11-30 19:04:37',120,'2020-11-30 19:03:01',25.00,7.5,0,0),(75,'PLAATSEN','Plaatsen','','2020-11-30 19:05:46',120,'2020-11-30 19:04:40',35.00,33,0,0),(76,'TERMINAL','Dialogs, MAC address, document viewer','','2020-12-27 13:11:01',122,'2020-12-27 13:08:21',80.00,21,0,0),(77,'CONTROLCENTER','Make registrations, mac address','','2020-12-27 13:10:55',122,'2020-12-27 13:09:10',80.00,8,0,0),(78,'MONITOR','Cleaning up, user status','','2020-12-27 13:10:50',122,'2020-12-27 13:09:50',80.00,7,0,0),(79,'SERVER','Running as a service','','2020-12-27 13:10:42',122,'2020-12-27 13:10:12',80.00,5,0,0),(80,'ANDERE','Database bug HTMS + meetings','','2020-12-27 13:11:46',122,'2020-12-27 13:11:11',80.00,2,0,0),(81,'TERMINAL','MAC address, registering sessions, document viewer','','2021-02-01 18:02:33',130,'2021-02-01 18:01:51',80.00,17,0,0),(82,'CONTROLCENTER','Making registrations','','2021-02-01 18:03:01',130,'2021-02-01 18:02:36',80.00,8,0,0),(83,'MONITOR','Status view, bug fixes','','2021-02-01 18:03:22',130,'2021-02-01 18:03:02',80.00,24,0,0),(84,'ANDERE','Meetings','','2021-02-01 18:03:37',130,'2021-02-01 18:03:25',80.00,1,0,0),(85,'LASSEN','Lassen','','2021-02-28 09:47:23',131,'2021-02-28 09:46:25',25.00,9,0,0),(86,'PLAATSEN','Plaatsen','','2021-02-28 09:48:04',131,'2021-02-28 09:47:24',35.00,38,0,0),(87,'TERMINAL','Auto install, Job sheet, Document Viewer','','2021-02-28 09:52:29',132,'2021-02-28 09:48:50',80.00,26,0,0),(88,'CONTROLCENTER','Auto Install apk, Job Sheet','','2021-02-28 09:53:47',132,'2021-02-28 09:49:59',80.00,15,0,0),(89,'MONITOR','Bug fixes','','2021-02-28 09:53:56',132,'2021-02-28 09:50:20',80.00,5,0,0),(90,'ANDERE','Meetings','','2021-02-28 09:53:28',132,'2021-02-28 09:50:38',80.00,3,0,0),(91,'SERVER','Running as a service','','2021-02-28 09:52:45',132,'2021-02-28 09:51:40',80.00,8,0,0),(92,'PLAATSEN','Plaatsen','','2021-03-29 08:28:09',142,'2021-03-29 08:27:25',35.00,16,0,0),(93,'TERMINAL','Auto install & Windows Service','','2021-03-29 08:29:48',143,'2021-03-29 08:29:02',80.00,5,0,0),(94,'CONTROLCENTER','Debug config','','2021-03-29 08:31:12',143,'2021-03-29 08:29:50',80.00,3,0,0),(95,'ALURO','Create Server','','2021-03-29 08:30:30',143,'2021-03-29 08:30:16',80.00,1,0,0),(96,'MEETINGS','Meetings','','2021-03-29 08:30:42',143,'2021-03-29 08:30:33',80.00,2,0,0),(97,'ONLINEMONITOR','Online Monitor Service','','2021-03-29 08:31:01',143,'2021-03-29 08:30:47',80.00,8,0,0),(98,'MEETINGS','Meetings','','2021-05-03 15:23:17',150,'2021-05-03 15:22:43',80.00,3,0,0),(99,'KARDEX','Kardex','','2021-05-03 15:23:41',150,'2021-05-03 15:23:19',80.00,4,0,0),(100,'SERVER','Documents refactor','','2021-05-03 15:23:56',150,'2021-05-03 15:23:42',80.00,2,0,0),(102,'TERMINAL','Documenten & Messages','','2021-05-30 10:32:09',151,'2021-05-30 10:31:01',80.00,19,0,0),(103,'SERVER','Documenten, Messages, finishing jobs','','2021-05-30 10:34:42',151,'2021-05-30 10:31:27',80.00,7,0,0),(104,'CONTROLCENTER','Documenten & Messages','','2021-05-30 10:33:55',151,'2021-05-30 10:31:37',80.00,11,0,0),(105,'OTHER','Meetings & HTMS Jobs clean up','','2021-05-30 10:34:59',151,'2021-05-30 10:32:23',80.00,4,0,0),(106,'KARDEX','Service updates & testing','','2021-05-30 10:33:05',151,'2021-05-30 10:32:33',80.00,3,0,0),(107,'PLAATSEN','Plaatsen','','2021-07-16 15:15:29',164,'2021-07-16 15:15:03',2390.00,1,0,0),(108,'CONTROLCENTER','Messages & Updating tablet','','2021-08-02 15:08:23',166,'2021-08-02 15:07:54',80.00,11.5,0,0),(109,'TERMINAL','Messages & Updating','','2021-08-02 15:08:40',166,'2021-08-02 15:08:25',80.00,13,0,0),(110,'OTHER','Meetings','','2021-08-02 15:08:55',166,'2021-08-02 15:08:41',80.00,6,0,0),(111,'SERVER','Messages & Updates','','2021-08-02 15:09:15',166,'2021-08-02 15:09:00',80.00,4,0,0),(112,'KARDEX','Installatie en Updates','','2021-09-02 10:01:21',167,'2021-09-02 10:00:50',80.00,10,0,0),(113,'TERMINAL','Messages en Documenten','','2021-09-02 10:01:53',167,'2021-09-02 10:01:23',80.00,8.5,0,0),(114,'LASSEN','Lassen','','2021-09-02 10:04:56',168,'2021-09-02 10:04:15',25.00,3,0,0),(115,'PLAATSEN','Plaatsen','','2021-09-02 10:05:22',168,'2021-09-02 10:04:57',35.00,8.5,0,0),(116,'PLAATSEN','Augustus','','2021-10-01 12:41:12',176,'2021-10-01 12:40:48',35.00,2.5,0,0),(117,'PLAATSEN','September','','2021-10-01 12:41:57',176,'2021-10-01 12:41:15',35.00,17.5,0,0),(118,'KARDEX','Installatie & Updates','','2021-10-01 12:43:34',177,'2021-10-01 12:43:11',80.00,4,0,0),(119,'ALURO','Installatie','','2021-10-01 12:44:07',177,'2021-10-01 12:43:39',80.00,5,0,0),(120,'TERMINAL','Messages, Zones, Aluro layout','','2021-10-01 12:44:24',177,'2021-10-01 12:44:09',80.00,12,0,0),(121,'SERVER','Zones, Messages','','2021-10-01 12:44:40',177,'2021-10-01 12:44:26',80.00,4,0,0),(122,'CONTROLECENTER','Messages, Zones','','2021-10-01 12:44:58',177,'2021-10-01 12:44:45',80.00,6,0,0),(123,'MEETINGS','Kalmthout, Aluro','','2021-10-01 12:45:48',177,'2021-10-01 12:45:00',80.00,11,0,0),(124,'OTHER','MSSQL Tools','','2021-10-01 12:46:11',177,'2021-10-01 12:46:00',80.00,3,0,0);
/*!40000 ALTER TABLE `invoicelines` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoices`
--

DROP TABLE IF EXISTS `invoices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoices` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(45) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `info` varchar(1023) DEFAULT NULL,
  `lastModified` timestamp NULL DEFAULT NULL,
  `outgoing` tinyint(1) DEFAULT NULL,
  `dateCreated` timestamp NULL DEFAULT NULL,
  `dateSend` timestamp NULL DEFAULT NULL,
  `dateSendToBooky` timestamp NULL DEFAULT NULL,
  `datePayed` timestamp NULL DEFAULT NULL,
  `vat` int(11) DEFAULT NULL,
  `vatShifted` tinyint(1) DEFAULT NULL,
  `customerId` int(11) DEFAULT NULL,
  `savePath` varchar(255) DEFAULT NULL,
  `bookySavePath` varchar(255) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_invoice_customer_idx` (`customerId`),
  CONSTRAINT `fk_invoice_customer` FOREIGN KEY (`customerId`) REFERENCES `customers` (`id`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=178 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoices`
--

LOCK TABLES `invoices` WRITE;
/*!40000 ALTER TABLE `invoices` DISABLE KEYS */;
INSERT INTO `invoices` VALUES (1,'UNKNOWN',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,'2020-001','Workwatch','','2020-04-16 06:51:30',0,'2020-01-27 23:00:00','2020-03-11 22:01:05','2020-04-16 06:51:30','2020-04-11 09:49:25',21,0,2,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-001.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',3630.00),(5,'2020-002','Lassen','','2020-04-16 06:51:30',0,'2020-01-04 21:57:01','2020-03-11 21:57:20','2020-04-16 06:51:30','2020-03-11 21:57:34',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-002.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',162.50),(50,'2020-003','Lassen','','2020-04-16 06:51:30',0,'2020-01-28 20:47:27','2020-03-14 20:47:47','2020-04-16 06:51:30','2020-03-14 21:01:00',21,0,2,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-003.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',338.80),(51,'2020-004','WorkWatch','','2020-04-16 06:51:30',0,'2020-02-17 23:00:00','2020-03-14 20:50:00','2020-04-16 06:51:30','2020-03-14 21:01:10',21,0,2,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-004.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',762.30),(52,'2020-005','WorkWatch','','2020-04-16 06:51:31',0,'2020-02-18 20:54:41','2020-03-14 20:54:58','2020-04-16 06:51:30','2020-03-14 21:01:18',21,0,2,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-005.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',635.25),(53,'2020-006','Lassen','','2020-04-16 06:51:31',0,'2020-03-14 20:56:29','2020-03-26 14:29:10','2020-04-16 06:51:30','2020-03-14 20:56:43',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-006.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',415.00),(57,'1110344802','Samsung Galaxy A40','','2020-04-16 06:51:31',1,'2020-03-14 08:53:32','2020-03-14 08:53:32','2020-04-16 06:51:30','2020-03-26 08:11:21',21,0,4,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Coolblue_Factuur_1110344802.pdf','',260.94),(58,'0050568B6FBE1EDA91D912BA924E00D9','Voorschot','','2020-04-16 06:51:31',1,'2020-02-29 07:10:40','2020-02-29 07:10:40','2020-04-16 06:51:30','2020-03-20 07:20:37',21,0,5,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\pidpa_0050568B6FBE1EDA91D912BA924E00D9.pdf','',38.00),(62,'182211304090','Voorschot','','2020-04-16 06:51:31',1,'2020-03-14 08:53:39','2020-03-14 08:53:39','2020-04-16 06:51:30','2020-03-14 08:53:39',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182211304090.pdf','',138.31),(63,'422777678','QWERTY Keyboard','','2020-04-16 06:51:31',1,'2020-03-20 06:20:32','2020-03-20 06:20:32','2020-04-16 06:51:30','2020-03-26 08:11:46',21,0,7,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Alternate_422777678.pdf','',23.97),(64,'5839185','Arduino Uno','','2020-04-16 06:51:31',1,'2020-03-26 08:10:59','2020-03-26 08:10:59','2020-04-16 06:51:30','2020-03-26 08:14:47',21,0,8,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Allekabels_5839185.pdf','',28.88),(67,'Nonnemanwolfs_104_10','Psycholoog','','2020-04-16 06:51:31',1,'2020-03-26 14:13:26','2020-03-26 14:13:26','2020-04-16 06:51:30','2020-03-26 14:13:26',21,0,9,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Nonnemanwolfs_104_10.pdf','',60.00),(68,'182151411921','Voorschot','','2020-04-16 06:51:31',1,'2020-03-30 09:51:52','2020-03-30 09:51:52','2020-04-16 06:51:30','2020-04-10 09:52:09',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182151411921.pdf','',138.31),(71,'2020-008','WorkWatch Maart','','2020-04-26 12:46:32',0,'2020-04-06 10:02:34','2020-04-06 10:38:59','2020-04-16 06:51:30','2020-04-26 12:46:31',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-008.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20200416.pdf',1258.40),(72,'18719514','Componenten power supply','','2020-04-16 06:51:31',1,'2020-04-05 14:06:55','2020-04-05 14:06:55','2020-04-16 06:51:30','2020-04-05 14:06:55',21,0,11,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Mouser_18719514.pdf','',90.36),(73,'Nonnemanwolfs_104_14','Psycholoog','','2020-04-16 06:51:31',1,'2020-04-10 07:48:24','2020-04-10 07:48:24','2020-04-16 06:51:30','2020-04-10 07:48:24',21,0,9,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Nonnemanwolfs_104_14.pdf','',60.00),(74,'telenet_1415186859','Factuur','','2020-04-16 06:51:30',1,'2020-04-14 14:45:18','2020-04-14 14:45:18','2020-04-16 06:51:30','2020-04-14 14:45:18',21,0,12,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\telenet_1415186859.pdf','',119.96),(75,'KBVF20041272','Laptop','','2020-07-09 11:45:03',1,'2020-04-16 16:21:19','2020-04-16 16:21:19','2020-07-09 11:45:00','2020-04-16 16:21:19',21,0,13,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\KBVF20041272.pdf','',1578.98),(76,'2020-009','WorkWatch','','2020-07-09 11:45:02',0,'2020-04-26 12:51:50','2020-04-26 13:15:58','2020-07-09 11:45:00','2020-05-31 08:53:08',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-009.pdf','',10648.00),(77,'2020-010','Lassen','','2020-07-09 11:45:02',0,'2020-04-26 12:57:09','2020-04-27 07:44:43','2020-07-09 11:45:00','2020-05-10 13:13:06',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-010.pdf','',704.00),(79,'182191459766','Voorschot','','2020-07-09 11:45:03',1,'2020-04-29 10:35:00','2020-04-29 10:35:00','2020-07-09 11:45:00','2020-04-29 10:35:00',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182191459766.pdf','',138.31),(80,'001304577197','Voorschot','','2020-07-09 11:45:03',1,'2020-04-29 10:34:05','2020-04-29 10:34:05','2020-07-09 11:45:00','2020-04-29 10:34:05',21,0,5,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\pidpa_001304577197.pdf','',38.00),(81,'26413982','Aanmaak eigen domein','','2020-07-09 11:45:04',1,'2020-04-29 12:51:08','2020-04-29 12:51:08','2020-07-09 11:45:00','2020-04-29 12:51:08',21,0,15,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\one_invoice.pdf','',13.14),(82,'boekhourder_844','prestaties 03/2020 ','','2020-07-09 11:45:04',1,'2020-05-02 07:47:05','2020-05-02 07:47:05','2020-07-09 11:45:00','2020-05-02 07:47:05',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhourder_844.pdf','',33.28),(83,'56664798','Power Supply bestelling','','2020-07-09 11:45:04',1,'2020-05-07 06:19:19','2020-05-07 06:19:19','2020-07-09 11:45:00','2020-05-07 06:19:19',21,0,11,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\56664798.pdf','',102.00),(84,'1424493268','Voorschot','','2020-07-09 11:45:04',1,'2020-05-06 01:53:59','2020-05-06 01:53:59','2020-07-09 11:45:00','2020-05-06 01:53:59',21,0,12,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\telenet.pdf','',54.79),(85,'EN20-317119','PCB MainGLCDController','','2020-07-09 11:45:04',1,'2020-05-07 15:45:04','2020-05-07 15:45:04','2020-07-09 11:45:00','2020-05-07 15:45:04',21,0,16,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\EN20-317119.pdf','',97.53),(88,'xerius','Inschrijving','','2020-07-09 11:45:04',1,'2020-05-15 12:53:05','2020-05-15 12:53:05','2020-07-09 11:45:00','2020-05-15 12:53:05',21,0,18,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\xerius.pdf','',657.29),(89,'boekhouder_1082','Prestaties april 2020','','2020-07-09 11:45:04',1,'2020-05-27 07:58:42','2020-05-27 07:58:42','2020-07-09 11:45:00','2020-05-27 07:58:42',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_1082.pdf','',18.33),(90,'182054785682','Voorschot','','2020-07-09 11:45:04',1,'2020-05-31 08:57:11','2020-05-31 08:57:11','2020-07-09 11:45:00','2020-05-31 08:57:11',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182054785682.pdf','',138.31),(91,'2020-011','WorkWatch Mei','','2020-07-09 11:45:02',0,'2020-05-31 09:08:51','2020-05-31 09:55:30','2020-07-09 11:45:00','2020-07-08 09:02:49',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-011.pdf','',8905.60),(92,'2020-012','Lassen','','2020-07-09 11:45:02',0,'2020-05-31 09:13:34','2020-05-31 17:44:29','2020-07-09 11:45:00','2020-06-16 14:57:33',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-012.pdf','',1422.50),(93,'Coolblue_Factuur_1178865502','Scheermachien em Bluetooth box','','2020-07-09 11:45:04',1,'2020-06-02 06:36:51','2020-06-02 06:36:51','2020-07-09 11:45:00','2020-06-02 06:36:51',21,0,4,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Coolblue_Factuur_1178865502.pdf','',252.98),(94,'telenet_05062020','Voorschot','','2020-07-09 11:45:04',1,'2020-06-06 01:23:41','2020-06-06 01:23:41','2020-07-09 11:45:00','2020-06-09 14:19:42',21,0,12,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\telenet_05062020.pdf','',54.79),(95,'MOUSER_Invoice_57050447','PowerSupply Main Controller','','2020-07-09 11:45:04',1,'2020-06-08 18:14:42','2020-06-08 18:14:42','2020-07-09 11:45:00','2020-06-08 18:14:42',21,0,11,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\MOUSER_Invoice_57050447.pdf','',88.94),(96,'182141425435','Voorschot','','2020-11-24 09:51:15',1,'2020-06-29 08:18:48','2020-06-29 08:18:48','2020-07-09 11:45:00','2020-06-29 08:18:48',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182141425435.pdf','',138.31),(97,'Invoice_P2541365','Devexpress winforms licentie','','2021-03-09 08:50:05',1,'2020-06-23 15:30:10','2020-06-23 15:30:10','2020-07-09 11:45:00','2020-06-23 15:30:10',21,0,22,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Invoice_P2541365.pdf','',999.99),(98,'182141425435','Voorschot','','2020-11-24 09:51:05',1,'2020-06-29 08:18:32','2020-06-29 08:18:32','2020-07-09 11:45:00','2020-06-29 08:18:32',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\E.pdf','',138.31),(99,'2020-013','Workwatch Juni/Juli','','2020-09-05 14:02:23',0,'2020-07-04 16:47:06','2020-07-04 16:59:47','2020-07-09 11:45:00','2020-09-05 14:02:23',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-013.pdf','',8421.60),(100,'2020-014','Lassen','','2020-07-09 11:45:03',0,'2020-07-04 16:49:22','2020-07-04 16:59:57','2020-07-09 11:45:00','2020-07-08 09:02:59',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-014.pdf','',1435.00),(101,'2020-015','Lassen','','2020-10-07 14:39:11',0,'2020-08-03 16:21:17','2020-08-07 06:16:43','2020-10-07 12:39:12','2020-09-05 14:02:10',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-015.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20201007.pdf',1040.00),(102,'2020-016','Workwatch ','','2020-10-07 14:39:11',0,'2020-08-03 16:25:30','2020-08-03 16:29:42','2020-10-07 12:39:12','2020-09-05 14:01:57',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-016.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20201007.pdf',4066.00),(103,'boekhouder_06.2020','','','2021-07-05 08:15:20',1,'2020-07-25 11:40:57','2020-07-25 11:40:57','2020-10-07 12:39:12','2020-07-25 11:40:57',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_06.2020.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201007.pdf',36.30),(104,'18211458690','Voorschot','','2020-11-24 09:51:23',1,'2020-09-01 16:49:18','2020-09-01 16:49:18','2020-10-07 12:39:12','2020-09-01 16:49:18',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_18211458690.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201007.pdf',138.31),(105,'boekhouder_07.2020','','','2021-07-05 08:15:13',1,'2020-08-24 16:38:23','2020-08-24 16:38:23','2020-10-07 12:39:12','2020-08-24 16:38:23',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_07.2020.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201007.pdf',134.10),(106,'Tussentijdse_Factuur_001205631039','','','2021-03-09 08:49:00',1,'2020-07-29 10:53:08','2020-07-29 10:53:08','2020-10-07 12:39:12','2020-07-29 10:53:08',21,0,5,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Tussentijdse_Factuur_001205631039.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201007.pdf',38.00),(107,'EN20-320559','','','2021-03-09 08:49:35',1,'2020-08-12 16:38:49','2020-08-12 16:38:49','2020-10-07 12:39:12','2020-08-12 16:38:49',21,0,16,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\EN20-320559.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201007.pdf',83.84),(108,'2020-017','Lassen','','2020-10-07 14:39:11',0,'2020-09-20 08:56:48','2020-09-20 09:03:26','2020-10-07 12:39:12','2020-10-07 12:27:57',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-017.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20201007.pdf',1265.00),(109,'2020-018','Workwatch Augustus','','2020-11-03 14:32:46',0,'2020-09-20 09:14:00','2020-09-20 09:16:36','2020-10-07 12:39:12','2020-11-03 14:32:47',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-018.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20201007.pdf',1355.00),(110,'ThomannInvoice','Presonus 68c audio interface','','2020-10-07 14:39:11',1,'2020-10-07 12:09:34','2020-10-07 12:09:34','2020-10-07 12:39:12','2020-10-07 12:09:34',21,0,20,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\ThomannInvoice.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201007.pdf',321.00),(111,'Coolblue_Factuur_1212231402','Docking station','','2020-10-07 14:39:11',1,'2020-10-07 11:56:57','2020-10-07 11:56:57','2020-10-07 12:39:12','2020-10-07 11:56:57',21,0,4,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Coolblue_Factuur_1212231402.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201007.pdf',279.00),(112,'Coolblue_Factuur_1251725702','HeadSet','','2020-10-07 14:39:11',1,'2020-10-07 11:58:14','2020-10-07 11:58:14','2020-10-07 12:39:12','2020-10-07 11:58:14',21,0,4,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Coolblue_Factuur_1251725702.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201007.pdf',53.00),(113,'2020-019','Workwatch Septembner','','2020-11-03 14:32:18',0,'2020-10-07 12:26:08','2020-10-07 12:37:20','2020-10-07 12:39:12','2020-11-03 14:32:18',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-019.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20201007.pdf',1839.00),(115,'2020-020','WorkWatch Oktober','','2020-12-27 13:15:15',0,'2020-11-03 14:31:40','2020-11-03 14:34:52','2020-10-12 12:10:06','2020-12-27 13:15:14',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-020.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20201124.pdf',3339.60),(116,'Verbruiksfactuur_003102158200','Pidpa verbuiksfactuur','','2020-11-24 09:36:15',1,'2020-10-12 12:10:06','2020-10-12 12:10:06','2020-10-12 12:10:06','2020-10-12 12:10:06',21,0,5,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Verbruiksfactuur_003102158200.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201124.pdf',46.34),(117,'7051354423','','','2020-11-24 09:36:15',1,'2020-11-04 08:49:16','2020-11-04 08:49:16','2020-10-12 12:10:06','2020-11-04 08:49:16',21,0,21,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\7051354423.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20201124.pdf',27.50),(118,'182201524375','Voorschot','','2021-01-18 10:16:34',1,'2020-11-24 09:52:33','2020-11-24 09:52:33','2021-01-18 10:19:00','2020-11-24 09:52:33',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182201524375.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20210118.pdf',127.62),(119,'2020-021','WorkWatch November','','2021-01-18 10:16:31',0,'2020-11-30 18:51:14','2020-11-30 19:01:28','2021-01-18 10:19:00','2020-12-27 13:15:18',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-021.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20210118.pdf',7502.00),(120,'2020-022','Lassen','','2021-01-18 10:16:31',0,'2020-11-30 19:02:11','2020-11-30 19:06:37','2021-01-18 10:19:00','2020-12-04 07:56:18',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-022.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20210118.pdf',1342.50),(121,'182074729722','Voorschot','','2021-01-18 10:16:34',1,'2020-11-30 11:22:51','2020-11-30 11:22:51','2021-01-18 10:19:00','2020-11-30 11:22:51',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182074729722.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20210118.pdf',127.62),(122,'2020-023','Workwatch December','','2021-01-18 10:16:31',0,'2020-12-27 13:07:51','2020-12-27 13:13:01','2021-01-18 10:19:00','2021-01-18 10:14:27',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2020-023.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouter_20210118.pdf',4162.40),(123,'thomannInvoice2','Straps, Jack cable','','2021-01-18 10:16:34',1,'2020-12-14 15:35:00','2020-12-14 15:35:00','2021-01-18 10:19:00','2020-12-14 15:35:00',21,0,20,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\thomannInvoice2.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20210118.pdf',179.94),(124,'Proximus_7053819149','','','2021-01-18 10:16:34',1,'2020-12-03 16:33:15','2020-12-03 16:33:15','2021-01-18 10:19:00','2020-12-03 16:33:15',21,0,21,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Proximus_7053819149.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20210118.pdf',27.50),(125,'AAFACT11.2020','Booky','','2021-01-18 10:16:34',1,'2020-12-27 13:16:00','2020-12-27 13:16:00','2021-01-18 10:19:00','2020-12-27 13:16:00',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Pagina\'s geëxtraheerd uit aafact11.2020.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20210118.pdf',42.35),(126,'Coolblue_factuur_1341624202','Stofzuiger prulleke','','2021-01-18 10:16:34',1,'2021-01-06 09:13:54','2021-01-06 09:13:54','2021-01-18 10:19:00','2021-01-06 09:13:54',21,0,4,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Coolblue_factuur_1341624202.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20210118.pdf',229.00),(127,'Coolblue_Factuur_1348849902','Muizen en audio kabels','','2021-01-18 10:16:34',1,'2021-01-06 13:33:00','2021-01-06 13:33:00','2021-01-18 10:19:00','2021-01-06 13:33:00',21,0,4,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Coolblue_Factuur_1348849902.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20210118.pdf',77.56),(128,'182114625075','Voorschot','','2021-01-18 10:16:34',1,'2021-01-13 12:14:40','2021-01-13 12:14:40','2021-01-18 10:19:00','2021-01-13 12:14:40',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182114625075.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20210118.pdf',127.62),(129,'12.2020','Boekhouder','','2021-01-18 10:16:34',1,'2021-01-06 15:16:00','2021-01-06 15:16:00','2021-01-18 10:19:00','2021-01-06 15:16:00',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_12.2020.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouter_20210118.pdf',233.93),(130,'2021-001','Workwatch Januari','','2021-03-30 07:48:55',0,'2021-02-01 18:01:27','2021-02-01 18:37:31','2021-03-30 07:48:56','2021-03-01 08:50:41',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-001.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouterCommV_20210330.pdf',4840.00),(131,'2021-002','Lassen','','2021-03-30 07:48:55',0,'2021-02-28 09:45:34','2021-03-15 08:38:29','2021-03-30 07:48:56','2021-03-01 08:50:35',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-002.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouterCommV_20210330.pdf',1555.00),(132,'2021-003','WorkWatch Februari','','2021-03-30 07:48:55',0,'2021-02-28 09:45:57','2021-02-28 09:57:07','2021-03-30 07:48:56','2021-03-29 08:28:55',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-003.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouterCommV_20210330.pdf',5517.60),(133,'Proximus_7128556278','Aanrekening','','2021-03-30 07:48:55',1,'2021-02-03 07:44:14','2021-02-03 07:44:14','2021-03-30 07:48:56','2021-02-03 07:44:14',21,0,21,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Proximus_7128556278.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',27.50),(134,'pidpa_001106375344','Voorschot','','2021-03-30 07:48:55',1,'2021-02-04 10:07:24','2021-02-04 10:07:24','2021-03-30 07:48:56','2021-02-04 10:07:24',21,0,5,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\pidpa_001106375344.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',39.00),(135,'Eneco_voorschot_182151655509','Voorschot','','2021-03-30 07:48:55',1,'2021-01-29 09:29:06','2021-01-29 09:29:06','2021-03-30 07:48:56','2021-01-29 09:29:06',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182151655509.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',127.62),(136,'Proximus_7130988054','','','2021-03-30 07:48:55',1,'2021-03-04 11:04:39','2021-03-04 11:04:39','2021-03-30 07:48:56','2021-03-04 11:04:39',21,0,21,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Proximus_7130988054.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',27.50),(137,'one_28482713','Domein vernieuwen','','2021-03-30 07:48:56',1,'2021-02-28 00:28:21','2021-02-28 00:28:21','2021-03-30 07:48:56','2021-03-09 09:01:52',21,0,15,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\one_28482713.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',79.70),(138,'Extracted pages from AAVF01.2021','Boekie','','2021-03-30 07:48:56',1,'2021-03-05 15:33:55','2021-03-05 15:33:55','2021-03-30 07:48:56','2021-03-09 08:45:49',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Extracted pages from AAVF01.2021.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',119.74),(139,'Eneco_voorschot_182161604078','voorschot','','2021-03-30 07:48:56',1,'2021-03-12 11:29:07','2021-03-12 11:29:07','2021-03-30 07:48:56','2021-03-12 11:29:07',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182161604078.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',127.62),(140,'boekhouder_751','','','2021-03-30 07:48:56',1,'2021-03-24 18:33:57','2021-03-24 18:33:57','2021-03-30 07:48:56','2021-03-24 18:33:57',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_751.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',973.82),(141,'boekhouder_11VF02.2021','','','2021-03-30 07:48:55',1,'2021-03-29 08:25:00','2021-03-29 08:25:00','2021-03-30 07:48:56','2021-03-29 08:25:00',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_11VF02.2021.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',42.35),(142,'2021-004','Lassen','','2021-04-12 10:49:32',0,'2021-03-29 08:27:01','2021-03-29 08:32:12','2021-03-30 07:48:56','2021-04-12 10:49:30',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-004.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouterCommV_20210330.pdf',560.00),(143,'2021-005','WorkWatch Maart','','2021-05-03 15:30:02',0,'2021-03-29 08:28:17','2021-03-29 08:32:26','2021-03-30 07:48:56','2021-05-03 15:30:00',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-005.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Verkoop_ThysWouterCommV_20210330.pdf',1839.20),(145,'GUNSBLAZE_Sponsering','Sponsering','','2021-03-30 07:48:55',1,'2021-03-30 06:57:08','2021-03-30 06:57:08','2021-03-30 07:48:56','2021-03-30 06:57:08',21,0,23,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\GUNSBLAZE_Sponsering.pdf','\\\\waldotron4000\\Zaakjes\\Facturen\\booky\\Aankoop_ThysWouterCommV_20210330.pdf',200.00),(146,'proximus_7133405909','Aanrekening','','2021-04-19 09:57:31',1,'2021-04-06 15:18:07','2021-04-06 15:18:07','2021-04-19 09:57:29','2021-04-06 15:18:07',21,0,21,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\proximus_7133405909.pdf','',27.50),(147,'182055042204','Voorschot','','2021-04-19 09:57:31',1,'2021-03-30 15:07:57','2021-03-30 15:07:57','2021-04-19 09:57:29','2021-03-30 15:07:57',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\document.pdf','',127.62),(148,'182055042204_','Voorschot','','2021-04-19 09:57:31',1,'2021-04-11 09:05:12','2021-04-11 09:05:12','2021-04-19 09:57:29','2021-04-11 09:05:12',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182055042204.pdf','',127.62),(149,'Coolblue_Factuur_1423246102','Beamer + HDMI kabel','','2021-04-19 09:57:31',1,'2021-04-13 06:19:54','2021-04-13 06:19:54','2021-04-19 09:57:29','2021-04-13 06:19:54',21,0,4,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Coolblue_Factuur_1423246102.pdf','',518.00),(150,'2021-006','WorkWatch April','','2021-07-16 15:25:38',0,'2021-05-03 15:22:06','2021-05-03 15:29:02','2021-07-16 15:25:37','2021-05-27 07:28:06',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-006.pdf','',871.20),(151,'2021-007','WorkWatch Mei','','2021-07-16 15:25:38',0,'2021-05-30 10:29:59','2021-05-30 10:35:26','2021-07-16 15:25:37','2021-07-16 15:20:34',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-007.pdf','',4259.20),(152,'Tussentijdse_factuur_001403820662','','','2021-07-16 15:25:38',1,'2021-04-30 07:06:16','2021-04-30 07:06:16','2021-07-16 15:25:37','2021-04-30 07:06:16',21,0,5,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Tussentijdse_factuur_001403820662.pdf','',39.00),(153,'proximus_7138849402','','','2021-07-16 15:25:38',1,'2021-06-07 10:37:20','2021-06-07 10:37:20','2021-07-16 15:25:37','2021-06-07 10:37:20',21,0,21,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\proximus_7138849402.pdf','',7.50),(154,'proximus_7136446091-1','','','2021-07-16 15:25:38',1,'2021-05-10 08:24:58','2021-05-10 08:24:58','2021-07-16 15:25:37','2021-05-10 08:24:58',21,0,21,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\proximus_7136446091-1.pdf','',7.50),(155,'Devexpress_renew_P2710110','','','2021-07-16 15:25:39',1,'2021-05-30 10:23:34','2021-05-30 10:23:34','2021-07-16 15:25:37','2021-05-30 10:23:34',21,0,22,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Devexpress_renew_P2710110.pdf','',449.99),(156,'eneco_voorschot_182141674466','','','2021-07-16 15:25:39',1,'2021-04-30 07:08:15','2021-04-30 07:08:15','2021-07-16 15:25:37','2021-04-30 07:08:15',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\eneco_voorschot_182141674466.pdf','',127.62),(157,'Eneco_voorschot_182025795013','','','2021-07-16 15:25:39',1,'2021-05-31 10:09:32','2021-05-31 10:09:32','2021-07-16 15:25:37','2021-05-31 10:09:32',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182025795013.pdf','',127.62),(158,'Boekhouder_05.2021VF','','','2021-07-16 15:25:39',1,'2021-05-31 15:50:00','2021-05-31 15:50:00','2021-07-16 15:25:37','2021-05-31 15:50:00',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Boekhouder_05.2021VF.pdf','',229.65),(159,'bedrijfsbelasting_0737794569','','','2021-07-16 15:25:39',1,'2021-06-08 11:08:13','2021-06-08 11:08:13','2021-07-16 15:25:37','2021-06-08 11:08:13',21,0,1,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\bedrijfsbelasting_0737794569.pdf','',101.00),(160,'Microsoft-account_8647209237','','','2021-07-16 15:25:39',1,'2021-04-20 06:53:36','2021-04-20 06:53:36','2021-07-16 15:25:37','2021-04-20 06:53:36',21,0,24,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Microsoft-account_8647209237.pdf','',99.00),(161,'182124879952','ENECO_VOORSCHOT','','2021-07-16 15:25:39',1,'2021-06-29 10:10:24','2021-06-29 10:10:24','2021-07-16 15:25:37','2021-06-29 10:10:24',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182124879952.pdf','',127.62),(162,'boekhouder_385','','','2021-07-16 15:25:38',1,'2021-07-05 08:54:02','2021-07-05 08:54:02','2021-07-16 15:25:37','2021-07-05 08:54:02',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_385.pdf','',90.75),(163,'boekhouder_2592','','','2021-07-16 15:25:38',1,'2021-07-05 08:54:42','2021-07-05 08:54:42','2021-07-16 15:25:37','2021-07-05 08:54:42',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_2592.pdf','',92.52),(164,'2021-008','Plaatsen Plopsaland','','2021-08-02 15:10:37',0,'2021-07-16 15:14:39','2021-07-16 15:19:58','2021-07-16 15:25:37','2021-08-02 15:10:35',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-008.pdf','',2390.00),(165,'pidpa_001403921422','Pidpa voorschot','','2021-10-01 12:49:07',1,'2021-07-29 15:40:20','2021-07-29 15:40:20','2021-10-01 12:49:07','2021-07-29 15:40:20',21,0,5,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\pidpa_001403921422.pdf','',39.00),(166,'2021-009','Workwatch Juli','','2021-10-01 12:49:07',0,'2021-08-02 15:07:10','2021-08-02 15:09:53','2021-10-01 12:49:07','2021-09-02 10:00:12',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-009.pdf','',3339.60),(167,'2021-010','Workwatch Augustus','','2021-10-01 12:49:07',0,'2021-09-02 10:00:20','2021-09-02 10:03:45','2021-10-01 12:49:07','1989-12-31 23:00:00',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-010.pdf','',1790.80),(168,'2021-011','Lassen','','2021-10-01 12:49:07',0,'2021-09-02 10:03:59','2021-09-02 10:06:37','2021-10-01 12:49:07','2021-10-01 12:29:01',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-011.pdf','',372.50),(169,'proximus_211500116791','','','2021-10-01 12:49:07',1,'2021-08-31 10:03:40','2021-08-31 10:03:40','2021-10-01 12:49:07','2021-08-31 10:03:40',21,0,21,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\proximus_211500116791.pdf','',63.37),(170,'proximus_7143615828','','','2021-10-01 12:49:07',1,'2021-08-16 10:16:11','2021-08-16 10:16:11','2021-10-01 12:49:07','2021-08-16 10:16:11',21,0,21,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\proximus_7143615828.pdf','',7.50),(171,'Eneco_voorschot_182114836106','','','2021-10-01 12:49:07',1,'2021-08-30 09:54:10','2021-08-30 09:54:10','2021-10-01 12:49:07','2021-08-30 09:54:10',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182114836106.pdf','',127.62),(172,'boekhouder_2064','','','2021-10-01 12:49:07',1,'2021-09-07 14:40:00','2021-09-07 14:40:00','2021-10-01 12:49:07','2021-09-07 14:40:00',21,0,17,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\boekhouder_2064.pdf','',33.28),(173,'Eneco_jaarlijks_141030873697','','','2021-10-01 12:49:07',1,'2021-09-22 13:12:19','2021-09-22 13:12:19','2021-10-01 12:49:07','2021-09-22 13:12:19',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_jaarlijks_141030873697.pdf','',354.60),(174,'air-bnb_01-11-2021','Overnachting','','2021-10-01 12:49:07',1,'2021-10-01 12:36:28','2021-10-01 12:36:28','2021-10-01 12:49:07','2021-10-01 12:36:28',21,0,1,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\air-bnb_01-11-2021.pdf','',98.01),(175,'Eneco_voorschot_182025836789','','','2021-10-01 12:49:07',1,'2021-10-01 12:38:09','2021-10-01 12:38:09','2021-10-01 12:49:07','2021-10-01 12:38:09',21,0,6,'\\\\waldotron4000\\Zaakjes\\Facturen\\betaald\\Eneco_voorschot_182025836789.pdf','',127.62),(176,'2021-012','Lassen','','2021-10-01 12:49:07',0,'2021-10-01 12:40:27','2021-10-01 12:42:40','2021-10-01 12:49:07','1989-12-31 23:00:00',0,1,3,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-012.pdf','',700.00),(177,'2021-013','Workwatch September','','2021-10-01 12:49:07',0,'2021-10-01 12:42:45','2021-10-01 12:47:04','2021-10-01 12:49:07','1989-12-31 23:00:00',21,0,10,'\\\\waldotron4000\\Zaakjes\\Facturen\\2021-013.pdf','',4356.00);
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
    website varchar(128),
    defaultUnitPrice decimal(10,2),
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
        phone,
        website,
        defaultUnitPrice)
	 VALUES (
		code,
		description,
        info,
        now(),
        addressLine1,
        addressLine2,
        vatNumber,
        email,
        phone,
        website,
        defaultUnitPrice);
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
    website varchar(128),
    defaultUnitPrice decimal(10,2),
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
        phone = phone,
        website = website,
        defaultUnitPrice = defaultUnitPrice
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

-- Dump completed on 2021-10-11 18:50:36
