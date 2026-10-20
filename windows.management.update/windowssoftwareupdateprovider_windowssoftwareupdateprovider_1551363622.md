---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdateProvider.#ctor(System.String)
-api-type: winrt constructor
---

# Windows.Management.Update.WindowsSoftwareUpdateProvider.#ctor(System.String)

<!--
public WindowsSoftwareUpdateProvider (string folderPath);
-->


## -description

Creates a new [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md) from a provider folder on disk.

## -parameters

### -param folderPath

The full path to the folder that contains the provider's `provider.json` manifest and payload files.

## -remarks

Constructing the provider reads and parses the manifest; it doesn't register the provider. Call [Register](./windowssoftwareupdateprovider_register_1161340127.md) to register it.

## -see-also

[WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md)

## -examples

