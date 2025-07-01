CREATE TABLE Categories (
    CategoryId SERIAL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL UNIQUE
);

-- DROP TABLE categories CASCADE;