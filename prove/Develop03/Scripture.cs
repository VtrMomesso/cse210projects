using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private readonly Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        InitializeWords(text);
    }

    private void InitializeWords(string text)
    {
        string[] wordArray = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        _words = wordArray.Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide <= 0)
            throw new ArgumentException("Number of words to hide must be greater than 0.");

        Random random = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberToHide)
        {
            int index = random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
