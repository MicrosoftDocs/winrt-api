---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputVisualizationMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputVisualizationMode : int
-->

# InjectedInputVisualizationMode

## -description

Specifies the type of visual feedback displayed for the injected input type.

## -enum-fields

### -field None:0

Indicates no visual feedback for the injected input. Default.

### -field Default:1

Indicates default system visual feedback for the type of injected input.

### -field Indirect:2

Indicates indirect visual feedback for the type of injected input (pen and touch only, typically for projection to an external monitor).


## -remarks

> [!Important]
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#special-and-restricted-capabilities).

Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`


## -examples

## -see-also

### Reference

- [InitializePenInjection](inputinjector_initializepeninjection_260722924.md)
- [InitializeTouchInjection](inputinjector_initializetouchinjection_1509714255.md)

### Conceptual

[Gaze interactions and eye tracking in UWP apps](https://docs.microsoft.com/windows/uwp/design/input/gaze-interactions)

### Samples

- [Simulate user input through input injection](https://review.docs.microsoft.com/windows/uwp/design/input/input-injection?branch=kbridge-inputinjection)
- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906)
- [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855)
