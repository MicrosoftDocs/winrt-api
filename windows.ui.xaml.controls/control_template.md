---
-api-id: P:Windows.UI.Xaml.Controls.Control.Template
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ControlTemplate Template { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.Template

## -description
Gets or sets a control template. The control template defines the visual appearance of a control in UI, and is defined in XAML markup.



## -xaml-syntax
```xaml
<control Template="{StaticResource templateResourceKey}"/>
- or -
<Style TargetType="controlTypeName">
  <Setter Property="Template">
    <Setter.Value>
      <ControlTemplate TargetType="controlTypeName">
        templateRoot
      </ControlTemplate>
    </Setter.Value>
  </Setter>
</Style>
```


## -xaml-values
<dl><dt>templateResourceKey</dt><dd>templateResourceKeyThe key that identifies the template being requested. The key refers to an existing resource in a ResourceDictionary.Property element syntax to define an inline template is technically possible, but not recommended for most template scenarios.</dd>
<dt>controlTypeName</dt><dd>controlTypeNameThe string form of the Type for a control.</dd>
<dt>templateRoot</dt><dd>templateRootA single object element (must be FrameworkElement derived) that defines the root element of a template. For more info on what can be used as a template root see Quickstart: Control templates.</dd>
</dl>
## -property-value
The template that defines the appearance of the [Control](control.md). The [ControlTemplate](controltemplate.md) must have exactly one root element as its content.

## -remarks
The second XAML syntax shown above is a [Setter](../windows.ui.xaml/setter.md) syntax as part of a [Style](../windows.ui.xaml/style.md). This is how a Template value for a [Control](control.md) is defined in almost all cases.

[TargetType](controltemplate_targettype.md) is a required attribute on all [ControlTemplate](controltemplate.md) elements used as a Template value. The value should match the [TargetType](../windows.ui.xaml/style_targettype.md) property for the [Style](../windows.ui.xaml/style.md) that contains the [Setter](../windows.ui.xaml/setter.md) for Template, if you are using a style-setter syntax.

The [ControlTemplate](controltemplate.md) specifies the appearance of a [Control](control.md); if a [Control](control.md) does not have a [ControlTemplate](controltemplate.md), the [Control](control.md) will have no visible presence in your app. The control author defines the default control template, and the app author can re-template the [ControlTemplate](controltemplate.md) XAML to redefine the visual tree of the control.

[Control](control.md) templates are typically set in Extensible Application Markup Language (XAML) as part of a control-specific implicit style. In this case, a [Property](../windows.ui.xaml/setter_property.md) value in the [Setter](../windows.ui.xaml/setter.md) is set as the string "Template", and the [Setter.Value](../windows.ui.xaml/setter_value.md) value is set as a property element, which contains a [ControlTemplate](controltemplate.md) object element. For example, this is the [Style](../windows.ui.xaml/style.md) that defines a Template value for a [ScrollViewer](scrollviewer.md). This is an example of an implicit style, where the [Style](../windows.ui.xaml/style.md) can be in a [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md) but doesn't need an [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute).



```xaml

<ResourceDictionary>
  <Style TargetType="ScrollViewer">
  ...
    <Setter Property="Template">
      <Setter.Value>
        <ControlTemplate TargetType="ScrollViewer">
          <!--visual root of template for a ScrollViewer-->
        </ControlTemplate>
      </Setter.Value>
    </Setter>
  </Style>
  ...
</ResourceDictionary>
```



### Styles and templates

You can use a [Setter](../windows.ui.xaml/setter.md) in a [Style](../windows.ui.xaml/style.md) to apply values to any dependency property. But it's the [Setter](../windows.ui.xaml/setter.md) for the Template property of a [Control](control.md)-derived class that constitutes the majority of the XAML markup in a typical [Style](../windows.ui.xaml/style.md). When a [Style](../windows.ui.xaml/style.md) is used to define a control template, the [TargetType](../windows.ui.xaml/style_targettype.md) of the [Style](../windows.ui.xaml/style.md) element and the [TargetType](controltemplate_targettype.md) of the [ControlTemplate](controltemplate.md) element for its Control.Template setter should always use the same value. The Template setter defines the basic templated UI definition for a control where that template is applied. It also contains the visual states for a control, and other state-based UI definitions such as default theme transitions. For a complex control such as [ListBox](listbox.md), the default template [Style](../windows.ui.xaml/style.md) and the [ControlTemplate](controltemplate.md) within can have hundreds of lines of XAML. For more info on the role of Template in control templating scenarios, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).

### Implicit styles

You can define styles such that a [Style](../windows.ui.xaml/style.md) is used implicitly by all objects of the same [TargetType](../windows.ui.xaml/style_targettype.md), without requiring each instance of such an object to specifically reference the [Style](../windows.ui.xaml/style.md) as a [FrameworkElement.Style](../windows.ui.xaml/frameworkelement_style.md) value. When a `<Style>` resource is declared in a [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md) without an [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute), the **x:Key** value uses the value of the [TargetType](../windows.ui.xaml/style_targettype.md) property. If you set the style implicitly, the style is applied only to the types that match the [TargetType](../windows.ui.xaml/style_targettype.md) exactly and not to elements derived from the [TargetType](../windows.ui.xaml/style_targettype.md) value. For example, if you create a style implicitly for all the [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) controls in your application, and your application has [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) and [CheckBox](checkbox.md) controls ([CheckBox](checkbox.md) derives from [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md)), the "ToggleButton" implicit style is applied only to the [ToggleButton](../windows.ui.xaml.controls.primitives/togglebutton.md) controls.

## -examples
This example shows a more complete control template defined as a [Style](../windows.ui.xaml/style.md) and [Setter](../windows.ui.xaml/setter.md) with [Setter.Property](../windows.ui.xaml/setter_property.md) value of "Template". This is a named style for a [RadioButton](radiobutton.md) control. It includes the template elements that are normally part of a functional control template, such as a [VisualStateManager.VisualStateGroups](/dotnet/api/system.windows.visualstatemanager.visualstategroups) attached property element attached to the root element of the template, and [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) values assigned to each of the prominent control parts.

```xaml

    <Style x:Key="TextRadioButtonStyle" TargetType="RadioButton"> 
        <Setter Property="MinWidth" Value="0"/> 
        <Setter Property="MinHeight" Value="0"/> 
        <Setter Property="Template"> 
            <Setter.Value> 
                <ControlTemplate TargetType="RadioButton"> 
                    <Grid Background="Transparent"> 
                        <TextBlock 
                            x:Name="Text" 
                            Text="{TemplateBinding Content}" 
                            Margin="3,-7,3,10" 
                            TextWrapping="NoWrap" 
                            Style="{StaticResource SubheaderTextStyle}"/> 
                        <Rectangle 
                            x:Name="FocusVisualWhite" 
                            IsHitTestVisible="False" 
                            Stroke="{StaticResource FocusVisualWhiteStrokeThemeBrush}" 
                            StrokeEndLineCap="Square" 
                            StrokeDashArray="1,1" 
                            Opacity="0" 
                            StrokeDashOffset="1.5"/> 
                        <Rectangle 
                            x:Name="FocusVisualBlack" 
                            IsHitTestVisible="False" 
                            Stroke="{StaticResource FocusVisualBlackStrokeThemeBrush}" 
                            StrokeEndLineCap="Square" 
                            StrokeDashArray="1,1" 
                            Opacity="0" 
                            StrokeDashOffset="0.5"/> 
 
                        <VisualStateManager.VisualStateGroups> 
                            <VisualStateGroup x:Name="CommonStates"> 
                                <VisualState x:Name="Normal"/> 
                                <VisualState x:Name="PointerOver"> 
                                    <Storyboard> 
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="Text" Storyboard.TargetProperty="Foreground"> 
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource ApplicationPointerOverForegroundThemeBrush}"/> 
                                        </ObjectAnimationUsingKeyFrames> 
                                    </Storyboard> 
                                </VisualState> 
                                <VisualState x:Name="Pressed"> 

                                    <Storyboard> 
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="Text" Storyboard.TargetProperty="Foreground"> 
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource ApplicationPressedForegroundThemeBrush}"/> 
                                        </ObjectAnimationUsingKeyFrames> 
                                    </Storyboard> 
                                </VisualState> 
                                <VisualState x:Name="Disabled"> 
                                    <Storyboard> 
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="Text" Storyboard.TargetProperty="Foreground"> 
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource ButtonDisabledForegroundThemeBrush}"/> 
                                        </ObjectAnimationUsingKeyFrames> 
                                    </Storyboard> 
                                </VisualState> 
                            </VisualStateGroup> 
                            <VisualStateGroup x:Name="FocusStates"> 
                                <VisualState x:Name="Focused"> 
                                    <Storyboard> 
                                        <DoubleAnimation Duration="0" To="1" Storyboard.TargetName="FocusVisualWhite" Storyboard.TargetProperty="Opacity"/> 
                                        <DoubleAnimation Duration="0" To="1" Storyboard.TargetName="FocusVisualBlack" Storyboard.TargetProperty="Opacity"/> 
                                    </Storyboard> 
                                </VisualState> 
                                <VisualState x:Name="Unfocused"/> 
                            </VisualStateGroup> 
                            <VisualStateGroup x:Name="CheckStates"> 
                                <VisualState x:Name="Checked"/> 
                                <VisualState x:Name="Unchecked"> 
                                    <Storyboard> 
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="Text" Storyboard.TargetProperty="Foreground"> 
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{StaticResource ApplicationSecondaryForegroundThemeBrush}"/> 
                                        </ObjectAnimationUsingKeyFrames> 
                                    </Storyboard> 
                                </VisualState> 
                                <VisualState x:Name="Indeterminate"/> 
                            </VisualStateGroup> 
                        </VisualStateManager.VisualStateGroups> 
                    </Grid> 
                </ControlTemplate> 
            </Setter.Value> 
        </Setter> 
    </Style> 

```



## -see-also
[Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [OnApplyTemplate](../windows.ui.xaml/frameworkelement_onapplytemplate_1955470198.md), [GetTemplateChild](control_gettemplatechild_501346084.md), [ControlTemplate](controltemplate.md), [Style](../windows.ui.xaml/style.md)
