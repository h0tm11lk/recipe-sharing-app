INSERT INTO public.Categories (Name) VALUES
('和食')
, ('洋食')
, ('中華')
, ('デザート')
, ('その他');

SELECT *
FROM public.categories;

SELECT
    r.id
    , c.name
FROM recipes AS r
INNER JOIN categories AS c
    ON r.categoryid = c.id;

DELETE
FROM Categories;