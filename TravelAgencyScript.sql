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

-- -------------------------------------------------------------------------------------------------
-- PROCEDURE I FUNKCIJE
-- -------------------------------------------------------------------------------------------------

DELIMITER $$
create function zarada (pId int)
returns double
reads sql data
begin
	declare vZarada double;
	
    select c.Ukupno * count(k.Id) into vZarada
    from (ponuda p inner join cijena c on p.Cijena=c.Id)
		 inner join karta k on p.Id=k.Ponuda
    where p.Id=pId;
    
    return vZarada;
end$$
DELIMITER ;

DELIMITER $$
create function broj_karata (pId int)
returns int
reads sql data
begin
	declare brojKarata int;
	
    select count(k.Id) into brojKarata
    from ponuda p inner join karta k on p.Id=k.Ponuda
    where p.Id=pId;
    
    return brojKarata;
end$$
DELIMITER ;


DELIMITER $$
CREATE PROCEDURE vrsta_naloga (in pId int, out pVrsta int)
BEGIN
	declare vKomercijalista, vPoslovodja bool default false;
    set pVrsta=-1;
    
	SELECT COUNT(*) > 0 INTO vKomercijalista
    FROM komercijalista k WHERE k.IdZaposlenog = pId;
	
	SELECT COUNT(*) > 0 INTO vPoslovodja
	FROM poslovodja p WHERE p.IdZaposlenog = pId;
	
    if vPoslovodja and not vKomercijalista then set pVrsta=1; end if;
    if vKomercijalista and not vPoslovodja then set pVrsta=2; end if;
END$$
DELIMITER ;


DELIMITER $$
create procedure obrisi_izlet (in pId int, in cId int)
begin
    delete from izlet where izlet.IdPonude=pId;
    delete from ponuda where ponuda.Id=pId;
    delete from cijena where cijena.Id=cId;
end$$
DELIMITER ;


DELIMITER $$
create procedure obrisi_putovanje (in pId int, in cId int)
begin
    delete from putovanje where putovanje.IdPonude=pId;
    delete from ponuda where ponuda.Id=pId;
    delete from cijena where cijena.Id=cId;
end$$
DELIMITER ;

-- -------------------------------------------------------------------------------------------------
-- TRIGERI
-- -------------------------------------------------------------------------------------------------

create trigger brisanje_rezervacije before delete
on rezervacija
for each row
delete from karta where karta.Ponuda=old.Ponuda and karta.Putnik=old.Putnik;

create trigger brisanje_zaposlenog before delete
on zaposleni
for each row
delete from nalog where nalog.Zaposleni=old.Id;

create trigger izracunaj_cijenu before insert
on cijena
for each row
set new.Ukupno = new.TroskoviPrevoza + new.CijenaSmjestaja + new.CijenaOsiguranja + new.BoravisnaTaksa;

create trigger preracunaj_cijenu before update
on cijena
for each row
set new.Ukupno = new.TroskoviPrevoza + new.CijenaSmjestaja + new.CijenaOsiguranja + new.BoravisnaTaksa;


-- -------------------------------------------------------------------------------------------------
-- POGLEDI
-- -------------------------------------------------------------------------------------------------

CREATE OR REPLACE VIEW ponude_detaljno AS
	SELECT p.Id as IdPonude,
    p.Naziv,
    p.DatumKreiranja,
    z.Id as IdKomercijaliste,
    z.Ime,
    z.Prezime,
    c.Id as IdCijene,
    c.Ukupno,
    count(r.Ponuda) as Rezervacije, 
    broj_karata(p.Id) as Karte
FROM ((ponuda p inner join zaposleni z on p.Komercijalista=z.Id)
	left outer join cijena c on p.Cijena=c.Id)
    left outer join rezervacija r on p.Id=r.Ponuda
group by p.Id;
    
    
CREATE OR REPLACE VIEW izlet_detaljno AS 
SELECT i.IdPonude,
	   p.Naziv,
       i.Datum,
       i.VrijemePolaska,
       i.VrijemePovratka,
       p.Komercijalista,
       p.DatumKreiranja,
       c.Id,
       c.TroskoviPrevoza,
       c.CijenaOsiguranja,
       c.BoravisnaTaksa,
       c.Ukupno
FROM (izlet i inner join ponuda p on i.IdPonude=p.Id)
	 inner join cijena c on p.Cijena=c.Id;

