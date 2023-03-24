---
-api-id: P:Windows.UI.Xaml.Controls.Control.TabIndex
-api-type: winrt property
---

<!-- Property syntax
public int TabIndex { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.TabIndex

## -description

Gets or sets a value that indicates the order in which elements receive focus when the user navigates through the app UI using the Tab key.

## -xaml-syntax
```xaml
<control TabIndex="int"/>
```

## -property-value

A value that indicates the preferred order of navigation.

When no value is specified, the default value is [MaxValue](/dotnet/api/system.int32.maxvalue?view=dotnet-uwp-10.0&preserve-view=true). The system then attempts a tab order based on the declaration order in the XAML or child collections.

## -remarks

Initial focus is set to the element with the lowest TabIndex that can receive focus. In a tie, the first element in the visual tree receives focus. Child elements of container controls are ignored.

## -examples

## -see-also

[IsTabStop](control_istabstop.md), [TabNavigation](control_tabnavigation.md), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions), [Keyboard accessibility](/windows/uwp/accessibility/keyboard-accessibility)
