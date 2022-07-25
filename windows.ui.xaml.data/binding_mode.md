---
-api-id: P:Windows.UI.Xaml.Data.Binding.Mode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Data.BindingMode Mode { get;  set; }
-->

# Windows.UI.Xaml.Data.Binding.Mode

## -description
Gets or sets a value that indicates the direction of the data flow in the binding.



## -xaml-syntax
```xaml
<Binding Mode="bindingModeMemberName"/>
```


## -xaml-values
<dl><dt>bindingModeMemberName</dt><dd>bindingModeMemberNameA named constant from the BindingMode enumeration, such as OneWay.</dd>
</dl>
## -property-value
One of the [BindingMode](bindingmode.md) values. The default is **OneWay**: the source updates the target, but changes to the target value do not update the source.

## -remarks
For **OneWay** and **TwoWay** bindings, dynamic changes to the source don't automatically propagate to the target without providing some support from the source. You must implement the **INotifyPropertyChanged** interface on the source object so that the source can report changes through events that the binding engine listens for. For C# or Microsoft Visual Basic, implement [System.ComponentModel.INotifyPropertyChanged](/dotnet/api/system.componentmodel.inotifypropertychanged?view=dotnet-uwp-10.0&preserve-view=true). For Visual C++ component extensions (C++/CX), implement [Windows::UI::Xaml::Data::INotifyPropertyChanged](inotifypropertychanged.md).

For **TwoWay** bindings, changes to the target automatically propagate to the source, except if the binding target is the [TextBox.Text](../windows.ui.xaml.controls/textbox_text.md) property. In that case, the update happens only when the [TextBox](../windows.ui.xaml.controls/textbox.md) loses focus. Also, it's possible to set [UpdateSourceTrigger](binding_updatesourcetrigger.md) on **TwoWay** bindings to **Explicit**, in which case you control the updates to the source explicitly by calling [UpdateSource](bindingexpression_updatesource_190615267.md).

For **OneTime** and **OneWay** bindings, calls to [DependencyObject.SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) automatically change the target value and delete the binding.


<!--For two way, what? Updates source, or deletes binding and therefore source no longer connected?-->

You can't set the property values of a [Binding](binding.md) object after that binding has been attached to a target element and target property. If you attempt this you'll get a run-time exception.

## -examples
This example demonstrates how to set the binding mode in XAML.



[!code-xaml[BindingMode](../windows.ui.xaml.controls.primitives/code/Binding_Simple/csharp/Page.xaml#SnippetBindingMode)]

## -see-also
[XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [UpdateSourceTrigger](binding_updatesourcetrigger.md), [System.ComponentModel.INotifyPropertyChanged](/dotnet/api/system.componentmodel.inotifypropertychanged?view=dotnet-uwp-10.0&preserve-view=true)
