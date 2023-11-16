namespace Fundamentals.Extensions
{
    public static class RandomExtensions
    {
        public static int GetTemperatureRandom(this Random random) 
        {
            return random.Next(-20, 55);
        }
    }
}
