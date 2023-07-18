using System;
using System.Collections.Generic;

class Video
{
    public string _title;
    public string _author;
    public int _length;
    public string[] _commentInfo;
    public List<string[]> comments = new List<string[]> {};
    
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public int GetLength()
    {
        return _length;
    }
    public void SetLength(int length)
    {
        _length = length;
    }

    public void AddComment(string[] commentInfo)
    {
        _commentInfo = commentInfo;
        comments.Add(_commentInfo);
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }
}