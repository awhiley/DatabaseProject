drop database if exists PasswordManager;

 create database PasswordManager;
use PasswordManager;
create table SECRET (SECRET_ID int not null auto_increment, secretPrompt varchar(100), secretAnswer varchar(100), primary key (SECRET_ID) );

 create table USER ( U_ID int not null auto_increment , SECRET_ID int not null, U_USERNAME varchar(50) not null, U_PASSWORD varchar(50) not null, U_EMAIL varchar(50) not null, PRIMARY KEY (U_ID) );

create table LOGIN_INFO (L_ID int not null auto_increment, U_ID int not null, WEB_ID int not null, L_EMAIL varchar(50), L_PASSWORD varchar(50) not null, L_PHONE varchar(50), L_USERNAME varchar(50), PRIMARY KEY (L_ID));

create table WEB_INFO ( WEB_ID int not null auto_increment, WebDomain varchar(100) not null, WebName varchar(50) not null, primary key (Web_ID) );

            