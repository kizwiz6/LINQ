namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nintendoCharacters = { "Super Mario", "Link", "Peach", "Donkey Kong", "Luigi", "Waluigi", "Wario", "Toad", "Daisy" };

            // Separate statements
            var nintendoCharactersWithA = nintendoCharacters.Where(n => n.Contains("a"));
            var lowerNintendoCharactersWithA = nintendoCharactersWithA.Select(n => n.ToLower());

            // Chained expressions
            var sameResult = nintendoCharacters
                .Select(n => n.ToLower())
                .Where(n => n.Contains("a"));

            foreach ( var n in nintendoCharactersWithA )
            {
                Console.WriteLine(n);
            }

            foreach ( var n in sameResult)
            {
                Console.WriteLine(n);
            }

        }
    }
}
