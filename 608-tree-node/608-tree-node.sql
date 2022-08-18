# Write your MySQL query statement below
SELECT id, 'Root' AS type FROM Tree WHERE p_id is null

UNION

SELECT id, 'Inner' AS type FROM Tree WHERE p_id is not null and id in(select p_id from Tree where p_id is not null)

UNION

SELECT id, 'Leaf' AS type FROM Tree WHERE p_id is not null and id not in(select p_id from Tree where p_id is not null)