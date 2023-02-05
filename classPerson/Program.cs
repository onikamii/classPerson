using System;
namespace classPerson
{
    class Person
    {
        public string fullName;
        public int age;
        public Person(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }
        public Person()
        {

        }
        public void move(string fullName)
        {
            Console.WriteLine(fullName, "двигается");
        }
        public void talk(string fullName)
        {
            Console.WriteLine(fullName, "говорит");
        }
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Oleg", 23);
            person2.move("Oleg");
            person2.talk("Mihail");
        }      
    }
}