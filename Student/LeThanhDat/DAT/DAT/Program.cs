using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> s = new Dictionary<int,string>();
            s.Add(404, "Not Found");
            s.Add(401, "Unauthentication");
            s.Add(403, "Unauthorization");
            s.Add(500, "Error Server");

            IQuestion question = new QuestionImp();
            Question q = new Question()
            {
                questiont_code = Guid.NewGuid().ToString(),
                content = "I ___ a student",
                level = 0,
                type = 0
            };
            question.Add(q);
            foreach (var item in question.GetAll())
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
