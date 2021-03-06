CREATE DATABASE  IF NOT EXISTS `nomina` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `nomina`;
-- MySQL dump 10.13  Distrib 5.7.30, for Linux (x86_64)
--
-- Host: localhost    Database: nomina
-- ------------------------------------------------------
-- Server version	5.7.30-0ubuntu0.18.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Area`
--

DROP TABLE IF EXISTS `Area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Area` (
  `IdArea` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `IdDepartamento` int(11) NOT NULL,
  PRIMARY KEY (`IdArea`),
  KEY `IdDepartamento_idx` (`IdDepartamento`),
  CONSTRAINT `IdDepartamento` FOREIGN KEY (`IdDepartamento`) REFERENCES `Departamento` (`IdDepartamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Area`
--

LOCK TABLES `Area` WRITE;
/*!40000 ALTER TABLE `Area` DISABLE KEYS */;
INSERT INTO `Area` VALUES (1,'Soporte',1);
/*!40000 ALTER TABLE `Area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Cargo`
--

DROP TABLE IF EXISTS `Cargo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Cargo` (
  `IdCargo` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`IdCargo`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Cargo`
--

LOCK TABLES `Cargo` WRITE;
/*!40000 ALTER TABLE `Cargo` DISABLE KEYS */;
INSERT INTO `Cargo` VALUES (1,'Ingeniero Informatico');
/*!40000 ALTER TABLE `Cargo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Contrato`
--

DROP TABLE IF EXISTS `Contrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Contrato` (
  `IdContrato` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(150) NOT NULL,
  `IdTipo_Contrato` int(11) NOT NULL,
  `IdTurno` int(11) NOT NULL,
  PRIMARY KEY (`IdContrato`),
  KEY `IdTipo_Contrato_idx` (`IdTipo_Contrato`),
  KEY `IdTurno_idx` (`IdTurno`),
  CONSTRAINT `IdTipo_Contrato` FOREIGN KEY (`IdTipo_Contrato`) REFERENCES `TipoContrato` (`IdTipo_Contrato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdTurno2` FOREIGN KEY (`IdTurno`) REFERENCES `Turno` (`IdTurno`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Contrato`
--

LOCK TABLES `Contrato` WRITE;
/*!40000 ALTER TABLE `Contrato` DISABLE KEYS */;
INSERT INTO `Contrato` VALUES (1,'Pasantia universitaria',1,1),(2,'Pasantia',1,1),(3,'Pasantia',1,1),(4,'Pasantia',1,1),(5,'Por proyecto',1,1);
/*!40000 ALTER TABLE `Contrato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Deducciones`
--

DROP TABLE IF EXISTS `Deducciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Deducciones` (
  `IdDeducciones` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `Descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`IdDeducciones`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Deducciones`
--

LOCK TABLES `Deducciones` WRITE;
/*!40000 ALTER TABLE `Deducciones` DISABLE KEYS */;
INSERT INTO `Deducciones` VALUES (1,'Prestamos','Deduccion de prestamos a la empresa'),(2,'Desgasto','Uso de utilidades');
/*!40000 ALTER TABLE `Deducciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Departamento`
--

DROP TABLE IF EXISTS `Departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Departamento` (
  `IdDepartamento` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  PRIMARY KEY (`IdDepartamento`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Departamento`
--

LOCK TABLES `Departamento` WRITE;
/*!40000 ALTER TABLE `Departamento` DISABLE KEYS */;
INSERT INTO `Departamento` VALUES (1,'Informatica');
/*!40000 ALTER TABLE `Departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Empleado`
--

DROP TABLE IF EXISTS `Empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Empleado` (
  `IdEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(20) NOT NULL,
  `Apellidos` varchar(20) NOT NULL,
  `Cedula` varchar(17) NOT NULL,
  `NivelEstudio` varchar(30) NOT NULL,
  `INSS_Empleado` varchar(9) DEFAULT NULL,
  `Fecha_Contratacion` date NOT NULL,
  `FechaDeBajaEmpleado` date DEFAULT NULL,
  `IdEstado` int(11) NOT NULL,
  `SeguroEmpleado` varchar(1) DEFAULT NULL,
  `Direccion` varchar(50) NOT NULL,
  `MotivoBaja` varchar(45) DEFAULT NULL,
  `SalarioEmpleado` double NOT NULL,
  `IdPlanilla` int(11) NOT NULL,
  `IdArea` int(11) NOT NULL,
  `IdContrato` int(11) NOT NULL,
  `IdSucural` int(11) NOT NULL,
  `IdCargo` int(11) NOT NULL,
  PRIMARY KEY (`IdEmpleado`),
  KEY `IdPlanilla_idx` (`IdPlanilla`),
  KEY `IdCargo_idx` (`IdCargo`),
  KEY `IdEstado_idx` (`IdEstado`),
  KEY `IdArea_idx` (`IdArea`),
  KEY `IdSucursal_idx` (`IdSucural`),
  KEY `IdContrato_idx` (`IdContrato`),
  CONSTRAINT `IdArea` FOREIGN KEY (`IdArea`) REFERENCES `Area` (`IdArea`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdCargo` FOREIGN KEY (`IdCargo`) REFERENCES `Cargo` (`IdCargo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdContrato` FOREIGN KEY (`IdContrato`) REFERENCES `Contrato` (`IdContrato`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdEstado` FOREIGN KEY (`IdEstado`) REFERENCES `Estado` (`IdEstado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdPlanilla` FOREIGN KEY (`IdPlanilla`) REFERENCES `Planilla` (`IdPlanilla`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdSucursal` FOREIGN KEY (`IdSucural`) REFERENCES `Sucursal` (`IdSucursal`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Empleado`
--

LOCK TABLES `Empleado` WRITE;
/*!40000 ALTER TABLE `Empleado` DISABLE KEYS */;
INSERT INTO `Empleado` VALUES (1,'Cleymer','Zavala','2410204001001k','Universtitario','','2017-05-02',NULL,1,NULL,'Jinotega','',2000.05,1,1,1,1,1),(2,'Engell','Zavala','1111K','Secundaria',NULL,'2017-06-02',NULL,1,NULL,'Pantasma',NULL,12000,1,1,2,1,1),(3,'Cleymer','Tinoco','4','Universitario',NULL,'2018-05-15',NULL,1,NULL,'Managua',NULL,21000,1,1,3,1,1),(4,'Miguel','Solis','24242','Universitario',NULL,'2018-05-15',NULL,1,NULL,'Managua',NULL,5000,1,1,1,1,1),(5,'David','Saenz','159874','Primaria',NULL,'2020-02-12',NULL,1,NULL,'Masaya',NULL,500,1,1,2,2,1),(6,'Jose','Cruz','12345JC','Secundaria','159DD','2020-05-21',NULL,1,NULL,'Jinotega',NULL,11000,1,1,4,2,1),(7,'Juana','La Cubana','42069XS','Secundaria','12DDD','2020-05-21',NULL,1,NULL,'Cuba',NULL,8000,1,1,5,5,1);
/*!40000 ALTER TABLE `Empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Empresa`
--

DROP TABLE IF EXISTS `Empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Empresa` (
  `NumeroRUC` int(11) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Telefono` varchar(45) NOT NULL,
  `Direccion` varchar(45) NOT NULL,
  PRIMARY KEY (`NumeroRUC`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Empresa`
--

LOCK TABLES `Empresa` WRITE;
/*!40000 ALTER TABLE `Empresa` DISABLE KEYS */;
INSERT INTO `Empresa` VALUES (1,'I.T Corporation','88882222','Mulucucu'),(2,'Maxi Pali','88884444','Matagalpa'),(3,'Soppexcca','89452312','Jinotega');
/*!40000 ALTER TABLE `Empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Estado`
--

DROP TABLE IF EXISTS `Estado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Estado` (
  `IdEstado` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(20) NOT NULL,
  PRIMARY KEY (`IdEstado`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Estado`
--

LOCK TABLES `Estado` WRITE;
/*!40000 ALTER TABLE `Estado` DISABLE KEYS */;
INSERT INTO `Estado` VALUES (1,'Activo');
/*!40000 ALTER TABLE `Estado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Extra`
--

DROP TABLE IF EXISTS `Extra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Extra` (
  `IdExtra` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(20) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`IdExtra`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Extra`
--

LOCK TABLES `Extra` WRITE;
/*!40000 ALTER TABLE `Extra` DISABLE KEYS */;
INSERT INTO `Extra` VALUES (1,'Salud','Extra para medicamentos'),(2,'Horas Extras','Extra fuera de horario laboral');
/*!40000 ALTER TABLE `Extra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Horario`
--

DROP TABLE IF EXISTS `Horario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Horario` (
  `IdHorario` int(11) NOT NULL AUTO_INCREMENT,
  `HorarioEntrada` varchar(45) NOT NULL,
  `HorarioSalida` varchar(45) NOT NULL,
  `IdTurno` int(11) NOT NULL,
  PRIMARY KEY (`IdHorario`),
  KEY `IdTurno_idx` (`IdTurno`),
  CONSTRAINT `IdTurno1` FOREIGN KEY (`IdTurno`) REFERENCES `Turno` (`IdTurno`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Horario`
--

LOCK TABLES `Horario` WRITE;
/*!40000 ALTER TABLE `Horario` DISABLE KEYS */;
/*!40000 ALTER TABLE `Horario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Moneda`
--

DROP TABLE IF EXISTS `Moneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Moneda` (
  `IdMoneda` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(30) NOT NULL,
  `Cambio` double NOT NULL,
  PRIMARY KEY (`IdMoneda`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Moneda`
--

LOCK TABLES `Moneda` WRITE;
/*!40000 ALTER TABLE `Moneda` DISABLE KEYS */;
INSERT INTO `Moneda` VALUES (1,'Dolar',33.8);
/*!40000 ALTER TABLE `Moneda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Opciones`
--

DROP TABLE IF EXISTS `Opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Opciones` (
  `IdOpciones` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(15) NOT NULL,
  `Formulario` varchar(50) NOT NULL,
  PRIMARY KEY (`IdOpciones`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Opciones`
--

LOCK TABLES `Opciones` WRITE;
/*!40000 ALTER TABLE `Opciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `Opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Pago`
--

DROP TABLE IF EXISTS `Pago`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Pago` (
  `IdPago` int(11) NOT NULL AUTO_INCREMENT,
  `IdEmpleado` int(11) NOT NULL,
  `Monto` double NOT NULL,
  `IdMoneda` int(11) NOT NULL,
  `Fecha_Pago` date NOT NULL,
  PRIMARY KEY (`IdPago`),
  KEY `IdEmpleado_idx` (`IdEmpleado`),
  KEY `IdMoneda_idx` (`IdMoneda`),
  CONSTRAINT `IdEmpleado2` FOREIGN KEY (`IdEmpleado`) REFERENCES `Empleado` (`IdEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdMoneda` FOREIGN KEY (`IdMoneda`) REFERENCES `Moneda` (`IdMoneda`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Pago`
--

LOCK TABLES `Pago` WRITE;
/*!40000 ALTER TABLE `Pago` DISABLE KEYS */;
INSERT INTO `Pago` VALUES (1,1,2000.05,1,'2020-05-05'),(2,2,12000,1,'2020-05-05'),(3,3,21000,1,'2020-05-25'),(4,6,11000,1,'2020-05-25');
/*!40000 ALTER TABLE `Pago` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Pago_Deduccion`
--

DROP TABLE IF EXISTS `Pago_Deduccion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Pago_Deduccion` (
  `IdEmpleado_Deduccion` int(11) NOT NULL AUTO_INCREMENT,
  `IdPago` int(11) NOT NULL,
  `IdDeducciones` int(11) NOT NULL,
  `Monto` double NOT NULL,
  PRIMARY KEY (`IdEmpleado_Deduccion`),
  KEY `IdDeducciones_idx` (`IdDeducciones`),
  KEY `IdPago_idx` (`IdPago`),
  CONSTRAINT `IdDeducciones` FOREIGN KEY (`IdDeducciones`) REFERENCES `Deducciones` (`IdDeducciones`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdPago2` FOREIGN KEY (`IdPago`) REFERENCES `Pago` (`IdPago`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Pago_Deduccion`
--

LOCK TABLES `Pago_Deduccion` WRITE;
/*!40000 ALTER TABLE `Pago_Deduccion` DISABLE KEYS */;
INSERT INTO `Pago_Deduccion` VALUES (1,1,1,120),(2,4,2,100);
/*!40000 ALTER TABLE `Pago_Deduccion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Pago_Extra`
--

DROP TABLE IF EXISTS `Pago_Extra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Pago_Extra` (
  `IdEmpleado_Extra` int(11) NOT NULL AUTO_INCREMENT,
  `IdPago` int(11) NOT NULL,
  `IdExtra` int(11) NOT NULL,
  `Monto` double NOT NULL,
  PRIMARY KEY (`IdEmpleado_Extra`),
  KEY `IdExtra_idx` (`IdExtra`),
  KEY `IdPago_idx` (`IdPago`),
  CONSTRAINT `IdExtra` FOREIGN KEY (`IdExtra`) REFERENCES `Extra` (`IdExtra`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdPago1` FOREIGN KEY (`IdPago`) REFERENCES `Pago` (`IdPago`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Pago_Extra`
--

LOCK TABLES `Pago_Extra` WRITE;
/*!40000 ALTER TABLE `Pago_Extra` DISABLE KEYS */;
INSERT INTO `Pago_Extra` VALUES (1,1,1,200),(2,1,2,100),(3,4,1,100),(4,4,2,50);
/*!40000 ALTER TABLE `Pago_Extra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Planilla`
--

DROP TABLE IF EXISTS `Planilla`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Planilla` (
  `IdPlanilla` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo_Planilla` varchar(30) NOT NULL,
  PRIMARY KEY (`IdPlanilla`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Planilla`
--

LOCK TABLES `Planilla` WRITE;
/*!40000 ALTER TABLE `Planilla` DISABLE KEYS */;
INSERT INTO `Planilla` VALUES (1,'Pago');
/*!40000 ALTER TABLE `Planilla` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Rol`
--

DROP TABLE IF EXISTS `Rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Rol` (
  `IdRol` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(15) NOT NULL,
  PRIMARY KEY (`IdRol`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Rol`
--

LOCK TABLES `Rol` WRITE;
/*!40000 ALTER TABLE `Rol` DISABLE KEYS */;
INSERT INTO `Rol` VALUES (1,'Empleado'),(2,'Admin'),(3,'Jefe');
/*!40000 ALTER TABLE `Rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Rol_Opciones`
--

DROP TABLE IF EXISTS `Rol_Opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Rol_Opciones` (
  `IdRol_Opciones` int(11) NOT NULL AUTO_INCREMENT,
  `IdRol` int(11) NOT NULL,
  `IdOpciones` int(11) NOT NULL,
  `Habilitado` varchar(10) NOT NULL,
  `Fecha_Creacion` date NOT NULL,
  PRIMARY KEY (`IdRol_Opciones`),
  KEY `IdRol_idx` (`IdRol`),
  KEY `IdOpciones_idx` (`IdOpciones`),
  CONSTRAINT `IdOpciones` FOREIGN KEY (`IdOpciones`) REFERENCES `Opciones` (`IdOpciones`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdRol1` FOREIGN KEY (`IdRol`) REFERENCES `Rol` (`IdRol`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Rol_Opciones`
--

LOCK TABLES `Rol_Opciones` WRITE;
/*!40000 ALTER TABLE `Rol_Opciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `Rol_Opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Sucursal`
--

DROP TABLE IF EXISTS `Sucursal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Sucursal` (
  `IdSucursal` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Extension` varchar(45) NOT NULL,
  `NumeroRUC` int(11) NOT NULL,
  PRIMARY KEY (`IdSucursal`),
  KEY `NumeroRUC_idx` (`NumeroRUC`),
  CONSTRAINT `NumeroRUC` FOREIGN KEY (`NumeroRUC`) REFERENCES `Empresa` (`NumeroRUC`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Sucursal`
--

LOCK TABLES `Sucursal` WRITE;
/*!40000 ALTER TABLE `Sucursal` DISABLE KEYS */;
INSERT INTO `Sucursal` VALUES (1,'Soporte Tecnico','1',1),(2,'Contaduria','1',1),(3,'Servidores','1',3),(4,'Carga','1',3),(5,'Encargos','1',2),(6,'Jinotexas','1',2);
/*!40000 ALTER TABLE `Sucursal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `TipoContrato`
--

DROP TABLE IF EXISTS `TipoContrato`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `TipoContrato` (
  `IdTipo_Contrato` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(120) NOT NULL,
  PRIMARY KEY (`IdTipo_Contrato`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `TipoContrato`
--

LOCK TABLES `TipoContrato` WRITE;
/*!40000 ALTER TABLE `TipoContrato` DISABLE KEYS */;
INSERT INTO `TipoContrato` VALUES (1,'Pasante');
/*!40000 ALTER TABLE `TipoContrato` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Turno`
--

DROP TABLE IF EXISTS `Turno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Turno` (
  `IdTurno` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(12) NOT NULL,
  PRIMARY KEY (`IdTurno`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Turno`
--

LOCK TABLES `Turno` WRITE;
/*!40000 ALTER TABLE `Turno` DISABLE KEYS */;
INSERT INTO `Turno` VALUES (1,'Diario');
/*!40000 ALTER TABLE `Turno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuario`
--

DROP TABLE IF EXISTS `Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Usuario` (
  `IdUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `IdEmpleado` int(11) NOT NULL,
  `Usuario` varchar(15) NOT NULL,
  `Pwd` varchar(15) NOT NULL,
  `Fecha_Creacion` date NOT NULL,
  `Activo` varchar(1) NOT NULL,
  PRIMARY KEY (`IdUsuario`),
  KEY `IdEmpleado_idx` (`IdEmpleado`),
  CONSTRAINT `IdEmpleado1` FOREIGN KEY (`IdEmpleado`) REFERENCES `Empleado` (`IdEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuario`
--

LOCK TABLES `Usuario` WRITE;
/*!40000 ALTER TABLE `Usuario` DISABLE KEYS */;
INSERT INTO `Usuario` VALUES (1,1,'zcley02','putoelquelolea','2017-05-02','1'),(2,2,'Fefito','pedo','2020-05-20','1'),(3,3,'cjzt','nose','2020-05-20','1'),(4,4,'ms','nosemae','2020-05-20','1'),(5,5,'agacha','123456','2020-05-20','1'),(6,6,'jose','dasdas','2020-05-22','1');
/*!40000 ALTER TABLE `Usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuario_Rol`
--

DROP TABLE IF EXISTS `Usuario_Rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Usuario_Rol` (
  `IdUsuario_Rol` int(11) NOT NULL AUTO_INCREMENT,
  `IdUsuario` int(11) NOT NULL,
  `IdRol` int(11) NOT NULL,
  `Fecha_Creacion` date NOT NULL,
  PRIMARY KEY (`IdUsuario_Rol`),
  KEY `fk_Usuario_Rol_1_idx` (`IdRol`),
  KEY `IdUsuario_idx` (`IdUsuario`),
  CONSTRAINT `IdRol2` FOREIGN KEY (`IdRol`) REFERENCES `Rol` (`IdRol`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `IdUsuario` FOREIGN KEY (`IdUsuario`) REFERENCES `Usuario` (`IdUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuario_Rol`
--

LOCK TABLES `Usuario_Rol` WRITE;
/*!40000 ALTER TABLE `Usuario_Rol` DISABLE KEYS */;
INSERT INTO `Usuario_Rol` VALUES (1,3,1,'2020-05-20'),(2,1,1,'2020-05-20'),(3,2,2,'2020-05-20'),(4,4,2,'2020-05-20'),(5,5,1,'2020-05-20'),(6,6,1,'2020-05-22');
/*!40000 ALTER TABLE `Usuario_Rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `obtenerEmp_Suc_Empre`
--

DROP TABLE IF EXISTS `obtenerEmp_Suc_Empre`;
/*!50001 DROP VIEW IF EXISTS `obtenerEmp_Suc_Empre`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `obtenerEmp_Suc_Empre` AS SELECT 
 1 AS `IdEmpleado`,
 1 AS `Nombre`,
 1 AS `Apellidos`,
 1 AS `Cedula`,
 1 AS `SalarioEmpleado`,
 1 AS `Fecha_Contratacion`,
 1 AS `Direccion`,
 1 AS `NombreS`,
 1 AS `NombreEm`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `sucursal_empresa`
--

DROP TABLE IF EXISTS `sucursal_empresa`;
/*!50001 DROP VIEW IF EXISTS `sucursal_empresa`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `sucursal_empresa` AS SELECT 
 1 AS `IdSucursal`,
 1 AS `Nombre`,
 1 AS `Extension`,
 1 AS `nombreEm`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vistaPago_Deduccion`
--

DROP TABLE IF EXISTS `vistaPago_Deduccion`;
/*!50001 DROP VIEW IF EXISTS `vistaPago_Deduccion`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vistaPago_Deduccion` AS SELECT 
 1 AS `IdEmpleado_Deduccion`,
 1 AS `IdPago`,
 1 AS `Nombre`,
 1 AS `Monto`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary table structure for view `vistaPago_Extra`
--

DROP TABLE IF EXISTS `vistaPago_Extra`;
/*!50001 DROP VIEW IF EXISTS `vistaPago_Extra`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE VIEW `vistaPago_Extra` AS SELECT 
 1 AS `IdEmpleado_Extra`,
 1 AS `IdPago`,
 1 AS `Nombre`,
 1 AS `Monto`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `obtenerEmp_Suc_Empre`
--

/*!50001 DROP VIEW IF EXISTS `obtenerEmp_Suc_Empre`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `obtenerEmp_Suc_Empre` AS select `e`.`IdEmpleado` AS `IdEmpleado`,`e`.`Nombre` AS `Nombre`,`e`.`Apellidos` AS `Apellidos`,`e`.`Cedula` AS `Cedula`,`e`.`SalarioEmpleado` AS `SalarioEmpleado`,`e`.`Fecha_Contratacion` AS `Fecha_Contratacion`,`e`.`Direccion` AS `Direccion`,`s`.`Nombre` AS `NombreS`,`em`.`Nombre` AS `NombreEm` from ((`Empleado` `e` join `Sucursal` `s`) join `Empresa` `em`) where ((`e`.`IdSucural` = `s`.`IdSucursal`) and (`s`.`NumeroRUC` = `em`.`NumeroRUC`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `sucursal_empresa`
--

/*!50001 DROP VIEW IF EXISTS `sucursal_empresa`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `sucursal_empresa` AS select `s`.`IdSucursal` AS `IdSucursal`,`s`.`Nombre` AS `Nombre`,`s`.`Extension` AS `Extension`,`e`.`Nombre` AS `nombreEm` from (`Sucursal` `s` join `Empresa` `e`) where (`s`.`NumeroRUC` = `e`.`NumeroRUC`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vistaPago_Deduccion`
--

/*!50001 DROP VIEW IF EXISTS `vistaPago_Deduccion`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vistaPago_Deduccion` AS select `p`.`IdEmpleado_Deduccion` AS `IdEmpleado_Deduccion`,`p`.`IdPago` AS `IdPago`,`e`.`Nombre` AS `Nombre`,`p`.`Monto` AS `Monto` from (`Pago_Deduccion` `p` join `Deducciones` `e` on((`p`.`IdDeducciones` = `e`.`IdDeducciones`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `vistaPago_Extra`
--

/*!50001 DROP VIEW IF EXISTS `vistaPago_Extra`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vistaPago_Extra` AS select `p`.`IdEmpleado_Extra` AS `IdEmpleado_Extra`,`p`.`IdPago` AS `IdPago`,`e`.`Nombre` AS `Nombre`,`p`.`Monto` AS `Monto` from (`Pago_Extra` `p` join `Extra` `e` on((`p`.`IdExtra` = `e`.`IdExtra`))) */;
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

-- Dump completed on 2020-05-26 15:31:24
