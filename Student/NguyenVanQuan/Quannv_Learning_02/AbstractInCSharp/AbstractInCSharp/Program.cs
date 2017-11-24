using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action ac = new Action();
            ac.addQuestion(new Question("0", "Tra'i da't hi`nh gi` ?", 1, 1));
            ac.addQuestion(new Question("1", "1 + 1 = ?", 2, 1));
            ac.addQuestion(new Question("2", "2 + 2 = ?", 2, 1));
            ac.addQuestion(new Question("3", "Tru'ng co' truo'c hay ga` co' truo'c ?", 1, 1));
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1. Get all question.");
                Console.WriteLine("2. Add new question.");
                Console.WriteLine("3. Find question.");
                Console.WriteLine("4. Exit");
                int menu = int.Parse( Console.ReadLine());
                
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Code\tContent");
                        Console.WriteLine();
                        List<Question> lq = ac.getAll();
                        for(int i = 0;i< lq.Count; i++)
                        {
                            if (lq[i] != null)
                            {
                                Console.WriteLine($"{lq[i].question_code}\t{lq[i].content}");
                            }
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter content:");
                        string ct = Console.ReadLine();
                        ac.addQuestion(new Question(String.Concat(ac.getAll().Count),ct,1,1));
                        Console.Clear();
                        Console.WriteLine("Success");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Enter code:");
                        string code = Console.ReadLine();
                        Question q =  ac.find(code);
                        if(q == null)
                        {
                            Console.Clear();
                            Console.WriteLine("not found!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Code\tContent");
                            Console.WriteLine();
                            Console.WriteLine($"{q.question_code}\t{q.content}");
                            Console.WriteLine();
                            Console.WriteLine("1. edit           2. remove       default. back");
                            try
                            {
                                int ch = int.Parse(Console.ReadLine());
                                switch (ch)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Enter content:");
                                        ct = Console.ReadLine();
                                        ac.modifile(int.Parse(q.question_code), ct);
                                        Console.Clear();
                                        Console.WriteLine("Success");
                                        Console.ReadLine();
                                        break;
                                    case 2:
                                        ac.remove(q.question_code);
                                        Console.Clear();
                                        Console.WriteLine("Success");
                                        Console.ReadLine();
                                        break;
                                }
                            }
                            catch
                            {

                            }
                        }
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
