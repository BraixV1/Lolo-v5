using Microsoft.JSInterop;

namespace WebApp.Helpers;

public class LocalStorageService
{
    private IJSRuntime js;

    public LocalStorageService(IJSRuntime jsRuntime)
    {
        js = jsRuntime;
    }

    public async Task AddLink(string key, string value)
    {
        await js.InvokeVoidAsync("localStorage.setItem", key, value);
    }
    
    public async Task<string> GetItem(string key)
    {
        return await js.InvokeAsync<string>("localStorage.getItem", key);
    }

    public async Task RemoveItem(string key)
    {
        await js.InvokeVoidAsync("localStorage.removeItem", key);
    }
}