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