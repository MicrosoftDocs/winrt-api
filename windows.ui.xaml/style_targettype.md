---
-api-id: P:Windows.UI.Xaml.Style.TargetType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName TargetType { get;  set; }
-->

# Windows.UI.Xaml.Style.TargetType

## -description
Gets or sets the type for which the style is intended. TargetType can be used to declare an implicit style resource if there's no resource key specified.



## -xaml-syntax
```xaml
<Style TargetType="typeName"/>
```


## -xaml-values
<dl><dt>typeName</dt><dd>typeNameA string that specifies the type name of the type where the style is applied. This might include an xmlns prefix for custom types; see Remarks.</dd>
</dl>
## -property-value
The type of object to which the style is applied. This value is usually set in XAML, not code. See Remarks.

## -remarks
A TargetType value is required for all cases where you use or declare a [Style](style.md). There is no default value. Even a [Style](style.md) that is used as an inline value of the [FrameworkElement.Style](frameworkelement_style.md) property requires an explicit TargetType value.

The typical way to specify a TargetType value is through a XAML attribute on the [Style](style.md) element. When set in XAML, the meaning of TargetType and the values you provide take on some aspects of how types are represented in XAML.

For XAML, any prefixes that would be necessary to refer to a type through a XAML element usage should be included in the TargetType attribute value. For example, if a style targets a custom type, which is defined in a code namespace that's mapped to the "local:" prefix, then the TargetType attribute value for that type's style should include that same prefix preceding the type name. This behavior is enabled by built-in string-type conversion behavior in the Windows Runtime XAML parser.

When defining styles for custom types, once you've included a mapping prefix for a TargetType you don't include any prefix in the [Property](setter_property.md) value of any [Setter](setter.md) within that [Style](style.md).

The value you provide for TargetType modifies the lookup behavior for any [Setter.Property](setter_property.md) value you specify within the style. Specifically, the dependency properties that you reference by name for a [Setter.Property](setter_property.md) XAML attribute value are expected to exist on the TargetType type, or on any ancestor class. For example, if the TargetType you specify is [Button](../windows.ui.xaml.controls/button.md), and one of the [Setter.Property](setter_property.md) XAML attribute values in the [Style](style.md) is "Background", that resolves to the [Control.Background](../windows.ui.xaml.controls/control_background.md) property ([Control](../windows.ui.xaml.controls/control.md) is three levels above [Button](../windows.ui.xaml.controls/button.md) in its class inheritance, and [Button](../windows.ui.xaml.controls/button.md) inherits all properties of [Control](../windows.ui.xaml.controls/control.md)). It's typical to specify the TargetType value to be the same UI element names you'd use in typical UI markup, you wouldn't usually name an ancestor class (although that's technically allowed).

If the [Style](style.md) includes a [Setter](setter.md) that declares a control template (a value for the [Template](../windows.ui.xaml.controls/control_template.md) property), then the TargetType value of the parent [Style](style.md) should match the [TargetType](../windows.ui.xaml.controls/controltemplate_targettype.md) value of the contained [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) element.

### Implicit styles

Styles are almost always declared as XAML resources that are shared and applied to each UI element in the app that references that style. In order to be declared as a resource, all XAML elements including the [Style](style.md) elements must have a key within the resources collection that distinguishes each resource for lookup at run-time. The [Style](styletypedpropertyattribute.md) element (and also the various template elements such as [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md)) support a feature called *implicit styles*. For an implicit style, the value you provide for the TargetType value also serves as the key for that style in its resources collection scope, and you aren't required to specify the [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute) value. (In contrast, most other elements you declare within a resources collection do need an explicit [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute) value and you'd get design-time or parser errors that enforce this.)

A style that's declared using the implicit style then is used as the [Style](style.md) value for any UI element instance that specifically is of the type that matches the TargetType of the implicit style. Controls don't need to reference a style with a [Style](frameworkelement_style.md) attribute value and a [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) reference to a key to get this behavior, it's implicit behavior if those controls match an existing implicit style's type.

Implicit styles don't apply to elements that are subtypes of the type referenced as the TargetType value. For example, if you declare an implicit style for [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) controls, and your app has [CheckBox](../windows.ui.xaml.controls/checkbox.md) controls ([CheckBox](../windows.ui.xaml.controls/checkbox.md) derives from [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md)), the style applies specifically to [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) controls but not to [CheckBox](../windows.ui.xaml.controls/checkbox.md) controls.

