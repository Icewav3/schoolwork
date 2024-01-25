# -*- coding: utf-8 -*-
"""
activities 10

practice

Created on Thu Nov  9 08:18:07 2023

@author: coled
"""

#1)
temp = 31
if(temp>30):
    print("It's hot!")
else:
    print("It's not hot!")


#2)
age = 15
if(age>=60):
    print("You are really old")
elif(age>= 50):
    print("You are old")
elif(age>=40):
    print("You are still moving")
else:
    print("enjoy life")

#3)

item = "apple"
dict = {"apple": "Apple Selected", "banana": "banana Selceted", "orange": "orange Selected"}
try:
    print(dict[item])
except:
    print("Item not found")

#4)

age = 23
hasid = True
if(age>=18):
    if(hasid):
        print("You can enter")
    else:
        print("You can't enter")
else:
    print("You are underage")

#5)

temp = 3
is_sunny = True
if(is_sunny and temp<5):
    print("It's cold and sunny")

#6)
x = 5
y = 10
z = 8
if(x>5 and y<10) or (z==0):
    print("conditions met")

#7)
choice = 1
if(choice == 1):
    print("You selected 1")
elif(choice == 2):
    print("You selected 2")
elif(choice == 3):
    print("You selected 3")

#8)
age = 25
if(age>18 and age <30):
    print("You are a young adult")

#9)
number = 5
if(number%2 == 0):
    print("Even")
else:
    print("Odd")

#10)
choice = "view"
dict = {"buy" : "You've chosen to buy the item", "sell" : "You've chosen to sell the item", "view" : "You've chosen to view the item's details"}
if(choice == "buy"):
    print(dict["buy"])
elif(choice == "sell"):
    print(dict["sell"])
elif(choice == "view"):
    print(dict["view"])
else:
    print("Invalid choice")