import numpy as np
import pandas as pd

priorities = np.loadtxt('data.txt') # матриця пріоритетів
s, shape = 800, priorities.shape    # ввід з клавіатури
s = s if 500 <= s <= 1500 else 500  # перевірка коректності значення
pri_linear = np.argsort(priorities.reshape(1, np.product(shape))[0]) # індекси відсортованих значень

plan = np.zeros_like(priorities) # нульова матриця
print(priorities)
for index in pri_linear:
    if s > 0:
        # перетворення в 2D-індекси
        i, j = index // max(shape), index - (max(shape) * (index // max(shape)))
        plan[i][j] = 100 # для квадратних матриць
    else:
        break
    s -= 100
print(priorities)
print(plan)