The Windows Runtime defines default implicit styles for every practical UI element that's part of the Windows Runtime  API. It has to do this because these styles define the visuals for elements (particularly the templates), and an element with no visuals won't even appear in the UI or participate in layout. All of these implicit styles can be seen in the design-helper XAML file called generic.xaml. The tools you use to edit XAML can copy discrete parts of this file into your app's XAML as the starting point when you edit copies of styles as enabled by the tools. Within the default implicit styles, there are many layers of resource reference, as well as theme support using the [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) and theme-specific brushes or other resources. You can override any implicit style that would otherwise come from the Windows Runtime defines default implicit styles. For more info, see [Quickstart: Styling controls](/previous-versions/windows/apps/hh465498(v=win.10)) and [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).

### Using **TargetType** in code

Setting TargetType in code is uncommon. The XAML style system is intended to be used by loading XAML as a resource and having all aspects of a style be ready beforehand. There should be very few scenarios where you would not know info about how to style a control or apply a style until runtime, where there'd be a need to set a TargetType on a [Style](style.md) created or referenced in code.

Getting a TargetType in code is also uncommon, but there are perhaps a few more scenarios where you might be doing this. For example, there might be a set of named [Style](style.md) resources already defined in your XAML. But you might want to double-check that a style you're about to apply to a control has a TargetType value that works for the type of the control you're applying it to. So, you might have code like this:
```csharp
        private bool VerifyStyle(FrameworkElement scope, String styleKey, Control applyTo)
        {
            Style styleToCheck = scope.Resources[styleKey] as Style;
            if (styleToCheck != null)
            {
                if (styleToCheck.TargetType == applyTo.GetType())
                {
                    // applyTo.Style = styleToCheck;
                    return true;
                }
            }
            return false;
        }
```



> [!TIP]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](../windows.ui.xaml.interop/typename.md) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#C#, you usually use the **typeof** operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type based on a type name as a string. In Microsoft Visual Basic, use **GetType**.

### Migration notes

+ If you have used XAML for Windows Presentation Foundation (WPF), then you might have used an **x:Type** markup extension to fill in any XAML values that take a [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). The Windows Runtime XAML parser does not support **x:Type**. Instead, you should refer to the type by name without using any markup extension, and any necessary XAML-to-backing type conversion is already handled by the built-in conversion behavior in the XAML parser.


## -examples
This example creates two styles: one for a [TextBlock](../windows.ui.xaml.controls/textblock.md) and one for a [TextBox](../windows.ui.xaml.controls/textbox.md). Each style is applied to two instances of a control to create a uniform appearance for each [TextBlock](../windows.ui.xaml.controls/textblock.md) and [TextBox](../windows.ui.xaml.controls/textbox.md). The example sets the [FrameworkElement.Style](frameworkelement_style.md) property of each control by referencing the [Style](style.md) as a [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension).

```xaml
<StackPanel x:Name="rootPanel">
  <StackPanel.Resources>
    <!--Create a Style for a TextBlock to specify that the
              Foreground equals Navy, FontSize equals 14, and
              VerticalAlignment equals Botton.-->
    <Style TargetType="TextBlock" x:Key="TextBlockStyle">
      <Setter Property="Foreground" Value="Navy"/>
      <Setter Property="FontSize" Value="14"/>
      <Setter Property="VerticalAlignment" Value="Bottom"/>
    </Style>

    <!--Create a Style for a TextBox that specifies that
              the Width is 200, Height is 30, Margin is 4,
              Background is LightBlue, and FontSize is 14.-->
    <Style TargetType="TextBox" x:Key="TextBoxStyle">
      <Setter Property="Width" Value="200"/>
      <Setter Property="Height" Value="30"/>
      <Setter Property="Margin" Value="4"/>
      <Setter Property="FontSize" Value="14"/>
      <Setter Property="Background">
        <Setter.Value>
          <LinearGradientBrush StartPoint="0,0.5" EndPoint="1,0.5">
            <GradientStop Color="White" Offset="0.0"/>
            <GradientStop Color="LightBlue" Offset="0.5"/>
            <GradientStop Color="Navy" Offset="1"/>
          </LinearGradientBrush>
        </Setter.Value>
      </Setter>
    </Style>
  </StackPanel.Resources>

  <!--Apply the TextBlockStyle and TextBoxStyle to each 
      TextBlock and TextBox, respectively.-->
  <StackPanel Orientation="Horizontal">
    <TextBlock Text="First Name:" Style="{StaticResource TextBlockStyle}"/>
    <TextBox Style="{StaticResource TextBoxStyle}"/>
  </StackPanel>
  <StackPanel Orientation="Horizontal">
    <TextBlock Text="Last Name:" Style="{StaticResource TextBlockStyle}"/>
    <TextBox Style="{StaticResource TextBoxStyle}"
             Margin="6,4,4,4"/>
  </StackPanel>
  <StackPanel x:Name="emailAddressPanel" Orientation="Horizontal"/>
</StackPanel>
```

## -see-also
