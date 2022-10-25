---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputPointerOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputPointerOptions : uint
-->

# InjectedInputPointerOptions

## -description
Specifies the various options, or modifiers, used to simulate pointer input through [InjectedInputMouseInfo](injectedinputmouseinfo.md), [InjectedInputPenInfo](injectedinputpeninfo.md), and [InjectedInputTouchInfo](injectedinputtouchinfo.md).

## -enum-fields
### -field None:0
No pointer modifier. Default.

### -field New:1
Indicates the arrival of a new pointer.

### -field InRange:2
Indicates that the pointer continues to exist. When this flag is not set, it indicates the pointer has left detection range.

### -field InContact:4
Indicates that the pointer is in contact with the digitizer surface or area. When this flag is not set, it indicates a hovering pointer.

### -field FirstButton:16
Indicates a primary action.

A touch pointer has this flag set when it is in contact with the digitizer surface.

A pen pointer has this flag set when it is in contact with the digitizer surface with no buttons pressed.

A mouse pointer has this flag set when the left mouse button is down.

### -field SecondButton:32
Indicates a secondary action.

A touch pointer does not use this flag.

A pen pointer has this flag set when it is in contact with the digitizer surface with the pen barrel button pressed.

A mouse pointer has this flag set when the right mouse button is down.

### -field Primary:8192
Indicates that the pointer can perform actions beyond those available to non-primary pointers. For example, when a primary pointer makes contact with a window’s surface, it might provide the window an opportunity to activate.

The primary pointer is identified from all current user interactions on the system (mouse, touch, pen, and so on). As such, the primary pointer might not be associated with your app. The first contact in a multi-touch interaction is set as the primary pointer. Once a primary pointer is identified, all contacts must be lifted before a new contact can be identified as a primary pointer. For apps that don't process pointer input, only the primary pointer's events are promoted to mouse events.

### -field Confidence:16384
Indicates a suggestion from the source device about whether the pointer represents an intended or accidental interaction, which is especially relevant for touch pointers where an accidental interaction (such as with the palm of the hand) can trigger input. The presence of this flag indicates that the source device has high confidence that this input is part of an intended interaction.

### -field Canceled:32768
Indicates that the pointer is departing in an abnormal manner, such as when the system receives invalid input for the pointer or when a device with active pointers departs abruptly. If the application receiving the input is in a position to do so, it should treat the interaction as not completed and reverse any effects of the pointer.

### -field PointerDown:65536
Indicates that this pointer made contact with the digitizer surface. A touch pointer has this flag set when it is in contact with the digitizer surface.

A pen pointer has this flag set when it is in contact with the digitizer surface.

A mouse pointer has this flag set when a mouse button is pressed.

### -field Update:131072
Indicates a simple update that does not include pointer state changes.

### -field PointerUp:262144
Indicates that this pointer ended contact with the digitizer surface. A touch pointer has this flag set when it ends contact with the digitizer surface.

A pen pointer has this flag set when it ends contact with the digitizer surface.

A mouse pointer has this flag set when a mouse button is released.

### -field CaptureChanged:2097152
Indicates that this pointer was captured by (associated with) another element and the original element has lost capture.


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

[InjectedInputPenInfo.PointerInfo](injectedinputpeninfo_pointerinfo.md), [InjectedInputTouchInfo.PointerInfo](injectedinputtouchinfo_pointerinfo.md), [Simulate user input through input injection](/windows/uwp/design/input/input-injection)
