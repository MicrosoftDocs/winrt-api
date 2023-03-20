---
-api-id: P:Windows.Storage.Provider.StorageProviderStatusUI.ProviderState
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderStatusUI.ProviderState

<!--
public Windows.Storage.Provider.StorageProviderState ProviderState { get; set; }
-->

## -description

Provides the current sync status of the storage provider status UI.

## -property-value

The current sync status of the storage provider status UI as a [StorageProviderState](storageproviderstate.md).

## -remarks

Possible `StorageProviderState` values are:

| State | Description |
|--------|--------|
| `Error` | The storage provider has encountered errors. |
| `InSync` | The storage provider is currently in-sync. |
| `Offline` | The storage provider is currently offline. |
| `Paused` | The storage provider has paused syncing. |
| `Syncing` | The storage provider is currently syncing. |
| `Warning` | The storage provider would like to display a warning message to the user. |

## -see-also

[StorageProviderStatuUI](storageproviderstatusui.md), [StorageProviderState](storageproviderstate.md)

## -examples

Please refer to the [CloudMirror sample app](https://github.com/microsoft/Windows-classic-samples/blob/7cbd99ac1d2b4a0beffbaba29ea63d024ceff700/Samples/CloudMirror/CloudMirror/MyStatusUISource.cpp) for more details.
