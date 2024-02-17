# In this assignment, you are to create two files: one file is a python module that should be named lrm.py; the other file is a python application named lrm_app.py which will import and use code from the module.

# 1) The file lrm.py should contain the following:

# A class named LinRegModel which is used for working with linear regression models. This class should have
# an __init__ method which creates two attributes: slope and bias, each with a default value of 0. The user should be able to enter slope and bias when creating a new LinRegModel object.
# a __repr__ method which neatly displays the value of slope and bias for a LinRegModel object as follows: 

# ***************************************
# Model parameters:
# slope = 1
# bias = 1
# ***************************************

# a predict method which takes a list of floats (x) as input and returns a list of predictions (y) according to: 
# y = bias + slope * x
# Outside of the class, there should be a function named rmse which inputs two lists of floats (each with the same length), one with predictions (yhat) and the other with true values (y). The function should return the root-mean-squared-error, found by:

# rmse = sqrt(1/n * sum((y - yhat)^2))
 
# where n is the length of each list.

# 2) The file lrm_app.py is to demonstrate using the class you created above. It should do the following:

# Import the lrm module you made above.
# Create two LinRegModel objects, one using the default values for slope and bias, the other setting slope = -1 and bias = 4.
# Use print to display the attributes of each linear regression model.
# Use the predict method you created to obtain predictions from each model for the input xlist = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]; store each list of predictions in a variable.
# Use the rmse function to calculate the root-mean-squared-error of each function, using your predictions and ylist = [4, 3, 2, 1, 0, -1, -2, -3, -4, -5]. Print the result for each model.


