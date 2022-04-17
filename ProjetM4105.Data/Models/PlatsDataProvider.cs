using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProjetM4105.Data.Models
{
    public class PlatsDataProvider : DropCreateDatabaseAlways<PlatContext>
    {
        protected override void Seed(PlatContext context)
        {
            GetPlats().ForEach(p => context.Plats.Add(p));
        }

        private static List<Plats> GetPlats()
        {
            var plats = new List<Plats> {
                new Plats
                {
                    PlatID = 1,
                    PlatName = "Chicken GYOZAS ",
                    Description = "Delicious snacked Japanese ravioli with chicken and vegetables (cabbage, leeks, onions)",
                    ImagePath="~/Content/Images/gyozaspoulet.jpg",
                    UnitPrice =  10.42,
                    Category = Category.Entree
               },
                new Plats
                {
                    PlatID = 2,
                    PlatName = "MINI SALMON BOWL",
                    Description = "Vinegar rice base, marinated fresh salmon, cream cheese, avocado, Thai spring onion and sesame.",
                    ImagePath="~/Content/Images/salmonbowl.jpg",
                    UnitPrice = 8,
                    Category = Category.Entree
               },
               
                new Plats
                {
                    PlatID = 3,
                    PlatName = "BALI BOWL",
                    Description = "Our new poké composed of tender caramelized chicken fillets with satay sauce, a duo of fresh carrots. Chioggia beetroot is added to the recipe, to add a touch of color and acidity!",
                    ImagePath="~/Content/Images/balibowl.jpeg",
                    UnitPrice = 20.69,
                    Category = Category.Plat
                },
                new Plats
                {
                    PlatID = 4,
                    PlatName = "CHIRASHI SALMON AVOCADO",
                    Description = "Choice of base, fresh salmon, half an avocado, Thai cebette, sesame seeds.",
                    ImagePath="~/Content/Images/saumonavocat.jpg",
                    UnitPrice = 18.69,
                    Category = Category.Plat
                },
                new Plats
                {
                    PlatID = 5,
                    PlatName = "GREEN LOVER",
                    Description = "Choice of base, marinated fresh salmon, avocado, edamame, sesame seeds and Thai spring onion.",
                    ImagePath="~/Content/Images/greenlover.jpg",
                    UnitPrice = 25.69,
                    Category = Category.Plat
                },
                new Plats
                {
                    PlatID = 6,
                    PlatName = "CHILLED, CBD WATER",
                    Description = "Chilled is a hibiscus-infused CBD sparkling source. A perfect remedy for everyday stress and anxiety.",
                    ImagePath="~/Content/Images/cbdwater.png",
                    UnitPrice = 4.69,
                    Category = Category.Boisson
                },
                new Plats
                {
                    PlatID = 7,
                    PlatName = "COCA-COLAS",
                    Description = "Our American friend, original and refreshing since 1886!",
                    ImagePath="~/Content/Images/coca.jpg",
                    UnitPrice = 105.69,
                    Category = Category.Boisson
                },
                new Plats
                {
                    PlatID = 8,
                    PlatName = "LEMONAID GINGER BIO",
                    Description = "Energy and natural drink! A stimulating version with pure ginger and lemon juice. Chills guaranteed!",
                    ImagePath="~/Content/Images/ginger.jpg",
                    UnitPrice = 4.69,
                    Category = Category.Boisson
                },
                new Plats
                {
                    PlatID = 8,
                    PlatName = "FRUIT NINJA",
                    Description = "As addictive as the game! Our exotic fruit salad brings you a touch of freshness with its beautiful pieces of fresh mango and pineapple.",
                    ImagePath="~/Content/Images/fruitninja.png",
                    UnitPrice = 4.69,
                    Category = Category.Dessert
                },
                new Plats
                {
                    PlatID = 8,
                    PlatName = "CHEESECAKE",
                    Description = "Cheesecake and its fresh raspberry coulis. Yum yum, a creamy and sweet touch to end in style.",
                    ImagePath="~/Content/Images/cheeskake.png",
                    UnitPrice = 4.69,
                    Category = Category.Dessert
                },
                new Plats
                {
                    PlatID = 8,
                    PlatName = "PUDDING VEGAN",
                    Description = "Coconut milk, chia pearls and fresh raspberry coulis the perfect dessert to end your Hawaiian getaway!",
                    ImagePath="~/Content/Images/pudding.png",
                    UnitPrice = 4.69,
                    Category = Category.Dessert
                }

            };

            return plats;
        }
    }
}
