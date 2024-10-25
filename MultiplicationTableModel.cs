namespace WpfApp1.Models
{
    /// <summary>
    /// Represents a model for generating a multiplication table for a given number.
    /// </summary>
    public class MultiplicationTableModel
    {
        /// <summary>
        /// Generates a multiplication table for the specified number.
        /// </summary>
        /// <param name="number">The number for which to generate the multiplication table.</param>
        /// <returns>A string containing the multiplication table from 1 to 10.</returns>
        public string GenerateTable(int number)
        {
            string table = ""; // Initialize the table string
            // Loop through numbers 1 to 10 to create the multiplication table
            for (int i = 1; i <= 10; i++)
            {
                table += $"{number} * {i} = {number * i}\n"; // Append each line of the table
            }
            return table; // Return the complete multiplication table
        }
    }
}
