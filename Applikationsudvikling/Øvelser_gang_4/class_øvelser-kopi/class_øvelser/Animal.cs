using System;
namespace class_øvelser
{
    public class Animal
    {
        public string _sound;
      
        public Animal(string s)
        {
            _sound = s;
         }
        public void Bark()
        {
            Console.WriteLine($"{_sound}");

        }
        public string sound
        {
            get { return sound; }
            set { sound = value;}
        }

    }
    }

