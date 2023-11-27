# -*- coding: utf-8 -*-
"""
user account creation

creates user account using data from another program

Created on Thu Nov  2 09:37:38 2023

@author: coled
"""

'''external variables'''
import Util
class AccountCreator:
    EMAILSUFFIX = "@academic.rrc.ca"
    username: str
    fname: str
    lname: str
    email: str
    userid: int
    password: str
    last_user_id = 0
    requirements = False
    #Requirements
    CHAR_MIN = 8
    NUM_MIN = 2

#Functions

    def __init__(self):
        self.user = {}

    def clean(self, string):
        return string.lower().strip()
    
    def PasswordHandler(self): #Private
        while not AccountCreator.requirements:
            password = input("Enter your password: ")
            if len(password) < AccountCreator.CHAR_MIN:
                print(f"Password must be at least {AccountCreator.CHAR_MIN} characters long")
            elif sum(1 for c in password if c.isdigit()) < AccountCreator.NUM_MIN:
                print(f"Password must contain at least {AccountCreator.NUM_MIN} number(s)")
            else:
                AccountCreator.requirements = True
                self.password = password
        return self.password

    def CreateAccount(self):
        fname = self.clean(input("Enter your first name: "))
        lname = self.clean(input("Enter your last name: "))
        username = fname[0] + lname
        print(f"Your automatically generated username is: {username}")
        email = username + AccountCreator.EMAILSUFFIX
        print(f"Your automatically generated email address is: {email}")

        print("Generating user profile...\n")
        self.user['username'] = username
        print(f"Added username: {username} to the user profile")
        self.user['fname'] = fname
        print(f"Added first name: {fname} to the user profile")
        self.user['lname'] = lname
        print(f"Added last name: {lname} to the user profile")
        self.user['email'] = email
        print(f"Added email: {email} to the user profile")
        self.last_user_id += 1
        self.user['userid'] = self.last_user_id
        print(f"Added user ID: {self.last_user_id} to the user profile")

        self.password = self.PasswordHandler()

        print(f"User profile generated: {self.user}")
        return self.user

