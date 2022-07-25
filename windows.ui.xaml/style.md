---
-api-id: T:Windows.UI.Xaml.Style
-api-type: winrt class
---

<!-- Class syntax.
public class Style : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.IStyle
-->

# Windows.UI.Xaml.Style

## -description
Contains property setters that can be shared between instances of a type. A Style is usually declared in a resources collection so that it can be shared and used for applying control templates and other styles.



## -xaml-syntax
```xaml
<Style .../>
-or-
<Style ...>
  oneOrMoreSetters
</Style>
```


## -remarks
A Style is basically a collection of property settings applied to one or more instances of a particular type that has such properties. A Style contains a collection of one or more [Setter](setter.md) objects. Each [Setter](setter.md) has a [Property](setter_property.md) and a [Value](setter_value.md). The [Property](setter_property.md) is the name of the property of the element the style is applied to. The [Value](setter_value.md) is the value that is applied to the property.

In order to apply a Style, the target object must be a [DependencyObject](dependencyobject.md). The property that each [Setter](setter.md) references as a [Property](setter_property.md) value must be a dependency property.

You must set the [TargetType](style_targettype.md) property when you create a Style. Otherwise an exception is thrown.

If you set a value for the same property in a Style and also on an element directly, the value set on the element directly takes precedence. For more info, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview), specifically the "Dependency property value precedence" section.

### Defining a **Style** as a XAML resource

A Style is almost always defined in XAML as a resource in a [ResourceDictionary](resourcedictionary.md).
+ For a Style that is used only by other UI items defined in the same XAML page, you typically define the Style in the [FrameworkElement.Resources](frameworkelement_resources.md) collection (`Page.Resources` if your root element is a [Page](../windows.ui.xaml.controls/page.md)).
+ For a Style that is used by more than one page in your app, you typically define the Style in the [Application.Resources](application_resources.md) collection. Alternatively, you might have a separate XAML file for the app that you include in [Application.Resources](application_resources.md) as a [MergedDictionaries](resourcedictionary_mergeddictionaries.md) value.
+ Most UI elements have a default style that's defined by the Windows Runtime. Copies of the default styles can be seen in the design-helper XAML file called generic.xaml, which isn't technically a resource file for apps although it's structured like one. You can copy discrete parts of this file into your app's XAML as the starting point when you edit copies of styles as enabled by the tools, but once you make such a copy it needs to be included in one of the **Resources** collections or indirectly accessed through [MergedDictionaries](resourcedictionary_mergeddictionaries.md). In all these cases the modified XAML that overrides the default is included as part of your app.


> **Windows 8**
> If you are re-templating an existing control in Windows 8 XAML, you sometimes modify the Style elements that exist in the StandardStyles.xaml XAML file that is included in most of the starting app templates. StandardStyles.xaml is referenced by the template app.xaml files as a [MergedDictionaries](resourcedictionary_mergeddictionaries.md) source file. Templates for apps starting with Windows 8.1 don't use StandardStyles.xaml anymore.

A Style defined element in a [ResourceDictionary](resourcedictionary.md) is not required to have an [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute) or [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute), which is normally a requirement of being a XAML resource. A Style that's defined this way uses its [TargetType](style_targettype.md) property value as the implicit key and is known as an implicit style.

For more info on how to use XAML resource dictionaries, see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

### Styles and templates

You can use a [Setter](setter.md) in a Style to apply values to any dependency property. But it's the [Setter](setter.md) for the [Template](../windows.ui.xaml.controls/control_template.md) property of a [Control](../windows.ui.xaml.controls/control.md)-derived class that constitutes the majority of the XAML markup in a typical Style. The [Value](setter_value.md) for a [Setter](setter.md) with `Property="Template"` is almost always specified as a property element that contains a [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) object element.

When a Style is used to define a control template, the [TargetType](style_targettype.md) of the Style element and the [TargetType](../windows.ui.xaml.controls/controltemplate_targettype.md) of the [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) element for its [Control.Template](../windows.ui.xaml.controls/control_template.md) setter should always use the same value.

The [Template](../windows.ui.xaml.controls/control_template.md) setter defines the basic template UI definition for a control instance where that template is applied. It also contains the visual states for a control, and other state-based UI definitions such as default theme transitions. For a complex control such as [ListBox](../windows.ui.xaml.controls/listbox.md), the default template Style and the [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) within can have hundreds of lines of XAML. For more info on the role of Style in control templating scenarios, see [XAML Control templates](/windows/uwp/design/controls-and-patterns/control-templates).

The template for a control often includes visual states that change the appearance of the control in response to logical states. For example, a [Button](../windows.ui.xaml.controls/button.md) can have a different visual appearance when it's pressed by applying a new visual state from its template, and all appearance changes can come from XAML not code. For more info on how visual states work and how to modify them or define states for custom controls, see [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)) and [XAML Control templates](/windows/uwp/design/controls-and-patterns/control-templates).

### Styles and runtime behavior

You can change the values of individual properties that have been set by a Style at run time and your new values overwrite the [Setters](style_setters.md) values. For example, you can set the [Template](../windows.ui.xaml.controls/control_template.md) property at run time even if this property has been set by a style.

