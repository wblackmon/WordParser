
public class WordParser
{
	public string ReturnUniqueWordsDelimited(Dictionary<string, string> words, string delimiter)
	{
		var uniqueWords = new Dictionary<string, int>() { };

		foreach (var word in words)
		{
			if (uniqueWords.ContainsKey(word.Key))
			{
				uniqueWords[word.Key] += 1;
			}
			else
			{
				uniqueWords.Add(word.Key, 1);
			}
		}

		var uniqueWordsString = string.Join(delimiter, uniqueWords.Where(u => u.Value == 1).Select(kvp => kvp.Key));
		Console.WriteLine($"Unique words: {uniqueWordsString}");

		return uniqueWordsString;
	}

	public List<string> ReturnWordsWithDuplicatesList(Dictionary<string, string> words)
	{
		Dictionary<string, int> duplicateWords = DuplicateWords(words);

		var duplicateWordsList = duplicateWords.Select(kvp => kvp.Key).ToList();

		return duplicateWordsList;
	}

	private static Dictionary<string, int> DuplicateWords(Dictionary<string, string> words)
	{
		var duplicateWords = new Dictionary<string, int>();

		foreach (var word in words)
		{
			if (duplicateWords.ContainsKey(word.Key))
			{
				duplicateWords[word.Key] += 1;
			}
			else
			{
				duplicateWords.Add(word.Key, 1);
			}
		}

		// Use ToDictionary to create a dictionary from the filtered results
		duplicateWords = duplicateWords.Where(kvp => kvp.Value > 1)
									   .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

		return duplicateWords;
	}
	
	public DuplicatesDTO[] ReturnDuplicatesDTO(Dictionary<string, string> words)
	{
		var duplicateWords = DuplicateWords(words);

		List<DuplicatesDTO> dupesDto = new List<DuplicatesDTO>() { };

		foreach (var dupe in duplicateWords)
		{
			var tempDTO = new DuplicatesDTO
			{
				Word = dupe.Key,
				Count = dupe.Value
			};

			dupesDto.Add(tempDTO);
		}
		return dupesDto.ToArray();
	}
}

public class DuplicatesDTO
{
	public string Word { get; set; }
	public int? Count { get; set; }
}