---
-api-id: M:Windows.Devices.Haptics.InputHapticsManager.GetForCurrentThread
-api-type: winrt method
---

# Windows.Devices.Haptics.InputHapticsManager.GetForCurrentThread

<!--
public static Windows.Devices.Haptics.InputHapticsManager GetForCurrentThread ();
-->


## -description

Returns the [InputHapticsManager](inputhapticsmanager.md) object for the current thread. Multiple calls to this method on the same thread return the same object, even if the object returned by earlier calls has its reference dropped.

## -returns

The [InputHapticsManager](inputhapticsmanager.md) for the current thread.

## -remarks

## -see-also

[InputHapticsManager.TryGetForThread](inputhapticsmanager_trygetforthread_453675118.md), [InputHapticsManager.IsSupported](inputhapticsmanager_issupported_930300905.md)

## -examples
