---
-api-id: P:Windows.UI.Xaml.VisualState.Setters
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.SetterBaseCollection Setters { get; }
-->

# Windows.UI.Xaml.VisualState.Setters

## -description
Gets a collection of [Setter](setter.md) objects that define discrete property values that control the appearance of [UIElement](uielement.md)s when this [VisualState](visualstate.md) is applied.



## -property-value
A collection of [Setter](setter.md) objects. The default is an empty collection.

## -remarks
Use this property to make discrete property value changes on multiple UI elements at one time when a [VisualState](visualstate.md) is applied.

## -examples
The following example shows how to use multiple [Setter](setter.md) statements inside the VisualState.Setters property to apply multiple discrete property value changes on 2 different elements when a [VisualState](visualstate.md) is applied.

```xaml
<Page>
    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup>
                <VisualState x:Name="NarrowState">
                    <VisualState.Setters>
                        <Setter Target="myPanel.Orientation" Value="Vertical" />
                        <Setter Target="myPanel.Width" Value="380" />
                        <Setter Target="myTextBlock.MaxLines" Value="3" />
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



## -see-also
