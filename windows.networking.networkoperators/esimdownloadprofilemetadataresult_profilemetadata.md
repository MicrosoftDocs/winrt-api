---
-api-id: P:Windows.Networking.NetworkOperators.ESimDownloadProfileMetadataResult.ProfileMetadata
-api-type: winrt property
---

<!-- Property syntax.
public ESimProfileMetadata ProfileMetadata { get; }
-->

# Windows.Networking.NetworkOperators.ESimDownloadProfileMetadataResult.ProfileMetadata

## -description
Gets an object representing any eSIM profile installation metadata that was downloaded.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -property-value
An object representing the eSIM profile installation metadata that was downloaded, or `null` if the download operation did not succeed.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe