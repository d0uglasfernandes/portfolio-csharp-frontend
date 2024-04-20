using Microsoft.JSInterop;
using Portfolio.Blazor.Utils;

namespace Portfolio.Blazor.Services.Theme
{
    public class ThemeService(IJSRuntime js)
    {
        private readonly IJSRuntime _js = js;
        private bool isDarkMode = false;

        public async Task<bool> IsDarkMode()
        {
            return await _js.GetFromLocalStorage("theme") == "dark";
        }

        public async Task SetDarkMode(bool value)
        {
            isDarkMode = value;
            await _js.SetInLocalStorage("theme", value ? "dark" : "light");
            await _js.InvokeVoidAsync("setTheme", value);
        }
    }
}