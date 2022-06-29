---
-api-id: P:Windows.ApplicationModel.DesignMode.DesignMode2Enabled
-api-type: winrt property
---

<!-- Property syntax.
public bool DesignMode2Enabled { get; }
-->

# Windows.ApplicationModel.DesignMode.DesignMode2Enabled

## -description

Used to enable or disable user code inside a XAML designer that targets the Windows 10 Fall Creators Update SDK, or later.

## -property-value

**True** if called from code running inside a XAML designer that targets the Windows 10 Fall Creators Update, or later; otherwise **false**.

## -remarks

[Windows.ApplicationModel.DesignMode.DesignModeEnabled](designmode_designmodeenabled.md) returns **true** when called from user code running inside any version of the XAML designer--regardless of which SDK version you target. This check is recommended for most users.

Starting with the Windows 10 Fall Creators Update, Visual Studio provides a new XAML designer that targets the Windows 10 Fall Creators Update and later.  

Use **Windows.ApplicationModel.DesignMode.DesignMode2Enabled** to differentiate code that depends on functionality only enabled for a XAML designer that targets the Windows 10 Fall Creators Update SDK or later.

The following table lists differences in functionality supported by the XAML designer, depending on the version of the Windows 10 SDK that the XAML designer targets.

|           | XAML designer that targets the Windows 10 Creators Update SDK or earlier  | Xaml designer that targets the Windows 10 Fall Creators Update SDK or later |
|-----------|:------------------:|:------------------:|
| [CoreWindow](/uwp/api/windows.ui.core.corewindow) | :x: | :heavy_check_mark: |
| [CoreDispatcher](/uwp/api/windows.ui.core.coredispatcher) | :x: | :heavy_check_mark: |
| Threading model | Single-threaded apartment (STA) | Application single-threaded apartment (ASTA) |
| .NET Framework | Desktop | Core |
| UI Composition support | :x: | :heavy_check_mark: |
| Acrylic brush support | :x: | :heavy_check_mark: |
| Fluent design system | Limited | Full support |

## -see-also

[Windows.ApplicationModel.DesignMode.DesignModeEnabled](designmode_designmodeenabled.md)

## -examples

The following code only executes when running inside a XAML designer, regardless of the version of the SDK that the XAML designer targets. We recommend this check for most users.

```csharp
if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
{
    // Code to execute when running inside a XAML designer, regardless of the SDK the designer targets.
}
```

The following code only executes when running inside a XAML designer that targets the Windows 10 Fall Creators Update SDK or later.

```csharp
if (Windows.ApplicationModel.DesignMode.DesignMode2Enabled)
{
    // Code to execute when running inside a XAML designer that targets the Fall Creators Update SDK, or later.
}
```
