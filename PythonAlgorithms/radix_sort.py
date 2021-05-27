letters = [0 for k in range(26)] # - словник кількостей літер (початкове значення 1)

def main():
    strings = [] # - список рядків
    for line in open('strings.txt'): # - читання даних
        strings.append(line.strip().lower())
    radix_sort(strings)
    print(f'{strings}')
    
    # Пошук найбільш частої літери:
    max = 0
    for i in range(1, 26):
        if letters[i] > letters[max]:
            max = i   
    print(f'Пароль: {strings[0]}{chr(max + 97)}{strings[-1]}')
        
# Сортування за розрядами [a - список для сортування]:
def radix_sort(a):
    for s in range(len(a[0]) - 1, -1, -1): # - по всіх розрядах, починаючи з молодшого [для елементів із однаковою кількістю розрядів]
        count_sort(a, s)

# Сортування підрахунком [a - список для сортування, check - розряд, по якому здійснюється сортування]:
def count_sort(a, check):
    symbols = [[] for k in range(26)] # - список із підсписками на кожну літеру

    # Формування списку літер у правильному порядку:
    for i in range(len(a)):
        symbols[ord(a[i][check]) - ord('a')].append(a[i]) # - додавання індексів у підсписок конкретної літери
            
    # Розставлення літер у вхідному списку:
    i = 0
    for s in range(len(symbols)):
        letters[s] += len(symbols[s]) # - додавання до загальної кількості повторень поточного символу, кількість по даному розряду
        for item in symbols[s]:
            a[i] = item
            i += 1
            
# Блок перевірки модуля:
if __name__ == '__main__':
    main()