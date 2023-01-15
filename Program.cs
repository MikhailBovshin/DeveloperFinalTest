// Программа для итогового теста по блоку "Разработчик"

Console.WriteLine ("Введите длину исходного массива:");
int initialLength = Convert.ToInt32(Console.ReadLine());      //Узнаем длину входящего массива
string [] initialArray = new string [initialLength];
int index = 0;
int finalLength = 0;
while (index<initialLength)
{
    Console.WriteLine ("Введите " + index + "-й элемент:");
    initialArray[index] = Console.ReadLine();                 //Считываем и запоминаем каждый элемент массива
    if (initialArray[index].Length<4)                         //Параллельно подсчитываем кол-во элементов, которые потом
    {                                                         //нужно будет перенести во второй массив
        finalLength++;
    }
    index++;
}

index = 0;
int finalIndex = 0;
string [] finalArray = new string [finalLength];              //Создаем новый массив

while (index<initialLength)
{
    if (initialArray[index].Length<4)                         //Если элемент исходного массива удовлетворяет условию - копируем его в новый массив
    {
        finalArray[finalIndex] = initialArray[index];
        finalIndex++;
    }
    index++;
}

Console.WriteLine ("Итоговый массив:");
finalIndex = 0;
while (finalIndex<finalLength)                                //Выводим получившийся массив на экран
{
    Console.Write(finalArray[finalIndex] + " ");
    finalIndex++;
}