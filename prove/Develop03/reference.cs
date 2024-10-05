using System;

public class Reference
{
  private string _book;
  private int _chapter;
  private int _startVerse;
  private int _endVerse;

  // Constructor for a single verse
  public Reference(string book, int chapter, int verse)
  {
    this._book = book;
    this._chapter = chapter;
    this._startVerse = verse;
    this._endVerse = verse; // Ensure start and end verse are the same
  }

  // Constructor for a range of verses
  public Reference(string book, int chapter, int startVerse, int endVerse)
  {
    this._book = book;
    this._chapter = chapter;
    this._startVerse = startVerse;
    this._endVerse = endVerse;
  }

  public string GetFormattedReference()
  {
    if (_startVerse == _endVerse)
    {
      return $"{_book} {_chapter}:{_startVerse}";
    }
    else
    {
      return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
  }
}