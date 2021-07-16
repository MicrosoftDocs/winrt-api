---
-api-id: M:Windows.Media.Protection.PlayReady.IPlayReadyLicenseSession2.CreateLicenseIterable(Windows.Media.Protection.PlayReady.PlayReadyContentHeader,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public PlayReadyLicenseIterable IPlayReadyLicenseSession2.CreateLicenseIterable(PlayReadyContentHeader contentHeader, Boolean fullyEvaluated)
-->

# Windows.Media.Protection.PlayReady.IPlayReadyLicenseSession2.CreateLicenseIterable

## -description
Creates a [PlayReadyLicense](playreadylicense.md) object iterator that supports in-memory-only PlayReady licenses in addition to persisted licenses.

## -parameters

### -param contentHeader
The content header used to locate associated licenses.

### -param fullyEvaluated
Indicates whether evaluated license chains should be enumerated or if all licenses (including those that are unusable) should be enumerated. Set this parameter to true if evaluated license chains should be enumerated. Set this parameter to false if all licenses should be enumerated.

## -returns

## -remarks

## -see-also

## -examples

