---
-api-id: P:Windows.UI.Xaml.Controls.Pivot.HeaderFocusVisualPlacement
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.PivotHeaderFocusVisualPlacement HeaderFocusVisualPlacement { get;  set; }
-->

# Windows.UI.Xaml.Controls.Pivot.HeaderFocusVisualPlacement

## -description
Gets or sets a value that specifies the style of focus visual used for pivot header items.



## -xaml-syntax
```xaml
<Pivot HeaderFocusVisualPlacement="pivotHeaderFocusVisualPlacementMemberName" />
```


## -xaml-values
<dl><dt>pivotHeaderFocusVisualPlacementMemberName</dt><dd>pivotHeaderFocusVisualPlacementMemberNameA named constant of the PivotHeaderFocusVisualPlacement enumeration; for example, SelectedItemHeader.</dd>
</dl>
## -property-value
A value of the enumeration that specifies the style of focus visual used for pivot header items. The default is **SelectedItemHeader**.

## -remarks
Use this property to specify how the focus visual is drawn around the [Pivot](pivot.md) header.

### Version compatibility

The HeaderFocusVisualPlacement property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```xaml
<Pivot x:Name="pivot1" Loaded="Pivot_Loaded">
    ...
</Pivot>
```

```csharp
private void Pivot_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.Pivot", "HeaderFocusVisualPlacement"))
    {
        pivot1.HeaderFocusVisualPlacement = PivotHeaderFocusVisualPlacement.SelectedItemHeader;
    }
}

```



## -examples

## -see-also
