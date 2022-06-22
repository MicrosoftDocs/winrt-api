---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.ButtonBase
-api-type: winrt class
---

<!-- Class syntax.
public class ButtonBase : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.Primitives.IButtonBase
-->

# Windows.UI.Xaml.Controls.Primitives.ButtonBase

## -description
Represents the base class for all button controls, such as [Button](../windows.ui.xaml.controls/button.md), [RepeatButton](repeatbutton.md), and [HyperlinkButton](../windows.ui.xaml.controls/hyperlinkbutton.md).



## -remarks
### **ButtonBase** derived classes

ButtonBase is the parent class for several immediately derived controls that refine specific button behaviors for UI interaction:

+ [Button](../windows.ui.xaml.controls/button.md)
+ [HyperlinkButton](../windows.ui.xaml.controls/hyperlinkbutton.md)
+ [RepeatButton](repeatbutton.md)
+ [ToggleButton](togglebutton.md) (parent of [RadioButton](../windows.ui.xaml.controls/radiobutton.md), [AppBarToggleButton](../windows.ui.xaml.controls/appbartogglebutton.md), [CheckBox](../windows.ui.xaml.controls/checkbox.md))


## -examples
The following example demonstrates handling the [Click](buttonbase_click.md) event and setting the [IsEnabled](../windows.ui.xaml.controls/control_isenabled.md) property of a [Button](../windows.ui.xaml.controls/button.md), which inherits from ButtonBase.

[!code-xaml[4](../windows.ui.xaml/code/System.Windows.Controls.ButtonClickEx/csharp/Page.xaml#Snippet4)]

[!code-csharp[41](../windows.ui.xaml/code/System.Windows.Controls.ButtonClickEx/csharp/Page.xaml.cs#Snippet41)]

[!code-vb[41](../windows.ui.xaml/code/System.Windows.Controls.ButtonClickEx/vbnet/Page.xaml.vb#Snippet41)]

## -see-also
[ContentControl](../windows.ui.xaml.controls/contentcontrol.md)
