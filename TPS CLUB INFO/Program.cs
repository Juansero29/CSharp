using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TPS_CLUB_INFO
{
    class Program
    {
        static void Main()
        {
            Exo02_16();
        }

        //Exo 2 is TP2_IUT Project

        static void Exo02_02() {
            Vector myVector = new Vector(12,3,5);
            WriteLine($"The norm of the vector {myVector.ToString()} is {myVector.Norm}");
        }

        static void Exo02_03() {
            Cobblestone myCobblestone = new Cobblestone(30, 20, 10);
            Cobblestone myCobblestone2 = new Cobblestone(25, 15, 5);
            WriteLine($"The volume of the cobblestone {myCobblestone.ToString()} is {myCobblestone.Volume}");
            WriteLine($"The volume of the cobblestone {myCobblestone2.ToString()} is {myCobblestone2.Volume}");
            WriteLine();

            myCobblestone2 = myCobblestone;
            WriteLine($"The volume of the cobblestone {myCobblestone.ToString()} is {myCobblestone.Volume}");
            WriteLine($"The volume of the cobblestone {myCobblestone2.ToString()} is {myCobblestone2.Volume}");
            WriteLine();

            myCobblestone2.Lenght = 10;
            myCobblestone2.Height = 25;
            myCobblestone2.Width = 70;
            WriteLine($"The volume of the cobblestone {myCobblestone.ToString()} is {myCobblestone.Volume}");
            WriteLine($"The volume of the cobblestone {myCobblestone2.ToString()} is {myCobblestone2.Volume}");
        }
        //4 to 10 are in Exo02_02 and Exo02_03.
        static void Exo02_11()
        {
            CurlingClassment cc = CurlingClassment.GetInstance();
            WriteLine($"{cc[20]}, Russia has {cc["Russia"]} points.");
            CurlingClassment oo = CurlingClassment.GetInstance(); //Using the same instance in another variable.
            WriteLine($"{oo[20]}, Russia has {oo["Russia"]} points.");
            ReadKey(true);
        }

        static void Exo02_13() {
            Target t = new Target("Mickey", 100, 50);
            WriteLine(t);
            //t.Description = "King Kong";
            HelpProgram.Exo02_13BadFonc(t);
            WriteLine(t);
            ReadKey(true);
        }
    

        static void Exo02_14()
        {
            Point po = new Point(3, 3);
            WriteLine($"{po.X} {po.Y}");
            HelpProgram.Exo02_14BadFonc(po);
            po.Translate(2, 2);//**
            WriteLine($"{po.X} {po.Y}"); //1. 'Point' class is not immutable because the method 'Exo02_14BadFonc()' that itself calls the method 'Translate()'can change the axis values of a Point, which makes this class mutable. 
            Circle ce = new Circle(2, po);
            WriteLine($"{ce.Centre.X} {ce.Centre.Y}");
            HelpProgram.Exo02_14BadFonc2(ce);
            ce.Centre.Translate(1, 1);
            WriteLine($"{ce.Centre.X} {ce.Centre.Y}"); //2. As the circle includes a Point object as one of its members, that makes this class mutable too, even if it is a structure.
            ReadKey(true);

            //3. If we change the class Point for a Structure, it will make this object immutable before methods but it's still mutable. 
            //Exo02_15 This is because of the "Translate" member function, which uses the same instance of the object changing it's values, as we can see in ** comment.
            //To make this an immutable structure, we have to make the "Translate" function create and return a new instance of the object.

        }

        static void Exo02_16()
        {
            RifleShooting shoot = new RifleShooting(new Target("Mickey", 90, 50), new Target("Gargame1", 150, 20), new Target("Smurf with glasses", 10, 5));
            WriteLine(shoot);
        }
        
        // Exercise 02_17 is Project Ex_17 Composite.
        // Exercise 02_18 is Project Ex_18 Strategy.
        // Exercise 02_19 is Project Ex_19
    }
}

public class HelpProgram
{
    public static void Exo02_13BadFonc(Target t)
    {
        t = t.ChangeDimensions(200, 90);
    }

    public static void readInteger(ref int integer)
    {
        while (!int.TryParse(ReadLine(), out integer))
        {
            WriteLine("Wrong input. Please, enter an integer.");
        }


    }

    public static void Exo02_14BadFonc(Point p)
    {
        p.Translate(2, 5);
    }

    public static void Exo02_14BadFonc2(Circle c)
    {
        c.Centre.Translate(2, 5);
    }

}

