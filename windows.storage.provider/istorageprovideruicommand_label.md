---
-api-id: P:Windows.Storage.Provider.IStorageProviderUICommand.Label
-api-type: winrt property
---

# Windows.Storage.Provider.IStorageProviderUICommand.Label

<!--
public string Label { get; }
-->

## -description

Returns the [IStorageProviderUICommand](istorageprovideruicommand.md) label

## -property-value

## -remarks

Depending on the placement of the command in the flyout, this label may appear on the command button itself or as a tooltip. As the flyout stands today, the following commands will display a label within the command button:

- [SyncStatusCommand](storageproviderstatusui_syncstatuscommand.md)
- [MoreInfoUICommand](storageproviderstatusui_moreinfoui.md)
- [ProviderPrimaryCommand](storageproviderstatusui_providerprimarycommand.md)

Each of the secondary commands, [ProviderSecondaryCommands](storageproviderstatusui_providersecondarycommands.md), will display the label as a tooltip.

For all of the commands, this label is read aloud by the screen reader.

Windows may choose to display "Hidden"-requested commands as "Disabled". This property must be specified and non-empty even if [IStorageProviderUICommand.State](istorageprovideruicommand_state.md) is Hidden. 

## -see-also

[IStorageProviderUICommand](istorageprovideruicommand.md)
