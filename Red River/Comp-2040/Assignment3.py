


#1
userInput = input("Enter a string: ")
userInput = userInput.lower().strip()
if userInput == userInput[::-1]:
    print("This is a palindrome")
else:
    print("This is not a palindrome")

#2
myDict = {"dog" : 0, "cat" : 1, "frog" : 2}
labels = []
encodedLabels = []
while len(encodedLabels) < 5:
    userInput = input("Enter an animal: ").lower().strip()
    if myDict.__contains__(userInput):
        labels.append(userInput)
        encodedLabels.append(myDict[userInput])
    else:
        print("This animal is not in the dictionary")
        print("The animals in the dictionary are: " + str(myDict.keys()))
    print("you have: ", 5-len(labels)," entries left")
print(labels)
print(encodedLabels)