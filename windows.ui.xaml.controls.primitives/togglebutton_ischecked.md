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
<dl><dt>togglebutton</dt><dd>togglebutton A literal ToggleButton, or a derived type such as CheckBox or RadioButton.</dd>
</dl>

## -property-value
**true** if the [ToggleButton](togglebutton.md) is checked; **false** if the [ToggleButton](togglebutton.md) is unchecked; otherwise **null**. The default is **false**.

<!--Projection dochack:-->
If you are programming using C# or Microsoft Visual Basic, the type of this property is projected as **bool?** (a nullable [Boolean](/dotnet/api/system.boolean?view=dotnet-uwp-10.0&preserve-view=true)).

## -remarks
[ToggleButton](togglebutton.md) and can have three states: <table>
   <tr><th>State</th><th>Property</th><th>Value</th></tr>
   <tr><td>checked</td><td>IsChecked</td><td><b>true</b></td></tr>
   <tr><td>unchecked</td><td>IsChecked</td><td><b>false</b></td></tr>
   <tr><td>indeterminate</td><td>IsChecked</td><td><b>null</b></td></tr>
</table>

 For the [ToggleButton](togglebutton.md) to report the indeterminate state, you must set the [IsThreeState](togglebutton_isthreestate.md) property to **true**.

> [!NOTE]
> [ToggleButton](togglebutton.md) has the same visual state for the indeterminate and unchecked states. Derived controls, like [CheckBox](../windows.ui.xaml.controls/checkbox.md), may define different visual states for each state.

To set the value to **null** in XAML, use the [{x:Null} markup extension](/windows/uwp/xaml-platform/x-null-markup-extension).

## -examples

## -see-also
[Nullable](/dotnet/api/system.nullable-1?view=dotnet-uwp-10.0&preserve-view=true), [{x:Null} markup extension](/windows/uwp/xaml-platform/x-null-markup-extension)
