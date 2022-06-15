---
-api-id: M:Windows.UI.Xaml.Hosting.ElementCompositionPreview.SetElementChildVisual(Windows.UI.Xaml.UIElement,Windows.UI.Composition.Visual)
-api-type: winrt method
---

<!-- Method syntax
public void SetElementChildVisual(Windows.UI.Xaml.UIElement element, Windows.UI.Composition.Visual visual)
-->

# Windows.UI.Xaml.Hosting.ElementCompositionPreview.SetElementChildVisual

## -description
Sets a custom [Windows.UI.Composition.Visual](../windows.ui.composition/visual.md) as the last child of the element’s visual tree.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Hosting.ElementCompositionPreview.SetElementChildVisual](/windows/winui/api/microsoft.ui.xaml.hosting.elementcompositionpreview.setelementchildvisual) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters
### -param element
The element to add the child [Visual](../windows.ui.composition/visual.md) to.

### -param visual
The [Visual](../windows.ui.composition/visual.md) to add to the element's visual tree.

## -remarks
The [Visual](../windows.ui.composition/visual.md) is added as the last child, therefore on top of the rest of the element in z-order.

## -examples

## -see-also
