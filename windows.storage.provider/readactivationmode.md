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
Indicates when Windows will request a file update if another app reads the locally cached version of the file.

## -enum-fields
### -field NotNeeded:0
Windows will not trigger a file update request when another app accesses the local file.

### -field BeforeAccess:1
Windows will trigger a file update request before allowing another app to access the local file.


## -remarks
If your app participates in the Cached File Updater contract, associate this information with the locally cached copy of a file by calling [CachedFileUpdater.SetUpdateInformation](cachedfileupdater_setupdateinformation.md).

## -examples

## -see-also