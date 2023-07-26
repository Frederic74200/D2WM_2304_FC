SELECT SUM(sal), COUNT(empno), AVG(sal), deptno, job 
FROM emp
GROUP BY deptno, job
HAVING COUNT(empno) >=2; 


