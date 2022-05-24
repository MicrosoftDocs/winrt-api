---
-api-id: P:Windows.Storage.Provider.StorageProviderStatusUI.ProviderSecondaryCommands
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderStatusUI.ProviderSecondaryCommands

<!--
public System.Collections.Generic.IList<Windows.Storage.Provider.IStorageProviderUICommand> ProviderSecondaryCommands { get; set; }
-->

## -description

List of secondary commands that appear in the commands area of the storage provider status UI flyout.

## -property-value

## -remarks

This property currently supports displaying up to three secondary commands. Any command after the third element in this list will be ignored.

Additionally, the labels ([IStorageProviderUICommandLabel](istorageprovideruicommand_label.md)) of these commands are utilized for the tooltip and display the icons ([IStorageProviderStatusUICommandIcon](istorageprovideruicommand_icon.md)).

## -see-also

[IStorageProviderUICommand](istorageprovideruicommand.md)
