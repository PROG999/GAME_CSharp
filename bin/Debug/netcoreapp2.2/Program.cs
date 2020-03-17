using System;
using System.Threading;


public class Game
{
    public void Print(string message)
    {
        foreach (var c in message)
        {
            Thread.Sleep(100);
            Console.Write(c);
        }
        Console.WriteLine();
    }

    public void Taxer()
    {
        string a;
        // сокращения
        Action<string> w = Console.WriteLine;
        Action<string> l = Console.Write;

        

        //code
        w("Вы выбрали игру 'Таксист!'");
        w("Ввидите ваше имя: ");
        string name = Convert.ToString(Console.ReadLine()); 
        if (String.IsNullOrWhiteSpace(name) == true) // Если переменная name имеет значение пустое (null) или "пробел", тогда будет true 
        { name = "Незнакомец"; } 
        w("Привет, " + name + ", добро пожаловать в игру!!!");
        w("нажмите любую клавишу для продолжения");
        Console.ReadKey();
        Console.Clear();
        w("Вы " + name + " живёте в конце 23 века");
        w("Вы таксист летающего такси");
        w("В прошлом лучший из спецназа,выживший из всего отряда");
        w("Вы поглядели в глазок двери,а там вымогатель ваши действия");
        l("Введите число от 0 до 4: ");
        a = Convert.ToString(Console.ReadLine());
        if (a == "0"){
            l("Вы открыли дверь и начали диалог с вымогателем у которого мощный ручной пулемёт\n");
        } else if (a != "1" && a != "2" && a != "3") {
            w("Вы растерялись и вызвали полицию");
            goto M;
        }

        l("Ввидите число от 0 до 2: ");
        a = Convert.ToString(Console.ReadLine());
        if (a == "1") {
            w("Вы обезоружили преступника лоха и добавили к своей коллекции ещё один экземпляр\nопасного оружия");
            goto G;
        } else if (a != "0" || a != "2") {
            w("Вас убили.Вы не смогли обезоружить вымогателя");
            goto F;
        }G:
        w("Нажмите любую клавишу");
        Console.ReadKey();
        Console.Clear();
        w(name + ",вы сели в свою машину такси и приятный женский голос поздоровался с вами");
        w("Для того чтобы завести машину нужно вставить права-карточку");
        l("Введите число от 5 до 9: ");
        a = Convert.ToString(Console.ReadLine());
        if (a == "6") {
            w(name + ",вы выехали из гаража, чудный денёк!");
        } else if (a != "0" || a != "1" || a != "2" || a != "3" || a != "4" || a != "5" || a != "7" || a != "8" || a != "9") {
            w("Права ваши просрочены вы остаётесь дома");
        }

        M: F:

        string choice; 
        do 
        { 
            l("Введите выбор [0-4]: "); 
            choice = Convert.ToString(Console.ReadLine()); 
        }while(choice == "0" && choice == "1" && choice == "2" && choice == "3" && choice == "4"); 
        switch(choice) 
        {
            case "0": 
              Taxer();
              break; 
            case "1": 
              Game1();
              break; 
            case "2": 
              About();
              break; 
            case "3": 
              Menu(); 
              break; 
            case "4":
              Unload(); 
              break; 
        }
    }

    public void Game1()
    {
        string name;
        Action<string> w = Console.WriteLine;
        Action<string> l = Console.Write;


        w("Вы попали в игру про программиста");
        l("Введите ваше имя: ");
        name = Convert.ToString(Console.ReadLine());
        w("Вы " + name + ", попали в интересную игру!");
        w("Нажмите любую клавишу");
        Console.ReadKey();
        Console.Clear();

        w("0. Таксист");
        w("1. Игра");
        w("2. Разработчики");
        w("3. Меню");
        w("4. Выход");

        string choice; 
        do 
        { 
            Console.Write("Введите выбор [0-4]: "); 
            choice = Convert.ToString(Console.ReadLine()); 
        }while(choice == "0" && choice == "1" && choice == "2" && choice == "3" && choice == "4"); 
        switch(choice) 
        {
            case "0": 
              Taxer();
              break; 
            case "1": 
              Game1();
              break; 
            case "2": 
              About();
              break; 
            case "3": 
              Menu(); 
              break; 
            case "4":
              Unload(); 
              break; 
        }
    }

    public void About()
    {
        Action<string> w = Console.WriteLine;
        Action<string> l = Console.Write;

        Console.Clear();
        w("Разработчик игры я STEEL");
        w("©2020 Компания ORANGE® SoftWare");
        w("Нажмите любую клавишу");
        Console.ReadKey();
        Console.Clear();

        w("0. Таксист");
        w("1. Игра");
        w("2. Разработчики");
        w("3. Меню");
        w("4. Выход");

        string choice; 
        do 
        { 
            Console.Write("Введите выбор [0-4]: "); 
            choice = Convert.ToString(Console.ReadLine()); 
        }while(choice == "0" && choice == "1" && choice == "2" && choice == "3" && choice == "4"); 
        switch(choice) 
        {
            case "0": 
              Taxer();
              break; 
            case "1": 
              Game1();
              break; 
            case "2": 
              About();
              break; 
            case "3": 
              Menu(); 
              break; 
            case "4":
              Unload(); 
              break; 
        }
    }

    public void Menu()
    {
        string input = "4";

        switch(input)
        {
            case "4":
                DisplayMenu();
                break;
        }
    }

    public void Unload()
    {
        string choice;
        bool exit = false  ;
        do
        {
            choice = Convert.ToString(Console.ReadLine());

        }while (exit);
    }

    public void DisplayMenu()
    {
        Action<string> w = Console.WriteLine;
        Action<string> l = Console.Write;

        //code
        Console.Clear();
        w("0. Таксист");
        w("1. Игра");
        w("2. Разработчики");
        w("3. Меню");
        w("4. Выход");

        string choice; 
        do 
        { 
            Console.Write("Введите выбор [0-4]: "); 
            choice = Convert.ToString(Console.ReadLine()); 
        }while(choice == "0" && choice == "1" && choice == "2" && choice == "3" && choice == "4"); 
        switch(choice) 
        {
            case "0": 
              Taxer();
              break; 
            case "1": 
              Game1();
              break; 
            case "2": 
              About();
              break; 
            case "3": 
              Menu(); 
              break; 
            case "4":
              Unload(); 
              break; 
        }
    }
}//конец класса