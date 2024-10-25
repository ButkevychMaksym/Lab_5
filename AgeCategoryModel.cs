using System;

namespace WpfApp1.Models
{
    /// <summary>
    /// Represents a model for determining the age category based on a given age.
    /// </summary>
    public class AgeCategoryModel
    {
        /// <summary>
        /// Determines the age category based on the provided age.
        /// </summary>
        /// <param name="age">The age to evaluate.</param>
        /// <returns>A string representing the age category.</returns>
        /// <exception cref="ArgumentException">Thrown when age is negative.</exception>
        public string GetCategory(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
            else if (age <= 12)
            {
                return "Child"; // Age category for children
            }
            else if (age <= 19)
            {
                return "Teenager"; // Age category for teenagers
            }
            else if (age <= 60)
            {
                return "Adult"; // Age category for adults
            }
            else
            {
                return "Old"; // Age category for seniors
            }
        }
    }
}
