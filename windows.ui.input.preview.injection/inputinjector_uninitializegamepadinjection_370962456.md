---
-api-id: M:Windows.UI.Input.Preview.Injection.InputInjector.UninitializeGamepadInjection
-api-type: winrt method
---

<!-- Method syntax.
public void InputInjector.UninitializeGamepadInjection()
-->

# Windows.UI.Input.Preview.Injection.InputInjector.UninitializeGamepadInjection

## -description
Shuts down the virtual gamepad device created with [InitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md).

## -remarks
Calling this method is analogous to disconnecting a physical gamepad, which also triggers a [**GamepadRemoved**](https://docs.microsoft.com/uwp/api/windows.gaming.input.gamepad#Windows_Gaming_Input_Gamepad_GamepadRemoved) event.

A physical gamepad is assigned a persistent unique ID (see [**NonRoamableId**](..\windows.gaming.input\rawgamecontroller_nonroamableid.md)) that does not change when the device is connected and disconnected. Similarly, a virtual gamepad created with [**InitializeGamepadInjection**](inputinjector_initializegamepadinjection_1113833135.md) is also assigned a unique ID that persists across calls to [UninitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md) and [**InitializeGamepadInjection**](inputinjector_initializegamepadinjection_1113833135.md) for the same [InputInjector](inputinjector.md) instance.

## -examples

## -see-also
- [InitializeGamepadInjection](inputinjector_initializegamepadinjection_1113833135.md)

