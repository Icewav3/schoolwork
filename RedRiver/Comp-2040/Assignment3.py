"""
Cole dorman
1/23/2024
Assignment 3 2nd attempt

1) Ask the user to input a word. Check if the word is palindrome (spelled the same forward and backward). Print out the word spelled both forward and backward, along with a statement of whether or not the word is a palindrome. The code should work even if the user enters upper- and/or lower-case letters.

2) Create a dictionary with the following key--value pairs: 'dog' -- 0, 'cat' -- 1, 'frog' -- 2. Ask the user to input five animals (dog, cat, or frog) one at a time, and store these in a list called labels; reject any input that is not one of the animals. Write a code which creates a new list called encoded_labels which denotes each animal with 0, 1, or 2 according to the dictionary, in the same order as labels. Print out labels and encoded_labels.
"""

#1
user_input = input("Enter a string: ")
user_input = user_input.lower().strip()
if user_input == user_input[::-1]:
    print("This is a palindrome")
else:
    print("This is not a palindrome")

#2
my_dict = {"dog" : 0, "cat" : 1, "frog" : 2}
labels = []
encoded_labels = []
while len(encoded_labels) < 5:
    user_input = input("Enter an animal: ").lower().strip()
    if my_dict.__contains__(user_input):
        labels.append(user_input)
        encoded_labels.append(my_dict[user_input])
    else:
        print("This animal is not in the dictionary")
        print("The animals in the dictionary are: " + str(my_dict.keys()))
    print("you have: ", 5-len(labels)," entries left")
print(labels)
print(encoded_labels)