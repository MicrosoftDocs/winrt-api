---
-api-id: P:Windows.UI.Xaml.Controls.ComboBox.MaxDropDownHeight
-api-type: winrt property
---

<!-- Property syntax
public double MaxDropDownHeight { get;  set; }
-->

# Windows.UI.Xaml.Controls.ComboBox.MaxDropDownHeight

## -description
 Gets or sets the maximum height for a combo box drop-down. 



## -xaml-syntax
```xaml
<ComboBox MaxDropDownHeight="double"/>
```


## -property-value
The maximum height of the drop-down. The default is infinity.

## -remarks
> [!NOTE]
> In Windows 8, this property is ignored. If this property is set incorrectly (set to 0, for example) in an app that's compiled for Windows 8, the app might behave incorrectly or crash when it's run in Windows 8.1. You should set this property to a value of 76 or greater to make sure the scroll buttons show and behave correctly when the [ComboBox](combobox.md) is open.

## -examples

## -see-also
