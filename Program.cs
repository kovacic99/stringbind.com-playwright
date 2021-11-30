using Microsoft.Playwright;
using System;
using System.Threading.Tasks;
class Program
{
    public static async Task Main()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
            SlowMo = 200,
        });
        var context = await browser.NewContextAsync();

        // Open new page
        var page = await context.NewPageAsync();

        await page.GotoAsync("https://stringbind.com/");
        await page.ClickAsync("text=About");
        await page.ClickAsync("text=Services");
        await page.ClickAsync("text=Projects");
        await page.ClickAsync("text=Project Startup");
        await page.ClickAsync("text=Contact");
    }
}


