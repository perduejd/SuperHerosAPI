namespace SuperHerosApi.Models
{
	public class SuperHero

	{
		public int Id { get; set; } // # of the superhero stored in the DB.

		public string Name { get; set; } = string.Empty; // Name of the superhero stored or created.

        public string FirstName { get; set; } = string.Empty; // First name of the superhero in the DB.

        public string LastName { get; set; } = string.Empty; // Last name of the superhero in the DB.

        public string Place { get; set; } = string.Empty; // Location of where the superhero is from in the DB.
    }
}