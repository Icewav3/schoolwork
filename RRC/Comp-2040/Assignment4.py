'''
Cole Dorman
1/25/2024

Create a different .py file for each question below. Write your code according to PEP8 standards.

1) Ask the user to input five integers and store these in a list; reject any input that is not a valid integer and ask again, so that you receive five valid integers at the end of this input process. Write a code to sort the numbers from smallest to largest (do not use the sort() method). Print out the original list and the sorted list.

2) Ask the user to input a string. Create a dictionary that has each character found in the string as a key, with the number of times it is found (the frequency) as the corresponding value. Print out the characters and frequencies, in alphabetical order of the keys (you may use a sort function for this question). For example, if the input is 'baca', the dictionary should be: {'a': 2, 'b': 1, 'c': 1}.'''

#1
ints = []
sorted_ints = []
while len(ints) < 5:
    user_input = input("Enter a number: ").lower().strip()
    try:
        user_input = int(user_input)
        ints.append(user_input)
    except:
        print("This is not a valid integer")
    print("you have: ", 5-len(ints)," entries left")
for i in ints:
    if not sorted_ints or i <= sorted_ints[-1]:
        sorted_ints.append(i)
    else:
        for j in sorted_ints:
            if i > j:
                sorted_ints.insert(sorted_ints.index(j),i)
                break
    print(sorted_ints)
print(f"The original list is: {ints}")
print(f"The ordered list is: {sorted_ints[::-1]}")

#2
characters_dict = {}
user_input = input("Enter a string: ").lower().strip()
for i in user_input:
    if characters_dict.__contains__(i):
        characters_dict[i] += 1
    else:
        characters_dict[i] = 1
sorted_keys = sorted(characters_dict.keys())
for key in sorted_keys:
    print(key, characters_dict[key])