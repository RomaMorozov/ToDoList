using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Приветствую Вас в заметках!");
            List<string> listOfNotes = new List<string>();
            string selection = "";
            while (selection != "в")
            {
                Console.WriteLine("Для выполнения действия нажмите цифру:");
                Console.WriteLine("Чтобы добавить заметку нажмите 1.");
                Console.WriteLine("Чтобы удалить заметку нажмите 2.");
                Console.WriteLine("Чтобы изменить заметку нажмите 3.");
                Console.WriteLine("Отобразить список заметок - нажмите 4.");
                Console.WriteLine("Для выхода нажмите 'в'.");

                selection = Console.ReadLine();
                if (selection == "1")
                {
                    Console.Write("Введите текст заметки: ");
                    string textNotes = Console.ReadLine();
                    listOfNotes.Add(textNotes);
                    Console.WriteLine("__________");
                }
                else if(selection =="2")
                {
                    for (int i = 0; i < listOfNotes.Count; i++)
                    {
                        Console.WriteLine(i+1 + ": " + listOfNotes[i]);
                    }
                    Console.Write("Укажите номер строки для удаления: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    listOfNotes.RemoveAt(--number);
                }
                else if (selection=="3")
                {
                    for (int i = 0; i < listOfNotes.Count; i++)
                    {
                        Console.WriteLine(i+1 + ": " + listOfNotes[i]);
                    }
                    Console.Write("Укажите номер строки для изменения: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    listOfNotes.RemoveAt(--number);
                    Console.Write("Введите текст новой заметки: ");
                    string textNotes = Console.ReadLine();
                    listOfNotes.Insert(number, textNotes);

                }
                else if (selection == "4")
                {
                    Console.WriteLine("Список заметок:");
                    for (int i = 0; i < listOfNotes.Count; i++)
                    {
                        Console.WriteLine(i+1 + ": " + listOfNotes[i]);
                    }
                    Console.WriteLine("==================");
                }
                else
                {
                    Console.WriteLine("Введите корректно данные.");
                }
                
            }
            Console.WriteLine("Выход из приложения.");
            Console.ReadKey();
        }
    }
}
