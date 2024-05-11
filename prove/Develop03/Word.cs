class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Generate hidden symbol based on the length of the word
            string hiddenSymbol = new string('_', _text.Length);
            return hiddenSymbol;
        }
        else
        {
            return _text;
        }
    }
}
