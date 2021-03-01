use contractorapi;
-- CREATE TABLE jobs(
--   id INT NOT NULL AUTO_INCREMENT,
--   Title VARCHAR(255) NOT NULL UNIQUE,
--   Location VARCHAR(255),
--   Description VARCHAR(255),
--   PRIMARY KEY(id)
-- );
-- INSERT INTO jobs
-- (Title,Location,Description)VALUES
-- ("Manager", "Boise","A new job.");

-- SELECT * FROM jobs;

-- CREATE TABLE contractworkers(
--   id INT NOT NULL AUTO_INCREMENT,
--   Name VARCHAR(255) NOT NULL,
--   Ratings INT,
--   PRIMARY KEY(id)
-- );
-- INSERT INTO contractworkers
-- (Name,Ratings)VALUES
-- ("John", 20);

-- SELECT * FROM contractworkers;

-- CREATE TABLE jobcontractors(
--   id INT NOT NULL AUTO_INCREMENT,
--   JobId INT,
--   ContractId INT,
--   PRIMARY KEY(id),

--   FOREIGN KEY(JobId)
--   REFERENCES jobs(id)
--   ON DELETE CASCADE,

--   FOREIGN KEY(ContractId)
--   REFERENCES contractworkers(id)
--   ON DELETE CASCADE
-- );

-- INSERT INTO jobcontractors
-- (JobId,ContractId)VALUES
-- (1,1);
-- INSERT INTO jobcontractors
-- (JobId,ContractId)VALUES
-- (1,3);
-- INSERT INTO jobcontractors
-- (JobId,ContractId)VALUES
-- (3,1);
-- INSERT INTO jobcontractors
-- (JobId,ContractId)VALUES
-- (3,3);
-- ALTER TABLE jobcontractors
-- ADD JobTitle VARCHAR(255);

-- UPDATE jobcontractors
-- SET JobTitle = "Manager"
-- WHERE id= 4;
UPDATE jobcontractors
SET JobTitle = "Software Developer"
WHERE id= 1;
UPDATE jobcontractors
SET JobTitle = "Manager"
WHERE id= 7;
UPDATE jobcontractors
SET JobTitle = "Doctor"
WHERE id= 4;
UPDATE jobcontractors
SET JobTitle = "Manager"
WHERE id= 12;
SELECT * FROM jobcontractors;