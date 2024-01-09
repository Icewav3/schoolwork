"""
1) Create a list that stores the following integers: [5, 0, -10, 4, 9, -5, 13, 26, -17, 18]. Print out each number in the list.
2) Calculate the sum and display the result neatly. Do not use the "sum" function.
3) Calculate the average and display the result neatly. Do this in a way that will work for a list of any length.
4) Find the largest number and display the result neatly. Do not use the "max" function. Do this in a way that will work for any list of integers.
"""
mylist = [5, 0, -10, 4, 9, -5, 13, 26, -17, 18]
sum = 0

for each in mylist:
    print(each)
    sum += each
print("The sum of the list is: ", sum)
print("The average of the list is: ", sum/len(mylist))

#calculate the largest
max = mylist[0]
for i in mylist:
    if i > max:
        max = i
print("The largest number in the list is: ", max)