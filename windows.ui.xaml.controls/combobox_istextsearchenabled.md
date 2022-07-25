---
-api-id: P:Windows.UI.Xaml.Controls.ComboBox.IsTextSearchEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsTextSearchEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ComboBox.IsTextSearchEnabled

## -description
Gets or sets a value that specifies whether a user can jump to a value by typing.



## -xaml-syntax
```xaml
<ComboBox IsTextSearchEnabled="bool"/>

```


## -property-value
**true** if a user can jump to a value by typing; otherwise, **false**. The default is **true**.

## -remarks
Starting in Windows 10, version 1607, [ComboBox](combobox.md) introduces a text search feature. By default, the [ComboBox](combobox.md) jumps to a relevant value as the user types. You can set the IsTextSearchEnabled property to **false** to disable this behavior. This is useful, for example, if you have extended [ComboBox](combobox.md) with custom text search.

### Version compatibility

The IsTextSearchEnabled property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

> [!NOTE]
> The text search feature is available when your app is compiled for Windows 10, version 1607 and running on version 1607 (or later). It is not available when your app is compiled for a previous version or is running on a previous version.

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```xaml
<ComboBox x:Name="comboBox1" Loaded="ComboBox_Loaded"/>
```

```csharp
private void ComboBox_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.ComboBox", "IsTextSearchEnabled"))
    {
        comboBox1.IsTextSearchEnabled = false;
    }
}

```



## -examples

## -see-also