CREATE OR REPLACE VIEW putovanja_detaljno AS
SELECT t.IdPonude,
	   p.Naziv,
       t.Polazak,
       t.Povratak,
       p.Komercijalista,
       p.DatumKreiranja,
       c.Id,
       c.TroskoviPrevoza,
       c.CijenaSmjestaja,
       c.CijenaOsiguranja,
       c.BoravisnaTaksa,
       c.Ukupno
FROM (putovanje t inner join ponuda p on t.IdPonude=p.Id)
	 inner join cijena c on p.Cijena=c.Id;
	
CREATE OR REPLACE VIEW rezervacije_detaljno AS 
SELECT r.DatumRezervisanja,
       r.Poslovodja,
       p.Id as IdPutnika,
       p.Ime,
       p.Prezime,
       p.JMB,
       d.Id as IdPonude,
	   d.Naziv
FROM (rezervacija r inner join putnik p on r.Putnik=p.Id)
	 inner join ponuda d on r.Ponuda=d.Id;
     
-- -------------------------------------------------------------------------------------------------
-- KORISNICKI NALOG
-- -------------------------------------------------------------------------------------------------

create user 'tatjana'@'localhost' identified by 'lozinka';
grant select, insert, update, delete on turisticka_agencija.* to 'tatjana'@'localhost';
grant select, insert, update, delete on turisticka_agencija.ponude_detaljno to 'tatjana'@'localhost';
grant select, insert, update, delete on turisticka_agencija.putovanja_detaljno to 'tatjana'@'localhost';
grant select, insert, update, delete on turisticka_agencija.izlet_detaljno to 'tatjana'@'localhost';
grant select, insert, update, delete on turisticka_agencija.rezervacije_detaljno to 'tatjana'@'localhost';
grant execute on procedure turisticka_agencija.obrisi_izlet to 'tatjana'@'localhost';
grant execute on procedure turisticka_agencija.obrisi_putovanje to 'tatjana'@'localhost';
grant execute on procedure turisticka_agencija.vrsta_naloga to 'tatjana'@'localhost';
flush privileges;

-- -------------------------------------------------------------------------------------------------
-- TESTN PODACI
-- -------------------------------------------------------------------------------------------------

insert into mjesto values (null, "Prijedor", 79101, "Bosna i Hercegovina");
insert into mjesto values (null, "Banjaluka", 78101, "Bosna i Hercegovina");
insert into mjesto values (null, "Bijeljina", 76300, "Bosna i Hercegovina");
insert into mjesto values (null, "Trebinje", 89101, "Bosna i Hercegovina");

insert into adresa values (null, "Vuka Karadzica", 140, 1);
insert into adresa values (null, "Stepe Stepanovica", 220, 2);
insert into adresa values (null, "Neznanih junaka", 170, 3);
insert into adresa values (null, "Svetosavska", 250, 4);
insert into adresa values (null, "Nikole Pasica", 150, 1);
insert into adresa values (null, "Cara Lazara", 17, 1);
insert into adresa values (null, "Ive Andrica", 180, 2);
insert into adresa values (null, "Zivojina Misica", 265, 2);

insert into poslovnica values (null, "Agencija Prijedor", "1111111110000", "prijedor@agencija.com", 1, null);
insert into poslovnica values (null, "Agencija Banja Luka", "2222222220000", "banjaluka@agencija.com", 2, null);
insert into poslovnica values (null, "Agencija Bijeljina", "3333333330000", "bijeljina@agencija.com", 3, null);
insert into poslovnica values (null, "Agencija Trebinje", "4444444440000", "trebinje@agencija.com", 4, null);
update poslovnica set Sjediste=2 where Id=1; -- dodajem da je sjedište poslovnice Prijedor u Banjaluci

insert into zaposleni values (null, "Tatjana", "Tomic", "2411987111111", "magistar menadzmenta", 1150.00, 1, 5);
insert into zaposleni values (null, "Marko", "Markovic", "0101990222222", "dipl. ekonomista za turizam", 1000.00, 1, 6);
insert into zaposleni values (null, "Petar", "Petrovic", "0202980555555", "magistar menadzmenta", 1150.00, 2, 7);
insert into zaposleni values (null, "Ivana", "Ivanovic", "0709991666666", "dipl. ekonomista za turizam", 1000.00, 2, 7);

