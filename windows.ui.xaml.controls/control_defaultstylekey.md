---
-api-id: P:Windows.UI.Xaml.Controls.Control.DefaultStyleKey
-api-type: winrt property
---

<!-- Property syntax
protected object DefaultStyleKey { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.DefaultStyleKey

## -description

Gets or sets the key that references the default style for the control. Authors of custom controls use this property to change the default for the style that their control uses.



## -property-value

The key that references the default style for the control. To work correctly as part of theme style lookup, this value is expected to be a [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) value.

> [!NOTE]
> Visual C++ component extensions (C++/CX) uses a string that is the qualified name of the type. But this relies on generated code that produces a [TypeName](../windows.ui.xaml.interop/typename.md) once accessed by a XAML compiler; see Remarks.

## -remarks

 DefaultStyleKey is one of the very few protected properties in the Windows Runtime  API. It's intended only for use by control authors, who will be subclassing some existing control class and therefore have the necessary access to set this property. For many custom control scenarios where you'll be setting DefaultStyleKey, you'll also be overriding [OnApplyTemplate](../windows.ui.xaml/frameworkelement_onapplytemplate_1955470198.md).

The return type of DefaultStyleKey is loosely typed as **Object** in the syntax, but the XAML style system will expect the value to provide a type reference:

+ For a control that has its logic written in C#, the value of DefaultStyleKey should be an instance of [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). Typically you set this value in the default constructor:

```csharp
public CustomControl1()
{
    this.DefaultStyleKey = typeof(CustomControl1);
}
```

+ For a control that has its logic written in Microsoft Visual Basic, the value of DefaultStyleKey should be an instance of [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). Typically you set this value in the default constructor:

```vb
Public Sub New()
    Me.DefaultStyleKey = GetType(CustomControl1)
End Sub
```

```cppwinrt
CustomControl1::CustomControl1() // public: in the header.
{
	DefaultStyleKey(winrt::box_value(L"App1.CustomControl1"));
}
```

+ For a control that has its logic written in Visual C++ component extensions (C++/CX), the value of DefaultStyleKey should be a namespace-qualified string that is the name of the custom control class. Typically you set this value in the default constructor:

```cppcx
CustomControl1::CustomControl1() //public: in the header
{
    DefaultStyleKey = "App1.CustomControl1";
}
```

> [!NOTE]
> Ultimately the string alone isn't enough to support a Visual C++ component extensions (C++/CX) type reference. If you use the **Add / New Item / Templated Control** options in Solution Explorer, the templates and support for Visual C++ component extensions (C++/CX) and XAML generates classes that give [IXamlMetadataProvider](../windows.ui.xaml.markup/ixamlmetadataprovider.md) info. The XAML compiler can access this code when the XAML is loaded, and uses it to validate and create types and members and join the partial classes. As far as what you define in your own app code, the string is all you need. But if you're curious you can have a look at the XamlTypeInfo.g.h and XamlTypeInfo.g.cpp files that are generated.

Control authors could choose to not provide a value for DefaultStyleKey, but that's uncommon. The result would be that the default style is the one as defined by the base class. In some cases (like for [ContentControl](contentcontrol.md)) the value is **null**. Even if you choose to not redefine the value, make sure that the original default style is useful for rendering your control.

When a XAML control is loaded, the rendering process starts, and the system is looking for the correct template to apply, what's being loaded is the XAML default style for the control, including its template. Included in the Windows Runtime is an internal copy of all the default styles for all the XAML controls that the Windows Runtime defines. The type reference in DefaultStyleKey tells the system which named XAML resource to load as this style. In XAML form, the styles really are keyed by type even though there's no mechanism in Windows Runtime XAML that defines a type reference explicitly. But for any [TargetType](../windows.ui.xaml/style_targettype.md) value, which is the attribute that holds the key for lookup, it's implicitly assumed to represent a type reference in the form of a string. For example, DefaultStyleKey from a [Button](button.md) is a [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) instance where the **Name** is "Button", **FullName** is "Windows.UI.Xaml.Controls.Button". The system uses this info to know to load the [Style](../windows.ui.xaml/style.md) from the internal resources that has `TargetType="Button"`.

Custom controls usually aren't in the default XAML namespace. Instead, they're in a XAML namespace that has a **using:** statement to reference the app's code namespace. By default, projects create a prefix "local:" that maps this namespace for you. You could also map other XAML namespaces to refer to additional code namespaces for controls or other code that your app defines.

The "local:" prefix (or some other namespace that maps to your app's code and namespaces) should precede the name of your custom control, when it's in XAML as the [TargetType](../windows.ui.xaml/style_targettype.md) value. This is also already done for you by the starting templates; when you add a new control, you'll see a generic.xaml file that contains just one style. That style will have [TargetType](../windows.ui.xaml/style_targettype.md) value that is a string starting with "local:" and completed by the name you chose for your custom control class. To match previous examples that set DefaultStyleKey in a `CustomControl1` definition, you'd see an element for `<Style TargetType="local:CustomControl1">` defined in the starting generic.xaml, and that style defines the control template as well as setting other properties.

> [!NOTE]
> The "local:" prefix is isolated to the XAML where it's defined and used. XAML namespaces and the prefixes only have meaning within XAML and are self-contained to each XAML file. DefaultStyleKey values in code don't include the prefixes.

## -examples

## -see-also
[OnApplyTemplate](../windows.ui.xaml/frameworkelement_onapplytemplate_1955470198.md), [Style](../windows.ui.xaml/style.md), [Style.TargetType](../windows.ui.xaml/style_targettype.md), [XAML namespaces and namespace mapping](/windows/uwp/xaml-platform/xaml-namespaces-and-namespace-mapping), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10))
