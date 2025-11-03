-- Use the ooplibrary database
USE `ooplibrary`;

-- Set foreign key checks to 0 to allow insertion of interdependent data
SET foreign_key_checks = 0;

--
-- Populating table `accounts`
-- Note: Passwords are hashed using SHA2('password', 256).
-- The actual passwords are 'adminpass', 'libpass123', 'password', 
--
TRUNCATE TABLE `accounts`;
INSERT INTO `accounts` (`account_id`, `username`, `password_hash`, `role`, `name`, `student_id`, `email`, `birthday`, `contact_number`, `date_created`, `is_active`) VALUES
(1, 'Admin John', '5f94a1a56f34e339a43a88b50f75b8061f8f9c65eb4111354921509355743147', 'Admin', 'Admin John', '20240001-C', 'admin@library.com', '1990-01-01', '09171234567', '2025-01-01 10:00:00', 1),
(2, 'Jane Dela Cruz', 'b18018ae50d885611440a3258163f5b5b5463f0f7f4e91f0e4953c89422a16d8', 'Librarian', 'Jane Dela Cruz', '20240002-C', 'jane.d@library.com', '1995-05-15', '09287654321', '2025-01-15 11:00:00', 1),
(3, 'Alex Reyes', 'ef92b778bafe771e89245b89ecbc08a44a4e166c06659911881f383d4473e94f', 'Student', 'Alex Reyes', '20240003-C', 'alex.reyes@student.edu', '2002-08-30', '09451112233', '2025-02-10 14:30:00', 1);

--
-- Populating table `transactions`
--
TRUNCATE TABLE `transactions`;
INSERT INTO `transactions` (`transaction_id`, `account_id`, `copy_id`, `transaction_type`, `date_borrowed`, `date_due`, `date_returned`, `fine`, `status`) VALUES
(1, 3, 3, 'Borrow', '2025-10-25 14:30:10', '2025-11-01 14:30:10', NULL, 0.00, 'Borrowed'),
(2, 3, 1, 'Borrow', '2025-10-10 11:15:00', '2025-10-17 11:15:00', '2025-10-16 09:05:20', 0.00, 'Returned');

--
-- UPDATE book_copies statuses based on transactions
--
UPDATE `book_copies` SET `status` = 'Borrowed' WHERE `copy_id` = 3;
UPDATE `book_copies` SET `status` = 'Available' WHERE `copy_id` = 1; -- Confirming status of returned book


--
-- Populating table `user_otp`
--
TRUNCATE TABLE `user_otp`;
INSERT INTO `user_otp` (`user_id`, `verification_target`, `otp_code`, `expires_at`, `is_used`) VALUES
(3, 'alex.reyes@student.edu', '123456', '2025-10-29 10:00:00', 1); -- A used OTP for Alex


-- Set foreign key checks to 0 to allow insertion of interdependent data
SET foreign_key_checks = 0;

--
-- Populating table `genres` (Expanded List)
--
TRUNCATE TABLE `genres`;
INSERT INTO `genres` (`genre_id`, `name`) VALUES
(1, 'Thriller'),
(2, 'Horror'),
(3, 'Mystery'),
(4, 'Science Fiction'),
(5, 'Fantasy'),
(6, 'Non-Fiction'),
(7, 'Programming'),
(8, 'Psychological'),
(9, 'Manga'),
(10, 'Shonen'),
(11, 'Seinen'),
(12, 'Academic'),
(13, 'Computer Science'),
(14, 'History'),
(15, 'Philosophy'),
(16, 'Classic'),
(17, 'Romance'),
(18, 'Poetry'),
(19, 'Biography'),
(20, 'Self-Help'),
(21, 'Dystopian'),
(22, 'Historical Fiction'),
(23, 'Graphic Novel');

