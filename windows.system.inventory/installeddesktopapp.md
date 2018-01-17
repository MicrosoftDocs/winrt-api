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

## -see-also

## -examples
```csharp
IList<IInstalledDesktopApp> installedApps = InstalledDesktopApp::GetInventoryAsync();
    
foreach(var app in installedApps)
{
    Console.WriteLine("Display Name: " + app.DisplayName);
    Console.WriteLine("Application ID: " + app.Id);
    Console.WriteLine("Publisher: " + app.Publisher);
    Console.WriteLine("Display Version: " + app.DisplayVersion);
}
```  

