---
-api-id: T:Windows.Networking.NetworkOperators.ESimAuthenticationPreference
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ESimAuthenticationPreference : int 
-->

# Windows.Networking.NetworkOperators.ESimAuthenticationPreference

## -description
Defines constants that specify under what conditions the user should be challenged for eSIM authentication credentials.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -enum-fields
### -field OnEntry:0
Indicates that credentials should be requested when the eSIM is entered.

### -field OnAction:1
Indicates that credentials should be requested when the eSIM is involved in an action.

### -field Never:2
Indicates that credentials should never be requested.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe