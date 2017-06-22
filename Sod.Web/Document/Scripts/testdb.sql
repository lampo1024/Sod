/*
SQLyog Ultimate v12.3.3 (64 bit)
MySQL - 5.5.53 : Database - test
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`test` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `test`;

/*Table structure for table `address` */

DROP TABLE IF EXISTS `address`;

CREATE TABLE `address` (
  `Id` int(4) NOT NULL AUTO_INCREMENT,
  `PersonId` int(6) DEFAULT '0',
  `Line1` varchar(255) DEFAULT '',
  `Line2` varchar(255) DEFAULT '',
  `ZipCode` varchar(20) DEFAULT '',
  `State` varchar(100) DEFAULT '',
  `City` varchar(100) DEFAULT '',
  `Country` varchar(255) DEFAULT '',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `address` */

insert  into `address`(`Id`,`PersonId`,`Line1`,`Line2`,`ZipCode`,`State`,`City`,`Country`) values 
(1,1,'Chongqing','Chongqing','400000','CQ','CQ','China');

/*Table structure for table `person` */

DROP TABLE IF EXISTS `person`;

CREATE TABLE `person` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `DateCreated` datetime DEFAULT NULL,
  `Active` tinyint(1) DEFAULT '1',
  `ModifiedOn` datetime DEFAULT NULL,
  `Age` int(2) DEFAULT '0',
  `Salary` decimal(12,2) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

/*Data for the table `person` */

insert  into `person`(`Id`,`FirstName`,`LastName`,`DateCreated`,`Active`,`ModifiedOn`,`Age`,`Salary`) values 
(1,'Steph','Curry','2017-05-23 10:37:15',1,'2017-06-12 10:08:04',NULL,NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
