---
-api-id: M:Windows.Devices.Haptics.InputHapticsManager.ClearOverrideHapticsController(Windows.Devices.Haptics.HapticsControllerOverrideToken)
-api-type: winrt method
---

# Windows.Devices.Haptics.InputHapticsManager.ClearOverrideHapticsController(Windows.Devices.Haptics.HapticsControllerOverrideToken)

<!--
public void ClearOverrideHapticsController (Windows.Devices.Haptics.HapticsControllerOverrideToken token);
-->


## -description

Clears the overriding [SimpleHapticsController](simplehapticscontroller.md) that was previously set with the specified token. If this was the only override, the manager returns to its default behavior of determining the controller based on the latest input received by the thread.

## -parameters

### -param token

The token previously returned by [SetOverrideHapticsController](inputhapticsmanager_setoverridehapticscontroller_1943473886.md).

## -remarks

## -see-also

[InputHapticsManager.SetOverrideHapticsController](inputhapticsmanager_setoverridehapticscontroller_1943473886.md), [HapticsControllerOverrideToken](hapticscontrolleroverridetoken.md)

## -examples


