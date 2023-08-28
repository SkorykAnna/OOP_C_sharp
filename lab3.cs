using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asd;

namespace asd
{
    public abstract class Automobile
    {
        public abstract string Name { get; set; }
        public abstract double Speed { get; set; }

        protected string name;
        protected double speed;

        public void InfoAuto()
        {
            Console.WriteLine("Automobile " + Name + " has speed " + Speed + " km/h.");
        }
    }
    public class Sprinter : Automobile
    {

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override double Speed
        {
            get
            {
                return speed;
            }
            set
            { speed = value; }
        }
    }

}
public class Truck : Automobile
{
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public override double Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }

}
public class PowerOnly : Automobile
{
    public override string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public override double Speed
    {
        get
        {
            return speed;
        }
        set
        { speed = value; }
    }

}
class Program
{
    static void Main(string[] args)
    {
        Sprinter objSprinter = new Sprinter();
        Console.WriteLine("Enter name for Sprinter");
        string a = Console.ReadLine();
        objSprinter.Name = a;
        Console.WriteLine("Enter the his speed");
        double aa = Double.Parse(Console.ReadLine());
        objSprinter.Speed = aa;

        Truck objTruck = new Truck();
        Console.WriteLine("Enter name for Truck");
        string b = Console.ReadLine();
        objTruck.Name = b;
        Console.WriteLine("Enter the his speed");
        double bb = Double.Parse(Console.ReadLine());
        objTruck.Speed = bb;

        PowerOnly objPowerOnly = new PowerOnly();
        Console.WriteLine("Enter name for Power Only");
        string c = Console.ReadLine();
        objPowerOnly.Name = c;
        Console.WriteLine("Enter the his speed");
        double cc = Double.Parse(Console.ReadLine());
        objPowerOnly.Speed = cc;

        Console.WriteLine("You gave such info:");
        objSprinter.InfoAuto();
        objTruck.InfoAuto();
        objPowerOnly.InfoAuto();
        Console.WriteLine();

        double[] autoArray = {aa, bb, cc};
        if (getLargest(autoArray) == aa)
        {
            Console.WriteLine("Auto with max speed is " + a);
        }
        else if (getLargest(autoArray) == bb)
        {
            Console.WriteLine("Auto with max speed is " + b);
        }
        else if (getLargest(autoArray) == cc)
        {
            Console.WriteLine("Auto with max speed is " + c);
        }


        Console.Read();
    }

    public static double getLargest(double[] arrray)
    {
        double largest = arrray[0];
        for (int i = 1; i < arrray.Length; i++)
        {
            if (arrray[i] > largest)
                largest = arrray[i];
        }
        return largest;
    } 
}
