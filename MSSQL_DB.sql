CREATE DATABASE doors

GO
USE doors
GO

CREATE TABLE Workers --ТАБЛИЦА ПЕРСОНАЛА
(
--ДОБАВИТЬ ПЕРВИЧНЫЙ КЛЮЧ WORKER_ID
WORKER_ID              SMALLINT         IDENTITY    PRIMARY KEY, --ПЕРВИЧНЫЙ КЛЮЧ УНИКАЛЬНОГО НОМЕРА РАБОТНИКА
WORKER_SURNAME         VARCHAR(50)      NOT NULL, --ФАМИЛИЯ РАБОТНИКА
WORKER_NAME            VARCHAR(50)      NOT NULL, --ИМЯ РАБОТНИКА
WORKER_PATRONOMIC      VARCHAR(50)      NOT NULL, --ОТЧЕСТВО РАБОТНИКА
WORKER_IIN             BIGINT           NOT NULL, --ИИН НОМЕР РАБОТНИКА
WORKER_SEX             VARCHAR(15)      NOT NULL, --ПОЛ РАБОТНИКА
WORKER_PHONE           BIGINT           NOT NULL, --ТЕЛЕФОННЫЙ НОМЕР
WORKER_EMAIL           VARCHAR(50)              , --ПОЧТОВЫЙ АДРЕС
WORKER_WORKTIME        INT              NOT NULL, --ЧАСЫ РАБОТЫ
WORKER_ADDRESS         VARCHAR(50)      NOT NULL, --ДОМАШНИЙ АДРЕС
WORKER_COME            DATE             NOT NULL, --ДАТА ПРИХОДА
WORKER_OUTCOME         DATE                     , --ДАТА УВОЛЬНЕНИЯ
WORKER_LICENSE         BIT                      , --ВОДИТЕЛЬСКИЕ ПРАВА
WORKER_EXPERIENCE      INT                      , --ОПЫТ РАБОТЫ
ROWVRSN                ROWVERSION
);

CREATE TABLE Customers --ТАБЛИЦА КЛИЕНТОВ
(
--ДОБАВИТЬ ПЕРВИЧНЫЙ КЛЮЧ CUSTOMER_ID
CUSTOMER_ID            SMALLINT         IDENTITY    PRIMARY KEY, --ПЕРВИЧНЫЙ КЛЮЧ УНИКАЛЬНОГО НОМЕРА КЛИЕНТА
CUSTOMER_SURNAME       VARCHAR(50)      NOT NULL, --ФАМИЛИЯ КЛИЕНТА
CUSTOMER_NAME          VARCHAR(50)      NOT NULL, --ИМЯ КЛИЕНТА
CUSTOMER_PATRONOMIC    VARCHAR(50)      NOT NULL, --ОТЧЕСТВО КЛИЕНТА
CUSTOMER_PHONE         BIGINT           NOT NULL, --НОМЕР ТЕЛЕФОНА КЛИЕНТА
CUSTOMER_EMAIL         VARCHAR(50)              , --ПОЧТОВЫЙ АДРЕС КЛИЕНТА
CUSTOMER_ADDRESS       VARCHAR(50)      NOT NULL, --АДРЕС КЛИЕНТА
CUSTOMER_HOME          VARCHAR(50)      NOT NULL, --ДОМ КЛИЕНТА
CUSTOMER_ENTRANCE      VARCHAR(10)              , --ПОДЪЕЗД
CUSTOMER_FLAT          SMALLINT                 , --КВАРТИРА
ROWVRSN                ROWVERSION
);

