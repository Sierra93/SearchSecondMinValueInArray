using System;
using System.Collections.Generic;

namespace SearchSecondMinValueInArray {
    class Program {
        static void Main() {
            List<int> listArr = new List<int>() { 1, 7, 3, 4, 5, 6, 2, 8, 9, 10};
            int firstMinValue = listArr[0];    // Первое минимальное значение массива            
            Console.Write("Исходный массив:\n");
            for (int i = 0; i < listArr.Count; i++) {
                Console.Write(listArr[i] + " ");
                // Находит первый минимальный элемент
                if (firstMinValue > listArr[i]) {
                    firstMinValue = listArr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Первый минимальный элемент: {firstMinValue}");
            // Удаляет из списка первый найденный ранее минимальный элемент
            listArr.Remove(firstMinValue);
            // Выводит массив после удаленного элемента
            Console.WriteLine("Массив после удаленного первого минимального элемента:");
            foreach (int el in listArr) {
                Console.Write(el + " ");
            }
            // Нахождение второго минимального значения
            int secondMinValue = listArr[0];    // Минимальный элемент
            for (int i = 0; i < listArr.Count; i++) {
                // Находит второй минимальный элемент
                if (secondMinValue > listArr[i]) {
                    secondMinValue = listArr[i];
                }
            }
            Console.WriteLine();
            Console.Write($"Второй минимальный элемент: {secondMinValue}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
