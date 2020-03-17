using System;
using System.Collections.Generic;
using System.Text;

public class Game
{
    public void Game1()
    {
        string name;

        Console.WriteLine("Вы попали в игру про программиста");
        Console.Write("Введите ваше имя: ");
        name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Вы " + name + ", попали в интересную игру!");
        Console.WriteLine("Нажмите любую клавишу");
        Console.ReadKey();
        Console.Clear();
    }

    public void About()
    {
        Console.Clear();
        Console.WriteLine("Разработчик игры я STEEL");
        Console.WriteLine("©2019 Компания ORANGE© SoftWare");
    }

    public void Menu()
    {
        int input = 3;

        switch(input)
        {
            case 3:
                DisplayMenu();
                break;
        }
    }

    public void Unload()
    {
        int choice;
        bool exit = false  ;
        do
        {
            choice = Convert.ToInt32(Console.ReadLine());

        }while (exit);
    }

    public void DisplayMenu()
    {
        //code
        Console.Clear();
        Console.WriteLine("1. Игра");
        Console.WriteLine("2. Разработчики");
        Console.WriteLine("3. Меню");
        Console.WriteLine("0. Выход");

        int choice;
        do
        {
            Console.Write("Введите выбор [0-3]: "); // постоянное меню
            choice = Convert.ToInt32(Console.ReadLine()); //ввод меню

        } while (choice < 0 || choice > 3);

        switch(choice)
        {
            case 1:
                Game1();
                break;
            case 2:
                About();
                break;
            case 3:
                Menu();
                break;
            case 0:
                Unload();
                break;
        }
    }
}//конец класса