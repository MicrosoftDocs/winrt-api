---
-api-id: P:Windows.UI.Xaml.Controls.Control.TabIndex
-api-type: winrt property
---

<!-- Property syntax
public int TabIndex { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.TabIndex

## -description
Gets or sets a value that determines the order in which elements receive focus when the user navigates through controls by pressing the Tab key.

## -xaml-syntax
```xaml
<control TabIndex="int"/>
```


## -property-value
A value that determines the order of logical navigation for a device. The default value is [MaxValue](/dotnet/api/system.int32.maxvalue?view=dotnet-uwp-10.0&preserve-view=true) with the tab order based on declaration order in the XAML or child collections.

## -remarks
For UWP apps, initial focus is set to the element with the highest TabIndex that can receive focus. Child elements of container controls are ignored. In a tie, the first element in the visual tree receives focus.
## -examples

## -see-also
[IsTabStop](control_istabstop.md), [TabNavigation](control_tabnavigation.md), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions), [Keyboard accessibility](/windows/uwp/accessibility/keyboard-accessibility)
