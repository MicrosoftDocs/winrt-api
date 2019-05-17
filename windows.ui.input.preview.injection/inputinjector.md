---
-api-id: T:Windows.UI.Input.Preview.Injection.InputInjector
-api-type: winrt class
---

<!-- Class syntax.
public class InputInjector : Windows.UI.Input.Preview.Injection.IInputInjector
-->

# Windows.UI.Input.Preview.Injection.InputInjector

## -description
Represents the virtual input device for sending the input data.

## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | InitializeGamepadInjection |
| 1709 | 16299 | InjectGamepadInput |
| 1709 | 16299 | TryCreateForAppBroadcastOnly |
| 1709 | 16299 | UninitializeGamepadInjection |

## -examples

## -see-also

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

- [Simulate user input through input injection](https://review.docs.microsoft.com/windows/uwp/design/input/input-injection?branch=kbridge-inputinjection)
- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855)
