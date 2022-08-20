# Write your MySQL query statement below
select t1.name
from SalesPerson t1
where t1.sales_id not in 
(select t2.sales_id from Orders t2
left join Company t3 on t2.com_id = t3.com_id
where t3.name = 'RED') 