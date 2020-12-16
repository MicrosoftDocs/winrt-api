---
-api-id: P:Windows.Gaming.XboxLive.Storage.GameSaveContainerInfo.NeedsSync
-api-type: winrt property
---

<!-- Property syntax
public bool NeedsSync { get; }
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainerInfo.NeedsSync

## -description

Indicates whether the container needs to sync before updates can be submitted with [SubmitUpdatesAsync](gamesavecontainer_submitupdatesasync_1002100950.md) or [SubmitPropertySetUpdatesAsync](gamesavecontainer_submitpropertysetupdatesasync_435712146.md).

## -property-value

Type: **Boolean** \[JavaScript\] | [System.Boolean](/dotnet/api/system.boolean?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | [Platform::Boolean](/cpp/cppcx/platform-boolean-value-class) \[C++\]

True if the container needs to sync before updates can be submitted; false otherwise.

## -remarks

See [GetSyncOnDemandForUserAsync](gamesaveprovider_getsyncondemandforuserasync_1696921570.md) for more information about sync-on-demand game save providers.

## -examples

## -see-also

[GameSaveContainerInfo](gamesavecontainerinfo.md)