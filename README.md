# PlayWrightSaucedemo
We will create some basic tests with Playwright to saucedemo.com page using .NET

## Setup
- dotnet new nunit -n PlaywrightTests
- dotnet add package Microsoft.Playwright
- dotnet add package Microsoft.Playwright.NUnit
- pwsh bin/Debug/net8.0/playwright.ps1 install

## Run Tests
- dotnet test
- dotnet test --filter "FullyQualifiedName~TestClass1"

## Debug Tests
- Set breakpoints in Visual Studio
- Run tests in debug mode

## View Test Results
- Test results will be available in the Test Explorer

