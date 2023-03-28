using System;

namespace BassicClass
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }
    
    class MainApp
    {
        static void Main(string args[])
        {
            Cat kitty = new BassicClass.Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name}:{kitty.Color}");

            Cat nero = new BassicClass.Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name}: {nero.Color}");
        }
    }
}