-- SQL Schema for ooplibrary
-- Creates the database and tables with InnoDB engine for transaction support.

SET NAMES utf8mb4;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET default_storage_engine = InnoDB;

-- Create and use the database
CREATE DATABASE IF NOT EXISTS `ooplibrary`;
USE `ooplibrary`;

--
-- Table structure for table `accounts`
--
DROP TABLE IF EXISTS `accounts`;
CREATE TABLE `accounts` (
  `account_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password_hash` varchar(64) NOT NULL,
  `role` varchar(50) NOT NULL DEFAULT 'Member',
  `name` varchar(255) NOT NULL,
  `student_id` varchar(255) NOT NULL ,
  `email` varchar(255) NOT NULL,
  `birthday` date DEFAULT NULL,
  `contact_number` varchar(20) DEFAULT NULL,
  `fav_book_design` tinyint(1) DEFAULT 1,
  `date_created` datetime NOT NULL DEFAULT current_timestamp(),
  `is_active` tinyint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`account_id`),
  UNIQUE KEY `UK_username` (`username`),
  UNIQUE KEY `UK_email` (`email`),
  UNIQUE KEY `UK_student_id` (`student_id`),
  KEY `IX_role` (`role`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `books`
--
DROP TABLE IF EXISTS `books`;
CREATE TABLE `books` (
  `book_id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `isbn` varchar(13) NOT NULL,
  `publisher` varchar(255) DEFAULT NULL,
  `year_published` int(11) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `cover_url` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`book_id`),
  UNIQUE KEY `UK_isbn` (`isbn`),
  KEY `IX_title` (`title`),
  KEY `IX_author` (`author`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `book_copies`
--
DROP TABLE IF EXISTS `book_copies`;
CREATE TABLE `book_copies` (
  `copy_id` int(11) NOT NULL AUTO_INCREMENT,
  `book_id` int(11) NOT NULL,
  `condition` varchar(50) NOT NULL DEFAULT 'Good',
  `status` varchar(50) NOT NULL DEFAULT 'Available',
  `shelf_location` varchar(100) DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp(),
  `last_updated` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`copy_id`),
  KEY `IX_book_id` (`book_id`),
  KEY `IX_status` (`status`),
  CONSTRAINT `FK_book_copies_books` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `announcements`
--
DROP TABLE IF EXISTS `announcements`;
CREATE TABLE `announcements` (
  `announcement_id` int(11) NOT NULL AUTO_INCREMENT,
  `admin_id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `message` text NOT NULL,
  `date_posted` datetime NOT NULL DEFAULT current_timestamp(),
  `expiry_date` datetime DEFAULT NULL,
  `priority` varchar(50) NOT NULL DEFAULT 'Normal',
  `is_active` tinyint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`announcement_id`),
  KEY `IX_admin_id` (`admin_id`),
  KEY `IX_is_active` (`is_active`),
  CONSTRAINT `FK_announcements_accounts` FOREIGN KEY (`admin_id`) REFERENCES `accounts` (`account_id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `favorites`
--
DROP TABLE IF EXISTS `favorites`;
CREATE TABLE `favorites` (
  `fav_id` int(11) NOT NULL AUTO_INCREMENT,
  `account_id` int(11) NOT NULL,
  `book_id` int(11) NOT NULL,
  `date_added` datetime DEFAULT current_timestamp(),
  PRIMARY KEY (`fav_id`),
  UNIQUE KEY `UK_account_book` (`account_id`,`book_id`),
  KEY `IX_account_id` (`account_id`),
  KEY `IX_book_id` (`book_id`),
  CONSTRAINT `FK_favorites_accounts` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE,
  CONSTRAINT `FK_favorites_books` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `transactions`
--
DROP TABLE IF EXISTS `transactions`;
CREATE TABLE `transactions` (
  `transaction_id` int(11) NOT NULL AUTO_INCREMENT,
  `account_id` int(11) NOT NULL,
  `copy_id` int(11) DEFAULT NULL,
  `transaction_type` varchar(50) NOT NULL,
  `date_borrowed` datetime DEFAULT NULL,
  `date_due` datetime DEFAULT NULL,
  `date_returned` datetime DEFAULT NULL,
  `fine` decimal(10,2) NOT NULL DEFAULT 0.00,
  `status` varchar(50) NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`transaction_id`),
  KEY `IX_account_id` (`account_id`),
  KEY `IX_copy_id` (`copy_id`),
  KEY `IX_status` (`status`),
  CONSTRAINT `FK_transactions_accounts` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE,
  CONSTRAINT `FK_transactions_book_copies` FOREIGN KEY (`copy_id`) REFERENCES `book_copies` (`copy_id`) ON DELETE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `logs`
--
DROP TABLE IF EXISTS `logs`;
CREATE TABLE `logs` (
  `log_id` int(11) NOT NULL AUTO_INCREMENT,
  `account_id` int(11) DEFAULT NULL,
  `action` varchar(255) NOT NULL,
  `timestamp` datetime NOT NULL DEFAULT current_timestamp(),
  `details` text DEFAULT NULL,
  `ip_address` varchar(45) DEFAULT NULL,
  `severity` varchar(50) NOT NULL DEFAULT 'Info',
  PRIMARY KEY (`log_id`),
  KEY `IX_account_id` (`account_id`),
  KEY `IX_timestamp` (`timestamp`),
  KEY `IX_severity` (`severity`),
  CONSTRAINT `FK_logs_accounts` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `notifications`
--
DROP TABLE IF EXISTS `notifications`;
CREATE TABLE `notifications` (
  `notification_id` int(11) NOT NULL AUTO_INCREMENT,
  `account_id` int(11) NOT NULL,
  `transaction_id` int(11) DEFAULT NULL,
  `message` text NOT NULL,
  `date_sent` datetime NOT NULL DEFAULT current_timestamp(),
  `is_read` tinyint(1) NOT NULL DEFAULT 0,
  `notification_type` int(11) NOT NULL,
  PRIMARY KEY (`notification_id`),
  KEY `IX_account_id` (`account_id`),
  KEY `IX_transaction_id` (`transaction_id`),
  CONSTRAINT `FK_notifications_accounts` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE,
  CONSTRAINT `FK_notifications_transactions` FOREIGN KEY (`transaction_id`) REFERENCES `transactions` (`transaction_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `user_otp`
--
DROP TABLE IF EXISTS `user_otp`;
CREATE TABLE `user_otp` (
  `otp_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) DEFAULT NULL,
  `verification_target` varchar(255) DEFAULT NULL,
  `otp_code` varchar(6) DEFAULT NULL,
  `expires_at` datetime DEFAULT NULL,
  `is_used` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`otp_id`),
  KEY `IX_verification_target` (`verification_target`),
  KEY `IX_user_id` (`user_id`),
  CONSTRAINT `FK_user_otp_accounts` FOREIGN KEY (`user_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `genres`
--
DROP TABLE IF EXISTS `genres`;
CREATE TABLE `genres` (
  `genre_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  PRIMARY KEY (`genre_id`),
  UNIQUE KEY `UK_genre_name` (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Table structure for table `book_genres` (Junction table for M-to-M)
--
DROP TABLE IF EXISTS `book_genres`;
CREATE TABLE `book_genres` (
  `book_id` int(11) NOT NULL,
  `genre_id` int(11) NOT NULL,
  PRIMARY KEY (`book_id`, `genre_id`),
  KEY `IX_book_id` (`book_id`),
  KEY `IX_genre_id` (`genre_id`),
  CONSTRAINT `FK_book_genres_books` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON DELETE CASCADE,
  CONSTRAINT `FK_book_genres_genres` FOREIGN KEY (`genre_id`) REFERENCES `genres` (`genre_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

SET foreign_key_checks = 1;

--
-- Table structure for table `displayed_books`
--
DROP TABLE IF EXISTS displayed_books;

CREATE TABLE displayed_books (
  account_id INT NOT NULL,
  book_id INT NOT NULL,
  display_order INT NOT NULL,
  PRIMARY KEY (account_id, book_id),
  FOREIGN KEY (account_id) REFERENCES accounts(account_id),
  FOREIGN KEY (book_id) REFERENCES books(book_id)
);

