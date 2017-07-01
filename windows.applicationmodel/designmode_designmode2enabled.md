---
-api-id: P:Windows.ApplicationModel.DesignMode.DesignMode2Enabled
-api-type: winrt property
---

<!-- Property syntax.
public bool DesignMode2Enabled { get; }
-->

# Windows.ApplicationModel.DesignMode.DesignMode2Enabled

## -description
Used to enable/disable user code inside a XAML designer that targets the Windows 10 Fall Creators Update SDK, or later.

## -property-value
**True** if the user code is running inside the XAML designer for a project that targets the Windows 10 Fall Creators Update or later; otherwise **false**.

## -remarks
Starting with the Fall Creators Update, Visual Studio supports a new XAML designer. Use this property to determine when your code is running in the new designer.

Note that [Windows.ApplicationModel.DesignMode.DesignModeEnabled](designmode_designmodeenabled.md) returns **true** when your  code runs inside any version of the XAML designer, regardless of which SDK version you target. Most users should use this check unless you need to know specifically that your code is running in the new designer.

The following table lists the functionality differences between the legacy XAML designer and the new designer in the Fall Creators Update:

|           | Legacy designer  | Fall Creators Update designer |
|-----------|:------------------:|:------------------:|
|[CoreWindow](https://docs.microsoft.com/en-us/uwp/api/windows.ui.core.corewindow) |:x:|:heavy_check_mark:|
|[CoreDispatcher](https://docs.microsoft.com/en-us/uwp/api/windows.ui.core.coredispatcher) |:x:|:heavy_check_mark:|
|Threading model | Single-threaded apartment (STA) | Application single-threaded apartment (ASTA) |
|.NET Framework | Desktop | Core |
|UI Composition support |:x:|:heavy_check_mark:|
|Acrylic brush support |:x:|:heavy_check_mark:|
|Fluent design system | Limited | Full support |

> [!NOTE]
> This property is available only in the presence of a developer certificate.

## -see-also

## -examples
The following code only executes when running inside a XAML designer, regardless of the SDK the designer targets. We recommend this check for most users.

```csharp
if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
{
    // Code to execute when running inside any version of the XAML designer
}
```

The following code only executes when running inside a XAML designer if your project targets the Windows 10 Fall Creators Update SDK or later.

```csharp
if (Windows.ApplicationModel.DesignMode.DesignMode2Enabled)
{
    // Code to execute when running inside a XAML designer that targets the Fall Creators Update SDK, or later.
}
```
