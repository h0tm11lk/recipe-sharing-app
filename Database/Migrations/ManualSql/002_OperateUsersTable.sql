INSERT INTO public.users (Username, Email, PasswordHash)
SELECT
    'user_' || LPAD(FLOOR(RANDOM() * 1000000)::text, 6, '0') AS username
    , 'user_' || LPAD(FLOOR(RANDOM() * 1000000)::text, 6, '0') || '@example.com' AS Email
    , MD5(RANDOM()::text) AS PasswordHash
FROM GENERATE_SERIES(1, 10) s;

SELECT *
FROM public.users
ORDER BY Id ASC;

SELECT *
FROM public.users
WHERE username LIKE '%a%';

DELETE 
FROM public.users
WHERE NOT username LIKE 'user%';