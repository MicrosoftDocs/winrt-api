---
-api-id: T:Windows.System.Inventory.InstalledDesktopApp
-api-type: winrt class
---

<!-- Class syntax.
public class InstalledDesktopApp : IStringable
-->

# Windows.System.Inventory.InstalledDesktopApp

## -description
Provides a list of installed Win32 apps available to the current user. This includes apps installed for all users as well as only for the current user.

## -remarks
InstalledDesktopApp checks for the **packageQuery** capability and returns an empty vector if the capability isn’t held by the caller.

## -see-also

## -examples
```csharp
IReadOnlyList<IInstalledDesktopApp> installedApps = await InstalledDesktopApp.GetInventoryAsync();
    
foreach (var app in installedApps)
{
    Console.WriteLine("Display Name: " + app.DisplayName);
    Console.WriteLine("Application ID: " + app.Id);
    Console.WriteLine("Publisher: " + app.Publisher);
    Console.WriteLine("Display Version: " + app.DisplayVersion);
}
```

## -capabilities
packageQuery
