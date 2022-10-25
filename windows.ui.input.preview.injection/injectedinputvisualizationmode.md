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
> The APIs in this namespace require the inputInjectionBrokered [restricted capability](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities).

Using input injection requires the following be added to the Package.appxmanifest:

- To `<Package>`
    - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
    - `IgnorableNamespaces="rescap"`
- To `<Capabilities>`
    - `<rescap:Capability Name="inputInjectionBrokered" />`

## -examples

Here are some downloadable samples demonstrating basic input and input injection:

- [Input injection sample (mouse to touch)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-input-injection-mouse-to-touch.zip)
- [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample)
- [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)

## -see-also

[InitializePenInjection](inputinjector_initializepeninjection_260722924.md), [InitializeTouchInjection](inputinjector_initializetouchinjection_1509714255.md), [Simulate user input through input injection](/windows/uwp/design/input/input-injection)
