using SP01;
namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Target target = new Target() {Hp = 100 };
            int counter = 0;

            Console.WriteLine("Choose your weapon:");
            string name  = Console.ReadLine();

            IWeapon weapon = Weapons.Create(name);

            while(target.Hp > 0)
            {
                counter++;
                target.Hp -= weapon.Damage;
            }

            Console.WriteLine($"Понадобилось {counter} выстрелов чтобы убить мишень");

        }
    }
}
