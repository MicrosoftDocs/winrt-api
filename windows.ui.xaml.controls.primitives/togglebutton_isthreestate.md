---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsThreeState
-api-type: winrt property
---

<!-- Property syntax
public bool IsThreeState { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsThreeState

## -description
Gets or sets a value that indicates whether the control supports three states.



## -xaml-syntax
```xaml
<togglebutton IsThreeState="bool"/>
```


## -xaml-values
<dl><dt>togglebutton</dt><dd>togglebuttonA literal ToggleButton, or a derived type such as CheckBox or RadioButton.</dd>
</dl>
## -property-value
**True** if the control supports three states; otherwise, **false**. The default is **false**.

## -remarks

[ToggleButton](togglebutton.md) and can have three states:

| State | Property | Value |
|---|---|---|
| checked | [IsChecked](togglebutton_ischecked.md) | **true** |
| unchecked | [IsChecked](togglebutton_ischecked.md) | **false** |
| indeterminate | [IsChecked](togglebutton_ischecked.md) | **null** |

For the [ToggleButton](togglebutton.md) to report the indeterminate state, you must set the IsThreeState property to **true**.

> [!NOTE]
> [ToggleButton](togglebutton.md) has the same visual state for the indeterminate and unchecked states. Derived controls, like [CheckBox](../windows.ui.xaml.controls/checkbox.md), may define different visual states for each state.

## -examples

## -see-also
