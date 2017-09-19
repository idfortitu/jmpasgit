-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Sam 12 Août 2017 à 19:18
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
(1, 'Bennom', 'BenPrenom', '2017-05-01', 'Mari', 'rue ben1', 1),
(2, 'bennom2', 'benprenom2', '2017-05-02', 'femme', 'rue ben2', 2),
(3, 'bennom3', 'benprenom3', '2017-05-03', 'oncle', 'rue du ben3', 2),
(4, 'bennom4', 'benprenom4', '2017-05-03', 'oncle', 'rue du ben4', 2),
(5, 'bennom5', 'benprenom5', '2017-05-03', 'oncle', 'rue du ben5', 2),
(6, 'bennom6', 'benprenom6', '2017-05-03', 'oncle', 'rue du ben6', 1),
(7, 'bennom7', 'benprenom7', '2017-05-03', 'oncle', 'rue du ben7', 2),
(8, 'bennom8', 'benprenom8', '2017-05-03', 'oncle', 'rue du ben8', 2),
(9, 'bennom9', 'benprenom9', '2017-05-03', 'oncle', 'rue du ben9', 2),
(10, 'bennom10', 'benprenom10', '2017-05-03', 'oncle', 'rue du ben10', 2),
(11, 'bennom11', 'benprenom11', '2017-05-03', 'oncle', 'rue du ben11', 2),
(12, 'bennom12', 'benprenom12', '2017-05-03', 'oncle', 'rue du ben12', 2),
(13, 'bennom13', 'benprenom13', '2017-05-02', 'femme', 'rue ben13', 2),
(14, 'bennom14', 'benprenom14', '2017-05-03', 'oncle', 'rue du ben14', 2),
(15, 'bennom15', 'benprenom15', '2017-05-03', 'oncle', 'rue du ben15', 1),
(16, 'bennom16', 'benprenom16', '2017-05-03', 'oncle', 'rue du ben16', 2),
(17, 'bennom17', 'benprenom17', '2017-05-03', 'oncle', 'rue du ben17', 2),
(18, 'bennom18', 'benprenom18', '2017-05-03', 'oncle', 'rue du ben18', 2),
(19, 'bennom19', 'benprenom19', '2017-05-03', 'oncle', 'rue du ben19', 2),
(20, 'bennom20', 'benprenom20', '2017-05-03', 'oncle', 'rue du ben20', 2),
(21, 'bennom21', 'benprenom21', '2017-05-03', 'oncle', 'rue du ben21', 2),
(22, 'bennom22', 'benprenom22', '2017-05-03', 'oncle', 'rue du ben22', 2),
(23, 'bennom23', 'benprenom23', '2017-05-03', 'oncle', 'rue du ben23', 2),
(30, 'krouton', 'jean', '1314-12-12', 'chien', 'là', 6),
(32, 'bidule', 'machin', '1314-12-12', 'chien', 'rue du coin', 1);

-- --------------------------------------------------------

--
-- Structure de la table `beneficier`
--

