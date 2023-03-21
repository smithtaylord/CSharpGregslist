CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS houses(
        id INT AUTO_INCREMENT PRIMARY KEY,
        bedrooms INT NOT NULL,
        bathrooms INT NOT NULL,
        year INT NOT NULL DEFAULT 1900,
        price DOUBLE NOT NULL DEFAULT 1.00,
        description TEXT,
        imgUrl VARCHAR(255) NOT NULL
    ) default charset utf8 COMMENT '';

INSERT INTO
    houses(
        bedrooms,
        bathrooms,
        year,
        price,
        description,
        imgUrl
    )
VALUES (
        3,
        3,
        1957,
        10000.99,
        'This is a nice house and it is pretty cool',
        'www.urlarecool.com'
    );

SELECT * FROM houses;