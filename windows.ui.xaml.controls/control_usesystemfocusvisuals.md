---
-api-id: P:Windows.UI.Xaml.Controls.Control.UseSystemFocusVisuals
-api-type: winrt property
---

<!-- Property syntax
public bool UseSystemFocusVisuals { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.UseSystemFocusVisuals

## -description
Gets or sets a value that indicates whether the control uses focus visuals that are drawn by the system or those defined in the control template.

## -property-value
**true** if the control uses focus visuals drawn by the system; **false** if the control uses focus visuals defined in the [ControlTemplate](controltemplate.md). The default is **false**; see Remarks.

## -remarks
This property is **false** by default so that a custom [ControlTemplate](controltemplate.md) that defines its own focus visuals works as expected. However, all XAML framework controls set this property to **true** in their [ControlTemplate](controltemplate.md) and use system drawn focus visuals.

To define custom focus visuals for a control, you need to provide a custom [ControlTemplate](controltemplate.md). 
In the [ControlTemplate](controltemplate.md), do the following:

+ If you're modifying a default [ControlTemplate](controltemplate.md), be sure to set the UseSystemFocusVisuals property to **false** to turn off the system focus visuals. When set to **false**, the focus states in the [VisualStateManager](../windows.ui.xaml/visualstatemanager.md) are called.
+ Define a [VisualStateGroup](../windows.ui.xaml/visualstategroup.md) for `FocusStates`.
+ In the `FocusStates` group, define [VisualState](../windows.ui.xaml/visualstate.md)s for `Focused`, `Unfocused`, and `PointerFocused`.
+ Define the focus visuals.


## -examples
This example shows a [ControlTemplate](controltemplate.md) that defines custom focus visuals for a [Button](button.md).

Some elements of the control template aren't shown to make the relevant parts more clear.

```xaml
<Style TargetType="Button">
 
<!-- Set UseSystemFocusVisuals to false. -->
    <Setter Property="UseSystemFocusVisuals" Value="False"/> 
     ...

    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="Button">
                <Grid>
                    <VisualStateManager.VisualStateGroups>
                        <VisualStateGroup x:Name="CommonStates">
                            <VisualState x:Name="Normal"/>
                            <VisualState x:Name="PointerOver">
                             ...

                            </VisualState>
                        </VisualStateGroup>

<!-- Add VisualStateGroup for FocusStates. -->
                        <VisualStateGroup x:Name="FocusStates">
                            <VisualState x:Name="Focused">
                                <Storyboard>
                                    <DoubleAnimation Storyboard.TargetName="FocusVisualWhite"
                                                     Storyboard.TargetProperty="Opacity"
                                                     To="1"
                                                     Duration="0"/>
                                    <DoubleAnimation Storyboard.TargetName="FocusVisualBlack"
                                                     Storyboard.TargetProperty="Opacity"
                                                     To="1"
                                                     Duration="0"/>
                                </Storyboard>
                            </VisualState>
                            <VisualState x:Name="Unfocused"/>
                            <VisualState x:Name="PointerFocused"/>
                        </VisualStateGroup>

                    </VisualStateManager.VisualStateGroups>
                    <Border x:Name="Border"
                            Background="{TemplateBinding Background}"
                            BorderBrush="{TemplateBinding BorderBrush}"
                            BorderThickness="{TemplateBinding BorderThickness}"
                            Margin="3">
                        <ContentPresenter x:Name="ContentPresenter"
                                          Content="{TemplateBinding Content}"
                                          ContentTransitions="{TemplateBinding ContentTransitions}"
                                          ContentTemplate="{TemplateBinding ContentTemplate}"
                                          Margin="{TemplateBinding Padding}"
                                          HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                                          VerticalAlignment="{TemplateBinding VerticalContentAlignment}" 
                                          AutomationProperties.AccessibilityView="Raw"/>
                    </Border>

<!-- Add elements for focus visuals. -->
                    <Rectangle x:Name="FocusVisualWhite"
                               IsHitTestVisible="False"
                               Stroke="{ThemeResource FocusVisualWhiteStrokeThemeBrush}"
                               StrokeEndLineCap="Square"
                               StrokeDashArray="1,1"
                               Opacity="0"
                               StrokeDashOffset="1.5"/>
                    <Rectangle x:Name="FocusVisualBlack"
                               IsHitTestVisible="False"
                               Stroke="{ThemeResource FocusVisualBlackStrokeThemeBrush}"
                               StrokeEndLineCap="Square"
                               StrokeDashArray="1,1"
                               Opacity="0"
                               StrokeDashOffset="0.5"/>
                </Grid>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```



## -see-also
[FocusState](control_focusstate.md), [Control.IsTemplateFocusTarget](/uwp/api/windows.ui.xaml.controls.control.istemplatefocustarget)
