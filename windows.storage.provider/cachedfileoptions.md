---
-api-id: T:Windows.Storage.Provider.CachedFileOptions
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Storage.Provider.CachedFileOptions : uint
-->

# CachedFileOptions

## -description
Describes when Windows will request an update to a file.

## -enum-fields
### -field None:0
Another app may be able to access the locally cached copy of the file without triggering an update.

### -field RequireUpdateOnAccess:1
An update always triggers when another app accesses the locally cached copy of the file.

### -field UseCachedFileWhenOffline:2
An update triggers when another app accesses the locally cached copy of the file if a network connection is available.  Otherwise, other apps can access the local file without triggering an update.

### -field DenyAccessWhenOffline:4
An update triggers when another app accesses the locally cached copy of the file if a network connection is available.  Otherwise, other apps are denied access to the local file.


## -remarks

## -examples

## -see-also