---
-api-id: P:Windows.UI.Xaml.Controls.Pivot.IsHeaderItemsCarouselEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsHeaderItemsCarouselEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.Pivot.IsHeaderItemsCarouselEnabled

## -description
Gets or sets a value that indicates whether the selected header moves to the first position.



## -xaml-syntax
```xaml
<Pivot IsHeaderItemsCarouselEnabled="bool" />
```


## -property-value
**true** if the selected header moves to the first position; **false** if headers always keep the same position. The default is **true**.

## -remarks
This property has an effect only when the Pivot doesn't have enough space to show all the headers. If space is available, all headers are shown regardless of this property setting.

By default, the selected [Pivot](pivot.md) header always moves to the first position (far left), and the headers carousel. The user can pan infinitely and the content just wraps around from front to back.

When this property is **false**, the [Pivot](pivot.md) headers always keep the same position. Scrolling is enabled to show headers that don't fit in the viewport.

### Version compatibility

The IsHeaderItemsCarouselEnabled property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```xaml
<Pivot x:Name="pivot1" Loaded="Pivot_Loaded">
    ...
</Pivot>
```

```csharp
private void Pivot_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.Pivot", "IsHeaderItemsCarouselEnabled"))
    {
        pivot1.IsHeaderItemsCarouselEnabled = false;
    }
}

```



## -examples

## -see-also
