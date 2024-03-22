﻿/* 3059. Find All Unique Email Domains, Easy */

/*
Table: Emails

+-------------+---------+
| Column Name | Type    |
+-------------+---------+
| id          | int     |
| email       | varchar |
+-------------+---------+
id is the primary key (column with unique values) for this table.
Each row of this table contains an email. The emails will not contain uppercase letters.
Write a solution to find all unique email domains and count the number of individuals associated with each domain. Consider only those domains that end with .com.

Return the result table orderd by email domains in ascending order.

The result format is in the following example.

 

Example 1:

Input: 
Emails table:
+-----+-----------------------+
| id  | email                 |
+-----+-----------------------+
| 336 | hwkiy@test.edu        |
| 489 | adcmaf@outlook.com    |
| 449 | vrzmwyum@yahoo.com    |
| 95  | tof@test.edu          |
| 320 | jxhbagkpm@example.org |
| 411 | zxcf@outlook.com      |
+----+------------------------+
Output: 
+--------------+-------+
| email_domain | count |
+--------------+-------+
| outlook.com  | 2     |
| yahoo.com    | 1     |  
+--------------+-------+
Explanation: 
- The valid domains ending with ".com" are only "outlook.com" and "yahoo.com", with respective counts of 2 and 1.
Output table is ordered by email_domains in ascending order.
*/

/* Write your T-SQL query statement below */
Select * From 
(Select domain as email_domain, Count(*) as count 
From (Select domain From (Select SUBSTRING(email, CHARINDEX('@', email) + 1, LEN(email))as domain From Emails) a 
Where domain like '%.com') b
Group by domain) t
Order by email_domain
