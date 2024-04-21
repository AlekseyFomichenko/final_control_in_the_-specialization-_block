create database human_friends;
use human_friends;

create table pets(
id int auto_increment primary key,
nickname varchar(30) not null,
kind varchar(45) not null,
birthday date,
commands varchar(45)
);

create table pack_animals(
id int auto_increment primary key,
nickname varchar(30) not null,
kind varchar(45) not null,
birthday date,
commands varchar(255)
);

insert into pets(nickname, kind, birthday, commands)
values
("Fido", "Dog", STR_TO_DATE('2020.01.01', '%Y.%m.%d'), "Sit, Stay, Fetch"),

("Whiskers", "Cat", STR_TO_DATE('2019.05.15', '%Y.%m.%d'), "Sit, Pounce"),

("Hammy", "Hamster", STR_TO_DATE('2021.03.10', '%Y.%m.%d'), "Roll, Hide"),

("Buddy", "Dog",STR_TO_DATE('2018.12.10', '%Y.%m.%d') , "Sit, Paw, Bark"),

("Smudge", "Cat", STR_TO_DATE('2020.02.20', '%Y.%m.%d'), "Sit, Pounce, Scratch"),

("Peanut", "Hamster",STR_TO_DATE('2021.08.01', '%Y.%m.%d') , "Roll, Spin"),

("Bella", "Dog", STR_TO_DATE('2019.11.11', '%Y.%m.%d'), "Sit, Stay, Roll"),

("Oliver", "Cat", STR_TO_DATE('2020.06.30', '%Y.%m.%d'), "Meow, Scratch, Jump");

insert into pack_animals(nickname, kind, birthday, commands)
values
("Thunder", "Horse", STR_TO_DATE('2015.07.21', '%Y.%m.%d'), "Trot, Canter, Gallop"),

("Sandy", "Camel", STR_TO_DATE('2016.11.03', '%Y.%m.%d'), "Walk, Carry Load"),

("Eeyore", "Donkey", STR_TO_DATE('2017.09.18', '%Y.%m.%d'), "Walk, Carry Load, Bray"),

("Storm", "Horse", STR_TO_DATE('2014.05.05', '%Y.%m.%d'), "Trot, Canter"),

("Dune", "Camel", STR_TO_DATE('2018.12.12', '%Y.%m.%d'), "Walk, Sit"),

("Burro", "Donkey", STR_TO_DATE('2019.01.23', '%Y.%m.%d'), "Walk, Bray, Kick"),

("Blaze", "Horse", STR_TO_DATE('2016.02.29', '%Y.%m.%d'), "Trot, Jump, Gallop"),

("Sahara", "Camel", STR_TO_DATE('2015.08.14', '%Y.%m.%d'), "Walk, Run");


delete from pack_animals WHERE kind = 'Camel' and id > 0;

create table all_animals as
select * from pets;

insert into all_animals
select * from pack_animals;

delete from all_animals
where timestampdiff(year, birthday, curdate()) > 3;

select *,
timestampdiff(month, birthday, curdate()) as age_in_months
from all_animals;

CREATE TABLE final_table AS
SELECT 
    *, 'pets' AS table_name
FROM
    pets 
UNION ALL SELECT 
    *, 'pack_animals' AS table_name
FROM
    pack_animals 
UNION ALL SELECT 
    *, 'all_animals' AS table_name
FROM
    all_animals;
