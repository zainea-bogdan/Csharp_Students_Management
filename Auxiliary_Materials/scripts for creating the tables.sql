create schema if not exists Csharp_Students_Management;
create table if not exists Csharp_Students_Management.cities
(
	id_city int PRIMARY KEY,
	city_name varchar(25)
);

create table if not exists Csharp_Students_Management.roles
(
	id_role int PRIMARY KEY,
	role_name varchar(25)
);

create table if not exists Csharp_Students_Management.secretary
(
	id_secretary int GENERATED ALWAYS AS IDENTITY,
	email varchar(100),
	password varchar(50),
	identity_key_1 int,
	identity_key_2 int
);

CREATE TABLE IF NOT EXISTS Csharp_Students_Management.users
(
    id_user INT GENERATED ALWAYS AS IDENTITY,
    id_role INT,
    name VARCHAR(255),
    surname VARCHAR(255),
    age INT,
    email VARCHAR(100),
    password VARCHAR(50),
    phone VARCHAR(10),
    id_city int,
    address VARCHAR(255),
    birthdate VARCHAR(25),

    CONSTRAINT fk_city
        FOREIGN KEY (id_city)
        REFERENCES Csharp_Students_Management.cities (id_city)
        ON DELETE CASCADE,

    CONSTRAINT fk_role
        FOREIGN KEY (id_role)
        REFERENCES Csharp_Students_Management.roles (id_role)
        ON DELETE CASCADE
);
