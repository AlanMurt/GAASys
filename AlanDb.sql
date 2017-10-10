-- Alan Moriarty T00175140  
-- Jan 2015
-- Script to create a GAASys

 -- Drop table Fixtures before creating it
DROP TABLE Fixtures;
DROP TABLE Teams;

Prompt Creating Teams Table
CREATE TABLE Teams
(TeamId numeric(5) NOT NULL,
 Name varchar(45) NOT NULL,
 Venue varchar(40) NOT NULL,
 Email varchar(50) NOT NULL,
 ContactName varchar(30) NOT NULL,
 ContactNumber varchar(15) NOT NULL,
 Won numeric(2) DEFAULT 0,
 Lost numeric(2) DEFAULT 0,
 Drawn numeric(2) DEFAULT 0,
 ScoresFor numeric(3) DEFAULT 0,
 ScoresAgainst numeric(3) DEFAULT 0,
 Points numeric(3) DEFAULT 0,
 CONSTRAINT pk_TeamId PRIMARY KEY (TeamId));
 

 
Prompt Creating Fixtures Table 
CREATE TABLE Fixtures
(FixturesId numeric(5) NOT NULL,
Team1Id numeric(5),
Team2Id numeric(5),
Team1Goals numeric(2),
Team1Points numeric(2),
Team2Goals numeric(2),
Team2Points numeric(2),
Venue varchar(30),
FixtureDate date,
FixtureTime varchar2(5),
CONSTRAINT pk_FixturesId PRIMARY KEY (FixturesId),
CONSTRAINT fk_Fix_Team1 FOREIGN KEY (Team1Id) REFERENCES Teams,
CONSTRAINT fk_Fix_Team2 FOREIGN KEY (Team2Id) REFERENCES Teams);



COMMIT;
