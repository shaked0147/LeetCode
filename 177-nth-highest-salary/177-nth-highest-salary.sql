CREATE FUNCTION getNthHighestSalary(N INT) RETURNS INT
BEGIN
DECLARE A INT;
SET A=N-1;
  RETURN (
      # Write your MySQL query statement below.
      select distinct salary
      from Employee
      order by salary desc limit A, 1
  );
END