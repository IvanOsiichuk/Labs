from datetime import datetime as dt
def binary_search_sum(keys, s1, s2 = None):
    '''Пошук різних сум в словнику через бінарний пошук
       [keys - словник, s1 - початок діапазону сум, s2 - кінець діапазону]\n
       повертає: кількість різних сум для заданого діапазону'''
    amount = 0 # - кількість різних сум
    if s2 == None: # - перевірятиметься лише 1 сума
        s2 = s1

    sums = [s for s in range(s1, s2 + 1)]
    for key in keys:
        for i in range(len(sums)):
            y = sums[0] - key
            
            # Бінарний пошук:
            begin = 0
            end = len(keys) - 1
            while end - begin >= 0: # доки вибраний діапазон містить числа
                pivot = (begin + end) // 2  # визначення середини
                if keys[pivot] == y:  # шукане значення посередині
                    amount += 1
                    del sums[i]
                    break
                elif y < keys[pivot]: # пошук у лівій половині
                    end = pivot - 1
                else:                 # пошук у правій половині
                    begin = pivot + 1
    return amount

def main():
    start = dt.now()
    keys = [] # - список чисел із файлу
    for x in open('data.txt'):
        keys.append(int(x))
    keys = list(set(keys)) # сортування та видалення повторень
    print(f'Total different values of sums in the interval [-1000, 1000]: {binary_search_sum(keys, -1000, 1000)}')
    print(dt.now() - start)

if __name__ == "__main__":
    main()