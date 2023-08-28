using System.Text;


class Money
{


    private int first;
    private int second;
    private int third;


    private Money()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;


        Console.WriteLine("Введіть номінал, що маєте:");
        int f = Convert.ToInt32(Console.ReadLine());
        if (f < 0)
        {
            Console.WriteLine("Введіть додатнє число: ");
            f = Convert.ToInt32(Console.ReadLine());
        }
        first = f;
        Console.WriteLine("Введіть кількість купюр з цим номіналом, що маєте:");
        int s = Convert.ToInt32(Console.ReadLine());
        if (s < 0)
        {
            Console.WriteLine("Введіть додатнє число: ");
            s = Convert.ToInt32(Console.ReadLine());
        }
        second = s;
        Console.WriteLine("Введіть суму покупки:");
        int t = Convert.ToInt32(Console.ReadLine());
        if (t < 0)
        {
            Console.WriteLine("Введіть додатнє число: ");
            t = Convert.ToInt32(Console.ReadLine());
        }
        third = t;
    }


    static void Count(int first, int second, int third)
    {
        Console.WriteLine("Ви маєте: " + first + " грн кількістю " + second + " шт.");
        Console.WriteLine("Ваша сума становить " + (first * second) + " грн.");
        int count =  (second * first) / third;
        if (count == 0) { count = 1; }
        if (third > (second * first))
        {
            Console.WriteLine("На жаль, Вам не вистачає коштів зробити покупку на " +
                (third - (second * first)) + " грн.");
        }
        else
        {
            Console.WriteLine("Ви можете купити " + count + " шт.");
            Console.WriteLine("У Вас залишиться " + ((second * first) - (third * count)) + " грн.");
        }
    }


    static void Main(string[] args)
    {
        Money Groshi = new Money();
        int f = Groshi.first;
        int s = Groshi.second;
        int t = Groshi.third;
        Count(f, s, t);
    }
}
