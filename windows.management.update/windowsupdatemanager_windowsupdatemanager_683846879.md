---
-api-id: M:Windows.Management.Update.WindowsUpdateManager.#ctor(System.String,System.String[])
-api-type: winrt constructor
---

# Windows.Management.Update.WindowsUpdateManager.#ctor(System.String,System.String[])

<!--
public WindowsUpdateManager (string clientId, string[] providerIdFilter);
-->


## -description

Constructs a new [WindowsUpdateManager](./windowsupdatemanager.md) that's scoped to a specific set of update providers.

## -parameters

### -param clientId

An identifier used to distinguish this update manager instance.

### -param providerIdFilter

An array of provider IDs that limits the manager to the specified providers. Only updates and scans for these providers are surfaced through this instance.

## -remarks

Use this overload to work with a subset of providers — for example, a single software-update provider. To work with all providers, use the [WindowsUpdateManager(String)](./windowsupdatemanager_windowsupdatemanager_290278668.md) constructor.

## -see-also

[WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md)

## -examples

