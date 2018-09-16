using System.Collections.Generic;
using APIVersioningDemo.Model;

namespace APIVersioningDemo.Data
{
    public class Seed
    {
        private static readonly List<Information> UserData = new List<Information>()
        {
            new Information()
            {
                Id = 1,
                FirstName = "Ashley",
                LastName = "C. Dunn",
                Gender = "Female",
                Email = "Ashley@api.com",
                Number = "+91-98765432XX"
            },

            new Information()
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "E. Linn",
                Gender = "Female",
                Email = "Sarah@api.com",
                Number = "+91-98765432XX"
            },

            new Information()
            {
                Id = 3,
                FirstName = "Nancy",
                LastName = "R. Smoak",
                Gender = "Female",
                Email = "Nancy@api.com",
                Number = "+91-98765432XX"
            },
        };

        public List<Information> Info { get; } = UserData;
    }
}
