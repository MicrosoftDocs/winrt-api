---
-api-id: T:Windows.Management.Deployment.StubPackageOption
-api-type: winrt enumeration
---

## -description

Defines the stub behavior for an app package that is being added or staged.

## -enum-fields

### -field Default:0

Use the default behavior.

### -field InstallFull:1

Install as a full app.

### -field InstallStub:2

Install as stub app.

### -field UsePreference:3

Use the current [PackageSubPreference](packagestubpreference.md) for the package.

## -remarks

> [!NOTE]
> The ability for an app to run as a stub is currently available only to certain apps that are built by Microsoft.

## -see-also

[StagePackageOptions](stagepackageoptions.md),[AddPackageOptions](addpackageoptions.md)

## -examples

