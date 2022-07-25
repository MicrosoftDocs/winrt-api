---
-api-id: T:Windows.UI.Xaml.Setter
-api-type: winrt class
---

<!-- Class syntax.
public class Setter : Windows.UI.Xaml.SetterBase, Windows.UI.Xaml.ISetter, Windows.UI.Xaml.ISetter2
-->

# Windows.UI.Xaml.Setter

## -description
Applies a value to a property in a [Style](style.md) or a [VisualState](visualstate.md).



## -xaml-syntax
```xaml
<Setter .../>
```


## -remarks
Use Setter statements to set a property value within a [Style](style.md) or a [VisualState](visualstate.md).

The [Setter.Target](setter_target.md) property can be used in either a [Style](style.md) or a [VisualState](visualstate.md), but in different ways. When used in a [Style](style.md), the property that needs to be modified can be specified directly. When used in [VisualState](visualstate.md), the Target property must be given a [TargetPropertyPath](targetpropertypath.md) (dotted syntax with a target element and property explicitly specified).

The [Setter.Property](setter_property.md) property can be used only in a [Style](style.md) and not in a [VisualState](visualstate.md). Starting in Windows 10, you can use [Setter.Target](setter_target.md) everywhere instead of [Setter.Property](setter_property.md).

You must specify both the [Value](setter_value.md), and the [Target](setter_target.md) or [Property](setter_property.md), on a Setter. Otherwise, an exception is thrown (either a parse exception or runtime error, depending on whether the Setter is created in XAML or modified in code).

If you're accessing a Setter instance using code, you cannot change the value of any property of a Setter instance if the value of the [IsSealed](style_issealed.md) property on a parent [Style](style.md) is **true**. This is also reported by the [IsSealed](setterbase_issealed.md) property on an individual Setter. The system sets these properties to **true** when the runtime applies styles to UI elements and displays them in the UI. Attempting to change a sealed Setter throws a runtime error.

### Migration notes

+ Windows Presentation Foundation (WPF) and Microsoft Silverlight supported the ability to use a [Binding](../windows.ui.xaml.data/binding.md) expression to supply the [Value](setter_value.md) for a Setter in a [Style](style.md). The Windows Runtime doesn't support a [Binding](../windows.ui.xaml.data/binding.md) usage for [Setter.Value](../windows.ui.xaml.data/binding.md) (the [Binding](../windows.ui.xaml.data/binding.md) won't evaluate and the Setter has no effect, you won't get errors, but you won't get the desired result either). When you convert XAML styles from Windows Presentation Foundation (WPF) or Microsoft Silverlight XAML, replace any [Binding](../windows.ui.xaml.data/binding.md) expression usages with strings or objects that set values, or refactor the values as shared [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) values rather than [Binding](../windows.ui.xaml.data/binding.md)-obtained values.


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

This example shows how to use multiple Setter statements inside the [VisualState.Setters](visualstate_setters.md) property to apply discrete property value changes on various elements (without animations) when a [VisualState](visualstate.md) is applied.

```xaml

<Page>
    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup>
                <VisualState x:Name="NarrowState">
                    <VisualState.Setters>
                        <Setter Target="myPanel.Orientation" Value="Vertical"/>
                        <Setter Target="myPanel.Width" Value="380"/>
                        <Setter Target="myTextBlock.MaxLines" Value="3"/>
                    </VisualState.Setters>
                </VisualState>
            </VisualStateGroup>
        </VisualStateManager.VisualStateGroups>
        
        <StackPanel x:Name="myPanel" Orientation="Horizontal">
            <TextBlock x:Name="myTextBlock" MaxLines="5" Style="{ThemeResource BodyTextBlockStyle}"/>
        </StackPanel>
    </Grid>
</Page>

```

You can also apply setters to attached property values, by specifying the attached property name in the *AttachedPropertyProvider*.*PropertyName* form. For example, to use a [Setter](setter.md) for the attached property [Canvas.Left](/uwp/api/windows.ui.xaml.controls.canvas.left), use this XAML.

```xaml
<Setter Property="Canvas.Left" Value="100"/>
```

To update a value of an attached property using `Target`, place the attached property path inside parentheses. This example shows how to update the `RelativePanel.AlignRightWithPanel` value on an element with the name 'TitleTextBlock'. 

```xaml
<RelativePanel>
    <TextBlock x:Name="TitleTextBlock" Text="Title"/>
</RelativePanel>

...

<Setter Target="TitleTextBlock.(RelativePanel.AlignRightWithPanel)" Value="True"/>
```


## -see-also
[SetterBase](setterbase.md), [TargetPropertyPath](targetpropertypath.md), [VisualState.Setters](visualstate_setters.md), [Style](style.md), [Migrating  or  XAML/code to a ](/previous-versions/windows/apps/br229571(v=win.10))
