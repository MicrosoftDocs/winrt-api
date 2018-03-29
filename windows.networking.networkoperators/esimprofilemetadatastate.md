---
-api-id: T:Windows.Networking.NetworkOperators.ESimProfileMetadataState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ESimProfileMetadataState : int 
-->

# Windows.Networking.NetworkOperators.ESimProfileMetadataState

## -description
Defines constants that specify the state of eSIM profile metadata.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -enum-fields
### -field Unknown:0
Indicates that the state of the eSIM profile metadata is not known.

### -field WaitingForInstall:1
Indicates that the eSIM profile metadata is waiting to be installed.

### -field Downloading:2
Indicates that the eSIM profile metadata is being downloaded.

### -field Installing:3
Indicates that the eSIM profile metadata is being installed.

### -field Expired:4
Indicates that the eSIM profile metadata has expired.

### -field RejectingDownload:5
Indicates that download of the eSIM profile metadata is being rejected.

### -field NoLongerAvailable:6
Indicates that the eSIM profile metadata is no longer available.

### -field DeniedByPolicy:7
Indicates that the eSIM profile metadata has been denied by policy.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe