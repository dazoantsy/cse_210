class Comment
{
    public string _name;
    public string _comment;
    public string[] _commentDetails = new string[] {"", ""};
    //public List<string> _commnents;

    public Comment (string name, string comment)
    {
        _name = name;
        _comment = comment;
        _commentDetails[0] = _name;
        _commentDetails[1] = _comment;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetComment()
    {
        return _comment;
    }
    public void SetComment(string comment)
    {
        _comment = comment;
    }

    public string[] GetCommentDetails()
    {
        return _commentDetails;
    }
}