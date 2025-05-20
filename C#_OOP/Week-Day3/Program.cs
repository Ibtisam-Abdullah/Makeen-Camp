namespace Week2_Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(5, 3, "blue");
            Rectangle r2 = new Rectangle(4, 6, "green");
            Rectangle r3 = new Rectangle(-3, 6, "red");
            Rectangle r4 = new Rectangle("orange");
            Rectangle r5 = new Rectangle(4, 6);
            //r1.width = 5;
            //r1.height = 2;
            //r1.colore = "red";
            Console.WriteLine(r1.areaInfo());
            Console.WriteLine(r2.areaInfo());
            Console.WriteLine(r3.areaInfo());
            Console.WriteLine(r4.areaInfo());
            Console.WriteLine(r5.areaInfo());
        }
    }

    // Rectangle Class
    public class Rectangle
    {
        private readonly int height = 4;
        private readonly int width = 8;
        private readonly string colore = "black";

        // constructor 1 -> give all alues 
        public Rectangle(int height, int width, string colore)
        {
            if (height > 0 && width > 0)
            {
                this.height = height;
                this.width = width;
                this.colore=colore;
            }
            else
            {
                this.height = 4;
                this.width = 7;
                this.colore= colore;
            }
        }

        // constructor 2 -> give color value
        public Rectangle(int height, int width) : this(height, width, "yellow")
        {

        }

        // constructor 3 -. give height & width values
        public Rectangle(string colore) : this(2, 5, colore)
        {

        }
        // method 1
        public int calculateArea()
        {
            int area = height * width;
            return area;
        }

        // method 2
        public string areaInfo()
        {
            return $"The Area of a {colore} rectangle with {height} height, " +
                $"and {width} width is {calculateArea()}";
        }

    }
}
