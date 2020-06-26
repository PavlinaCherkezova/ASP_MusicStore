CREATE DATABASE MUSIC_STORE;
USE MUSIC_STORE;
CREATE TABLE CD(
CD_ID int UNIQUE NOT NULL,
album_name varchar(200) NOT NULL,
number_songs int, 
artist_name varchar(400) NOT NULL,
autograph bit,
label_name varchar(400),
release_date date,
price float NOT NULL,
cover_image varchar (400)
);

CREATE TABLE DVD(
DVD_ID int UNIQUE NOT NULL,
album_name varchar(200)NOT NULL,
number_songs int, 
artist_name varchar(400)NOT NULL,
autograph bit,
label_name varchar(400),
release_date date,
price float NOT NULL,
cover_image varchar (400)
);

CREATE TABLE Vinyl(
VINYL_ID int UNIQUE NOT NULL,
album_name varchar(200)NOT NULL,
number_songs int, 
artist_name varchar(400)NOT NULL,
autograph bit,
label_name varchar(400),
release_date date,
price float NOT NULL,
cover_image varchar (400)
);

CREATE TABLE DeluxeEdition(
DELUX_ID int UNIQUE NOT NULL,
album_name varchar(200) NOT NULL,
number_albums int,
number_songs int, 
artist_name varchar(400) NOT NULL,
autograph bit,
label_name varchar(400),
release_date date,
price float NOT NULL,
cover_image varchar (400)
);

CREATE TABLE T_shirt(
T_SHIRT_ID int UNIQUE NOT NULL,
artist_name varchar(400) NOT NULL,
color varchar(100),
size int NOT NULL,
autograph bit,
price float NOT NULL,
t_shirt_image varchar (400)
);

alter table CD add primary key (CD_ID);
alter table DVD add primary key (DVD_ID);
alter table Vinyl add primary key (VINYL_ID);
alter table DeluxeEdition add primary key (DELUX_ID);
alter table T_shirt add primary key (T_SHIRT_ID);