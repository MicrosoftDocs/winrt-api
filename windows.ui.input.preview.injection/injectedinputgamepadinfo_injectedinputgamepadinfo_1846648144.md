---
-api-id: M:Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.#ctor(Windows.Gaming.Input.GamepadReading)
-api-type: winrt method
---

<!-- Method syntax.
public InjectedInputGamepadInfo.InjectedInputGamepadInfo(GamepadReading reading)
-->

# Windows.UI.Input.Preview.Injection.InjectedInputGamepadInfo.InjectedInputGamepadInfo

## -description
Creates a new [InjectedInputGamepadInfo](injectedinputgamepadinfo.md) object that is used to specify the gamepad input to inject based on the current state of the gamepad.

## -parameters
### -param reading
The current state of the gamepad.

> [!NOTE]
> The [Timestamp](https://docs.microsoft.com/uwp/api/windows.gaming.input.gamepadreading?branch=rs3.Timestamp) value is replaced with the current time of input injection.

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -see-also

### Reference

[InjectedInputGamepadInfo()](injectedinputgamepadinfo_injectedinputgamepadinfo_1221375020.md)

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

- [Simulate user input through input injection](https://review.docs.microsoft.com/windows/uwp/design/input/input-injection?branch=kbridge-inputinjection)
- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855)


## -examples

