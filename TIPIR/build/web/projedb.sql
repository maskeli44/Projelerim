-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 21 Ağu 2020, 12:35:05
-- Sunucu sürümü: 10.4.10-MariaDB
-- PHP Sürümü: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `projedb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanicilar`
--

CREATE TABLE `kullanicilar` (
  `nick` varchar(20) NOT NULL,
  `pass` varchar(20) NOT NULL,
  `resim` varchar(250) NOT NULL,
  `guvenliksorusu` varchar(50) NOT NULL,
  `guvenlikcevap` varchar(15) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `kullanicilar`
--

INSERT INTO `kullanicilar` (`nick`, `pass`, `resim`, `guvenliksorusu`, `guvenlikcevap`, `id`) VALUES
('admin', '123', 'image/admin.jpg', '3', '1', 1),
('asd@asd.com', 'qwe', 'image/youtube.png.pagespeed.ce.BFLi8UXZyM.png', '1', 'a', 17),
('cxalixd@hotmail.com', '123', '', '3', '123', 23),
('qwer@qwer.com', '123', '', '3', '123', 24),
('deneme@hotmail.com', '123', '', '2', 'hatice', 25),
('test@gmail.com', '123', '', '2', 'test', 26);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `makale`
--

CREATE TABLE `makale` (
  `makale_id` int(11) NOT NULL,
  `makale_baslik` varchar(50) NOT NULL,
  `makale_konu` text NOT NULL,
  `makale_icerik` longtext NOT NULL,
  `kullanici_nick` varchar(50) NOT NULL,
  `makale_resim` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `makale`
--

INSERT INTO `makale` (`makale_id`, `makale_baslik`, `makale_konu`, `makale_icerik`, `kullanici_nick`, `makale_resim`) VALUES
(78, 'MakaleBaşlık1', 'MakaleKonu1', '<p>MakaleIcerik1</p>\n', 'admin', 'image\\20190406155522_1.jpg'),
(105, 'Lorem Test Başlık', 'Test', '<h2>What is Lorem Ipsum?</h2>\n\n<p><strong>Lorem Ipsum</strong> is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>\n\n<h2>Why do we use it?</h2>\n\n<p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using &#39;Content here, content here&#39;, making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for &#39;lorem ipsum&#39; will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).</p>\n\n<p>&nbsp;</p>\n\n<h2>Where does it come from?</h2>\n\n<p>Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of &quot;de Finibus Bonorum et Malorum&quot; (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, &quot;Lorem ipsum dolor sit amet..&quot;, comes from a line in section 1.10.32.</p>\n\n<p>The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from &quot;de Finibus Bonorum et Malorum&quot; by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.</p>\n', 'admin', 'image\\176760.jpg'),
(132, 'asdasdas', 'dasdasdasd', '<p>dsfdsfdsfasd</p>\n', 'admin', 'image\\header.jpg');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `okunmasayisi`
--

CREATE TABLE `okunmasayisi` (
  `id` int(11) NOT NULL,
  `Okuyucu` varchar(15) NOT NULL,
  `MakaleID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `okunmasayisi`
--

INSERT INTO `okunmasayisi` (`id`, `Okuyucu`, `MakaleID`) VALUES
(1, 'Misafir', 78),
(5, 'Misafir', 78),
(10, 'Misafir', 78),
(11, 'Misafir', 78),
(12, 'Misafir', 78),
(13, 'Misafir', 78),
(14, 'Misafir', 78),
(17, 'Misafir', 78),
(19, 'Misafir', 78),
(20, 'Misafir', 78),
(21, 'Misafir', 78),
(22, 'Misafir', 78),
(23, 'Misafir', 78),
(24, 'Misafir', 78),
(25, 'Misafir', 78),
(26, 'Misafir', 78),
(27, 'Misafir', 78),
(28, 'Misafir', 78),
(29, 'Misafir', 78),
(30, 'Misafir', 78),
(31, 'Misafir', 78),
(32, 'Misafir', 78),
(34, 'Misafir', 78),
(35, 'Misafir', 78),
(36, 'Misafir', 78),
(37, 'Misafir', 78),
(38, 'Misafir', 78),
(39, 'Misafir', 78),
(40, 'Misafir', 78),
(41, 'Misafir', 78),
(42, 'Misafir', 78),
(43, 'Misafir', 78),
(44, 'Misafir', 78),
(45, 'Misafir', 78),
(46, 'Misafir', 78),
(47, 'Misafir', 78),
(48, 'Misafir', 78),
(49, 'Misafir', 78),
(50, 'Misafir', 78),
(54, 'Misafir', 78),
(55, 'Misafir', 78),
(58, 'Misafir', 78),
(60, 'Misafir', 78),
(65, 'Misafir', 78),
(70, 'Misafir', 78),
(71, 'Misafir', 78),
(72, 'Misafir', 78),
(83, 'Misafir', 78),
(84, 'Misafir', 78);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kullanicilar`
--
ALTER TABLE `kullanicilar`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id` (`id`),
  ADD KEY `nick` (`nick`);

--
-- Tablo için indeksler `makale`
--
ALTER TABLE `makale`
  ADD PRIMARY KEY (`makale_id`),
  ADD KEY `kullanici_nick` (`kullanici_nick`);

--
-- Tablo için indeksler `okunmasayisi`
--
ALTER TABLE `okunmasayisi`
  ADD PRIMARY KEY (`id`),
  ADD KEY `MakaleID` (`MakaleID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kullanicilar`
--
ALTER TABLE `kullanicilar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Tablo için AUTO_INCREMENT değeri `makale`
--
ALTER TABLE `makale`
  MODIFY `makale_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=133;

--
-- Tablo için AUTO_INCREMENT değeri `okunmasayisi`
--
ALTER TABLE `okunmasayisi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=85;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `makale`
--
ALTER TABLE `makale`
  ADD CONSTRAINT `makale_ibfk_1` FOREIGN KEY (`kullanici_nick`) REFERENCES `kullanicilar` (`nick`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Tablo kısıtlamaları `okunmasayisi`
--
ALTER TABLE `okunmasayisi`
  ADD CONSTRAINT `okunmasayisi_ibfk_1` FOREIGN KEY (`MakaleID`) REFERENCES `makale` (`makale_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
