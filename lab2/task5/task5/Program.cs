using task5;

internal class Program
{
    private static void Main(string[] args)
    {
        Director director = new Director();
        HeroBuilder heroBuilder = new HeroBuilder();
        EnemyBuilder enemyBuilder = new EnemyBuilder();

        Hero hero = director.Hero(heroBuilder);
        Hero enemy = director.Enemy(enemyBuilder);

        Console.WriteLine("Hero:");
        hero.GetInfo();
        Console.WriteLine("Enemy:");
        enemy.GetInfo();
    }
}