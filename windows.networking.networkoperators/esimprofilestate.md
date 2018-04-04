---
-api-id: T:Windows.Networking.NetworkOperators.ESimProfileState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ESimProfileState : int 
-->

# Windows.Networking.NetworkOperators.ESimProfileState

## -description
Defines constants that specify the state of an eSIM profile, including its presence and enabled status.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -enum-fields
### -field Unknown:0
Indicates that the state of the eSIM profile is not known.

### -field Enabled:2
Indicates that the eSIM profile is enabled.

### -field Disabled:1
Indicates that the eSIM profile is disabled.

### -field Deleted:3
Indicates that the eSIM profile has been deleted.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
