---
-api-id: P:Windows.UI.Xaml.Controls.Control.IsTabStop
-api-type: winrt property
---

<!-- Property syntax
public bool IsTabStop { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.IsTabStop

## -description
Gets or sets a value that indicates whether a control is included in tab navigation.

## -xaml-syntax
```xaml
<control IsTabStop="bool"/>
```


## -property-value
**true** if the control is included in tab navigation; otherwise, **false**. The default is **true**.

## -remarks
Controlling the tab sequence with a combination of IsTabStop and [TabIndex](control_tabindex.md) rather than using the default tab sequence is sometimes necessary in order to tune the keyboard accessibility of your UI. For more info, see [Keyboard accessibility](/windows/uwp/accessibility/keyboard-accessibility).

If IsTabStop is **false**, the control is excluded from tab navigation. In addition, if IsTabStop is **false**, the control cannot receive input focus. (If you try to set focus programmatically, by calling the [Focus](control_focus_195503898.md) method, [Focus](control_focus_195503898.md) returns **false**).

If the reason you don't want the control to be a tab stop is because it's not interactive in your UI, you might want to set [IsEnabled](control_isenabled.md) to **false** to make the lack of interaction more obvious. Many controls have predefined visual states that are invoked for [IsEnabled](control_isenabled.md) =**false**, such as "graying out" text in labels.

## -examples

## -see-also
[TabNavigation](control_tabnavigation.md), [TabIndex](control_tabindex.md), [IsEnabled](control_isenabled.md), [Keyboard accessibility](/windows/uwp/accessibility/keyboard-accessibility)
