amount = 0 # - кількість порівнянь
def main():
    a = []

    # Читання файлу:
    for item in open("data.txt", 'r'):
        try:
            a.append(int(item))
        except:
            continue # - якщо рядок неможливо перетворити в цілий тип
    #print(f"Початковий масив:\n{a}")
    
    a.pop(0) # - видалення першого елементу, який є кількістю елементів у масивів
    quick_sort(a)
    print(f"Всього виконано порівнянь: {amount}") # [Кінцевий масив:\n{a}\n]

# Визначення середнього значення серед трьох:
def pivot_definition(a, first, medium, last):
    if a[medium] > a[first] > a[last] or a[last] > a[first] > a[medium]: # - перший елемент є медіаною
        a[first], a[last] = a[last], a[first]
    elif a[first] > a[medium] > a[last] or a[last] > a[medium] > a[first]: # - середній елемент є медіаною
        a[medium], a[last] = a[last], a[medium]
    # у інших випадках медіаною уже є останній елемент

# Швидке сортування [begin - початок підмасиву для сортування, pivot - опорний елемент]:
def quick_sort(a, begin = 0, pivot = None):
    if pivot == None:
        pivot = len(a) - 1
    _quick_sort(a, begin, pivot) # - початковий виклик рекурсивної функції
    
# Основна рекурсивна функція:
def _quick_sort(a, begin, pivot):
    if begin < pivot:        # - якщо підсписок для сортування містить більше 1 елемента
        pivot_definition(a, begin, (begin + pivot) // 2, pivot)     # - визначення медіани для використання в якості опорного елементу
        wall = partition(a, begin, pivot)      # - пошук середини для поділу
        _quick_sort(a, begin, wall - 1)        # - сортування елементів зліва від середини
        _quick_sort(a, wall + 1, pivot)        # - сортування елементів справа від середини
    
# Поділ на підсписки [a - список для сортування, wall - початок діапазону для сортування, pivot - опорний елемент]:
def partition(a, wall, pivot):
    global amount
    amount += pivot - wall
    
    for left in range(wall, pivot):             # - всі елементи у діапазоні від початку сортування до опорного елементу (без останнього)
        if a[left] <= a[pivot]:                 # - якщо знайдено елемент менший або рівний опорному
            a[left], a[wall] = a[wall], a[left] # - переміщення за стіну [новий елемент з індексом 0]
            wall += 1                           # - переміщення стіни на 1 вправо
    a[pivot], a[wall] = a[wall], a[pivot]       # - заміна опорного елементу із останнім перевіреним
    return wall                                 # - повертає індекс середини по значеннях [зліва менші елементи, справа більші]
    
# Блок перевірки модуля:
if __name__ == "__main__":
    main()