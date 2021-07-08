public class BuildGitHub
{    
    public string Owner { get; private set; }
    public string Repository { get; private set; }
    public string Url => $"https://github.com/{Owner}/{Repository}";
    public string UserName { get; private set; }
    public string Password { get; private set; }

    public BuildGitHub(
        string owner,
        string repository,
        string userName, 
        string password)
    {
        Owner = owner;
        Repository = repository;
        UserName = userName;
        Password = password;
    }

    public static BuildGitHub GetWithCredentials(ICakeContext context, string owner, string repository)
    {
        var username = context.EnvironmentVariable("GITHUB_USERNAME");
        var token = context.EnvironmentVariable("GITHUB_TOKEN");
        return new BuildGitHub(owner, repository, username, token);            
    } 

    public override string ToString()
    {
        return $"Owner: {Owner}\nRepository: {Repository}\nUrl: {Url}\nUserName: {UserName}\nPassword: {Password}";
    }  
}

public class BuildNuGet
{    
    public string ApiUrl { get; private set; }
    public string ApiKey { get; private set; }

    public BuildNuGet(string apiUrl, string apiKey)
    {        
        ApiUrl = apiUrl;
        ApiKey = apiKey;
    }

    public static BuildNuGet GetWithCredentials(ICakeContext context)
    {
        var apiUrl = context.EnvironmentVariable("NUGET_API_URL");
        if(apiUrl == null) 
        {      
             apiUrl = "https://api.nuget.org/v3/index.json";
        }

        var apiKey = context.EnvironmentVariable("NUGET_API_KEY");
        return new BuildNuGet(apiUrl, apiKey);
    }

    public override string ToString()
    {
        return $"ApiUrl: {ApiUrl}";
    }

}