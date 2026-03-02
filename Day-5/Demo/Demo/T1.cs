using System;
using System.Collections.Generic;
using System.Linq;

class TextApplication
{
    static void Main()
    {
        // Reading the main input string from user
        string originalText = ReadInput("");

        // Reading substring to be searched
        string searchPattern = ReadInput("");

        // Reading character that needs to be replaced
        string oldCharInput = ReadInput("");
        char characterToRemove = oldCharInput[0];

        // Reading replacement character
        string newCharInput = ReadInput("");
        char characterToInsert = newCharInput[0];

        // Performing all operations
        bool isSubstringPresent = DoesSubstringExist(originalText, searchPattern);
        string updatedText = ReplaceGivenCharacter(originalText, characterToRemove, characterToInsert);
        string toggledCaseText = ConvertCharacterCase(originalText);
        string whitespaceFreeText = EliminateWhitespace(originalText);
        Dictionary<char, int> characterFrequency = CalculateLetterFrequency(originalText);

        // Displaying results
        Console.WriteLine($"Substring Exists: {(isSubstringPresent ? "Yes" : "No")}");
        Console.WriteLine($"Replaced: {updatedText}");
        Console.WriteLine($"Case Swapped: {toggledCaseText}");
        Console.WriteLine($"No Spaces: {whitespaceFreeText}");
        Console.WriteLine($"Letter Count: {string.Join(", ", characterFrequency.Select(pair => $"{pair.Key}: {pair.Value}"))}");
    }

    // Method to read input from console
    static string ReadInput(string message)
    {
        Console.WriteLine(message);
        string userInput = Console.ReadLine();
        return userInput;
    }

    // Method to check whether substring exists in main string
    static bool DoesSubstringExist(string mainText, string subText)
    {
        if (string.IsNullOrEmpty(subText))
        {
            return false;
        }

        bool result = mainText.Contains(subText);
        return result;
    }

    // Method to replace one character with another
    static string ReplaceGivenCharacter(string text, char oldCharacter, char newCharacter)
    {
        string modifiedText = text.Replace(oldCharacter, newCharacter);
        return modifiedText;
    }

    // Method to swap uppercase letters to lowercase and vice versa
    static string ConvertCharacterCase(string text)
    {
        char[] transformedCharacters = new char[text.Length];

        for (int index = 0; index < text.Length; index++)
        {
            char currentCharacter = text[index];

            if (char.IsUpper(currentCharacter))
            {
                transformedCharacters[index] = char.ToLower(currentCharacter);
            }
            else if (char.IsLower(currentCharacter))
            {
                transformedCharacters[index] = char.ToUpper(currentCharacter);
            }
            else
            {
                transformedCharacters[index] = currentCharacter;
            }
        }

        string finalText = new string(transformedCharacters);
        return finalText;
    }

    // UPDATED: Method to remove all whitespace characters (NO LINQ)
    static string EliminateWhitespace(string text)
    {
        System.Text.StringBuilder cleanedText = new System.Text.StringBuilder();

        for (int index = 0; index < text.Length; index++)
        {
            char currentCharacter = text[index];

            if (!char.IsWhiteSpace(currentCharacter))
            {
                cleanedText.Append(currentCharacter);
            }
        }

        return cleanedText.ToString();
    }

    // Method to count frequency of each letter USING FOR LOOP
    static Dictionary<char, int> CalculateLetterFrequency(string text)
    {
        Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

        for (int index = 0; index < text.Length; index++)
        {
            char character = text[index];

            if (char.IsLetter(character))
            {
                if (frequencyMap.ContainsKey(character))
                {
                    frequencyMap[character] = frequencyMap[character] + 1;
                }
                else
                {
                    frequencyMap.Add(character, 1);
                }
            }
        }

        return frequencyMap;
    }
}
