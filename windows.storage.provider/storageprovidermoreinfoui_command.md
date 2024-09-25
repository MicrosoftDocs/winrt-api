---
-api-id: P:Windows.Storage.Provider.StorageProviderMoreInfoUI.Command
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderMoreInfoUI.Command

<!--
public Windows.Storage.Provider.IStorageProviderUICommand Command { get; set; }
-->

## -description

The [MoreInfoUI](storageproviderstatusui_moreinfoui.md) section's command.

## -property-value

## -remarks

When the user's display settings are standard (e.g., no high contrast theme is currently applied), this button uses the user's accent color.

Windows may choose to disable Storage Provider Status UI if neither this command nor [ProviderPrimaryCommand](storageproviderstatusui_providerprimarycommand.md) are specified.

Additionally, Windows may choose this command to take precedence over [ProviderPrimaryCommand](storageproviderstatusui_providerprimarycommand.md) when both commands are present.


## -see-also

[MoreInfoUI](storageproviderstatusui_moreinfoui.md)
[IStorageProviderStatusUICommand](istorageprovideruicommand.md)
