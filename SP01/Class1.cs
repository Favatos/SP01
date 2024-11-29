namespace SP01
{
    public interface IWeapon
    {   
        public int Damage { get; }
        public float Interval { get; }
        public string Name { get; }
    }

    internal class Pistol : IWeapon {
        public int Damage => 20;
        public float Interval => 0.25f;
        public string Name => "Pistol";

    }

    internal class Shotgun : IWeapon
    {
        public int Damage => 40;
        public float Interval => 0.8f;
        public string Name => "Shotgun";

    }

    internal class Rifle : IWeapon
    {
        public int Damage => 30;
        public float Interval => 0.4f;
        public string Name => "Rifle";

    }

    public static class Weapons
    {
        public static IWeapon Create(string weaponType)
        {
            switch (weaponType.ToLower())
            {
                case "shotgun":
                    return new Shotgun();
                case "pistol":
                    return new Pistol();
                case "rifle":
                    return new Rifle();
                default:
                    throw new ArgumentException("Неизвестный тип оружия.");
            }
        }
    }
}
