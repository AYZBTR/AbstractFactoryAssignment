using System;

namespace AbstractFactoryAssignment
{
    // Singleton class for Printer
    public class Printer
    {
        private static Printer? instance;

        private Printer() { }

        public static Printer GetInstance()
        {
            if (instance == null)
            {
                instance = new Printer();
            }
            return instance;
        }

        public void Print(string message)
        {
            // Output: print out the string message 
            Console.WriteLine(message);
        }
    }

    // Interface for Exam
    public interface InterfaceExam
    {
        void PerformConduct();
        void PerformEvaluate();
        void PerformPublishResults();

    }

    // Concrete implementation of Math Exam
    public class MathExam : InterfaceExam
    {
        public void PerformConduct()
        {
            Printer.GetInstance().Print("Conducting Math Exam");
        }

        public void PerformEvaluate()
        {
            Printer.GetInstance().Print("Evaluating Math Exam");
        }

        public void PerformPublishResults()
        {
            Printer.GetInstance().Print("Publishing Math Exam Results");
        }
    }

    // implementation of Science Exam
    public class ScienceExam : InterfaceExam
    {
        public void PerformConduct()
        {
            Printer.GetInstance().Print("Conducting Science Exam");
        }

        public void PerformEvaluate()
        {
            Printer.GetInstance().Print("Evaluating Science Exam");
        }

        public void PerformPublishResults()
        {
            Printer.GetInstance().Print("Publishing Science Exam Results");
        }
    }

    // implementation of Programming Exam
    public class ProgrammingExam : InterfaceExam
    {
        public void PerformConduct()
        {
            Printer.GetInstance().Print("Organizing Programming Exam.");
        }

        public void PerformEvaluate()
        {
            Printer.GetInstance().Print("Reviewing Programming Exam.");
        }

        public void PerformPublishResults()
        {
            Printer.GetInstance().Print("Announcement of Programming Exam Results...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Printer that uses Singleton pattern
            Printer printer = Printer.GetInstance();

            // Test that the created Printer works, by calling the Print method
            printer.Print("Here I am: Testing Printer");

            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            // Try to create new Printer object and compare the two objects to check,
            // that the new printer object is the same instance

            Printer nextPrinter = Printer.GetInstance();

            if (printer == nextPrinter)
            {
                Console.WriteLine("The two printer instances are identical.");
            }
            else
            {
                Console.WriteLine("The printer instances are not the same.");
            }

            // TODO#10: Use Abstract Factory to create different types of exams.
            InterfaceExam mathExam = new MathExam();
            mathExam.PerformConduct();
            mathExam.PerformEvaluate();
            mathExam.PerformPublishResults();

            InterfaceExam scienceExam = new ScienceExam();
            scienceExam.PerformConduct();
            scienceExam.PerformEvaluate();
            scienceExam.PerformPublishResults();

            InterfaceExam programmingExam = new ProgrammingExam();
            programmingExam.PerformConduct();
            programmingExam.PerformEvaluate();
            programmingExam.PerformPublishResults();
        }
    }
}




