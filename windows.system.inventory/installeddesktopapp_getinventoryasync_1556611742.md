---
-api-id: M:Windows.System.Inventory.InstalledDesktopApp.GetInventoryAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<InstalledDesktopApp>> InstalledDesktopApp.GetInventoryAsync()
-->

# Windows.System.Inventory.InstalledDesktopApp.GetInventoryAsync

## -description

Gets a list of installed Win32 apps available to the current user. This includes apps installed for all users as well as only for the current user.

## -returns

Returns an async operation indicating that the task has completed and containing a list of installed Win32 apps available to the current user.

## -remarks

The list includes apps installed for all users as well as only for the current user.

## -see-also

## -examples

```csharp
IReadOnlyList<InstalledDesktopApp> installedApps = await InstalledDesktopApp.GetInventoryAsync();
    
foreach (var app in installedApps)
{
    Console.WriteLine("Display Name: " + app.DisplayName);
    Console.WriteLine("Application ID: " + app.Id);
    Console.WriteLine("Publisher: " + app.Publisher);
    Console.WriteLine("Display Version: " + app.DisplayVersion);
}
```
