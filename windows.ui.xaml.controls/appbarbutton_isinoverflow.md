---
-api-id: P:Windows.UI.Xaml.Controls.AppBarButton.IsInOverflow
-api-type: winrt property
---

<!-- Property syntax
public bool IsInOverflow { get; }
-->

# Windows.UI.Xaml.Controls.AppBarButton.IsInOverflow

## -description
Gets a value that indicates whether this item is in the overflow menu.



## -property-value
**true** if this item is in the overflow menu; otherwise, **false**.

## -remarks
For more info and guidelines, see the [App bar and command bar](/windows/uwp/controls-and-patterns/app-bars) article.

Starting in Windows 10, version 1607, [CommandBar](commandbar.md) introduces a dynamic overflow feature. By default, [PrimaryCommands](commandbar_primarycommands.md) automatically move in or out of the overflow area as the command bar width changes, for example, when users resize their app window. You can set the [IsDynamicOverflowEnabled](commandbar_isdynamicoverflowenabled.md) property to **false** to disable this behavior.

Dynamic overflow affects only the UI presentation of the commands, it doesn’t move commands from the [PrimaryCommands](commandbar_primarycommands.md) collection to [SecondaryCommands](commandbar_secondarycommands.md).

### Version compatibility

The IsInOverflow property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

> [!NOTE]
> Dynamic overflow is available when your app is compiled for Windows 10, version 1607 and running on version 1607 (or later). Dynamic overflow is not available when your app is compiled for a previous version or is running on a previous version.

To avoid exceptions when your app runs on previous versions of Windows 10, do not use this property without first performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you use it.

```csharp
if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.AppBarButton", "IsInOverflow"))
{
    bool overflow = appBarButton1.IsInOverflow;
}

```



## -examples

## -see-also
[App bar and command bar guide](/windows/uwp/controls-and-patterns/app-bars)
