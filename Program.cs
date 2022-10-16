// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либа равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коолекциями, лучше обойтись исключительно массивами.


string[] mass = { "task", "line", "dog", "cat", "num", "result", "day" };

string[] SearchString(string[] mass)
{
    string[] scndmass = new string[1];
    int j = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            Array.Resize(ref scndmass, 1 + j);
            scndmass[j] = mass[i];
            j++;
        }
    }
    return scndmass;
}
Console.WriteLine(String.Join(" | ", SearchString(mass)));


