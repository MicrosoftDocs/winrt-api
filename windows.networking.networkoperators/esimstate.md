---
-api-id: T:Windows.Networking.NetworkOperators.ESimState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ESimState : int 
-->

# Windows.Networking.NetworkOperators.ESimState

## -description
Defines constants that specify the state of an eSIM, including its presence and working status.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -enum-fields
### -field Unknown:0
Indicates that the state of the eSIM is not known.

### -field Idle:1
Indicates that the eSIM is idle.

### -field Removed:2
Indicates that the eSIM has been removed.

### -field Busy:3
Indicates that the eSIM is busy.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe