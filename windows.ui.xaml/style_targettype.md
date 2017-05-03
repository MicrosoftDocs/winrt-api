---
-api-id: P:Windows.UI.Xaml.Style.TargetType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName TargetType { get;  set; }
-->

# Windows.UI.Xaml.Style.TargetType

## -description
Gets or sets the type for which the style is intended. [TargetType](style_targettype.md) can be used to declare an implicit style resource if there's no resource key specified.

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
A [TargetType](style_targettype.md) value is required for all cases where you use or declare a [Style](style.md). There is no default value. Even a [Style](style.md) that is used as an inline value of the [FrameworkElement.Style](frameworkelement_style.md) property requires an explicit [TargetType](style_targettype.md) value.

The typical way to specify a [TargetType](style_targettype.md) value is through a XAML attribute on the [Style](style.md) element. When set in XAML, the meaning of [TargetType](style_targettype.md) and the values you provide take on some aspects of how types are represented in XAML.

For XAML, any prefixes that would be necessary to refer to a type through a XAML element usage should be included in the [TargetType](style_targettype.md) attribute value. For example, if a style targets a custom type, which is defined in a code namespace that's mapped to the "local:" prefix, then the [TargetType](style_targettype.md) attribute value for that type's style should include that same prefix preceding the type name. This behavior is enabled by built-in string-type conversion behavior in the Windows Runtime XAML parser.

When defining styles for custom types, once you've included a mapping prefix for a [TargetType](style_targettype.md) you don't include any prefix in the [Property](setter_property.md) value of any [Setter](setter.md) within that [Style](style.md).

The value you provide for [TargetType](style_targettype.md) modifies the lookup behavior for any [Setter.Property](setter_property.md) value you specify within the style. Specifically, the dependency properties that you reference by name for a [Setter.Property](setter_property.md) XAML attribute value are expected to exist on the [TargetType](style_targettype.md) type, or on any ancestor class. For example, if the [TargetType](style_targettype.md) you specify is [Button](../windows.ui.xaml.controls/button.md), and one of the [Setter.Property](setter_property.md) XAML attribute values in the [Style](style.md) is "Background", that resolves to the [Control.Background](../windows.ui.xaml.controls/control_background.md) property ([Control](../windows.ui.xaml.controls/control.md) is three levels above [Button](../windows.ui.xaml.controls/button.md) in its class inheritance, and [Button](../windows.ui.xaml.controls/button.md) inherits all properties of [Control](../windows.ui.xaml.controls/control.md)). It's typical to specify the [TargetType](style_targettype.md) value to be the same UI element names you'd use in typical UI markup, you wouldn't usually name an ancestor class (although that's technically allowed).

If the [Style](style.md) includes a [Setter](setter.md) that declares a control template (a value for the [Template](../windows.ui.xaml.controls/control_template.md) property), then the [TargetType](style_targettype.md) value of the parent [Style](style.md) should match the [TargetType](../windows.ui.xaml.controls/controltemplate_targettype.md) value of the contained [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) element.

### Implicit styles

Styles are almost always declared as XAML resources that are shared and applied to each UI element in the app that references that style. In order to be declared as a resource, all XAML elements including the [Style](style.md) elements must have a key within the resources collection that distinguishes each resource for lookup at run-time. The [Style](styletypedpropertyattribute.md) element (and also the various template elements such as [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md)) support a feature called *implicit styles*. For an implicit style, the value you provide for the [TargetType](style_targettype.md) value also serves as the key for that style in its resources collection scope, and you aren't required to specify the [x:Key attribute](http://msdn.microsoft.com/library/141fc5af-80ee-4401-8a1b-17cb22c2277a) value. (In contrast, most other elements you declare within a resources collection do need an explicit [x:Key attribute](http://msdn.microsoft.com/library/141fc5af-80ee-4401-8a1b-17cb22c2277a) value and you'd get design-time or parser errors that enforce this.)

