---
-api-id: P:Windows.Storage.Provider.CachedFileUpdaterUI.UpdateTarget
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Provider.CachedFileTarget UpdateTarget { get; }
-->

# Windows.Storage.Provider.CachedFileUpdaterUI.UpdateTarget

## -description
Gets a value that indicates which version of the file needs to be updated: the local version or the version in the app's repository.

## -property-value
An enum value that indicates which version of the file needs to be updated: the local version or the version in the app's repository.

## -remarks
If your app participates in the Cached File Updater contract, you should use this property to respond to [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) events. If this property is [CachedFileTarget.Local](cachedfiletarget.md), your app should update the locally cached copy of the file to match the latest version of the file that is in your app's repository. Otherwise, if it's [CachedFileTarget.Remote](cachedfiletarget.md), your app should update the version of the file that is in your app's repository to match the latest, locally cached copy of the file.

The value of this property is applies to all of the [FileUpdateRequested](cachedfileupdaterui_fileupdaterequested.md) events that fire for a single [ActivationKind.CachedFileUpdater](../windows.applicationmodel.activation/activationkind.md) activation event.

## -examples

## -see-also
