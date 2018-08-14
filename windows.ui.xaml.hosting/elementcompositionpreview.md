---
-api-id: T:Windows.UI.Xaml.Hosting.ElementCompositionPreview
-api-type: winrt class
---

<!-- Class syntax.
public class ElementCompositionPreview : Windows.UI.Xaml.Hosting.IElementCompositionPreview
-->

# Windows.UI.Xaml.Hosting.ElementCompositionPreview

## -description
Enables access to composition visual objects that back XAML elements in the XAML composition tree.

## -remarks
[ElementCompositionPreview](elementcompositionpreview.md) allows access to the [Windows.UI.Composition.Visual](../windows.ui.composition/visual.md) object backing a XAML element with the [GetElementVisual](elementcompositionpreview_getelementvisual_1511147715.md) method. Once the backing object has been retrieved it can be manipulated using the [Windows.UI.Composition](../windows.ui.composition/windows_ui_composition.md) namespace. This allows properties of the object to be changed, like the orientation, or additional objects to be added to the XAML composition tree.

## -examples

## -see-also
