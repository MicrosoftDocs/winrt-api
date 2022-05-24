---
-api-id: T:Windows.Storage.Provider.StorageProviderMoreInfoUI
-api-type: winrt class
---

# Windows.Storage.Provider.StorageProviderMoreInfoUI

<!--
public sealed class StorageProviderMoreInfoUI
-->

## -description

The container for the more info UI section of the storage provider flyout. This is used to provide additional information and/or a recommended action a user can take in response to the current sync state.

## -remarks

This section will only be visible if at least one of [StorageProviderMoreInfoUICommand](storageprovidermoreinfoui_command.md) or [StorageProviderMoreInfoUIMessage](storageprovidermoreinfoui_message.md) is Enabled (see [IStorageProviderUICommandState](istorageprovideruicommand_state.md)) or non-empty, respectively.

## -see-also

[StorageProviderStatusUI](storageproviderstatusui.md)