--
-- Populating table `books` (Expanded to 65 books)
--
TRUNCATE TABLE `books`;
INSERT INTO `books` (`book_id`, `title`, `author`, `isbn`, `publisher`, `year_published`, `description`, `cover_url`) VALUES
(1, 'The Haunting of Hill House', 'Shirley Jackson', '9780143039983', 'Penguin Classics', 1959, 'Four seekers arrive at a notoriously unfriendly pile called Hill House...', 'hill_house.jpg'),
(2, 'Big Little Lies', 'Liane Moriarty', '9780399167065', 'G.P. Putnam''s Sons', 2014, 'A tale of murder and mischief in a tranquil seaside town...', 'big_little_lies.jpg'),
(3, 'Clean Code', 'Robert C. Martin', '9780132350884', 'Prentice Hall', 2008, 'A Handbook of Agile Software Craftsmanship.', 'clean_code.jpg'),
(4, 'The Woman in the Window', 'A.J. Finn', '9780062678416', 'William Morrow', 2018, 'An agoraphobic woman living alone in New York City...', 'woman_window.jpg'),
(5, 'Dune', 'Frank Herbert', '9780441172719', 'Chilton Books', 1965, 'Set in the distant future amidst a feudal interstellar society...', 'dune.jpg'),
(6, 'Attack on Titan, Vol. 1', 'Hajime Isayama', '9781612620244', 'Kodansha Comics', 2012, 'The battle for survival against man-eating giants.', 'aot_1.jpg'),
(7, 'Berserk, Vol. 1', 'Kentaro Miura', '9781593070205', 'Dark Horse Manga', 2003, 'Guts, a lone mercenary, wanders a medieval world.', 'berserk_1.jpg'),
(8, 'A Brief History of Time', 'Stephen Hawking', '9780553380163', 'Bantam', 1998, 'From the big bang to black holes.', 'hawking_time.jpg'),
(9, 'Sapiens: A Brief History of Humankind', 'Yuval Noah Harari', '9780062316097', 'Harper', 2015, 'A sweeping tour of the history of our species.', 'sapiens.jpg'),
(10, 'Introduction to Algorithms', 'Thomas H. Cormen', '9780262033848', 'MIT Press', 2009, 'The bible of algorithms. (CLRS)', 'clrs.jpg'),
(11, 'The Pragmatic Programmer', 'David Thomas', '9780201616224', 'Addison-Wesley', 1999, 'From Journeyman to Master.', 'pragmatic_prog.jpg'),
(12, '1984', 'George Orwell', '9780451524935', 'Signet Classic', 1950, 'A dystopian novel set in Airstrip One, formerly Great Britain.', '1984.jpg'),
(13, 'Brave New World', 'Aldous Huxley', '9780060850524', 'HarperPerennial', 1932, 'A dystopian novel which anticipates developments in reproductive technology.', 'brave_new_world.jpg'),
(14, 'The Catcher in the Rye', 'J.D. Salinger', '9780316769488', 'Little, Brown', 1951, 'A story about teenage angst and alienation.', 'catcher_rye.jpg'),
(15, 'Pride and Prejudice', 'Jane Austen', '9780141439518', 'Penguin Classics', 1813, 'A classic novel of manners.', 'pride_prejudice.jpg'),
(16, 'Meditations', 'Marcus Aurelius', '9780140449334', 'Penguin Classics', 2006, 'Stoic philosophy from the Roman emperor.', 'meditations.jpg'),
(17, 'Beyond Good and Evil', 'Friedrich Nietzsche', '9780140449235', 'Penguin Classics', 1886, 'A critique of past philosophers and their moral prejudices.', 'beyond_good_evil.jpg'),
(18, 'Naruto, Vol. 1', 'Masashi Kishimoto', '9781569319000', 'VIZ Media', 2003, 'A young ninja seeks recognition from his peers.', 'naruto_1.jpg'),
(19, 'One Piece, Vol. 1', 'Eiichiro Oda', '9781569319017', 'VIZ Media', 2003, 'Monkey D. Luffy''s adventure to become the King of the Pirates.', 'one_piece_1.jpg'),
(20, 'Death Note, Vol. 1', 'Tsugumi Ohba', '9781421501680', 'VIZ Media', 2005, 'A high school student discovers a supernatural notebook.', 'death_note_1.jpg'),
(21, 'Atomic Habits', 'James Clear', '9780735211292', 'Avery', 2018, 'An Easy & Proven Way to Build Good Habits & Break Bad Ones.', 'atomic_habits.jpg'),
(22, 'The Psychology of Money', 'Morgan Housel', '9780857197689', 'Harriman House', 2020, 'Timeless lessons on wealth, greed, and happiness.', 'psychology_money.jpg'),
(23, 'Watchmen', 'Alan Moore', '9780930289232', 'DC Comics', 1987, 'A deconstruction of the superhero archetype.', 'watchmen.jpg'),
(24, 'Maus', 'Art Spiegelman', '9780679406419', 'Pantheon', 1991, 'A graphic novel memoir of the Holocaust.', 'maus.jpg'),
(25, 'The Silence of the Lambs', 'Thomas Harris', '9780312924584', 'St. Martin''s', 1988, 'FBI trainee Clarice Starling hunts a serial killer with the help of another.', 'silence_lambs.jpg'),
(26, 'The Shining', 'Stephen King', '9780385121675', 'Doubleday', 1977, 'A family heads to an isolated hotel for the winter...', 'the_shining.jpg'),
(27, 'Frankenstein', 'Mary Shelley', '9780141439471', 'Penguin Classics', 1818, 'A young scientist creates a sapient creature in an unorthodox experiment.', 'frankenstein.jpg'),
(28, 'The Name of the Wind', 'Patrick Rothfuss', '9780756404741', 'DAW Books', 2007, 'The first book in The Kingkiller Chronicle series.', 'name_wind.jpg'),
(29, 'Mistborn: The Final Empire', 'Brandon Sanderson', '9780765311788', 'Tor Books', 2006, 'A fantasy heist story set in a world ruled by a dark lord.', 'mistborn.jpg'),
(30, 'A Game of Thrones', 'George R.R. Martin', '9780553103540', 'Bantam', 1996, 'The first book of A Song of Ice and Fire.', 'got_1.jpg'),
(31, 'The Gunslinger', 'Stephen King', '9780451160528', 'Signet', 1982, 'The first book of The Dark Tower series.', 'gunslinger.jpg'),
(32, 'Hyperion', 'Dan Simmons', '9780553283686', 'Bantam', 1989, 'A space opera on the eve of Armageddon.', 'hyperion.jpg'),
(33, 'Neuromancer', 'William Gibson', '9780441569595', 'Ace Books', 1984, 'The quintessential cyberpunk novel.', 'neuromancer.jpg'),
(34, 'The Hitchhiker''s Guide to the Galaxy', 'Douglas Adams', '9780345391803', 'Harmony Books', 1979, 'Seconds before Earth is demolished...', 'hitchhikers_guide.jpg'),
(35, 'The Great Gatsby', 'F. Scott Fitzgerald', '9780743273565', 'Scribner', 1925, 'A novel about the American dream.', 'great_gatsby.jpg'),
(36, 'To Kill a Mockingbird', 'Harper Lee', '9780061120084', 'HarperPerennial', 1960, 'A classic of modern American literature.', 'to_kill_mockingbird.jpg'),
(37, 'One Hundred Years of Solitude', 'Gabriel Garcia Marquez', '9780060883287', 'HarperPerennial', 1967, 'The multi-generational story of the Buendía family.', '100_years_solitude.jpg'),
(38, 'The Lord of the Rings', 'J.R.R. Tolkien', '9780618640157', 'Houghton Mifflin', 1954, 'The complete trilogy in one volume.', 'lotr.jpg'),
(39, 'The Hobbit', 'J.R.R. Tolkien', '9780618260300', 'Houghton Mifflin', 1937, 'A hobbit''s adventure to reclaim a treasure.', 'hobbit.jpg'),
(40, 'Don Quixote', 'Miguel de Cervantes', '9780060934347', 'Ecco', 1605, 'A satire of chivalric romances.', 'don_quixote.jpg'),
(41, 'Moby Dick', 'Herman Melville', '9780142437247', 'Penguin Classics', 1851, 'The saga of Captain Ahab and his obsession with a white whale.', 'moby_dick.jpg'),
(42, 'War and Peace', 'Leo Tolstoy', '9781400079988', 'Vintage', 1869, 'A panoramic study of early 19th-century Russian society.', 'war_and_peace.jpg'),
(43, 'The Odyssey', 'Homer', '9780140268867', 'Penguin Classics', -800, 'The epic poem of Odysseus'' journey home.', 'odyssey.jpg'),
(44, 'The Divine Comedy', 'Dante Alighieri', '9780142437223', 'Penguin Classics', 1320, 'An epic poem describing Dante''s journey through Hell, Purgatory, and Paradise.', 'divine_comedy.jpg'),
(45, 'The Republic', 'Plato', '9780872201361', 'Hackett', -375, 'A Socratic dialogue concerning justice.', 'republic.jpg'),
(46, 'The Prince', 'Niccolò Machiavelli', '9780140449150', 'Penguin Classics', 1532, 'A 16th-century political treatise.', 'the_prince.jpg'),
(47, 'Guns, Germs, and Steel', 'Jared Diamond', '9780393317558', 'W. W. Norton', 1997, 'The fates of human societies.', 'guns_germs_steel.jpg'),
(48, 'Cosmos', 'Carl Sagan', '9780345539434', 'Ballantine Books', 1980, 'A popular science book exploring the universe.', 'cosmos.jpg'),
(49, 'Vagabond, Vol. 1', 'Takehiko Inoue', '9781421507460', 'VIZ Media', 2004, 'A fictionalized account of the life of Japanese swordsman Miyamoto Musashi.', 'vagabond_1.jpg'),
(50, 'Monster, Vol. 1', 'Naoki Urasawa', '9781421569062', 'VIZ Media', 2014, 'A neurosurgeon''s life is thrown into chaos after saving a young boy.', 'monster_1.jpg'),
(51, '20th Century Boys, Vol. 1', 'Naoki Urasawa', '9781421522609', 'VIZ Media', 2009, 'A group of friends try to save the world from a mysterious cult leader.', '20th_century_boys.jpg'),
(52, 'The Design of Everyday Things', 'Don Norman', '9780465050659', 'Basic Books', 2013, 'How to make products user-friendly.', 'design_everyday.jpg'),
(53, 'Thinking, Fast and Slow', 'Daniel Kahneman', '9780374533557', 'Farrar, Straus and Giroux', 2011, 'The two systems that drive the way we think.', 'thinking_fast_slow.jpg'),
(54, 'A People''s History of the United States', 'Howard Zinn', '9780060838652', 'HarperPerennial', 1980, 'American history told from the perspective of marginalized peoples.', 'peoples_history.jpg'),
(55, 'The Iliad', 'Homer', '9780140275360', 'Penguin Classics', -750, 'An epic poem about the Trojan War.', 'iliad.jpg'),
(56, 'The Picture of Dorian Gray', 'Oscar Wilde', '9780141439570', 'Penguin Classics', 1890, 'A novel about a man whose portrait ages instead of him.', 'dorian_gray.jpg'),
(57, 'Dracula', 'Bram Stoker', '9780141439846', 'Penguin Classics', 1897, 'The classic vampire novel.', 'dracula.jpg'),
(58, 'The Handmaid''s Tale', 'Margaret Atwood', '9780385490818', 'Anchor', 1986, 'A dystopian novel set in a totalitarian society.', 'handmaids_tale.jpg'),
(59, 'The Road', 'Cormac McCarthy', '9780307387899', 'Vintage', 2006, 'A father and son''s post-apocalyptic journey.', 'the_road.jpg'),
(60, 'Blood Meridian', 'Cormac McCarthy', '9780679728757', 'Vintage', 1985, 'An epic novel of the violent American West.', 'blood_meridian.jpg'),
(61, 'The Structure of Scientific Revolutions', 'Thomas S. Kuhn', '9780226458083', 'University of Chicago Press', 1962, 'A landmark book in the history and philosophy of science.', 'scientific_revolutions.jpg'),
(62, 'Operating System Concepts', 'Abraham Silberschatz', '9781118063330', 'Wiley', 2012, 'The essential textbook for operating systems.', 'os_concepts.jpg'),
(63, 'Compilers: Principles, Techniques, and Tools', 'Alfred Aho', '9780321486813', 'Pearson', 2006, 'The "Dragon Book" of compilers.', 'dragon_book.jpg'),
(64, 'Gödel, Escher, Bach: an Eternal Golden Braid', 'Douglas Hofstadter', '9780465026562', 'Basic Books', 1979, 'A metaphorical fugue on minds and machines.', 'geb.jpg'),
(65, 'The Selfish Gene', 'Richard Dawkins', '9780199291151', 'Oxford University Press', 2006, 'A landmark work on evolutionary biology.', 'selfish_gene.jpg');

