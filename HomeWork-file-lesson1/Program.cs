using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork_file_lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            Console.WriteLine("Задание 1");
            Console.WriteLine(Math.Round(Math.E, 1));


            //Вывести на экран числа 50 и 10 одно под другим.
            Console.WriteLine("\nЗадание 2");
            Console.WriteLine(50);
            Console.WriteLine(10);



            //Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine("\nЗадание 3");
            Console.WriteLine(25);
            Console.WriteLine(78);
            Console.WriteLine(34);
            Console.WriteLine(-12);


            //Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Пользователь вводит число. Выведите на экран число, которое больше введенного на 10");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userNumber + 10);


            //Дана сторона квадрата. Найти его периметр.
            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Дана сторона квадрата. Найти его периметр");
            int squareSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(squareSide * 4);


            //Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.WriteLine("\nЗадание 6");
            Console.WriteLine("Дан радиус окружности. Найти длину окружности и площадь круга.");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Длина окружности: {radius * 2 * Math.PI}");
            Console.WriteLine($"Площадь круга: {radius * radius * Math.PI}");


            //Найти значение y=cos(x)
            Console.WriteLine("\nЗадание 7");
            Console.WriteLine("Найти значение y=cos(x)");
            int x_7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"y = {Math.Cos(x_7)}");



            //Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.WriteLine("\nЗадание 8");
            Console.WriteLine("Найти периметр трапеции");

            Console.WriteLine("Меньшее основание: ");
            int smallerOsn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Большее основание: ");
            int biggerOsn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Высота: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Периметр трапеции: {biggerOsn + smallerOsn + 2 * Math.Sqrt( Math.Pow(height, 2) + Math.Pow((biggerOsn - smallerOsn)/2, 2) )}");



            //Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,если купили x кг конфет, у кг печенья и z кг яблок.
            Console.WriteLine("\nЗадание 9");
            Console.WriteLine("Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки,\r\nесли купили x кг конфет, у кг печенья и z кг яблок.");

            Console.WriteLine("цена конфеты: ");
            int candyCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во конфет: ");
            int candysCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Цена печенья: ");
            int cookyCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во печенья: ");
            int cookysCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Цена яблок: ");
            int applesCost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во яблок: ");
            int applesCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Стоимость товаров {candyCost * candysCount + cookyCost * cookysCount + applesCost * applesCount}");


            //Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
            //(кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
            //Мир Труд Май
            //Затем так:
            //Мир
            //        Труд
            //                Май

            Console.WriteLine("\nЗадание 10");

            Console.Write("Мир");
            Console.Write("Труд");
            Console.Write("Май");
            Console.WriteLine($"Мир\n{"Труд", 10}\n{"Май", 16}");




            //Программа просит пользователя ввести 2 числовые переменные. А после она меняет их местами и выводит результат на экран. Но, так как пользователь может ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести, например, букву или строку, а так же учесть, что число может быть дробным, и для выделения её дробной части одни используют точку, другие – запятую.

            Console.WriteLine("\nЗадание 11");

            string firstNumber_11 = Console.ReadLine();
            string secondNumber_11 = Console.ReadLine();

            if (firstNumber_11.Contains("."))
            {
                firstNumber_11 = firstNumber_11.Replace(".", ",");
            } else if (secondNumber_11.Contains("."))
            {
                secondNumber_11 = secondNumber_11.Replace(".", ",");
            }

            if (double.TryParse(firstNumber_11, out double a1)  & double.TryParse(secondNumber_11, out double a2) )
            {

                Console.WriteLine("{1} {0}", a1, a2);
            } else
            {
                Console.WriteLine("Одно из введёных данных не является числом");
            }



            //Программа для подсчета периметра и площади фигур (треугольник, четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа будет считать – площадь или периметр.Задаётся все необходимые значения, а на основе полученных результатов, программа должна подсчитать, какими могли бы быть периметры или площади остальных фигур.
            Console.WriteLine("\nЗадание 12");

            Console.WriteLine("Выберите фигуру: треугольник, четырёхугольник, круг:");
            string obj = Console.ReadLine();

            switch (obj)
            {

                case "треугольник":
                    Console.WriteLine("Укажите стороны треугольника");
                    int a1_12 = Convert.ToInt32(Console.ReadLine());
                    int a2_12 = Convert.ToInt32(Console.ReadLine());
                    int a3_12 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("площадь или периметр?");
                    string triangeOperation = Console.ReadLine();
                    if (triangeOperation == "периметр")
                    {
                        Console.WriteLine(a1_12 + a2_12 + a3_12);
                    }
                    else
                    {
                        float halfPerimitr = (float)(a1_12 + a2_12 + a3_12) / 2;
                        Console.WriteLine(Math.Sqrt(halfPerimitr*(halfPerimitr- a1_12) *(halfPerimitr- a2_12) *(halfPerimitr- a3_12) ) );
                    }
                    break;

                case "четырёхугольник":
                    Console.WriteLine("Укажите стороны четырёхугольника");
                    int b1 = Convert.ToInt32(Console.ReadLine());
                    int b2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("площадь или периметр?");
                    string QuadrangleOperation = Console.ReadLine();
                    if (QuadrangleOperation == "периметр")
                    {
                        Console.WriteLine((b1 + b2) * 2);
                    }
                    else
                    {
                        Console.WriteLine(b1 * b2);
                    }
                    break;
                case "круг":
                    Console.WriteLine("Укажите радиус круга");
                    int r = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("площадь или периметр?");
                    string operation = Console.ReadLine();
                    if (operation == "периметр")
                    {
                        Console.WriteLine(2 * Math.PI * r);
                    }
                    else
                    {
                        Console.WriteLine(Math.PI * r * r);
                    }
                    break;
            }



            //Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому числу должно предшествовать сообщение «Вы ввели число».
            Console.WriteLine("\nЗадание 13");

            Console.WriteLine($"Вы ввели число: {Console.ReadLine()}");




            // Составить программу вывода на экран следующей информации: 2кг 13 17
            Console.WriteLine("\nЗадание 14");

            Console.WriteLine("2кг");
            Console.WriteLine("13 17");



            //Составить программу вывода на экран «столбиком» четырех случайных чисел.
            Console.WriteLine("\nЗадание 15");

            Random random = new Random();

            Console.WriteLine(random.Next(1, 100));
            Console.WriteLine(random.Next(1, 100));
            Console.WriteLine(random.Next(1, 100));
            Console.WriteLine(random.Next(1, 100));




            //Найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)

            Console.WriteLine("\nЗадание 16");

            Console.WriteLine("Enter the coefficients:");
            float a = Convert.ToInt32(Console.ReadLine());
            float b = Convert.ToInt32(Console.ReadLine());
            float c = Convert.ToInt32(Console.ReadLine());
            if (a != 0)
            {
                double Discriminant = b * b - 4 * a * c;
                double x1 = (-b + Math.Sqrt(Discriminant)) / 2 * a;
                double x2 = (-b - Math.Sqrt(Discriminant)) / 2 * a;
                Console.WriteLine($"First result {x1}");
                Console.WriteLine($"Second result {x2}");
            }
            else if (b != 0)
            {
                float x = c / b;
                Console.WriteLine($"Result {x}");
            }
            else
            {
                Console.WriteLine($"Result {c}");
            }


            //Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
            Console.WriteLine("\nЗадание 17");

            int firstNumber_17 = Convert.ToInt32(Console.ReadLine());
            int secondNumber_17 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Среднее арифмитическое: {(firstNumber_17 + secondNumber_17) / 2}");
            Console.WriteLine($"Среднее геометрическое: {Math.Sqrt(firstNumber_17 * secondNumber_17)}");



            //Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.
            Console.WriteLine("\nЗадание 18");

            Console.Write("X1: ");
            int x1_18 = Convert.ToInt32(Console.ReadLine());

            Console.Write("X2: ");
            int x2_18 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y1: ");
            int y1_18 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Y2: ");
            int y2_18 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Растояние между двумя точками: {Math.Sqrt( Math.Pow(x2_18 - x1_18, 2) + Math.Pow(y2_18 - y1_18, 2))}");




            //Составить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам:

            Console.WriteLine("\nЗадание 19");

            int a1_19 = 4;
            int b1_19 = 5;
            int c1_19 = 7;

            Console.WriteLine("Пункт а до преобразований: {0} {1} {2}", a1_19, b1_19, c1_19);

            int a2_19 = 4;
            int b2_19 = 5;
            int c2_19 = 7;

            Console.WriteLine("Пункт b до преобразований: {0} {1} {2}", a2_19, b2_19, c2_19);



            (a1_19, b1_19, c1_19) = (b1_19, c1_19, a1_19);
            (a2_19, b2_19, c2_19) = (c2_19, a2_19, b2_19);

            Console.WriteLine("Пункт а после преобразований: {0} {1} {2}", a1_19, b1_19, c1_19);
            Console.WriteLine("Пункт а после преобразований: {0} {1} {2}", a2_19, b2_19, c2_19);




            //С начала суток прошло n секунд. Определить:
            //а) сколько полных часов прошло с начала суток;
            //б) сколько полных минут прошло с начала очередного часа;
            //в) сколько полных секунд прошло с начала очередной минуты.

            Console.WriteLine("\nЗадание 20");

            int seconds = Convert.ToInt32(Console.ReadLine());
            int minutes = seconds / 60;
            int hours = minutes / 60;

            Console.WriteLine($"С начала суток прошло {hours} часов {minutes} минут {seconds % 60} секунд");





            //Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?

            Console.WriteLine("\nЗадание 21");

            int x_21 = 543;
            int y_21 = 130;
            Console.WriteLine($"От прямоугольника можно отрезать {(x_21 / 130) * (y_21 / 130)}");




            //Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале.Найти полученное число.

            Console.WriteLine("\nЗадание 22");

            int number_22 = Convert.ToInt32(Console.ReadLine());

            int hundreds_22 = number_22 / 100;
            int tens_22 = (number_22 / 10) % 10;
            int units_22 = number_22 % 10;

            Console.WriteLine($"{units_22}{hundreds_22}{tens_22}");




            //Дано натуральное число n (n > 999). Найти:
            //а) число сотен в нем;
            //б) число тысяч в нем.

            Console.WriteLine("\nЗадание 23");

            int number_23 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Тысячи: {number_23 / 1000} \nСотни: {(number_23 / 100) % 10}");




            //Дано четырехзначное число. Найти:
            //а) число, полученное при прочтении его цифр справа налево;
            //б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
            //заданного числа.Например, из числа 5434 получить 4543, из числа 7048 — 784;
            //в) число, образуемое при перестановке второй и третьей цифр заданного числа.
            //Например, из числа 5084 получить 5804;
            //г) число, образуемое при перестановке двух первых и двух последних цифр
            //заданного числа.Например, из числа 4566 получить 6645, из числа 7304 — 473.

            Console.WriteLine("\nЗадание 24");

            int number_24 = Convert.ToInt32(Console.ReadLine());

            int thousands_24 = number_24 / 1000;
            int hundreds_24 = (number_24 / 100) % 10;
            int tens_24 = (number_24 / 10) % 10;
            int units_24 = number_24 % 10;

            Console.WriteLine($"a) {Convert.ToInt32($"{units_24}{tens_24}{hundreds_24}{thousands_24}")}");
            Console.WriteLine($"б) {Convert.ToInt32($"{hundreds_24}{thousands_24}{units_24}{tens_24}")}");
            Console.WriteLine($"в) {Convert.ToInt32($"{thousands_24}{tens_24}{hundreds_24}{units_24}")}");
            Console.WriteLine($"г) {Convert.ToInt32($"{tens_24}{units_24}{thousands_24}{hundreds_24}")}");


            //Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили на 10,
            //а к частному слева приписали последнюю цифру числа x, то получилось
            //число n. Найти число x.Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом
            //число десятков в n не равно нулю.

            Console.WriteLine("\nЗадание 25");

            int number_25 = Convert.ToInt32(Console.ReadLine());
            int units_25 = number_25 % 10;

            Console.WriteLine($"{units_25}{(number_25 - units_25)/10}");

            


            //Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
            //времени: «h часов, m минут, s секунд». Определить угол(в градусах) между
            //положением часовой стрелки в начале суток и в указанный момент времени.

            Console.WriteLine("\nЗадание 26");

            Console.Write("Введите часы (0 <= h <= 23): ");
            int hours_26 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите минуты (0 <= m <= 59): ");
            int minutes_26 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите секунды (0 <= s <= 59): ");
            int seconds_26 = Convert.ToInt32(Console.ReadLine());

            int hoursDegree;

            if (hours_26 - 12 >= 0)
            {
                hoursDegree = (hours_26 - 12) * 30;
            }
            else
            {
                hoursDegree = 360 + (hours_26 - 12) * 30;
            }

            float minutesDegree = (float)minutes_26 / 2;
            float secondDegree = (float)seconds_26 / 120;

            Console.WriteLine($"Угол равен: {(hoursDegree + minutesDegree + secondDegree)}");


            

            //27. Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
            //соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2.Определить значение угла для
            //минутной стрелки, а также количество полных часов и полных минут.

            Console.WriteLine("\nЗадание 27");

            Console.Write("значение угла в радианах (0 <= y <= 2): ");
            decimal degrees_27 = Convert.ToDecimal(Console.ReadLine()) * (decimal)57.3;

            decimal hours_27 = Math.Floor(degrees_27 / 30);
            decimal minutesDegree_27 = degrees_27 - 30 * hours_27;

            Console.WriteLine($"Значение угла: {minutesDegree_27} \nКол-во полных часов: {hours_27} \nКол-во полных минут: {minutesDegree_27 * 2}");

            

            //Создать программу, которая будет выводить на экран меньшее по модулю из трёх
            //введённых пользователем вещественных чисел

            Console.WriteLine("\nЗадание 28");

            Console.WriteLine("Введите три вещественных числа: ");

            decimal number1_28 = Convert.ToDecimal(Console.ReadLine());
            decimal number2_28 = Convert.ToDecimal(Console.ReadLine());
            decimal number3_28 = Convert.ToDecimal(Console.ReadLine());

            decimal minNumber;

            if (Math.Abs(number1_28) <= Math.Abs(number2_28) && Math.Abs(number1_28) <= Math.Abs(number3_28))
            {
                minNumber = (decimal)number1_28;
            }
            else if (Math.Abs(number2_28) <= Math.Abs(number1_28) && Math.Abs(number2_28) <= Math.Abs(number3_28))
            {
                minNumber = (decimal)number2_28;
            }
            else
            {
                minNumber = (decimal)number3_28;
            }

            Console.WriteLine($"Минимальное по модулю число: {minNumber}");



            //Найти сумму большего и меньшего из трёх заданных чисел

            Console.WriteLine("\nЗадание 29");

            Console.WriteLine("Введите три числа: ");
            decimal number1_29 = Convert.ToDecimal(Console.ReadLine());
            decimal number2_29 = Convert.ToDecimal(Console.ReadLine());
            decimal number3_29 = Convert.ToDecimal(Console.ReadLine());

            decimal minNumber_29 = Math.Min(Math.Min(number1_29, number2_29), Math.Min(number2_29, number3_29));
            decimal maxNumber_29 = Math.Max(Math.Max(number1_29, number2_29), Math.Max(number2_29, number3_29));

            Console.WriteLine(minNumber_29 + maxNumber_29);



            //Подсчитать общее количество делителей натурального числа

            Console.WriteLine("\nЗадание 30");

            Console.WriteLine("Введите число: ");
            int number_30 = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= number_30; i++)
            {
                if (number_30 % i == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Кол-во делителей: {count}(с учётом 1 и самого числа)");



            //Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
            //вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
            //уравнений вида A* X3 +B * X2 + C * X + D = 0.На факультативе по математике Васе
            //задали решить около ста уравнений как раз такого вида.Но, к сожалению, Вася
            //забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все
            //корни уравнений – целые числа и находятся на отрезке[-100, 100]. Поэтому у Васи
            //есть шанс найти их методом перебора, но для этого ему придется затратить уйму
            //времени, т.к.возможно необходимо будет осуществить перебор нескольких тысяч
            //значений.Помогите Васе написать программу, которая поможет ему найти корни
            //кубических уравнений!


            Console.WriteLine("\nЗадание 31");

            Console.WriteLine("Введите коэфиценты квадратного уравнения");
            int a_31 = Convert.ToInt32(Console.ReadLine());
            int b_31 = Convert.ToInt32(Console.ReadLine());
            int c_31 = Convert.ToInt32(Console.ReadLine());
            int d_31 = Convert.ToInt32(Console.ReadLine());


            for (int i = -100; i <= 100; i++)
            {
                if ((a_31*i*i*i + b_31*i*i + c_31*i + d_31) == 0)
                {
                    Console.WriteLine($"Решение в вещественных числах: {i}");
                }
            }


            //Заданы первый и второй элементы арифметической прогрессии. Требуется
            //написать программу, которая вычислит элемент прогрессии по ее номеру.

            Console.WriteLine("\nЗадание 32");

            Console.WriteLine("Введите первый и второй элемент прогрессии: ");
            int a_32 = Convert.ToInt32(Console.ReadLine());
            int b_32 = Convert.ToInt32(Console.ReadLine());

            int d_32 = b_32 - a_32;


            Console.WriteLine("Введите номер последовательности который вы хотите знать");
            int n_32 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Элемент под номером {n_32}: {a_32 + d_32*(n_32-1)}");



            //Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
            //трудоустроен не получаю кредит. Ну а если я, и пенсионер и
            //студент,(трудоустройство тут не имеет значения) то не должен получить.
            //Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
            //или кто-то ещё.Вывести информацию: дадут кредит или нет.

            Console.WriteLine("\nЗадание 33");

            bool isOld = false;
            bool isStudent = false;
            bool isWorker = false;

            Console.WriteLine("Вы пенсионер? да/нет");
            string old_33 = Console.ReadLine();

            Console.WriteLine("Вы студент? да/нет");
            string student_33 = Console.ReadLine();

            Console.WriteLine("Вы трудоустроен? да/нет");
            string worker_33 = Console.ReadLine();

            if (old_33 == "да")
            {
                isOld = true;
            }
            if (student_33 == "да")
            {
                isStudent = true;
            }
            if (worker_33 == "да")
            {
                isWorker = true;
            }

            if (isWorker || (isStudent && isOld))
            {
                Console.WriteLine("Вам кредит не положен");
            }
            else
            {
                Console.WriteLine("Вы можете взять кредит");
            }

            

            //Составить программу, которая:
            //а) запрашивает имя человека и повторяет его на экране;
            //б) запрашивает имя человека и повторяет его на экране с приветствием.

            Console.WriteLine("\nЗадание 34");

            Console.WriteLine("Как вас зовут?");
            string name_34 = Console.ReadLine();

            Console.WriteLine(name_34);
            Console.WriteLine($"Привет {name_34}");

            

            //Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с
            //консолью.Консоль спрашивает, как зовут пользователя. Пользователь называет
            //имя.Консоль пишет: привет, < имя пользователя >.После этого пользователь
            //спрашивает, знает ли консоль что-то о тайной комнате.Консоль отвечает «Да».
            //После этого пользователь спрашивает, может ли рассказать. Консоль отвечает
            //«Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет
            //цвет на любой случайный цвет.

            Console.WriteLine("\nЗадание 35");

            Console.ReadLine();
            Console.WriteLine("Как тебя зовут");
            string name_35 = Console.ReadLine();
            Console.WriteLine($"привет, {name_35}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Но могу показать");
            


            //Вычислить контрольную цифру штрихкода(EAN13).
            // 12 цифр определяются случайным образом.
            // 12 цифр вводит пользователь

            Console.WriteLine("\nЗадание 36");


            string randomNumbers = "";
            string userNumbers = "";

            Console.WriteLine("Введите 12 цифр");
            for (int i = 0; i < 12; i++)
            {
                randomNumbers += random.Next(0, 9);
                userNumbers += Console.ReadLine();
            }

            Console.WriteLine($"контрольная цифра штрихкода(EAN13): {randomNumbers + userNumbers}");

            Console.ReadKey();
        }
    }
}