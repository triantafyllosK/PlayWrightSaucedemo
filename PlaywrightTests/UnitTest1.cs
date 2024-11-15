using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class SauceDemoTests : PageTest
{
    [Test]
    public async Task ShouldLoginSuccessfully()
    {
        await Page.GotoAsync("https://www.saucedemo.com/");
        await Page.FillAsync("#user-name", "standard_user");
        await Page.FillAsync("#password", "secret_sauce");
        await Page.ClickAsync("#login-button");
        
        await Expect(Page).ToHaveURLAsync("https://www.saucedemo.com/inventory.html");
    }
}