--
-- Populating table `book_genres` (Junction Table)
--
TRUNCATE TABLE `book_genres`;
INSERT INTO `book_genres` (`book_id`, `genre_id`) VALUES
(1, 2), (1, 8), (2, 1), (2, 3), (3, 6), (3, 7), (3, 13), (4, 1), (4, 3), (4, 8),
(5, 4), (5, 5), (6, 9), (6, 10), (7, 9), (7, 11), (7, 5), (8, 6), (8, 12),
(9, 6), (9, 14), (10, 12), (10, 13), (11, 6), (11, 7), (11, 13), (12, 16), (12, 21), (12, 4),
(13, 16), (13, 21), (13, 4), (14, 16), (15, 16), (15, 17), (16, 6), (16, 15), (17, 6), (17, 15),
(18, 9), (18, 10), (19, 9), (19, 10), (20, 9), (20, 10), (20, 1), (20, 8), (21, 6), (21, 20), (21, 8),
(22, 6), (22, 20), (23, 23), (23, 21), (23, 4), (24, 23), (24, 14), (24, 19), (25, 1), (25, 8), (25, 2),
(26, 2), (26, 8), (27, 16), (27, 2), (27, 4), (28, 5), (29, 5), (30, 5), (30, 22), (31, 5), (31, 4), (31, 2),
(32, 4), (33, 4), (34, 4), (35, 16), (36, 16), (37, 16), (37, 5), (38, 5), (38, 16), (39, 5), (39, 16),
(40, 16), (41, 16), (42, 16), (42, 14), (43, 16), (43, 18), (44, 16), (44, 18), (45, 15), (45, 16),
(46, 15), (46, 6), (47, 6), (47, 14), (48, 6), (48, 12), (49, 9), (49, 11), (49, 14),
(50, 9), (50, 11), (50, 8), (50, 1), (51, 9), (51, 11), (51, 3), (51, 4), (52, 6), (52, 8), (52, 13),
(53, 6), (53, 8), (53, 20), (54, 14), (54, 6), (55, 16), (55, 18), (56, 16), (56, 8), (56, 2),
(57, 16), (57, 2), (58, 21), (58, 4), (59, 21), (59, 4), (60, 16), (60, 22), (61, 12), (61, 15), (61, 14),
(62, 12), (62, 13), (63, 12), (63, 13), (64, 15), (64, 13), (64, 6), (65, 12), (65, 6);

