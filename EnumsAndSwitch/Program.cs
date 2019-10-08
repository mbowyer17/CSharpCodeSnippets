using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndSwitch
{
    class Program
    {
        //Enumration is a data type that limits and contrains all possible values that have meaning 
        //  
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo {Description = "Task 1", EstimatedHours = 6, Status = Status.Completed},
                new Todo {Description = "Task 2", EstimatedHours = 2, Status = Status.InProgress},
                new Todo {Description = "Task 3", EstimatedHours = 8, Status = Status.NotStarted},
                new Todo {Description = "Task 4", EstimatedHours = 12, Status = Status.Deleted},
                new Todo {Description = "Task 5", EstimatedHours = 6, Status = Status.InProgress},
                new Todo {Description = "Task 6", EstimatedHours = 2, Status = Status.NotStarted},
                new Todo {Description = "Task 7", EstimatedHours = 14, Status = Status.NotStarted},
                new Todo {Description = "Task 8", EstimatedHours = 8, Status = Status.Completed},
                new Todo {Description = "Task 9", EstimatedHours = 8, Status = Status.InProgress},
                new Todo {Description = "Task 10", EstimatedHours = 8, Status = Status.Completed},
                new Todo {Description = "Task 11", EstimatedHours = 4, Status = Status.NotStarted},
                new Todo {Description = "Task 12", EstimatedHours = 10, Status = Status.Completed},
                new Todo {Description = "Task 13", EstimatedHours = 12, Status = Status.Deleted},
                new Todo {Description = "Task 14", EstimatedHours = 6, Status = Status.Completed}

            };

            Console.ForegroundColor = ConsoleColor.DarkRed;

            PrintAssesment(todos);
            Console.ReadLine();
        }

        private static void PrintAssesment(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                // switch then you have a value or variable that is under evulation, 
                // then you have the series cases which we try to match it up with the cases, we write the code beneath it
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;

                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            }

        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        // comes from emun status
        public Status Status { get; set; }

    }

     enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }

}
