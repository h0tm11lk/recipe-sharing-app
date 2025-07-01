CREATE TABLE MenuItems (
    MenuItemId BIGSERIAL PRIMARY KEY
    , RecipeId BIGINT NOT NULL
    , Name VARCHAR(255) NOT NULL
    , QuantityValue NUMERIC(10, 2) NOT NULL
    , Unit VARCHAR(50) NOT NULL
    , CONSTRAINT FK_Recipes_RecipeId
        FOREIGN KEY (RecipeId)
        REFERENCES Recipes(RecipeId)
        ON DELETE CASCADE
);

-- DROP TABLE MenuItems CASCADE;