-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 08, 2023 at 02:29 AM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `metafarmsdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `age_group`
--

CREATE TABLE `age_group` (
  `Age_Id` int(8) NOT NULL,
  `Age_Desc` varchar(30) NOT NULL,
  `Intake_levels` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `age_group`
--

INSERT INTO `age_group` (`Age_Id`, `Age_Desc`, `Intake_levels`) VALUES
(1, '30 Days Old', '0.9'),
(2, '20 Days Old', '1');

-- --------------------------------------------------------

--
-- Stand-in structure for view `animal`
-- (See below for the actual view)
--
CREATE TABLE `animal` (
`animal_id` int(8)
,`animal_name` varchar(50)
,`price` varchar(50)
,`feed_name` varchar(50)
,`gender_name` varchar(20)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `animaltofeed`
-- (See below for the actual view)
--
CREATE TABLE `animaltofeed` (
`animal_name` varchar(50)
,`feed_name` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `animaltogender`
-- (See below for the actual view)
--
CREATE TABLE `animaltogender` (
`animal_name` varchar(50)
,`gender_name` varchar(20)
);

-- --------------------------------------------------------

--
-- Table structure for table `animal_type`
--

CREATE TABLE `animal_type` (
  `Animal_ID` int(8) NOT NULL,
  `Animal_Name` varchar(50) NOT NULL,
  `Price` varchar(50) NOT NULL,
  `Feed_ID` int(8) NOT NULL,
  `Gender_Id` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `animal_type`
--

INSERT INTO `animal_type` (`Animal_ID`, `Animal_Name`, `Price`, `Feed_ID`, `Gender_Id`) VALUES
(1, 'Pig', '20$/pd', 1, 1),
(2, 'Chickem', '10$/pd', 1, 1),
(3, 'Cow', '40$/pd', 1, 1);

-- --------------------------------------------------------

--
-- Stand-in structure for view `feed`
-- (See below for the actual view)
--
CREATE TABLE `feed` (
`feed_id` int(8)
,`feed_name` varchar(50)
,`age_desc` varchar(30)
);

-- --------------------------------------------------------

--
-- Table structure for table `feed_type`
--

CREATE TABLE `feed_type` (
  `Feed_ID` int(8) NOT NULL,
  `Feed_name` varchar(50) NOT NULL,
  `Age_Id` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `feed_type`
--

INSERT INTO `feed_type` (`Feed_ID`, `Feed_name`, `Age_Id`) VALUES
(1, 'Sunshine', 2);

-- --------------------------------------------------------

--
-- Table structure for table `gender`
--

CREATE TABLE `gender` (
  `Gender_ID` int(8) NOT NULL,
  `Gender_Name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `gender`
--

INSERT INTO `gender` (`Gender_ID`, `Gender_Name`) VALUES
(1, 'Male'),
(2, 'Female');

-- --------------------------------------------------------

--
-- Table structure for table `route_to_market`
--

CREATE TABLE `route_to_market` (
  `Market_ID` int(8) NOT NULL,
  `Market_desc` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `route_to_market`
--

INSERT INTO `route_to_market` (`Market_ID`, `Market_desc`) VALUES
(1, 'Facebook Marketplace'),
(2, 'CraigsList');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `Transaction_Id` int(8) NOT NULL,
  `Buyer_Name` varchar(50) NOT NULL,
  `Sale_Price` decimal(12,2) NOT NULL,
  `Date_of_Transaction` date NOT NULL,
  `Market_Id` int(8) NOT NULL,
  `Animal_Id` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`Transaction_Id`, `Buyer_Name`, `Sale_Price`, `Date_of_Transaction`, `Market_Id`, `Animal_Id`) VALUES
(1, 'Kira', '13.10', '2023-02-07', 1, 1),
(2, 'Sora', '2240.10', '2018-03-14', 1, 1),
(3, 'Andrew', '78204.90', '2018-02-11', 1, 2),
(4, 'Lisa', '64532.90', '2019-08-20', 2, 1),
(5, 'Mordred', '634523.86', '2020-03-13', 2, 1),
(6, 'Linda', '52433.93', '2022-11-10', 1, 2),
(7, 'Mikhail', '55827.10', '2022-10-14', 2, 2);

-- --------------------------------------------------------

--
-- Stand-in structure for view `transaction_view`
-- (See below for the actual view)
--
CREATE TABLE `transaction_view` (
`transaction_id` int(8)
,`buyer_name` varchar(50)
,`sale_price` decimal(12,2)
,`date_of_transaction` date
,`market_desc` varchar(50)
,`animal_name` varchar(50)
);