insert into nalog values (null, "tatjana", "tatjana", 1);
insert into nalog values (null, "marko", "marko", 2);
insert into nalog values (null, "petar", "petar", 3);
insert into nalog values (null, "ivana", "ivana", 4);

insert into poslovodja values (1);
insert into poslovodja values (3);

insert into komercijalista values (2);
insert into komercijalista values (4);


insert into cijena values (null, 25, 0, 0, 0, null);
insert into cijena values (null, 15, 0, 0, 0, 15);
insert into ulaznica values (2, "Vodopad Jajce", 5);
insert into cijena values (null, 30, 0, 0, 10, 40);
insert into cijena values (null, 400, 0, 0, 0, 400);
insert into cijena values (null, 200, 0, 0, 0, 200);

insert into ponuda values (null, "Obilazak Trebinja", 4, 1, "2021-01-01 8:15:10");
insert into ponuda values (null, "Posjeta Jajcu", 4, 2, "2021-01-01 8:20:10");
insert into ponuda values (null, "Shopping u Gracu", 2, 3, "2021-01-01 10:15:11");
insert into ponuda values (null, "Ljetovanje u Grckoj", 2, 4, "2021-01-01 12:07:17");
insert into ponuda values (null, "Osmi mart u Parizu", 4, 5, "2021-01-01 14:36:11");

insert into mjesto values (null, "Jajce", 70101, "Bosna i Hercegovina");
insert into mjesto values (null, "Grac", 8010, "Austrija");

insert into izlet values (1, "2021-01-20", "06:00:00", "18:00:00");
insert into izlet values (2, "2021-01-25", "08:00:00", "16:00:00");
insert into izlet values (3, "2021-02-20", "04:00:00", "19:00:00");

insert into putovanje values (4, "2021-07-20 05:00:00", "2021-07-27 16:00:00");
insert into putovanje values (5, "2021-03-05 04:00:00", "2021-03-09 18:00:00");

insert into putnik values (null, "Marko", "Markovic", "1111111111111", "111111111", "11111111");
insert into putnik values (null, "Petar", "Petrovic", "2222222222222", "222222222", "22222222");
insert into putnik values (null, "Ivan", "Ivanovic", "3333333333333", "333333333", "33333333");
insert into putnik values (null, "Jovana", "Jovanic", "4444444444444", "444444444", "44444444");
insert into putnik values (null, "Bojana", "Bojanic", "5555555555555", "555555555", "55555555");
insert into putnik values (null, "Jovan", "Jovanic", "6666666666666", "666666666", "66666666");

insert into rezervacija values ("2021-1-6 10:25:00", 3, 1, 1);
insert into rezervacija values ("2021-1-6 10:25:00", 3, 3, 1);
insert into rezervacija values ("2021-1-6 10:25:00", 3, 5, 2);
insert into rezervacija values ("2021-1-6 10:25:00", 1, 6, 2);
insert into rezervacija values ("2021-1-6 10:25:00", 1, 5, 4);
insert into rezervacija values ("2021-1-6 10:25:00", 1, 6, 4);
insert into rezervacija values (sysdate(), 1, 2, 1);
insert into rezervacija values (sysdate(), 1, 4, 1);
insert into rezervacija values (sysdate(), 1, 1, 4);
insert into rezervacija values (sysdate(), 1, 2, 4);
insert into rezervacija values (sysdate(), 1, 3, 4);
insert into rezervacija values (sysdate(), 1, 4, 4);

insert into karta values (null, sysdate(), 1, 1, 1, 1);
insert into karta values (null, sysdate(), 1, 2, 1, 2);
insert into karta values (null, sysdate(), 1, 3, 1, 3);
insert into karta values (null, sysdate(), 1, 4, 1, 4);
insert into karta values (null, sysdate(), 4, 1, 1, 1);
insert into karta values (null, sysdate(), 4, 2, 1, 2);
insert into karta values (null, sysdate(), 4, 3, 1, 3);
insert into karta values (null, sysdate(), 4, 4, 1, 4);

insert into autobus values ("111111111", "Mercedes-Benz", "O405", 56);
insert into autobus values ("222222222", "Mercedes-Benz", "O405GT", 65);
insert into autobus values ("333333333", "Mercedes-Benz", "O405", 56);
insert into autobus values ("444444444", "VDL", "FMD2-129", 60);
insert into autobus values ("555555555", "VDL", "FDD2-144", 36);
insert into autobus values ("666666666", "VDL", "FDD2-144", 36);
