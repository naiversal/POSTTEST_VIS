-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 13, 2026 at 05:15 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbfotostudio`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbpaket`
--

CREATE TABLE `tbpaket` (
  `kodePaket` varchar(5) NOT NULL,
  `namaPaket` varchar(100) NOT NULL,
  `durasi` int(11) NOT NULL,
  `harga` int(11) NOT NULL,
  `foto` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbpaket`
--

INSERT INTO `tbpaket` (`kodePaket`, `namaPaket`, `durasi`, `harga`, `foto`) VALUES
('PK001', 'Foto Grup', 20, 100000, 'C:\\Users\\ADVAN\\Downloads\\JANGAN LUPA BAYAR (1).png');

-- --------------------------------------------------------

--
-- Table structure for table `tbpelanggan`
--

CREATE TABLE `tbpelanggan` (
  `kodePelanggan` varchar(5) NOT NULL,
  `namaLengkap` varchar(100) NOT NULL,
  `noHp` varchar(13) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbpelanggan`
--

INSERT INTO `tbpelanggan` (`kodePelanggan`, `namaLengkap`, `noHp`, `email`) VALUES
('PA001', 'agus julyanah', '0831-9031-887', 'agus@gmail.com'),
('PA002', 'dilla baswedan', '0812-3456-789', 'dilla@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `tbreservasi`
--

CREATE TABLE `tbreservasi` (
  `kodeReservasi` varchar(5) NOT NULL,
  `kodePelanggan` varchar(5) NOT NULL,
  `kodePaket` varchar(5) NOT NULL,
  `tanggal` date NOT NULL,
  `jam` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbreservasi`
--

INSERT INTO `tbreservasi` (`kodeReservasi`, `kodePelanggan`, `kodePaket`, `tanggal`, `jam`) VALUES
('RA001', 'PA001', 'PK001', '2026-04-15', '09:00'),
('RA002', 'PA002', 'PK001', '2026-04-15', '10:45');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbpaket`
--
ALTER TABLE `tbpaket`
  ADD PRIMARY KEY (`kodePaket`);

--
-- Indexes for table `tbpelanggan`
--
ALTER TABLE `tbpelanggan`
  ADD PRIMARY KEY (`kodePelanggan`);

--
-- Indexes for table `tbreservasi`
--
ALTER TABLE `tbreservasi`
  ADD PRIMARY KEY (`kodeReservasi`),
  ADD KEY `fk_pelanggan` (`kodePelanggan`),
  ADD KEY `fk_paket` (`kodePaket`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbreservasi`
--
ALTER TABLE `tbreservasi`
  ADD CONSTRAINT `fk_paket` FOREIGN KEY (`kodePaket`) REFERENCES `tbpaket` (`kodePaket`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_pelanggan` FOREIGN KEY (`kodePelanggan`) REFERENCES `tbpelanggan` (`kodePelanggan`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
