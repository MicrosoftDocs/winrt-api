---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdateProvider.Register
-api-type: winrt method
---

# Windows.Management.Update.WindowsSoftwareUpdateProvider.Register

<!--
public Windows.Management.Update.WindowsSoftwareUpdateResult Register ();
-->


## -description

Registers the provider with the Windows Update Orchestrator, making it eligible to be scanned. Registration validates the manifest, payload-file hashes, catalog, and code-signing.

## -returns

A [WindowsSoftwareUpdateResult](./windowssoftwareupdateresult.md) that indicates whether registration succeeded, with a result code describing any failure.

## -remarks

Requires administrator privileges. For onboarding steps and the list of registration checks, see the [windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsSoftwareUpdateResult](./windowssoftwareupdateresult.md)

## -examples

