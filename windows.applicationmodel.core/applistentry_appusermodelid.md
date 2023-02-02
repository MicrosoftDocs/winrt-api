---
-api-id: P:Windows.ApplicationModel.Core.AppListEntry.AppUserModelId
-api-type: winrt property
---

<!-- Property syntax.
public string AppUserModelId { get; }
-->

# Windows.ApplicationModel.Core.AppListEntry.AppUserModelId

## -description

Gets the **Application User Model ID (AUMID)** for this `AppListEntry`.

## -property-value

A string representing the app's identity.

## -remarks

An **AUMID** is a persistable value that you can use to identify an application. It's based on **package family name** + **Package Relative Application ID (PRAID)**.

| Identifier | Description |
|--------|--------|
| Package family name | Name + Publisher (the `<Identity>` element found in **appxmanifest.xml**). |
| PRAID | The `Id` property of the `Application` found in **appxmanifest.xml** (e.g. `<Application Id="Foo"...>`). |

The AUMID is independent of package version or architecture, so it can be used to identify an app across multiple versions or platforms.

## -see-also

## -examples

```csharp
// Find and activate the desired application (if present on this machine)
using namespace Windows.Management.Deployment;

async Task<bool> RunApplicationAsync(string aumid)
{
  var packageManager = new Windows.Management.Deployment.PackageManager();
  IEnumerable<Package> packages = packageManager.FindPackagesForUserWithPackageTypes(
      null, PackageTypes.Main | PackageTypes.Optional);

  foreach (Package package in packages)
  {
    IReadOnlyList<AppListEntry> entries = await package.GetAppListEntriesAsync();
    foreach (AppListEntry entry in entries)
    {
      if (String.Equals(entry.AppUserModelId, aumid, StringComparison.OrdinalIgnoreCase))
      {
        return await entry.LaunchAsync();
      }
    }
  }
  return false;
}
```
