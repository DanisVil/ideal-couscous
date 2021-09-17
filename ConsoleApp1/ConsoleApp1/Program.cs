using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S1.1");
            Console.WriteLine("{0:F2}", 888.8888124);

            Console.WriteLine("S1.2");
            Console.WriteLine("{0:F1}", Math.E);

            Console.WriteLine("S1.3");
            Console.WriteLine("Введите число:");
            double inputs13 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы ввели число {0}", inputs13);

            Console.WriteLine("S1.4");
            Console.WriteLine("Введите число:");
            double inputs14 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} - вот такое число Вы ввели", inputs14);

            Console.WriteLine("S1.5");
            Console.WriteLine("{0} {1} {2}", 1, 13, 49);

            Console.WriteLine("S1.6");
            Console.WriteLine("{0}  {1}  {2}", 7, 15, 100);

            var rand = new Random();
            Console.WriteLine("S1.7");
            Console.WriteLine("{0}  {1}  {2}", rand.Next(101), rand.Next(101), rand.Next(101));

            Console.WriteLine("S1.8");
            Console.WriteLine("{0} {1} {2} {3}", rand.Next(101), rand.Next(101), rand.Next(101), rand.Next(101));

            Console.WriteLine("S1.9");
            Console.WriteLine(50);
            Console.WriteLine(10);

            Console.WriteLine("S1.10");
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);

            Console.WriteLine("S1.11");
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine(rand.Next(101));
            }

            Console.WriteLine("S1.12");
            Console.WriteLine("5 10");
            Console.WriteLine("7 см");

            Console.WriteLine("S1.13");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine("S2.1a");
            Console.WriteLine("Введите значение х:");
            double inputs21a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y = 7x^2 + 3x + 6 = {0}", 7 * inputs21a * inputs21a + 3 * inputs21a + 6);

            Console.WriteLine("S2.1b");
            Console.WriteLine("Введите значение а:");
            double inputs21b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x = 12a^2 + 7a + 12 = {0}", 12 * inputs21b * inputs21b + 7 * inputs21b + 12);

            Console.WriteLine("S2.2");
            Console.WriteLine("Введите длину стороны квадрата:");
            double square_side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Периметр квадрата равен {0}", 4 * square_side);

            Console.WriteLine("S2.3");
            Console.WriteLine("Введите радиус окружности:");
            double circle_radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Диаметр окружности равен {0}", 2 * circle_radius);

            Console.WriteLine("S2.4");
            Console.WriteLine("Введите высоту в км:");
            double height_above_earth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расстояние до линии горизонта равно {0} км", Math.Sqrt((6350 + height_above_earth) * (6350 + height_above_earth) - 40322500));

            Console.WriteLine("S2.5");
            Console.WriteLine("Введите длину ребра куба:");
            double cube_edge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Объём куба равен {0}, площадь боковой поверхности - {1}", cube_edge * cube_edge * cube_edge, 4 * cube_edge * cube_edge);

            Console.WriteLine("S2.6");
            Console.WriteLine("Введите радиус:");
            circle_radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности - {0}, площадь - {1}", 2 * Math.PI * circle_radius, Math.PI * circle_radius * circle_radius);

            Console.WriteLine("S2.7");
            Console.WriteLine("Введите число а:");
            int inputs27a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            int inputs27b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Среднее арифметическое а и b равно {0}, среднее геометрическое - {1}", ((float)inputs27a + inputs27b) / 2, Math.Sqrt(inputs27a * inputs27b));

            Console.WriteLine("S2.8");
            Console.WriteLine("Введите массу тела:");
            float mass = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите объём тела:");
            float volume = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Плотность материала тела равна {0}", mass / volume);

            Console.WriteLine("S2.9");
            Console.WriteLine("Введите население страны:");
            double population = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите площадь страны:");
            double country_area = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Плотность населения страны - {0}", population / country_area);

            Console.WriteLine("S2.10");
            Console.WriteLine("Введите а:");
            float inputs210a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите b:");
            float inputs210b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Решением уравнения ax + b = 0 является x = {0}", -inputs210b / inputs210a);

            Console.WriteLine("S2.11");
            Console.WriteLine("Введите длину первого катета:");
            float cathetus1 = Convert.ToSingle(Console.ReadLine()); //susඞ
            Console.WriteLine("Введите длину второго катета:");
            float cathetus2 = (float)Convert.ToDouble(Console.ReadLine()); //THE SECOND SUS?!?!?!ඞඞඞඞඞඞ
            Console.WriteLine("Длина гипотенузы: {0}", Math.Sqrt(cathetus1 * cathetus1 + cathetus2 * cathetus2)); //too much sus...ඞඞඞඞඞඞ                 ඞ Hypotenuse was not an imposter...

            Console.WriteLine("S2.12");
            Console.WriteLine("Введите радиус внешней окружности:");
            float outer_circle_radius = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите радиус внутренней окружности:");
            float inner_circle_radius = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Площадь кольца равна {0}", Math.Abs(Math.PI * (outer_circle_radius * outer_circle_radius - inner_circle_radius * inner_circle_radius)));

            Console.WriteLine("S2.13");
            Console.WriteLine("Введите длину первого катета:");
            cathetus1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите длину второго катета:");
            cathetus2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Периметр = {0}", Math.Sqrt(cathetus1 * cathetus1 + cathetus2 * cathetus2) + cathetus1 + cathetus2);

            Console.WriteLine("S2.13A");
            Console.WriteLine("Введите первое число:");
            float inputs213a = Math.Abs((float)(double)Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Введите второе число:");
            float inputs213b = Math.Abs((float)(double)(float)(double)Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Среднее арифметическое |а| и |b| равно {0}, среднее геометрическое - {1}", (inputs213a + inputs213b) / 2, Math.Sqrt(inputs213a * inputs213b));

            Console.WriteLine("S2.14");
            Console.WriteLine("Введите длину нижнего основания трапеции:");
            float trapezoid_base1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите длину верхнего основания трапеции:");
            float trapezoid_base2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите высоту трапеции:");
            float trapezoid_height = Convert.ToSingle(Console.ReadLine());
            float trapezoid_side = (float)Math.Sqrt(trapezoid_height * trapezoid_height + (trapezoid_base1 - trapezoid_base2) * (trapezoid_base1 - trapezoid_base2) / 4);
            Console.WriteLine("Периметр трапеции равен {0}", trapezoid_base1 + trapezoid_base2 + 2 * trapezoid_side);

            Console.WriteLine("S2.14A");
            Console.WriteLine("Введите сторону прямоугольника:");
            float rectangle_a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите другую сторону прямоугольника:");
            float rectangle_b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Периметр прямоугольника равен {0}, длина диагонали - {1}", 2 * (rectangle_a + rectangle_b), Math.Sqrt(rectangle_a * rectangle_a + rectangle_b * rectangle_b));

            Console.WriteLine("S2.15");
            Console.WriteLine("Введите число а:");
            float inputs215a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            float inputs215b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Сумма = {0}, разность = {1}, произведение = {2}, частное от деления = {3}", inputs215a + inputs215b, inputs215a - inputs215b, inputs215a * inputs215b, inputs215a % inputs215b);

            Console.WriteLine("S2.16");
            Console.WriteLine("Введите сторону основания:");
            float inputs216a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону основания:");
            float inputs216b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите высоту:");
            float inputs216h = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("V = {0}, Sбок = {1}", inputs216a * inputs216b * inputs216h, 2 * inputs216h * (inputs216a + inputs216b));

            Console.WriteLine("S2.17");
            Console.WriteLine("Введите х1:");
            double inputs217x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            double inputs217y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х2:");
            double inputs217x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            double inputs217y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расстояние = {0}", Math.Sqrt((inputs217x1 - inputs217x2) * (inputs217x1 - inputs217x2) + (inputs217y1 - inputs217y2) * (inputs217y1 - inputs217y2)));

            Console.WriteLine("S2.18");
            Console.WriteLine("Повтор S2.14");

            Console.WriteLine("S2.19");
            Console.WriteLine("Введите длину нижнего основания трапеции:");
            trapezoid_base1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите длину верхнего основания трапеции:");
            trapezoid_base2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите угол при большем основании (в градусах):");
            float trapezoid_angle = (float)Math.PI * Convert.ToSingle(Console.ReadLine()) / 180;
            trapezoid_height = (float)(Math.Abs(trapezoid_base1 - trapezoid_base2) * Math.Tan(trapezoid_angle) / 2);
            Console.WriteLine("Площадь равна {0}", 0.5 * (trapezoid_base1 + trapezoid_base2) * trapezoid_height);

            Console.WriteLine("S2.20");
            Console.WriteLine("Введите х1:");
            double inputs220x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            double inputs220y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х2:");
            double inputs220x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            double inputs220y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х3:");
            double inputs220x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y3:");
            double inputs220y3 = Convert.ToDouble(Console.ReadLine());
            double s220a = Distance(inputs220x1, inputs220y1, inputs220x2, inputs220y2);
            double s220b = Distance(inputs220x2, inputs220y2, inputs220x3, inputs220y3);
            double s220c = Distance(inputs220x1, inputs220y1, inputs220x3, inputs220y3);
            double s220perimetr = s220a + s220b + s220c;
            double s220area = Herone(s220a, s220b, s220c);
            Console.WriteLine("Периметр - {0}, площадь - {1}", s220perimetr, s220area);

            Console.WriteLine("S2.21");
            Console.WriteLine("Введите х1:");
            double inputs221x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y1:");
            double inputs221y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х2:");
            double inputs221x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y2:");
            double inputs221y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х3:");
            double inputs221x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y3:");
            double inputs221y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите х4:");
            double inputs221x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y4:");
            double inputs221y4 = Convert.ToDouble(Console.ReadLine());
            double s221a = Distance(inputs221x1, inputs221y1, inputs221x2, inputs221y2);
            double s221b = Distance(inputs221x2, inputs221y2, inputs221x3, inputs221y3);
            double s221c = Distance(inputs221x3, inputs221y3, inputs221x4, inputs221y4);
            double s221d = Distance(inputs221x1, inputs221y1, inputs221x4, inputs221y4);
            double s221diagonale = Distance(inputs221x1, inputs221y1, inputs221x3, inputs221y3);
            double s221perimetr = s221a + s221b + s221c + s221d;
            double s221area = Herone(s221a, s221b, s221diagonale) + Herone(s221c, s221d, s221diagonale);
            Console.WriteLine("Периметр - {0}, площадь - {1}", s221perimetr, s221area);

            Console.WriteLine("S2.22");
            Console.WriteLine("Введите вес конфет в кг:");
            double candy_weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену конфет за кг:");
            double candy_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес печенья в кг:");
            double cookie_weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену печенья за кг:");
            double cookie_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес яблок в кг:");
            double apple_weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену яблок за кг:");
            double apple_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Стоимость покупки {0} руб.", candy_weight * candy_price + cookie_weight * cookie_price + apple_weight * apple_price);

            Console.WriteLine("S2.23");
            Console.WriteLine("Введите цену монитора:");
            double monitor_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену системного блока:");
            double pc_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену клавиатуры:");
            double keybord_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену мышь:");
            double mouse_price = Convert.ToDouble(Console.ReadLine());
            double full_complect_price = monitor_price + pc_price + keybord_price + mouse_price;
            Console.WriteLine("Цена 3-х компьютеров равна {0} руб.", 3 * full_complect_price);
            Console.WriteLine("Введите количество компьютеров:");
            int pc_count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Итоговая цена {0} руб.", full_complect_price * pc_count);

            Console.WriteLine("S2.24");
            Console.WriteLine("Введите возраст Тани:");
            int tanya_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите возраст Мити:");
            int mitya_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Средний возраст - {0}, возраст каждого ребенка отличается от среднего на {1}", (float)(tanya_age + mitya_age) / 2, (float)Math.Abs(tanya_age - mitya_age) / 2);

            Console.WriteLine("S2.25");
            Console.WriteLine("Введите V1:");
            double s225v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите V2:");
            double s225v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите S:");
            double s225s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Автомобили встретятся через {0} час(а/ов)", s225s / (s225v1 + s225v2));

            Console.WriteLine("S2.26");
            Console.WriteLine("Введите V1:");
            double s226v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите V2:");
            double s226v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите S:");
            double s226s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расстояние равно {0} км", s226s + Math.Abs(s226v1 - s226v2) / 2);

            Console.WriteLine("S2.27");
            Console.WriteLine("Введите температуру по шкале Цельсия:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Температура по шкале Фаренгейта {0}, Кельвина - {1}", celsius * 1.8 + 32, celsius + 273.15);

            Console.WriteLine("S2.28");
            double farenheitus = 451;
            Console.WriteLine("{0} градусов по Цельсию", 5 * (farenheitus - 32) / 9);

            //S3.1
            int s31a = 1;
            int s31b = 2;
            int s31c = s31a;
            s31a = s31b;
            s31b = s31c;

            //S3.2 a
            int s321a = 1;
            int s321b = 2;
            int s321c = 3;
            int s321temp1 = s321a;
            int s321temp2 = s321b;
            int s321temp3 = s321c;
            s321b = s321temp3;
            s321a = s321temp2;
            s321c = s321temp1;

            //S3.2 b
            int s322a = 1;
            int s322b = 2;
            int s322c = 3;
            int s322temp1 = s322a;
            int s322temp2 = s322b;
            int s322temp3 = s322c;
            s322b = s322temp1;
            s322c = s322temp2;
            s322a = s322temp3;

            //S3.3
            int power = 2;
            //a
            int power2 = power * power;
            int power4 = power2 * power2;
            //б /b/
            int power6 = power4 * power2;
            //в
            int power7 = power6 * power;
            //г
            int power8 = power4 * power4;
            //д
            int power9 = power8 * power;
            //e
            int power5 = power4 * power;
            int power10 = power5 * power5;

            //S3.4
            //a
            int d = 2;
            int d2 = d * d;
            int d3 = d2 * d;
            int d5 = d3 * d2;
            int d10 = d5 * d5;
            //б
            int o = 2;
            int o2 = o * o;
            int o4 = o2 * o2;
            int o8 = o4 * o4;
            int o16 = o8 * o8;
            int o20 = o16 * o4;
            //в
            int n = 2;
            int n2 = n * n;
            int n3 = n2 * n;
            int n5 = n3 * n2;
            int n10 = n5 * n5;
            int n13 = n10 * n3;
            //г
            int m = 2;
            int m2 = m * m;
            int m3 = m * m2;
            int m5 = m3 * m2;
            int m8 = m5 * m3;
            int m16 = m8 * m8;
            int m19 = m16 * m3;
            //д
            int q = 2;
            int q2 = q * q;
            int q3 = q2 * q;
            int q5 = q2 * q3;
            int q8 = q5 * q3;
            int q16 = q8 * q8;
            int q17 = q16 * q;
            //e
            int u = 2;
            int u2 = u * u;
            int u4 = u2 * u2;
            int u8 = u4 * u4;
            int u12 = u8 * u4;
            int u24 = u12 * u12;
            int u28 = u24 * u4;

            //S3.5
            int magic = 1010;
            int sum = 0;
            while (magic > 0)
            {
                sum += magic % 10;
                magic /= 10;
            }
            magic = sum;
            Console.WriteLine(magic);

            Console.WriteLine("task2.1");
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Здравствуй, " + name + "!");

            Console.WriteLine("task2.2");

            double a, b;
            Console.WriteLine("Введите делимое:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите делитель:");
            b = Convert.ToDouble(Console.ReadLine());
            if (b != 0)
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
            }

            Console.WriteLine("HomeTask2.1");
            char[] killrillica = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.WriteLine("Write letter:");
            char letter = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            int serial_number = Array.FindIndex(killrillica, i => i == letter);
            if (serial_number < 25)
            {
                Console.WriteLine("Next letter is {0}", killrillica[serial_number + 1]);
            }
            else
            {
                Console.WriteLine("This is the last letter");
            }

            Console.WriteLine("HomeTask2.2");
            Console.WriteLine("Введите а");
            double a_koef = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b_koef = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c_koef = Convert.ToDouble(Console.ReadLine());
            double discriminant = b_koef * b_koef - 4 * a_koef * c_koef;
            if (discriminant >= 0)
            {
                Console.WriteLine("x1 = {0}", (- b_koef - Math.Sqrt(discriminant)) / 2 / a_koef);
                Console.WriteLine("x2 = {0}", (-b_koef + Math.Sqrt(discriminant)) / 2 / a_koef);
            }
            else
            {
                Console.WriteLine("Нет действительный решений");
            }

            Console.ReadKey();
        }
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }

        static double Herone(double a, double b, double c)
        {
            double p = 0.5 * (a + b + c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
