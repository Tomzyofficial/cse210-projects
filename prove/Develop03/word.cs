using System;

public class Word
{
  private string _text;
  private bool _isHidden;

  public Word(string text)
  {
    this._text = text;
    this._isHidden = false;
  }

  // Method to hide the word
  public void Hide()
  {
    _isHidden = true;
  }

  // Method to check if the word is hidden
  public bool IsHidden()
  {
    return _isHidden;
  }

  // Method to get the text or underscores if hidden
  public string GetDisplayText()
  {
    return _isHidden ? new string('_', _text.Length) : _text;
  }
}