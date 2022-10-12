---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarCustomPenButton
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarCustomPenButton : Windows.UI.Xaml.Controls.InkToolbarPenButton, Windows.UI.Xaml.Controls.IInkToolbarCustomPenButton
-->

# Windows.UI.Xaml.Controls.InkToolbarCustomPenButton

## -description

Represents an [InkToolbar](inktoolbar.md) button that activates a pen for which the ink color palette and pen tip properties, such as shape, rotation, and size, are defined by the host app.

## -remarks

The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. Custom tools (InkToolbarCustomPenButton and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.

    > Feature selection is mutually exclusive.

+ A second group of "toggle" buttons containing the built-in stencil ([InkToolbarStencilButton](inktoolbarstencilbutton.md)) button (or the [InkToolbarRulerButton](inktoolbarrulerbutton.md) button). Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.

    > Features are not mutually exclusive and can be used concurrently with other active tools.


Built-in buttons can be displayed by default, or you can specify which should be displayed by your app. 

You cannot change the display order of the built-in buttons. The default display order is: [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md), [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md), [InkToolbarEraserButton](inktoolbareraserbutton.md), and [InkToolbarRulerButton](inktoolbarrulerbutton.md), with custom tool buttons appended to the radio button group and custom toggle buttons appended to the toggle button group.

You can use the built-in [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md) or you can specify a custom [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md) definition in the standard [InkToolbar](inktoolbar.md) pen declaration.

For custom configurations, your pen class must derive from [InkToolbarCustomPen](inktoolbarcustompen.md), and override the [CreateInkDrawingAttributesCore](inktoolbarcustompen_createinkdrawingattributescore_257776854.md) method. You can then set an instance of the derived class into [InkToolbarCustomPenButton.CustomPen](inktoolbarcustompenbutton_custompen.md) and provide the custom configuration UI elements.

## -examples
Here's an example of a custom pen that reuses the default [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md).

```xaml
<Page ...>
    <Page.Resources>
        <local:CalligraphicPen x:Key="CalligraphicPen"/>
        <BrushCollection x:Key="CalligraphicPenPalette">
            <SolidColorBrush>Crimson</Color>
            <SolidColorBrush>Black</Color>
            <SolidColorBrush>Green</Color>
            <SolidColorBrush>Blue</Color>
            <SolidColorBrush>White</Color>
        </BrushCollection>
        <Color x:Key="CallipgraphicPenDefaultColor">Crimson</Color>
    </Page.Resources>

    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    ...
    <InkToolbar TargetInkCanvas="{x:Bind m_inkCanvas}">
        <InkToolbarCustomPenButton CustomPen="{StaticResource CalligraphicPen}"
        MinStrokeWidth="1" MaxStrokeWidth="3" SelectedStrokeWidth="2"
        Palette="{StaticResource CalligraphicPenPalette}"
        SelectedColor="{StaticResource CallipgraphicPenDefaultColor}">
    
            <SymbolIcon Symbol="Placeholder"/>
            <InkToolbarCustomPenButton.ConfigurationContent>
                <InkToolbarPenConfigurationControl/>
            </InkToolbarCustomPenButton.ConfigurationContent>
        </InkToolbarCustomPenButton>
    </InkToolbar>
    ...
    <InkCanvas x:Name="m_inkCanvas"/>
    ... 
</Page>
```

Here's an example of a custom pen that customizes the default [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md).

```xaml
<Style TargetType="InkToolbarPenConfigurationControl">
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="InkToolbarPenConfigurationControl">
                <Grid MinWidth="272">
                    <Grid.Resources>
                        <Style x:Key="FlyoutStrokeWidthSelectorStyle" TargetType="Slider">
                            <Setter Property="IsThumbToolTipEnabled" Value="true"/>
                        </Style>
                    </Grid.Resources>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="auto"/>
                        <RowDefinition Height="auto"/>
                        <RowDefinition Height="auto"/>
                        <RowDefinition Height="auto"/>
                    </Grid.RowDefinitions>
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="auto"/>
                    </Grid.ColumnDefinitions>
                    <TextBlock x:Name="PenColorPaletteTitle" 
                        Grid.Row="0" Grid.Column="0" Padding="16,14,16,10" 
                        Style="{ThemeResource BodyTextBlockStyle}" Text="Colors"/>
                    <!-- Color palette -->
                    <GridView x:Name="PenColorPalette" 
                        Grid.Row="1" Grid.Column="0" Padding="12,0,12,0" 
                        Background="{TemplateBinding Background}" 
                        ItemsSource="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=PenButton.ColorPalette}" 
                        SelectedItem="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=PenButton.SelectedColor, Mode=TwoWay}">
                        ...
                    </GridView>
                    ...
                    <Slider x:Name="PenThicknessSlider" 
                        Grid.Row="3" Grid.Column="0" Width="240" 
                        Margin="16,0,16,0" HorizontalAlignment="Stretch" 
                        Minimum="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=PenButton.MinStrokeWidth}" 
                        Maximum="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=PenButton.MaxStrokeWidth}" 
                        Value="{Binding RelativeSource={RelativeSource TemplatedParent}, Path=PenButton.SelectedStrokeWidth, Mode=TwoWay}" 
                        Style="{StaticResource FlyoutStrokeWidthSelectorStyle}"/>
                </Grid>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style> 
```

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Windows.UI.Xaml.Controls classes](/uwp/api/windows.ui.xaml.controls), [InkToolbarPenButton](inktoolbarpenbutton.md), [InkToolbarCustomPen](inktoolbarcustompen.md), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)

## -ignore
<!--
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough)

### Reference
[Windows.UI.Xaml.Controls classes](windows_ui_xaml_controls_classes.md), [InkToolbarPenButton](inktoolbarpenbutton.md), [InkToolbarCustomPen](inktoolbarcustompen.md)

### Samples
* [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk)
* [Complex ink sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk)
* [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)
-->
