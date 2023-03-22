using Outfits.SDK;

namespace OutfitLibForApp
{
    public class Jacket : IOutfit
    {
        public void Geton(string color)
        {
            Console.WriteLine($"Now you wear {color} jacket.");
        }
    }
    public class Gear : IOutfit 
    {
        public void Geton(string color)
        {
            Console.WriteLine($"Now you wear {color} gear.");
        }
    }

    [Unfinished]
    public class Tshirt : IOutfit
    {
        public void Geton(string color)
        {
            Console.WriteLine($"Now you wear {color} Tshirt.");
        }
    }
}