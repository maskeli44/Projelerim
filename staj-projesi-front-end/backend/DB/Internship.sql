CREATE DATABASE  IF NOT EXISTS `internship` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `internship`;
-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: internship
-- ------------------------------------------------------
-- Server version	8.0.29

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
-- Table structure for table `authorization`
--

DROP TABLE IF EXISTS `authorization`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `authorization` (
  `id` int NOT NULL AUTO_INCREMENT,
  `type` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authorization`
--

LOCK TABLES `authorization` WRITE;
/*!40000 ALTER TABLE `authorization` DISABLE KEYS */;
INSERT INTO `authorization` VALUES (1,'student'),(2,'teacher');
/*!40000 ALTER TABLE `authorization` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `company`
--

DROP TABLE IF EXISTS `company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `company` (
  `id` int NOT NULL AUTO_INCREMENT,
  `company_name` varchar(45) DEFAULT NULL,
  `sector` varchar(255) DEFAULT NULL,
  `tax_number` varchar(255) DEFAULT NULL,
  `phone_no` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `web_address` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `company`
--

LOCK TABLES `company` WRITE;
/*!40000 ALTER TABLE `company` DISABLE KEYS */;
INSERT INTO `company` VALUES (1,'turk','türk','1231231','05453336677','turkcell@turkey.com','http://turkcell.turkey.com','turkey'),(2,'vodafone','vodafone','222233','05423654345','vodafone@istanbul.com','http://vodafone.com','istanbul'),(3,'turktelekom','turktelekom','333344','05429658785','ttnet@istanbul.com','http://ttnet.com','istanbul');
/*!40000 ALTER TABLE `company` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `internship`
--

DROP TABLE IF EXISTS `internship`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `internship` (
  `id` int NOT NULL AUTO_INCREMENT,
  `student_id` int DEFAULT NULL,
  `company_id` int DEFAULT NULL,
  `start_date` varchar(255) DEFAULT NULL,
  `end_date` datetime DEFAULT NULL,
  `number_of_days` int DEFAULT NULL,
  `chief` varchar(255) DEFAULT NULL,
  `subject` varchar(255) DEFAULT NULL,
  `appeal_form` varchar(255) DEFAULT NULL,
  `commission_head_id` int DEFAULT NULL,
  `commission_member1_id` int DEFAULT NULL,
  `commission_member2_id` int DEFAULT NULL,
  `internship_book` varchar(255) DEFAULT NULL,
  `accepted_number_of_days` int DEFAULT NULL,
  `commission_approval` tinyint(1) DEFAULT '0',
  `commission_accepted_appeal_form` varchar(255) DEFAULT NULL,
  `department` varchar(45) NOT NULL,
  `engineers_number` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_istudent_id_idx` (`student_id`),
  KEY `fk_company_id_idx` (`company_id`),
  KEY `fk_commission_president_id_idx` (`commission_head_id`),
  KEY `fk_commission_member1_id_idx` (`commission_member1_id`),
  KEY `fk_commission_member2_id_idx` (`commission_member2_id`),
  CONSTRAINT `fk_commission_head_id` FOREIGN KEY (`commission_head_id`) REFERENCES `teacher` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_commission_member1_id` FOREIGN KEY (`commission_member1_id`) REFERENCES `teacher` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_commission_member2_id` FOREIGN KEY (`commission_member2_id`) REFERENCES `teacher` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_company_id` FOREIGN KEY (`company_id`) REFERENCES `company` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_student_id` FOREIGN KEY (`student_id`) REFERENCES `student` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `internship`
--

LOCK TABLES `internship` WRITE;
/*!40000 ALTER TABLE `internship` DISABLE KEYS */;
INSERT INTO `internship` VALUES (1,22,1,'2000-08-08','2000-09-09 00:00:00',30,'sam','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(2,12,2,'2000-08-08','2000-09-09 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(3,19,3,'2000-08-08','2000-09-09 00:00:00',30,'seren','software','../uploads/form',1,2,3,'../uploads/books',23,0,'../uploads/accepted_forms','',''),(4,4,1,'2022-06-20','2022-08-08 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',30,1,'../uploads/accepted_forms','',''),(5,5,1,'2000-08-08','2000-09-09 00:00:00',30,'sam','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(6,8,2,'2000-08-08','2000-09-09 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(7,7,3,'2000-08-08','2000-09-09 00:00:00',30,'sam','software','../uploads/form',1,2,3,'../uploads/books',23,0,'../uploads/accepted_forms','',''),(8,10,1,'2022-06-20','2022-08-08 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',30,1,'../uploads/accepted_forms','',''),(9,30,1,'2000-08-08','2000-09-09 00:00:00',30,'seren','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(10,28,2,'2000-08-08','2000-09-09 00:00:00',30,'seren','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(11,27,3,'2000-08-08','2000-09-09 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',23,0,'../uploads/accepted_forms','',''),(12,26,1,'2022-06-20','2022-08-08 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',30,1,'../uploads/accepted_forms','',''),(13,1,1,'2000-08-08','2000-09-09 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(14,2,2,'2000-08-08','2000-09-09 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(15,3,3,'2000-08-08','2000-09-09 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',23,0,'../uploads/accepted_forms','',''),(16,6,1,'2022-06-20','2022-08-08 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',30,1,'../uploads/accepted_forms','',''),(17,20,1,'2000-08-08','2000-09-09 00:00:00',30,'sam','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(18,9,2,'2000-08-08','2000-09-09 00:00:00',30,'sam','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(19,11,3,'2000-08-08','2000-09-09 00:00:00',30,'sam','software','../uploads/form',1,2,3,'../uploads/books',23,0,'../uploads/accepted_forms','',''),(20,13,1,'2022-06-20','2022-08-08 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',30,1,'../uploads/accepted_forms','',''),(21,15,1,'2000-08-08','2000-09-09 00:00:00',30,'seren','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(22,14,2,'2000-08-08','2000-09-09 00:00:00',30,'seren','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(23,16,3,'2000-08-08','2000-09-09 00:00:00',30,'seren','software','../uploads/form',1,2,3,'../uploads/books',23,0,'../uploads/accepted_forms','',''),(24,23,1,'2022-06-20','2022-08-08 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',30,1,'../uploads/accepted_forms','',''),(25,17,3,'2000-08-08','2000-09-09 00:00:00',30,'sam','software','../uploads/form',1,2,3,'../uploads/books',23,0,'../uploads/accepted_forms','',''),(26,18,1,'2022-06-20','2022-08-08 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',30,1,'../uploads/accepted_forms','',''),(27,24,1,'2000-08-08','2000-09-09 00:00:00',30,'sam','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(28,21,2,'2000-08-08','2000-09-09 00:00:00',30,'seren','software','../uploads/form',1,2,3,'../uploads/books',23,1,'../uploads/accepted_forms','',''),(29,25,3,'2000-08-08','2000-09-09 00:00:00',30,'seren','software','../uploads/form',1,2,3,'../uploads/books',23,0,'../uploads/accepted_forms','',''),(30,29,1,'2022-06-20','2022-08-08 00:00:00',30,'jhon','software','../uploads/form',1,2,3,'../uploads/books',30,1,'../uploads/accepted_forms','','');
/*!40000 ALTER TABLE `internship` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `id` int NOT NULL AUTO_INCREMENT,
  `student_no` varchar(45) DEFAULT NULL,
  `firstname` varchar(255) DEFAULT NULL,
  `lastname` varchar(255) DEFAULT NULL,
  `tc_no` varchar(45) DEFAULT NULL,
  `phone_no` varchar(45) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `nation` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (1,'1903332102','dexter','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(2,'209111222','bob','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(3,'309111222','alex','white','66622233444','05443332288','alex@white.com','london','england'),(4,'1903332102','james','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(5,'209111222','anna','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(6,'309111222','pop','white','66622233444','05443332288','alex@white.com','london','england'),(7,'1903332102','alice','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(8,'2091112223','rudy','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(9,'3091112223','celen','white','66622233444','05443332288','alex@white.com','london','england'),(10,'1903332100','adam','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(11,'2091112894','lena','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(12,'3091112244','harley','white','66622233444','05443332288','alex@white.com','london','england'),(13,'1903332899','rock','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(14,'2091112228','george','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(15,'3091112444','kai','white','66622233444','05443332288','alex@white.com','london','england'),(16,'1903332300','jennie','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(17,'2091112773','lisa','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(18,'3091110023','sharley','white','66622233444','05443332288','alex@white.com','london','england'),(19,'1903332101','sherlok','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(20,'2098889921','robert','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(21,'3092223321','carl','white','66622233444','05443332288','alex@white.com','london','england'),(22,'1903323122','jimmy','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(23,'2099902321','falcon','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(24,'3091331322','chris','white','66622233444','05443332288','alex@white.com','london','england'),(25,'1901331232','ashley','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(26,'2091313131','selena','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(27,'3091113113','taylor','white','66622233444','05443332288','alex@white.com','london','england'),(28,'1903332213','emma','smith','79334323242','980022921','john@smith.com','urfa','turkey'),(29,'2091313344','tara','marley','55522233444','05443332277','bob@marley.com','vegas','america'),(30,'3091313134','max','white','66622233444','05443332288','alex@white.com','london','england'),(31,'1246885433','Amin','Feryadi','25614435244','05317481665','aDeryad@gamail.com','urfa','Iran');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacher`
--

DROP TABLE IF EXISTS `teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teacher` (
  `id` int NOT NULL AUTO_INCREMENT,
  `registration_no` varchar(45) DEFAULT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `position` varchar(45) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacher`
--

LOCK TABLES `teacher` WRITE;
/*!40000 ALTER TABLE `teacher` DISABLE KEYS */;
INSERT INTO `teacher` VALUES (1,'1903332102','undefined','white','member','emily@white.com'),(2,'444222333','arthur','morgan','member','arthur@morgon.com'),(3,'555222333','harold','finch','member','harold@finch.com');
/*!40000 ALTER TABLE `teacher` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-08-01 13:24:56

--INTERNSHIP PEROIOD TABLE ADDED !!!!!!!


CREATE TABLE `internship_period` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `start_date` VARCHAR(45) NULL,
  `end_date` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));

INSERT INTO `internship`.`internship_period` (`name`, `start_date`, `end_date`) VALUES ('2021_donem_1', '2021-01-01', '2021-01-15');
INSERT INTO `internship`.`internship_period` (`name`, `start_date`, `end_date`) VALUES ('2021_donem_2', '2021-07-01', '2021-07-15');
INSERT INTO `internship`.`internship_period` (`name`, `start_date`, `end_date`) VALUES ('2022_donem_1', '2022-01-01', '2022-01-15');
INSERT INTO `internship`.`internship_period` (`name`, `start_date`, `end_date`) VALUES ('2022_donem_2', '2022-07-01', '2022-07-15');