CREATE TABLE `beneficier` (
  `con_id` int(11) NOT NULL,
  `ben_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `beneficier`
--

INSERT INTO `beneficier` (`con_id`, `ben_id`) VALUES
(2, 1),
(2, 2),
(1, 3),
(2, 3),
(6, 4),
(7, 5),
(8, 6),
(9, 7),
(10, 8),
(3, 10),
(3, 11),
(3, 12),
(3, 13),
(4, 15),
(5, 16),
(7, 20),
(8, 21),
(9, 22),
(10, 23),
(24, 32);

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
(1, 'consnom1', 'consprenom1', '2017-05-11', 'rue du cons1', 15478552, '255145525', 2),
(2, 'consnom2', 'consprenom2', '2017-05-08', 'rue du cons2', 58288848, '1478569', NULL),
(3, 'consnom3', 'consprenom1', '2017-05-11', 'rue du cons3', 15478552, '2551525', 2),
(4, 'consnom4', 'consprenom2', '2017-05-08', 'rue du cons4', 58288848, '14785269', NULL),
(5, 'consnom5', 'consprenom1', '2017-05-11', 'rue du cons5', 15478552, '255185525', 2),
(6, 'consnom6', 'consprenom2', '2017-05-08', 'rue du cons6', 58288848, '147852369', NULL),
(7, 'consnom7', 'consprenom1', '2017-05-11', 'rue du cons7', 15478552, '2551400055', 2),
(8, 'consnom8', 'consprenom2', '2017-05-08', 'rue du cons8', 58288848, '14785212369', NULL),
(9, 'consnom9', 'consprenom1', '2017-05-11', 'rue du cons9', 15478552, '200005', 2),
(10, 'consnom10', 'consprenom2', '2017-05-08', 'rue du cons10', 58288848, '0000069', NULL),
(14, 'Durand', 'Jean', '1212-12-12', '4 rue des glands', 23223323456, '23454345', 1),
(15, 'Durand', 'Julie', '1215-12-11', 'rue du ciment', 12142131243, '12354', 1),
(17, 'crapaud', 'jean', NULL, '', NULL, '', NULL),
(18, 'azeaze', 'azeaze', NULL, '', NULL, '', NULL),
(19, 'aze', 'aze', NULL, '', NULL, '', NULL),
(20, 'aze', 'aze', NULL, '', NULL, '', NULL),
(21, 'cession', 'ducon', NULL, '', NULL, '', NULL),
(22, 'az', 'az', NULL, '', NULL, '', NULL),
(23, 'aze', 'oiu', NULL, '', NULL, '', NULL),
(24, 'zer', 'er', NULL, '', NULL, '', NULL),
(25, 'Leconcessionnaire', 'Auyefz4', '1970-12-12', '3 rue des concessions', 98765098765, '123456789', 1),
(26, 'Cessionnaire', 'Con', '1970-12-12', '3 rue de la concession', 12087736478, '098767890', 12),
(27, 'Ducon-Cession', 'Mireille', '2001-12-12', 'rue des concessionnaires, 112', 12746287461, '666', 4),
(28, 'McCain', 'Descartes', '1050-12-12', 'Rue des flèches', 9876545678, '098765', 2),
(29, 'dgaj', 'odsef', NULL, '', NULL, '', NULL),
(30, 'jeann', 'jean', NULL, '', NULL, '', NULL),
(31, 'feiug', 'hein', NULL, '', NULL, '', NULL);

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
  `con_montant_paye` decimal(7,0) DEFAULT NULL,
  `empl_id` int(11) NOT NULL,
  `csnr_id` int(11) NOT NULL,
  `com_id` int(11) DEFAULT NULL,
  `h_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `concessions`
--

INSERT INTO `concessions` (`con_id`, `con_numero`, `con_date_debut`, `con_date_fin`, `con_nbre_renovations`, `con_montant_paye`, `empl_id`, `csnr_id`, `com_id`, `h_id`) VALUES
(1, 20161, '2012-05-01', '2018-05-25', 0, '100', 2, 1, 1, 1),
(2, 20162, '2012-05-08', '2017-12-10', 0, '150', 2, 2, 1, 1),
(3, 20163, '2012-05-01', '2017-05-02', 1, '200', 3, 3, 1, 1),
(4, 20164, '2012-05-01', '2017-05-25', 0, '100', 5, 4, 1, 1),
(5, 20165, '2012-05-08', '2017-05-10', 0, '150', 4, 2, 1, 1),
(6, 20166, '2012-05-01', '2017-05-02', 1, '200', 7, 1, 1, 1),
(7, 20167, '2012-05-01', '2017-05-25', 0, '100', 9, 6, 1, 1),
(8, 20168, '2012-05-08', '2017-05-10', 0, '150', 10, 2, 1, 1),
(9, 20169, '2012-05-01', '2017-05-02', 1, '200', 3, 1, 1, 1),
(10, 201610, '2012-05-01', '2017-05-25', 0, '100', 12, 1, 1, 1),
(11, 201611, '2012-05-08', '2017-05-10', 0, '150', 15, 4, 1, 1),
(12, 201612, '2012-05-01', '2017-05-02', 1, '200', 16, 8, 1, 1),
(13, 201613, '2017-05-01', '2017-05-25', 0, '100', 17, 8, 1, 1),
(14, 201614, '2017-05-08', '2017-05-10', 0, '150', 15, 2, 1, 1),
(15, 201615, '2017-05-01', '2017-05-02', 1, '200', 15, 1, 1, 1),
(19, NULL, '1212-12-12', '1227-12-12', 0, '13', 4, 18, 5, 2),
(20, NULL, '1212-12-12', '1227-12-12', 0, '12', 4, 19, 6, 3),
(21, NULL, '1111-11-11', '1126-11-11', 0, '23', 3, 20, 7, 4),
(22, NULL, '1311-12-12', '1326-12-12', 0, '23', 3, 22, 9, 6),
(23, NULL, '1212-12-12', '1227-12-12', 0, '42', 3, 23, 10, 7),
(24, NULL, '1212-12-12', '1227-12-12', 0, '23', 1, 24, 11, 8),
(25, NULL, '2007-12-12', '2037-12-12', 0, '900', 13, 25, 12, 9),
(26, NULL, '2009-12-12', '2039-12-12', 0, '250', 4, 26, 13, 10),
(27, NULL, '2007-12-12', '2037-12-12', 0, '250', 6, 27, 14, 11),
(28, NULL, '1111-12-12', '1141-12-12', 0, '900', 7, 28, 15, 12),
(29, NULL, '1212-12-12', '1227-12-12', 0, '250', 3, 29, 16, 13),
(30, NULL, '1212-12-12', '1227-12-12', 0, '250', 3, 30, 17, 14),
(31, NULL, '1212-12-12', '1227-12-12', 0, '250', 3, 31, 18, 15);

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
(9, 10009, 201610009, 'defuntprenom9', 'defuntnom9', 'rue du defadresse 9', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 2, 1),
(10, 10010, 201610010, 'defuntprenom10', 'defuntnom10', 'rue du defadresse 10', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '1', 1, '2017-05-02', '2017-05-31', 12, 1),
(11, 10011, 201610011, 'defuntprenom11', 'defuntnom11', 'rue du defadresse 11', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 8, 1),
(12, 10012, 201610012, 'defuntprenom12', 'defuntnom12', 'rue du defadresse 12', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 2, 1),
(13, 10013, 201610013, 'defuntprenom13', 'defuntnom13', 'rue du defadresse 13', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '1', 1, '2017-05-02', '2017-05-31', 9, 1),
(14, 10014, 201610014, 'defuntprenom14', 'defuntnom14', 'rue du defadresse 14', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 2, 1),
(15, 10015, 201610015, 'defuntprenom15', 'defuntnom15', 'rue du defadresse 15', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 5, 1),
(16, 10016, 201610016, 'defuntprenom16', 'defuntnom16', 'rue du defadresse 16', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '1', 1, '2017-05-02', '2017-05-31', 4, 1),
(17, 10017, 201610017, 'defuntprenom17', 'defuntnom17', 'rue du defadresse 17', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 3, 1),
(18, 10018, 201610018, 'defuntprenom18', 'defuntnom18', 'rue du defadresse 18', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 7, 1),
(19, 10019, 201610019, 'defuntprenom19', 'defuntnom19', 'rue du defadresse 19', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 10, 1),
(20, 10020, 201610020, 'defuntprenom20', 'defuntnom20', 'rue du defadresse 20', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 11, 1),
(21, 20001, 201620001, 'defuntprenom21', 'defuntnom21', 'rue du defadresse 21', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '1', 1, '2017-05-02', '2017-05-31', 13, 1),
(22, 20002, 201620002, 'defuntprenom22', 'defuntnom22', 'rue du defadresse 22', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 13, 1),
(23, 20003, 201620003, 'defuntprenom23', 'defuntnom23', 'rue du defadresse 23', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 16, 1),
(24, 20004, 201620004, 'defuntprenom24', 'defuntnom24', 'rue du defadresse 24', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '1', 1, '2017-05-02', '2017-05-31', 14, 1),
(25, 20005, 201620005, 'defuntprenom25', 'defuntnom25', 'rue du defadresse 25', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 15, 1),
(26, 20006, 201620006, 'defuntprenom26', 'defuntnom26', 'rue du defadresse 26', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 17, 1),
(27, 20007, 201620007, 'defuntprenom27', 'defuntnom27', 'rue du defadresse 27', 1, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '1', 1, '2017-05-02', '2017-05-31', 14, 1),
(28, 20008, 201620008, 'defuntprenom28', 'defuntnom28', 'rue du defadresse 28', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 14, 1),
(29, 20009, 201620009, 'defuntprenom29', 'defuntnom29', 'rue du defadresse 29', 2, 'Marie', '2017-05-04', 'La bas', '2017-05-25', '2', 2, '2017-05-02', '2017-05-31', 2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `emplacements`
--

CREATE TABLE `emplacements` (
  `empl_id` int(11) NOT NULL,
  `empl_reference` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `empl_type` int(11) NOT NULL DEFAULT '0' COMMENT ' 	0=non précisé, 1=caveau, 2=concession, 3=fosse ordinaire 	',
  `empl_nb_places` int(11) DEFAULT NULL,
  `empl_monum_classe` tinyint(1) NOT NULL DEFAULT '0',
  `hist_id` int(11) DEFAULT NULL,
  `empl_coords` varbinary(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `emplacements`
--

INSERT INTO `emplacements` (`empl_id`, `empl_reference`, `empl_type`, `empl_nb_places`, `empl_monum_classe`, `hist_id`, `empl_coords`) VALUES
(1, 'A100', 0, 0, 0, NULL, 0xcf0015045b0110045601d903cf00d703cf001504),
(2, 'A200', 0, 10, 0, NULL, NULL),
(3, 'A300', 0, 10, 0, NULL, NULL),
(4, 'A400', 0, NULL, 0, NULL, NULL),
(5, 'A500', 0, 1, 0, NULL, NULL),
(6, 'A600', 0, 10, 0, NULL, NULL),
(7, 'A700', 0, 10, 0, NULL, NULL),
(8, 'A800', 0, 10, 0, NULL, NULL),
(9, 'A900', 0, 5, 0, NULL, NULL),
(10, 'A1000', 0, 1, 0, NULL, NULL),
(11, 'A1100', 0, 10, 0, NULL, NULL),
(12, 'A1200', 0, 10, 0, NULL, NULL),
(13, 'A1300', 0, 10, 0, NULL, NULL),
(14, 'A1400', 0, 5, 0, NULL, NULL),
(15, 'A1500', 0, 1, 0, NULL, NULL),
(16, 'A1600', 0, 10, 0, NULL, NULL),
(17, 'A1700', 0, 10, 0, NULL, NULL),
(18, 'A1800', 0, 10, 0, NULL, NULL),
(19, 'A1900', 0, 5, 0, NULL, NULL),
(20, 'A2000', 0, 1, 0, NULL, NULL),
(21, 'A2100', 0, 1, 0, NULL, NULL),
(22, 'A2200', 0, 10, 0, NULL, NULL),
(23, 'A2300', 0, 10, 0, NULL, NULL),
(24, 'A2400', 0, 10, 0, NULL, NULL),
(25, 'A2500', 0, 5, 0, NULL, NULL),
(26, 'A2600', 0, 1, 0, NULL, NULL),
(27, 'A2700', 0, 10, 0, NULL, NULL),
(28, 'A2800', 0, 10, 0, NULL, NULL),
(29, 'A2900', 0, 10, 0, NULL, NULL),
(30, 'A3000', 0, 5, 0, NULL, NULL),
(31, 'A3100', 0, 1, 0, NULL, NULL);

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
(1, 'persnom1', 'persprenom1', '14557751', 'rue de perscontact1', 2),
(2, 'persnom2', 'persprenom2', '1450002727', 'rue de persocontact2', 4),
(3, 'persnom3', 'persprenom3', '17751', 'rue de perscontact3', 2),
(4, 'persnom4', 'persprenom4', '14545072727', 'rue de persocontact4', 4),
(5, 'persnom5', 'persprenom5', '145500051', 'rue de perscontact5', 2),
(6, 'persnom6', 'persprenom6', '1454572727', 'rue de persocontact6', 4),
(7, 'persnom7', 'persprenom7', '19999951', 'rue de perscontact7', 2),
(8, 'persnom8', 'persprenom8', '1458888827', 'rue de persocontact8', 4),
(9, 'persnom9', 'persprenom9', '146666751', 'rue de perscontact9', 2),
(10, 'persnom10', 'persprenom10', '1455552727', 'rue de persocontact10', 4),
(11, 'persnom11', 'persprenom11', '14444451', 'rue de perscontact11', 2),
(12, 'persnom12', 'persprenom12', '143333727', 'rue de persocontact12', 4);

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
(1, 'com com'),
(2, ''),
(3, ''),
(4, ''),
(5, ''),
(6, ''),
(7, ''),
(8, ''),
(9, ''),
(10, ''),
(11, ''),
(12, 'dépêchez-vous, il n\'est plus très frais'),
(13, ''),
(14, ''),
(15, ''),
(16, ''),
(17, ''),
(18, '');

-- --------------------------------------------------------

--
-- Structure de la table `t_histoire`
--

CREATE TABLE `t_histoire` (
  `h_id` int(11) NOT NULL,
  `h_histoire` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `t_histoire`
--

INSERT INTO `t_histoire` (`h_id`, `h_histoire`) VALUES
(1, 'pas d\'histoire'),
(2, ''),
(3, ''),
(4, ''),
(5, ''),
(6, ''),
(7, ''),
(8, ''),
(9, ''),
(10, ''),
(11, ''),
(12, ''),
(13, ''),
(14, ''),
(15, '');

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
(1, 1310, 'La hulpe', 2),
(2, 1410, 'Waterloo', 2),
(4, 666, 'Hell', 5),
(6, 9876, 'Vancouver', 5),
(12, 243, 'Trouperdu-Les-Bains-De-Pieds-À-La-Lavande', 3),
(16, 458, 'Outabobo', 7);

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
(1, 'admin', 'ntl2HtFLe9MG8jx2pvTZVg==');

-- --------------------------------------------------------

--
-- Structure de la table `t_pays`
--

CREATE TABLE `t_pays` (
  `Pays_id` int(11) NOT NULL,
  `Pays_nom` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Contenu de la table `t_pays`
--

INSERT INTO `t_pays` (`Pays_id`, `Pays_nom`) VALUES
(1, 'Portugal'),
(2, 'Belgique'),
(3, 'France'),
(4, 'Allemagne'),
(5, 'Canada'),
(6, 'Talboukistan'),
(7, 'Gabon');

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
  MODIFY `ben_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT pour la table `concessionnaires`
--
ALTER TABLE `concessionnaires`
  MODIFY `csnr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT pour la table `concessions`
--
ALTER TABLE `concessions`
  MODIFY `con_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT pour la table `defunts`
--
ALTER TABLE `defunts`
  MODIFY `def_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
--
-- AUTO_INCREMENT pour la table `emplacements`
--
ALTER TABLE `emplacements`
  MODIFY `empl_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=32;
--
-- AUTO_INCREMENT pour la table `personnes_contact`
--
ALTER TABLE `personnes_contact`
  MODIFY `pc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT pour la table `t_commentaire`
--
ALTER TABLE `t_commentaire`
  MODIFY `com_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT pour la table `t_histoire`
--
ALTER TABLE `t_histoire`
  MODIFY `h_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT pour la table `t_loc_ville`
--
ALTER TABLE `t_loc_ville`
  MODIFY `locville_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
--
-- AUTO_INCREMENT pour la table `t_login`
--
ALTER TABLE `t_login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT pour la table `t_pays`
--
ALTER TABLE `t_pays`
  MODIFY `Pays_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
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
