using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Wolverine fewest battles
        // Pheonix most battles

        string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
        int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

        string result = " ";

        // Initializing variables to 0
        int largestNumIndex = 0;
        int smallestNumIndex = 0;

        for (int i = 0; i < names.Length; i++)
        {
            // Is this the largest count so far?
            if (numbers[i] > numbers[largestNumIndex])  // If this is the largest number we've seen so far, set largestNumIndex to that number
            {
                largestNumIndex = i;
            }

            // Is this the smallest count so far?
            if (numbers[i] < numbers[smallestNumIndex]) // If this is the smallest number we've seen so far, set smallestNumIndex to that number
            {
                smallestNumIndex = i;
            }




            result = String.Format("Most battles belong to: {0} (Value: {1})<br>Least battles belong to: {2} (Value: {3})", 
                names[largestNumIndex], 
                numbers[largestNumIndex], 
                names[smallestNumIndex], 
                numbers[smallestNumIndex]);
        }




        

        resultLabel.Text = result;
    }

    
}