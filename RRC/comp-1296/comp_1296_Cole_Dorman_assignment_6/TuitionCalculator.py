# -*- coding: utf-8 -*-
"""
School Cost Calculator

calculates total cost given user input

Created on Tue Oct 31 09:36:53 2023

@author: coled
"""
import Util


class TuitionCalculator:
    userinput = False
    total = 0
    tuition = 0
    insurance = 0
    gym_membership = 0
    payment_per_month = 0
    monyhly_payments = 0
    INSURANCE = 300
    CREDIT_VALUE = 1300.3
    STUDENT_SERVICES = 50.25
    GYM_MEMBERSHIP = 23

    def clean(self, string):
        return string.lower().strip()

    def GetUserInput(self):
        insurance = self.clean(input("Do you want insurance? (y/n): "))
        if insurance == "y":
            self.insurance = True
        else:
            self.insurance = False
        print(f"insurance: {insurance}")

        gym_membership = self.clean(input("Do you want a gym membership? (y/n): "))
        if gym_membership == "y":
            self.gym_membership = True
        else:
            self.gym_membership = False
        print(f"gym membership: {gym_membership}")

        monthly_payments = int(self.clean(input("How many monthly payments do you want to make? (1-12): ")))
        try:
            self.monthly_payments = int(monthly_payments)
        except ValueError:
            print("invalid input, defaulting to 6")
            self.monthly_payments = 6
        if monthly_payments > 12:
            print("invalid input, defaulting to 6")
            self.monthly_payments = 6
        else:
            print(f"monthly payments: {monthly_payments}")
            self.monthly_payments = monthly_payments

        credits_taken = int(self.clean(input("How many credits are you taking? (1-30): ")))
        try:
            self.credits_taken = int(credits_taken)
        except ValueError:
            print("invalid input, defaulting to 15")
            self.credits_taken = 15
        if credits_taken > 30:
            print("invalid input, defaulting to 15")
            self.credits_taken = 15
        else:
            print(f"credits taken: {credits_taken}")
            self.credits_taken = credits_taken
        if credits_taken is not None and monthly_payments is not None and insurance is not None and gym_membership is not None:
            return True
        return False

    def CalculateTuition(self):
        check = self.GetUserInput()
        if check == True:
            self.total += self.GYM_MEMBERSHIP
            print(f"Current Total: {self.total}")
            self.total += self.INSURANCE * self.insurance #Needs to be tested
            print(f"Current Total: {self.total}")
            self.tuition = self.credits_taken * self.CREDIT_VALUE
            self.total += self.tuition
            payment_per_month = self.total / self.monthly_payments
            payment_per_month = round(payment_per_month)
            return payment_per_month

'''
DEPRECATED
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
'''