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
