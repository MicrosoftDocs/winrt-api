---
-api-id: P:Windows.Networking.NetworkOperators.ESimProfilePolicy.IsManagedByEnterprise
-api-type: winrt property
---

<!-- Property syntax.
public bool IsManagedByEnterprise { get; }
-->

# Windows.Networking.NetworkOperators.ESimProfilePolicy.IsManagedByEnterprise

## -description
Gets a value indicating whether the eSIM profile policy represented by this object instance calls for the profile to be managed by the enterprise.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store then you will need to request special approval to use the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Special and restricted capabilities](/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

## -property-value
`true` if the policy calls for the profile to be managed by the enterprise, otherwise `false`.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe