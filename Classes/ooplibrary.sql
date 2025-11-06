-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 06, 2025 at 04:53 PM
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
-- Database: `ooplibrary`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

CREATE TABLE `accounts` (
  `account_id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password_hash` varchar(64) NOT NULL,
  `role` varchar(50) NOT NULL DEFAULT 'Member',
  `name` varchar(255) NOT NULL,
  `student_id` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `birthday` date DEFAULT NULL,
  `contact_number` varchar(20) DEFAULT NULL,
  `fav_book_design` tinyint(1) DEFAULT 1,
  `date_created` datetime NOT NULL DEFAULT current_timestamp(),
  `is_active` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`account_id`, `username`, `password_hash`, `role`, `name`, `student_id`, `email`, `birthday`, `contact_number`, `fav_book_design`, `date_created`, `is_active`) VALUES
(1, 'Admin John', 'f6e0a1e2ac41945a9aa7ff8a8aaa0cebc12a3bcc981a929ad5cf810a090e11ae', 'Admin', 'Admin John', '20240001-C', 'admin@library.com', '1990-01-01', '09171234567', 1, '2025-01-01 10:00:00', 1),
(2, 'Jane Dela Cruz', 'f6e0a1e2ac41945a9aa7ff8a8aaa0cebc12a3bcc981a929ad5cf810a090e11ae', 'Librarian', 'Jane Dela Cruz', '20240002-C', 'jane.d@library.com', '1995-05-15', '09287654321', 1, '2025-01-15 11:00:00', 1),
(3, 'Alex Reyes', 'ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f', 'Student', 'Alex Reyes', '20240003-C', 'alex.reyes@student.edu', '2002-08-30', '09451112233', 1, '2025-02-10 14:30:00', 1),
(4, 'Ren Seraspe', '3cc849279ba298b587a34cabaeffc5ecb3a044bbf97c516fab7ede9d1af77cfa', 'Student', 'Ren Seraspe', '20240519-C', 'ireneovseraspeiii123@gmail.com', NULL, NULL, 0, '2025-11-05 22:37:40', 1),
(5, 'Jestine', 'f6e0a1e2ac41945a9aa7ff8a8aaa0cebc12a3bcc981a929ad5cf810a090e11ae', 'Student', 'Jestine', '20240136-C', 'jestineaquino5@gmail.com', NULL, NULL, 0, '2025-11-06 03:15:15', 1),
(6, 'Jj Mcdal Nabong', '63d44582ad437dce2fbc264e73cc505ea3cb0edcfbebab34de93fdc94c805afb', 'Student', 'Jj Mcdal Nabong', '20221123-N', 'jjmcdalnabong2001@gmail.com', NULL, NULL, 0, '2025-11-06 11:41:51', 1);

-- --------------------------------------------------------

--
-- Table structure for table `announcements`
--

