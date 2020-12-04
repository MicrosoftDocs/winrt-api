---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceManager.LoadPriFiles(Windows.Foundation.Collections.IIterable{Windows.Storage.IStorageFile})
-api-type: winrt method
---

<!-- Method syntax
public void LoadPriFiles(Windows.Foundation.Collections.IIterable<Windows.Storage.IStorageFile> files)
-->

# Windows.ApplicationModel.Resources.Core.ResourceManager.LoadPriFiles

## -description
Loads one or more Package Resource Index (PRI) files and adds their contents to the default resource manager.

## -parameters
### -param files
The Package Resource Index (PRI) files you want to add.

## -remarks
The `LoadPRIFiles` method accepts files only from inside the app package or dependent packages.

If resource packs are used by an app, this method will always fail.

For more info about PRI files, see [Resource Management System](/windows/uwp/app-resources/resource-management-system).

## -examples

## -see-also
[Localize strings in your UI and app package manifest](/windows/uwp/app-resources/localize-strings-ui-manifest), [Resource Management System](/windows/uwp/app-resources/resource-management-system)
