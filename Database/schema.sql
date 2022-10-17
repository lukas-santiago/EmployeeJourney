-- Active: 1662095696133@@127.0.0.1@3306@employee_journey

CREATE TABLE IF NOT EXISTS `employee` (
  `id_employee` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255),
  `data` VARCHAR(255),
  PRIMARY KEY `pk_id_employee`(`id_employee`)
) ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `employee_history` (
  `id_employee_history` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_employee` INT UNSIGNED NOT NULL,
  `position` VARCHAR(255),
  `create_on` DATETIME,
  PRIMARY KEY `pk_id_employee_history`(`id_employee_history`),
  CONSTRAINT `fk_employee_history_id_employee` FOREIGN KEY (`id_employee`) REFERENCES `employee`(`id_employee`)
) ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `employee_feedback` (
  `id_employee_feedback` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `id_employee` INT UNSIGNED NOT NULL,
  `feedback` VARCHAR(255),
  `create_on` DATETIME,
  PRIMARY KEY `pk_id_employee_feedback`(`id_employee_feedback`),
  CONSTRAINT `fk_employee_feedback_id_employee` FOREIGN KEY (`id_employee`) REFERENCES `employee`(`id_employee`)
) ENGINE = InnoDB;