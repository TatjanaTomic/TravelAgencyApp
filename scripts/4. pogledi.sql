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