-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Ven 22 Septembre 2017 à 20:04
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bddcimebast`
--

-- --------------------------------------------------------

--
-- Structure de la table `beneficiaires`
--

CREATE TABLE `beneficiaires` (
  `ben_id` int(11) NOT NULL,
  `ben_nom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `ben_prenom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `ben_date_naiss` date DEFAULT NULL,
  `ben_lien_parente` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `ben_adresse` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `locville_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `beneficiaires`
--

INSERT INTO `beneficiaires` (`ben_id`, `ben_nom`, `ben_prenom`, `ben_date_naiss`, `ben_lien_parente`, `ben_adresse`, `locville_id`) VALUES
(87, 'Bois', 'Hugh', '1941-10-13', '', 'Rue des Ecoles 68', 28),
(88, 'René', 'Pierpont', '1942-01-31', '', 'Oostjachtpark 273', 28),
(89, 'Goulet', 'Philippe', '1954-04-21', '', 'Rue du Presbytère 493', 28),
(90, 'Beaulac', 'Fantina', '1940-07-28', '', 'Rue du Thisnes 61', 28),
(91, 'Saindon', 'Garland', '1967-07-22', '', 'Rue Bois des Fosses 159', 28),
(92, 'LaGrande', 'Guillaume', '1956-04-12', '', 'Tiegemberg 253', 28),
(93, 'Truchon', 'Christelle', '1953-07-30', '', 'Place Léopold 118', 28),
(94, 'Lamour', 'Hilaire', '1971-02-10', '', 'Tiegemberg 217', 28),
(95, 'Allard', 'Erembourg', '1963-05-25', '', 'Machelsesteenweg 289', 28),
(96, 'Lesage', 'Apolline', '1961-02-08', '', 'Rue Camille Joset 391', 28),
(97, 'Morneau', 'Honore', '1943-04-12', '', 'Rue Dielhère 346', 28),
(98, 'Labossière', 'Robinette', '1946-10-13', '', 'Tiegemberg 51', 28),
(99, 'St-Jacques', 'Roch', '1954-10-12', '', 'Mandemakersstraat 475', 28),
(100, 'L\'Heureux', 'Théodore', '1945-08-16', '', 'Drève des Bouleaux 84', 28),
(101, 'Corbin', 'Patience', '1943-10-20', '', 'Molenstraat 142', 28),
(102, 'Pinneau', 'Joanna', '1971-12-04', '', 'Korte Noordsstraat 14', 28),
(103, 'Garcia', 'Troy', '1932-07-08', '', 'Ramselsesteenweg 467', 28),
(104, 'Migneault', 'Laurene', '1937-06-03', '', 'Rue de Baras 243', 28),
(105, 'Camus', 'Cosette', '1931-09-25', '', 'Rue du Presbytère 27', 28),
(106, 'Houde', 'Pomeroy', '1967-10-02', '', 'Noordstraat 189', 28),
(107, 'Savard', 'Royden', '1934-08-15', '', 'Rue du Thisnes 157', 28),
(108, 'Guernon', 'Jewel', '1962-08-21', '', 'Jagerij 123', 28),
(109, 'Bourdette', 'Laurent', '1968-10-14', '', 'Route de Baschamps 377', 28),
(110, 'Brousse', 'Aiglentina', '1942-08-24', '', 'Lodewijk De Raetlaan 401', 28),
(111, 'Gingras', 'Odette', '1952-04-09', '', 'Netelaan 130', 28),
(112, 'Marois', 'Thérèse', '1956-08-27', '', 'Kerkstraat 470', 28),
(113, 'Boileau', 'Francis', '1967-09-15', '', 'Rue de la Tannerie 72', 28),
(114, 'Louineaux', 'Josette', '1948-07-15', '', 'Rue Haute 458', 28),
(115, 'Gaillou', 'Agathe', '1955-02-08', '', 'Rue de la Sarthe 263', 28),
(116, 'Jetté', 'Victorine', '1952-05-25', '', 'Heirstraat 226', 28),
(117, 'Lanteigne', 'Romaine', '1944-01-27', '', 'Hooivelden 476', 28),
(118, 'Dupéré', 'Léon', '1966-01-25', '', 'Hoge Wei 5', 28),
(119, 'Richer', 'Leala', '1949-05-20', '', 'Berkendreef 190', 28),
(120, 'Paquet', 'Babette', '1959-05-19', '', 'Avenue Emile Vandervelde 249', 28),
(121, 'Daoust', 'Clothilde', '1950-01-07', '', 'Rue de la Sarthe 445', 28),
(122, 'Charpie', 'Harcourt', '1967-08-05', '', 'Rue du Château 168', 28),
(123, 'Potvin', 'Danielle', '1959-08-13', '', 'Lange Elzenstraat 457', 28),
(124, 'Proulx', 'Aiglentina', '1939-12-20', '', 'Rue Bois des Fosses 233', 28),
(125, 'Narcisse', 'Laurence', '1952-04-16', '', 'Rue du Château 55', 28),
(126, 'Mazuret', 'Simone', '1937-10-26', '', 'Rue Grande 436', 28),
(127, 'Guay', 'Eulalie', '1937-03-27', '', 'Rue du Presbytère 416', 28),
(128, 'Lampron', 'Étienne', '1950-02-22', '', 'Rue de la Sarthe 55', 28),
(129, 'Girard', 'Christophe', '1946-01-29', '', 'Blancefloerlaan 81', 28),
(130, 'Franchet', 'Harcourt', '1941-07-28', '', 'Rue du Château 379', 28),
(131, 'Aubin', 'Namo', '1960-04-29', '', 'Rue du Vert Galant 334', 28),
(132, 'Bienvenue', 'Philip', '1953-05-06', '', 'Passiewijk 141', 28),
(133, 'Dupéré', 'Noémi', '1941-09-13', '', 'Schoolstraat 394', 28),
(134, 'Boulé', 'Frédérique', '1963-09-20', '', 'Alsembergsesteenweg 92', 28),
(135, 'Flamand', 'Yolande', '1950-08-23', '', 'Rue du Bourgmestre Dandoy 258', 28),
(136, 'Rochon', 'Dielle', '1935-01-25', '', 'Rue du Chapy 466', 28),
(137, 'L\'Heureux', 'Searlait', '1932-05-11', '', 'Rue du Cornet 485', 28),
(138, 'Bler', 'Christien', '1934-11-06', '', 'Avenue Emile Vandervelde 198', 28),
(139, 'Cinq-Mars', 'Corinne', '1931-12-05', '', 'Avenue Huart Hamoir 418', 28),
(140, 'Adler', 'Byron', '1959-07-12', '', 'Rue de Sy 160', 28),
(141, 'Théberge', 'Madelene', '1951-06-15', '', 'Stationsstraat 239', 28),
(142, 'Dubé', 'Loring', '1959-12-22', '', 'Schoolstraat 358', 28),
(143, 'Galarneau', 'Tanguy', '1962-05-19', '', 'Rue de la Rulles 178', 28),
(144, 'Brunault', 'Musette', '1935-08-22', '', 'Rue de Berloz 172', 28),
(145, 'Gabriaux', 'Noël', '1938-02-24', '', 'Excelsiorlaan 310', 28),
(146, 'Lepage', 'Suzette', '1944-12-26', '', 'Rue de la Sarthe 469', 28);

-- --------------------------------------------------------

--
-- Structure de la table `beneficier`
--

