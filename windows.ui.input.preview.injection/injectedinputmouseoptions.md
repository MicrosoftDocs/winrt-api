---
-api-id: T:Windows.UI.Input.Preview.Injection.InjectedInputMouseOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Preview.Injection.InjectedInputMouseOptions : uint
-->

# InjectedInputMouseOptions

## -description
Specifies the various options, or modifiers, used to simulate mouse input through [InjectedInputMouseInfo](injectedinputmouseinfo.md).

## -enum-fields
### -field None:0
No mouse modifier. Default.

### -field Move:1
Move (coalesce move messages). If a mouse event occurs and the application has not yet processed the previous mouse event, the previous one is thrown away. See **MoveNoCoalesce**.

### -field LeftDown:2
Left mouse button pressed.

### -field LeftUp:4
Left mouse button released.

### -field RightDown:8
Right mouse button pressed.

### -field RightUp:16
Right mouse button released.

### -field MiddleDown:32
Middle mouse button pressed.

### -field MiddleUp:64
Middle mouse button released.

### -field XDown:128
XBUTTON pressed.

### -field XUp:256
XBUTTON released.

### -field Wheel:2048
Mouse wheel.

### -field HWheel:4096
Mouse tilt wheel.

### -field MoveNoCoalesce:8192
Move (do not coalesce move messages). The application processes all mouse events since the previously processed mouse event. See **Move**.

### -field VirtualDesk:16384
Map coordinates to the entire virtual desktop.

### -field Absolute:32768
Normalized absolute coordinates between 0 and 65,535. If the flag is not set, relative data (the change in position since the last reported position) is used.

Coordinate (0,0) maps onto the upper-left corner of the display surface; coordinate (65535,65535) maps onto the lower-right corner. In a multi-monitor system, the coordinates map to the primary monitor.

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

[Simulate user input through input injection](/windows/uwp/design/input/input-injection)
