---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsChecked
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<bool> IsChecked { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsChecked

## -description
Gets or sets whether the [ToggleButton](togglebutton.md) is checked.

## -xaml-syntax
```xaml
<togglebutton IsChecked="bool"/>
-or-
<togglebutton IsChecked="{x:Null}"/>
```


## -xaml-values
<dl><dt>togglebutton</dt><dd>togglebuttonA literal ToggleButton, or a derived type such as CheckBox or RadioButton.</dd>
</dl>
## -property-value
**true** if the [ToggleButton](togglebutton.md) is checked; **false** if the [ToggleButton](togglebutton.md) is unchecked; otherwise **null**. The default is **false**.

<!--Projection dochack:-->
If you are programming using C#or Microsoft Visual Basic, the type of this property is projected as **bool?**(a nullable [Boolean](https://msdn.microsoft.com/library/system.boolean.aspx)).

## -remarks
[ToggleButton](togglebutton.md) and can have three states: <table>
   <tr><th>State</th><th>Property</th><th>Value</th></tr>
   <tr><td>checked</td><td>[  IsChecked](togglebutton_ischecked.md)</td><td>**true**</td></tr>
   <tr><td>unchecked</td><td>[  IsChecked](togglebutton_ischecked.md)</td><td>**false**</td></tr>
   <tr><td>indeterminate</td><td>[  IsChecked](togglebutton_ischecked.md)</td><td>**null**</td></tr>
</table>

 For the [ToggleButton](togglebutton.md) to report the indeterminate state, you must set the [IsThreeState](togglebutton_isthreestate.md) property to **true**.

> [!NOTE]
> [ToggleButton](togglebutton.md) has the same visual state for the indeterminate and unchecked states. Derived controls, like [CheckBox](../windows.ui.xaml.controls/checkbox.md), may define different visual states for each state.

To set the value to **null** in XAML, use the [{x:Null} markup extension](http://msdn.microsoft.com/library/e6a4038e-4ada-4e82-9824-582fc16ab037).

## -examples

## -see-also
[Nullable](https://docs.microsoft.com/dotnet/api/system.nullable-1), [{x:Null} markup extension](http://msdn.microsoft.com/library/e6a4038e-4ada-4e82-9824-582fc16ab037)