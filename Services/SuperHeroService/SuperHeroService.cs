namespace SuperHerosApi.Services.SuperHeroService
{
    // SuperHeroService class implements the ISuperHeroService interface
    public class SuperHeroService : ISuperHeroService
    {
        
        private static List<SuperHero> superHeroes = new List<SuperHero> // Static list of superheroes for demonstration purposes.
        {
            // Preset superheros added to the list, testing for functionality.
            new SuperHero
            {
                Id = 1,
                Name = "Captain America",
                FirstName = "Steven",
                LastName = "Rogers",
                Place = "New York City"
            },

            new SuperHero
            {
                Id = 2,
                Name = "Black Panther",
                FirstName = "T",
                LastName = "Challa",
                Place = "Wakanda"
            },

            new SuperHero
            {
                Id = 3,
                Name = "Thor",
                FirstName = "Thor",
                LastName = "Odinson",
                Place = "God of Sky"
            },

            new SuperHero
            {
                Id = 4,
                Name = "Ironman",
                FirstName = "Tony",
                LastName = "Stark",
                Place = "Malibu"
            }
        };

        
        public List<SuperHero> AddHero(SuperHero hero) // Adds a new superhero to the DB.
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        
        public List<SuperHero>? DeleteHero(int id) // Deletes a superhero from the DB by ID.
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            superHeroes.Remove(hero);

            return superHeroes;
        }

        
        public List<SuperHero> GetAllHeroes() // Retrieves a list of all superheroes within the DB.
        {
            return superHeroes;
        }

        
        public SuperHero? GetSingleHero(int id) // Retrieves a single superhero by ID.
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;
            return hero;
        }

        
        public List<SuperHero>? UpdateHero(int id, SuperHero request) // Updates the information of an existing superhero by ID.
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            // Updates superhero properties with the provided request.
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Name = request.Name;
            hero.Place = request.Place;

            return superHeroes;
        }
    }
}