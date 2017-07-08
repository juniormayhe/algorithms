using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParagraphApp
{
    class Paragraph
    {
        
        public static string ChangeDateFormat(string paragraph)
        {
            const string validationExpression = @"(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}";
            Regex r = new Regex(validationExpression);
            var oldDates = r.Matches(paragraph);
            foreach (Match oldDate in oldDates) {
                string[] date = oldDate.Value.Split('/');
                string newDate = $"{date[1]}/{date[0]}/{date[2]}";
                paragraph = paragraph.Replace(oldDate.Value, newDate);
            }

            return paragraph;
        }

        static void Main(string[] args)
        {
            string paragraph = "Last time it rained was on 07/25/2013 and today is 08/09/2013.";
            
            Console.WriteLine(ChangeDateFormat(paragraph) );
            Console.Read();
        }
    }
}
