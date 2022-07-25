---
-api-id: E:Windows.UI.Xaml.Controls.CommandBar.DynamicOverflowItemsChanging
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler DynamicOverflowItemsChanging<Windows.UI.Xaml.Controls.CommandBar,  Windows.UI.Xaml.Controls.DynamicOverflowItemsChangingEventArgs>
-->

# Windows.UI.Xaml.Controls.CommandBar.DynamicOverflowItemsChanging

## -description
Occurs when items move into or out of the overflow menu.



## -xaml-syntax
```xaml
<CommandBar DynamicOverflowItemsChanging="eventhandler"/>
```


## -remarks
For event data, see [DynamicOverflowItemsChangingEventArgs](dynamicoverflowitemschangingeventargs.md).

Starting in Windows 10, version 1607, [CommandBar](commandbar.md) introduces a dynamic overflow feature. By default, [PrimaryCommands](commandbar_primarycommands.md) automatically move in or out of the overflow area as the command bar width changes, for example, when users resize their app window. You can set the [IsDynamicOverflowEnabled](commandbar_isdynamicoverflowenabled.md) property to **false** to disable this behavior.

Dynamic overflow affects only the UI presentation of the commands, it doesn’t move commands from the [PrimaryCommands](commandbar_primarycommands.md) collection to [SecondaryCommands](commandbar_secondarycommands.md).

### Version compatibility

The [IsDynamicOverflowEnabled](commandbar_isdynamicoverflowenabled.md) event is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

> [!NOTE]
> Dynamic overflow is available when your app is compiled for Windows 10, version 1607 and running on version 1607 (or later). Dynamic overflow is not available when your app is compiled for a previous version or is running on a previous version.

To avoid exceptions when your app runs on previous versions of Windows 10, do not connect this event without first performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this event before you use it.

```xaml
<CommandBar x:Name="commandBar1" Loaded="CommandBar_Loaded">
    ...
</CommandBar>
```

```csharp
private void CommandBar_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsEventPresent("Windows.UI.Xaml.Controls.CommandBar", "DynamicOverflowItemsChanging"))
    {
        commandBar1.DynamicOverflowItemsChanging += CommandBar1_DynamicOverflowItemsChanging;
    }
}

```



## -examples

## -see-also
[DynamicOverflowItemsChangingEventArgs](dynamicoverflowitemschangingeventargs.md), [App bar and command bar](/windows/uwp/controls-and-patterns/app-bars)
