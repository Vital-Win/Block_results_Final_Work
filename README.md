## Итоговая проверочная работа

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

**Описание решения:**
1. Объявляем два массива: первый и второй такой же длины. 
2. Применяем метод, в котором используется цикл равный длине первого массива, внутри данного цикла проводится проверка условия (<=3), если да, то элемент первого массива заносится в count элемент второго массива. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так пока не выйдем из цикла.
3. Затем применяем метод для вывода искомого массива в консоль.
4. Конец программы.