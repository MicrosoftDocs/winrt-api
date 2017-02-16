---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceManager.UnloadPriFiles(Windows.Foundation.Collections.IIterable{Windows.Storage.IStorageFile})
-api-type: winrt method
---

<!-- Method syntax
public void UnloadPriFiles(Windows.Foundation.Collections.IIterable<Windows.Storage.IStorageFile> files)
-->

# Windows.ApplicationModel.Resources.Core.ResourceManager.UnloadPriFiles

## -description
Unloads one or more resource index ("PRI") files.
<!--Please clarify what a PRI file is; I assume it's something to do with priority, but it's not clear.-->

<!--It's a resource index file, actually, which proves your point. This will be explained in Remarks, to be added after BUILD.-->

## -parameters
### -param files
The files you want unloaded.

## -remarks
If resource packs are used by an app, this method will always fail.

## -examples

## -see-also
