---
-api-id: M:Windows.Devices.Haptics.InputHapticsManager.ClearOverrideHapticsController(Windows.Devices.Haptics.HapticsControllerOverrideToken)
-api-type: winrt method
---

# Windows.Devices.Haptics.InputHapticsManager.ClearOverrideHapticsController(Windows.Devices.Haptics.HapticsControllerOverrideToken)

<!--
public void ClearOverrideHapticsController (Windows.Devices.Haptics.HapticsControllerOverrideToken token);
-->

## -description

Clears the [SimpleHapticsController](simplehapticscontroller.md) override that was previously set with the specified token.

## -parameters

### -param token

The token previously returned by [SetOverrideHapticsController](inputhapticsmanager_setoverridehapticscontroller_1943473886.md).

## -returns

Returns E_INVALIDARG if the [HapticsControllerOverrideToken](hapticscontrolleroverridetoken.md) does not represent a current override (unless the token value is 0).

## -remarks

Other overrides previously set on the manager still have an effect, if they were set recently enough. If this was the only override, the manager returns to its default behavior of determining the controller based on the latest input received by the thread.

## -see-also

## -examples
