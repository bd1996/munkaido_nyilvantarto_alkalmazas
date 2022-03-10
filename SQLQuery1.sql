CREATE DATABASE VacationDB;
CREATE TABLE Employee (
	employee_id int IDENTITY (1, 1) PRIMARY KEY NOT NULL ,
	email_address nvarchar (250) NOT NULL ,
	full_name nvarchar (250) NOT NULL,
	birth_date datetime NOT NULL ,
	password_hash int NOT NULL,
	remaining_vacation int NOT NULL,
	workhours_weekly int NOT NULL DEFAULT 40,
	is_admin bit NOT NULL DEFAULT 0
	);
--ALTER TABLE Employee ADD is_admin bit NOT NULL DEFAULT 0;
ALTER TABLE Employee ADD full_name nvarchar (250) NOT NULL;
ALTER TABLE Employee DROP COLUMN name; 
SELECT *FROM Employee;
COMMIT;

CREATE TABLE Work_date (
	date_id int IDENTITY (1, 1) PRIMARY KEY NOT NULL ,
	date_type nvarchar (15) NOT NULL CHECK(date_type IN ('WORKDAY','WEEKEND','HOLIDAY')),
	date_year int NOT NULL,
	date_month int NOT NULL,
	date_day int NOT NULL,
	CONSTRAINT unique_date UNIQUE NONCLUSTERED
    (
        date_year, date_month, date_day
    )
	);


CREATE TABLE Time_off_day ( 
	time_off_type nvarchar (15) NOT NULL CHECK(time_off_type IN ('PAID_LEAVE','SICK_LEAVE','UNPAID_LEAVE')),
	employee_id int FOREIGN KEY REFERENCES Employee(employee_id),
	date_id int FOREIGN KEY REFERENCES Work_date(date_id));

INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,1,1);	
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('WEEKEND',2022,3,14);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,3,15);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('WORKDAY',2022,3,26);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,4,15);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,4,18);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,5,1);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,6,5);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,6,6);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,8,20);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('WORKDAY',2022,10,15);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,10,23);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('WEEKEND',2022,10,31);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,11,1);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,12,25);
INSERT INTO Work_date (date_type,date_year,date_month,date_day) VALUES ('HOLIDAY',2022,12,26);


SELECT employee_id,email_address,full_name,birth_date,password_hash,remaining_vacation,workhours_weekly,is_admin FROM Employee;


/*Szabadság_típus
Dolgozó_id
Dátum_id

Év
Hónap
Nap
Nap_típus
Dátum_id
*/
