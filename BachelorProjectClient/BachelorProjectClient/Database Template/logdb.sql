-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Värd: 127.0.0.1
-- Tid vid skapande: 10 mars 2020 kl 10:31
-- Serverversion: 10.4.11-MariaDB
-- PHP-version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databas: `logdb`
--

-- --------------------------------------------------------

--
-- Tabellstruktur `resultdatalog`
--

CREATE TABLE `resultdatalog` (
  `id` int(11) NOT NULL,
  `clientId` int(11) NOT NULL,
  `totalTime` int(11) NOT NULL,
  `requestContentSize` int(11) DEFAULT NULL,
  `responseContentSize` int(11) DEFAULT NULL,
  `executionNO` int(11) DEFAULT NULL,
  `iteration` int(11) DEFAULT NULL,
  `dbName` varchar(255) DEFAULT NULL,
  `testCase` varchar(25) DEFAULT NULL,
  `api` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Index för dumpade tabeller
--

--
-- Index för tabell `resultdatalog`
--
ALTER TABLE `resultdatalog`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT för dumpade tabeller
--

--
-- AUTO_INCREMENT för tabell `resultdatalog`
--
ALTER TABLE `resultdatalog`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
