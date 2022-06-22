---
-api-id: P:Windows.UI.Xaml.Controls.CommandBar.DefaultLabelPosition
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.CommandBarDefaultLabelPosition DefaultLabelPosition { get;  set; }
-->

# Windows.UI.Xaml.Controls.CommandBar.DefaultLabelPosition

## -description
Gets or sets a value that indicates the placement and visibility of the labels on the command bar's buttons.



## -xaml-syntax
```xaml
<CommandBar DefaultLabelPosition="commandBarDefaultLabelPositionMemberName" />
```


## -xaml-values
<dl><dt>commandBarDefaultLabelPositionMemberName</dt><dd>commandBarDefaultLabelPositionMemberNameA named constant of the CommandBarDefaultLabelPosition enumeration; for example, Right.</dd>
</dl>
## -property-value
An enumeration value that indicates the placement and visibility of the labels on the command bar's buttons. The default is **Bottom**.

## -remarks
By default, an app bar button's label is displayed below the icon. You can set this property to show labels to the right of the icon, or to hide labels.

You can set the [AppBarButton.LabelPosition](appbarbutton_labelposition.md) property to override this value and make the label always collapsed for a specific app bar button.

### Version compatibility

The DefaultLabelPosition property is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not set this property in XAML or use it without performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this property before you set it.

```xaml
<CommandBar x:Name="commandBar1" Loaded="CommandBar_Loaded">
    ...
</CommandBar>
```

```csharp
private void CommandBar_Loaded(object sender, RoutedEventArgs e)
{
    if (ApiInformation.IsPropertyPresent("Windows.UI.Xaml.Controls.CommandBar", "DefaultLabelPosition"))
    {
        commandBar1.DefaultLabelPosition = CommandBarDefaultLabelPosition.Right;
    }
}

```



## -examples

## -see-also
