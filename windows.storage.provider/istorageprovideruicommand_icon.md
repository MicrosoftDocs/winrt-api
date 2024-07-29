---
-api-id: P:Windows.Storage.Provider.IStorageProviderUICommand.Icon
-api-type: winrt property
---

# Windows.Storage.Provider.IStorageProviderUICommand.Icon

<!--
public System.Uri Icon { get; }
-->

## -description

Returns the [IStorageProviderUICommand](istorageprovideruicommand.md) icon URI, which is expected to be a fully-qualified local file path to an SVG file.

## -property-value

A Uri referencing the fully-qualified path to an SVG file.

## -remarks

Windows determines if the [SyncStatusCommand](storageproviderstatusui_syncstatuscommand.md), [ProviderSecondaryCommands](storageproviderstatusui_providersecondarycommands.md), [ProviderPrimaryCommand](storageproviderstatusui_providerprimarycommand.md), or [StorageProviderMoreInfoUI.Command](storageprovidermoreinfoui_command.md) can display icons.

Windows may choose to display "Hidden"-requested commands as "Disabled". This property must be specified and non-empty even if [IStorageProviderUICommand.State](istorageprovideruicommand_state.md) is Hidden. 


## -see-also

[IStorageProviderUICommand](istorageprovideruicommand.md)
