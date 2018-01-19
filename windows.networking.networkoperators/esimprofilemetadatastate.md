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
> To use this API you will need to contact Microsoft to request the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations?branch=live).

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