# -*- coding: utf-8 -*-
"""
School Cost Calculator

calcualtes total cost given data from another program

Created on Tue Oct 31 09:36:53 2023

@author: coled
"""

#import math

total = 0
tuition = 0
INSURANCE = 300
CREDIT_VALUE = 1300.3
STUDENT_SERVICES = 50.25
GYM_MEMBERSHIP = 23

#editable vars
'''in our meeting we agreed these come from outside program'''
insurance = False
gym_membership = True
credits_taken = 27
monthly_payments = 6
payment_per_month : float

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
print(f"total cost: {total}")
print(f"calculating total divided by {monthly_payments} monthly payments")
payment_per_month = total / monthly_payments
print("rounding...")
payment_per_month = round(payment_per_month)
print(f"you need to pay {payment_per_month}")


