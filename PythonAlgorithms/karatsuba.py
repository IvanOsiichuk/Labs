amount = 0 # - лічильник повторень значень

def karatsuba(x, y):
    """x * y методом Карацуби\nЗа value != None перевіряє кількість, коли ad + bd = value"""
    x, y = str(x), str(y)
    n = max(len(x), len(y))
    if n == 1:
        return int(x) * int(y)
    half = n // 2 # x та y мають однакові довжини
    
    # Поділ на половини:
    a, b = x[:-half], x[-half:]
    c, d = y[:-half], y[-half:]
    if a == '':
        a = 0
    if b == '':
        b = 0
    if c == '':
        c = 0
    if d == '':
        d = 0

    # Рекурсивний обрахунок:
    ac = karatsuba(a, c)
    bd = karatsuba(b, d)
    ab_cd = karatsuba(int(a) + int(b), int(c) + int(d))

    # Перевірка повторень певних значень:
    global amount
    if ab_cd - ac - bd == 105:
        amount += 1
    return (pow(100, half) * ac) + (pow(10, half) * (ab_cd - ac - bd)) + bd

if __name__ == "__main__":
    x = int(input('x = '))
    y = int(input('y = '))
    print(f'x * y = {karatsuba(int(x), int(y))}')
    print(amount)