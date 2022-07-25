---
-api-id: P:Windows.UI.Xaml.Controls.AppBarToggleButton.DynamicOverflowOrder
-api-type: winrt property
---

<!-- Property syntax
public int DynamicOverflowOrder { get;  set; }
-->

# Windows.UI.Xaml.Controls.AppBarToggleButton.DynamicOverflowOrder

## -description
Gets or sets the order in which this item is moved to the [CommandBar](commandbar.md) overflow menu.



## -xaml-syntax
```xaml
<AppBarToggleButton DynamicOverflowOrder="int" .../>
```


## -property-value
The order in which this item is moved to the overflow menu relative to other items.

## -remarks
For more info and guidelines, see the [App bar and command bar](/windows/uwp/controls-and-patterns/app-bars) article.

Starting in Windows 10, version 1607, [CommandBar](commandbar.md) introduces a dynamic overflow feature. By default, [PrimaryCommands](commandbar_primarycommands.md) automatically move in or out of the overflow area as the command bar width changes, for example, when users resize their app window. You can set the [IsDynamicOverflowEnabled](commandbar_isdynamicoverflowenabled.md) property to **false** to disable this behavior.

Dynamic overflow affects only the UI presentation of the commands, it doesn’t move commands from the [PrimaryCommands](commandbar_primarycommands.md) collection to [SecondaryCommands](commandbar_secondarycommands.md).

This property has an effect only when this element is in the [CommandBar.PrimaryCommands](commandbar_primarycommands.md) collection and [CommandBar.IsDynamicOverflowEnabled](commandbar_isdynamicoverflowenabled.md) is **true**.

You can assign the same DynamicOverflowOrder value to more than one element. Elements with the same value move in and out of the overflow area at the same time.

### Version compatibility

The DynamicOverflowOrder property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

> [!NOTE]
> Dynamic overflow is available when your app is compiled for Windows 10, version 1607 and running on version 1607 (or later). Dynamic overflow is not available when your app is compiled for a previous version or is running on a previous version.

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```xaml
<CommandBar x:Name="commandBar1" Loaded="CommandBar_Loaded">
    <AppBarToggleButton x:Name="appBarButtonShuffle" Icon="Shuffle" Label="Shuffle"/>
    <AppBarToggleButton x:Name="appBarButtonRepeat" Icon="RepeatAll" Label="Repeat"/>
</CommandBar>
```

```csharp
private void CommandBar_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.AppBarToggleButton", "DynamicOverflowOrder"))
    {
        commandBar1.IsDynamicOverflowEnabled = true;
        appBarButtonShuffle.DynamicOverflowOrder = 1;
        appBarButtonRepeat.DynamicOverflowOrder = 2;
    }
}

```



## -examples

## -see-also
