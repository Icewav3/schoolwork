# 1. Using your favorite text editor, create a weather.csv file with the following lines, making sure there are no spaces in between items:
# "Temp", "Press", "Humidity",
# 1.1, 55.5, 22.2,
# 3.3, 4.4, 6.6,
# 8.8, 99.9, 7.7
# 2. Write a function that reads the CSV file into a dictionary and calculates the average temperature.
# 3. Print out all the original data and the average temperature on the screen.
import csv
average = 0
amtKeys = 0
with open('Comp-2040/TopicChallenge_6B/weather.csv') as f:
    testvar = csv.DictReader(f)
    for line in csv.DictReader(f):
        print(line)
        average += float(line['Temp'])
        amtKeys += 1
    print("Average Temperature: ", average/amtKeys)
    