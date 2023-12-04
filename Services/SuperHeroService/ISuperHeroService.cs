namespace SuperHerosApi.Services.SuperHeroService
{
    /// <summary>
    /// Interface for defining operations related to superhero entities.
    /// </summary>
    public interface ISuperHeroService
    {
        /// <summary>
        /// Retrieves a list of all superheroes stored in the DB.
        /// </summary>
        List<SuperHero> GetAllHeroes();

        /// <summary>
        /// Retrieves a single superhero by ID.
        /// </summary>
        /// <param name="id">The ID of the superhero to retrieve.</param>
        /// <returns>The superhero matching the specified ID.</returns>
        SuperHero? GetSingleHero(int id);

        /// <summary>
        /// Adds a new superhero to the DB.
        /// </summary>
        /// <param name="hero">The superhero to be added.</param>
        /// <returns>The updated list of superheroes after adding the new hero.</returns>
        List<SuperHero> AddHero(SuperHero hero);

        /// <summary>
        /// Updates the information of an existing superhero by ID.
        /// </summary>
        /// <param name="id">The ID of the superhero to be updated.</param>
        /// <param name="request">The updated information for the superhero.</param>
        /// <returns>The updated list of superheroes after modifying the specified hero.</returns>
        List<SuperHero>? UpdateHero(int id, SuperHero request);

        /// <summary>
        /// Deletes a superhero from the DB by ID.
        /// </summary>
        /// <param name="id">The ID of the superhero to be deleted.</param>
        /// <returns>The updated list of superheroes after removing the specified hero.</returns>
        List<SuperHero>? DeleteHero(int id);
    }
}