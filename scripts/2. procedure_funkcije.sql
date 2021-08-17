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