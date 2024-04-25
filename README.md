# Описание выполенения всех пунктов

## Итоговая контрольная работа

 ### Информация о проекте
 Необходимо организовать систему учета для питомника в котором живут домашние и Pack animals. 

### Как сдавать проект 

Для сдачи проекта необходимо создать отдельный общедоступный репозиторий(Github, gitlub, или Bitbucket). Разработку вести в этом репозитории, использовать пул реквесты на изменения. Программа должна запускаться и работать, ошибок при выполнении программы быть не должно. Программа, может использоваться в различных системах, поэтому необходимо разработать класс в виде конструктора 

## Задание 

### Операционные системы и виртуализация (Linux)

1. Использование команды cat в Linux
   - Создать два текстовых файла: "Pets"(Домашние животные) и "Pack animals"(вьючные животные), используя команду `cat` в терминале Linux. В первом файле перечислить собак, кошек и хомяков. Во втором — лошадей, верблюдов и ослов.
   - Объединить содержимое этих двух файлов в один и просмотреть его содержимое.
   - Переименовать получившийся файл в "Human Friends"(.
Пример конечного вывода после команды “ls” :
Desktop Documents Downloads  HumanFriends.txt  Music  PackAnimals.txt  Pets.txt  Pictures  Videos

2. Работа с директориями в Linux
   - Создать новую директорию и переместить туда файл "Human Friends".
```
   88  cat Pets.txt Pack_Animals.txt
   89  cat >> Pets.txt
   90  cat >> Pack_Animals.txt
   91  cat Pets.txt 
   92  cat Pets.txt Pack_Animals.txt > Human_Friends.txt
   93  mkdir newFolder && mv Human_Friends.txt newFolder
```
3. Работа с MySQL в Linux. “Установить MySQL на вашу вычислительную машину ”
   - Подключить дополнительный репозиторий MySQL и установить один из пакетов из этого репозитория.
```
   97  sudo apt remove mysql
   98  sudo apt install mysql
   99  sudo apt install mysql-community-server
  100  mysql --version
  101  systemctl status mysql
```
4. Управление deb-пакетами
   - Установить и затем удалить deb-пакет, используя команду `dpkg`.
```
   56  sudo dpkg -i mysql-workbench-community-dbgsym_8.0.36-1ubuntu22.04_amd64.deb 
   57  sudo apt install mysql-client
   58  apt --fix-broken install
   59  sudo apt --fix-broken install
   60  sudo apt install mysql-client
   61  sudo dpkg -i mysql-workbench-community-dbgsym_8.0.36-1ubuntu22.04_amd64.deb 
   62  sudo apt --fix-broken install
   63  mysql --version
   64  ll
   65  sudo dpkg -i mysql-workbench-community_8.0.34-1ubuntu22.04_amd64.deb
   66  ll
   67  sudo dpkg -i mysql-workbench-community_8.0.36-1ubuntu22.04_amd64.deb.asc
   68  sudo apt --fix-broken install
```
![список установленных пакетов](https://github.com/AlekseyFomichenko/final_control_in_the_-specialization-_block/assets/128860587/eba82d68-32e8-48c1-9f88-9e1f35a45698)

*Далее я начал их удалять*
```
  104  sudo apt purge mysql-community-server
  105  sudo apt purge mysql
  106  dpkg --list
  107  cd /home/alekseytest/Загрузки/
  108  ll
  109  sudo dpkg -p mysql-community-server-core-dbgsym_8.3.0-1ubuntu22.04_amd64.deb
  110  dpkg-query -l
  111  nano file.txt
  112  sudo dpkg -p file.txt
  113  nano file.txt
  114  sudo dpkg -p mysql-apt-config
  115  mysql-client
  116  mysql-common
  117  mysql-community-client
  118  mysql-community-client-core
  119  mysql-community-client-plugins
  120  mysql-community-server-core
  121  mysql-workbench-community
  122  mysql-workbench-community-dbgsym
```
*Два пакета не удалились из-за ошибки с зависимостями*
![проблемы с зависимостями](https://github.com/AlekseyFomichenko/final_control_in_the_-specialization-_block/assets/128860587/896c69e0-4adc-4bbc-88c7-b47848df6407)

*Применил команды для обновления и исправления, и для удаления ненужных*
![обновил и удалил оставшиеся](https://github.com/AlekseyFomichenko/final_control_in_the_-specialization-_block/assets/128860587/f1bbca3b-9be5-42f0-a452-0ee9a2cffdd6)

*И вот результат, все пакеты удалены*
![список после удаления](https://github.com/AlekseyFomichenko/final_control_in_the_-specialization-_block/assets/128860587/9d5cf364-ce0d-417d-a31d-8a5d6b602f0a)


5. История команд в терминале Ubuntu
   - Сохранить и выложить историю ваших терминальных команд в Ubuntu.
В формате: Файла с ФИО, датой сдачи, номером группы(или потока)

Объектно-ориентированное программирование 

6. Диаграмма классов
   - Создать диаграмму классов с родительским классом "Животные", и двумя подклассами: "Pets" и "Pack animals".
В составы классов которых в случае Pets войдут классы: собаки, кошки, хомяки, а в класс Pack animals войдут: Лошади, верблюды и ослы).
Каждый тип животных будет характеризоваться (например, имена, даты рождения, выполняемые команды и т.д)
Диаграмму можно нарисовать в любом редакторе, такими как Lucidchart, Draw.io, Microsoft Visio и других.

*Диаграмма нарисована в файле ClassDiagram1.cd*

7. Работа с MySQL (Задача выполняется в случае успешного выполнения задачи “Работа с MySQL в Linux. “Установить MySQL на вашу машину”

7.1. После создания диаграммы классов в 6 пункте, в 7 пункте база данных "Human Friends" должна быть структурирована в соответствии с этой диаграммой. Например, можно создать таблицы, которые будут соответствовать классам "Pets" и "Pack animals", и в этих таблицах будут поля, которые характеризуют каждый тип животных (например, имена, даты рождения, выполняемые команды и т.д.). 
7.2   - В ранее подключенном MySQL создать базу данных с названием "Human Friends".
   - Создать таблицы, соответствующие иерархии из вашей диаграммы классов.
   ```
CREATE DATABASE human_friends;
USE human_friends;

CREATE TABLE pets (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nickname VARCHAR(30) NOT NULL,
    kind VARCHAR(45) NOT NULL,
    birthday DATE,
    commands VARCHAR(45)
);

CREATE TABLE pack_animals (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nickname VARCHAR(30) NOT NULL,
    kind VARCHAR(45) NOT NULL,
    birthday DATE,
    commands VARCHAR(255)
);
```
   - Заполнить таблицы данными о животных, их командах и датами рождения.
```
INSERT INTO pets(nickname, kind, birthday, commands)
VALUES
("Fido", "Dog", STR_TO_DATE('2020.01.01', '%Y.%m.%d'), "Sit, Stay, Fetch"),

("Whiskers", "Cat", STR_TO_DATE('2019.05.15', '%Y.%m.%d'), "Sit, Pounce"),

("Hammy", "Hamster", STR_TO_DATE('2021.03.10', '%Y.%m.%d'), "Roll, Hide"),

("Buddy", "Dog",STR_TO_DATE('2018.12.10', '%Y.%m.%d') , "Sit, Paw, Bark"),

("Smudge", "Cat", STR_TO_DATE('2020.02.20', '%Y.%m.%d'), "Sit, Pounce, Scratch"),

("Peanut", "Hamster",STR_TO_DATE('2021.08.01', '%Y.%m.%d') , "Roll, Spin"),

("Bella", "Dog", STR_TO_DATE('2019.11.11', '%Y.%m.%d'), "Sit, Stay, Roll"),

("Oliver", "Cat", STR_TO_DATE('2020.06.30', '%Y.%m.%d'), "Meow, Scratch, Jump");

INSERT INTO pack_animals(nickname, kind, birthday, commands)
VALUES
("Thunder", "Horse", STR_TO_DATE('2015.07.21', '%Y.%m.%d'), "Trot, Canter, Gallop"),

("Sandy", "Camel", STR_TO_DATE('2016.11.03', '%Y.%m.%d'), "Walk, Carry Load"),

("Eeyore", "Donkey", STR_TO_DATE('2017.09.18', '%Y.%m.%d'), "Walk, Carry Load, Bray"),

("Storm", "Horse", STR_TO_DATE('2014.05.05', '%Y.%m.%d'), "Trot, Canter"),

("Dune", "Camel", STR_TO_DATE('2018.12.12', '%Y.%m.%d'), "Walk, Sit"),

("Burro", "Donkey", STR_TO_DATE('2019.01.23', '%Y.%m.%d'), "Walk, Bray, Kick"),

("Blaze", "Horse", STR_TO_DATE('2016.02.29', '%Y.%m.%d'), "Trot, Jump, Gallop"),

("Sahara", "Camel", STR_TO_DATE('2015.08.14', '%Y.%m.%d'), "Walk, Run");
```
   - Удалить записи о верблюдах и объединить таблицы лошадей и ослов.
```
DELETE FROM pack_animals WHERE kind = 'Camel' AND id > 0;

CREATE TABLE all_animals AS
SELECT * FROM pets;

INSERT INTO all_animals
SELECT * FROM pack_animals;
```
   - Создать новую таблицу для животных в возрасте от 1 до 3 лет и вычислить их возраст с точностью до месяца.
```
DELETE FROM all_animals 
WHERE TIMESTAMPDIFF(YEAR, birthday, CURDATE()) > 3;

SELECT *,
TIMESTAMPDIFF(MONTH,birthday,CURDATE()) AS age_in_months
FROM all_animals;
```
   - Объединить все созданные таблицы в одну, сохраняя информацию о принадлежности к исходным таблицам.
```
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
```
Пример заполненной таблицы для теста:
Лист "Pets"
ID
Name
Type
BirthDate
Commands
1
Fido
Dog
2020-01-01
Sit, Stay, Fetch
2
Whiskers
Cat
2019-05-15
Sit, Pounce
3
Hammy
Hamster
2021-03-10
Roll, Hide
4
Buddy
Dog
2018-12-10
Sit, Paw, Bark
5
Smudge
Cat
2020-02-20
Sit, Pounce, Scratch
6
Peanut
Hamster
2021-08-01
Roll, Spin
7
Bella
Dog
2019-11-11
Sit, Stay, Roll
8
Oliver
Cat
2020-06-30
Meow, Scratch, Jump

 Лист "PackAnimals"
ID
Name
Type
BirthDate
Commands
1
Thunder
Horse
2015-07-21
Trot, Canter, Gallop
2
Sandy
Camel
2016-11-03
Walk, Carry Load
3
Eeyore
Donkey
2017-09-18
Walk, Carry Load, Bray
4
Storm
Horse
2014-05-05
Trot, Canter
5
Dune
Camel
2018-12-12
Walk, Sit
6
Burro
Donkey
2019-01-23
Walk, Bray, Kick
7
Blaze
Horse
2016-02-29
Trot, Jump, Gallop
8
Sahara
Camel
2015-08-14
Walk, Run




8. ООП и Java
   - Создать иерархию классов в Java, который будет повторять диаграмму классов созданную в задаче 6(Диаграмма классов) .

9. Программа-реестр домашних животных
    - Написать программу на Java, которая будет имитировать реестр домашних животных. 
Должен быть реализован следующий функционал:
    
    9.1. Добавление нового животного
        - Реализовать функциональность для добавления новых животных в реестр.       
 Животное должно определяться в правильный класс (например, "собака", "кошка", "хомяк" и т.д.)
        
 
   9.2. Список команд животного
        - Вывести список команд, которые может выполнять добавленное животное (например, "сидеть", "лежать").
        
    9.3. Обучение новым командам
        - Добавить возможность обучать животных новым командам.
  9.4 Вывести список животных по дате рождения

9.5. Навигация по меню
        - Реализовать консольный пользовательский интерфейс с меню для навигации между вышеуказанными функциями.
        
10. Счетчик животных
Создать механизм, который позволяет вывести на экран общее количество созданных животных любого типа (Как домашних, так и вьючных), то есть при создании каждого нового животного счетчик увеличивается на “1”. 
  




