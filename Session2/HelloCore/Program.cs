using System;

namespace Session2
{
    class Program
    {
      static void print_function(double a, double b) => Console.WriteLine($"{a}\t{b}");

      static double add_funcion(double a, double b) => a+b;

      static double substract_function(double a, double b)
      {
          double result = a - b;
          return result;
      }

      static double multiply_function(double a, double b)
      {
          double result = a * b;
          return result;
      }

      static bool is_prime(double a)
      {
          if (a < 2)
          {
              return false;
          }
          if (a == 2)
          {
              return true;
          }
          else
          {
              if (a % 2 == 0)
              {
                  return false;
              }
              for (int i = 2; i <= Math.Sqrt(a); i++)
              {
                  if (a % i == 0)
                  {
                      return false;
                  }
              }
              return true;
          }
      }

      static void print_menu()
      {
          Console.WriteLine("De in ra 2 so, bam 1");
          Console.WriteLine("De tinh tong 2 so, bam 2");
          Console.WriteLine("De tinh hieu 2 so, bam 3");
          Console.WriteLine("De tinh tich 2 so, bam 4");
          Console.WriteLine("De kiem tra so nguyen, bam 5");
          Console.WriteLine("De thoat chuong trinh, bam 6");
      }

      static void main_funtion()
      {
          string c = "";
          double a=0,b=0;
          while(true)
          {
              print_menu();
              c = Console.ReadLine();
              Console.WriteLine(c);
              switch (c)
              {
                  case "1":
                      a = Convert.ToDouble(Console.ReadLine());
                      b = Convert.ToDouble(Console.ReadLine());
                      print_function(a, b);
                      Console.Clear();
                      break;
                  case "2":
                      try
                      {
                          Console.WriteLine(add_funcion(a, b));
                      }
                      catch (FormatException e)
                      {
                          Console.WriteLine(e.Message);
                      }
                      break;

                  case "3":
                      try
                      {
                          Console.WriteLine(substract_function(a, b));
                      }
                      catch (FormatException e)
                      {
                          Console.WriteLine(e.Message);
                      }
                      break;

                  case "4":
                      try
                      {
                          double result = multiply_function(a, b);
                          Console.WriteLine(result);
                      } catch (FormatException e)
                      {
                          Console.WriteLine(e.Message);
                      }
                      break;

                  case "5":
                      try
                      {
                          if (a - Math.Floor(a) != 0 && b - Math.Floor(b) != 0)
                              Console.WriteLine("So khong hop le");
                          if (a - Math.Floor(a) == 0 && b - Math.Floor(b) == 0)
                          {
                              double[] data = {a , b};
                              foreach (double number in data)
                              {
                                  if (is_prime(number) == true)
                                  {
                                      Console.WriteLine(number + " la so nguyen to");
                                  }
                                  else
                                  {
                                      Console.WriteLine(number + " khong phai la so nguyen to");
                                  }
                              }
                          }
                      } catch (FormatException e)
                      {
                          Console.WriteLine(e.Message);
                      }
                      break;

                  case "6":
                      Console.WriteLine("Bye!");
                      Environment.Exit(0);
                      break;
                  default:
                   Console.WriteLine("Nhap sai.Moi Nhap lai");
                   break;
              }
          }
      }
        static void Main(string[] args)
        {
          main_funtion();
        }
    }
}
