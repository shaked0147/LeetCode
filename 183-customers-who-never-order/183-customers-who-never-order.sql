# Write your MySQL query statement below
SELECT name  as Customers from Customers
WHERE id NOT in (SELECT customerId from Orders)