--
-- Populating table `book_copies` (Expanded to ~150 copies)
--
INSERT INTO `book_copies` (`book_id`, `condition`, `status`, `shelf_location`) VALUES
(1, 'Good', 'Available', 'HOR-S-01'), (1, 'Worn', 'Available', 'HOR-S-01'),
(2, 'Good', 'Available', 'THR-M-01'), (2, 'Good', 'Available', 'THR-M-01'),
(3, 'New', 'Available', 'CS-A-01'), (3, 'Good', 'Available', 'CS-A-01'), (3, 'Worn', 'Maintenance', 'CS-A-01'),
(4, 'Good', 'Available', 'THR-F-01'), (4, 'New', 'Available', 'THR-F-01'),
(5, 'Good', 'Available', 'SF-H-01'), (5, 'Worn', 'Available', 'SF-H-01'), (5, 'Good', 'Available', 'SF-H-01'),
(6, 'New', 'Available', 'MANGA-A-01'), (6, 'New', 'Available', 'MANGA-A-01'),
(7, 'New', 'Available', 'MANGA-B-01'), (7, 'New', 'Available', 'MANGA-B-01'), (7, 'New', 'Available', 'MANGA-B-01'),
(8, 'Good', 'Available', 'SCI-H-01'), (8, 'Worn', 'Available', 'SCI-H-01'),
(9, 'New', 'Available', 'HIST-H-01'), (9, 'New', 'Available', 'HIST-H-01'),
(10, 'Good', 'Available', 'CS-A-02'), (10, 'Worn', 'Available', 'CS-A-02'), (10, 'Good', 'Available', 'CS-A-02'),
(11, 'Good', 'Available', 'CS-A-01'), (11, 'Good', 'Available', 'CS-A-01'),
(12, 'Good', 'Available', 'CLASSIC-O-01'), (12, 'Worn', 'Available', 'CLASSIC-O-01'),
(13, 'Good', 'Available', 'CLASSIC-H-01'), (13, 'Good', 'Available', 'CLASSIC-H-01'),
(14, 'Worn', 'Available', 'CLASSIC-S-01'), (14, 'Good', 'Available', 'CLASSIC-S-01'),
(15, 'Good', 'Available', 'CLASSIC-A-01'), (15, 'Worn', 'Available', 'CLASSIC-A-01'),
(16, 'New', 'Available', 'PHIL-A-01'), (16, 'Good', 'Available', 'PHIL-A-01'),
(17, 'Good', 'Available', 'PHIL-N-01'),
(18, 'New', 'Available', 'MANGA-K-01'), (18, 'New', 'Available', 'MANGA-K-01'),
(19, 'New', 'Available', 'MANGA-O-01'), (19, 'New', 'Available', 'MANGA-O-01'),
(20, 'New', 'Available', 'MANGA-O-02'), (20, 'New', 'Available', 'MANGA-O-02'),
(21, 'New', 'Available', 'SELF-C-01'), (21, 'New', 'Available', 'SELF-C-01'),
(22, 'New', 'Available', 'SELF-H-01'), (22, 'New', 'Available', 'SELF-H-01'),
(23, 'Good', 'Available', 'GRAPHIC-M-01'),
(24, 'Good', 'Available', 'GRAPHIC-S-01'),
(25, 'Worn', 'Available', 'THR-H-01'), (25, 'Good', 'Available', 'THR-H-01'),
(26, 'Good', 'Available', 'HOR-K-01'), (26, 'Worn', 'Available', 'HOR-K-01'),
(27, 'Worn', 'Available', 'CLASSIC-S-02'), (27, 'Worn', 'Available', 'CLASSIC-S-02'),
(28, 'Good', 'Available', 'FAN-R-01'), (28, 'New', 'Available', 'FAN-R-01'),
(29, 'New', 'Available', 'FAN-S-01'), (29, 'New', 'Available', 'FAN-S-01'), (29, 'New', 'Available', 'FAN-S-01'),
(30, 'Good', 'Available', 'FAN-M-01'), (30, 'Good', 'Available', 'FAN-M-01'),
(31, 'Worn', 'Available', 'FAN-K-01'),
(32, 'Good', 'Available', 'SF-S-01'), (32, 'Worn', 'Available', 'SF-S-01'),
(33, 'Worn', 'Available', 'SF-G-01'),
(34, 'Good', 'Available', 'SF-A-01'), (34, 'Worn', 'Available', 'SF-A-01'),
(35, 'Worn', 'Available', 'CLASSIC-F-01'), (35, 'Good', 'Available', 'CLASSIC-F-01'),
(36, 'Worn', 'Available', 'CLASSIC-L-01'), (36, 'Good', 'Available', 'CLASSIC-L-01'),
(37, 'Good', 'Available', 'CLASSIC-M-01'),
(38, 'Good', 'Available', 'FAN-T-01'), (38, 'Worn', 'Available', 'FAN-T-01'), (38, 'New', 'Available', 'FAN-T-01'),
(39, 'Good', 'Available', 'FAN-T-01'), (39, 'Good', 'Available', 'FAN-T-01'),
(40, 'Worn', 'Available', 'CLASSIC-C-01'),
(41, 'Worn', 'Available', 'CLASSIC-M-02'),
(42, 'Good', 'Available', 'CLASSIC-T-01'),
(43, 'Worn', 'Available', 'CLASSIC-H-02'), (43, 'Good', 'Available', 'CLASSIC-H-02'),
(44, 'Worn', 'Available', 'CLASSIC-D-01'),
(45, 'Good', 'Available', 'PHIL-P-01'), (45, 'Worn', 'Available', 'PHIL-P-01'),
(46, 'Good', 'Available', 'PHIL-M-01'),
(47, 'Good', 'Available', 'HIST-D-01'), (47, 'New', 'Available', 'HIST-D-01'),
(48, 'Good', 'Available', 'SCI-S-01'), (48, 'Worn', 'Available', 'SCI-S-01'),
(49, 'New', 'Available', 'MANGA-I-01'), (49, 'New', 'Available', 'MANGA-I-01'),
(50, 'New', 'Available', 'MANGA-U-01'), (50, 'New', 'Available', 'MANGA-U-01'),
(51, 'New', 'Available', 'MANGA-U-01'), (51, 'New', 'Available', 'MANGA-U-01'),
(52, 'New', 'Available', 'CS-N-01'), (52, 'Good', 'Available', 'CS-N-01'),
(53, 'New', 'Available', 'SELF-K-01'), (53, 'New', 'Available', 'SELF-K-01'),
(54, 'Good', 'Available', 'HIST-Z-01'), (54, 'Worn', 'Available', 'HIST-Z-01'),
(55, 'Worn', 'Available', 'CLASSIC-H-02'),
(56, 'Good', 'Available', 'CLASSIC-W-01'),
(57, 'Worn', 'Available', 'CLASSIC-S-03'), (57, 'Good', 'Available', 'CLASSIC-S-03'),
(58, 'New', 'Available', 'DYS-A-01'), (58, 'Good', 'Available', 'DYS-A-01'),
(59, 'Good', 'Available', 'DYS-M-01'),
(60, 'Good', 'Available', 'CLASSIC-M-03'),
(61, 'Worn', 'Available', 'PHIL-K-01'), (61, 'Good', 'Available', 'PHIL-K-01'),
(62, 'Good', 'Available', 'CS-S-01'), (62, 'Worn', 'Available', 'CS-S-01'),
(63, 'Worn', 'Available', 'CS-A-03'), (63, 'Worn', 'Available', 'CS-A-03'),
(64, 'Good', 'Available', 'PHIL-H-01'),
(65, 'Good', 'Available', 'SCI-D-01');


