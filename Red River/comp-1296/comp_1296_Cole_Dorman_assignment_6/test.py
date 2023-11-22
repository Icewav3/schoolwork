# Write data to a file
with open("data.txt", "w") as file:
    file.write("Hello, World!")

# Read data from the file
with open("data.txt", "r") as file:
    data = file.read()
    print(data)
