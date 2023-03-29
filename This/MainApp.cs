using System;

namespace This
{
    class Emplogyee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position);
        {
             this.Position=Position;
        }

        public string GetPosition()
        {
             return this.GetPosition;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Emplogyee pooh = new Emplogyee();
            pooh.SetName("Pooh");
            pooh SetPosition("Water");
            Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Emplogyee tigger = new Emplogyee();
            tigger.SetName("Tigger");
            tigger SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
        }
    }
}  