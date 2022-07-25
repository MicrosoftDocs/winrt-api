---
-api-id: P:Windows.UI.Xaml.Controls.MenuFlyoutItem.KeyboardAcceleratorTextOverride
-api-type: winrt property
---

<!-- Property syntax.
public string KeyboardAcceleratorTextOverride { get;  set; }
-->

# Windows.UI.Xaml.Controls.MenuFlyoutItem.KeyboardAcceleratorTextOverride

## -description
Gets or sets a string that overrides the default key combination string associated with a [keyboard accelerator](../windows.ui.xaml/uielement_keyboardaccelerators.md).

<img src="images/keyboard-accelerators.png" alt="Example of a menu showing keyboard accelerators for various menu items">

*Example of a menu showing keyboard accelerators for various menu items*



## -property-value
The string to replace the default key combination string. The default is null.

Use a single space for no text.

## -remarks
Windows 10, version 1703, introduced [keyboard accelerator](../windows.ui.xaml/uielement_keyboardaccelerators.md) shortcuts. However, these shortcuts were not displayed with the UI of their corresponding controls.

Starting with Windows 10, version 1803, when [KeyboardAccelerators](../windows.ui.xaml/uielement_keyboardaccelerators.md) are declared, controls display the corresponding key combinations by default.

The override text is not be presented if the system cannot detect an attached keyboard (you can check this yourself through the [KeyboardPresent](../windows.devices.input/keyboardcapabilities_keyboardpresent.md) property).

### Version compatibility

The KeyboardAcceleratorTextOverride property is not available prior to Windows 10, version 1803. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```xaml
<CommandBar x:Name="commandBar1" Loaded="CommandBar_Loaded">
    <AppBarToggleButton x:Name="appBarButtonShuffle" Icon="Shuffle" Label="Shuffle"/>
</CommandBar>


<Button Content="Button Flyout">
   <Button.Flyout>
      <MenuFlyout>
         <MenuFlyoutItem x:Name="menuFlyoutItemExample" Text="Item 1" />
         <MenuFlyoutItem Text="Item 2" />
         <MenuFlyoutSeparator />
         <MenuFlyoutSubItem Text="Item 3">
            <MenuFlyoutItem Text="Item 4" />
            <MenuFlyoutSubItem Text="Item 5">
               <MenuFlyoutItem Text="Item 6" />
               <MenuFlyoutItem Text="Item 7" />
            </MenuFlyoutSubItem>
         </MenuFlyoutSubItem>
         <MenuFlyoutSeparator />
         <ToggleMenuFlyoutItem Text="Toggle Menu Item 1" />
      </MenuFlyout>
   </Button.Flyout>
</Button>
```

```csharp
private void Button_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.MenuFlyoutItem", "KeyboardAcceleratorTextOverride"))
    {
        menuFlyoutItemExample.KeyboardAcceleratorTextOverride = "Ctrl+S";
    }
}
```
## -see-also
[Keyboard Accelerators](/windows/uwp/design/input/keyboard-accelerators)

## -examples

