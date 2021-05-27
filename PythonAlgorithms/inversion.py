def main():
    a = []
    for line in open("array.txt", 'r'):
        a.append(line[line.find(' ') + 1:].split(' '))
    
    print('Відлік починається з 1')
    while True:
        f = int(input("Перший: "))
        s = int(input("Другий: "))
        if f >= 1 and f <= len(a) and s >=1 and s <= len(a):
            break
		
    a[f] = [int(item) for item in a[f]]
    a[s] = [int(item) for item in a[s]]
    inversion_find(a[f], a[s])
    
def inversion_find(first, second):
    if (len(first) != len(second)):
        return

    for i in range(len(first) // 2 + 1): # - лінійний прохід по ключових елементах
        while first[i] != i + 1:     # - доки елемент стоїть не на своєму місці [має дорівнювати своєму індексу зі зміщенням]
            index = first[i] - 1     # - значення цього елемента [індекс місця, де він має бути]
            first[index], first[i] = first[i], first[index] # - перестановка місцям
            second[index], second[i] = second[i], second[index]

    print(f"| Обрано:\nПерший масив: {first}\nДругий масив: {second}")
    count = 0
    print("Знайдені інверсії: ")
    for i in range(0, len(second) - 1):
        for j in range(i + 1, len(second)):
            if (second[i] > second[j]):
                count += 1
                print(f"({i + 1}, {j + 1})")
    print(f"Всього знайдено інверсій: {count}.")

if __name__ == "__main__":
    main()