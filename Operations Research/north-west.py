import numpy as np
import pandas as pd

stocks = [120, 120, 35, 60]
orders = [70, 110, 40, 115]

# stocks = list(map(int, input('Запаси: ').split()))
# orders = list(map(int, input('Замовлення: ').split()))
# P = int(input('Пропускна здатність = '))

# маршрути з обмеженною пропускною здатністю
limit_indexes, P = {(0, 1), (1, 1), (2, 3)}, 40

# збереження початкових значень
table = pd.DataFrame(index=stocks, columns=orders) # формування таблиці (рядки, стовпці)
plan = np.zeros((len(stocks), len(orders)), dtype = int)

# прямий порядок (північно-західний кут)
for j in range(len(orders)):     # замовлення
    for i in range(len(stocks)): # запаси
        if orders[j] == 0:
            break
        value = min(orders[j], stocks[i], P) if (i, j) in limit_indexes else min(orders[j], stocks[i])
        plan[i][j] = value
        orders[j] -= value
        stocks[i] -= value

print(pd.DataFrame(plan, index=table.index, columns=table.columns))
print(pd.DataFrame(plan, index=table.index, columns=table.columns))