CREATE TABLE Products --ТАБЛИЦА ТОВАРОВ
(
--ДОБАВИТЬ ПЕРВИЧНЫЙ КЛЮЧ PRODUCT_ID
PRODUCT_ID             SMALLINT         IDENTITY    PRIMARY KEY, --ПЕРВИЧНЫЙ КЛЮЧ УНИКАЛЬНОГО НОМЕРА ТОВАРА
PRODUCT_NAME           VARCHAR(50)      NOT NULL, --НАИМЕНОВАНИЕ ТОВАРА
PRODUCT_WEIGHT         DECIMAL          NOT NULL, --ВЕС ТОВАРА
PRODUCT_MANUFAC        VARCHAR(50)      NOT NULL, --ПРОИЗОДИТЕЛЬ
PRODUCT_PROVIDER       VARCHAR(50)      NOT NULL, --ПОСТАВЩИК
PRODUCT_AVAILABLE      NVARCHAR(50)     NOT NULL, --НАЛИЧИЕ ТОВАРА
PRODUCT_QUANTITY       INT              NOT NULL, --КОЛИЧЕСТВО ТОВАРА
PRODUCT_PRICE          INT              NOT NULL, --ЦЕНА ТОВАРА
PRODUCT_TYPE           VARCHAR(50)      NOT NULL, --ТИП ТОВАРА (ДЕРЕВО/МЕТАЛЛ/СТЕКЛО)
FK_FRONTDOOR           SMALLINT                 , --АТРИБУТ СВЯЗЫВАЮЩИЙ ТАБЛИЦУ ТОВАРА С НСИ ТАБЛИЦЕЙ (ВХОДНАЯ ДВЕРЬ)
FK_INTERIORDOOR        SMALLINT                 , --АТРИБУТ СВЯЗЫВАЮЩИЙ ТАБЛИЦУ ТОВАРА С НСИ ТАБЛИЦЕЙ (МЕЖКОМНАТНАЯ ДВЕРЬ)
ROWVRSN                ROWVERSION
);

CREATE TABLE Journal --ТАБЛИЦА РЕЕСТРА ПРОДАННЫХ ТОВАРОВ
(
--ДОБАВИТЬ ПЕРВИЧНЫЙ КЛЮЧ ORDER_CODE
ORDER_CODE             SMALLINT         IDENTITY    PRIMARY KEY, --ПЕРВИЧНЫЙ КЛЮЧ НОМЕРА ЗАКАЗА
FK_CUSTOMER            SMALLINT         NOT NULL, --ВТОРИЧНЫЙ КЛЮЧ КЛИЕНТ
FK_PRODUCT             SMALLINT         NOT NULL, --ВТОРИЧНЫЙ КЛЮЧ ТОВАР
FK_WORKER              SMALLINT         NOT NULL, --ВТОРИЧНЫЙ КЛЮЧ РАБОТНИК
DATE_PLACEMENT         DATE             NOT NULL, --ДАТА РАЗМЕЩЕНИЯ ЗАКАЗА
DATE_EXECUTION         DATE             NOT NULL, --ДАТА ИСПОЛНЕНИЯ ЗАКАЗА
ROWVRSN                ROWVERSION
);

-----------------------------------------------------------------------------------------

CREATE TABLE users --СОЗДАНИЕ ТАБЛИЦЫ ДЛЯ АВТОРИЗАЦИИ 
(
ID                INT              IDENTITY(1,1)    PRIMARY KEY,
USERNAME          VARCHAR(50)      NOT NULL,
USERPASS          VARCHAR(50)      NOT NULL
);

INSERT INTO Users(USERNAME, USERPASS) VALUES ('tokhtar', '123456');

SELECT * FROM users

-----------------------------------------------------------------------------------------

--НСИ
CREATE TABLE Frontdoor --СОЗДАНИЕ ТАБЛИЦЫ ВХОДНАЯ ДВЕРЬ
(
FRONTDOOR_ID           SMALLINT         IDENTITY    PRIMARY KEY, --УНИКАЛЬНЫЙ НОМЕР ВХОДНОЙ ДВЕРИ
FRONTDOOR_TYPE         VARCHAR(50),
ROWVRSN                ROWVERSION
);

CREATE TABLE Interiordoor --СОЗДАНИЕ ТАБЛИЦЫ МЕЖКОМНАТНАЯ ДВЕРЬ
(
INTERIORDOOR_ID        SMALLINT         IDENTITY    PRIMARY KEY, --УНИКАЛЬНЫЙ НОМЕР МЕЖКОМНАТНОЙ ДВЕРИ
INTERIORDOOR_TYPE      VARCHAR(50),
ROWVRSN                ROWVERSION
);

-----------------------------------------------------------------------------------------

ALTER TABLE Journal
add FOREIGN KEY (FK_CUSTOMER) REFERENCES Customers(CUSTOMER_ID);

ALTER TABLE Journal
add FOREIGN KEY (FK_PRODUCT) REFERENCES Products(PRODUCT_ID);

ALTER TABLE Journal
add FOREIGN KEY (FK_WORKER) REFERENCES Workers(WORKER_ID);

ALTER TABLE Products
add FOREIGN KEY (FK_FRONTDOOR) REFERENCES Frontdoor(FRONTDOOR_ID); 

