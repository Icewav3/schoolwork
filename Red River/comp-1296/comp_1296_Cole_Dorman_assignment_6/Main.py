import AccountCreator
import TuitionCalculator
import Util
import SaveData

exit = False
DATA_HANDLER = SaveData.DataHandler("users")

print("Welcome to Red River")
while exit == False:
    mode = Util.clean(input("Would you like to create an account or login to an existing account? (create/login): "))
    if mode == "exit":
        exit = True
        print("Thank you for using Red River")
    elif mode == "create":
        account_creator = AccountCreator.AccountCreator() #Create account creator object
        DATA_HANDLER.write_data(account_creator.CreateAccount()) #Create account and write to file
    elif mode == "login":
        data = DATA_HANDLER.read_data()
        #print(data)
        username = Util.clean(input("Enter your username: "))
        if username in data.values():
            print("Welcome back")
            tuition_calculator = TuitionCalculator.TuitionCalculator()
            tuition_calculator.CalculateTuition()
        else:
            print("Username not found, please try again")
    else:
        print("invalid input, please try again")