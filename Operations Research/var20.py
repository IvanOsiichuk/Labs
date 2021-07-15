import numpy as np

routes, tariffs = np.loadtxt('routes.txt'), np.loadtxt('tariffs.txt')
product = routes * tariffs
print(round(product.sum() / product[product > 0].size, 2))
'''
Обидві матриці поелементно перемножуються.
Отримуємо нову матрицю, кожен її елемент - добуток двох відповідних елементів початкових матриць.
Сума цієї матриці ділиться на кількість її ненульових елементів.
'''