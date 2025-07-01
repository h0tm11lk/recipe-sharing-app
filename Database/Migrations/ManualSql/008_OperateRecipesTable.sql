INSERT INTO recipes (
    CreatorId,
    Title,
    Description,
    CookingTimeMinutes,
    ImageUrl,
    IsPublished,
    CategoryId
)

SELECT
    CASE WHEN RANDOM() < 0.5 THEN 1 ELSE 2 END AS CreatorId
    ,'ランダムレシピ' || LPAD(FLOOR(RANDOM() * 10000)::text, 4, '0') AS Title
    , MD5(RANDOM()::text) || MD5(RANDOM()::text) AS Description
    , FLOOR(RANDOM() * 80) + 10 AS CookingTimeMinutes
    , 'https://example.com/random_recipe_image_' || FLOOR(RANDOM() * 1000) || 'jpg' AS ImageUrl
    , CASE WHEN RANDOM() < 0.7 THEN TRUE ELSE FALSE END AS IsPublished
    , FLOOR(RANDOM() * 4) + 1 AS CategoryId
FROM GENERATE_SERIES(1, 10) s;