CREATE TABLE Menus (
    MenuId BIGSERIAL PRIMARY KEY
    , CreatorId BIGINT NOT NULL
    , MenuDate TIMESTAMP NOT NULL
    , CONSTRAINT FK_Users_UserId
        FOREIGN KEY (CreatorId)
        REFERENCES Users(UserId)
        ON DELETE CASCADE
);