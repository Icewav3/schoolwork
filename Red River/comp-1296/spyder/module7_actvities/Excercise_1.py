# -*- coding: utf-8 -*-
"""
Created on Thu Oct 19 08:20:40 2023

@author: coled
"""

import math

total = 0
tuition = 0
INSURANCE = 300
CREDIT_VALUE = 1300.3
STUDENT_SERVICES = 50.25
GYM_MEMBERSHIP = 23

#editable vars

insurance = False
gym_membership = True
credits_taken = 27


total += GYM_MEMBERSHIP
total += INSURANCE
print(f"Current Total: {total}")
print(f"student is taking {credits_taken} credits.")
tuition = credits_taken * CREDIT_VALUE
print(f"with a value of {CREDIT_VALUE} this totals to: {tuition}")
total -= INSURANCE
print(f"Student is buying insurance: {insurance}")
total += tuition
print("Deducting insurance and adding tutition")
print("rounding...")
print(total)
print(int(total%10))

print(total%1+total)
#math.ceil()
