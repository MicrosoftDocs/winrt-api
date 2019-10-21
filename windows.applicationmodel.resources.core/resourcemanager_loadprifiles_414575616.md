---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceManager.LoadPriFiles(Windows.Foundation.Collections.IIterable{Windows.Storage.IStorageFile})
-api-type: winrt method
---

<!-- Method syntax
public void LoadPriFiles(Windows.Foundation.Collections.IIterable<Windows.Storage.IStorageFile> files)
-->

# Windows.ApplicationModel.Resources.Core.ResourceManager.LoadPriFiles

## -description
Loads one or more resource index ("PRI") files and adds their contents to the default resource manager.

## -parameters
### -param files
The files you want to add.

## -remarks
The LoadPRIFiles method accepts files only from inside the app package or dependent packages. See [How to load string resources](https://docs.microsoft.com/previous-versions/windows/apps/hh465248(v=win.10)).

If resource packs are used by an app, this method will always fail.

## -examples

## -see-also
[How to load string resources](https://docs.microsoft.com/previous-versions/windows/apps/hh465248(v=win.10))
