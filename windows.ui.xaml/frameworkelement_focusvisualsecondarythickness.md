---
-api-id: P:Windows.UI.Xaml.FrameworkElement.FocusVisualSecondaryThickness
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness FocusVisualSecondaryThickness { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.FocusVisualSecondaryThickness

## -description

Gets or sets the thickness of the inner border of a `HighVisibility` or `Reveal` focus visual for a [FrameworkElement](frameworkelement.md).

## -property-value

The thickness of the inner border of a [HighVisibility](focusvisualkind.md) focus visual. The default value is 1.

## -remarks

[HighVisibility](focusvisualkind.md) and [Reveal](focusvisualkind.md) focus visuals are rendered with an outer (primary) and inner (secondary) border.

For more info, see [High Visibility Focus Visuals](/windows/uwp/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals) and [Reveal focus](/windows/uwp/design/style/reveal-focus).

## -examples

```xaml
<Button Content="Button"
        FocusVisualSecondaryThickness="1"/>
```

## -see-also

[High Visibility Focus Visuals](/windows/uwp/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals), [Reveal focus](/windows/uwp/design/style/reveal-focus), [FocusVisualPrimaryBrush](frameworkelement_focusvisualprimarybrush.md), [FocusVisualSecondaryBrush](frameworkelement_focusvisualsecondarybrush.md), [FocusVisualPrimaryThickness](frameworkelement_focusvisualprimarythickness.md)
