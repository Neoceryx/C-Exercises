
USE ArteDigitalTest

-- Headquarters = 1, Execution Bran

-- Exercie 1
SELECT AMOUNT,
EMPLOYEE.FIRST_NAME + ' ' + EMPLOYEE.LAST_NAME [FullName]
FROM ACC_TRANSACTION
INNER JOIN BRANCH ON ( ACC_TRANSACTION.EXECUTION_BRANCH_ID = BRANCH.BRANCH_ID)
INNER JOIN EMPLOYEE ON  (ACC_TRANSACTION.TELLER_EMP_ID = EMPLOYEE.EMP_ID)
Where BRANCH_ID = 1 AND AMOUNT  Between 100 AND 1000
ORDER BY AMOUNT DESC

-- Exercie 2
SELECT COUNT(*)[EmployeeNumber], D.NAME FROM EMPLOYEE AS E
INNER JOIN BRANCH B ON (E.ASSIGNED_BRANCH_ID = B.BRANCH_ID)
INNER JOIN DEPARTMENT D ON (E.DEPT_ID = D.DEPT_ID)
Where B.NAME = 'Headquarters'
GROUP BY D.NAME
ORDER BY COUNT(*) DESC
