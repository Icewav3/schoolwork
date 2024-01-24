#1
data_list = [42, "apple", 7, "banana", 3, "cherry", 9]

print("The complete list:", data_list)

filtered_list = []
for item in data_list:
    if type(item) == int: 
        filtered_list.append(item)

print(filtered_list)
print(sum(filtered_list))
print("\n")
#2
mixed_data_tuple = (2.718, "Green", True, 42)
print("complete tuple:", mixed_data_tuple)
tlen = len(mixed_data_tuple)
print("The length of the tuple is:", tlen)
print("Index 2 is:", mixed_data_tuple[2])
print("\n")
#3
set1 = {1, 2, 3, 4, 5, 8}
set2 = {3, 4, 5, 6, 7, 9}

difference_set = set1.difference(set2)

difference_set = sorted(difference_set)

print("The difference is:", difference_set)

print("The size of the difference is:", len(difference_set))
print("\n")
#4
my_dict = {
    'name': 'Alice',
    'age': 30,
    'city': 'Wonderland',
    'email': 'alice@wonderland.com',
    'phone': '123-456-7890'
}
print(f"my info: {my_dict}")
personalinfo = [my_dict['name'], my_dict['age'], my_dict['city']]

print(f"Personal Information: {personalinfo}")

contact_details = f"Contact Details: Email: {my_dict['email']}, Phone: {my_dict['phone']}"
print(contact_details)