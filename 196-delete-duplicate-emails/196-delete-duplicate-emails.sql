# Please write a DELETE statement and DO NOT write a SELECT statement.
# Write your MySQL query statement below
DELETE T1 from Person T1 JOIN Person T2
where T1.email = T2.email AND T1.id > T2.id