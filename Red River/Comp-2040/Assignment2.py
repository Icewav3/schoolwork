from datetime import datetime
import time
import math

#1
for i in range(5):
    right_this_minute = datetime.today().minute
    if right_this_minute % 2 == 1:
        print("This minute seems a little odd.")
    else:
        print("Not an odd minute.")
    time.sleep(60)

#2
alphabet = "abcdefghijklmnopqrstuvwxyz"
for i in range(25, 0, -2):
    print(alphabet[i], end="\n")

#3
mylist = [73.79693173, 41.76429734, 53.66368384, 24.60911367, 73.60414637, 62.26858213, 13.9670495, 70.97809816, 17.9978692, 56.10505197]

mean = sum(mylist) / len(mylist)
variance = sum((x - mean) ** 2 for x in mylist) / len(mylist)
standard_deviation = math.sqrt(variance)

print("Variance:", variance)
print("Standard Deviation:", standard_deviation)
