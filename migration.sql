CREATE DATABASE DataDictionary;
USE DataDictionary;

-- Drop tables
DROP TABLE IF EXISTS Product, UniversityMember, Student, Professor, User, AnimalSpecies, Animal;

CREATE TABLE AnimalSpecies (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    parent_id INT DEFAULT NULL,
    path_str VARCHAR(100) DEFAULT ''
);

CREATE TABLE Animal (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    species_id INT,
    FOREIGN KEY (species_id) REFERENCES AnimalSpecies(id)
);

INSERT INTO AnimalSpecies (id, name, parent_id, path_str)
VALUES
    (1, 'Animalija', NULL, ',1,'),
    (2, 'Hondri', 1, ',1,2,'),
    (3, 'Antropodi', 1, ',1,3,'),
    (4, 'Sisari', 2, ',1,2,4,'),
    (5, 'Ptice', 2, ',1,2,5,'),
    (6, 'Insekti', 3, ',1,3,6,');

    INSERT INTO Animal (id, name, species_id)
VALUES
    (1, 'Lav', 4),
    (2, 'Jelen', 4),
    (3, 'Roda', 5),
    (4, 'Lasta', 5),
    (5, 'Bubamara', 6),
    (6, 'Leptir', 6);


-- Create Product table
CREATE TABLE Product (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    available_quantity INT NOT NULL,
    sold_quantity INT NOT NULL
);



-- Insert 10 generic products with names
INSERT INTO Product (name, available_quantity, sold_quantity)
VALUES
    ('Laptop', 100, 0),
    ('Smartphone', 50, 0),
    ('Headphones', 75, 0),
    ('Tablet', 200, 0),
    ('Digital Camera', 30, 0),
    ('Smartwatch', 60, 0),
    ('Desktop Computer', 90, 0),
    ('Wireless Mouse', 120, 0),
    ('Bluetooth Speaker', 40, 0),
    ('External Hard Drive', 80, 0);

-- Create Student table
CREATE TABLE Student (
    id INT AUTO_INCREMENT PRIMARY KEY,
    enrollment_year INT,
    major VARCHAR(255) NOT NULL
);

-- Create Professor table
CREATE TABLE Professor (
    id INT AUTO_INCREMENT PRIMARY KEY,
    department VARCHAR(255) NOT NULL,
    research_area VARCHAR(255) NOT NULL
);

-- Create UniversityMember table
CREATE TABLE UniversityMember (
    member_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    professor_id INT DEFAULT NULL,
	student_id INT DEFAULT NULL,
	FOREIGN KEY (professor_id) REFERENCES Professor(id),
    FOREIGN KEY (student_id) REFERENCES Student(id)
);

-- Insert 10 Students
INSERT INTO Student (id, major, enrollment_year)
VALUES
    (1, 'Računarske nauke', 2020),
    (2, 'Matematika', 2019),
    (3, 'Inženjering', 2021),
    (4, 'Biologija', 2022),
    (5, 'Fizika', 2020),
    (6, 'Psihologija', 2019),
    (7, 'Istorija', 2022),
    (8, 'Ekonomija', 2021),
    (9, 'Engleski jezik', 2019),
    (10, 'Hemija', 2020);

-- Insert 10 Professors
INSERT INTO Professor (id, department, research_area)
VALUES
    (1, 'Računarske nauke', 'Mašinsko učenje'),
    (2, 'Matematika', 'Teorija brojeva'),
    (3, 'Inženjering', 'Robotika'),
    (4, 'Biologija', 'Genetika'),
    (5, 'Fizika', 'Kvantna fizika'),
    (6, 'Psihologija', 'Kognitivna psihologija'),
    (7, 'Istorija', 'Antička istorija'),
    (8, 'Ekonomija', 'Mikroekonomija'),
    (9, 'Engleski jezik', 'Američka književnost'),
    (10, 'Hemija', 'Organska hemija');
    
-- Insert members
INSERT INTO UniversityMember (member_id, name, email, professor_id, student_id)
VALUES
    (1, 'John Smith', 'john@example.com', 1 ,2),
    (2, 'Jane Doe', 'jane@example.com', 1, NULL),
    (3, 'David Brown', 'david@example.com', 2, NULL),
    (4, 'Emily White', 'emily@example.com', 3, NULL),
    (5, 'Michael Johnson', 'michael@example.com', NULL, 4),
    (6, 'Sophia Lee', 'sophia@example.com', NULL, 8),
    (7, 'Oliver Martin', 'oliver@example.com', 6, NULL),
    (8, 'Ava Wilson', 'ava@example.com', 4, NULL),
    (9, 'Ethan Anderson', 'ethan@example.com', 4, 6),
    (10, 'Isabella Hall', 'isabella@example.com', 10, NULL),
    (11, 'William Clark', 'william@example.com', NULL, 10),
    (12, 'Grace Harris', 'grace@example.com', 2, NULL),
    (13, 'Daniel Turner', 'daniel@example.com', 7, NULL),
    (14, 'Chloe Wilson', 'chloe@example.com', 5, NULL),
    (15, 'James Davis', 'james@example.com', NULL, 9),
    (16, 'Avery Rodriguez', 'avery@example.com', 2, 7),
    (17, 'Lily Allen', 'lily@example.com', NULL, 1),
    (18, 'Benjamin Martinez', 'benjamin@example.com', NULL, 3),
    (19, 'Zoe Perez', 'zoe@example.com', 8, NULL),
    (20, 'Samuel Young', 'samuel@example.com', NULL, 4);

-- Create User table
CREATE TABLE User (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(255) UNIQUE NOT NULL
);

-- Insert Users
INSERT INTO User (id, username)
VALUES
    (1, 'Pera'),
    (2, 'Zika'),
    (3, 'Mika');