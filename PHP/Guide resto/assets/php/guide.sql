-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           8.0.30 - MySQL Community Server - GPL
-- SE du serveur:                Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Listage des données de la table guide.restaurants : ~2 rows (environ)
INSERT INTO `restaurants` (`id`, `nom`, `adresse`, `prix`, `commentaire`, `note`, `visite`) VALUES
	(1, 'JEAN-YVES SCHILLINGER', '17 Rue de la Poissonnerie, 68000 Colmar', 50.00, 'Le JY\'S est un restaurant différent des autres avec un décor cosy et résolument contemporain qui attire une\r\ntrès belle clientèle cosmopolite. Jean-Yves Schillinger est un chef doublement étoilé créatif qui vous entraînera\r\ndans une ronde dépaysante à souhait où la cuisine du monde est à l\'honneurLe chef décline la cuisine fusion à\r\nsa façon. Une carte régulièrement renouvelée s\'égaye de créations audacieuses et de plats revisités avec\r\nmodernité et pertinence.', 9, '2019-12-05'),
	(2, 'L’ADRIATICO', '6 route de Neuf Brisach, 68000, Colmar, France', 25.00, 'Une des meilleurs pizzéria de la région Service très agréable, efficace et souriant Salle principale un peu\r\nbruyante mais cela donne un côté italien je recommande', 8, '2020-02-04');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
