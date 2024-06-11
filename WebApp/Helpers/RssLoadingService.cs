namespace WebApp.Helpers;

public class RssLoadingService
{
    private LocalStorageService ls;

    public RssLoadingService(LocalStorageService localstorage)
    {
        ls = localstorage;
    }
    
}