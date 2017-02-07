---
-api-id: T:Windows.UI.Xaml.Controls.ContentPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class ContentPresenter : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IContentPresenter, Windows.UI.Xaml.Controls.IContentPresenter2, Windows.UI.Xaml.Controls.IContentPresenter3, Windows.UI.Xaml.Controls.IContentPresenter4, Windows.UI.Xaml.Controls.IContentPresenterOverrides
-->

# Windows.UI.Xaml.Controls.ContentPresenter

## -description
Displays the content of a [ContentControl](contentcontrol.md). Can also provide content presentation for non-controls. Provides a base class for specialized presenters such as [ScrollContentPresenter](scrollcontentpresenter.md).

## -xaml-syntax
```xaml
<ContentPresenter .../>
```


## -remarks
Typically, you use the [ContentPresenter](contentpresenter.md) directly within the [ControlTemplate](controltemplate.md) of a [ContentControl](contentcontrol.md) to mark where the content to be presented appears.

A [ContentPresenter](contentpresenter.md) is often used to apply characteristics to text content, which are set into a **Content** property using only a string for the text (or some indirect equivalent such as a [Binding](../windows.ui.xaml.data/binding.md) or a RESX resource). For this reason the properties of a [ContentPresenter](contentpresenter.md) are similar to the properties of the [TextElement](../windows.ui.xaml.documents/textelement.md) class. (The [TextElement](../windows.ui.xaml.documents/textelement.md) class is a base class for several elements that aren't controls but are used to format the text that might appear in a control or layout container.)

> [!TIP]
> Starting in Windows 10, [ContentPresenter](contentpresenter.md) defines new border properties that let you draw a border around the [ContentPresenter](contentpresenter.md) without using an additional [Border](border.md) element. The new properties are [ContentPresenter.BorderBrush](contentpresenter_borderbrush.md), [ContentPresenter.BorderThickness](contentpresenter_borderthickness.md), [ContentPresenter.CornerRadius](contentpresenter_cornerradius.md), and [ContentPresenter.Padding](contentpresenter_padding.md).



```xaml
<ContentPresenter BorderBrush="Red" BorderThickness="2" CornerRadius="10" Padding="12">
</ContentPresenter>
```



A [ContentPresenter](contentpresenter.md) can use a logic class to influence which template to use for templated data content at run-time. For more info, see the [ContentTemplateSelector](contentcontrol_contenttemplateselector.md) property.

If the [ContentPresenter](contentpresenter.md) is in the [ControlTemplate](controltemplate.md) of a [ContentControl](contentcontrol.md), the [ContentPresenter](contentpresenter.md) behavior will implicitly bind to the [ContentTemplate](contentcontrol_contenttemplate.md) and [Content](contentcontrol_content.md) properties of the templated [ContentControl](contentcontrol.md).

### **ContentPresenter** derived classes

[ContentPresenter](contentpresenter.md) is the parent class for these classes:
+ [ScrollContentPresenter](scrollcontentpresenter.md)
+ [GridViewItemPresenter](../windows.ui.xaml.controls.primitives/gridviewitempresenter.md)
+ [ListViewItemPresenter](../windows.ui.xaml.controls.primitives/listviewitempresenter.md)


## -examples
This example shows a typical placement of a [ContentPresenter](contentpresenter.md) object element as part of the [ControlTemplate](controltemplate.md) for a [ContentControl](contentcontrol.md). This example is a simplification of the Windows Runtime XAML default style for [HyperlinkButton](hyperlinkbutton.md). One example [VisualState](../windows.ui.xaml/visualstate.md) is included to show how the [ContentPresenter](contentpresenter.md) properties are changed based on state. The [ContentPresenter](contentpresenter.md) is within a [Border](border.md) in the composition; it's common for content controls to have the [ContentPresenter](contentpresenter.md) nested within one other parent element, and that parent element often template-binds some of the control properties that a [ContentPresenter](contentpresenter.md) doesn't have. Note also how the [ContentPresenter](contentpresenter.md) uses [{TemplateBinding} markup extension](http://msdn.microsoft.com/library/fde71086-9d42-4287-89ed-8fbfcdf169dc) to bind [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) / [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) values to the control properties of where the template is applied.

```xaml
    <!-- Default style for Windows.UI.Xaml.Controls.Primitives.HyperlinkButton -->
    <Style TargetType="HyperlinkButton">
...
        <Setter Property="HorizontalAlignment" Value="Left"/>
        <Setter Property="VerticalAlignment" Value="Center"/>
...
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="HyperlinkButton">
                    <Grid>
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="CommonStates">
...
                                <VisualState x:Name="Disabled">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="ContentPresenter"
                                                                       Storyboard.TargetProperty="Foreground">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="{ThemeResource HyperlinkDisabledThemeBrush}"/>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
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
                                              HorizontalAlignment="{TemplateBinding HorizontalContentAlignment}"
                                              VerticalAlignment="{TemplateBinding VerticalContentAlignment}" 
                    />
                        </Border>
                        <!--focus visuals omitted-->
                    </Grid>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
```



## -see-also
[ContentControl](contentcontrol.md), [FrameworkElement](../windows.ui.xaml/frameworkelement.md), [ItemsPresenter](itemspresenter.md), [Quickstart: Control templates](http://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77)