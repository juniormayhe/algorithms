/*Folders

Tags
C# SERIALIZATION PUBLIC
Difficulty
Hard  
Expected time
20min Author
Josip Kremenić
Implement a function FolderNames, which accepts a string containing an XML file that specifies folder structure and returns all folder names that start with startingLetter. The XML format is given in the example below.

For example, for the letter 'u' and XML file:

<?xml version="1.0" encoding="UTF-8"?>
<folder name="c">
    <folder name="program files">
        <folder name="uninstall information" />
    </folder>
    <folder name="users" />
</folder>
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        //throw new NotImplementedException("Waiting to be implemented.");
		List<string> list = new List<string>();

		XmlDocument xmldoc = new XmlDocument();
		xmldoc.LoadXml(xml);
		XmlNodeList nodes = xmldoc.GetElementsByTagName("folder");
		for (int i=0; i< nodes.Count;i++)
		{
			string name = nodes[i].Attributes["name"].Value;
			if (name.IndexOf(startingLetter) == 0)
			{                    
				list.Add(name);
			}
			Console.WriteLine(name);
			//.SelectNodes("//folder/@name[starts-with(., '" + startingLetter + "')]")
		}
		return list;
    }

    public static void Main(string[] args)
    {
        string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

        foreach (string name in Folders.FolderNames(xml, 'u'))
            Console.WriteLine(name);
    }
}