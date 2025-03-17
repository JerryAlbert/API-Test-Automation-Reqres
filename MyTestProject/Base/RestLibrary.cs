using RestSharp;

namespace MyTestProject.Base;

public class RestLibrary
{
    private RestClientOptions _restClientOptions;
    
    public RestLibrary()
    {
        _restClientOptions = new RestClientOptions
        {
            BaseUrl = new Uri("https://reqres.in"),
            RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
        };
        
        RestClient = new RestClient(_restClientOptions);
    }
    
    public RestClient RestClient { get;}
    
}