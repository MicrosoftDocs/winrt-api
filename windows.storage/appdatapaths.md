---
-api-id: T:Windows.Storage.AppDataPaths
-api-type: winrt class
---

<!-- Class syntax.
public class AppDataPaths 
-->

# Windows.Storage.AppDataPaths

## -description
AppDataPaths returns paths to commonly used application folders based on the [KNOWNFOLDERID](/windows/desktop/shell/knownfolderid) naming pattern. 

## -remarks
This class returns paths that are always isolated per the caller’s context. For example, this will match expectations of cross-platform app developers who might have used “private” versions of documents in the past. There is no legacy COM interop interface for this type.

Requesting app-specific folder locations from an app without package identity (for example, [LocalAppData](appdatapaths_localappdata.md)) will fail. This ensures there are no migration issues if an app depends on the per-app locations being shared (Win32), or if the app paths change when using the Desktop Bridge.

## -see-also

## -examples

