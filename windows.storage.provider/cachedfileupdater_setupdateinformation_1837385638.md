---
-api-id: M:Windows.Storage.Provider.CachedFileUpdater.SetUpdateInformation(Windows.Storage.IStorageFile,System.String,Windows.Storage.Provider.ReadActivationMode,Windows.Storage.Provider.WriteActivationMode,Windows.Storage.Provider.CachedFileOptions)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetUpdateInformation(Windows.Storage.IStorageFile file, System.String contentId, Windows.Storage.Provider.ReadActivationMode readMode, Windows.Storage.Provider.WriteActivationMode writeMode, Windows.Storage.Provider.CachedFileOptions options)
-->

# Windows.Storage.Provider.CachedFileUpdater.SetUpdateInformation

## -description
Configures update policies for a local file.

## -parameters
### -param file
The local file.

### -param contentId
A unique identifier for the local file.

You can use this identifier to associate a file in your app's repository with the local file. When updates are requested by Windows, you can use this *contentId* to identify the correct file in your app's repository.

### -param readMode
A value that specifies whether Windows will request updates before the local file is retrieved from an app's [MostRecentlyUsedList](../windows.storage.accesscache/storageapplicationpermissions_mostrecentlyusedlist.md) or [FutureAccessList](../windows.storage.accesscache/storageapplicationpermissions_futureaccesslist.md).

### -param writeMode
A value that specifies whether other apps can write to the local file and, if so, whether Windows will request updates after the local file is written.

### -param options
A value that specifies additional circumstances and behaviors for when Windows requests updates.

For example, you could require Windows to request an update every time the local file is accessed by using [CachedFileOptions.RequireUpdateOnAccess](cachedfileoptions.md). For more information about possible options, see [CachedFileOptions](cachedfileoptions.md).

## -remarks
In order to use this method your app must participate in the Cached File Updater contract.

You can use this method to control how other apps can access a file that is provided by your app and to control when Windows requests updates for that file.

## -examples

## -see-also
