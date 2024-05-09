using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    //Singleton desgin

    class Program
    {

        delegate void calculate(int a, int b);
        static void Main()
        {





            #region simple factory

            //IFrequency ff = FactoryFrequency.GetFrequency("Yearly");

            //if (ff != null)
            //{
            //    DateTime dtnew = ff.GetDueDate(DateTime.Now);

            //    Console.WriteLine("New due date is {0}", dtnew);
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect frequency");
            //}

            #endregion

            #region factory method example

            //IFrequenyCreator monthlyCreater = new MonthlyCreater();
            //IFrequency monthly = monthlyCreater.GetFrequency();

            //var duedate = monthly.getduedate(DateTime.Now);

            //Console.WriteLine("new due date is {0}", duedate);


            //IFrequenyCreator quaterlyCreater = new QuarterlyCreater();
            //IFrequency quaterly = quaterlyCreater.GetFrequency();
            //var duedt = quaterly.getduedate(DateTime.Now);

            //Console.WriteLine("new due date is {0}", duedt);

            #endregion

            #region Main Method Abstract Factory Method
            /*
            IVehicleFactory sports = new SportsVehicleFactory();
            IVehicle sportsBike = sports.CreateBike();
            IVehicle sportsCar = sports.CreateCar();

            sportsBike.Drive();
            sportsCar.Drive();


            IVehicleFactory regular = new RegularVehicleFactory();
            IVehicle regularBike = regular.CreateBike();
            IVehicle regularCar = regular.CreateCar();

            regularBike.Drive();
            regularCar.Drive();

            */
            #endregion

            #region Chain of responsibility
            /*
            IHandeler handeler1 = new Montly();
            IHandeler handeler2 = new HalfYearly();

            handeler1.NextHandler = handeler2;

            handeler1.NextDueDate("Halfyearly");
            */
            #endregion

            #region Adaptor design pattern client

            //INewDueDate newDueDate = new OldMontlyAdapter(new Monthly());
            //DateTime dt = DateTime.Now.AddDays(-2);
            //newDueDate.GetNewDueDate(dt);

            #endregion

            #region extension method
            //string input = "Hello World";
            //int i = input.WordCount();
            //Console.WriteLine(i);
            #endregion


            #region singleton desing pattern client implementation
           // SingleTonClass s = SingleTonClass.GetInstance();

            #endregion

            int[] inputArray = { 0,1,2,3,4,5 };

            Program p = new Program();
            p.ChangeZeroValues(inputArray);



        }


        #region singleton design Pattern
        public sealed class SingleTonClass
        {
            private static SingleTonClass instance;

            private static object obj;
            private SingleTonClass()
            {

            }

            public static SingleTonClass GetInstance()
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        return instance;
                    }
                }
                return instance;
            }

            public void Test()
            {

            }
        }
        #endregion


        //coding question


        #region fibonacci
        //public void Fibonacci(int input)
        //{
        //    int first = 0;
        //    int second = 1;
        //    int next = 1;

        //    Console.Write("{0}, {1}", first, second);

        //    for (int i = 2; i < input; i++)
        //    {
        //        next = first + second;
        //        first = second;
        //        second = next;

        //        Console.Write(", {0}", next);
        //    }

        //}

        #endregion

        #region sum of elements in array
        /*
        public void ReturnSumOfArrayElements(int[] intArray)
        {
            int output = 0;
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                output = output + intArray[i];
            }

            Console.WriteLine(output);
        }*/

        #endregion


        #region Max number in provided array
        /*
        public void MaxNum(int [] intArray)
        {
            int a = 0;

            foreach(var element in intArray)
            {
                if(a < element)
                {
                    a = element;
                }
            }

            Console.WriteLine(a);
        }
        */
        #endregion


        #region prime number
        /*
        public bool IsPrime(int num)
        {
            bool output = false;
            double root = Math.Sqrt(num);


            if (num > 2)
            {
                for (int i = 2; i < root; i++)
                {
                    if (num % i ==0)
                    {
                        output = false;
                        break;
                    }
                    else
                    {
                        output = true;
                    }
                }

                return output;
            }
            else
            {
                output = true;
            }

            return output;

        }
        */
        #endregion

        #region count of vowels
        /*
        public void CountOfVowels(string strinput)
        {
            string[] arrayVowels = { "a", "e", "i", "o", "u" };
            int counter = 0;

            for (int i = 0; i <= strinput.Length ; i++)
            {
                for (int j = 0; j <= arrayVowels.Length ; j++)
                {
                    if (strinput[i].ToString().ToLower() == arrayVowels[j].ToString())
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter); 
        }
        */
        #endregion


        #region print all 0 values in array at last

        public void ChangeZeroValues(int[] inputArray)
        {
            int nonZeroIndex = 0;

            // Move all non-zero elements to the front of the array
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] != 0)
                {
                    // Swap non-zero element with the current position of nonZeroIndex
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[nonZeroIndex];
                    inputArray[nonZeroIndex] = temp;

                    nonZeroIndex++;
                }
            }

            // Print the modified array
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }


        //public void ChangeZeroValues(int[] inputArray)
        //{
        //int countZero = 0;
        //foreach (var item in inputArray)
        //{
        //    if (item == 0)
        //    {
        //        countZero++;
        //    }
        //}

        //int[] result = new int[inputArray.Length];
        //int index = 0;
        //foreach (var item in inputArray)
        //{
        //    if (item != 0)
        //    {
        //        result[index++] = item;
        //    }
        //}

        //for (int i = 0; i < countZero; i++)
        //{
        //    result[index++] = 0;
        //}

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}



        //}
        #endregion



    }




    #region extension method
    //public static class StringExtension
    //{
    //    public static int WordCount(this string str)
    //    {
    //        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    //
    //        return words.Length;
    //    }
    //}
    #endregion

    #region simple factory
    /*
    public class FactoryFrequency
    {
        public static IFrequency GetFrequency(string input)
        {
            IFrequency objfrequency = null;
            if (input == "Monthly")
            {
                objfrequency = new Monthly();

                return objfrequency;
            }
            else if (input == "HalfYearly")
            {
                objfrequency = new HalfYearly();

                return objfrequency;
            }
            else if (input == "Quarterly")
            {
                objfrequency = new Quartely();

                return objfrequency;
            }
            else
            {
                return null;
            }
        }
    }


    public interface IFrequency
    {
        public DateTime GetDueDate(DateTime date);
    }

    public class Monthly : IFrequency
    {
        public DateTime GetDueDate(DateTime date)
        {
            DateTime newDuedt = date.AddMonths(1);

            return newDuedt;
        }
    }

    public class Quartely : IFrequency
    {
        public DateTime GetDueDate(DateTime date)
        {
            DateTime newDuedt = date.AddMonths(3);

            return newDuedt;
        }
    }

    public class HalfYearly : IFrequency
    {

        public DateTime GetDueDate(DateTime date)
        {
            DateTime newDuedt = date.AddMonths(6);

            return newDuedt;
        }
    }

    */
    #endregion

    #region factory method
    /*
    public interface IFrequency
    {
        public DateTime getduedate(DateTime duedt);
    }

    public class Monthly : IFrequency
    {
        public DateTime getduedate(DateTime duedate)
        {
            return duedate.AddMonths(1);
        }
    }

    public class Quarterly : IFrequency
    {
        public DateTime getduedate(DateTime duedate)
        {
            return duedate.AddMonths(4);
        }
    }


    public interface IFrequenyCreator
    {
        IFrequency GetFrequency();
    }

    public class MonthlyCreater : IFrequenyCreator
    {
        public IFrequency GetFrequency()
        {
            return new Monthly();
        }
    }

    public class QuarterlyCreater : IFrequenyCreator
    {
        public IFrequency GetFrequency()
        {
            return new Quarterly();
        }
    }
    */
    #endregion

    #region abstract factory method
    /*
    //abstract product
    public interface IVehicle
    {
        public void Drive();
    }

    //concret product
    public class SportsCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a sports car");
        }
    }

    public class RegularCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a regular car");
        }
    }

    public class SportsBike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a sports bike");
        }
    }

    public class RegularBike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a regular bike");
        }
    }


    //Abstract Factory
    public interface IVehicleFactory
    {
        IVehicle CreateCar();
        IVehicle CreateBike();
    }


    //Concrete factory that actully create objects
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateBike()
        {
            return new SportsBike();
        }

        public IVehicle CreateCar()
        {
            return new SportsCar();
        }
    }

    public class RegularVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateBike()
        {
            return new RegularBike();
        }

        public IVehicle CreateCar()
        {
            return new RegularCar();
        }
    }

    */

    #endregion

    #region chain of responsibility
    /*
    public interface IHandeler
    {
        IHandeler NextHandler { get; set; }

        public void NextDueDate( string frequency);
    }


    public class Montly : IHandeler
    {
        public IHandeler NextHandler { get ; set ; }

        public void NextDueDate(string frequency)
        {
            if (frequency == "Monthly")
            {
                DateTime nxtduedt = DateTime.Now.AddMonths(1);
                Console.WriteLine(nxtduedt);
            }
            else if (NextHandler != null)
            {
                NextHandler.NextDueDate(frequency);
            }
            else
            {
                Console.WriteLine("Request can't be handeled");
            }
        }
    }

    public class HalfYearly : IHandeler
    {
        public IHandeler NextHandler { get; set ; }

        public void NextDueDate(string frequency)
        {
            if (frequency == "Halfyearly")
            {
                DateTime nxtduedt = DateTime.Now.AddMonths(6);
                Console.WriteLine(nxtduedt);
            }
            else if (NextHandler != null)
            {
                NextHandler.NextDueDate(frequency);
            }
            else
            {
                Console.WriteLine("Request can't be handeled");
            }
        }
    }
    */
    #endregion

    #region adaptor design pattern
    //public class Monthly
    //{
    //    public DateTime GetDueDate(DateTime dt)
    //    {
    //        return dt.AddMonths(1);
    //    }


    //}
    //public interface INewDueDate
    //{
    //    void GetNewDueDate(DateTime dateTime);
    //}


    //public class OldMontlyAdapter : INewDueDate
    //{
    //    private Monthly _monthly;

    //    public OldMontlyAdapter(Monthly monthly)
    //    {
    //        _monthly = monthly;
    //    }

    //    public void GetNewDueDate(DateTime dateTime)
    //    {
    //        DateTime newDueDt = dateTime;

    //        newDueDt = _monthly.GetDueDate(dateTime);

    //        if (newDueDt.DayOfWeek.ToString() == "Sunday")
    //        {
    //            newDueDt = newDueDt.AddDays(1);
    //        }

    //        Console.WriteLine(newDueDt);
    //    }
    //}

    #endregion

    #region epam scenario based question
    public class A
    {
        public A()
        {
            Console.WriteLine("Hi From A");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("Hi From B");
        }
    }



    #endregion


    
}