A style that's declared using the implicit style then is used as the [Style](style.md) value for any UI element instance that specifically is of the type that matches the [TargetType](style_targettype.md) of the implicit style. Controls don't need to reference a style with a [Style](frameworkelement_style.md) attribute value and a [{StaticResource} markup extension](http://msdn.microsoft.com/library/d50349b5-4588-4ebd-9458-75f629ccc395) reference to a key to get this behavior, it's implicit behavior if those controls match an existing implicit style's type.

Implicit styles don't apply to elements that are subtypes of the type referenced as the [TargetType](style_targettype.md) value. For example, if you declare an implicit style for [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) controls, and your app has [CheckBox](../windows.ui.xaml.controls/checkbox.md) controls ([CheckBox](../windows.ui.xaml.controls/checkbox.md) derives from [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md)), the style applies specifically to [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) controls but not to [CheckBox](../windows.ui.xaml.controls/checkbox.md) controls.

The Windows Runtime defines default implicit styles for every practical UI element that's part of the Windows Runtime  API. It has to do this because these styles define the visuals for elements (particularly the templates), and an element with no visuals won't even appear in the UI or participate in layout. All of these implicit styles can be seen in the design-helper XAML file called generic.xaml. The tools you use to edit XAML can copy discrete parts of this file into your app's XAML as the starting point when you edit copies of styles as enabled by the tools. Within the default implicit styles, there are many layers of resource reference, as well as theme support using the [{ThemeResource} markup extension](http://msdn.microsoft.com/library/8a1c79d2-9566-44aa-b8e1-cc7adad1bcc5) and theme-specific brushes or other resources. You can override any implicit style that would otherwise come from the Windows Runtime defines default implicit styles. For more info, see [Quickstart: Styling controls](http://msdn.microsoft.com/library/45d4f823-e637-4131-a63b-268af4d3e743) and [Quickstart: Control templates](http://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77).

### Using **TargetType** in code

Setting [TargetType](style_targettype.md) in code is uncommon. The XAML style system is intended to be used by loading XAML as a resource and having all aspects of a style be ready beforehand. There should be very few scenarios where you would not know info about how to style a control or apply a style until runtime, where there'd be a need to set a [TargetType](style_targettype.md) on a [Style](style.md) created or referenced in code.

Getting a [TargetType](style_targettype.md) in code is also uncommon, but there are perhaps a few more scenarios where you might be doing this. For example, there might be a set of named [Style](style.md) resources already defined in your XAML. But you might want to double-check that a style you're about to apply to a control has a [TargetType](style_targettype.md) value that works for the type of the control you're applying it to. So, you might have code like this:
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
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](../windows.ui.xaml.interop/typename.md) type projects as [System.Type](https://msdn.microsoft.com/library/system.type.aspx). When programming using C#C#, you usually use the **typeof** operator to get references to the [System.Type](https://msdn.microsoft.com/library/system.type.aspx) of a type based on a type name as a string. In Microsoft Visual Basic, use **GetType**.

### Migration notes

+ If you have used XAML for Windows Presentation Foundation (WPF), then you might have used an **x:Type** markup extension to fill in any XAML values that take a [System.Type](https://msdn.microsoft.com/library/system.type.aspx). The Windows Runtime XAML parser does not support **x:Type**. Instead, you should refer to the type by name without using any markup extension, and any necessary XAML-to-backing type conversion is already handled by the built-in conversion behavior in the XAML parser.


## -examples
This example creates two styles: one for a [TextBlock](../windows.ui.xaml.controls/textblock.md) and one for a [TextBox](../windows.ui.xaml.controls/textbox.md). Each style is applied to two instances of a control to create a uniform appearance for each [TextBlock](../windows.ui.xaml.controls/textblock.md) and [TextBox](../windows.ui.xaml.controls/textbox.md). The example sets the [FrameworkElement.Style](frameworkelement_style.md) property of each control by referencing the [Style](style.md) as a [{StaticResource} markup extension](http://msdn.microsoft.com/library/d50349b5-4588-4ebd-9458-75f629ccc395).



[!code-xml[11](../windows.ui.xaml.data/code/StylingTemplatingOverview/csharp/ButtonStages.xaml#Snippet11)]

## -see-also
