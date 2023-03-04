namespace CSTypes;
public class User
{
    private string id;
    public string Id
    {
        get { return id; }
    }

    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private string email;
    private string password;
}
