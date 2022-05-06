using System;

namespace Task3
{
    public delegate double MyDelegate(RandomDelegate[] d);
    public delegate int RandomDelegate();

    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            MyDelegate myDelegate = delegate (RandomDelegate[] d)
            {
                double sum = new double();
                for (int i = 0; i < d.Length; i++)
                {
                    sum += d[i].Invoke();
                }
                return sum / d.Length;
            };
            RandomDelegate randomDelegate = delegate () { return rand.Next(100); };
            RandomDelegate randomDelegate2 = delegate () { return rand.Next(100); };

            RandomDelegate[] randomDelegates = {randomDelegate, randomDelegate2 };
            Console.WriteLine(myDelegate(randomDelegates));


            Console.ReadKey();
         
        }
    }
}
