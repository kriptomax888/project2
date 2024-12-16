using System;
namespace LAB2_2;
class Ar
{
    private int n; 
    private int[] a;

    public int K 
    {
        get
        {
            int count = 0;
            foreach (int num in a)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }

    public int N 
    {
        get { return n; }
    }

    public Ar(int a, int b)
    {
        Random rand = new Random();
        n = rand.Next(1, 101); 
        this.a = new int[n];
        for (int i = 0; i < n; i++)
        {
            this.a[i] = rand.Next(a, b + 1) * (rand.Next(2) == 0 ? 1 : -1);
        }
    }

    public Ar(int n) 
    {
        Random rand = new Random();
        this.n = n;
        this.a = new int[n];
        for (int i = 0; i < n; i++)
        {
            this.a[i] = rand.Next(101) * (rand.Next(2) == 0 ? 1 : -1); 
        }
    }

    public void Print() 
    {
        Console.WriteLine("Елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    public int P() 
    {
        for (int i = n - 1; i >= 0; i--)
        {
            if (a[i] > 0)
            {
                return i;
            }
        }
        return -1;
    }

    public int Sum(int i1, int i2) 
    {
        int sum = 0;
        for (int i = i1; i <= i2; i++)
        {
            sum += a[i];
        }
        return sum;
        Console.ReadLine();
    }
    
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Виберіть конструктор (1 або 2):");
        int constructorChoice = int.Parse(Console.ReadLine());

        Ar ar;
        if (constructorChoice == 1)
        {
            Console.WriteLine("Введіть a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть b:");
            int b = int.Parse(Console.ReadLine());
            ar = new Ar(a, b);
        }
        else if (constructorChoice == 2)
        {
            Console.WriteLine("Введіть n:");
            int n = int.Parse(Console.ReadLine());
            ar = new Ar(n);
        }
        else
        {
            Console.WriteLine("Неправильний вибір конструктора.");
            return;
        }

        ar.Print();
        Console.WriteLine("Кількість парних елементів: " + ar.K);

        int lastIndex = ar.P();
        if (lastIndex != -1)
        {
            Console.WriteLine("Індекс останнього позитивного елемента: " + lastIndex);
            int sum = ar.Sum(0, lastIndex);
            Console.WriteLine("Сума елементів лівіше вказаного індексу: " + sum);
        }
        else
        {
            Console.WriteLine("Позитивних елементів немає.");
        }
        Console.ReadLine();
        
    }
    
    
}
