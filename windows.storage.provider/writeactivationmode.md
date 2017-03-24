---
-api-id: T:Windows.Storage.Provider.WriteActivationMode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Storage.Provider.WriteActivationMode : int
-->

# WriteActivationMode

## -description
Indicates whether other apps can write to the locally cached version of the file and when Windows will request an update if another app writes to that local file.

## -enum-fields
### -field ReadOnly:0
Other apps can't write to the local file.

### -field NotNeeded:1
Windows will trigger a file update request when another app writes to the local file.

### -field AfterWrite:2
Windows will trigger a file update request after another app writes to the local file.


## -remarks
If your app participates in the Cached File Updater contract, associate this information with the locally cached copy of a file by calling [CachedFileUpdater.SetUpdateInformation](cachedfileupdater_setupdateinformation.md).

## -examples

## -see-also