---
-api-id: T:Windows.UI.Xaml.Markup.ContentPropertyAttribute
-api-type: winrt class
---

<!-- Class syntax.
public class ContentPropertyAttribute : System.Attribute
-->

# Windows.UI.Xaml.Markup.ContentPropertyAttribute

## -description
Indicates which property of a type is the XAML content property. A XAML processor uses this information when processing XAML child elements of XAML representations of the attributed type.



## -remarks

**C++/WinRT**. See [The [contentproperty] attribute](/uwp/midl-3/predefined-attributes#the-contentproperty-attribute).

This attribute is used to identify that a specific property of the attributed type should be considered the XAML content property, when interpreted by XAML parsers and other XAML framework code. The purpose of a XAML content property is that it provides a XAML syntax shorthand that can omit property element markup for that property. The removal of property elements facilitates a more natural parent-children form in XAML markup. For more info on XAML content properties, see "XAML content properties" section of [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

An example of a class in the default Windows Runtime XAML vocabulary that has ContentPropertyAttribute applied is [Panel](../windows.ui.xaml.controls/panel.md). The property [Children](../windows.ui.xaml.controls/panel_children.md) on the [Panel](../windows.ui.xaml.controls/panel.md) is identified as the XAML content property as defined by the ContentPropertyAttribute and its **Name** value. The content property information is inherited by all derived types of [Panel](../windows.ui.xaml.controls/panel.md), such as [Grid](../windows.ui.xaml.controls/grid.md) and [Canvas](../windows.ui.xaml.controls/canvas.md) and [StackPanel](../windows.ui.xaml.controls/stackpanel.md).

This code approximates how [Panel](../windows.ui.xaml.controls/panel.md) applies ContentPropertyAttribute in C# (the true definition is applied in native code, this is for illustration only):
```csharp
[ContentProperty(Name = "Children")]
    public class Panel : FrameworkElement
    { ...}
```

Using [Panel](../windows.ui.xaml.controls/panel.md) and its derived class [StackPanel](../windows.ui.xaml.controls/stackpanel.md) as the illustration of the XAML content property concept, you may have the following XAML:
```xaml
<StackPanel>
  <StackPanel.Children>
    <TextBlock>Testing content attribute</TextBlock>
  </StackPanel.Children>
</StackPanel>
```

The above is equivalent to this more readable XAML:
```xaml
<StackPanel>
  <TextBlock>Testing content attribute</TextBlock>
</StackPanel>
```

When parsed by a XAML parser, the parser knows through the ContentPropertyAttribute applied on [Panel](../windows.ui.xaml.controls/panel.md) that any content found within the body of a [StackPanel](../windows.ui.xaml.controls/stackpanel.md) tag should be used to set the value of [Children](../windows.ui.xaml.controls/panel_children.md) on the created [StackPanel](../windows.ui.xaml.controls/stackpanel.md) instance.

Another prominent example of ContentPropertyAttribute in action can be seen on the [TextBlock](../windows.ui.xaml.controls/textblock.md) class. [TextBlock](../windows.ui.xaml.controls/textblock.md) uses [Inlines](../windows.ui.xaml.controls/textblock_inlines.md) as its content property, and the default inline class [Run](../windows.ui.xaml.documents/run.md) uses [Text](../windows.ui.xaml.documents/run_text.md) as its content property. In combination, the content properties enable a simple inline syntax such as `<TextBlock>Hello</TextBlock>`, even though the object graph created by this XAML is more complex and is also capable of supporting multiple explicit inline elements if desired.

## -examples

## -see-also
[Attribute](/dotnet/api/system.attribute?view=dotnet-uwp-10.0&preserve-view=true), [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide), [XAML overview](/windows/uwp/xaml-platform/xaml-overview)
