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
The [LoadPRIFiles](resourcemanager_loadprifiles_414575616.md) method accepts files only from inside the app package or dependent packages. See [How to load string resources](https://msdn.microsoft.com/library/849f5bbf-6d85-4760-8832-75d3eff9bd96).

If resource packs are used by an app, this method will always fail.

## -examples

## -see-also
[How to load string resources](https://msdn.microsoft.com/library/849f5bbf-6d85-4760-8832-75d3eff9bd96)
