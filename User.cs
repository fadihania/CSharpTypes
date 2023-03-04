namespace CSTypes;
public class User
{
    private string id;
    public string GetId()
    {
        return id;
    }

    private string name;
    public string GetName()
    {
        return name;
    }
    public void SetName(string v)
    {
        name = v;
    }

    private string email;
    private string password;
}
