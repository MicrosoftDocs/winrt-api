---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.LayoutInformation
-api-type: winrt class
---

<!-- Class syntax.
public class LayoutInformation : Windows.UI.Xaml.Controls.Primitives.ILayoutInformation
-->

# Windows.UI.Xaml.Controls.Primitives.LayoutInformation

## -description
Defines methods that provide additional information about the layout of an element.



## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | GetAvailableSize |

## -examples
The following example shows how to use [GetLayoutSlot](layoutinformation_getlayoutslot_399246493.md) and draw the bounding box for the [Rectangle](../windows.ui.xaml.shapes/rectangle.md).



[!code-xaml[1](../windows.ui.xaml.controls.primitives/code/GetLayoutInfo/csharp/Page.xaml#Snippet1)]

[!code-csharp[2](../windows.ui.xaml.controls.primitives/code/GetLayoutInfo/csharp/Page.xaml.cs#Snippet2)]

[!code-vb[2](../windows.ui.xaml.controls.primitives/code/GetLayoutInfo/vbnet/Page.xaml.vb#Snippet2)]


## -see-also