ALTER TABLE Products
add FOREIGN KEY (FK_INTERIORDOOR) REFERENCES Interiordoor(INTERIORDOOR_ID);

-----------------------------------------------------------------------------------------
--ЗАПИСЬ НЕКОТОРЫХ ДАННЫХ В ТАБЛИЦУ

DECLARE @work1 TINYINT, @work2 TINYINT, @work3 TINYINT
--1
INSERT INTO Workers(WORKER_SURNAME, WORKER_NAME, WORKER_PATRONOMIC, WORKER_IIN, WORKER_SEX, WORKER_PHONE, WORKER_EMAIL,
                    WORKER_WORKTIME, WORKER_ADDRESS, WORKER_COME, WORKER_OUTCOME, WORKER_LICENSE, WORKER_EXPERIENCE)
VALUES('Clark', 'John', 'Clarkovich', 020635445225, 'Male', 87075462563, 'clark@gmail.com', 8, 'Sarokov St.5', '2012-05-16', '2022-01-01', 0, 10)
SELECT @work1 = @@IDENTITY
--2
INSERT INTO Workers(WORKER_SURNAME, WORKER_NAME, WORKER_PATRONOMIC, WORKER_IIN, WORKER_SEX, WORKER_PHONE, WORKER_EMAIL,
                    WORKER_WORKTIME, WORKER_ADDRESS, WORKER_COME, WORKER_OUTCOME, WORKER_LICENSE, WORKER_EXPERIENCE)
VALUES('Malinin', 'Yevdokim', 'Yurievich', 020614523652, 'Male', 87074156235, 'malinin@gmail.com', 8, 'Malinina St.6', '2011-05-16', '', 1, 11)
SELECT @work2 = @@IDENTITY
--3
INSERT INTO Workers(WORKER_SURNAME, WORKER_NAME, WORKER_PATRONOMIC, WORKER_IIN, WORKER_SEX, WORKER_PHONE, WORKER_EMAIL,
                    WORKER_WORKTIME, WORKER_ADDRESS, WORKER_COME, WORKER_OUTCOME, WORKER_LICENSE, WORKER_EXPERIENCE)
VALUES('Kapriyanova', 'Fenya', 'Aleksandrovna', 020614788520, 'Female', 87775552552, 'fenya@gmail.com', 8, 'Almagul 5B', '2021-11-11', '', 1, 1)
SELECT @work3 = @@IDENTITY

SELECT * FROM Workers
--DELETE FROM Workers


DECLARE @front1 TINYINT, @front2 TINYINT, @front3 TINYINT
INSERT INTO Frontdoor(FRONTDOOR_TYPE) VALUES('Wood')
SELECT @front1 = @@IDENTITY

INSERT INTO Frontdoor(FRONTDOOR_TYPE) VALUES('Plastic')
SELECT @front2 = @@IDENTITY

INSERT INTO Frontdoor(FRONTDOOR_TYPE) VALUES('Metal')
SELECT @front3 = @@IDENTITY

DECLARE @interior1 TINYINT, @interior2 TINYINT, @interior3 TINYINT
INSERT INTO Interiordoor(INTERIORDOOR_TYPE) VALUES('Wood')
SELECT @interior1 = @@IDENTITY

INSERT INTO Interiordoor(INTERIORDOOR_TYPE) VALUES('Plastic')
SELECT @interior2 = @@IDENTITY

INSERT INTO Interiordoor(INTERIORDOOR_TYPE) VALUES('Metal')
SELECT @interior3 = @@IDENTITY


DECLARE @prod1 TINYINT, @prod2 TINYINT, @prod3 TINYINT, @prod4 TINYINT,	@prod5 TINYINT
--1
INSERT INTO Products(PRODUCT_NAME, PRODUCT_WEIGHT, PRODUCT_MANUFAC, PRODUCT_PROVIDER, PRODUCT_AVAILABLE, PRODUCT_QUANTITY, 
                     PRODUCT_PRICE, PRODUCT_TYPE, FK_FRONTDOOR, FK_INTERIORDOOR)
VALUES('Arfa', 10, 'Russia', 'Doors.ru', 'Yes', 3, 86000, 'Wood', @front1, @interior1)
SELECT @prod1 = @@IDENTITY
--2
INSERT INTO Products(PRODUCT_NAME, PRODUCT_WEIGHT, PRODUCT_MANUFAC, PRODUCT_PROVIDER, PRODUCT_AVAILABLE, PRODUCT_QUANTITY, 
                     PRODUCT_PRICE, PRODUCT_TYPE, FK_FRONTDOOR, FK_INTERIORDOOR)
