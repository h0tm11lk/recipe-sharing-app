CREATE TABLE recipes (
    RecipeId BIGSERIAL PRIMARY KEY,
    CreatorId BIGINT NOT NULL,
    Title VARCHAR(255) NOT NULL,
    Description TEXT NOT NULL,
    CookingTimeMinutes INT NOT NULL,
    ImageUrl VARCHAR(500),
    IsPublished BOOLEAN DEFAULT FALSE NOT NULL,
    CategoryId INT NOT NULL,
    CreateAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP NOT NULL,
    UpdateAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP NOT NULL,
    CONSTRAINT FK_Recipes_Users
        FOREIGN KEY (CreatorId)
        REFERENCES Users(UserId)
        ON DELETE CASCADE,
    CONSTRAINT FK_Recipes_Categories
        FOREIGN KEY (CategoryId)
        REFERENCES Categories(CategoryId)
        ON DELETE CASCADE
);

-- DROP TABLE recipes CASCADE;