-- Populating table `transactions` (Added more for student_alex)
TRUNCATE TABLE `transactions`;
INSERT INTO `transactions` (`transaction_id`, `account_id`, `copy_id`, `transaction_type`, `date_borrowed`, `date_due`, `date_returned`, `fine`, `status`) VALUES
(1, 3, 3, 'Borrow', '2025-10-25 14:30:10', '2025-11-08 14:30:10', NULL, 0.00, 'Borrowed'),
(2, 3, 1, 'Borrow', '2025-10-10 11:15:00', '2025-10-24 11:15:00', '2025-10-16 09:05:20', 0.00, 'Returned'),
(3, 3, 6, 'Borrow', '2025-10-15 10:00:00', '2025-10-29 10:00:00', NULL, 5.00, 'Overdue'),
(4, 3, 14, 'Borrow', '2025-10-28 16:00:00', '2025-11-11 16:00:00', NULL, 0.00, 'Borrowed'),
(5, 3, 24, 'Borrow', '2025-10-20 09:00:00', '2025-11-03 09:00:00', '2025-10-28 15:59:00', 0.00, 'Returned');

-- UPDATE book_copies statuses based on new transactions
UPDATE `book_copies` SET `status` = 'Borrowed' WHERE `copy_id` IN (3, 6, 14);
UPDATE `book_copies` SET `status` = 'Available' WHERE `copy_id` IN (1, 24);