VALUES('Beta', 11, 'Kazakhstan', 'Esik.kz', 'No', 0, 85000, 'Plastic', @front2, @interior2)
SELECT @prod2 = @@IDENTITY
--3
INSERT INTO Products(PRODUCT_NAME, PRODUCT_WEIGHT, PRODUCT_MANUFAC, PRODUCT_PROVIDER, PRODUCT_AVAILABLE, PRODUCT_QUANTITY, 
                     PRODUCT_PRICE, PRODUCT_TYPE, FK_FRONTDOOR, FK_INTERIORDOOR)
VALUES('Jorg', 16, 'China', 'Alibaba.com', 'Yes', 10, 105000, 'Metal', @front3, @interior3)
SELECT @prod3 = @@IDENTITY
--4
INSERT INTO Products(PRODUCT_NAME, PRODUCT_WEIGHT, PRODUCT_MANUFAC, PRODUCT_PROVIDER, PRODUCT_AVAILABLE, PRODUCT_QUANTITY, 
                     PRODUCT_PRICE, PRODUCT_TYPE, FK_FRONTDOOR, FK_INTERIORDOOR)
VALUES('Antares', 11, 'USA', 'Doppel.com', 'Yes', 4, 160000, 'Wood', @front1, @interior1)
SELECT @prod4 = @@IDENTITY
--5
INSERT INTO Products(PRODUCT_NAME, PRODUCT_WEIGHT, PRODUCT_MANUFAC, PRODUCT_PROVIDER, PRODUCT_AVAILABLE, PRODUCT_QUANTITY, 
                     PRODUCT_PRICE, PRODUCT_TYPE, FK_FRONTDOOR, FK_INTERIORDOOR)
VALUES('Napaleon', 10, 'Uzbekistan', 'Uzbek.com', 'No', 0, 70000, 'Plastic', @front2, @interior2)
SELECT @prod5 = @@IDENTITY

SELECT * FROM Products
--DELETE FROM Products


DECLARE @cust1 TINYINT, @cust2 TINYINT, @cust3 TINYINT

INSERT INTO Customers(CUSTOMER_SURNAME, CUSTOMER_NAME, CUSTOMER_PATRONOMIC, CUSTOMER_PHONE, CUSTOMER_EMAIL, CUSTOMER_ADDRESS, CUSTOMER_HOME, CUSTOMER_ENTRANCE, CUSTOMER_FLAT)
VALUES('Jokevich', 'Nadal', 'Nadalevich', 87054125632, 'nadal@john.nadal', 'Moskow St.6', '6B', '', '')
SELECT @cust1 = @@IDENTITY

SELECT * FROM Customers
--DELETE FROM Customers


--DECLARE @jour1 TINYINT
--INSERT INTO Journal(FK_CUSTOMER, FK_PRODUCT, FK_WORKER, DATE_PLACEMENT, DATE_EXECUTION)
--VALUES(@cust1, @prod4, @work2, '2022-05-01', '2022-05-02')
--SELECT @jour1 = @@IDENTITY

SELECT * FROM Journal
--DELETE FROM Journal

-----------------------------------------------------------------------------------------
--ПРОЦЕДУРЫ
GO
CREATE PROC Stored_Procedure_Products_Insert --ХРАНИМАЯ ПРОЦЕДУРА ТАБЛИЦЫ ПРОДУКТОВ (INSERT)
@PRODUCT_NAME           VARCHAR(50),   --НАИМЕНОВАНИЕ ТОВАРА
@PRODUCT_WEIGHT         NVARCHAR(50),  --ВЕС ТОВАРА
@PRODUCT_MANUFAC        VARCHAR(50),   --ПРОИЗОДИТЕЛЬ
@PRODUCT_PROVIDER       VARCHAR(50),   --ПОСТАВЩИК
@PRODUCT_AVAILABLE      NVARCHAR(50),  --НАЛИЧИЕ ТОВАРА 
@PRODUCT_QUANTITY       INT        ,   --КОЛИЧЕСТВО ТОВАРА
@PRODUCT_PRICE          INT        ,   --ЦЕНА ТОВАРА
@PRODUCT_TYPE           VARCHAR(50)
AS
BEGIN
INSERT INTO Products(PRODUCT_NAME, PRODUCT_WEIGHT, PRODUCT_MANUFAC, PRODUCT_PROVIDER, PRODUCT_AVAILABLE, PRODUCT_QUANTITY, 
                     PRODUCT_PRICE, PRODUCT_TYPE) VALUES
					 (@PRODUCT_NAME, @PRODUCT_WEIGHT, @PRODUCT_MANUFAC, @PRODUCT_PROVIDER, @PRODUCT_AVAILABLE, @PRODUCT_QUANTITY, 
                     @PRODUCT_PRICE, @PRODUCT_TYPE)
