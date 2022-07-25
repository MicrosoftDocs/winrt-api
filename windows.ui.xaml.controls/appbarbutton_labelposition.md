---
-api-id: P:Windows.UI.Xaml.Controls.AppBarButton.LabelPosition
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.CommandBarLabelPosition LabelPosition { get;  set; }
-->

# Windows.UI.Xaml.Controls.AppBarButton.LabelPosition

## -description
Gets or sets a value that indicates the placement and visibility of the button's label.



## -xaml-syntax
```xaml
<AppBarButton LabelPosition="commandBarLabelPositionMemberName" />
```


## -xaml-values
<dl><dt>commandBarLabelPositionMemberName</dt><dd>commandBarLabelPositionMemberNameA named constant of the CommandBarLabelPosition enumeration; for example, Collapsed.</dd>
</dl>
## -property-value
An enumeration value that specifies the placement and visibility of the button's label. The default is **Default**.

## -remarks
By default, the app bar button's label is displayed in the position specified by the [CommandBar.DefaultLabelPosition](commandbar_defaultlabelposition.md) property. You can set the LabelPosition property to override this value and make the label always collapsed for a specific app bar button.

### Version compatibility

The LabelPosition property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```xaml
<CommandBar x:Name="commandBar1" Loaded="CommandBar_Loaded">
    <AppBarButton x:Name="appBarButtonCut" Icon="Cut" Label="Cut"/>
</CommandBar>
```

```csharp
private void CommandBar_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.AppBarButton", "LabelPosition"))
    {
        appBarButtonCut.LabelPosition = CommandBarLabelPosition.Collapsed;
    }
}

```



## -examples

## -see-also