CREATE TABLE `beneficier` (
  `con_id` int(11) NOT NULL,
  `ben_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `concessionnaires`
--

CREATE TABLE `concessionnaires` (
  `csnr_id` int(11) NOT NULL,
  `csnr_nom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `csnr_prenom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `csnr_date_naiss` date DEFAULT NULL,
  `csnr_adresse` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `csnr_no_registre` bigint(20) DEFAULT NULL,
  `csnr_tel` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `locville_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `concessionnaires`
--

INSERT INTO `concessionnaires` (`csnr_id`, `csnr_nom`, `csnr_prenom`, `csnr_date_naiss`, `csnr_adresse`, `csnr_no_registre`, `csnr_tel`, `locville_id`) VALUES
(59, 'Franchet', 'Martin', NULL, 'Blancefloerlaan 238', NULL, '0486 21 44 39', 28),
(60, 'Pomerleau', 'Zerbino', NULL, 'Rue de Virton 445', NULL, '0472 40 96 70', 28),
(61, 'Lamoureux', 'Leal', NULL, 'Noordstraat 493', NULL, '0494 40 85 02', 28),
(62, 'Pinneau', 'Lorraine', NULL, 'Rue de Berloz 188', NULL, '0476 59 50 55', 28),
(63, 'Auclair', 'Lucas', NULL, 'Rue du Pont Simon 100', NULL, '0497 19 29 68', 28),
(64, 'Daviau', 'Noelle', NULL, 'Rue Jean Lorette 336', NULL, '0470 98 03 59', 28),
(65, 'Beaudoin', 'Lundy', NULL, 'Nieuwe Baan 445', NULL, '0485 36 37 94', 28),
(66, 'de Chateaub', 'Gill', NULL, 'Rue de Baras 169', NULL, '0492 39 78 02', 28),
(67, 'Bazinet', 'Brigitte', NULL, 'Rue des Ecoles 7', NULL, '0474 22 57 21', 28),
(68, 'Marois', 'Fletcher', NULL, 'Poolse Winglaan 45', NULL, '0492 28 91 76', 28),
(69, 'Cartier', 'Talon', NULL, 'Strepestraat 299', NULL, '0494 91 24 55', 28),
(70, 'Ayot', 'Daisi', NULL, 'Maskenstraat 212', NULL, '0492 85 06 83', 28),
(71, 'Chevrette', 'Yolande', NULL, 'Hooivelden 235', NULL, '0471 18 02 99', 28),
(72, 'Savard', 'Audric', NULL, 'Prinsenstraat 161', NULL, '0478 48 61 69', 28),
(73, 'Langlais', 'Millicent', NULL, 'Lambrechtstraat 337', NULL, '0474 85 59 65', 28),
(74, 'Laboissonnière', 'Parnella', NULL, 'Rue Bouhouille 281', NULL, '0490 22 66 86', 28),
(75, 'René', 'Marlon', NULL, 'Rue Haute 157', NULL, '0499 32 85 39', 28),
(76, 'Perrault', 'La Roux', NULL, 'Rue de la Sarthe 277', NULL, '0491 72 39 33', 28),
(77, 'Loiselle', 'Éléonore', NULL, 'Bessenveldstraat 44', NULL, '0480 80 56 98', 28),
(78, 'Robitaille', 'Benjamin', NULL, 'Rue de Berloz 465', NULL, '0483 97 42 35', 28),
(79, 'St-Jacques', 'Villette', NULL, 'Populierenstraat 371', NULL, '0496 68 47 12', 28),
(80, 'Gingras', 'Halette', NULL, 'Rue de Bouillon 449', NULL, '0497 32 38 90', 28),
(81, 'Beaupré', 'Melville', NULL, 'Orchideeenlaan 324', NULL, '0492 70 22 16', 28),
(82, 'Lajeunesse', 'Sargent', NULL, 'Rue du Château 296', NULL, '0495 38 60 83', 28),
(83, 'Josseaume', 'Patrice', NULL, 'Amerveldstraat 117', NULL, '0483 95 20 74', 28),
(84, 'Carrière', 'Aceline', NULL, 'Strepestraat 403', NULL, '0491 91 44 59', 28),
(85, 'Beaudoin', 'Ormazd', NULL, 'Strepestraat 168', NULL, '0482 85 84 13', 28),
(86, 'Beaujolie', 'Eugène', NULL, 'Rue de la Tannerie 348', NULL, '0490 91 25 94', 28),
(87, 'Michaud', 'Faye', NULL, 'Rue de Fontigny 121', NULL, '0489 53 60 25', 28),
(88, 'Forest', 'Jesper', NULL, 'Blekersdijk 464', NULL, '0476 65 99 72', 28),
(89, 'Rouleau', 'Fabienne', NULL, 'Eikstraat 407', NULL, '0474 46 99 63', 28),
(90, 'Desrosiers', 'Millard', NULL, 'Pont du Chêne 60', NULL, '0492 84 12 84', 28),
(91, 'Labrie', 'Julie', NULL, 'Rue du Manoir 376', NULL, '0470 63 69 07', 28),
(92, 'Cressac', 'Brice', NULL, 'Kasterleesteenweg 59', NULL, '0496 44 13 09', 28),
(93, 'Beaudoin', 'Hamilton', NULL, 'Booischotseweg 373', NULL, '0470 34 94 65', 28),
(94, 'Bisaillon', 'Cheney', NULL, 'Rue de Virton 338', NULL, '0477 49 84 93', 28),
(95, 'Chartré', 'Dominic', NULL, 'Rue de Boneffe 364', NULL, '0482 11 32 47', 28),
(96, 'Bonenfant', 'Verrill', NULL, 'Rue de Piétrain 282', NULL, '0478 75 02 53', 28),
(97, 'Deserres', 'Fanette', NULL, 'Rue des Ecoles 404', NULL, '0491 44 39 85', 28),
(98, 'Veronneau', 'Nanna', NULL, 'Lange Elzenstraat 98', NULL, '0496 64 20 40', 28),
(99, 'Chouinard', 'Florismart', NULL, 'Rue Supexhe 251', NULL, '0498 59 90 28', 28),
(100, 'Meilleur', 'Océane', NULL, 'Orchideeenlaan 171', NULL, '0473 12 54 10', 28),
(101, 'Petit', 'Roxanne', NULL, 'Rue de Birmingham 436', NULL, '0494 27 15 65', 28),
(102, 'Drouin', 'Grosvenor', NULL, 'Rue Henri Lambert 170', NULL, '0486 89 93 45', 28),
(103, 'Ayot', 'Burrell', NULL, 'Rue du Moulin 347', NULL, '0481 20 94 83', 28),
(104, 'Perrault', 'Avent', NULL, 'Rue de Fontigny 267', NULL, '0494 59 84 82', 28),
(105, 'Pépin', 'Chantal', NULL, 'Hauwaart 157', NULL, '0480 63 63 32', 28),
(106, 'Pelland', 'Sébastien', NULL, 'Rue des Tanneurs 333', NULL, '0483 33 34 57', 28),
(107, 'Beaulé', 'Fleurette', NULL, 'Route de Baschamps 156', NULL, '0478 79 94 88', 28),
(108, 'Busson', 'Edmee', NULL, 'Rue de Genville 138', NULL, '0494 24 24 26', 28),
(109, 'Lanoie', 'Donatien', NULL, 'Rue de la Sarthe 71', NULL, '0487 39 88 31', 28),
(110, 'Josseaume', 'Normand', NULL, 'Herentalsebaan 344', NULL, '0488 66 68 89', 28),
(111, 'Michaud', 'Lirienne', NULL, 'Rue du Commerce 446', NULL, '0498 33 51 34', 28),
(112, 'Beaulé', 'Alita', NULL, 'Rue du Bienne 44', NULL, '0473 47 74 72', 28),
(113, 'Avare', 'Campbell', NULL, 'Rue du Centre 56', NULL, '0499 31 66 56', 28),
(114, 'Brochu', 'Benjamin', NULL, 'Booischotseweg 14', NULL, '0471 90 44 37', 28),
(115, 'Bonneville', 'Jeannine', NULL, 'Rue des Campanules 353', NULL, '0480 13 80 69', 28),
(116, 'Covillon', 'Audric', NULL, 'Rue Haute 89', NULL, '0484 35 12 32', 28),
(117, 'Thibodeau', 'Blanchefle', NULL, 'Rue Jean Lorette 195', NULL, '0488 17 06 52', 28),
(118, 'Coupart', 'Gaetane', NULL, 'Lange Elzenstraat 110', NULL, '0498 90 34 11', 28),
(119, 'Charest', 'Vincent', NULL, 'Rue de la Tannerie 423', NULL, '0499 44 39 63', 28),
(120, 'Turgeon', 'Felicien', NULL, 'Rue de Piétrain 172', NULL, '0479 67 58 34', 28),
(121, 'Paquin', 'Roger', NULL, 'Rue du Presbytère 85', NULL, '0490 26 40 52', 28),
(122, 'Jodion', 'Malagigi', NULL, 'Blekersdijk 315', NULL, '0477 45 34 06', 28),
(123, 'Asselin', 'Medoro', NULL, 'Courtensdreef 363', NULL, '0472 51 90 01', 28),
(124, 'Lafond', 'Brice', NULL, 'Orchideeenlaan 46', NULL, '0496 54 30 51', 28),
(125, 'Lanoie', 'Somerville', NULL, 'Chaussée de Tirlemont 330', NULL, '0487 71 97 15', 28),
(126, 'Labrecque', 'Frontino', NULL, 'Taille Maréchal 140', NULL, '0481 16 20 22', 28),
(127, 'Gauthier', 'Gifford', NULL, 'Strepestraat 102', NULL, '0474 95 46 61', 28),
(128, 'Truchon', 'Chapin', NULL, 'Schietboompleinstraat 301', NULL, '0479 81 15 12', 28),
(129, 'Provencher', 'Lance', NULL, 'Perksesteenweg 232', NULL, '0487 57 13 05', 28),
(130, 'Picard', 'Pascal', NULL, 'Rue de la Sarthe 35', NULL, '0477 91 50 60', 28),
(131, 'Bériault', 'Apolline', NULL, 'Rue Fouramont 145', NULL, '0476 58 39 26', 28),
(132, 'Brian', 'Hélène', NULL, 'Rue du Thisnes 105', NULL, '0498 17 21 68', 28),
(133, 'Laliberté', 'Isaac', NULL, 'Rue de Liège 212', NULL, '0493 36 15 60', 28),
(134, 'Morel', 'Alfred', NULL, 'De Veurs Comberg 76', NULL, '0491 41 82 44', 28),
(135, 'Bussière', 'Creissant', NULL, 'Route de Neufchateau 456', NULL, '0492 88 30 31', 28),
(136, 'Houde', 'Philip', NULL, 'Pont du Chêne 262', NULL, '0489 54 50 88', 28),
(137, 'Asselin', 'Pansy', NULL, 'Rue de Virton 399', NULL, '0489 53 10 78', 28),
(138, 'Beaulé', 'Bertrand', NULL, 'Drève des Bouleaux 104', NULL, '0475 19 48 79', 28),
(139, 'Garcia', 'Linette', NULL, 'Industrieweg 289', NULL, '0475 14 08 44', 28),
(140, 'Cantin', 'Cloridan', NULL, 'Machelsesteenweg 386', NULL, '0471 28 35 25', 28),
(141, 'Bourgeau', 'Seymour', NULL, 'Rue de Baras 73', NULL, '0470 80 47 81', 28),
(142, 'Michaud', 'Odo', NULL, 'Strepestraat 184', NULL, '0491 11 67 83', 28),
(143, 'Truchon', 'Arianne', NULL, 'Jagerij 181', NULL, '0478 87 22 85', 28),
(144, 'Vincent', 'Minette', NULL, 'Rue du Monument 496', NULL, '0484 77 00 04', 28),
(145, 'Laboissonnière', 'Sydney', NULL, 'Rue Fosse Piron 482', NULL, '0475 42 11 61', 28),
(146, 'Roy', 'Fletcher', NULL, 'Rue de Fontigny 65', NULL, '0491 75 45 41', 28),
(147, 'Dastous', 'Florus', NULL, 'Rue du Bourgmestre Dandoy 439', NULL, '0477 94 34 54', 28),
(148, 'Bossé', 'Carole', NULL, 'Courtensdreef 55', NULL, '0481 40 48 81', 28),
(149, 'Brousse', 'Afrodille', NULL, 'Chaussée de Wavre 460', NULL, '0474 81 72 10', 28),
(150, 'Poulin', 'Dalmace', NULL, 'Populierenstraat 470', NULL, '0496 22 64 83', 28),
(151, 'Plouffe', 'Christelle', NULL, 'Taille Maréchal 136', NULL, '0487 19 57 31', 28),
(152, 'Lécuyer', 'Quennel', NULL, 'Prinsenstraat 1', NULL, '0486 82 79 13', 28),
(153, 'Langlois', 'Xavier', NULL, 'Avenue des Sartiaux 385', NULL, '0498 20 21 47', 28),
(154, 'Guay', 'Demi', NULL, 'Rue des Laderies 347', NULL, '0488 40 63 10', 28),
(155, 'Bordeaux', 'Esmeraude', NULL, 'Boulevard General Wahis 468', NULL, '0494 46 20 68', 28),
(156, 'Daigneault', 'Florismart', NULL, 'Blancefloerlaan 7', NULL, '0475 83 43 19', 28),
(157, 'Bisaillon', 'Agathe', NULL, 'Raas van Gaverestraat 66', NULL, '0479 39 94 21', 28),
(158, 'Durepos', 'Robinette', NULL, 'Industriestraat 450', NULL, '0489 16 87 05', 28),
(159, 'Gilbert', 'Amorette', NULL, 'Maskenstraat 18', NULL, '0485 22 95 35', 28),
(160, 'Plante', 'Delphine', NULL, 'Oostjachtpark 305', NULL, '0499 71 38 67', 28),
(161, 'Harquin', 'Fabien', NULL, 'Rue du Centre 63', NULL, '0498 48 22 37', 28),
(162, 'Poulin', 'Avice', NULL, 'Nieuwe Baan 455', NULL, '0495 43 03 34', 28),
(163, 'Labossière', 'Armand', NULL, 'Heirstraat 424', NULL, '0485 64 57 00', 28),
(164, 'Parent', 'Amorette', NULL, 'Schoolstraat 86', NULL, '0470 32 47 34', 28),
(165, 'Huard', 'Nicholas', NULL, 'Poolse Winglaan 353', NULL, '0473 33 50 06', 28),
(166, 'Flamand', 'Demi', NULL, 'Rue Henri Lambert 371', NULL, '0476 52 15 73', 28),
(167, 'Fouquet', 'Chantal', NULL, 'Hooivelden 282', NULL, '0491 44 95 95', 28),
(168, 'Giroux', 'Chandler', NULL, 'Route de Botrange 352', NULL, '0490 38 15 78', 28),
(169, 'Barteaux', 'Hedvige', NULL, 'Rue de Vonêche 155', NULL, '0484 47 04 86', 28),
(170, 'Fremont', 'Chapin', NULL, 'Alsembergsesteenweg 194', NULL, '0498 35 83 18', 28),
(171, 'Labossière', 'Forrest', NULL, 'Chaussée de Liège 218', NULL, '0475 11 92 30', 28),
(172, 'Covillon', 'Normand', NULL, 'Lodorp 277', NULL, '0481 59 95 70', 28),
(173, 'Paquin', 'Dalmace', NULL, 'Pont du Chêne 449', NULL, '0474 58 73 84', 28),
(174, 'Ruel', 'Élisabeth', NULL, 'Rostsestraat 381', NULL, '0487 39 81 45', 28),
(175, 'Paradis', 'Olivie', NULL, 'Rue de la Briqueterie 358', NULL, '0483 72 95 68', 28),
(176, 'Lapierre', 'Rosemarie', NULL, 'Rue des Ecoles 123', NULL, '0474 51 19 14', 28),
(177, 'Michaud', 'Laurene', NULL, 'Kerkstraat 295', NULL, '0494 88 69 74', 28),
(178, 'Côté', 'Sacripant', NULL, 'Amerveldstraat 166', NULL, '0476 15 43 70', 28),
(179, 'Girard', 'Chapin', NULL, 'Rue de Sy 109', NULL, '0490 10 10 99', 28),
(180, 'Allain', 'Curtis', NULL, 'Rue Grande 332', NULL, '0487 57 51 17', 28),
(181, 'Lereau', 'Talon', NULL, 'Populierenstraat 52', NULL, '0491 77 09 40', 28),
(182, 'Brunelle', 'Lothair', NULL, 'Rue de la Brasserie 321', NULL, '0490 58 46 13', 28),
(183, 'Mousseau', 'Troy', NULL, 'Chaussée de Wavre 263', NULL, '0483 22 01 76', 28),
(184, 'Charron', 'Olympia', NULL, 'Rue des Ecoles 248', NULL, '0492 78 56 68', 28),
(185, 'Alexandre', 'Charlot', NULL, 'Raas van Gaverestraat 242', NULL, '0493 75 11 81', 28),
(186, 'Bienvenue', 'Germaine', NULL, 'Place Léopold 493', NULL, '0497 10 02 34', 28),
(187, 'Durepos', 'Olivie', NULL, 'Blekersdijk 174', NULL, '0496 34 95 09', 28),
(188, 'Lamothe', 'Marthe', NULL, 'Raas van Gaverestraat 211', NULL, '0473 60 39 21', 28),
(189, 'Laurent', 'Archaimbau', NULL, 'Rue des Campanules 274', NULL, '0490 14 57 43', 28),
(190, 'Ratté', 'Denis', NULL, 'Rue des Tanneurs 79', NULL, '0481 95 73 64', 28),
(191, 'Chaloux', 'Rachelle', NULL, 'Aven Ackers 349', NULL, '0479 44 17 35', 28),
(192, 'Paré', 'Matthieu', NULL, 'Rue de Boneffe 59', NULL, '0472 71 01 05', 28),
(193, 'Hébert', 'Ermengardi', NULL, 'Rue du Bourgmestre Dandoy 452', NULL, '0474 58 37 34', 28),
(194, 'Labrecque', 'Dominic', NULL, 'Sur les Tailles 104', NULL, '0499 59 93 30', 28),
(195, 'Duval', 'Bernadette', NULL, 'Dijkstraat 369', NULL, '0497 95 43 70', 28),
(196, 'Baril', 'Olympia', NULL, 'Rue de Boneffe 26', NULL, '0480 64 09 31', 28),
(197, 'Parenteau', 'Searlas', NULL, 'Rue de la Tannerie 215', NULL, '0470 71 11 39', 28),
(198, 'Reault', 'Grosvenor', NULL, 'Kerkstraat 242', NULL, '0472 67 92 88', 28),
(199, 'Tisserand', 'Orva', NULL, 'Courtensdreef 39', NULL, '0473 30 83 77', 28),
(200, 'Laliberté', 'Marc', NULL, 'Rue de la Briqueterie 131', NULL, '0492 71 16 15', 28),
(201, 'Boulanger', 'Gallia', NULL, 'Route de Baschamps 414', NULL, '0472 97 13 33', 28),
(202, 'Charest', 'Yseult', NULL, 'Rue des Tanneurs 303', NULL, '0476 22 33 61', 28),
(203, 'Roussel', 'Vivienne', NULL, 'Putstraat 67', NULL, '0470 49 97 69', 28),
(204, 'Patel', 'Paien', NULL, 'Avenue Emile Vandervelde 77', NULL, '0495 39 72 90', 28),
(205, 'Beaudouin', 'Aimée', NULL, 'Noordstraat 226', NULL, '0487 91 29 63', 28),
(206, 'Laisné', 'Bertrand', NULL, 'Raas van Gaverestraat 258', NULL, '0483 94 85 35', 28),
(207, 'Laprise', 'Brice', NULL, 'Rue de Vonêche 485', NULL, '0484 63 67 50', 28),
(208, 'Moreau', 'Renée', NULL, 'Rue du Monument 412', NULL, '0497 73 32 67', 28);

-- --------------------------------------------------------

--
-- Structure de la table `concessions`
--

CREATE TABLE `concessions` (
  `con_id` int(11) NOT NULL,
  `con_numero` int(11) DEFAULT NULL,
  `con_date_debut` date DEFAULT NULL,
  `con_date_fin` date DEFAULT NULL,
  `con_nbre_renovations` int(11) DEFAULT NULL,
  `con_montant_paye` decimal(7,2) DEFAULT NULL,
  `empl_id` int(11) NOT NULL,
  `csnr_id` int(11) NOT NULL,
  `com_id` int(11) DEFAULT NULL,
  `h_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `concessions`
--

INSERT INTO `concessions` (`con_id`, `con_numero`, `con_date_debut`, `con_date_fin`, `con_nbre_renovations`, `con_montant_paye`, `empl_id`, `csnr_id`, `com_id`, `h_id`) VALUES
(143, NULL, '1994-11-23', '2018-11-26', NULL, NULL, 47, 152, NULL, NULL),
(144, NULL, '1993-01-10', '2018-12-20', NULL, NULL, 51, 84, NULL, NULL),
(148, NULL, '1991-01-20', '2017-05-31', NULL, NULL, 85, 169, NULL, NULL),
(151, NULL, '2003-10-20', '2017-10-20', NULL, NULL, 125, 144, 68, NULL),
(157, NULL, '1993-11-19', '2018-04-10', NULL, NULL, 77, 159, NULL, NULL),
(159, NULL, '1991-12-30', '2018-12-03', NULL, NULL, 147, 192, NULL, NULL),
(162, NULL, '1995-03-31', '2019-01-23', NULL, NULL, 72, 132, NULL, NULL),
(166, NULL, '1991-11-12', '2017-10-25', NULL, NULL, 114, 177, NULL, NULL),
(168, NULL, '1993-11-22', '2019-08-23', NULL, NULL, 103, 122, NULL, NULL),
(169, NULL, '1989-07-21', '2018-08-30', NULL, NULL, 80, 189, NULL, NULL),
(170, NULL, '1995-09-02', '2019-12-25', NULL, NULL, 118, 128, NULL, NULL),
(174, NULL, '1992-10-14', '2016-08-05', NULL, NULL, 70, 106, NULL, NULL),
(175, NULL, '1991-09-26', '2019-08-14', NULL, NULL, 45, 101, NULL, NULL),
(178, NULL, '1990-12-02', '2014-11-30', NULL, NULL, 135, 199, NULL, NULL),
(180, NULL, '1989-12-30', '2020-04-23', NULL, NULL, 140, 87, NULL, NULL),
(182, NULL, '1994-02-23', '2017-02-04', NULL, NULL, 54, 151, NULL, NULL),
(183, NULL, '1992-05-16', '2016-06-22', NULL, NULL, 41, 64, NULL, NULL),
(184, NULL, '1990-01-07', '2016-09-07', NULL, NULL, 60, 75, NULL, NULL),
(185, NULL, '1989-11-27', '2019-08-09', NULL, NULL, 76, 200, NULL, NULL),
(187, NULL, '1991-04-17', '2018-09-10', NULL, NULL, 82, 123, NULL, NULL),
(188, NULL, '1990-06-25', '2016-04-30', NULL, NULL, 137, 168, NULL, NULL),
(190, NULL, '1991-03-11', '2017-09-25', NULL, NULL, 88, 125, NULL, NULL),
(191, NULL, '1992-10-21', '2015-06-23', NULL, NULL, 138, 184, NULL, NULL),
(196, NULL, '1993-03-15', '2019-09-08', NULL, NULL, 124, 62, NULL, NULL),
(200, NULL, '1993-01-16', '2016-08-05', NULL, NULL, 130, 143, NULL, NULL),
(202, NULL, '1992-10-15', '2014-11-06', NULL, NULL, 113, 194, NULL, NULL),
(204, NULL, '1991-06-06', '2017-06-25', NULL, NULL, 68, 74, NULL, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `defunts`
--

CREATE TABLE `defunts` (
  `def_id` int(11) NOT NULL,
  `def_numero_lh` int(11) DEFAULT NULL,
  `def_numero_annee` int(11) DEFAULT NULL,
  `def_prenom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `def_nom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `def_adresse` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `def_etat_civil` int(11) NOT NULL DEFAULT '0' COMMENT ' 0=non précisé, 1=celibataire,2=epoux,3=veuf,4=divorce,5=enfant ',
  `def_etat_civil_de` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `def_date_naiss` date DEFAULT NULL,
  `def_lieu_naiss` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `def_date_deces` date DEFAULT NULL,
  `def_lieu_deces` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `pc_id` int(11) DEFAULT NULL,
  `Date_debut` date DEFAULT NULL,
  `Date_fin` date DEFAULT NULL,
  `empl_id` int(11) DEFAULT NULL,
  `locville_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `defunts`
--

INSERT INTO `defunts` (`def_id`, `def_numero_lh`, `def_numero_annee`, `def_prenom`, `def_nom`, `def_adresse`, `def_etat_civil`, `def_etat_civil_de`, `def_date_naiss`, `def_lieu_naiss`, `def_date_deces`, `def_lieu_deces`, `pc_id`, `Date_debut`, `Date_fin`, `empl_id`, `locville_id`) VALUES
(53, 6252, NULL, 'Annette', 'Gagné', 'Rue Engeland 313', 0, '', '1940-08-01', '', '2017-08-01', '', 6, NULL, NULL, 93, 28),
(56, 6255, NULL, 'Mandel', 'Therriault', 'Rue du Bois Colau 363', 0, '', '1932-12-16', '', '2016-12-16', '', 9, NULL, NULL, 93, 28),
(57, 6256, NULL, 'Fanchon', 'Lapierre', 'Witbakkerstraat 17', 0, '', '1946-08-30', '', '2017-08-30', '', 10, NULL, NULL, 93, 28),
(59, 6258, NULL, 'Noelle', 'Sylvain', 'Rue de Birmingham 367', 0, '', '1930-05-05', '', '2017-05-05', '', 12, NULL, NULL, 70, 28),
(62, 6261, NULL, 'Arianne', 'Gladu', 'Rue de la Rulles 40', 0, '', '1934-11-14', '', '2016-11-14', '', 15, NULL, NULL, 71, 28),
(63, 6262, NULL, 'France', 'Souplet', 'Rue Haute 119', 0, '', '1936-07-04', '', '2017-07-04', '', 16, NULL, NULL, 132, 28),
(64, 6263, NULL, 'Comforte', 'Guay', 'Industrieweg 296', 0, '', '1935-06-15', '', '2017-06-15', '', 17, NULL, NULL, 67, 28),
(66, 6265, NULL, 'Josephe', 'Bellefeuille', 'Rue des Honnelles 202', 0, '', '1933-09-01', '', '2017-09-01', '', 19, NULL, NULL, 124, 28),
(67, 6266, NULL, 'Brunella', 'Chaloux', 'Rue de Fontigny 410', 0, '', '1952-05-16', '', '2017-05-16', '', 20, NULL, NULL, 147, 28),
(70, 6269, NULL, 'Tyson', 'Guibord', 'Rue du Pont Simon 24', 0, '', '1928-05-02', '', '2017-05-02', '', 23, NULL, NULL, 147, 28),
(71, 6270, NULL, 'Denis', 'Bellefeuille', 'Rue du Chapy 456', 0, '', '1934-12-24', '', '2016-12-24', '', 24, NULL, NULL, 147, 28),
(72, 6271, NULL, 'Gradasso', 'Desjardins', 'Rue Haute 88', 0, '', '1951-02-26', '', '2017-02-26', '', 25, NULL, NULL, 95, 28),
(74, 6273, NULL, 'Élodie', 'Bourdette', 'Rue de Genville 437', 0, '', '1936-02-22', '', '2017-02-22', '', 27, NULL, NULL, 80, 28),
(75, 6274, NULL, 'Lyle', 'Mathieu', 'Rue Libert 167', 0, '', '1928-07-03', '', '2017-07-03', '', 28, NULL, NULL, 63, 28),
(76, 6275, NULL, 'Lundy', 'Marchesseault', 'Lodorp 39', 0, '', '1956-07-07', '', '2017-07-07', '', 29, NULL, NULL, 42, 28),
(77, 6276, NULL, 'Liane', 'Phaneuf', 'Rue Dielhère 360', 0, '', '1930-01-03', '', '2017-01-03', '', NULL, NULL, NULL, 105, 28),
(79, 6278, NULL, 'Arno', 'Rivard', 'Putstraat 449', 0, '', '1949-07-23', '', '2017-07-23', '', NULL, NULL, NULL, 107, 28),
(81, 6280, NULL, 'Sennet', 'Mouet', 'Rue de Virton 325', 0, '', '1929-09-02', '', '2017-09-02', '', NULL, NULL, NULL, 106, 28),
(82, 6281, NULL, 'Vaden', 'Goguen', 'Rue du Moulin 103', 0, '', '1950-11-09', '', '2016-11-09', '', NULL, NULL, NULL, 109, 28),
(84, 6283, NULL, 'William', 'Belisle', 'Rue Jean Lorette 149', 0, '', '1933-08-30', '', '2017-08-30', '', NULL, NULL, NULL, 34, 28),
(86, 6285, NULL, 'Mason', 'Aupry', 'Rue Basse 455', 0, '', '1928-02-13', '', '2017-02-13', '', NULL, NULL, NULL, 86, 28),
(88, 6287, NULL, 'Arnaude', 'Fouquet', 'Touwslagerstraat 179', 0, '', '1938-04-04', '', '2017-04-04', '', NULL, NULL, NULL, 112, 28),
(89, 6288, NULL, 'Alita', 'Saindon', 'Rue de Baras 326', 0, '', '1929-09-29', '', '2016-09-29', '', NULL, NULL, NULL, 102, 28),
(92, 6291, NULL, 'Joseph', 'Laforest', 'Route de Baschamps 241', 0, '', '1933-12-14', '', '2016-12-14', '', NULL, NULL, NULL, 130, 28),
(94, 6293, NULL, 'Loring', 'St-Jean', 'Door Van dijckstraat 26', 0, '', '1939-07-15', '', '2017-07-15', '', NULL, NULL, NULL, 90, 28),
(96, 6295, NULL, 'Agramant', 'Veronneau', 'Rue de Piétrain 170', 0, '', '1941-08-25', '', '2017-08-25', '', NULL, NULL, NULL, 139, 28),
(98, 6297, NULL, 'Varden', 'Bordeleau', 'Rue du Pont Simon 421', 0, '', '1927-05-30', '', '2017-05-30', '', NULL, NULL, NULL, 44, 28),
(100, 6299, NULL, 'Inès', 'Deslauriers', 'Rue du Chapy 466', 0, '', '1943-10-31', '', '2016-10-31', '', NULL, NULL, NULL, 113, 28),
(101, 6300, NULL, 'Delphine', 'Cantin', 'Rue du Presbytère 153', 0, '', '1938-10-09', '', '2016-10-09', '', NULL, NULL, NULL, 133, 28),
(102, 6301, NULL, 'Odette', 'Fugère', 'Strepestraat 88', 0, '', '1951-02-10', '', '2017-02-10', '', NULL, NULL, NULL, 66, 28),
(103, 6302, NULL, 'Fusberta', 'Souplet', 'Berkendreef 455', 0, '', '1944-10-19', '', '2016-10-19', '', NULL, NULL, NULL, 131, 28),
(107, 6306, NULL, 'Brigitte', 'Vallée', 'Rue Supexhe 300', 0, '', '1937-04-26', '', '2017-04-26', '', NULL, NULL, NULL, 118, 28),
(108, 6307, NULL, 'Anne', 'Lajoie', 'Herentalsebaan 92', 0, '', '1944-02-18', '', '2017-02-18', '', NULL, NULL, NULL, 74, 28),
(109, 6308, NULL, 'Élise', 'Giroux', 'Ringlaan 96', 0, '', '1955-12-13', '', '2016-12-13', '', NULL, NULL, NULL, 99, 28),
(110, 6309, NULL, 'Florismart', 'Monty', 'Rue du Commerce 26', 0, '', '1935-05-05', '', '2017-05-05', '', NULL, NULL, NULL, 127, 28),
(112, 6311, NULL, 'Ila', 'Jolicoeur', 'De Veurs Comberg 151', 0, '', '1955-12-21', '', '2016-12-21', '', NULL, NULL, NULL, 76, 28),
(113, 6312, NULL, 'Ansel', 'Quinn', 'Avenue des Sartiaux 428', 0, '', '1941-01-28', '', '2017-01-28', '', NULL, NULL, NULL, 126, 28),
(114, 6313, NULL, 'Leverett', 'Perillard', 'Rue Jean Lorette 25', 0, '', '1928-05-31', '', '2017-05-31', '', NULL, NULL, NULL, 136, 28),
(116, 6315, NULL, 'Mayhew', 'Roy', 'Rue du Monument 105', 0, '', '1948-04-05', '', '2017-04-05', '', NULL, NULL, NULL, 108, 28),
(120, 6319, NULL, 'Desire', 'Daigneault', 'Rue des Buissons 264', 0, '', '1951-05-26', '', '2017-05-26', '', NULL, NULL, NULL, 116, 28),
(125, 6324, NULL, 'Burnell', 'Flamand', 'Rue de Bouillon 387', 0, '', '1942-06-25', '', '2017-06-25', '', NULL, NULL, NULL, 38, 28),
(126, 6325, NULL, 'Josephe', 'Sciverit', 'Rue du Commerce 277', 0, '', '1927-06-18', '', '2017-06-18', '', NULL, NULL, NULL, 91, 28),
(130, 6329, NULL, 'Solaine', 'Ducharme', 'Lodorp 393', 0, '', '1949-03-08', '', '2017-03-08', '', NULL, NULL, NULL, 87, 28),
(180, NULL, NULL, 'Gaetan', 'Duclos', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 56, NULL),
(181, NULL, NULL, 'Clarice', 'Gladu', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 93, NULL),
(182, NULL, NULL, 'Annot', 'Sciverit', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 33, NULL),
(183, NULL, NULL, 'Hugues', 'Grandpré', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 89, NULL),
(184, NULL, NULL, 'Searlas', 'Tremblay', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 82, NULL),
(185, NULL, NULL, 'Yolette', 'Ruais', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 112, NULL),
(186, NULL, NULL, 'Alexandrin', 'Caisse', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 50, NULL),
(187, NULL, NULL, 'Anne', 'Clément', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 113, NULL),
(188, NULL, NULL, 'Byron', 'Gaulin', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 39, NULL),
(189, NULL, NULL, 'Albertine', 'Angélil', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 53, NULL),
(190, NULL, NULL, 'Jessamine', 'Cliche', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 117, NULL),
(191, NULL, NULL, 'Guerin', 'Blanc', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 48, NULL),
(192, NULL, NULL, 'Fifine', 'Chenard', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 88, NULL),
(193, NULL, NULL, 'Beltane', 'Laboissonnière', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 34, NULL),
(194, NULL, NULL, 'Guerin', 'Dupont', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 107, NULL),
(195, NULL, NULL, 'Philippe', 'Flamand', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 51, NULL),
(196, NULL, NULL, 'Fauna', 'Perrault', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 135, NULL),
(197, NULL, NULL, 'Aubrey', 'Migneault', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 142, NULL),
(198, NULL, NULL, 'Avenall', 'Chauvet', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 41, NULL),
(199, NULL, NULL, 'Pénélope', 'de Brisay', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 96, NULL),
(200, NULL, NULL, 'Granville', 'Covillon', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 95, NULL),
(201, NULL, NULL, 'Avenall', 'Chesnay', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 37, NULL),
(202, NULL, NULL, 'Nadine', 'Ménard', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 101, NULL),
(203, NULL, NULL, 'Emmeline', 'Desrosiers', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 129, NULL),
(204, NULL, NULL, 'Jeannine', 'Belisle', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 81, NULL),
(205, NULL, NULL, 'Chapin', 'Boivin', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 101, NULL),
(206, NULL, NULL, 'Avenall', 'Brault', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 115, NULL),
(207, NULL, NULL, 'Jeannine', 'Sirois', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 124, NULL),
(208, NULL, NULL, 'Amedee', 'LaGrande', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 127, NULL),
(209, NULL, NULL, 'Zoé', 'Marcil', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 114, NULL),
(210, NULL, NULL, 'Onfroi', 'Larocque', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 45, NULL),
(211, NULL, NULL, 'Clothilde', 'Tessier', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 81, NULL),
(212, NULL, NULL, 'Adrien', 'Bonneville', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 121, NULL),
(213, NULL, NULL, 'Byron', 'Ménard', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 102, NULL),
(214, NULL, NULL, 'Océane', 'Déziel', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 115, NULL),
(215, NULL, NULL, 'Chantal', 'Binet', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 120, NULL),
(216, NULL, NULL, 'Fifine', 'Marois', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 108, NULL),
(217, NULL, NULL, 'Slainie', 'Larocque', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 33, NULL),
(218, NULL, NULL, 'Zara', 'Devoe', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 39, NULL),
(219, NULL, NULL, 'Magnolia', 'Beaudouin', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 66, NULL),
(220, NULL, NULL, 'Simone', 'Bouchard', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 67, NULL),
(221, NULL, NULL, 'Honoré', 'Duffet', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 105, NULL),
(222, NULL, NULL, 'Vick', 'Cailot', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 61, NULL),
(223, NULL, NULL, 'Pensee', 'Moreau', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 73, NULL),
(224, NULL, NULL, 'Annot', 'Lavallée', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 36, NULL),
(225, NULL, NULL, 'Suzette', 'Querry', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 46, NULL),
(226, NULL, NULL, 'Gifford', 'Lessard', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 92, NULL),
(227, NULL, NULL, 'Thomas', 'Bossé', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 55, NULL),
(228, NULL, NULL, 'Audrey', 'Louis', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 86, NULL),
(229, NULL, NULL, 'Peverell', 'Patel', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 118, NULL),
(230, NULL, NULL, 'Orlene', 'Savard', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 67, NULL),
(231, NULL, NULL, 'Eliot', 'Panetier', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 64, NULL),
(232, NULL, NULL, 'Gaston', 'Demers', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 90, NULL),
(233, NULL, NULL, 'Zerbino', 'Mailloux', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 109, NULL),
(234, NULL, NULL, 'Louis', 'Pelletier', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 129, NULL),
(235, NULL, NULL, 'Solaine', 'Babin', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 55, NULL),
(236, NULL, NULL, 'Arridano', 'Durepos', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 87, NULL),
(237, NULL, NULL, 'Alaine', 'Paquin', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 123, NULL),
(238, NULL, NULL, 'Pensee', 'Lanoie', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 90, NULL),
(239, NULL, NULL, 'Dominic', 'De La Vergne', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 49, NULL),
(240, NULL, NULL, 'Julienne', 'Desjardins', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 61, NULL),
(241, NULL, NULL, 'Peppin', 'Bordeleau', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 128, NULL),
(242, NULL, NULL, 'Anastasie', 'Metivier', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 76, NULL),
(243, NULL, NULL, 'Juliette', 'Lalonde', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 80, NULL),
(244, NULL, NULL, 'Alaine', 'Guédry', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 142, NULL),
(245, NULL, NULL, 'Lyle', 'Guay', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 92, NULL),
(246, NULL, NULL, 'Melusina', 'Varieur', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 116, NULL),
(247, NULL, NULL, 'Roland', 'Gaillou', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 41, NULL),
(248, NULL, NULL, 'Madelene', 'Charette', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 56, NULL),
(249, NULL, NULL, 'Élisabeth', 'Sylvain', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 125, NULL),
(250, NULL, NULL, 'Manon', 'Echeverri', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 77, NULL),
(251, NULL, NULL, 'Marmion', 'Franchet', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 94, NULL),
(252, NULL, NULL, 'Étienne', 'Loiselle', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 94, NULL),
(253, NULL, NULL, 'Jérôme', 'Begin', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 40, NULL),
(254, NULL, NULL, 'Corette', 'Mailhot', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 117, NULL),
(255, NULL, NULL, 'Moore', 'Gaudreau', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 87, NULL),
(256, NULL, NULL, 'Marmion', 'Sciverit', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 54, NULL),
(257, NULL, NULL, 'Soren', 'Séguin', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 91, NULL),
(258, NULL, NULL, 'Henry', 'Charlebois', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 32, NULL),
(259, NULL, NULL, 'Iven', 'Duhamel', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 88, NULL),
(260, NULL, NULL, 'Searlas', 'Lavoie', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 79, NULL),
(261, NULL, NULL, 'Bartlett', 'Boucher', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 100, NULL),
(262, NULL, NULL, 'Fleurette', 'Généreux', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 116, NULL),
(263, NULL, NULL, 'Mavise', 'Metivier', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 130, NULL),
(264, NULL, NULL, 'Anne', 'Louis', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 41, NULL),
(265, NULL, NULL, 'Juliette', 'Cressac', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 130, NULL),
(266, NULL, NULL, 'Pascaline', 'Lamoureux', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 147, NULL),
(267, NULL, NULL, 'René', 'Avare', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 80, NULL),
(268, NULL, NULL, 'Blanche', 'Barjavel', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 46, NULL),
(269, NULL, NULL, 'Vail', 'Barteaux', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 74, NULL),
(270, NULL, NULL, 'Didiane', 'Babin', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 85, NULL),
(271, NULL, NULL, 'Travers', 'Rancourt', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 56, NULL),
(272, NULL, NULL, 'Luce', 'Duhamel', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 108, NULL),
(273, NULL, NULL, 'Percy', 'Paulet', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 110, NULL),
(274, NULL, NULL, 'Bruce', 'Patel', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 80, NULL),
(275, NULL, NULL, 'Mireille', 'Dufresne', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 37, NULL),
(276, NULL, NULL, 'Denis', 'Laframboise', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 145, NULL),
(277, NULL, NULL, 'Aleron', 'Thériault', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 120, NULL),
(278, NULL, NULL, 'Aurore', 'Morin', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 133, NULL),
(279, NULL, NULL, 'Madeleine', 'Grignon', '', 0, '', NULL, '', NULL, '', NULL, NULL, NULL, 43, NULL);

-- --------------------------------------------------------

--
-- Structure de la table `emplacements`
--

CREATE TABLE `emplacements` (
  `empl_id` int(11) NOT NULL,
  `empl_reference` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `empl_type` int(11) NOT NULL DEFAULT '0' COMMENT ' 	0=non précisé, 1=caveau, 2=concession, 3=fosse ordinaire, 4=urne',
  `empl_nb_places` int(11) DEFAULT NULL,
  `empl_monum_classe` tinyint(1) NOT NULL DEFAULT '0',
  `hist_id` int(11) DEFAULT NULL,
  `empl_coords` varbinary(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `emplacements`
--

INSERT INTO `emplacements` (`empl_id`, `empl_reference`, `empl_type`, `empl_nb_places`, `empl_monum_classe`, `hist_id`, `empl_coords`) VALUES
(32, 'A2001', 1, NULL, 0, NULL, 0xcb0036070c01410702017f07c7007f07cb003607),
(33, 'A2002', 4, NULL, 0, NULL, 0x0f017c07770187077d012b0716012b070f017c07),
(34, 'A1003', 4, NULL, 0, NULL, 0x7a018107b1017907cc012b0784012b077a018107),
(35, 'A1004', 4, 2, 0, NULL, 0xc9017f070302840703023607d3013007c9017f07),
(36, 'A1005', 4, 9, 0, NULL, 0x26028f078d028f079e023b073a02360726028f07),
(37, 'A1006', 4, 3, 0, NULL, 0xa2029507df029207ea023b07a8023307a2029507),
(38, 'A1007', 4, NULL, 0, NULL, 0xf1023b07ea028d07210395072b034107f1023b07),
(39, 'A1008', 4, NULL, 0, NULL, 0x3203950770038f077703410739033b0732039507),
(40, 'A1009', 3, NULL, 0, NULL, 0x77039207ae039207c20344078103470777039207),
(41, 'A1010', 3, NULL, 0, NULL, 0xc2034407b80395070304950700044707c2034407),
(42, 'A1011', 3, NULL, 0, NULL, 0x0a044c07fd039e0745049e074c0449070a044c07),
(43, 'A1012', 0, NULL, 0, NULL, 0x6b044c075d04a007a8049b07af044f076b044c07),
(44, 'A1013', 1, NULL, 0, NULL, 0xdc044f07dc04a6071605a90721055507dc044f07),
(45, 'A1014', 0, NULL, 0, NULL, 0x1a05a3075b05ac0769055707210557071a05a307),
(46, 'A1015', 0, NULL, 0, NULL, 0x70055a076505a907aa05a907b405570770055a07),
(47, 'A1016', 0, NULL, 0, NULL, 0xb8055707a305b107f905b107fd055707b8055707),
(48, 'A1017', 0, NULL, 0, NULL, 0x0e064c0756064f074f06b1070406ae070e064c07),
(49, 'A1018', 0, NULL, 0, NULL, 0x5306b107a206b107a2064f075d0647075306b107),
(50, 'A1019', 0, NULL, 0, NULL, 0xd9069207d506b4077e07b1077e078d07d9069207),
(51, 'A1020', 0, NULL, 0, NULL, 0xf4066507f4068107a0078707a0076307f4066507),
(52, 'A1021', 0, NULL, 0, NULL, 0xf4061f07fb0644079c07410799072507f4061f07),
(53, 'A1022', 0, NULL, 0, NULL, 0xa0071f07f4061f07f806fe0692070307a0071f07),
(54, 'A1023', 0, NULL, 0, NULL, 0x96070007ed06fb06f106df069607df0696070007),
(55, 'A1024', 0, NULL, 0, NULL, 0x9607dc06ed06df06f106ba068b07ba069607dc06),
(56, 'A1025', 0, NULL, 0, NULL, 0x9207b506f406b706ed0693068f0796069207b506),
(57, 'A1026', 0, NULL, 0, NULL, 0x96079606e6069006ea0671068b07740696079606),
(58, 'A1027', 0, NULL, 0, NULL, 0x88077106e6067406ea064d068b07500688077106),
(59, 'A1028', 0, NULL, 0, NULL, 0x81074a06e6064a06e6062b0688072b0681074a06),
(60, 'A1029', 0, NULL, 0, NULL, 0x84072806df062606df06fe057e07070684072806),
(61, 'A1030', 0, NULL, 0, NULL, 0x7e070406e306fe05e306e2057e07e5057e070406),
(62, 'A1031', 0, NULL, 0, NULL, 0x8107e005dc06e205d906be057707c3058107e005),
(63, 'A1032', 0, NULL, 0, NULL, 0x6c07b505dc06bb05df06a2057307a2056c07b505),
(64, 'A1033', 0, NULL, 0, NULL, 0x77079c05dc069705d90680056c07800577079c05),
(65, 'A1034', 0, NULL, 0, NULL, 0x73077805d9067505d50653057007560573077805),
(66, 'A1035', 0, NULL, 0, NULL, 0x70075605d2065305d20637057007340570075605),
(67, 'A1036', 0, NULL, 0, NULL, 0x70073405cb062c05ce060d057007130570073405),
(68, 'A1037', 0, NULL, 0, NULL, 0x70070a05ce061005ce06ee046207ee0470070a05),
(69, 'A1038', 0, NULL, 0, NULL, 0x7007eb04c706eb04c706cd046907cd047007eb04),
(70, 'A1039', 0, NULL, 0, NULL, 0x6907ca04c706cd04cb06a3046907a5046907ca04),
(71, 'A1040', 0, NULL, 0, NULL, 0x6507a304cb06a804c7068604620789046507a304),
(72, 'A1041', 0, NULL, 0, NULL, 0x5f078604c7067e04c7066204620765045f078604),
(73, 'A1042', 0, NULL, 0, NULL, 0x62075c04c7065c04c1063e0462073e0462075c04),
(74, 'A1043', 0, NULL, 0, NULL, 0x5f074004c4063b04c4061c04650719045f074004),
(75, 'A1044', 0, NULL, 0, NULL, 0x5f070e04bd061104bd06f2035407ec035f070e04),
(76, 'A1045', 0, NULL, 0, NULL, 0xbd06ec035807e9035807c503c406c803bd06ec03),
(77, 'A1046', 0, NULL, 0, NULL, 0xbd06c2035407c2035407a003bd06a303bd06c203),
(78, 'A1047', 0, NULL, 0, NULL, 0xba06a3035b079e034d077f03ba068703ba06a303),
(79, 'A1048', 0, NULL, 0, NULL, 0xb6067c035407820354076303b6066303b6067c03),
(80, 'A1049', 0, NULL, 0, NULL, 0xaf06630358075a0351073b03b6064103af066303),
(81, 'A1050', 0, NULL, 0, NULL, 0xac063b0351073b034d071703b3061a03ac063b03),
(82, 'A1051', 0, NULL, 0, NULL, 0xaf0617034d0717034d07f502ac06f502af061703),
(83, 'A1052', 0, NULL, 0, NULL, 0xaf06f5025407f3025407d402af06d402af06f502),
(84, 'A1053', 0, NULL, 0, NULL, 0xaf06d9024a07d1024a07af02af06b202af06d902),
(85, 'A1054', 0, NULL, 0, NULL, 0xac06aa024a07a70247078802ac068b02ac06aa02),
(86, 'A1055', 0, NULL, 0, NULL, 0xa80688024707880243076602a8066c02a8068802),
(87, 'A1056', 0, NULL, 0, NULL, 0x9e0642024007420243071d029b0620029e064202),
(88, 'A1057', 0, NULL, 0, NULL, 0x9e06120243070f024707e8019406e8019e061202),
(89, 'A1058', 0, NULL, 0, NULL, 0x9b06c4014307bb0143079a01a2069a019b06c401),
(90, 'A1059', 0, NULL, 0, NULL, 0xa206970140079a0139077b0197067801a2069701),
(91, 'A1060', 0, NULL, 0, NULL, 0x9b0672013c077b013c075601a20653019b067201),
(92, 'A1061', 0, NULL, 0, NULL, 0x9b064b0139074b0139073201a2062f019b064b01),
(93, 'A1062', 0, NULL, 0, NULL, 0x9b062f01390729013c07080194060a019b062f01),
(94, 'A1063', 0, NULL, 0, NULL, 0x9b06080139070d013907e6009e06e6009b060801),
(95, 'A1064', 0, NULL, 0, NULL, 0x9406e6003907e3003507bf009706c2009406e600),
(96, 'A1065', 0, NULL, 0, NULL, 0x9406c2003507b9002b0797009406a3009406c200),
(97, 'A1066', 0, NULL, 0, NULL, 0x9b069700350797003507760097067b009b069700),
(98, 'A1067', 0, NULL, 0, NULL, 0x94067b00320776003907540094065a0094067b00),
(99, 'A1068', 0, NULL, 0, NULL, 0x94065a0032075400320730009006320094065a00),
(100, 'A1069', 0, NULL, 0, NULL, 0x90063200320732002b070e008a06160090063200),
(101, 'A1115', 0, NULL, 0, NULL, 0x6b006606ba007406f1001806a2000f066b006606),
(102, 'A1116', 0, NULL, 0, NULL, 0xc7007706130185066c013406f7001806c7007706),
(103, 'A1117', 0, NULL, 0, NULL, 0x1301850654019b06bf0155066c013f0613018506),
(104, 'A1118', 0, NULL, 0, NULL, 0x510199068801b5060a026f06bb01530651019906),
(105, 'A1142', 0, NULL, 0, NULL, 0xed00120688013906a3011a060901f305ed001206),
(106, 'A1119', 0, NULL, 0, NULL, 0x2202bd066402bd0660026c0629026f062202bd06),
(107, 'A1120', 0, NULL, 0, NULL, 0x64026c06a80271069e02bd065d02bd0664026c06),
(108, 'A1121', 0, NULL, 0, NULL, 0xa802c306e602c606ea026f06a2026c06a802c306),
(109, 'A1122', 0, NULL, 0, NULL, 0xea027106e302c3063503c30632037406ea027106),
(110, 'A1123', 0, NULL, 0, NULL, 0x390374063503c3067303c3067a03770639037406),
(111, 'A1124', 0, NULL, 0, NULL, 0x7d03c80681037706c2037a06bf03d1067d03c806),
(112, 'A1125', 0, NULL, 0, NULL, 0xc203d1060304d40607047a06c9037706c203d106),
(113, 'A1126', 0, NULL, 0, NULL, 0x0e04d106070477064f047a064c04cb060e04d106),
(114, 'A1127', 0, NULL, 0, NULL, 0x6e04ba06a504bd06a80477066e0477066e04ba06),
(115, 'A1128', 0, NULL, 0, NULL, 0xc004ba060505bd060c057d06c7047406c004ba06),
(116, 'A1129', 0, NULL, 0, NULL, 0x100574064a0577064d05280610052b0610057406),
(117, 'A1130', 0, NULL, 0, NULL, 0x0c052b0605056c06cb047106cb042b060c052b06),
(118, 'A1131', 0, NULL, 0, NULL, 0xc4042b06c404710683046f0686042806c4042b06),
(119, 'A1132', 0, NULL, 0, NULL, 0x7f04280683046f064504690645042e067f042806),
(120, 'A1133', 0, NULL, 0, NULL, 0x37046906f6036906f903280641042b0637046906),
(121, 'A1134', 0, NULL, 0, NULL, 0xf9032b06f6036906bb036606bb032806f9032b06),
(122, 'A1135', 0, NULL, 0, NULL, 0xaa0363066903610669032306a7032606aa036306),
(123, 'A1136', 0, NULL, 0, NULL, 0x6c031a06650363062b035e062b0323066c031a06),
(124, 'A1137', 0, NULL, 0, NULL, 0x28031d0624035e06e6025b06e602200628031d06),
(125, 'A1138', 0, NULL, 0, NULL, 0xdf021d06e30261069b025806a8022306df021d06),
(126, 'A1139', 0, NULL, 0, NULL, 0x90025e06530258064f0226069b021d0690025e06),
(127, 'A1140', 0, NULL, 0, NULL, 0x4c0255060002550603022306480228064c025506),
(128, 'A1141', 0, NULL, 0, NULL, 0xe1014d0695013406a7011206f9011a06e1014d06),
(129, 'A1299', 0, NULL, 0, NULL, 0x7c02b805af02b505af027d057c027b057c02b805),
(130, 'A1300', 0, NULL, 0, NULL, 0xba02b505c4027805ed027b05ed02b305ba02b505),
(131, 'A1301', 0, NULL, 0, NULL, 0x0903b50505037b05390380053903b3050903b505),
(132, 'A1302', 0, NULL, 0, NULL, 0x5103bb058103bb057d0380054d037b055103bb05),
(133, 'A1303', 0, NULL, 0, NULL, 0x99037d059903bb05cd03b805d0037d0599037d05),
(134, 'A1304', 0, NULL, 0, NULL, 0xeb038305eb03b8051c04b50518047d05eb038305),
(135, 'A1305', 0, NULL, 0, NULL, 0x370480053004b8056704b50567047d0537048005),
(136, 'A1306', 0, NULL, 0, NULL, 0x8d047b058a04be05cb04ad05cb047d058d047b05),
(137, 'A1307', 0, NULL, 0, NULL, 0x0c0583050905be05ce04b305d5047d050c058305),
(138, 'A1308', 0, NULL, 0, NULL, 0x100583051005bb054305be054305800510058305),
(139, 'A1289', 0, NULL, 0, NULL, 0x10054805400545053905080510050a0510054805),
(140, 'A1290', 0, NULL, 0, NULL, 0xfe040a0502054505d5044505ce040505fe040a05),
(141, 'A1291', 0, NULL, 0, NULL, 0xb3040a05ba0442058604420583040a05b3040a05),
(142, 'A1292', 0, NULL, 0, NULL, 0x6b04100567044b0537044e053e0410056b041005),
(143, 'A1293', 0, NULL, 0, NULL, 0x22040d0511044b05e5034b05eb03100522040d05),
(144, 'A1294', 1, NULL, 0, NULL, 0xd0030a05d3034205a0034e059c030d05d0030a05),
(145, 'A1295', 0, NULL, 0, NULL, 0x88030d058b03480554034b054d03100588030d05),
(146, 'A1296', 0, NULL, 0, NULL, 0x4d0313054003500510034e0510030d054d031305),
(147, 'A1297', 0, NULL, 0, NULL, 0xf4021305f4024805c4024b05c4021605f4021305),
(148, 'A1298', 0, NULL, 0, NULL, 0xac0248057c02500571021005ac021605ac024805);

-- --------------------------------------------------------

--
-- Structure de la table `notifications`
--

CREATE TABLE `notifications` (
  `notif_id` int(11) NOT NULL,
  `notif_emplacement` int(11) DEFAULT NULL,
  `notif_commentaire` text NOT NULL,
  `notif_photo` longblob,
  `notif_masquer_fossoy` tinyint(1) NOT NULL DEFAULT '0',
  `notif_masquer_servicepop` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `permissions`
--

CREATE TABLE `permissions` (
  `admin` int(11) NOT NULL,
  `fossoyeur` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `personnes_contact`
--

CREATE TABLE `personnes_contact` (
  `pc_id` int(11) NOT NULL,
  `pc_nom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `pc_prenom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `pc_tel` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `pc_adresse` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `locville_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `personnes_contact`
--

INSERT INTO `personnes_contact` (`pc_id`, `pc_nom`, `pc_prenom`, `pc_tel`, `pc_adresse`, `locville_id`) VALUES
(6, 'Mothé', 'Laurent', '0480 20 16 89', 'Rue Basse 496', 28),
(7, 'Salmons', 'Dexter', '0498 82 34 56', 'Pont du Chêne 273', 28),
(8, 'Jobin', 'Eulalie', '0470 12 55 75', 'Rue du Presbytère 260', 28),
(9, 'Cotuand', 'Kerman', '0477 39 47 07', 'Rue du Stade 430', 28),
(10, 'Robitaille', 'Zara', '0473 44 72 16', 'Kerkstraat 189', 28),
(11, 'Duplessis', 'Azura', '0477 53 89 15', 'Maskenstraat 21', 28),
(12, 'Lazure', 'Chandler', '0474 16 21 19', 'Rue du Thisnes 483', 28),
(13, 'Cressac', 'Claude', '0471 27 55 32', 'Aven Ackers 365', 28),
(14, 'Riquier', 'Jeanne', '0491 23 88 32', 'Route de Vonèche 197', 28),
(15, 'Rouze', 'Ganelon', '0471 45 58 35', 'Dijkstraat 38', 28),
(16, 'Brian', 'Maurice', '0494 85 80 51', 'Rue Jean Lorette 90', 28),
(17, 'Lafontaine', 'Gabriel', '0482 65 80 82', 'Raas van Gaverestraat 147', 28),
(18, 'Sarrazin', 'Édouard', '0493 97 66 65', 'Rue Bois des Fosses 342', 28),
(19, 'Huppé', 'Mandel', '0487 67 81 88', 'Kerkstraat 142', 28),
(20, 'Sylvain', 'Fabien', '0482 33 89 67', 'Jagerij 87', 28),
(21, 'Perrault', 'Odo', '0475 65 28 39', 'Heuvenstraat 181', 28),
(22, 'Varieur', 'Iva', '0477 43 32 25', 'Heuvenstraat 208', 28),
(23, 'Josseaume', 'Karlotta', '0497 26 69 03', 'Westdorp 32', 28),
(24, 'Souplet', 'Noémi', '0490 14 06 48', 'Rue des Taillis 145', 28),
(25, 'Raymond', 'Manon', '0477 89 87 17', 'Rue du Monument 330', 28),
(26, 'Gousse', 'Vick', '0480 66 10 32', 'Jagerij 256', 28),
(27, 'Austin', 'Honoré', '0485 93 30 50', 'Luchthavenlaan 61', 28),
(28, 'Leclerc', 'Arnou', '0476 14 93 36', 'Rue Jean Lorette 346', 28),
(29, 'Batard', 'Yseult', '0471 48 60 63', 'Rue des Laderies 158', 28),
(30, 'Lereau', 'Vail', '0492 17 71 39', 'Brixtonlaan 436', 28);

-- --------------------------------------------------------

--
-- Structure de la table `t_commentaire`
--

CREATE TABLE `t_commentaire` (
  `com_id` int(11) NOT NULL,
  `com_commentaire` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `t_commentaire`
--

INSERT INTO `t_commentaire` (`com_id`, `com_commentaire`) VALUES
(68, '');

-- --------------------------------------------------------

--
-- Structure de la table `t_histoire`
--

CREATE TABLE `t_histoire` (
  `h_id` int(11) NOT NULL,
  `h_histoire` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Structure de la table `t_loc_ville`
--

CREATE TABLE `t_loc_ville` (
  `locville_id` int(11) NOT NULL,
  `locville_cp` int(11) DEFAULT NULL,
  `locville_ville` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `Pays_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `t_loc_ville`
--

INSERT INTO `t_loc_ville` (`locville_id`, `locville_cp`, `locville_ville`, `Pays_id`) VALUES
(28, 1310, 'La Hulpe', NULL);

-- --------------------------------------------------------

--
-- Structure de la table `t_login`
--

CREATE TABLE `t_login` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `t_login`
--

INSERT INTO `t_login` (`id`, `username`, `password`) VALUES
(1, 'admin', 'ntl2HtFLe9MG8jx2pvTZVg=='),
(2, 'user', 'zxjy0fl7XFAKh/Q0SJsxpw==');

-- --------------------------------------------------------

--
-- Structure de la table `t_pays`
--

CREATE TABLE `t_pays` (
  `Pays_id` int(11) NOT NULL,
  `Pays_nom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index pour les tables exportées
--

--
-- Index pour la table `beneficiaires`
--
ALTER TABLE `beneficiaires`
  ADD PRIMARY KEY (`ben_id`),
  ADD KEY `FK_beneficiaires_locville_id` (`locville_id`);

--
-- Index pour la table `beneficier`
--
ALTER TABLE `beneficier`
  ADD PRIMARY KEY (`con_id`,`ben_id`),
  ADD KEY `FK_Beneficier_ben_id` (`ben_id`),
  ADD KEY `con_id` (`con_id`);

--
-- Index pour la table `concessionnaires`
--
ALTER TABLE `concessionnaires`
  ADD PRIMARY KEY (`csnr_id`),
  ADD KEY `FK_concessionnaires_locville_id` (`locville_id`);

--
-- Index pour la table `concessions`
--
ALTER TABLE `concessions`
  ADD PRIMARY KEY (`con_id`),
  ADD KEY `FK_concessions_empl_id` (`empl_id`),
  ADD KEY `FK_concessions_csnr_id` (`csnr_id`),
  ADD KEY `FK_concessions_com_id` (`com_id`);

--
-- Index pour la table `defunts`
--
ALTER TABLE `defunts`
  ADD PRIMARY KEY (`def_id`),
  ADD KEY `FK_defunts_locville_id` (`locville_id`),
  ADD KEY `empl_id` (`empl_id`),
  ADD KEY `FK_def_lieu_deces` (`pc_id`) USING BTREE;

--
-- Index pour la table `emplacements`
--
ALTER TABLE `emplacements`
  ADD PRIMARY KEY (`empl_id`),
  ADD UNIQUE KEY `empl_reference` (`empl_reference`),
  ADD KEY `empl_histoire` (`hist_id`);

--
-- Index pour la table `notifications`
--
ALTER TABLE `notifications`
  ADD PRIMARY KEY (`notif_id`),
  ADD KEY `notif_emplacement` (`notif_emplacement`);

--
-- Index pour la table `personnes_contact`
--
ALTER TABLE `personnes_contact`
  ADD PRIMARY KEY (`pc_id`),
  ADD KEY `FK_personnes_contact_locville_id` (`locville_id`);

--
-- Index pour la table `t_commentaire`
--
ALTER TABLE `t_commentaire`
  ADD PRIMARY KEY (`com_id`);

--
-- Index pour la table `t_histoire`
--
ALTER TABLE `t_histoire`
  ADD PRIMARY KEY (`h_id`);

--
-- Index pour la table `t_loc_ville`
--
ALTER TABLE `t_loc_ville`
  ADD PRIMARY KEY (`locville_id`),
  ADD KEY `FK_T_Loc_ville_Pays_id` (`Pays_id`);

--
-- Index pour la table `t_login`
--
ALTER TABLE `t_login`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `t_pays`
--
ALTER TABLE `t_pays`
  ADD PRIMARY KEY (`Pays_id`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `beneficiaires`
--
ALTER TABLE `beneficiaires`
  MODIFY `ben_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=150;
--
-- AUTO_INCREMENT pour la table `concessionnaires`
--
ALTER TABLE `concessionnaires`
  MODIFY `csnr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=314;
--
-- AUTO_INCREMENT pour la table `concessions`
--
ALTER TABLE `concessions`
  MODIFY `con_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=205;
--
-- AUTO_INCREMENT pour la table `defunts`
--
ALTER TABLE `defunts`
  MODIFY `def_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=307;
--
-- AUTO_INCREMENT pour la table `emplacements`
--
ALTER TABLE `emplacements`
  MODIFY `empl_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=149;
--
-- AUTO_INCREMENT pour la table `notifications`
--
ALTER TABLE `notifications`
  MODIFY `notif_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT pour la table `personnes_contact`
--
ALTER TABLE `personnes_contact`
  MODIFY `pc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;
--
-- AUTO_INCREMENT pour la table `t_commentaire`
--
ALTER TABLE `t_commentaire`
  MODIFY `com_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;
--
-- AUTO_INCREMENT pour la table `t_histoire`
--
ALTER TABLE `t_histoire`
  MODIFY `h_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=75;
--
-- AUTO_INCREMENT pour la table `t_loc_ville`
--
ALTER TABLE `t_loc_ville`
  MODIFY `locville_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
--
-- AUTO_INCREMENT pour la table `t_login`
--
ALTER TABLE `t_login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `t_pays`
--
ALTER TABLE `t_pays`
  MODIFY `Pays_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `beneficiaires`
--
ALTER TABLE `beneficiaires`
  ADD CONSTRAINT `FK_beneficiaires_locville_id` FOREIGN KEY (`locville_id`) REFERENCES `t_loc_ville` (`locville_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `beneficier`
--
ALTER TABLE `beneficier`
  ADD CONSTRAINT `FK_Beneficier_ben_id` FOREIGN KEY (`ben_id`) REFERENCES `beneficiaires` (`ben_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_Beneficier_con_id` FOREIGN KEY (`con_id`) REFERENCES `concessions` (`con_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `concessionnaires`
--
ALTER TABLE `concessionnaires`
  ADD CONSTRAINT `FK_concessionaires_locville_id` FOREIGN KEY (`locville_id`) REFERENCES `t_loc_ville` (`locville_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `concessions`
--
ALTER TABLE `concessions`
  ADD CONSTRAINT `FK_concessions_com_id` FOREIGN KEY (`com_id`) REFERENCES `t_commentaire` (`com_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_concessions_csnr_id` FOREIGN KEY (`csnr_id`) REFERENCES `concessionnaires` (`csnr_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_concessions_empl_id` FOREIGN KEY (`empl_id`) REFERENCES `emplacements` (`empl_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `defunts`
--
ALTER TABLE `defunts`
  ADD CONSTRAINT `FK_defunts_empl_id` FOREIGN KEY (`empl_id`) REFERENCES `emplacements` (`empl_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_defunts_locville_id` FOREIGN KEY (`locville_id`) REFERENCES `t_loc_ville` (`locville_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_defunts_pc_id` FOREIGN KEY (`pc_id`) REFERENCES `personnes_contact` (`pc_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `emplacements`
--
ALTER TABLE `emplacements`
  ADD CONSTRAINT `fk_emplacements_hist_id` FOREIGN KEY (`hist_id`) REFERENCES `t_histoire` (`h_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `notifications`
--
ALTER TABLE `notifications`
  ADD CONSTRAINT `notifications_ibfk_1` FOREIGN KEY (`notif_emplacement`) REFERENCES `emplacements` (`empl_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `personnes_contact`
--
ALTER TABLE `personnes_contact`
  ADD CONSTRAINT `FK_pcontact_locville_id` FOREIGN KEY (`locville_id`) REFERENCES `t_loc_ville` (`locville_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Contraintes pour la table `t_loc_ville`
--
ALTER TABLE `t_loc_ville`
  ADD CONSTRAINT `FK_T_Loc_ville_Pays_id` FOREIGN KEY (`Pays_id`) REFERENCES `t_pays` (`Pays_id`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
