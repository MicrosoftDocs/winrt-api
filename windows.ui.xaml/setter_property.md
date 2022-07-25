---
-api-id: P:Windows.UI.Xaml.Setter.Property
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty Property { get;  set; }
-->

# Windows.UI.Xaml.Setter.Property

## -description
Gets or sets the property to apply the [Value](setter_value.md) to.



## -xaml-syntax
```xaml
<Setter Property="propertyName"/>
```


## -xaml-values
<dl><dt>propertyName</dt><dd>propertyNameA string that specifies the name of the property being set. This property must be a dependency property.</dd>
</dl>
## -property-value
A [DependencyProperty](dependencyproperty.md) to which the [Value](setter_value.md) will be applied. The default is **null**.

## -remarks
You must specify both the Property and [Value](setter_value.md) properties on a [Setter](setter.md). Otherwise an exception is thrown (either a parse exception or runtime error, depending on whether the [Setter](setter.md) is created in XAML or modified in code).

If you're accessing a [Setter](setter.md) instance using code, you cannot change the value of any property of a [Setter](setter.md) instance if the value of the [IsSealed](style_issealed.md) property on a parent [Style](style.md) is **true**. This is also reported by the [IsSealed](setterbase_issealed.md) property on an individual [Setter](setter.md). The system sets these properties to **true** when the runtime applies styles to UI elements and displays them in the UI. Attempting to change a sealed [Setter](setter.md) throws a runtime error.

You can use a [Setter](setter.md) to style an attached property. In this case the dependency property name is a qualified name in XAML that also names the attached property's defining type. For example, `<Setter Property="AutomationProperties.LiveSetting" Value="Polite" />` could be used to set the [AutomationProperties.LiveSetting](/uwp/api/windows.ui.xaml.automation.automationproperties.livesetting) attached property value within the style for any control or UI element.

> [!NOTE]
> The XAML parser also accepts dependency property names that include a qualifying class. For example the parser interprets either "Button.Background" or "Control.Background" as being a reference to the [Background](../windows.ui.xaml.controls/control_background.md) property in a style for a [Button](../windows.ui.xaml.controls/button.md). Qualifying by class isn't necessary though and results in potentially confusing markup. You might encounter or use qualified property-name usages if you're migrating XAML from other platforms.

### Identifying dependency properties

As noted, you can only use a [Setter](setter.md) to adjust a property through a style if the property in question is a dependency property. The UI properties where there's a scenario for applying a style are almost always implemented as dependency properties by the Windows Runtime, and settable properties that aren't a dependency property on UI elements are quite rare. If you want to verify that a Windows Runtime property is a dependency property, check the members lists for the type that originally defines the property. If a property is in fact a dependency property, the dependency property identifier will exist on that class also, and that identifier has the same name as the property itself but with the suffix **Property** added. This dependency property identifier is a static read-only property that's useful in some dependency property scenarios through code. For example you could use such an identifier value in code to adjust an existing Setter.Property value so long as the parent style isn't already sealed.

### Using a Setter for a custom property

For your own custom properties you should declare the property as a dependency property if you want to support styles, as well as for other scenarios such as data binding or animation. If you do so your custom property is also supported for styling on any [Style](style.md) with a [TargetType](style_targettype.md) that references your custom type. For more info, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties) or [TargetType](style_targettype.md).

## -examples

This example shows how to use Setter statements in a style for [TextBlock](../windows.ui.xaml.controls/textblock.md) elements.

```xaml
<StackPanel>
    <StackPanel.Resources>
        <!-- Create a Style for a TextBlock to specify that the
             Foreground equals Navy, FontSize equals 14, and
             VerticalAlignment equals Bottom. -->
        <Style TargetType="TextBlock" x:Key="TextBlockStyle">
            <Setter Property="Foreground" Value="Navy"/>
            <Setter Property="FontSize" Value="14"/>
            <Setter Property="VerticalAlignment" Value="Bottom"/>
        </Style>
    </StackPanel.Resources>
 
    <!-- Apply the TextBlockStyle to 2 different TextBlocks. -->
    <TextBlock Style="{StaticResource TextBlockStyle}" Text="Hello"/>
    <TextBlock Style="{StaticResource TextBlockStyle}" Text="World"/>
</StackPanel>

```

You can also apply setters to attached property values, by specifying the attached property name in the *AttachedPropertyProvider*.*PropertyName* form. For example, to use a [Setter](setter.md) for the attached property [Canvas.Left](/uwp/api/windows.ui.xaml.controls.canvas.left), use This XAML.

```xaml
<Setter Property="Canvas.Left" Value="100"/>
```

## -see-also
