# 2) The file lrm_app.py is to demonstrate using the class you created above. It should do the following:

# Import the lrm module you made above.
# Create two LinRegModel objects, one using the default values for slope and bias, the other setting slope = -1 and bias = 4.
# Use print to display the attributes of each linear regression model.
# Use the predict method you created to obtain predictions from each model for the input xlist = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]; store each list of predictions in a variable.
# Use the rmse function to calculate the root-mean-squared-error of each function, using your predictions and ylist = [4, 3, 2, 1, 0, -1, -2, -3, -4, -5]. Print the result for each model.

import lrm

model1 = lrm.LinRegModel()
model2 = lrm.LinRegModel(-1, 4)
print(model1)
print(model2)
xlist = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
ylist = [4, 3, 2, 1, 0, -1, -2, -3, -4, -5]
predictions1 = model1.predict(xlist)
predictions2 = model2.predict(xlist)
print(lrm.rmse(ylist, predictions1))
print(lrm.rmse(ylist, predictions2))
