using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{ 

    class Program
{
    static void Main(string[] args)

    {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.Write("Введіть бренд комп'ютера: ");
        string brand = Console.ReadLine();

        Console.Write("Введіть модель комп'ютера: ");
        string model = Console.ReadLine();

        Console.Write("Введіть процесор: ");
        string processor = Console.ReadLine();

        Console.Write("Введіть об'єм оперативної пам'яті (ГБ): ");
        string sRAM = Console.ReadLine();

        Console.Write("Введіть об'єм накопичувача (ГБ): ");
        string sStorage = Console.ReadLine();

        Console.Write("Введіть ціну (у доларах): ");
        string sPrice = Console.ReadLine();

        Console.Write("Чи має комп'ютер дискретну відеокарту? (у-так, н-ні): ");
        ConsoleKeyInfo keyHasDedicatedGPU = Console.ReadKey();
        Console.WriteLine();

        Console.Write("Чи має комп'ютер сенсорний екран? (у-так, н-ні): ");
        ConsoleKeyInfo keyHasTouchscreen = Console.ReadKey();
        Console.WriteLine();

        Computer myComputer = new Computer();
        myComputer.Brand = brand;
        myComputer.Model = model;
        myComputer.Processor = processor;
        myComputer.RAM = int.Parse(sRAM);
        myComputer.Storage = int.Parse(sStorage);
        myComputer.Price = double.Parse(sPrice);
        myComputer.HasDedicatedGPU = keyHasDedicatedGPU.Key == ConsoleKey.Y ? true : false;
        myComputer.HasTouchscreen = keyHasTouchscreen.Key == ConsoleKey.Y ? true : false;

        double pricePerGB = myComputer.GetPricePerGB();

        Console.WriteLine();
        Console.WriteLine("Дані про комп'ютер:");
        Console.WriteLine("-------------------");
        Console.WriteLine("Бренд: " + myComputer.Brand);
        Console.WriteLine("Модель: " + myComputer.Model);
        Console.WriteLine("Процесор: " + myComputer.Processor);
        Console.WriteLine("Оперативна пам'ять: " + myComputer.RAM + " ГБ");
        Console.WriteLine("Накопичувач: " + myComputer.Storage + " ГБ");
        Console.WriteLine("Ціна: $" + myComputer.Price.ToString("0.00"));
        Console.WriteLine(myComputer.HasDedicatedGPU ? "Має дискретну відеокарту" : "Не має дискретної відеокарти");
        Console.WriteLine(myComputer.HasTouchscreen ? "Має сенсорний екран" : "Не має сенсорного екрану");
        Console.WriteLine();
        Console.WriteLine("Ціна за ГБ: $" + pricePerGB.ToString("0.00"));
        Console.ReadKey();
    }
}
}