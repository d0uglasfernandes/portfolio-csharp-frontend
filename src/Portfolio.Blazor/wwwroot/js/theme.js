function setTheme(isDarkMode)
{
    if (isDarkMode)
    {
        window.document.body.classList.add('dark');
    }
    else
    {
        window.document.body.classList.remove('dark');
    }
}