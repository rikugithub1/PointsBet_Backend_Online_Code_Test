using System.Text;

namespace PointsBet_Backend_Online_Code_Test
{
    public class StringFormatter
    {

        //Code to improve
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            if (items == null || items.Length == 0)
            {
                throw new ArgumentException("items is null or empty");
            }

            if (quote == null)
            {
                throw new ArgumentException("quote is null");
            }

            return String.Join(", ", items
                    .Where(item => !String.IsNullOrWhiteSpace(item))
                    .Select(item => $"{quote}{item}{quote}")
                );
        }
    }
}