-- --------------------------------------------------------

--
-- Structure for view `animal`
--
DROP TABLE IF EXISTS `animal`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `animal`  AS SELECT `a`.`Animal_ID` AS `animal_id`, `a`.`Animal_Name` AS `animal_name`, `a`.`Price` AS `price`, `f`.`Feed_name` AS `feed_name`, `g`.`Gender_Name` AS `gender_name` FROM ((`animal_type` `a` join `feed_type` `f` on(`a`.`Feed_ID` = `f`.`Feed_ID`)) join `gender` `g` on(`a`.`Gender_Id` = `g`.`Gender_ID`))  ;

-- --------------------------------------------------------

--
-- Structure for view `animaltofeed`
--
DROP TABLE IF EXISTS `animaltofeed`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `animaltofeed`  AS SELECT `a`.`Animal_Name` AS `animal_name`, `g`.`Feed_name` AS `feed_name` FROM (`animal_type` `a` join `feed_type` `g` on(`a`.`Feed_ID` = `g`.`Feed_ID`))  ;

-- --------------------------------------------------------

--
-- Structure for view `animaltogender`
--
DROP TABLE IF EXISTS `animaltogender`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `animaltogender`  AS SELECT `a`.`Animal_Name` AS `animal_name`, `g`.`Gender_Name` AS `gender_name` FROM (`animal_type` `a` join `gender` `g` on(`a`.`Gender_Id` = `g`.`Gender_ID`))  ;

-- --------------------------------------------------------

--
-- Structure for view `feed`
--
DROP TABLE IF EXISTS `feed`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `feed`  AS SELECT `f`.`Feed_ID` AS `feed_id`, `f`.`Feed_name` AS `feed_name`, `a`.`Age_Desc` AS `age_desc` FROM (`feed_type` `f` join `age_group` `a` on(`f`.`Age_Id` = `a`.`Age_Id`))  ;

-- --------------------------------------------------------

--
-- Structure for view `transaction_view`
--
DROP TABLE IF EXISTS `transaction_view`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `transaction_view`  AS SELECT `t`.`Transaction_Id` AS `transaction_id`, `t`.`Buyer_Name` AS `buyer_name`, `t`.`Sale_Price` AS `sale_price`, `t`.`Date_of_Transaction` AS `date_of_transaction`, `m`.`Market_desc` AS `market_desc`, `a`.`Animal_Name` AS `animal_name` FROM ((`transaction` `t` join `route_to_market` `m` on(`t`.`Market_Id` = `m`.`Market_ID`)) join `animal_type` `a` on(`t`.`Animal_Id` = `a`.`Animal_ID`))  ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `age_group`
--
ALTER TABLE `age_group`
  ADD PRIMARY KEY (`Age_Id`);

--
-- Indexes for table `animal_type`
--
ALTER TABLE `animal_type`
  ADD PRIMARY KEY (`Animal_ID`),
  ADD KEY `Feed_ID` (`Feed_ID`,`Gender_Id`),
  ADD KEY `Gender_Id` (`Gender_Id`);

--
-- Indexes for table `feed_type`
--
ALTER TABLE `feed_type`
  ADD PRIMARY KEY (`Feed_ID`),
  ADD KEY `Age_Id` (`Age_Id`);

--
-- Indexes for table `gender`
--
ALTER TABLE `gender`
  ADD PRIMARY KEY (`Gender_ID`);

--
-- Indexes for table `route_to_market`
--
ALTER TABLE `route_to_market`
  ADD PRIMARY KEY (`Market_ID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`Transaction_Id`),
  ADD KEY `Market_Id` (`Market_Id`),
  ADD KEY `Animal_Id` (`Animal_Id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `animal_type`
--
ALTER TABLE `animal_type`
  ADD CONSTRAINT `animal_type_ibfk_1` FOREIGN KEY (`Feed_ID`) REFERENCES `feed_type` (`Feed_ID`),
  ADD CONSTRAINT `animal_type_ibfk_2` FOREIGN KEY (`Gender_Id`) REFERENCES `gender` (`Gender_ID`);

--
-- Constraints for table `feed_type`
--
ALTER TABLE `feed_type`
  ADD CONSTRAINT `feed_type_ibfk_2` FOREIGN KEY (`Age_Id`) REFERENCES `age_group` (`Age_Id`);

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`Market_Id`) REFERENCES `route_to_market` (`Market_ID`),
  ADD CONSTRAINT `transaction_ibfk_2` FOREIGN KEY (`Animal_Id`) REFERENCES `animal_type` (`Animal_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
