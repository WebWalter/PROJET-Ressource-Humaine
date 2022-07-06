-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  mer. 06 juil. 2022 à 06:01
-- Version du serveur :  10.4.10-MariaDB
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ressh`
--

-- --------------------------------------------------------

--
-- Structure de la table `absences_retards`
--

DROP TABLE IF EXISTS `absences_retards`;
CREATE TABLE IF NOT EXISTS `absences_retards` (
  `ID` int(25) NOT NULL AUTO_INCREMENT,
  `Duree` int(30) NOT NULL,
  `Type` varchar(50) NOT NULL,
  `Date_retard` date DEFAULT NULL,
  `Date_debut_absence` date DEFAULT NULL,
  `Date_retour_absence` date DEFAULT NULL,
  `Motif` varchar(50) NOT NULL,
  `Statut` varchar(50) DEFAULT NULL,
  `Matricule_employe` int(25) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `Matricule_employé` (`Matricule_employe`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `absences_retards`
--

INSERT INTO `absences_retards` (`ID`, `Duree`, `Type`, `Date_retard`, `Date_debut_absence`, `Date_retour_absence`, `Motif`, `Statut`, `Matricule_employe`) VALUES
(12, 3, 'Retards', '2021-07-28', NULL, NULL, 'Mauvais réveil', 'Injustifié', 1),
(13, 5, 'Absences', NULL, '2021-07-28', '2021-08-03', 'Opératio médicale', 'Injustifié', 2);

-- --------------------------------------------------------

--
-- Structure de la table `demandes`
--

DROP TABLE IF EXISTS `demandes`;
CREATE TABLE IF NOT EXISTS `demandes` (
  `ID_demande` int(25) NOT NULL AUTO_INCREMENT,
  `Type_demande` varchar(25) NOT NULL,
  `Date_demande` date NOT NULL,
  `Date_debut` date DEFAULT NULL,
  `Date_fin` date DEFAULT NULL,
  `Montant` int(50) DEFAULT NULL,
  `Motif_demande` varchar(150) NOT NULL,
  `Reponse_demande` varchar(30) DEFAULT NULL,
  `Date_reponse` date DEFAULT NULL,
  `Matricule_employe` int(25) NOT NULL,
  PRIMARY KEY (`ID_demande`),
  KEY `Matricule_employé` (`Matricule_employe`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `demandes`
--

INSERT INTO `demandes` (`ID_demande`, `Type_demande`, `Date_demande`, `Date_debut`, `Date_fin`, `Montant`, `Motif_demande`, `Reponse_demande`, `Date_reponse`, `Matricule_employe`) VALUES
(1, 'Salaire', '2021-08-01', NULL, NULL, 40000, 'frais médicaux', 'Accepter', '2021-08-01', 4),
(2, 'Formation', '2021-07-28', NULL, NULL, NULL, 'Pour gagner de l\'expérience', NULL, NULL, 5),
(3, 'Congé', '2021-07-28', '2021-07-29', '2021-08-03', NULL, 'Cause de maladie du foie', NULL, NULL, 1),
(4, 'Salaire', '2021-07-28', NULL, NULL, 100000, 'Frais de réparation de voiture', 'Accepter', '2021-07-30', 3),
(5, 'Congé', '2021-07-30', '2021-08-04', '2021-08-13', NULL, 'Opération du tibia', 'Refuser', '2021-08-01', 3),
(6, 'Congé', '2021-07-31', '2021-07-31', '2021-07-31', NULL, 'jhg', NULL, NULL, 3),
(7, 'Formation', '2021-07-31', '2021-08-01', '2021-08-13', NULL, 'nvghvh', 'Accepter', '2021-08-01', 3);

-- --------------------------------------------------------

--
-- Structure de la table `employes`
--

DROP TABLE IF EXISTS `employes`;
CREATE TABLE IF NOT EXISTS `employes` (
  `Matricule` int(25) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `Nom` varchar(50) NOT NULL,
  `Mdp` varchar(50) NOT NULL,
  `Sexe` varchar(25) NOT NULL,
  `numTel` int(8) NOT NULL,
  `Poste` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Statut_Actuel` varchar(30) NOT NULL DEFAULT 'ACTIF',
  `Salaire` int(11) NOT NULL,
  `Photo` text NOT NULL,
  PRIMARY KEY (`Matricule`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `employes`
--

INSERT INTO `employes` (`Matricule`, `Prenom`, `Nom`, `Mdp`, `Sexe`, `numTel`, `Poste`, `Email`, `Statut_Actuel`, `Salaire`, `Photo`) VALUES
(1, 'Admin', 'Admin', 'Admin', 'Homme', 77000001, 'Ressources Humaine', 'Admin@RH.com', 'ACTIF', 200000, '0'),
(2, 'PDG', 'PDG', 'PDG', 'Homme', 77000000, 'PDG', 'PDG@RH.com', 'ACTIF', 300000, '0'),
(3, 'Test1', 'Employe1', 'Employe1', 'Masculin', 77000002, 'Simple utilisateur', 'EmployeT1@gmail.com', 'Actif', 150000, '0'),
(4, 'Test2', 'Employe2', 'Employe2', 'Féminin', 77000003, 'Simple utilisateur', 'EmployeT2@gmail.com', 'Actif', 152000, '1'),
(5, 'Test3', 'Employe3', 'Employe3', 'Féminin', 77000004, 'Simple utilisateur', 'EmployeT3@gmail.com', 'Actif', 150000, '1');

-- --------------------------------------------------------

--
-- Structure de la table `sanctions`
--

DROP TABLE IF EXISTS `sanctions`;
CREATE TABLE IF NOT EXISTS `sanctions` (
  `ID_sanction` int(50) NOT NULL AUTO_INCREMENT,
  `Date_sanction` date NOT NULL,
  `Date_retour` date DEFAULT NULL,
  `Type` varchar(50) NOT NULL,
  `Motif` varchar(100) NOT NULL,
  `Matricule_employe` int(50) NOT NULL,
  PRIMARY KEY (`ID_sanction`),
  KEY `Matricule_employe` (`Matricule_employe`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `sanctions`
--

INSERT INTO `sanctions` (`ID_sanction`, `Date_sanction`, `Date_retour`, `Type`, `Motif`, `Matricule_employe`) VALUES
(2, '2021-07-28', NULL, 'Avertissement ou blâme', 'Retards injustifié.', 5),
(3, '2021-07-14', NULL, 'Mutation', 'N\'a pas assez d\'experience', 4),
(5, '2021-07-28', NULL, 'Avertissement ou blâme', 'Mauvais Travail', 1);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absences_retards`
--
ALTER TABLE `absences_retards`
  ADD CONSTRAINT `absences_retards_ibfk_1` FOREIGN KEY (`Matricule_employe`) REFERENCES `employes` (`Matricule`);

--
-- Contraintes pour la table `demandes`
--
ALTER TABLE `demandes`
  ADD CONSTRAINT `demandes_ibfk_1` FOREIGN KEY (`Matricule_employe`) REFERENCES `employes` (`Matricule`);

--
-- Contraintes pour la table `sanctions`
--
ALTER TABLE `sanctions`
  ADD CONSTRAINT `sanctions_ibfk_1` FOREIGN KEY (`Matricule_employe`) REFERENCES `employes` (`Matricule`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
