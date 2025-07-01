INSERT INTO Tags (Name) VALUES
('時短レシピ'),
('簡単'),
('ヘルシー'),
('パーティー向け'),
('お弁当'),
('子供向け'),
('一人暮らし'),
('節約'),
('定番'),
('和風');

SELECT *
FROM recipes;

SELECT
    r.title AS "タイトル"
    , c.name AS "カテゴリー名"
FROM recipes AS r
INNER JOIN categories AS c
    ON r.categoryid = c.id;