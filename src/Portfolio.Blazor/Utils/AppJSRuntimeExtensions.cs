using Microsoft.JSInterop;

namespace Portfolio.Blazor.Utils
{
    public static class AppJSRuntimeExtensions
    {
        public static ValueTask<object> SetInLocalStorage(this IJSRuntime js, string key, string content) =>
            js.InvokeAsync<object>("localStorage.setItem", key, content);

        public static ValueTask<string> GetFromLocalStorage(this IJSRuntime js, string key) =>
            js.InvokeAsync<string>("localStorage.getItem", key);
    }
}