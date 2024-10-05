using System;

public class Scripture
{
  private Reference _reference;
  private List<Word> _words;

  public Scripture(Reference reference, string text)
  {
    this._reference = reference;
    _words = new List<Word>();

    // Split the text into words and create Word objects
    foreach (string wordText in text.Split(' '))
    {
      _words.Add(new Word(wordText));
    }
  }

  // Method to display the scripture
  public void Display()
  {
    Console.WriteLine(_reference.GetFormattedReference());
    foreach (Word word in _words)
    {
      Console.Write(word.GetDisplayText() + " ");
    }
    Console.WriteLine();
  }

  // Method to hide a few random words
  public void HideRandomWords()
  {
    Random random = new Random();
    int wordsToHide = 3; // Number of words to hide at a time
    int attempts = 0;

    while (attempts < wordsToHide)
    {
      int index = random.Next(_words.Count);
      if (!_words[index].IsHidden()) // Only hide if the word is not hidden yet
      {
        _words[index].Hide();
        attempts++;
      }
    }
  }

  // Method to check if all words are hidden
  public bool AllWordsHidden()
  {
    return _words.All(word => word.IsHidden());
  }
}