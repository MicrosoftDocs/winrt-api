---
-api-id: P:Windows.Storage.Provider.IStorageProviderUICommand.State
-api-type: winrt property
---

# Windows.Storage.Provider.IStorageProviderUICommand.State

<!--
public Windows.Storage.Provider.StorageProviderUICommandState State { get; }
-->

## -description

Returns the [IStorageProviderUICommand](istorageprovideruicommand.md) state ([StorageProviderUICommandState](storageprovideruicommandstate.md))

## -property-value

- **Hidden** when the command should not display at all.
- **Disabled** when the command should be visible and disabled.
- **Enabled** when the command should be visible and enabled.

## -remarks

When the State is Disabled, the command will be visible but not click-able. When the State is Enabled, the command will be visible and click-able.

Windows may choose to display "Hidden"-requested commands as "Disabled". Those commands will be visible but not click-able.

## -see-also

[IStorageProviderUICommand](istorageprovideruicommand.md)
