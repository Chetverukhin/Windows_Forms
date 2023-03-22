using System;
using System.Collections.Generic;
using System.Media;
using GameClassLibrary;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer congrats = new("Congrats.wav");

            MakeColorText(ConsoleColor.DarkYellow, "Вас приветствует программа по определению ваших интеллектуальных способностей");
            Console.Write("Давайте познакомимся. Введите ваше имя: ");

            string name;
            while (!Check.UserText(Console.ReadLine(), out name, out string error))
            {
                MakeColorText(ConsoleColor.Red, error);
            }

            User user = new(name);
            Game game = new(user);
            game.PrepareSources();

            Console.WriteLine($"Добрый день {game.user.Name}, рад знакомству!!!\n");

            while (true)
            {
                int userChoiseItemMenu = 0;

                MakeColorText(ConsoleColor.DarkYellow, $"{game.user.Name} Вы находитесь в главном меню программы\n");

                int nextAction = SelectItemMenu(ShowMainMenu(), userChoiseItemMenu);
                if (nextAction == (int)GameMenu.StartTest)
                {
                    while (true)
                    {
                        Console.Clear();
                        MakeColorText(ConsoleColor.DarkYellow, "Вы находитесь в меню тестирования\n");

                        nextAction = SelectItemMenu(ShowTestMenu(), userChoiseItemMenu);

                        if (nextAction == 0)
                        {
                            game.Start();
                            Console.Clear();
                            while (!game.End())
                            {
                                MakeColorText(ConsoleColor.Red, game.GetNumberTest(true));

                                Test newTest = game.GetNextTest();
                                Console.WriteLine(newTest.Question);

                                int userAnswer;

                                while (!Check.UserNumber(Console.ReadLine(), out userAnswer, out string error))
                                {
                                    MakeColorText(ConsoleColor.Red, error);
                                }
                                game.AcceptAnswer(userAnswer);
                            }
                            congrats.Play();

                            User newUser = new(game.user.Name);
                            game.SaveUserResults(newUser);

                            MakeColorText(ConsoleColor.DarkYellow, $"\nВы ответили правильно на: {game.user.QuantityRightAnswers} вопросов");
                            MakeColorText(ConsoleColor.Red, $"{game.user.Name} Ваш диагноз: {game.user.Diagnosis}\n");

                            Console.Write("Чтобы вернуться в меню тестирования нажмите любую клавишу");
                            Console.ReadLine();
                        }
                        if (nextAction == 1) { Console.Clear(); break; }
                    }
                }
                else if (nextAction == (int)GameMenu.ShowDetailsResults)
                {
                    while (true)
                    {
                        ShowDetailsResults(game.GetDetailsResults());
                        nextAction = SelectItemMenu(ShowResultsMenu(), userChoiseItemMenu);

                        if (nextAction == 0)
                        {
                            game.ClearAllResults();
                            continue;
                        }
                        if (nextAction == 1)
                        {
                            Console.Clear(); break;
                        }
                    }
                }
                else if (nextAction == (int)GameMenu.ShowTopResults)
                {
                    while (true)
                    {
                        ShowDetailsResults(game.GetSummaryResults());
                        nextAction = SelectItemMenu(ShowResultsMenu(), userChoiseItemMenu);

                        if (nextAction == 0)
                        {
                            game.ClearAllResults();
                            continue;
                        }
                        if (nextAction == 1)
                        {
                            Console.Clear(); break;
                        }
                    }
                }
                else if (nextAction == (int)GameMenu.AddTest)
                {
                    while (true)
                    {
                        Console.Clear();
                        MakeColorText(ConsoleColor.DarkYellow, $"Вы находитесь в меню добавления тестов\n");
                        nextAction = SelectItemMenu(ShowAddTestMenu(), userChoiseItemMenu);

                        if (nextAction == 0)
                        {
                            AddTestToBase(game);
                            Console.Write("Чтобы вернуться в меню добавления тестов нажмите любую клавишу");
                            Console.ReadLine();
                        }
                        if (nextAction == 1) { Console.Clear(); break; }
                    }
                }
                else if (nextAction == (int)GameMenu.DeleteTest)
                {
                    while (true)
                    {
                        ShowTestsList(game.GetTestsData());
                        nextAction = SelectItemMenu(ShowDeletTestMenu(), userChoiseItemMenu);

                        if (nextAction == 0) { DeleteTestFromBase(game); }
                        if (nextAction == 1) { Console.Clear(); break; }
                    }
                }
                else if (nextAction == (int)GameMenu.Exit)
                {
                    game.Save();
                    break;
                }
                else Console.Clear();
            }
        }
        enum GameMenu
        {
            StartTest,
            ShowDetailsResults,
            ShowTopResults,
            AddTest,
            DeleteTest,
            Exit
        }
        static void ShowDetailsResults(List<User> usersData)
        {
            Console.Clear();
            string format = "| {0,4} | {1,-30} | {2,30} | {3,30} | {4,30:P1} | {5,10} |";
            PrintResultsTitle(format, ConsoleColor.DarkYellow);

            int count = 0;
            foreach (var user in usersData)
            {
                Console.WriteLine(format,
                                  ++count,
                                  user.Name,
                                  user.QuantityPassedTests,
                                  user.QuantityRightAnswers,
                                  user.PercentRightAnswers,
                                  user.Diagnosis);
            }
        }
        static void ShowTestsList(List<Test> testsData)
        {
            Console.Clear();
            MakeColorText(ConsoleColor.DarkYellow, $"Вы находитесь в меню добавления тестов\n");
            string format = "| {0,4} | {1,-150} |";
            PrintTestsTitle(format, ConsoleColor.DarkYellow);

            int count = 0;
            foreach (var test in testsData)
            {
                Console.WriteLine(format, ++count, test.Question);
            }
        }
        static void AddTestToBase(Game game)
        {
            Console.Clear();

            string newQestion;
            int newAnswer;

            MakeColorText(ConsoleColor.DarkYellow, "Напишите вопрос теста:");
            while (!Check.UserText(Console.ReadLine(), out newQestion, out string error))
            {
                MakeColorText(ConsoleColor.Red, error);
            }

            MakeColorText(ConsoleColor.DarkYellow, "Напишите ответ на тест:");
            while (!Check.UserNumber(Console.ReadLine(), out newAnswer, out string error))
            {
                MakeColorText(ConsoleColor.Red, error);
            }
            Test newTest = new(newQestion, newAnswer);

            game.AddTest(newTest);
            Console.WriteLine("Тестовое задание добавлено!");
        }
        static void DeleteTestFromBase(Game game)
        {
            MakeColorText(ConsoleColor.DarkYellow, "\nВведите номер теста который хотите удалить\nПервые 5 вопросов удалять нельзя:");
            while (true)
            {
                int userChoice;

                while (!Check.UserNumber(Console.ReadLine(), out userChoice, out string errorText))
                {
                    MakeColorText(ConsoleColor.Red, errorText);
                }

                var additionalCondition = userChoice <= StorageTests.GetDefaultTests().Count || userChoice > game.GetTestsData().Count;

                if (additionalCondition)
                {
                    MakeColorText(ConsoleColor.Red, "Вы выбрали не существующий номер теста, попробуйте еще раз");
                }
                if (!additionalCondition)
                {
                    game.DelTest(userChoice - 1);

                    MakeColorText(ConsoleColor.Red, "\nТест был удален из базы данных");
                    Console.Write("для продолжения нажмите любую клавишу");
                    Console.ReadLine();
                    break;
                }
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void PrintTestsTitle(string format, ConsoleColor color)
        {
            string[] title = { "№", "Тестовый вопрос" };

            int stringLength = string.Format(format, "val1", "val2").Length;

            Console.WriteLine(new string('=', stringLength));
            Console.ForegroundColor = color;
            Console.WriteLine(format, title);
            Console.ResetColor();
            Console.WriteLine(new string('=', stringLength));
        }
        static void PrintResultsTitle(string format, ConsoleColor color)
        {
            string[] title = { "№",
                               "Имя студента",
                               "Количество пройденных тестов",
                               "Количество правильных ответов",
                               "Процент правильных ответов",
                               "Диагноз" };

            int stringLength = string.Format(format, "val1", "val2", "val3", "val4", "val5", "val6").Length;

            Console.WriteLine(new string('=', stringLength));
            Console.ForegroundColor = color;
            Console.WriteLine(format, title);
            Console.ResetColor();
            Console.WriteLine(new string('=', stringLength));
        }
        static void MakeColorText(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static string[] ShowMainMenu()
        {
            string[] menu = new string[6]
            {
                "Начать тестирование",
                "Увидеть список результатов тестирования",
                "Посмотреть рейтинг учеников ТОП-10",
                "Добавить тестовое задание в базу данных",
                "Удалить тестовое задание из базы данных",
                "Закрыть программу"
            };
            return menu;
        }
        static string[] ShowTestMenu()
        {
            string[] menu = new string[2]
            {
                "Начать тестирование",
                "Вернуться в главное меню"
            };
            return menu;
        }
        static string[] ShowResultsMenu()
        {
            string[] menu = new string[2]
            {
                "Если хотите очистить все результаты экзамена",
                "Вернуться в главное меню"
            };
            return menu;
        }
        static string[] ShowAddTestMenu()
        {
            string[] menu = new string[2]
            {
                "Добавить тест в базу данных",
                "Вернуться на главный экран экзамена"
            };
            return menu;
        }
        static string[] ShowDeletTestMenu()
        {
            string[] menu = new string[2]
            {
                "Удалить тест из базы данных",
                "Вернуться на главный экран экзамена"
            };
            return menu;
        }
        static int SelectItemMenu(string[] menuTitel, int indexMenu)
        {
            MakeColorText(ConsoleColor.Red, "Выберите дальнейшее действие: \n");

            Console.CursorVisible = false;
            var row = Console.CursorTop;
            var col = Console.CursorLeft;

            while (true)
            {
                Console.SetCursorPosition(col, row);
                for (int i = 0; i < menuTitel.Length; i++)
                {
                    if (i == indexMenu)
                    {
                        Console.BackgroundColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine($"{i + 1,2}) {menuTitel[i]}");
                    Console.ResetColor();
                }
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (indexMenu < menuTitel.Length - 1) { indexMenu++; }
                        break;
                    case ConsoleKey.UpArrow:
                        if (indexMenu > 0) { indexMenu--; }
                        break;
                    case ConsoleKey.Enter:
                        Console.CursorVisible = true;
                        return indexMenu;
                }
            }
        }
    }
}