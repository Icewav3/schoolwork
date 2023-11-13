# -*- coding: utf-8 -*-
"""
Module 9 practice activities

Created on Thu Nov  2 08:15:55 2023

@author: coled
"""
#A) Using Python evaluate the following expressions modified them so they evaluate False.

#1)T
student_attendance = 1
student_marks = 85
qa1 = student_marks >= 80 and student_attendance >= 75
print(qa1)

#2)F
num = 15
qa2 = (num % 2 == 0 or num % 3 == 0) or (num > 10)
print(qa2)


#3)T
num = 11
qa3 = (num % 2 == 0 or num % 3 == 0) or not (num > 10)
print(qa3)

#4)T
num = 11
qa4 = num % 2 == 0 or (num % 3 == 0 and num > 10) 
print(qa4)

#5)T
A = 7
B = 3
C = 9
qa5 = (A > B) and (C == 10) or (B <= 5 and not (A == 7))
print(qa5)

#6)T
age = 5
income = 20000
has_degree = True
qa6 = (age >= 18 and age <= 30) and (income > 30000 or has_degree) 
print(qa6)


#B) Using Python evaluate the following expressions:

#1)T
A=1
B=1
C=0
D=1
E=1
F=0
G=0
qb1 = A and (B or C) and (not D or E) and (F and G)
print(qb1)

#2)T
X=1
Y=1
Z=0
P=1
Q=1
R=0
S=0
T=0
qb2 = (X or Y) and (Z or not P) or (Q and R) or (S or T)
print(qb2)


#3)T
A=10
B=1
C=7
qb3 = (A < 5) and (B <= 10) or (C != 7)
print(qb3)

#4)F
X=10
Y=5; 
Z=20
qb4 = (X + Y < 20) and (not (Z <= 15))
print(qb4)


#5)F
P=5
Q=2
R=15
S=9
qb5 = (P * Q < 25) or (R - S == 10) and (S <= 10)
print(qb5)



#6)F
P=5
Q=2
R=15
S=9
qb6 = (P * Q < 25 or R - S == 10) and (S <= 10)

print(qb6)