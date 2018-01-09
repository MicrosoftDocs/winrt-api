---
-api-id: T:Windows.UI.Xaml.Controls.ToggleSwitch
-api-type: winrt class
---

<!-- Class syntax.
public class ToggleSwitch : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IToggleSwitch, Windows.UI.Xaml.Controls.IToggleSwitchOverrides
-->

# Windows.UI.Xaml.Controls.ToggleSwitch

## -description
Represents a switch that can be toggled between two states.

## -xaml-syntax
```xaml
<ToggleSwitch .../>
-or-
<ToggleSwitch ...>
  oneOrMorePropertyElementComponents
</ToggleSwitch>
```


## -remarks
[ToggleSwitch](toggleswitch.md) is a control that can be toggled between 2 states.

<img alt="Toggle switch control" src="images/controls/ToggleSwitch.png" />

Use a [ToggleSwitch](toggleswitch.md) control to let the user switch an option between on and off states. Use the [IsOn](toggleswitch_ison.md) property to determine the state of the switch. Handle the [Toggled](toggleswitch_toggled.md) event to respond to changes in the state.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [ToggleSwitch](toggleswitch.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>ToggleSwitchContainerBackground</td><td>Background color of entire control bounds at rest</td></tr>
   <tr><td>ToggleSwitchContainerBackgroundPointerOver</td><td>Background color on hover</td></tr>
   <tr><td>ToggleSwitchContainerBackgroundPressed</td><td>Background color when pressed</td></tr>
   <tr><td>ToggleSwitchContainerBackgroundDisabled</td><td>Background color when disabled</td></tr>
   <tr><td>ToggleSwitchContentForeground</td><td>Label text color at rest</td></tr>
   <tr><td>ToggleSwitchContentForegroundDisabled</td><td>Label text color when disabled</td></tr>
   <tr><td>ToggleSwitchHeaderForeground</td><td>Header text color at rest</td></tr>
   <tr><td>ToggleSwitchHeaderForegroundDisabled</td><td>Header text color when disabled</td></tr>
   <tr><td>ToggleSwitchFillOff</td><td>Background color of switch control part in "Off" state</td></tr>
   <tr><td>ToggleSwitchFillOffPointerOver</td><td>Background olor of switch control part in "Off" state on hover</td></tr>
   <tr><td>ToggleSwitchFillOffPressed</td><td>Background color of switch control part in "Off" state when pressed</td></tr>
   <tr><td>ToggleSwitchFillOffDisabled</td><td>Background color of switch control part in "Off" state when disabled</td></tr>
   <tr><td>ToggleSwitchFillOn</td><td>Background color of switch control part in "On" state</td></tr>
   <tr><td>ToggleSwitchFillOnPointerOver</td><td>Background color of switch control part in "On" state on hover</td></tr>
   <tr><td>ToggleSwitchFillOnPressed</td><td>Background color of switch control part in "On" state when pressed</td></tr>
   <tr><td>ToggleSwitchFillOnDisabled</td><td>Background color of switch control part in "On" state when disabled</td></tr>
   <tr><td>ToggleSwitchStrokeOff</td><td>Border color of switch control part in "Off" state</td></tr>
   <tr><td>ToggleSwitchStrokeOffPointerOver</td><td>Border color of switch control part in "Off" state on hover</td></tr>
   <tr><td>ToggleSwitchStrokeOffPressed</td><td>Border color of switch control part in "Off" state when pressed</td></tr>
   <tr><td>ToggleSwitchStrokeOffDisabled</td><td>Border color of switch control part in "Off" state when disabled</td></tr>
   <tr><td>ToggleSwitchStrokeOn</td><td>Border color of switch control part in "On" state</td></tr>
   <tr><td>ToggleSwitchStrokeOnPointerOver</td><td>Border color of switch control part in "On" state on hover</td></tr>
   <tr><td>ToggleSwitchStrokeOnPressed</td><td>Border color of switch control part in "On" state when pressed</td></tr>
   <tr><td>ToggleSwitchStrokeOnDisabled</td><td>Border color of switch control part in "On" state when disabled</td></tr>
   <tr><td>ToggleSwitchKnobFillOff</td><td>Color of switch control's knob in "Off" state</td></tr>
   <tr><td>ToggleSwitchKnobFillOffPointerOver</td><td>Color of switch control's knob in "Off" state on hover</td></tr>
   <tr><td>ToggleSwitchKnobFillOffPressed</td><td>Color of switch control's knob in "Off" state when pressed</td></tr>
   <tr><td>ToggleSwitchKnobFillOffDisabled</td><td>Color of switch control's knob in "Off" state when disabled</td></tr>
   <tr><td>ToggleSwitchKnobFillOn</td><td>Color of switch control's knob in "On" state</td></tr>
   <tr><td>ToggleSwitchKnobFillOnPointerOver</td><td>Color of switch control's knob in "On" state on hover</td></tr>
   <tr><td>ToggleSwitchKnobFillOnPressed</td><td>Color of switch control's knob in "On" state when pressed</td></tr>
   <tr><td>ToggleSwitchKnobFillOnDisabled</td><td>Color of switch control's knob in "On" state when disabled</td></tr>
</table>

## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to open the app and see the <a href="xamlcontrolsgallery:/item/ToggleSwitch">ToggleSwitch</a> in action.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

This example shows how to set the [Header](toggleswitch_header.md), [OnContent](toggleswitch_oncontent.md), and [OffContent](toggleswitch_offcontent.md) properties of a toggle switch. The [Toggled](toggleswitch_toggled.md) event is handled to turn a [ProgressRing](progressring.md) control on or off.

```xaml
<StackPanel Orientation="Horizontal">
    <ToggleSwitch Header="Toggle Switch Example" 
        OffContent="Do work" OnContent="Working" 
        Toggled="ToggleSwitch_Toggled"/>  
    <ProgressRing x:Name="progress1"/>
</StackPanel>
```

```csharp
        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    progress1.IsActive = true;
                    progress1.Visibility = Visibility.Visible;
                }
                else
                {
                    progress1.IsActive = false;
                    progress1.Visibility = Visibility.Collapsed;
                }
            }
        }
```



## -see-also
[Toggle switches overview](https://docs.microsoft.com/windows/uwp/controls-and-patterns/toggles), [ToggleSwitch styles and templates](http://msdn.microsoft.com/library/e1cd988d-550a-418c-ae1d-d12c14b369da), [CheckBox](checkbox.md), [RadioButton](radiobutton.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)