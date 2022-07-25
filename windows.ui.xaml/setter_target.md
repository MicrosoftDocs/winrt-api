---
-api-id: P:Windows.UI.Xaml.Setter.Target
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.TargetPropertyPath Target { get;  set; }
-->

# Windows.UI.Xaml.Setter.Target

## -description
Gets or sets the path of a property on a target element to apply the [Value](setter_value.md) to.



## -property-value
The path of a property on a target element to apply the [Value](setter_value.md) to.

## -remarks

The [Setter.Target](setter_target.md) property can be used in either a [Style](style.md) or a [VisualState](visualstate.md), but in different ways. 

- When used in a [Style](style.md), the property that needs to be modified can be specified directly.
- When used in [VisualState](visualstate.md), the Target property must be given a [TargetPropertyPath](targetpropertypath.md) (dotted syntax with a target element and property explicitly specified).


## -examples

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

To update a value of an attached property, place the attached property path inside parentheses. This example shows how to update the `RelativePanel.AlignRightWithPanel` value on an element with the name 'TitleTextBlock'. 

```xaml
<RelativePanel>
    <TextBlock x:Name="TitleTextBlock" Text="Title"/>
</RelativePanel>

...

<Setter Target="TitleTextBlock.(RelativePanel.AlignRightWithPanel)" Value="True"/>
```

## -see-also
