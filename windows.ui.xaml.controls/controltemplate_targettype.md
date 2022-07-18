---
-api-id: P:Windows.UI.Xaml.Controls.ControlTemplate.TargetType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName TargetType { get;  set; }
-->

# Windows.UI.Xaml.Controls.ControlTemplate.TargetType

## -description
Gets or sets the type to which the [ControlTemplate](controltemplate.md) is applied.



## -xaml-syntax
```xaml
<ControlTemplate TargetType="typeName"/>
```


## -xaml-values
<dl><dt>typeName</dt><dd>typeNameA string that specifies the type name of the type where the template is applied.</dd>
</dl>
## -property-value
The type to which the [ControlTemplate](controltemplate.md) is applied. This value is usually set in XAML, not code. See Remarks.

## -remarks
The typical way to specify a TargetType value is through a XAML attribute on the [ControlTemplate](controltemplate.md). When set in XAML, the meaning of TargetType and the values you provide take on some aspects of how types are represented in XAML. In particular, any prefixes that would be necessary to refer to a given type as a XAML element should also be included as the value of the TargetType value string. For example, if a template is intended to target a custom type that must be preceded by the already-mapped prefix "local" in a particular markup scope, then the TargetType value should include that same prefix. This behavior is enabled by built-in conversion behavior in the Windows Runtime XAML parser.

In most cases, you will be setting the TargetType for a [ControlTemplate](controltemplate.md) where that [ControlTemplate](controltemplate.md) is within a [Setter](../windows.ui.xaml/setter.md) for the [Template](control_template.md) property. This in turn is within the implicit [Style](../windows.ui.xaml/style.md) you are defining for a control. The ControlTemplate.TargetType value and the [Style.TargetType](../windows.ui.xaml/style_targettype.md) value of the containing [Style](../windows.ui.xaml/style.md) should always be the same type reference, referring to the same implicitly named control. Otherwise the control template might not work.

For more info on how to write a control template, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).

> [!NOTE]
> If you have previously programmed XAML for Windows Presentation Foundation (WPF), then you might have used an **x:Type** markup extension to fill in any XAML values that take a [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). The Windows Runtime XAML parser does not support **x:Type**. Instead, you should refer to the type by name without using any markup extension, and any necessary XAML-to-backing type conversion is already handled by the built-in conversion behavior described in the previous paragraph.

### Using **TargetType** in code

Setting TargetType in code is uncommon. The XAML style/template system is intended to be used by loading XAML as a resource and having all aspects of a control template be ready beforehand. There should be very few scenarios where you would not know info about controls and templates until runtime, where there is a need to set a TargetType on a [ControlTemplate](controltemplate.md) created or referenced in code.

Getting a TargetType in code is also uncommon, but you might do this to double-check that a [ControlTemplate](controltemplate.md) that you've loaded from XAML is compatible with a given control target that you got from the runtime tree.

> [!TIP]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](../windows.ui.xaml.interop/typename.md) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, you usually use the **typeof** operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type based on a type name as a string. In Microsoft Visual Basic, use **GetType**.

## -examples

## -see-also
[Style.TargetType](../windows.ui.xaml/style_targettype.md), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)
