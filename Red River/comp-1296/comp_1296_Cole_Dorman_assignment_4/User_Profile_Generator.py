# -*- coding: utf-8 -*-
"""
user account creation

creates user account using data from another program

Created on Thu Nov  2 09:37:38 2023

@author: coled
"""

'''external variables'''

username = "cdorman"
fname = "Cole"
lname = "Dorman"
email = "cdorman@example.com"
userid = "12740757"

user = {}

print("generating user profile...\n")
user['username'] = username
print(f"Added username: {username} to the user profile")
user['fname'] = fname
print(f"Added first name: {fname} to the user profile")
user['lname'] = lname
print(f"Added last name: {lname} to the user profile")
user['email'] = email
print(f"Added email: {email} to the user profile")
user['userid'] = userid
print(f"Added user ID: {userid} to the user profile")
print(f"User profile generated: {user}")