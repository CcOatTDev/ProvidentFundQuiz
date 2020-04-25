CREATE DATABASE `provident`; /*!40100 COLLATE 'utf8_unicode_ci' */

CREATE TABLE provident.`employeelog` (
	`EmployeeLogID` INT(20) NOT NULL AUTO_INCREMENT,
	`Firstname` VARCHAR(100) NOT NULL DEFAULT '' COLLATE 'utf8_unicode_ci',
	`Lastname` VARCHAR(100) NOT NULL DEFAULT '' COLLATE 'utf8_unicode_ci',
	`DateOfBirth` DATE NOT NULL,
	`StartWorkDate` DATE NOT NULL,
	`Salary` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
	`ProvidentFundRate` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
	`ProvidentFundCollectAmount` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
	PRIMARY KEY (`EmployeeLogID`)
)
COLLATE='utf8_unicode_ci'
ENGINE=InnoDB
;

CREATE TABLE provident.`employeelogdetail` (
	`EmployeeLogDetailID` INT(11) NOT NULL AUTO_INCREMENT,
	`EmployeeLogID` INT(11) NOT NULL DEFAULT 0,
	`WorkYear` VARCHAR(50) NOT NULL DEFAULT '',
	`Month` INT(10) NOT NULL DEFAULT 0,
	`Salary` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
	`PVDRate` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
	`CompanyPaidPercent` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
	`ProvidentFundCollect` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
	PRIMARY KEY (`EmployeeLogDetailID`)
)
COLLATE='utf8_unicode_ci'
ENGINE=InnoDB
;
