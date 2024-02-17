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

class LinRegModel:
    def __init__(self, slope = 0, bias = 0):
        self.slope = slope
        self.bias = bias
    def __repr__(self):
        return f"***************************************\nModel parameters:\nslope = {self.slope}\nbias = {self.bias}\n***************************************"
    def predict(self, x):
        return [self.bias + self.slope * i for i in x]

rmse = lambda y, yhat: (sum([(y[i] - yhat[i])**2 for i in range(len(y))])/len(y))**0.5