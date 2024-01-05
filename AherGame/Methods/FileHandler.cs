namespace AherGame.Methods;

public class FileHandler
{
    private const string WordsFilePath = "/Users/philip/RiderProjects/AherGame/AherGame/words.txt";

    public string[] LoadWordsFromFile()
    {
        try
        {
            // load words from a file and return them as an array of strings 
            return File.ReadAllLines(WordsFilePath);
        }
        catch (FileNotFoundException)
        {
            // if the file is not found I exit the program
            Console.WriteLine("Error: Words file not found.");
            Environment.Exit(1);
        }
        catch (IOException e)        
        {
            Console.WriteLine($"Error reading words file: {e.Message}");
            Environment.Exit(1);
        }
        return null;
    }
}