using System;

class Entry
{
    public string _prompt;
    public string _response;
    public string _date;
    public Entry(string _prompt, string _response, string _date) 
    {
        this._prompt = _prompt;
        this._response = _response;
        this._date = _date;
    }

    public string DisplayEntry()
    {
        return _prompt + "\n" + _response + "\n" + _date;
    }
}