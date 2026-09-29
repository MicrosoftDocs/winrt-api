---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdateProvider.Validate
-api-type: winrt method
---

# Windows.Management.Update.WindowsSoftwareUpdateProvider.Validate

<!--
public Windows.Management.Update.WindowsSoftwareUpdateResult Validate ();
-->


## -description

Validates the provider package without registering it, checking the manifest, payload-file hashes, catalog, and code-signing.

## -returns

A [WindowsSoftwareUpdateResult](./windowssoftwareupdateresult.md) that indicates whether the package is valid.

## -remarks

Use this to verify a provider before attempting registration.

## -see-also

[WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md)

## -examples