CREATE TABLE `announcements` (
  `announcement_id` int(11) NOT NULL,
  `admin_id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `message` text NOT NULL,
  `date_posted` datetime NOT NULL DEFAULT current_timestamp(),
  `expiry_date` datetime DEFAULT NULL,
  `priority` varchar(50) NOT NULL DEFAULT 'Normal',
  `is_active` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `announcements`
--

INSERT INTO `announcements` (`announcement_id`, `admin_id`, `title`, `message`, `date_posted`, `expiry_date`, `priority`, `is_active`) VALUES
(1, 1, 'Welcome to the New Library System!', 'The OOP Library System is now fully operational. Please report any bugs to the front desk. Enjoy your reading!', '2025-10-28 08:00:00', '2025-11-30 23:59:59', 'High', 1),
(2, 2, 'Holiday Hours', 'The library will be closed on November 1st for All Saints\' Day.', '2025-10-29 10:00:00', '2025-11-02 00:00:00', 'Normal', 1);

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `book_id` int(11) NOT NULL,
  `title` varchar(255) NOT NULL,
  `author` varchar(255) NOT NULL,
  `isbn` varchar(13) NOT NULL,
  `publisher` varchar(255) DEFAULT NULL,
  `year_published` int(11) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `cover_url` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`book_id`, `title`, `author`, `isbn`, `publisher`, `year_published`, `description`, `cover_url`) VALUES
(1, 'The Silence of the Lambs', 'Thomas Harris', '9780312924584', 'St. Martin\'s', 1988, 'FBI trainee Clarice Starling hunts a serial killer with the help of another.', 'the_silence_of_the_lambs.jpg'),
(2, 'Moby-Dick', 'Herman Melville', '9780142437247', 'Penguin Classics', 1851, 'The saga of Captain Ahab and his obsession with the white whale, Moby Dick.', 'Moby Dick.png'),
(3, 'Thinking, Fast and Slow', 'Daniel Kahneman', '9780374533557', 'Farrar, Straus and Giroux', 2011, 'The two systems that drive the way we think.', 'thinking_fast_and_slow.jpg'),
(4, 'War and Peace', 'Leo Tolstoy', '9781400079988', 'Vintage', 1869, 'A panoramic study of early 19th-century Russian society.', 'war_and_peace.jpg'),
(5, 'A Brief History of Time', 'Stephen Hawking', '9780553380163', 'Bantam', 1988, 'From the big bang to black holes, a guide to cosmology.', 'a_brief_history_of_time.jpg'),
(6, 'The Road', 'Cormac McCarthy', '9780307387899', 'Vintage', 2006, 'A father and son\'s post-apocalyptic journey.', 'the_road.jpg'),
(7, 'The Handmaid\'s Tale', 'Margaret Atwood', '9780385490818', 'Anchor', 1986, 'A dystopian novel set in a totalitarian society.', 'the_handmaids_tale.jpg'),
(8, 'The Republic', 'Plato', '9780872201361', 'Hackett', -375, 'A Socratic dialogue concerning justice.', 'The_Republic.jpg'),
(9, 'The Design of Everyday Things', 'Don Norman', '9780465050659', 'Basic Books', 2013, 'How to make products user-friendly.', 'the_design_of_everyday_things.jpg'),
(10, 'The Prince', 'Niccolò Machiavelli', '9780140449150', 'Penguin Classics', 1532, 'A 16th-century political treatise.', 'The_Prince.jpg'),
(11, 'Watchmen', 'Alan Moore', '9780930289232', 'DC Comics', 1987, 'A deconstruction of the superhero archetype.', 'Watchmen.png'),
(12, 'Neuromancer', 'William Gibson', '9780441569595', 'Ace Books', 1984, 'The quintessential cyberpunk novel.', 'neuromancer.jpg'),
(13, 'The Goldfinch', 'Donna Tartt', '9780316055437', 'Little, Brown', 2013, 'A novel about a boy whose life is changed by a terrorist bombing at an art museum.', 'the_goldfinch.jpg'),
(14, 'The Shining', 'Stephen King', '9780385121675', 'Doubleday', 1977, 'A family heads to an isolated hotel for the winter where a sinister presence influences the father.', 'the_shining.jpg'),
(15, 'Brief Answers to the Big Questions', 'Stephen Hawking', '9781529302111', 'Bantam', 2018, 'Stephen Hawking\'s final thoughts on the biggest questions facing humankind.', 'brief_answers_to_the_big_questions.jpg'),
(16, 'Hyperion', 'Dan Simmons', '9780553283686', 'Bantam', 1989, 'A space opera on the eve of Armageddon.', 'hyperion.jpg'),
(17, 'To Kill a Mockingbird', 'Harper Lee', '9780061120084', 'HarperPerennial', 1960, 'A classic of American literature dealing with racial injustice.', 'to_kill_a_mocking_bird.jpg'),
(18, 'The Study Skills Handbook', 'Stella Cottrell', '9781137610871', 'Macmillan', 2019, 'A guide for students to develop effective study skills.', 'the_study_skills_handbook.jpg'),
(19, 'The Catcher in the Rye', 'J.D. Salinger', '9780316769488', 'Little, Brown', 1951, 'A story about teenage angst and alienation.', 'The Catcher in the Rye.png'),
(20, 'Little Fires Everywhere', 'Celeste Ng', '9781594206822', 'Penguin Press', 2017, 'A novel about two families in Shaker Heights, Ohio.', 'little_fires_everywhere.jpg'),
(21, '6865555557656554', 'Frank Herbert', '9780441172719', 'Chilton Books', 1965, 'Set in the distant future amidst a feudal interstellar society...', 'dune.jpg'),
(22, 'The Pragmatic Programmer', 'David Thomas & Andrew Hunt', '9780201616224', 'Addison-Wesley', 1999, 'From Journeyman to Master.', 'The_Pragmatic_Programmer.jpg'),
(23, 'The Odyssey', 'Homer', '9780140268867', 'Penguin Classics', -800, 'The epic poem of Odysseus\' journey home.', 'The Odyssey.png'),
(24, 'Vagabond, Vol. 1', 'Takehiko Inoue', '9781421507460', 'VIZ Media', 2004, 'A fictionalized account of the life of Japanese swordsman Miyamoto Musashi.', 'Vagabond_Vol_1.jpg'),
(25, 'Dracula', 'Bram Stoker', '9780486411095', 'Dover', 1897, 'The classic vampire novel that introduced Count Dracula.', 'dracula.jpg'),
(26, 'The Immortal Life of Henrietta Lacks', 'Rebecca Skloot', '9781400052172', 'Crown', 2010, 'The story of the HeLa cell line and the woman it came from.', 'the_immortal_life_of_henrietta_lacks.jpg'),
(27, 'The Picture of Dorian Gray', 'Oscar Wilde', '9780141439570', 'Penguin Classics', 1890, 'A novel about a man whose portrait ages instead of him.', 'the_picture_of_dorian_gray.jpg'),
(28, 'Pride and Prejudice', 'Jane Austen', '9780141439518', 'Penguin Classics', 1813, 'A classic novel of manners, love, and social standing.', 'Pride and Prejudice.png'),
(29, 'Guns, Germs, and Steel', 'Jared Diamond', '9780393317558', 'W. W. Norton', 1997, 'The fates of human societies.', 'Guns_Germs_and_Steel.jpg'),
(30, 'Death Note, Vol. 1', 'Tsugumi Ohba', '9781421501680', 'VIZ Media', 2005, 'A high school student discovers a supernatural notebook.', 'death_note_volume_1.jpg'),
(31, 'How to Read a Book', 'Mortimer J. Adler & Charles Van Doren', '9780671212094', 'Simon & Schuster', 1972, 'The classic guide to intelligent reading and comprehension.', 'how_to_read_a_book.jpg'),
(32, 'Blood Meridian', 'Cormac McCarthy', '9780679728757', 'Vintage', 1985, 'An epic novel of the violent American West.', 'Blood Meridian.png'),
(33, 'The Lord of the Rings', 'J.R.R. Tolkien', '9780618640157', 'Houghton Mifflin', 1954, 'The epic fantasy novel detailing the quest to destroy the One Ring.', 'lord_of_the_rings_fellowship.jpg'),
(34, 'The Fault in Our Stars', 'John Green', '9780525478812', 'Dutton Books', 2012, 'A young adult novel about two teenagers with cancer who fall in love.', 'the_fault_in_our_stars.jpg'),
(35, 'Gödel, Escher, Bach', 'Douglas Hofstadter', '9780465026562', 'Basic Books', 1979, 'A metaphorical fugue on min', 'Godel,Escher,Bach_an Eternal Golden.png'),
(36, 'The Guest List', 'Lucy Foley', '9780062868930', 'William Morrow', 2020, 'A wedding celebration on a remote island turns deadly.', 'the_guest_list.jpg'),
(37, 'The Wedding Date', 'Jasmine Guillory', '9780399587661', 'Berkley', 2018, 'A romantic comedy that starts with a fake wedding date.', 'the_wedding_date.jpg'),
(38, 'Naruto, Vol. 1', 'Masashi Kishimoto', '9781569319000', 'VIZ Media', 2003, 'A young ninja seeks recognition from his peers.', 'naruto_volume_1.jpg'),
(39, 'The Iliad', 'Homer', '9780140275360', 'Penguin Classics', -750, 'An epic poem about the Trojan War.', 'the_iliad.jpg'),
(40, 'Monster, Vol. 1', 'Naoki Urasawa', '9781421569062', 'VIZ Media', 2014, 'A neurosurgeon\'s life is thrown into chaos after saving a young boy.', 'monster_volume_1.jpg'),
(41, 'The Body: A Guide for Occupants', 'Bill Bryson', '9780385539302', 'Doubleday', 2019, 'A guide to the human body, its functions, and its oddities.', 'the_body.jpg'),
(42, 'Clean Code', 'Robert C. Martin', '9780132350884', 'Prentice Hall', 2008, 'A Handbook of Agile Software Craftsmanship.', 'Clean_Code.jpg'),
(43, 'The Name of the Wind', 'Patrick Rothfuss', '9780756404741', 'DAW Books', 2007, 'The first book in The Kingkiller Chronicle series.', 'The Name of the Wind.png'),
(44, 'Twilight', 'Stephenie Meyer', '9780316015844', 'Little, Brown', 2005, 'A young adult romance between a teenage girl and a vampire.', 'twilight.jpg'),
(45, 'The Power of Habit', 'Charles Duhigg', '9781400069286', 'Random House', 2012, 'An exploration of the science of habit formation.', 'the_power_of_habit.jpg'),
(46, 'Sapiens: A Brief History of Humankind', 'Yuval Noah Harari', '9780062316097', 'Harper', 2015, 'A sweeping tour of the history of our species.', 'Sapiens_A_Brief_History_of_Humankind.jpg'),
(47, 'Metamorphosis', 'ShindoL', '9784865542792', 'Wanimagazine', 2016, 'A tragic manga about a high school girl\'s transformation. (Also known as 177013)', '177013.jpg'),
(48, 'A Game of Thrones', 'George R.R. Martin', '9780553103540', 'Bantam', 1996, 'The first book of A Song of Ice and Fire.', 'A Game of Thrones .png'),
(49, 'Sword Art Online, Vol. 21', 'Reki Kawahara', '9784049125313', 'ASCII Media Works', 2018, 'Unital Ring arc, volume 1.', 'Sword_Art_Online.png'),
(50, 'The Great Gatsby', 'F. Scott Fitzgerald', '9780743273565', 'Scribner', 1925, 'A novel about the American dream and the excesses of the 1920s.', 'the_great_gatsby.jpg'),
(51, 'The Hobbit', 'J.R.R. Tolkien', '9780618260300', 'Houghton Mifflin', 1937, 'A hobbit\'s adventure to reclaim treasure from a dragon.', 'hobbit.jpg'),
(52, '20th Century Boys, Vol. 1', 'Naoki Urasawa', '9781421522609', 'VIZ Media', 2009, 'A group of friends try to save the world from a mysterious cult leader.', '20th_century_boy_volume_1.jpg'),
(53, 'The Plot', 'Jean Hanff Korelitz', '9781250266099', 'Celadon Books', 2021, 'A struggling writer steals a brilliant story from a deceased former student.', 'the_plot.jpg'),
(54, 'Where the Crawdads Sing', 'Delia Owens', '9780735219090', 'G.P. Putnam\'s Sons', 2018, 'A novel set in the marshes of North Carolina, blending mystery and nature.', 'where_the_crawdads_sing.jpg'),
(55, 'Beyond Good and Evil', 'Friedrich Nietzsche', '9780140449235', 'Penguin Classics', 1886, 'A critique of past philosophers and their moral prejudices.', 'Beyond_Good_and_Evil.jpg'),
(56, 'Maus', 'Art Spiegelman', '9780679406419', 'Pantheon', 1991, 'A graphic novel memoir of the Holocaust.', 'Maus.jpg'),
(57, 'Redo of Healer, Vol. 1', 'Rui Tsukiyo', '9781975310306', 'Yen Press', 2017, 'A fantasy manga series about a healing magician who goes back in time.', 'redo_of_healer.jpg'),
(58, 'The Rosie Project', 'Graeme Simsion', '9781476729091', 'Simon & Schuster', 2013, 'A genetics professor\'s logical quest to find a wife.', 'the_rosie_project.jpg'),
(59, 'Frankenstein', 'Mary Shelley', '9780141439471', 'Penguin Classics', 1818, 'A young scientist creates a sapient creature, with tragic consequences.', 'Frankenstein.png'),
(60, 'The Adventure', 'Author Name', '9780000000001', 'Stock Image', 2024, 'A fantasy time travel journey.', 'the_adventure.jpg'),
(61, 'A People\'s History of the United States', 'Howard Zinn', '9780060838652', 'HarperPerennial', 1980, 'American history told from the perspective of marginalized peoples.', 'A_People_s_History_of_the_United_States.jpg'),
(62, 'The Time Traveler\'s Wife', 'Audrey Niffenegger', '9781596916443', 'Scribner', 2003, 'A love story about a man with a genetic disorder that causes him to time travel unpredictably.', 'the_time_travelers_wife.jpg'),
(63, 'Berserk, Vol. 1', 'Kentaro Miura', '9781593070205', 'Dark Horse Manga', 2003, 'Guts, a lone mercenary, wanders a medieval world.', 'Berserk, Vol. 1.png'),
(64, 'The Structure of Scientific Revolutions', 'Thomas S. Kuhn', '9780226458083', 'University of Chicago Press', 1962, 'A landmark book in the history and philosophy of science.', 'The_Structure_of_Scientific_Revolutions.jpg'),
(65, 'Hell House', 'Richard Matheson', '9780765330314', 'Tor Books', 1971, 'A team investigates a notoriously haunted house.', 'hell_house.jpg'),
(66, 'The Divine Comedy', 'Dante Alighieri', '9780142437223', 'Penguin Classics', 1320, 'An epic poem describing Dante\'s journey through Hell, Purgatory, and Paradise.', 'the_divine_comedy.jpg'),
(67, 'The Gene: An Intimate History', 'Siddhartha Mukherjee', '9781476733500', 'Scribner', 2016, 'A history of the gene and genetic research.', 'gene.jpg'),
(68, 'Mexican Gothic', 'Silvia Moreno-Garcia', '9780525620785', 'Del Rey', 2020, 'A gothic horror novel set in a remote mansion in 1950s Mexico.', 'mexican_gothic.jpg'),
(69, 'Operating System Concepts', 'Abraham Silberschatz', '9781118063330', 'Wiley', 2012, 'The essential textbook for operating systems.', 'Operating System Concepts.png'),
(70, 'Mistborn: The Final Empire', 'Brandon Sanderson', '9780765311788', 'Tor Books', 2006, 'A fantasy heist story set in a world ruled by a dark lord.', 'Mistborn_ The Final Empire.png'),
(71, 'Compilers: Principles, Techniques, and Tools', 'Alfred Aho et al.', '9780321486813', 'Pearson', 2006, 'The \"Dragon Book\" of compilers.', 'Compilers_ Principles,.png'),
(72, 'It', 'Stephen King', '9781501175466', 'Scribner', 1986, 'A story of seven children haunted by an evil entity.', 'it.jpg'),
(73, 'Coraline', 'Neil Gaiman', '9780380977789', 'HarperCollins', 2002, 'A young girl discovers a sinister parallel world.', 'coraline.jpg'),
(74, 'Kissxsis, Vol. 1', 'Ditama Bow', '9784063751075', 'Kodansha', 2008, 'A Japanese manga series about a boy and his two stepsisters.', 'kissxsis.jpg'),
(75, 'The Gunslinger', 'Stephen King', '9780451160528', 'Signet', 1982, 'The first book of The Dark Tower series.', 'The_Gunslinger.jpg'),
(76, 'Introduction to Algorithms', 'Thomas H. Cormen et al.', '9780262033848', 'MIT Press', 2009, 'The bible of algorithms. (CLRS)', 'Introduction to Algorithms.png'),
(77, 'The Psychology of Money', 'Morgan Housel', '9780857197689', 'Harriman House', 2020, 'Timeless lessons on wealth, greed, and happiness.', 'The_Psychology_of_Money.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `book_copies`
--

CREATE TABLE `book_copies` (
  `copy_id` int(11) NOT NULL,
  `book_id` int(11) NOT NULL,
  `condition` varchar(50) NOT NULL DEFAULT 'Good',
  `status` varchar(50) NOT NULL DEFAULT 'Available',
  `shelf_location` varchar(100) DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp(),
  `last_updated` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `book_copies`
--

INSERT INTO `book_copies` (`copy_id`, `book_id`, `condition`, `status`, `shelf_location`, `date_added`, `last_updated`) VALUES
(1, 1, 'Good', 'Available', 'SCI-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(2, 1, 'Good', 'Available', 'SCI-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(3, 2, 'Worn', 'Available', 'CLASSIC-M-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(4, 2, 'Worn', 'Available', 'CLASSIC-M-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(5, 3, 'New', 'Available', 'SELF-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(6, 3, 'Good', 'Available', 'SELF-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(7, 4, 'Good', 'Available', 'CLASSIC-T-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(8, 4, 'Worn', 'Available', 'CLASSIC-T-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(9, 5, 'Good', 'Available', 'SCI-H-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(10, 5, 'Worn', 'Available', 'SCI-H-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(11, 6, 'Good', 'Available', 'DYS-M-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(12, 6, 'New', 'Available', 'DYS-M-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(13, 7, 'New', 'Available', 'DYS-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(14, 7, 'Good', 'Available', 'DYS-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(15, 8, 'Good', 'Available', 'PHIL-P-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(16, 8, 'Worn', 'Available', 'PHIL-P-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(17, 9, 'New', 'Available', 'CS-N-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(18, 9, 'Good', 'Available', 'CS-N-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(19, 10, 'Good', 'Available', 'PHIL-M-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(20, 11, 'Good', 'Available', 'GRAPHIC-M-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(21, 11, 'Good', 'Available', 'GRAPHIC-M-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(22, 12, 'Worn', 'Available', 'SF-G-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(23, 12, 'Good', 'Available', 'SF-G-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(24, 13, 'Good', 'Available', 'FIC-T-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(25, 14, 'Good', 'Available', 'HOR-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(26, 14, 'Worn', 'Maintenance', 'HOR-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(27, 15, 'New', 'Available', 'SCI-H-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(28, 16, 'Good', 'Available', 'SF-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(29, 16, 'Worn', 'Available', 'SF-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(30, 17, 'Worn', 'Available', 'CLASSIC-L-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(31, 17, 'Good', 'Available', 'CLASSIC-L-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(32, 18, 'New', 'Available', 'REF-C-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(33, 19, 'Worn', 'Available', 'CLASSIC-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(34, 20, 'New', 'Available', 'FIC-N-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(35, 21, 'Good', 'Available', 'SF-H-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(36, 21, 'Worn', 'Available', 'SF-H-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(37, 22, 'Good', 'Available', 'CS-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(38, 22, 'Good', 'Available', 'CS-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(39, 23, 'Worn', 'Available', 'CLASSIC-H-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(40, 23, 'Good', 'Available', 'CLASSIC-H-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(41, 24, 'New', 'Available', 'MANGA-I-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(42, 24, 'New', 'Available', 'MANGA-I-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(43, 25, 'Worn', 'Available', 'CLASSIC-S-03', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(44, 25, 'Good', 'Available', 'CLASSIC-S-03', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(45, 26, 'Good', 'Available', 'BIO-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(46, 26, 'New', 'Available', 'BIO-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(47, 27, 'Good', 'Available', 'CLASSIC-W-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(48, 28, 'Good', 'Available', 'CLASSIC-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(49, 28, 'Worn', 'Available', 'CLASSIC-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(50, 29, 'Good', 'Available', 'HIST-D-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(51, 29, 'New', 'Available', 'HIST-D-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(52, 30, 'New', 'Available', 'MANGA-O-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(53, 30, 'New', 'Available', 'MANGA-O-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(54, 31, 'Good', 'Available', 'REF-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(55, 32, 'Good', 'Available', 'CLASSIC-M-03', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(56, 33, 'Good', 'Available', 'FAN-T-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(57, 33, 'Worn', 'Available', 'FAN-T-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(58, 34, 'Good', 'Available', 'ROM-G-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(59, 34, 'Worn', 'Available', 'ROM-G-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(60, 35, 'Good', 'Available', 'PHIL-H-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(61, 36, 'New', 'Available', 'THR-F-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(62, 36, 'Good', 'Available', 'THR-F-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(63, 37, 'New', 'Available', 'ROM-G-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(64, 38, 'New', 'Available', 'MANGA-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(65, 38, 'New', 'Available', 'MANGA-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(66, 39, 'Worn', 'Available', 'CLASSIC-H-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(67, 40, 'New', 'Available', 'MANGA-U-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(68, 40, 'New', 'Available', 'MANGA-U-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(69, 41, 'Good', 'Available', 'SCI-B-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(70, 42, 'New', 'Available', 'CS-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(71, 42, 'Good', 'Available', 'CS-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(72, 42, 'Worn', 'Maintenance', 'CS-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(73, 43, 'Good', 'Available', 'FAN-R-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(74, 43, 'New', 'Available', 'FAN-R-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(75, 44, 'Good', 'Available', 'ROM-M-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(76, 44, 'Good', 'Available', 'ROM-M-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(77, 45, 'Good', 'Available', 'SELF-D-03', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(78, 46, 'New', 'Available', 'HIST-H-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(79, 46, 'New', 'Available', 'HIST-H-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(80, 47, 'New', 'Available', 'MANGA-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(81, 48, 'Good', 'Available', 'FAN-M-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(82, 48, 'Good', 'Available', 'FAN-M-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(83, 49, 'New', 'Available', 'MANGA-K-03', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(84, 50, 'Worn', 'Available', 'CLASSIC-F-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(85, 50, 'Good', 'Available', 'CLASSIC-F-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(86, 51, 'Good', 'Available', 'FAN-T-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(87, 52, 'New', 'Available', 'MANGA-U-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(88, 52, 'New', 'Available', 'MANGA-U-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(89, 53, 'New', 'Available', 'THR-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(90, 54, 'New', 'Available', 'FIC-O-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(91, 55, 'Good', 'Available', 'PHIL-N-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(92, 56, 'Good', 'Available', 'GRAPHIC-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(93, 57, 'New', 'Available', 'MANGA-R-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(94, 58, 'Good', 'Available', 'ROM-S-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(95, 59, 'Worn', 'Available', 'CLASSIC-S-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(96, 60, 'New', 'Available', 'FAN-A-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(97, 61, 'Good', 'Available', 'HIST-Z-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(98, 61, 'Worn', 'Available', 'HIST-Z-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(99, 62, 'Good', 'Available', 'ROM-N-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(100, 63, 'New', 'Available', 'MANGA-B-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(101, 63, 'New', 'Available', 'MANGA-B-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(102, 64, 'Worn', 'Available', 'PHIL-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(103, 64, 'Good', 'Available', 'PHIL-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(104, 65, 'Good', 'Available', 'HOR-M-03', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(105, 66, 'Worn', 'Available', 'CLASSIC-D-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(106, 67, 'Good', 'Available', 'SCI-M-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(107, 68, 'New', 'Available', 'HOR-M-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(108, 69, 'Good', 'Available', 'CS-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(109, 69, 'Worn', 'Available', 'CS-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(110, 70, 'New', 'Available', 'FAN-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(111, 70, 'New', 'Available', 'FAN-S-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(112, 71, 'Worn', 'Borrowed', 'CS-A-03', '2025-11-06 11:28:05', '2025-11-06 11:44:21'),
(113, 71, 'Worn', 'Available', 'CS-A-03', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(114, 72, 'Good', 'Available', 'HOR-K-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(115, 72, 'Worn', 'Available', 'HOR-K-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(116, 73, 'New', 'Available', 'FAN-G-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(117, 74, 'New', 'Available', 'MANGA-K-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(118, 75, 'Worn', 'Available', 'FAN-K-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(119, 76, 'Good', 'Available', 'CS-A-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(120, 76, 'Worn', 'Available', 'CS-A-02', '2025-11-06 11:28:05', '2025-11-06 11:28:05'),
(121, 77, 'New', 'Available', 'SELF-H-01', '2025-11-06 11:28:05', '2025-11-06 11:28:05');

-- --------------------------------------------------------

--
-- Table structure for table `book_genres`
--

CREATE TABLE `book_genres` (
  `book_id` int(11) NOT NULL,
  `genre_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `book_genres`
--

INSERT INTO `book_genres` (`book_id`, `genre_id`) VALUES
(1, 6),
(2, 16),
(3, 6),
(3, 8),
(4, 14),
(4, 16),
(5, 6),
(6, 4),
(6, 21),
(7, 16),
(7, 21),
(8, 15),
(8, 16),
(9, 6),
(10, 6),
(10, 15),
(11, 4),
(11, 23),
(12, 4),
(13, 22),
(14, 2),
(14, 8),
(15, 6),
(16, 4),
(17, 16),
(18, 12),
(18, 20),
(19, 16),
(20, 22),
(21, 4),
(21, 5),
(22, 7),
(22, 13),
(23, 16),
(23, 18),
(24, 9),
(24, 11),
(25, 2),
(25, 16),
(26, 6),
(26, 19),
(27, 8),
(27, 16),
(28, 16),
(28, 17),
(29, 6),
(29, 14),
(30, 3),
(30, 9),
(31, 6),
(31, 12),
(32, 16),
(32, 22),
(33, 5),
(33, 16),
(34, 17),
(35, 6),
(35, 15),
(36, 1),
(36, 3),
(37, 17),
(38, 9),
(38, 10),
(39, 16),
(39, 18),
(40, 9),
(40, 11),
(41, 6),
(42, 7),
(42, 13),
(43, 5),
(44, 5),
(44, 17),
(45, 6),
(45, 20),
(46, 6),
(46, 14),
(47, 9),
(48, 5),
(48, 22),
(49, 4),
(49, 9),
(50, 16),
(51, 5),
(51, 16),
(52, 9),
(52, 11),
(53, 1),
(53, 3),
(54, 3),
(54, 22),
(55, 15),
(56, 14),
(56, 23),
(57, 5),
(57, 9),
(58, 17),
(59, 2),
(59, 16),
(60, 4),
(60, 5),
(61, 6),
(61, 14),
(62, 4),
(62, 17),
(63, 9),
(63, 11),
(64, 12),
(64, 15),
(65, 2),
(66, 16),
(66, 18),
(67, 6),
(67, 19),
(68, 2),
(68, 22),
(69, 12),
(69, 13),
(70, 5),
(71, 12),
(71, 13),
(72, 2),
(73, 2),
(73, 5),
(74, 9),
(74, 17),
(75, 4),
(75, 5),
(76, 12),
(76, 13),
(77, 6),
(77, 20);

-- --------------------------------------------------------

--
-- Table structure for table `favorites`
--

CREATE TABLE `favorites` (
  `fav_id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `book_id` int(11) NOT NULL,
  `display_order` int(11) NOT NULL DEFAULT 0,
  `date_added` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `favorites`
--

INSERT INTO `favorites` (`fav_id`, `account_id`, `book_id`, `display_order`, `date_added`) VALUES
(1, 3, 1, 0, '2025-10-10 11:10:00'),
(2, 3, 3, 1, '2025-10-11 15:00:00'),
(3, 3, 7, 2, '2025-10-28 16:01:00'),
(4, 2, 10, 0, '2025-10-11 15:01:00'),
(5, 2, 50, 1, '2025-10-29 08:00:00'),
(12, 5, 53, 1, '2025-11-06 05:07:39'),
(13, 5, 40, 2, '2025-11-06 05:07:39'),
(14, 5, 27, 3, '2025-11-06 05:07:39'),
(15, 6, 5, 1, '2025-11-06 11:52:38');

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

CREATE TABLE `genres` (
  `genre_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `genres`
--

INSERT INTO `genres` (`genre_id`, `name`) VALUES
(12, 'Academic'),
(19, 'Biography'),
(16, 'Classic'),
(13, 'Computer Science'),
(21, 'Dystopian'),
(5, 'Fantasy'),
(23, 'Graphic Novel'),
(22, 'Historical Fiction'),
(14, 'History'),
(2, 'Horror'),
(9, 'Manga'),
(3, 'Mystery'),
(6, 'Non-Fiction'),
(15, 'Philosophy'),
(18, 'Poetry'),
(7, 'Programming'),
(8, 'Psychological'),
(17, 'Romance'),
(4, 'Science Fiction'),
(11, 'Seinen'),
(20, 'Self-Help'),
(10, 'Shonen'),
(1, 'Thriller');

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `log_id` int(11) NOT NULL,
  `account_id` int(11) DEFAULT NULL,
  `action` varchar(255) NOT NULL,
  `timestamp` datetime NOT NULL DEFAULT current_timestamp(),
  `details` text DEFAULT NULL,
  `ip_address` varchar(45) DEFAULT NULL,
  `severity` varchar(50) NOT NULL DEFAULT 'Info'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `logs`
--

INSERT INTO `logs` (`log_id`, `account_id`, `action`, `timestamp`, `details`, `ip_address`, `severity`) VALUES
(1, 1, 'User Login', '2025-11-03 15:02:21', 'Admin login successful.', '192.168.1.1', 'Info'),
(2, NULL, 'Failed Login', '2025-11-03 15:02:21', 'Attempted login for username: \'admin\' with wrong password.', '10.0.0.5', 'Warning'),
(3, 2, 'Book Copy Added', '2025-11-03 15:02:21', 'Added 3 copies for BookID: 7 (Berserk)', '192.168.1.3', 'Info'),
(4, 3, 'Book Borrowed', '2025-11-03 15:02:21', 'TransactionID: 4, CopyID: 14', '192.168.5.10', 'Info'),
(5, 3, 'Book Returned', '2025-11-03 15:02:21', 'TransactionID: 5, CopyID: 24', '192.168.5.10', 'Info'),
(6, 4, 'User Registration', '2025-11-05 22:37:40', 'New user \'Ren Seraspe\' registered.', NULL, 'Info'),
(7, 4, 'Login Success', '2025-11-05 22:37:55', 'User successfully logged in.', NULL, 'Info'),
(8, 4, 'Login Success', '2025-11-05 23:10:12', 'User successfully logged in.', NULL, 'Info'),
(9, 4, 'Login Success', '2025-11-05 23:23:24', 'User successfully logged in.', NULL, 'Info'),
(10, 4, 'Login Success', '2025-11-06 01:39:23', 'User successfully logged in.', NULL, 'Info'),
(11, 4, 'Login Success', '2025-11-06 02:28:41', 'User successfully logged in.', NULL, 'Info'),
(12, NULL, 'Login Failure', '2025-11-06 03:09:50', 'Attempted login for non-existent user \'Jestine\'.', NULL, 'Info'),
(13, NULL, 'Login Failure', '2025-11-06 03:09:57', 'Attempted login for non-existent user \'Jestine\'.', NULL, 'Info'),
(14, 5, 'User Registration', '2025-11-06 03:15:15', 'New user \'Jestine\' registered.', NULL, 'Info'),
(15, 5, 'Login Success', '2025-11-06 03:15:24', 'User successfully logged in.', NULL, 'Info'),
(16, 1, 'Login Success', '2025-11-06 03:18:57', 'User successfully logged in.', NULL, 'Info'),
(17, 5, 'Login Success', '2025-11-06 03:22:51', 'User successfully logged in.', NULL, 'Info'),
(18, NULL, 'Login Failure', '2025-11-06 03:26:40', 'Attempted login for non-existent user \'admin\'.', NULL, 'Info'),
(19, 1, 'Login Success', '2025-11-06 03:27:06', 'User successfully logged in.', NULL, 'Info'),
(20, 1, 'Login Success', '2025-11-06 03:30:04', 'User successfully logged in.', NULL, 'Info'),
(21, 2, 'Login Failure', '2025-11-06 03:31:44', 'Incorrect password provided.', NULL, 'Info'),
(22, 2, 'Login Success', '2025-11-06 03:33:36', 'User successfully logged in.', NULL, 'Info'),
(23, 1, 'System Startup', '2025-11-06 03:39:30', 'System initialization successful >>>>> Entering operational state.', NULL, 'info'),
(24, NULL, 'Login Failure', '2025-11-06 03:39:54', 'Attempted login for non-existent user \'jane.d@library.com\'.', NULL, 'Info'),
(25, NULL, 'Login Failure', '2025-11-06 03:39:56', 'Attempted login for non-existent user \'jane.d@library.com\'.', NULL, 'Info'),
(26, NULL, 'Login Failure', '2025-11-06 03:40:00', 'Attempted login for non-existent user \'jane.d@library.com\'.', NULL, 'Info'),
(27, NULL, 'Login Failure', '2025-11-06 03:40:18', 'Attempted login for non-existent user \'jane.d@library.com\'.', NULL, 'Info'),
(28, 2, 'Login Failure', '2025-11-06 03:40:41', 'Incorrect password provided.', NULL, 'Info'),
(29, 2, 'Login Success', '2025-11-06 03:40:44', 'User successfully logged in.', NULL, 'Info'),
(30, NULL, 'Login Failure', '2025-11-06 03:43:22', 'Attempted login for non-existent user \'Admin\'.', NULL, 'Info'),
(31, 5, 'Login Success', '2025-11-06 03:43:23', 'User successfully logged in.', NULL, 'Info'),
(32, 1, 'Login Success', '2025-11-06 03:43:27', 'User successfully logged in.', NULL, 'Info'),
(33, 1, 'Login Success', '2025-11-06 03:52:07', 'User successfully logged in.', NULL, 'Info'),
(34, 1, 'System Startup', '2025-11-06 03:52:42', 'System initialization successful >>>>> Entering operational state.', NULL, 'info'),
(35, 2, 'Login Failure', '2025-11-06 03:56:11', 'Incorrect password provided.', NULL, 'Info'),
(36, 2, 'Login Success', '2025-11-06 03:56:19', 'User successfully logged in.', NULL, 'Info'),
(37, 1, 'Login Success', '2025-11-06 03:57:14', 'User successfully logged in.', NULL, 'Info'),
(38, 5, 'Login Success', '2025-11-06 03:57:49', 'User successfully logged in.', NULL, 'Info'),
(39, 1, 'System Startup', '2025-11-06 04:00:14', 'System initialization successful >>>>> Entering operational state.', NULL, 'info'),
(40, 5, 'Login Success', '2025-11-06 04:00:49', 'User successfully logged in.', NULL, 'Info'),
(41, 1, 'System Startup', '2025-11-06 04:12:39', 'System initialization successful >>>>> Entering operational state.', NULL, 'info'),
(42, 5, 'Login Success', '2025-11-06 04:12:55', 'User successfully logged in.', NULL, 'Info'),
(43, 1, 'Login Success', '2025-11-06 04:48:31', 'User successfully logged in.', NULL, 'Info'),
(44, 1, 'Login Success', '2025-11-06 05:03:47', 'User successfully logged in.', NULL, 'Info'),
(45, 1, 'Login Success', '2025-11-06 05:07:16', 'User successfully logged in.', NULL, 'Info'),
(46, 1, 'Login Success', '2025-11-06 05:13:04', 'User successfully logged in.', NULL, 'Info'),
(47, 1, 'Login Success', '2025-11-06 05:17:39', 'User successfully logged in.', NULL, 'Info'),
(48, 1, 'Login Success', '2025-11-06 05:20:23', 'User successfully logged in.', NULL, 'Info'),
(49, 1, 'Login Success', '2025-11-06 05:21:40', 'User successfully logged in.', NULL, 'Info'),
(50, 1, 'Login Success', '2025-11-06 05:26:53', 'User successfully logged in.', NULL, 'Info'),
(51, 1, 'Login Success', '2025-11-06 05:40:29', 'User successfully logged in.', NULL, 'Info'),
(52, 1, 'Login Success', '2025-11-06 05:45:29', 'User successfully logged in.', NULL, 'Info'),
(53, 5, 'Login Success', '2025-11-06 06:01:33', 'User successfully logged in.', NULL, 'Info'),
(54, 1, 'System Startup', '2025-11-06 06:03:03', 'System initialization successful >>>>> Entering operational state.', NULL, 'info'),
(55, 5, 'Login Failure', '2025-11-06 06:09:32', 'Incorrect password provided.', NULL, 'Info'),
(56, 5, 'Login Success', '2025-11-06 06:09:34', 'User successfully logged in.', NULL, 'Info'),
(57, 5, 'Login Success', '2025-11-06 06:38:54', 'User successfully logged in.', NULL, 'Info'),
(58, NULL, 'Login Failure', '2025-11-06 06:53:39', 'Attempted login for non-existent user \' Jestine\'.', NULL, 'Info'),
(59, NULL, 'Login Failure', '2025-11-06 06:53:43', 'Attempted login for non-existent user \' Jestine\'.', NULL, 'Info'),
(60, NULL, 'Login Failure', '2025-11-06 06:53:46', 'Attempted login for non-existent user \' Jestine\'.', NULL, 'Info'),
(61, NULL, 'Login Failure', '2025-11-06 06:53:53', 'Attempted login for non-existent user \' Jestine\'.', NULL, 'Info'),
(62, 4, 'Login Failure', '2025-11-06 06:54:31', 'Incorrect password provided.', NULL, 'Info'),
(63, 4, 'Login Success', '2025-11-06 06:54:36', 'User successfully logged in.', NULL, 'Info'),
(64, 4, 'Login Success', '2025-11-06 07:41:44', 'User successfully logged in.', NULL, 'Info'),
(65, 4, 'Login Success', '2025-11-06 07:44:55', 'User successfully logged in.', NULL, 'Info'),
(66, 2, 'Login Success', '2025-11-06 08:28:51', 'User successfully logged in.', NULL, 'Info'),
(67, 2, 'Login Success', '2025-11-06 08:40:58', 'User successfully logged in.', NULL, 'Info'),
(68, 6, 'User Registration', '2025-11-06 11:41:51', 'New user \'Jj Mcdal Nabong\' registered.', NULL, 'Info'),
(69, NULL, 'Login Failure', '2025-11-06 11:42:12', 'Attempted login for non-existent user \'jjmcdalnabong2001@gmail.com\'.', NULL, 'Info'),
(70, 6, 'Login Success', '2025-11-06 11:42:26', 'User successfully logged in.', NULL, 'Info'),
(71, 1, 'Login Success', '2025-11-06 11:44:30', 'User successfully logged in.', NULL, 'Info'),
(72, 1, 'Catalogue Update', '2025-11-06 11:57:34', 'Book \'Gödel, Escher, Bach\' (ID: 35) details updated.', NULL, 'Info'),
(73, 1, 'Catalogue Update', '2025-11-06 11:58:38', 'Book \'6865555557656554\' (ID: 21) details updated.', NULL, 'Info');

-- --------------------------------------------------------

--
-- Table structure for table `notifications`
--

CREATE TABLE `notifications` (
  `notification_id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `transaction_id` int(11) DEFAULT NULL,
  `message` text NOT NULL,
  `date_sent` datetime NOT NULL DEFAULT current_timestamp(),
  `is_read` tinyint(1) NOT NULL DEFAULT 0,
  `notification_type` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `notifications`
--

INSERT INTO `notifications` (`notification_id`, `account_id`, `transaction_id`, `message`, `date_sent`, `is_read`, `notification_type`) VALUES
(1, 3, NULL, 'A new book you might like, \"Monster, Vol. 1\", has been added to the Manga section.', '2025-11-03 15:02:21', 0, 2),
(2, 3, 1, 'Your book, \"Big Little Lies\", is due on 2025-11-08.', '2025-11-03 15:02:21', 1, 3),
(3, 3, 3, 'Your borrowed book, \"Clean Code\", is overdue. Please return it as soon as possible. A fine is accumulating.', '2025-11-03 15:02:21', 0, 1),
(4, 3, 4, 'Your book, \"Berserk, Vol. 1\", is due on 2025-11-11.', '2025-11-03 15:02:21', 0, 3);

-- --------------------------------------------------------

--
-- Table structure for table `transactions`
--

CREATE TABLE `transactions` (
  `transaction_id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `copy_id` int(11) DEFAULT NULL,
  `transaction_type` varchar(50) NOT NULL,
  `date_borrowed` datetime DEFAULT NULL,
  `date_due` datetime DEFAULT NULL,
  `date_returned` datetime DEFAULT NULL,
  `fine` decimal(10,2) NOT NULL DEFAULT 0.00,
  `status` varchar(50) NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transactions`
--

INSERT INTO `transactions` (`transaction_id`, `account_id`, `copy_id`, `transaction_type`, `date_borrowed`, `date_due`, `date_returned`, `fine`, `status`) VALUES
(1, 3, 3, 'Borrow', '2025-10-25 14:30:10', '2025-11-08 14:30:10', NULL, 0.00, 'Borrowed'),
(2, 3, 1, 'Borrow', '2025-10-10 11:15:00', '2025-10-24 11:15:00', '2025-10-16 09:05:20', 0.00, 'Returned'),
(3, 3, 6, 'Borrow', '2025-10-15 10:00:00', '2025-10-29 10:00:00', NULL, 5.00, 'Overdue'),
(4, 3, 14, 'Borrow', '2025-10-28 16:00:00', '2025-11-11 16:00:00', NULL, 0.00, 'Borrowed'),
(5, 3, 24, 'Borrow', '2025-10-20 09:00:00', '2025-11-03 09:00:00', '2025-10-28 15:59:00', 0.00, 'Returned'),
(6, 4, 30, 'Borrow', '2025-11-06 07:45:57', '2025-11-13 07:45:57', NULL, 0.00, 'Active'),
(7, 4, 50, 'Borrow', '2025-11-06 07:45:57', '2025-11-13 07:45:57', NULL, 0.00, 'Active'),
(8, 4, 5, 'Borrow', '2025-11-06 07:45:57', '2025-11-13 07:45:57', NULL, 0.00, 'Active'),
(9, 6, 112, 'Borrow', '2025-11-06 11:44:21', '2025-12-06 11:44:21', NULL, 0.00, 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `user_otp`
--

CREATE TABLE `user_otp` (
  `otp_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `verification_target` varchar(255) DEFAULT NULL,
  `otp_code` varchar(6) DEFAULT NULL,
  `expires_at` datetime DEFAULT NULL,
  `is_used` tinyint(1) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_otp`
--

INSERT INTO `user_otp` (`otp_id`, `user_id`, `verification_target`, `otp_code`, `expires_at`, `is_used`) VALUES
(1, 3, 'alex.reyes@student.edu', '123456', '2025-10-29 10:00:00', 1),
(2, NULL, 'ireneovseraspeiii123@gmail.com', '189183', '2025-11-05 22:41:35', 1),
(3, NULL, 'jestineaquino5@gmail.com', '688966', '2025-11-06 03:19:48', 1),
(4, NULL, 'admin@library.com', '104570', '2025-11-06 03:23:03', 1),
(5, NULL, 'jane.d@library.com', '334937', '2025-11-06 03:37:11', 1),
(6, NULL, 'jane.d@library.com', '644833', '2025-11-06 08:44:40', 1),
(7, NULL, 'jjmcdalnabong2001@gmail.com', '502345', '2025-11-06 11:44:18', 1),
(8, NULL, 'jjmcdalnabong2001@gmail.com', '141578', '2025-11-06 11:44:28', 1),
(9, NULL, 'jjmcdalnabong2001@gmail.com', '575431', '2025-11-06 11:44:45', 1),
(10, NULL, 'jjmcdalnabong2001@gmail.com', '720031', '2025-11-06 11:45:52', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts`
--
ALTER TABLE `accounts`
  ADD PRIMARY KEY (`account_id`),
  ADD UNIQUE KEY `UK_username` (`username`),
  ADD UNIQUE KEY `UK_email` (`email`),
  ADD UNIQUE KEY `UK_student_id` (`student_id`),
  ADD KEY `IX_role` (`role`);

--
-- Indexes for table `announcements`
--
ALTER TABLE `announcements`
  ADD PRIMARY KEY (`announcement_id`),
  ADD KEY `IX_admin_id` (`admin_id`),
  ADD KEY `IX_is_active` (`is_active`);

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`book_id`),
  ADD UNIQUE KEY `UK_isbn` (`isbn`),
  ADD KEY `IX_title` (`title`),
  ADD KEY `IX_author` (`author`);

--
-- Indexes for table `book_copies`
--
ALTER TABLE `book_copies`
  ADD PRIMARY KEY (`copy_id`),
  ADD KEY `IX_book_id` (`book_id`),
  ADD KEY `IX_status` (`status`);

--
-- Indexes for table `book_genres`
--
ALTER TABLE `book_genres`
  ADD PRIMARY KEY (`book_id`,`genre_id`),
  ADD KEY `IX_book_id` (`book_id`),
  ADD KEY `IX_genre_id` (`genre_id`);

--
-- Indexes for table `favorites`
--
ALTER TABLE `favorites`
  ADD PRIMARY KEY (`fav_id`),
  ADD UNIQUE KEY `UK_account_book` (`account_id`,`book_id`),
  ADD KEY `IX_account_id` (`account_id`),
  ADD KEY `IX_book_id` (`book_id`);

--
-- Indexes for table `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`genre_id`),
  ADD UNIQUE KEY `UK_genre_name` (`name`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `IX_account_id` (`account_id`),
  ADD KEY `IX_timestamp` (`timestamp`),
  ADD KEY `IX_severity` (`severity`);

--
-- Indexes for table `notifications`
--
ALTER TABLE `notifications`
  ADD PRIMARY KEY (`notification_id`),
  ADD KEY `IX_account_id` (`account_id`),
  ADD KEY `IX_transaction_id` (`transaction_id`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `IX_account_id` (`account_id`),
  ADD KEY `IX_copy_id` (`copy_id`),
  ADD KEY `IX_status` (`status`);

--
-- Indexes for table `user_otp`
--
ALTER TABLE `user_otp`
  ADD PRIMARY KEY (`otp_id`),
  ADD KEY `IX_verification_target` (`verification_target`),
  ADD KEY `IX_user_id` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts`
--
ALTER TABLE `accounts`
  MODIFY `account_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `announcements`
--
ALTER TABLE `announcements`
  MODIFY `announcement_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `book_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;

--
-- AUTO_INCREMENT for table `book_copies`
--
ALTER TABLE `book_copies`
  MODIFY `copy_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=122;

--
-- AUTO_INCREMENT for table `favorites`
--
ALTER TABLE `favorites`
  MODIFY `fav_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `genres`
--
ALTER TABLE `genres`
  MODIFY `genre_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=74;

--
-- AUTO_INCREMENT for table `notifications`
--
ALTER TABLE `notifications`
  MODIFY `notification_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `user_otp`
--
ALTER TABLE `user_otp`
  MODIFY `otp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `announcements`
--
ALTER TABLE `announcements`
  ADD CONSTRAINT `FK_announcements_accounts` FOREIGN KEY (`admin_id`) REFERENCES `accounts` (`account_id`);

--
-- Constraints for table `book_copies`
--
ALTER TABLE `book_copies`
  ADD CONSTRAINT `FK_book_copies_books` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON DELETE CASCADE;

--
-- Constraints for table `book_genres`
--
ALTER TABLE `book_genres`
  ADD CONSTRAINT `FK_book_genres_books` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_book_genres_genres` FOREIGN KEY (`genre_id`) REFERENCES `genres` (`genre_id`) ON DELETE CASCADE;

--
-- Constraints for table `favorites`
--
ALTER TABLE `favorites`
  ADD CONSTRAINT `FK_favorites_accounts` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_favorites_books` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON DELETE CASCADE;

--
-- Constraints for table `logs`
--
ALTER TABLE `logs`
  ADD CONSTRAINT `FK_logs_accounts` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE SET NULL;

--
-- Constraints for table `notifications`
--
ALTER TABLE `notifications`
  ADD CONSTRAINT `FK_notifications_accounts` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_notifications_transactions` FOREIGN KEY (`transaction_id`) REFERENCES `transactions` (`transaction_id`) ON DELETE CASCADE;

--
-- Constraints for table `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `FK_transactions_accounts` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_transactions_book_copies` FOREIGN KEY (`copy_id`) REFERENCES `book_copies` (`copy_id`);

--
-- Constraints for table `user_otp`
--
ALTER TABLE `user_otp`
  ADD CONSTRAINT `FK_user_otp_accounts` FOREIGN KEY (`user_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