public class RifleShooting
{
    const int TARGETS_NUMBER = 5;
    Target?[] mTarget = new Target?[TARGETS_NUMBER];
    public int TargetsNumber
    {
        get { return mTarget.Length; }
    }
    public Target this[int index]
    {
        get
        {
            if (index < 0 || index >= mTarget.Length)
            {
                throw new IndexOutOfRangeException();
            }
            return (Target)mTarget[index];
        }
    }
    public RifleShooting(params Target[] targets)
    {
        int nbreMaxDeCibles = Math.Min(targets.Length, mTarget.Length);
        for (int index = 0; index < nbreMaxDeCibles; index++)
        {
            mTarget[index] = targets[index];
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Target :");
        foreach (Target? t in mTarget)
        {
            if (t == null)
            {
                sb.AppendLine("null");
            }
            else {
                sb.AppendLine(t.ToString());
            }
        }
        sb.AppendLine("**********************************");
        return sb.ToString();
    }
}
public struct Point
{
    public float X
    {
        get { return mX; }
    }
    private float mX;
    public float Y
    {
        get { return mY; }
    }
    private float mY;
    public Point(float x, float y)
    {
        mX = x;
        mY = y;
    }
    public Point Translate(float tx, float ty)
    {
        /*mX += tx;
        mY += ty;*/
        return new Point (mX + tx, mY + ty);
    }
}
public struct Circle
{
    public float Rayon
    {
        get { return mRayon; }
    }
    private readonly float mRayon;
    public Point Centre
    {
        get { return mCentre; }
    }
    private readonly Point mCentre;
    public Circle(float rayon, Point centre)
    {
        mRayon = rayon;
        mCentre = centre;
    }
}
/*public class Target
{
    public string Description
    {
        get;
        set;
    }
    public int Hauteur { get;  private set;}                                          //THIS CLASS IS MUTABLE. 

    public int Largeur { get; private set;}

    public void ChangeDimensions(int hauteur, int largeur)
    {
        Hauteur = hauteur;
        Largeur = largeur;
    }
    public Target(string desc, int hauteur, int largeur)
    {
        Description = desc;
        Hauteur = hauteur;
        Largeur = largeur;
    }
    public override string ToString()
    {
        return string.Format($"[Cible: Description={Description}, Hauteur ={Hauteur}, Largeur ={Largeur}]");
    }
}*/
public struct Target {
    public readonly string Description;
    public readonly int Height;
    public readonly int Length;
    public Target(string desc, int height, int length)
    {
        this.Description = desc;
        this.Height = height;
        this.Length = length;               //THIS CLASS IS IMMUTABLE.
    }

    public Target ChangeDimensions(int height, int length) {
        return new Target(Description, height, length);
    }

    

    public override string ToString()
    {
        return string.Format($"[Target:  Description = {Description}, Height = {Height}, Length = {Length}]");  
    }
}
public class CurlingClassment
{

    private static CurlingClassment mInstance = new CurlingClassment();
    private CurlingClassment()
    {
    }
    string[] mCountry = new string[] {
        "Canada","Scotland/Great Britain", "Norway",
        "Sweden", "Switzerland", "Germany", "USA",
        "France", "China", "Denmark", "Czech Republic",
        "New Zealand", "Italy", "Korea", "Finland",
        "Australia", "Russia", "Ireland", "Latvia"
    };

    int[] mPoints = new int[] {
        1064, 784, 774, 619, 550, 451,
        434, 426, 402, 384, 192, 179,
        141, 128, 122, 120, 115, 107,
        105
    };


    public object this[int index]
    {
        get {
            return index < 0 || index >= mCountry.Length ? null : mCountry[index]; }
        private set {}
    }

    public object this[string country]      
    {
        get { return mCountry.Contains(country) ? mPoints[Array.IndexOf(mCountry, country)] : -1; }
        set { }
    }
    

    public static CurlingClassment GetInstance() {
        return mInstance;
    }
    
}
struct Cobblestone
{
    public int Lenght { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public float Volume
    {
        get
        {
            return Lenght * Height * Width;
        }
    }
    public Cobblestone(int L, int H, int W) {
        this.Lenght = L;
        this.Height = H;
        this.Width = W;
    }
    public override string ToString()
    {
        return $"(L = {Lenght}, H = {Height}, W = {Width})";
    }
}
struct Vector
{
    public float x { get; set; }
    public float y { get; set; }
    public float z { get; set; }
    public double Norm
    {
        get
        {
            double value = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));
            return value;
        }
    }

    public Vector(float x, float y, float z) {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public override string ToString()
    {
        return $"({x}, {y}, {z})";
    }
}