-- Populating table `favorites` (Added more for student_alex)
TRUNCATE TABLE `favorites`;
INSERT INTO `favorites` (`account_id`, `book_id`, `date_added`) VALUES
(3, 1, '2025-10-10 11:10:00'),
(3, 3, '2025-10-11 15:00:00'),
(3, 7, '2025-10-28 16:01:00'),
(3, 10, '2025-10-11 15:01:00'),
(3, 50, '2025-10-29 08:00:00');

-- Populating table `announcements` (No changes, kept from previous script)
TRUNCATE TABLE `announcements`;
INSERT INTO `announcements` (`admin_id`, `title`, `message`, `date_posted`, `expiry_date`, `priority`, `is_active`) VALUES
(1, 'Welcome to the New Library System!', 'The OOP Library System is now fully operational. Please report any bugs to the front desk. Enjoy your reading!', '2025-10-28 08:00:00', '2025-11-30 23:59:59', 'High', 1),
(2, 'Holiday Hours', 'The library will be closed on November 1st for All Saints\' Day.', '2025-10-29 10:00:00', '2025-11-02 00:00:00', 'Normal', 1);

-- Populating table `logs` (No changes, kept from previous script)
TRUNCATE TABLE `logs`;
INSERT INTO `logs` (`account_id`, `action`, `details`, `ip_address`, `severity`) VALUES
(1, 'User Login', 'Admin login successful.', '192.168.1.1', 'Info'),
(NULL, 'Failed Login', 'Attempted login for username: ''admin'' with wrong password.', '10.0.0.5', 'Warning'),
(2, 'Book Copy Added', 'Added 3 copies for BookID: 7 (Berserk)', '192.168.1.3', 'Info'),
(3, 'Book Borrowed', 'TransactionID: 4, CopyID: 14', '192.168.5.10', 'Info'),
(3, 'Book Returned', 'TransactionID: 5, CopyID: 24', '192.168.5.10', 'Info');

-- Populating table `notifications` (Added more for student_alex)
TRUNCATE TABLE `notifications`;
INSERT INTO `notifications` (`account_id`, `transaction_id`, `message`, `is_read`, `notification_type`) VALUES
(3, NULL, 'A new book you might like, "Monster, Vol. 1", has been added to the Manga section.', 0, 2),
(3, 1, 'Your book, "Big Little Lies", is due on 2025-11-08.', 1, 3),
(3, 3, 'Your borrowed book, "Clean Code", is overdue. Please return it as soon as possible. A fine is accumulating.', 0, 1),
(3, 4, 'Your book, "Berserk, Vol. 1", is due on 2025-11-11.', 0, 3);

--
-- Set foreign key checks back to 1
--
SET foreign_key_checks = 1;