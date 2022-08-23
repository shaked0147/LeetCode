# Write your MySQL query statement below
select Users.name, sum(Transactions.amount) as balance
from Users
right join Transactions
on Users.account = Transactions.account
group by Users.name
having balance >= 10000