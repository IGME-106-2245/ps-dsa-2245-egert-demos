namespace IterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Enemy badguy = new Enemy(rng);

            // The enemy class can accept ANY IDamageable thing,
            // but players work because they implement that interface
            badguy.AddTarget(new Player("Pax", rng));
            badguy.AddTarget(new Player("Shiro", rng));
            badguy.AddTarget(new Vehicle("Tank"));
            badguy.AddTarget(new Vehicle("Scooter"));

            badguy.AttackAll();

        }
    }
}
