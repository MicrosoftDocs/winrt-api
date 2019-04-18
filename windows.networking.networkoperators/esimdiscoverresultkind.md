---
-api-id: T:Windows.Networking.NetworkOperators.ESimDiscoverResultKind
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum ESimDiscoverResultKind : int 
-->

# Windows.Networking.NetworkOperators.ESimDiscoverResultKind

## -description
Defines constants that specify the kind of the result object from an eSIM profile discovery operation.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -enum-fields

### -field None:0
Indicates that the result object contains neither events nor a profile.

### -field Events:1
Indicates that the result object contains events.

### -field ProfileMetadata:2
Indicates that the result object contains a profile.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
