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
