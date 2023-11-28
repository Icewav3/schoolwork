import AccountCreator
import TuitionCalculator
import SaveData

#Functions
def clean(string):
    return string.lower().strip()

#Main
exit = False
login = False
DATA_HANDLER = SaveData.DataHandler("users")
print("Welcome to Red River")
while exit == False:
    mode = clean(input("Would you like to create an account or login to an existing account? (create/login): "))
    if mode == "exit":
        exit = True
        print("Thank you for using Red River")
    elif mode == "create":
        account_creator = AccountCreator.AccountCreator() #Create account creator object
        DATA_HANDLER.write_data(account_creator.CreateAccount()) #Create account and write to file
    elif mode == "login":
        data = DATA_HANDLER.read_data()
        #print(data)
        username = clean(input("Enter your username: "))
        if username in data.values():
            print(f"Welcome back {username}")
            print(f"Please enter your password to continue")
            password = input("Enter your password: ")
            if password == data['password']: #Check if password matches
                print("Login accepted")
                login = True #Login successful
                while login == True:
                    options = clean(input("Would you like to calculate your tuition or return account details? (tuition/details/logout): "))
                    if options == "tuition":
                        tuition_calculator = TuitionCalculator.TuitionCalculator()
                        tuition = tuition_calculator.CalculateTuition()
                        print(f"Your tuition's monthly payment is: ${tuition}")
                    elif options == "details":
                        print(f"Username: {data['username']}")
                        print(f"First name: {data['fname']}")
                        print(f"Last name: {data['lname']}")
                        print(f"Email: {data['email']}")
                    elif options == "logout":
                        login = False
                        print("Logging out...")
                    else:
                        print("invalid input, please try again")
            else:
                print("Password incorrect, please try again")       
        else:
            print("Username not found, please try again")
    else:
        print("invalid input, please try again")