CREATE DATABASE IF NOT EXISTS AgendaIliana;
USE AgendaIliana;

CREATE TABLE IF NOT EXISTS User
(
    Id VARCHAR(36) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Name NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL
);

INSERT INTO User (Id, Username, Password, Name, LastName, Email) 
VALUES ('0', 'admin', 'admin', 'Iliana', 'Benchikh', 'benchikh.iliana@gmail.com');

-- Manually setting @last_id to the user ID
SET @last_id = '0';

SET @query = CONCAT('CREATE TABLE IF NOT EXISTS Friend_', @last_id, ' (
    Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    UserId VARCHAR(36) NOT NULL,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Address VARCHAR(100),
    Email VARCHAR(100),
    Phone VARCHAR(20),
    BirthDate DATE,
    Instagram VARCHAR(50),
    Facebook VARCHAR(50),
    LinkedIn VARCHAR(50),
    CONSTRAINT FK_Friend_', @last_id, '_User FOREIGN KEY (UserId) REFERENCES User(Id) ON DELETE CASCADE
)');
PREPARE stmt FROM @query;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;

CREATE TABLE IF NOT EXISTS Groupe
(
    FriendId VARCHAR(36) PRIMARY KEY,
    Friend BOOLEAN,
    Family BOOLEAN,
    Office BOOLEAN,
    CONSTRAINT FK_Groupe_Friend FOREIGN KEY (FriendId) REFERENCES User(Id) ON DELETE CASCADE
);
