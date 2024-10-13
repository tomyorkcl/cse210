using System;

public class Reference
{
    private int _bookNumber;
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;
    private string reference;

    public Reference(string reference)
    {
        ParseReference(reference);
    }

     private void ParseReference(string reference)
    {

        //Divide the output or the scripture in parts
        //For example 1 Juan 1:2-3 --> {Juan} {1} {2}{3}
        var parts = reference.Split(' ');

        if (parts.Length > 1)
        {
            _bookNumber = int.Parse(parts[0]);
            _book = parts[1];
            var chapterAndVerse = parts[2].Split(':');
            _chapter = int.Parse(chapterAndVerse[0]);

            var verseParts = chapterAndVerse[1].Split('-');
            _verse = int.Parse(verseParts[0]);

            if (verseParts.Length > 1)
            {
                _endVerse = int.Parse(verseParts[1]);
            }
            
            else
            {
                _endVerse = null; // null if the book not have the number.

                //for example Alma 2:3 dont haver the number. '1' Nephi 2:3 have the number.
            }
        }
    }

    public string GetReference()
    {
        if (_endVerse.HasValue)
        {
            return $"{_bookNumber} {_book} {_chapter}:{_verse}-{_endVerse.Value}";
        }
        else
        {
            return $"{_bookNumber} {_book} {_chapter}:{_verse}";
        }
    }
}