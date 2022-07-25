---
-api-id: T:Windows.UI.Xaml.Controls.ClickMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.ClickMode : int
-->

# ClickMode

## -description
Specifies when the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised for a control.


## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field Release:0
Specifies that the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the left mouse button is pressed and released, and the mouse pointer is over the control. If you are using the keyboard, specifies that the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the SPACEBAR or ENTER key is pressed and released, and the control has keyboard focus.

### -field Press:1
Specifies that the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the mouse button is pressed and the mouse pointer is over the control. If you are using the keyboard, specifies that the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the SPACEBAR or ENTER key is pressed and the control has keyboard focus.

### -field Hover:2
Specifies that the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event should be raised when the mouse pointer moves over the control.


## -remarks

## -examples
The following example demonstrates the ClickMode enumeration.


+ Hover - When the mouse pointer hovers over the first button, the foreground color of the button changes.
+ Press - When the left mouse button is pressed while over the second button, the foreground color of the button changes.
+ Release - When the mouse button is pressed and released while over the third button, the button resets the foreground color of the other two buttons to their original color.




[!code-xaml[1](../windows.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml#Snippet1)]


[!code-csharp[11](../windows.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/csharp/Page.xaml.cs#Snippet11)]

[!code-vb[11](../windows.ui.xaml.data/code/System.Windows.Controls.ButtonClickModeSL/vbnet/Page.xaml.vb#Snippet11)]

## -see-also
