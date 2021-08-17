-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema turisticka_agencija
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema turisticka_agencija
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `turisticka_agencija` DEFAULT CHARACTER SET utf8 ;
USE `turisticka_agencija` ;

-- -----------------------------------------------------
-- Table `turisticka_agencija`.`MJESTO`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`MJESTO` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(45) NOT NULL,
  `BrojPoste` INT NOT NULL,
  `Drzava` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`ADRESA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`ADRESA` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Ulica` VARCHAR(255) NOT NULL,
  `Broj` INT NOT NULL,
  `Mjesto` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_ADRESA_MJESTO1_idx` (`Mjesto` ASC) VISIBLE,
  CONSTRAINT `fk_ADRESA_MJESTO1`
    FOREIGN KEY (`Mjesto`)
    REFERENCES `turisticka_agencija`.`MJESTO` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`POSLOVNICA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`POSLOVNICA` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(255) NOT NULL,
  `JIB` CHAR(13) NOT NULL,
  `Email` VARCHAR(255) NULL,
  `Adresa` INT NOT NULL,
  `Sjediste` INT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `JIB_UNIQUE` (`JIB` ASC) VISIBLE,
  INDEX `fk_POSLOVNICA_ADRESA1_idx` (`Adresa` ASC) VISIBLE,
  INDEX `fk_POSLOVNICA_POSLOVNICA1_idx` (`Sjediste` ASC) VISIBLE,
  UNIQUE INDEX `Adresa_UNIQUE` (`Adresa` ASC) VISIBLE,
  CONSTRAINT `fk_POSLOVNICA_ADRESA1`
    FOREIGN KEY (`Adresa`)
    REFERENCES `turisticka_agencija`.`ADRESA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_POSLOVNICA_POSLOVNICA1`
    FOREIGN KEY (`Sjediste`)
    REFERENCES `turisticka_agencija`.`POSLOVNICA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`TELEFON`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`TELEFON` (
  `BrojTelefona` VARCHAR(45) NOT NULL,
  `Poslovnica` INT NOT NULL,
  PRIMARY KEY (`Poslovnica`, `BrojTelefona`),
  INDEX `fk_TELEFON_POSLOVNICA1_idx` (`Poslovnica` ASC) VISIBLE,
  CONSTRAINT `fk_TELEFON_POSLOVNICA1`
    FOREIGN KEY (`Poslovnica`)
    REFERENCES `turisticka_agencija`.`POSLOVNICA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`ZAPOSLENI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`ZAPOSLENI` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Ime` VARCHAR(45) NOT NULL,
  `Prezime` VARCHAR(45) NOT NULL,
  `JMB` CHAR(13) NOT NULL,
  `Zvanje` VARCHAR(45) NULL,
  `Plata` DECIMAL(8,2) NOT NULL,
  `Poslovnica` INT NOT NULL,
  `AdresaPrebivalista` INT NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `JMB_UNIQUE` (`JMB` ASC) VISIBLE,
  INDEX `fk_ZAPOSLENI_POSLOVNICA1_idx` (`Poslovnica` ASC) VISIBLE,
  INDEX `fk_ZAPOSLENI_ADRESA1_idx` (`AdresaPrebivalista` ASC) VISIBLE,
  CONSTRAINT `fk_ZAPOSLENI_POSLOVNICA1`
    FOREIGN KEY (`Poslovnica`)
    REFERENCES `turisticka_agencija`.`POSLOVNICA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ZAPOSLENI_ADRESA1`
    FOREIGN KEY (`AdresaPrebivalista`)
    REFERENCES `turisticka_agencija`.`ADRESA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`NALOG`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`NALOG` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `KorisnickoIme` VARCHAR(25) NOT NULL,
  `Lozinka` VARCHAR(25) NOT NULL,
  `Zaposleni` INT NOT NULL,
  INDEX `fk_NALOG_ZAPOSLENI1_idx` (`Zaposleni` ASC) VISIBLE,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `KorisnickoIme_UNIQUE` (`KorisnickoIme` ASC) VISIBLE,
  CONSTRAINT `fk_NALOG_ZAPOSLENI1`
    FOREIGN KEY (`Zaposleni`)
    REFERENCES `turisticka_agencija`.`ZAPOSLENI` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`KOMERCIJALISTA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`KOMERCIJALISTA` (
  `IdZaposlenog` INT NOT NULL,
  PRIMARY KEY (`IdZaposlenog`),
  CONSTRAINT `fk_KOMERCIJALISTA_ZAPOSLENI1`
    FOREIGN KEY (`IdZaposlenog`)
    REFERENCES `turisticka_agencija`.`ZAPOSLENI` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`CIJENA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`CIJENA` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `TroskoviPrevoza` DECIMAL(8,2) NOT NULL,
  `CijenaSmjestaja` DECIMAL(8,2) NOT NULL,
  `CijenaOsiguranja` DECIMAL(8,2) NOT NULL,
  `BoravisnaTaksa` DECIMAL(8,2) NOT NULL,
  `Ukupno` DECIMAL(8,2) NOT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`PONUDA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`PONUDA` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(255) NOT NULL,
  `Komercijalista` INT NOT NULL,
  `Cijena` INT NOT NULL,
  `DatumKreiranja` DATETIME NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_PONUDA_KOMERCIJALISTA1_idx` (`Komercijalista` ASC) VISIBLE,
  INDEX `fk_PONUDA_CIJENA1_idx` (`Cijena` ASC) VISIBLE,
  CONSTRAINT `fk_PONUDA_KOMERCIJALISTA1`
    FOREIGN KEY (`Komercijalista`)
    REFERENCES `turisticka_agencija`.`KOMERCIJALISTA` (`IdZaposlenog`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PONUDA_CIJENA1`
    FOREIGN KEY (`Cijena`)
    REFERENCES `turisticka_agencija`.`CIJENA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`IZLET`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`IZLET` (
  `IdPonude` INT NOT NULL,
  `Datum` DATE NOT NULL,
  `VrijemePolaska` TIME NOT NULL,
  `VrijemePovratka` TIME NOT NULL,
  PRIMARY KEY (`IdPonude`),
  CONSTRAINT `fk_IZLET_PONUDA1`
    FOREIGN KEY (`IdPonude`)
    REFERENCES `turisticka_agencija`.`PONUDA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`PUTOVANJE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`PUTOVANJE` (
  `IdPonude` INT NOT NULL,
  `Polazak` DATETIME NOT NULL,
  `Povratak` DATETIME NOT NULL,
  PRIMARY KEY (`IdPonude`),
  CONSTRAINT `fk_table1_PONUDA1`
    FOREIGN KEY (`IdPonude`)
    REFERENCES `turisticka_agencija`.`PONUDA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`POSLOVODJA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`POSLOVODJA` (
  `IdZaposlenog` INT NOT NULL,
  PRIMARY KEY (`IdZaposlenog`),
  CONSTRAINT `fk_RACUNOVODJA_ZAPOSLENI1`
    FOREIGN KEY (`IdZaposlenog`)
    REFERENCES `turisticka_agencija`.`ZAPOSLENI` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`VODIC`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`VODIC` (
  `IdZaposlenog` INT NOT NULL,
  `BrojLicence` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`IdZaposlenog`),
  UNIQUE INDEX `BrojLicence_UNIQUE` (`BrojLicence` ASC) VISIBLE,
  CONSTRAINT `fk_VODIC_ZAPOSLENI1`
    FOREIGN KEY (`IdZaposlenog`)
    REFERENCES `turisticka_agencija`.`ZAPOSLENI` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`AUTOBUS`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`AUTOBUS` (
  `RegistarskiBroj` CHAR(9) NOT NULL,
  `Proizvodjac` VARCHAR(45) NOT NULL,
  `Model` VARCHAR(45) NOT NULL,
  `BrojSjedista` INT NOT NULL,
  UNIQUE INDEX `RegistarskiBroj_UNIQUE` (`RegistarskiBroj` ASC) VISIBLE,
  PRIMARY KEY (`RegistarskiBroj`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`VOZAC`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`VOZAC` (
  `IdZaposlenog` INT NOT NULL,
  `BrojVozackeDozvole` CHAR(10) NOT NULL,
  PRIMARY KEY (`IdZaposlenog`),
  UNIQUE INDEX `BrojVozackeDozvole_UNIQUE` (`BrojVozackeDozvole` ASC) VISIBLE,
  CONSTRAINT `fk_VOZAC_ZAPOSLENI1`
    FOREIGN KEY (`IdZaposlenog`)
    REFERENCES `turisticka_agencija`.`ZAPOSLENI` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`BANKA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`BANKA` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(45) NOT NULL,
  `Adresa` INT NOT NULL,
  `Telefon` VARCHAR(45) NULL,
  `Email` VARCHAR(45) NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_BANKA_ADRESA1_idx` (`Adresa` ASC) VISIBLE,
  UNIQUE INDEX `Adresa_UNIQUE` (`Adresa` ASC) VISIBLE,
  CONSTRAINT `fk_BANKA_ADRESA1`
    FOREIGN KEY (`Adresa`)
    REFERENCES `turisticka_agencija`.`ADRESA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`HOTEL`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`HOTEL` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(45) NOT NULL,
  `Email` VARCHAR(255) NULL,
  `Telefon` VARCHAR(45) NULL,
  `Adresa` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_HOTEL_ADRESA1_idx` (`Adresa` ASC) VISIBLE,
  UNIQUE INDEX `Adresa_UNIQUE` (`Adresa` ASC) VISIBLE,
  CONSTRAINT `fk_HOTEL_ADRESA1`
    FOREIGN KEY (`Adresa`)
    REFERENCES `turisticka_agencija`.`ADRESA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`OSIGURAVAJUCA_KUCA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`OSIGURAVAJUCA_KUCA` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(45) NOT NULL,
  `Adresa` INT NOT NULL,
  `Telefon` VARCHAR(45) NULL,
  `Email` VARCHAR(45) NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_OSIGURAVAJUCA_KUCA_ADRESA1_idx` (`Adresa` ASC) VISIBLE,
  UNIQUE INDEX `Adresa_UNIQUE` (`Adresa` ASC) VISIBLE,
  CONSTRAINT `fk_OSIGURAVAJUCA_KUCA_ADRESA1`
    FOREIGN KEY (`Adresa`)
    REFERENCES `turisticka_agencija`.`ADRESA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`TEKUCI_RACUN`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`TEKUCI_RACUN` (
  `BrojRacuna` CHAR(16) NOT NULL,
  `Banka` INT NOT NULL,
  `Poslovnica` INT NULL,
  `Hotel` INT NULL,
  `OsiguravajucaKuca` INT NULL,
  INDEX `fk_RACUN_POSLOVNICA1_idx` (`Poslovnica` ASC) VISIBLE,
  PRIMARY KEY (`BrojRacuna`),
  INDEX `fk_RACUN_BANKA1_idx` (`Banka` ASC) VISIBLE,
  INDEX `fk_TEKUCI_RACUN_HOTEL1_idx` (`Hotel` ASC) VISIBLE,
  INDEX `fk_TEKUCI_RACUN_OSIGURAVAJUCA_KUCA1_idx` (`OsiguravajucaKuca` ASC) VISIBLE,
  UNIQUE INDEX `BrojRacuna_UNIQUE` (`BrojRacuna` ASC) VISIBLE,
  CONSTRAINT `fk_RACUN_POSLOVNICA1`
    FOREIGN KEY (`Poslovnica`)
    REFERENCES `turisticka_agencija`.`POSLOVNICA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_RACUN_BANKA1`
    FOREIGN KEY (`Banka`)
    REFERENCES `turisticka_agencija`.`BANKA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TEKUCI_RACUN_HOTEL1`
    FOREIGN KEY (`Hotel`)
    REFERENCES `turisticka_agencija`.`HOTEL` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TEKUCI_RACUN_OSIGURAVAJUCA_KUCA1`
    FOREIGN KEY (`OsiguravajucaKuca`)
    REFERENCES `turisticka_agencija`.`OSIGURAVAJUCA_KUCA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`SMJESTAJ`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`SMJESTAJ` (
  `Putovanje` INT NOT NULL,
  `Hotel` INT NOT NULL,
  `DatumPrijave` DATETIME NOT NULL,
  `DatumOdjave` DATETIME NOT NULL,
  `VrstaSmjestaja` VARCHAR(45) NULL,
  PRIMARY KEY (`Putovanje`, `Hotel`),
  INDEX `fk_PUTOVANJE_has_HOTEL_HOTEL1_idx` (`Hotel` ASC) VISIBLE,
  INDEX `fk_PUTOVANJE_has_HOTEL_PUTOVANJE1_idx` (`Putovanje` ASC) VISIBLE,
  CONSTRAINT `fk_PUTOVANJE_has_HOTEL_PUTOVANJE1`
    FOREIGN KEY (`Putovanje`)
    REFERENCES `turisticka_agencija`.`PUTOVANJE` (`IdPonude`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PUTOVANJE_has_HOTEL_HOTEL1`
    FOREIGN KEY (`Hotel`)
    REFERENCES `turisticka_agencija`.`HOTEL` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`OSIGURANJE`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`OSIGURANJE` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `OsiguravajucaKuca` INT NOT NULL,
  `Ponuda` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_OSIGURANJE_OSIGURAVAJUCA_KUCA1_idx` (`OsiguravajucaKuca` ASC) VISIBLE,
  INDEX `fk_OSIGURANJE_PONUDA1_idx` (`Ponuda` ASC) VISIBLE,
  UNIQUE INDEX `PONUDA_Id_UNIQUE` (`Ponuda` ASC) VISIBLE,
  CONSTRAINT `fk_OSIGURANJE_OSIGURAVAJUCA_KUCA1`
    FOREIGN KEY (`OsiguravajucaKuca`)
    REFERENCES `turisticka_agencija`.`OSIGURAVAJUCA_KUCA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_OSIGURANJE_PONUDA1`
    FOREIGN KEY (`Ponuda`)
    REFERENCES `turisticka_agencija`.`PONUDA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`PUTNIK`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`PUTNIK` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Ime` VARCHAR(45) NOT NULL,
  `Prezime` VARCHAR(45) NOT NULL,
  `JMB` CHAR(13) NOT NULL,
  `BrojLicneKarte` CHAR(9) NULL,
  `BrojPasosa` CHAR(8) NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `BrojLicneKarte_UNIQUE` (`BrojLicneKarte` ASC) VISIBLE,
  UNIQUE INDEX `BrojPasosa_UNIQUE` (`BrojPasosa` ASC) VISIBLE,
  UNIQUE INDEX `JMB_UNIQUE` (`JMB` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`REZERVACIJA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`REZERVACIJA` (
  `DatumRezervisanja` DATETIME NOT NULL,
  `Poslovodja` INT NOT NULL,
  `Putnik` INT NOT NULL,
  `Ponuda` INT NOT NULL,
  INDEX `fk_REZERVACIJA_RACUNOVODJA1_idx` (`Poslovodja` ASC) VISIBLE,
  INDEX `fk_REZERVACIJA_PUTNIK1_idx` (`Putnik` ASC) VISIBLE,
  INDEX `fk_REZERVACIJA_PONUDA1_idx` (`Ponuda` ASC) VISIBLE,
  PRIMARY KEY (`Ponuda`, `Putnik`),
  CONSTRAINT `fk_REZERVACIJA_RACUNOVODJA1`
    FOREIGN KEY (`Poslovodja`)
    REFERENCES `turisticka_agencija`.`POSLOVODJA` (`IdZaposlenog`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_REZERVACIJA_PUTNIK1`
    FOREIGN KEY (`Putnik`)
    REFERENCES `turisticka_agencija`.`PUTNIK` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_REZERVACIJA_PONUDA1`
    FOREIGN KEY (`Ponuda`)
    REFERENCES `turisticka_agencija`.`PONUDA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`KARTA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`KARTA` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `DatumIzdavanja` DATETIME NOT NULL,
  `Ponuda` INT NOT NULL,
  `Putnik` INT NOT NULL,
  `RedniBrojAutobusa` INT NOT NULL,
  `BrojSjedista` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_KARTA_REZERVACIJA1_idx` (`Ponuda` ASC, `Putnik` ASC) VISIBLE,
  CONSTRAINT `fk_KARTA_REZERVACIJA1`
    FOREIGN KEY (`Ponuda` , `Putnik`)
    REFERENCES `turisticka_agencija`.`REZERVACIJA` (`Ponuda` , `Putnik`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`KOORDINATOR`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`KOORDINATOR` (
  `IdZaposlenog` INT NOT NULL,
  PRIMARY KEY (`IdZaposlenog`),
  CONSTRAINT `fk_KOORDINATOR_ZAPOSLENI1`
    FOREIGN KEY (`IdZaposlenog`)
    REFERENCES `turisticka_agencija`.`ZAPOSLENI` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`PREVOZ_NA_DIONICI`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`PREVOZ_NA_DIONICI` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Koordinator` INT NOT NULL,
  `Ponuda` INT NOT NULL,
  `MjestoPolaska` VARCHAR(45) NOT NULL,
  `MjestoOdredista` VARCHAR(45) NOT NULL,
  `VrijemePolaska` DATETIME NOT NULL,
  `VrijemeDolaska` DATETIME NOT NULL,
  `Vozac` INT NOT NULL,
  `Vodic` INT NOT NULL,
  `Autobus` CHAR(9) NOT NULL,
  INDEX `fk_PLAN_PREVOZA_KOORDINATOR1_idx` (`Koordinator` ASC) VISIBLE,
  PRIMARY KEY (`Id`),
  INDEX `fk_PREVOZ_NA_DIONICI_PONUDA1_idx` (`Ponuda` ASC) VISIBLE,
  INDEX `fk_PREVOZ_NA_DIONICI_VOZAC1_idx` (`Vozac` ASC) VISIBLE,
  INDEX `fk_PREVOZ_NA_DIONICI_VODIC1_idx` (`Vodic` ASC) VISIBLE,
  INDEX `fk_PREVOZ_NA_DIONICI_AUTOBUS1_idx` (`Autobus` ASC) VISIBLE,
  CONSTRAINT `fk_PLAN_PREVOZA_KOORDINATOR1`
    FOREIGN KEY (`Koordinator`)
    REFERENCES `turisticka_agencija`.`KOORDINATOR` (`IdZaposlenog`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PREVOZ_NA_DIONICI_PONUDA1`
    FOREIGN KEY (`Ponuda`)
    REFERENCES `turisticka_agencija`.`PONUDA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PREVOZ_NA_DIONICI_VOZAC1`
    FOREIGN KEY (`Vozac`)
    REFERENCES `turisticka_agencija`.`VOZAC` (`IdZaposlenog`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PREVOZ_NA_DIONICI_VODIC1`
    FOREIGN KEY (`Vodic`)
    REFERENCES `turisticka_agencija`.`VODIC` (`IdZaposlenog`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PREVOZ_NA_DIONICI_AUTOBUS1`
    FOREIGN KEY (`Autobus`)
    REFERENCES `turisticka_agencija`.`AUTOBUS` (`RegistarskiBroj`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`TIP_OSIGURANJA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`TIP_OSIGURANJA` (
  `Osiguranje` INT NOT NULL,
  `Naziv` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Osiguranje`, `Naziv`),
  CONSTRAINT `fk_TIP_OSIGURANJA_OSIGURANJE1`
    FOREIGN KEY (`Osiguranje`)
    REFERENCES `turisticka_agencija`.`OSIGURANJE` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`POSJETA_MJESTU`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`POSJETA_MJESTU` (
  `Ponuda` INT NOT NULL,
  `Mjesto` INT NOT NULL,
  `DatumPosjete` DATETIME NULL,
  PRIMARY KEY (`Ponuda`, `Mjesto`),
  INDEX `fk_PONUDA_has_MJESTO_MJESTO1_idx` (`Mjesto` ASC) VISIBLE,
  INDEX `fk_PONUDA_has_MJESTO_PONUDA1_idx` (`Ponuda` ASC) VISIBLE,
  CONSTRAINT `fk_PONUDA_has_MJESTO_PONUDA1`
    FOREIGN KEY (`Ponuda`)
    REFERENCES `turisticka_agencija`.`PONUDA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PONUDA_has_MJESTO_MJESTO1`
    FOREIGN KEY (`Mjesto`)
    REFERENCES `turisticka_agencija`.`MJESTO` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`POPUST`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`POPUST` (
  `CIJENA_Id` INT NOT NULL,
  `Vrsta` VARCHAR(45) NOT NULL,
  `IznosUProcentima` INT NOT NULL,
  PRIMARY KEY (`CIJENA_Id`, `Vrsta`),
  CONSTRAINT `fk_POPUST_CIJENA1`
    FOREIGN KEY (`CIJENA_Id`)
    REFERENCES `turisticka_agencija`.`CIJENA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `turisticka_agencija`.`ULAZNICA`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `turisticka_agencija`.`ULAZNICA` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Naziv` VARCHAR(45) NOT NULL,
  `Iznos` DECIMAL(8,2) NOT NULL,
  PRIMARY KEY (`Id`, `Naziv`),
  CONSTRAINT `fk_ULAZNICA_CIJENA1`
    FOREIGN KEY (`Id`)
    REFERENCES `turisticka_agencija`.`CIJENA` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
