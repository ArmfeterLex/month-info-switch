string mes;
Console.WriteLine("Введите номер месяца: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12");
string month = Console.ReadLine();
switch (month)
{   case "1": mes = "Зима. 2 семестр"; break;
    case "2": mes = "Зима. 2 семестр"; break;
    case "3": mes = "Весна. 2 семестр"; break;
    case "4": mes = "Весна. 2 семестр"; break;
    case "5": mes = "Весна. 2 семестр"; break;
    case "6": mes = "Лето. Сессия"; break;
    case "7": mes = "Лето. Каникулы"; break;
    case "8": mes = "Лето. Каникулы"; break;
    case "9": mes = "Осень. 1 семестр"; break;
    case "10": mes = "Осень. 1 семестр"; break;
    case "11": mes = "Осень. 1 семестр"; break;
    case "12": mes = "Зима. Сессия"; break;
    default: mes = "Некорректный номер месяца"; break;
}
Console.WriteLine(mes);
Console.ReadKey();