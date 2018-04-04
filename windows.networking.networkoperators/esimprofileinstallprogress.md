---
-api-id: T:Windows.Networking.NetworkOperators.ESimProfileInstallProgress
-api-type: winrt struct
---

<!-- Structure syntax.
public struct ESimProfileInstallProgress  {
	public int InstalledSizeInBytes 
	public int TotalSizeInBytes 
}
-->

# Windows.Networking.NetworkOperators.ESimProfileInstallProgress

## -description
Represents the result of an asynchronous (with progress) operation to download and install an eSIM profile.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -struct-fields
### -field InstalledSizeInBytes
The installed size of the eSIM profile in whole bytes.

### -field TotalSizeInBytes
The total size of the eSIM profile in whole bytes.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe