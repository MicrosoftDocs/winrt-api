---
-api-id: P:Windows.Networking.NetworkOperators.ESimPolicy.ShouldEnableManagingUi
-api-type: winrt property
---

<!-- Property syntax.
public bool ShouldEnableManagingUi { get; }
-->

# Windows.Networking.NetworkOperators.ESimPolicy.ShouldEnableManagingUi

## -description
Gets a value indicating whether the policy for the eSIM calls for the eSIM to be shown on the Local User Interface (LUI) for eSIM management.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -property-value
`true` if the policy calls for the eSIM to be shown on the LUI, otherwise `false`.

## -remarks

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe