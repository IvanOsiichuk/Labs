import numpy as np
import pandas as pd

goods = [20, 120, 35, 60]  # запаси
orders = [70, 110, 40, 15] # замовлення
plan = pd.DataFrame(index=goods, columns=orders) # таблиця (рядки, стовпці) [для збереження початкових значень]
matrix = np.zeros((len(goods), len(orders)))     # нульові значення плану

# у зворотньому порядку (південно-східний кут)
for j in reversed(range(len(orders))):    # замовлення
    for i in reversed(range(len(goods))): # запаси
        # print(pd.DataFrame(matrix, index=goods, columns=orders)) # відладка кожного значення
        if (goods[i] > orders[j]):
            matrix[i][j] = orders[j]
            goods[i] -= orders[j]
            orders[j] = 0; break
        elif(orders[j] > 0 and goods[i] > 0):
            matrix[i][j] = orders[j] - (orders[j] - goods[i])
            orders[j] -= goods[i]
            goods[i] = 0

plan = pd.DataFrame(matrix, index=plan.index, columns=plan.columns)
print(plan)