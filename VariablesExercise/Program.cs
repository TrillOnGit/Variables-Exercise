namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string catName = "Bill";
            int catWeightIbs = 42;
            char catFirstInitial = 'B';
            bool isOverweight = true;
            double preciseWeight = 41.8234567890123;
            decimal yearsInVet = 0.000762M;

            Console.WriteLine($"My cat's name is {catName}, He is {catWeightIbs} pounds, or more precisely he is {preciseWeight} pounds.");
            
        }
    }
}
