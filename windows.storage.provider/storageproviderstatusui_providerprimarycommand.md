---
-api-id: P:Windows.Storage.Provider.StorageProviderStatusUI.ProviderPrimaryCommand
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderStatusUI.ProviderPrimaryCommand

<!--
public Windows.Storage.Provider.IStorageProviderUICommand ProviderPrimaryCommand { get; set; }
-->

## -description

The primary command that appears in the commands area of the storage provider status UI flyout.

## -property-value

## -remarks

Windows will determine if the icon property ([IStorageProviderStatusUICommandIcon](istorageprovideruicommand_icon.md)) of this command is displayed.

Windows may choose to disable Storage Provider Status UI if neither this command nor [StorageProviderStatusUI.MoreInfoUI](storageprovidermoreinfoui_command.md) are specified.

Additionally, Windows may choose [MoreInfoUI.Command](storageprovidermoreinfoui_command.md) to take precedence over this command when both commands are present.


## -see-also

[StorageProviderMoreInfoUI](storageproviderstatusui_moreinfoui.md)
