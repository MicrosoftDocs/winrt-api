---
-api-id: P:Windows.Networking.NetworkOperators.ESimProfilePolicy.CanDisable
-api-type: winrt property
---

<!-- Property syntax.
public bool CanDisable { get; }
-->

# Windows.Networking.NetworkOperators.ESimProfilePolicy.CanDisable

## -description
Gets a value indicating whether the eSIM profile policy represented by this object instance allows the profile to be disabled.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -property-value
`true` if the policy allows the profile to be disabled, otherwise `false`.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe