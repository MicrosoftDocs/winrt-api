---
-api-id: P:Windows.UI.Xaml.FrameworkElement.FocusVisualPrimaryBrush
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Brush FocusVisualPrimaryBrush { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.FocusVisualPrimaryBrush

## -description

Gets or sets the brush used to draw the outer border of a `HighVisibility` or `Reveal` focus visual for a [FrameworkElement](frameworkelement.md).



## -property-value

The brush used to draw the outer border of a [HighVisibility](focusvisualkind.md) focus visual.

## -remarks

The default colors are dependent on the [RequestedTheme](application_requestedtheme.md). Typically, the outer (primary) color is solid black, or equivalent, and the inner (secondary) color is solid white, or equivalent.

[HighVisibility](focusvisualkind.md) and [Reveal](focusvisualkind.md) focus visuals are rendered with an outer (primary) and inner (secondary) border.

For more info, see [High Visibility Focus Visuals](/windows/uwp/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals) and [Reveal focus](/windows/uwp/design/style/reveal-focus).

## -examples

```xaml
<!-- Specify a color directly -->
<Button Content="Button"
        FocusVisualPrimaryBrush="DarkRed"
        FocusVisualSecondaryBrush="Pink"/>

<!-- Use theme resources -->
<Button Content="Button"
        FocusVisualPrimaryBrush="{ThemeResource SystemBaseHighColor}"
        FocusVisualSecondaryBrush="{ThemeResource SystemAccentColor}"/>
```

## -see-also

[High Visibility Focus Visuals](/windows/uwp/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals), [Reveal focus](/windows/uwp/design/style/reveal-focus), [FocusVisualSecondaryBrush](frameworkelement_focusvisualsecondarybrush.md), [FocusVisualPrimaryThickness](frameworkelement_focusvisualprimarythickness.md), [FocusVisualSecondaryThickness](frameworkelement_focusvisualsecondarythickness.md)
