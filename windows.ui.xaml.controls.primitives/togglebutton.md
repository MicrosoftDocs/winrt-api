---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.ToggleButton
-api-type: winrt class
---

<!-- Class syntax.
public class ToggleButton : Windows.UI.Xaml.Controls.Primitives.ButtonBase, Windows.UI.Xaml.Controls.Primitives.IToggleButton, Windows.UI.Xaml.Controls.Primitives.IToggleButtonOverrides
-->

# Windows.UI.Xaml.Controls.Primitives.ToggleButton

## -description
Represents a control that a user can select (check) or clear (uncheck). Base class for controls that can switch states, such as [CheckBox](../windows.ui.xaml.controls/checkbox.md) and [RadioButton](../windows.ui.xaml.controls/radiobutton.md).

## -xaml-syntax
```xaml
<ToggleButton .../>
-or-
<ToggleButton>
    singleObject
</ToggleButton>
-or-
<ToggleButton>contentString</ToggleButton>
```


## -remarks
[ToggleButton](togglebutton.md) and can have three states: <table>
   <tr><th>State</th><th>Property</th><th>Value</th></tr>
   <tr><td>checked</td><td>[  IsChecked](togglebutton_ischecked.md)</td><td>**true**</td></tr>
   <tr><td>unchecked</td><td>[  IsChecked](togglebutton_ischecked.md)</td><td>**false**</td></tr>
   <tr><td>indeterminate</td><td>[  IsChecked](togglebutton_ischecked.md)</td><td>**null**</td></tr>
</table>

 For the [ToggleButton](togglebutton.md) to report the indeterminate state, you must set the [IsThreeState](togglebutton_isthreestate.md) property to **true**.

> [!NOTE]
> [ToggleButton](togglebutton.md) has the same visual state for the indeterminate and unchecked states. Derived controls, like [CheckBox](../windows.ui.xaml.controls/checkbox.md), may define different visual states for each state.

### **ToggleButton** derived classes

[ToggleButton](togglebutton.md) is the parent class for several immediately derived controls that toggle and are selectable:

+ [AppBarToggleButton](../windows.ui.xaml.automation.peers/appbartogglebuttonautomationpeer.md)
+ [CheckBox](../windows.ui.xaml.controls/checkbox.md)
+ [RadioButton](../windows.ui.xaml.controls/radiobutton.md)


## -examples
The following example shows how to create a three-state [ToggleButton](togglebutton.md) control.



[!code-xml[1](../windows.ui.xaml.data/code/System.Windows.Controls.ToggleButtonThreeState/csharp/Page.xaml#Snippet1)]

## -see-also
[ButtonBase](buttonbase.md), [ToggleButton styles and templates](https://msdn.microsoft.com/library/03017a91-a386-4a08-b0fc-63e98001ef6b), [AppBarToggleButton](../windows.ui.xaml.automation.peers/appbartogglebuttonautomationpeer.md), [CheckBox](../windows.ui.xaml.controls/checkbox.md), [RadioButton](../windows.ui.xaml.controls/radiobutton.md)
