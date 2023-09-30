# -*- coding: utf-8 -*-
"""
Created on Tue Sep 26 11:34:47 2023

@author: coled
"""

#Project 4
#Declaration
mylist = ["4", "cow", "1984", "string", "another_string",  92, 8712, 50, 2023, 7, 192.62, 19.74, 10.6, 78.672, 15.4, True, False]
print(f"The original list is: {mylist}")
print("\n")
for i in mylist:
    if(type(i)==bool):
        mylist.remove(i)
print(mylist)
print("\nNot possible, you can not remove the final boolean from the list while iterating through it")

print("\nHowever a possible solution is to create a new list:\n")

newlist = []
for i in mylist:
    if(type(i)!=bool):
        newlist.append(i)
print(newlist)

        