END

GO

CREATE PROC Stored_Procedure_Workers_Insert
@WORKER_SURNAME         VARCHAR(50), --ФАМИЛИЯ РАБОТНИКА
@WORKER_NAME            VARCHAR(50), --ИМЯ РАБОТНИКА
@WORKER_PATRONOMIC      VARCHAR(50), --ОТЧЕСТВО РАБОТНИКА
@WORKER_IIN             BIGINT     , --ИИН НОМЕР РАБОТНИКА
@WORKER_SEX             VARCHAR(15), --ПОЛ РАБОТНИКА
@WORKER_PHONE           BIGINT     , --ТЕЛЕФОННЫЙ НОМЕР
@WORKER_EMAIL           VARCHAR(50), --ПОЧТОВЫЙ АДРЕС
@WORKER_WORKTIME        int        , --ЧАСЫ РАБОТЫ
@WORKER_ADDRESS         VARCHAR(50), --ДОМАШНИЙ АДРЕС
@WORKER_COME            DATE       , --ДАТА ПРИХОДА
@WORKER_OUTCOME         DATE       , --ДАТА УВОЛЬНЕНИЯ
@WORKER_LICENSE         BIT        , --ВОДИТЕЛЬСКИЕ ПРАВА
@WORKER_EXPERIENCE      INT         --ОПЫТ РАБОТЫ
AS
BEGIN
INSERT INTO Workers(WORKER_SURNAME, WORKER_NAME, WORKER_PATRONOMIC, WORKER_IIN, WORKER_SEX, WORKER_PHONE, WORKER_EMAIL,
                    WORKER_WORKTIME, WORKER_ADDRESS, WORKER_COME, WORKER_OUTCOME, WORKER_LICENSE, WORKER_EXPERIENCE) VALUES
					(@WORKER_SURNAME, @WORKER_NAME, @WORKER_PATRONOMIC, @WORKER_IIN, @WORKER_SEX, @WORKER_PHONE, @WORKER_EMAIL,
                    @WORKER_WORKTIME, @WORKER_ADDRESS, @WORKER_COME, @WORKER_OUTCOME, @WORKER_LICENSE, @WORKER_EXPERIENCE)
END

GO

CREATE PROC Stored_Procedure_Customers_Insert
@CUSTOMER_SURNAME       VARCHAR(50), --ФАМИЛИЯ КЛИЕНТА
@CUSTOMER_NAME          VARCHAR(50), --ИМЯ КЛИЕНТА
@CUSTOMER_PATRONOMIC    VARCHAR(50), --ОТЧЕСТВО КЛИЕНТА
@CUSTOMER_PHONE         BIGINT     , --НОМЕР ТЕЛЕФОНА КЛИЕНТА
@CUSTOMER_EMAIL         VARCHAR(50), --ПОЧТОВЫЙ АДРЕС КЛИЕНТА
@CUSTOMER_ADDRESS       VARCHAR(50), --АДРЕС КЛИЕНТА
@CUSTOMER_HOME          VARCHAR(50), --ДОМ КЛИЕНТА
@CUSTOMER_ENTRANCE      VARCHAR(10), --ПОДЪЕЗД
@CUSTOMER_FLAT          SMALLINT     --КВАРТИРА
AS
BEGIN
INSERT INTO Customers(CUSTOMER_SURNAME, CUSTOMER_NAME, CUSTOMER_PATRONOMIC, CUSTOMER_PHONE, CUSTOMER_EMAIL, CUSTOMER_ADDRESS, CUSTOMER_HOME, 
                      CUSTOMER_ENTRANCE, CUSTOMER_FLAT) VALUES 
					  (@CUSTOMER_SURNAME, @CUSTOMER_NAME, @CUSTOMER_PATRONOMIC, @CUSTOMER_PHONE, @CUSTOMER_EMAIL, @CUSTOMER_ADDRESS, @CUSTOMER_HOME, 
					  @CUSTOMER_ENTRANCE, @CUSTOMER_FLAT)
END