You can adjust the properties of a Style at run time, but only if that style hasn't been applied to anything, and only exists as a resource that's not being used implicitly. For example, you can add setters to the collection in [Setters](style_setters.md) for a style that exists in [Resources](frameworkelement_resources.md) with an [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute) but has no [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) value elsewhere in XAML that refers to that style. However, as soon as a Style is referenced and used for values by a loaded object, the Style should be considered sealed. You can detect the sealed state by checking the value of the [IsSealed](style_issealed.md) property for the Style. If it's **true**, then the style is sealed and you can't modify any properties of it or the [Setter](setter.md) subvalues within. The point in time when a style's been put into use and sealed can also be detected when the object where the Style is referenced raises its [Loaded](frameworkelement_loaded.md) event.

### BasedOn styles

You can build a new style based on an existing style that's defined by your app or by default styles for Windows Runtime controls. You can do this using the [BasedOn](style_basedon.md) property. This reduces duplication in your XAML and makes it easier to manage resources. Each style supports only one [BasedOn](style_basedon.md) style. For more info, see [BasedOn](style_basedon.md) or [Styling controls](/windows/uwp/controls-and-patterns/styling-controls).

### Implicit styles

You can define styles such that a Style is used implicitly by all objects of the same [TargetType](style_targettype.md), without requiring each instance of such an object to specifically reference the Style as a [FrameworkElement.Style](frameworkelement_style.md) value. When a `<Style>` resource is declared in a [ResourceDictionary](resourcedictionary.md) without an [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute), the **x:Key** value uses the value of the [TargetType](style_targettype.md) property. If you set the style implicitly, the style is applied only to the types that match the [TargetType](style_targettype.md) exactly and not to elements derived from the [TargetType](style_targettype.md) value. For example, if you create a style implicitly for all the [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) controls in your application, and your application has [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) and [CheckBox](../windows.ui.xaml.controls/checkbox.md) controls ([CheckBox](../windows.ui.xaml.controls/checkbox.md) derives from [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md)), the "ToggleButton" implicit style is applied only to the [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) controls.

### Notes on XAML syntax

[Setters](style_setters.md) is the XAML content property for Style, so you can use an implicit collection syntax such as `<Style><Setter .../><Setter .../></Style>`.

Using the Style class in code (for example calling a constructor and building up the [Setter](setter.md) values one by one) is very rare. Styles are used for templates, and templates should be available at XAML load time, so any Style created in code is usually available too late to be applied to controls in a UI.

## -examples
This example creates two styles: one for a [TextBlock](../windows.ui.xaml.controls/textblock.md) and one for a [TextBox](../windows.ui.xaml.controls/textbox.md). Each style is applied to two instances of a control to create a uniform appearance for each [TextBlock](../windows.ui.xaml.controls/textblock.md) and [TextBox](../windows.ui.xaml.controls/textbox.md). The example sets the [FrameworkElement.Style](frameworkelement_style.md) property of each control by referencing the Style as a [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension). The example also shows how to retrieve a style from a resource dictionary and apply it to a control in code.

Each style has multiple [Setter](setter.md) parts. In this XAML, no `Style.Setters` XAML property element appears. That is the typical usage in XAML for this property. The `Style.Setters` value is implicit, because [Setters](style_setters.md) is the XAML content property for a Style. For more info on XAML syntax and how the XAML content syntax makes it possible to imply and omit certain XAML elements, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

Notice that in the style for the [TextBox](../windows.ui.xaml.controls/textbox.md), the [Margin](frameworkelement_margin.md) property is set to 4, which means that the [TextBox](../windows.ui.xaml.controls/textbox.md) has a margin of 4 on all sides. To compensate for the length of the second [TextBlock](../windows.ui.xaml.controls/textblock.md), which is shorter than the first [TextBlock](../windows.ui.xaml.controls/textblock.md) because **Last Name** takes less room than **First Name**, a value of "6,4,4,4" is assigned to the [Margin](frameworkelement_margin.md) property on the second [TextBox](../windows.ui.xaml.controls/textbox.md). This causes the second [TextBox](../windows.ui.xaml.controls/textbox.md) to have a different margin than what the style specifies, so that it aligns horizontally with the first [TextBox](../windows.ui.xaml.controls/textbox.md).

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

```csharp
private void ShowEmailAddressBox()
{
    TextBlock emailAddressLabel = new TextBlock();
    emailAddressLabel.Text = "Email:";
    emailAddressLabel.Style = (Style)rootPanel.Resources["TextBlockStyle"];

    TextBox emailAddressBox = new TextBox();
    emailAddressBox.Style = (Style)rootPanel.Resources["TextBoxStyle"];
    emailAddressBox.Margin = new Thickness(38, 4, 4, 4);

    emailAddressPanel.Children.Add(emailAddressLabel);
    emailAddressPanel.Children.Add(emailAddressBox);
}
```

This example creates two style elements. The TargetType for the first style element is set to TextBox and the TargetType for the second style element is set to Button. These are then applied as the implicit style for a TextBox control and a Button control.

[!code-xaml[ImplicitStyle](../windows.ui.xaml/code/ImplicitStyleSnippet/csharp/MainPage.xaml#SnippetImplicitStyle)]

This example creates a Style named InheritedStyle that is based on a Style named BaseStyle. InheritedStyle inherits the Background value of Yellow from BaseStyle and adds a Foreground value of Red.

[!code-xaml[BasedOn](../windows.ui.xaml/code/BasedOnSnippet/csharp/MainPage.xaml#SnippetBasedOn)]

## -see-also

[DependencyObject](dependencyobject.md), [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md), [Setter](setter.md), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary), [Styling controls](/windows/uwp/controls-and-patterns/styling-controls), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10))
