CREATE TABLE Steps (
    StepId BIGSERIAL PRIMARY KEY
    , RecipeId BIGINT NOT NULL
    , OrderNumber INT NOT NULL
    , Description TEXT NOT NULL
    , CONSTRAINT FK_Recipes_RecipeId
        FOREIGN KEY (RecipeId)
        REFERENCES Recipes(RecipeId)
        ON DELETE CASCADE
);

-- DROP TABLE Steps CASCADE