class Node:
    """Вузол дерева"""
    def __init__(self, key, parent = None, left = None, right = None):
        """Конструктор [key - значення у цьому вузлі, parent - батьківський вузол\n
        [індекс]left - лівий нащадок, [індекс]right - правий нащадок]"""
        if key == 0: # відсутність вузла дерева
            self.key = None
        else:
            self.key = key
            self.parent = parent
            self.left = left
            self.right = right

    def __repr__(self):
        """Перевантаження перетворення у рядок [значення, лівий нащадок, правий нащадок]"""
        return str(self.key)

def inorder_walk(tree, i = 0):
    """Рекурсивний обхід дерева у внутрішньому порядку із перевизначенням\n
    [tree - дерево, i - (для першого виклику)індекс кореня дерева]"""
    if tree[i].key:
        # Ліві нащадки:
        inorder_walk(tree, i + 1) # перехід до останнього лівого елементу в піддереві
        tree[i].key = sort_tree[0]
        del sort_tree[0]
        tree[i].left = tree[i + 1]   # лівий вузол поточного
        tree[i + 1].parent = tree[i] # поточний є батьківським для лівого
        
        # Праві нащадки:
        j = i
        global last_right
        if last_right <= i:
            i += 2
        else:
            i = last_right + 1
        last_right = i
        inorder_walk(tree, i)
        tree[j].right = tree[i]
        tree[i].parent = tree[j]

def sum_mono_ways(tree, sum):
    """Пошук сум монотонних шляхів [tree - дерево, sum - сума для пошуку]"""

    def rec_search(node):
        """[вкладена функція] Рекурсивна зростаюча (від листків до кореня) 
        функція пошуку монотонних сум [node - вузол дерева]"""
        nonlocal s, way, ways # використовуються змінні зовнішньої функції
        if node.key:
            s += node.key
            way.append(node.key)
            if s == sum:
                way.reverse() # - розвертання списку (стане від батьківського вузла до нащадків)
                ways.append(way)
                way = [] # - очищення шляху
                return
            if node.parent:
                rec_search(node.parent)

    s = 0
    ways = [] # усі шляхи
    way = []  # контейнер для зберігання шляху
    for node in reversed(tree): # перебір усіх вузлів дерева із кінця
        rec_search(node)        # ліві нащадки
        s = 0
        way = []
    return ways

# Читання даних:
tree = []
for line in open('data.txt'):
    for item in line.split():
        tree.append(int(item))

# Внутрішній обхід із перетворенням у дерево пошуку:
sort_tree = list(set(tree))          # видалення повторів та сортування
if sort_tree[0] == 0:
    del sort_tree[0]                 # видалення залишкового 0
tree = [Node(node) for node in tree] # перетворення у всіх вузлів у об'єкти Node

last_right = 0
inorder_walk(tree) # обхід дерева у внутрішньому порядку
print(tree)

# Пошук сум:
sum = int(input('Сума для пошуку: '))
ways = sum_mono_ways(tree, sum)
print(f'\tЗнайдено монотонних шляхів:\n{ways}\n' +
      f'Всього: {len(ways)}')