# Write your MySQL query statement below
SELECT u.user_id AS buyer_id, join_date, 
IFNULL(COUNT(order_date),0) AS orders_in_2019
FROM Users u LEFT JOIN Orders o ON u.user_id = o.buyer_id AND o.order_date LIKE "2019%"
GROUP BY u.user_id;
