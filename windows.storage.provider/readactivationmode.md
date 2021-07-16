---
-api-id: T:Windows.Storage.Provider.ReadActivationMode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Storage.Provider.ReadActivationMode : int
-->

# ReadActivationMode

## -description
Indicates when Windows will request a file update if another app retrieves the file from its [MostRecentlyUsedList](../windows.storage.accesscache/storageapplicationpermissions_mostrecentlyusedlist.md) or [FutureAccessList](../windows.storage.accesscache/storageapplicationpermissions_futureaccesslist.md).

## -enum-fields
### -field NotNeeded:0
Windows will not trigger a file update request when another app retrieves the local file.

### -field BeforeAccess:1
Windows will trigger a file update request just before it has been retrieved from the app's [MostRecentlyUsedList](../windows.storage.accesscache/storageapplicationpermissions_mostrecentlyusedlist.md) or [FutureAccessList](../windows.storage.accesscache/storageapplicationpermissions_futureaccesslist.md).


## -remarks
If your app participates in the Cached File Updater contract, associate this information with the locally cached copy of a file by calling [CachedFileUpdater.SetUpdateInformation](cachedfileupdater_setupdateinformation_1837385638.md).

## -examples

## -see-also