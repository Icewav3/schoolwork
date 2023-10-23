# -*- coding: utf-8 -*-
"""
calculator

Created on Sun Oct 22 11:50:23 2023

@author: coled
"""
output = 0
# Read the input from the user
print("Enter a value: ")
input_str = input("Input: ")
if len(input_str) == 1:
    value = int(input_str)
    r = range(1, value + 1)
    for x in r:
        output += x
    print(output)

# try:
#     x, y = map(int, input_str.split(','))
    
#     print(f'x: {x}, y: {y}')
# except ValueError:
#     print("Invalid input format. Please use 'x, y' format.")