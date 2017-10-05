---
-api-id: T:Windows.Storage.AppDataPaths
-api-type: winrt class
---

<!-- Class syntax.
public class AppDataPaths 
-->

# Windows.Storage.AppDataPaths

## -description
AppDataPaths returns paths to commonly used application folders based on the [KNOWNFOLDERID](https://msdn.microsoft.com/library/windows/desktop/dd378457.aspx) naming pattern. 

## -remarks
This class returns paths that are always isolated per the caller’s context. For example, this will match expectations of cross-platform app developers who might have used “private” versions of documents in the past. There is no legacy COM interop interface for this type.

Requesting folder locations from an app that doesn’t have a package identity will fail (e.g., [GetDefault](appdatapaths_getdefault_846721868.md) and [GetForUser](appdatapaths_getforuser_2058550280.md) will both return null). This ensures there are no migration issues if an app depends on the per-app locations being shared (Win32), or if the app paths change when using the Desktop Bridge.

## -see-also

## -examples

