---
-api-id: M:Windows.UI.Xaml.UIElement.RegisterAsScrollPort(Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax.
public void UIElement.RegisterAsScrollPort(UIElement element)
-->

# Windows.UI.Xaml.UIElement.RegisterAsScrollPort

## -description
Registers an element as representing a scrollable viewport.

## -parameters
### -param element

The element to register as a scrollable viewport.

## -remarks
This method is intended for use by custom controls that do not use the platform's native controls to display a scrollable area containing other XAML elements. For example, a custom scrolling control that relies on [InteractionTracker](../windows.ui.composition.interactions/interactiontracker.md). This method informs the framework that the element's applied clip (either due to layout or an explicitly assigned [Clip](uielement_clip.md)) is acting as a viewport and should receive special consideration such as when rendering focus visuals. By default, the focus visual is fully rendered around the outside of the focused element taking into account all clips. When an element is only partially visible within a viewport the framework needs to disambiguate which clip in the element's ancestor chain represents the viewport. The framework uses this knowledge to correctly apply the viewport clip to the rendered focus visual. 

## -see-also
* [UseSystemFocusVisuals](../windows.ui.xaml.controls/control_usesystemfocusvisuals.md)
* [InteractionTracker](../windows.ui.composition.interactions/interactiontracker.md)

## -examples

