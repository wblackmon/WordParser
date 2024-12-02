// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Objective:
////Create a class which will parse through the input

//Requirements:
//Create three different outputs
////one for a string of unique words delimited by a parameterized character
////one for a List of only words which have duplicates
////one for an DTO Array of each word and populate the properties

//Additional Notes:
////Do not modify the code contained in the Program class

Console.WriteLine("Welcome to the Word Parser Coding Challenge");
var wordParser = new WordParser();
var words = GetWords();

var distinctWordsDelimitedString = wordParser.ReturnUniqueWordsDelimited(words, delimiter: ",");
Console.WriteLine("ReturnUniqueWordsDelimited returned a count of " + distinctWordsDelimitedString.Split(',').Length);

var duplicateWordsList = wordParser.ReturnWordsWithDuplicatesList(words);
Console.WriteLine("ReturnWordsWithDuplicatesList returned a count of " + duplicateWordsList.Count);

var duplicatesDTOArray = wordParser.ReturnDuplicatesDTO(words);
Console.WriteLine("ReturnDuplicatesDTO returned a count of " + duplicatesDTOArray.Length);

Console.WriteLine("This concludes the Word Parser Coding Challenge!");
Console.WriteLine("Thank you for participating!");

/// <summary>
///  Only use the first column, ignore the second column
/// </summary>
/// <returns></returns>
static Dictionary<string, string> GetWords()
{
    var words = new Dictionary<string, string>();
    words.Add("policeman", "bad_data");
    words.Add("calculation", " ");
    words.Add("thread", "bad_data");
    words.Add("despair", "bad_data");
    words.Add("reflection", "bad_data");
    words.Add("penetrate", "bad_data");
    words.Add("conference", "bad_data");
    words.Add("worry", "bad_data");
    words.Add("divide", "bad_data");
    words.Add("organ", "bad_data");
    words.Add("limited", "bad_data");
    words.Add("smile", "bad_data");
    words.Add("strain", "bad_data");
    words.Add("expect", "bad_data");
    words.Add("alcohol", "bad_data");
    words.Add("moment", "");
    return words;
}