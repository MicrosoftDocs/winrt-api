---
-api-id: T:Windows.UI.Input.Inking.InkDrawingAttributesPencilProperties
-api-type: winrt class
---

<!-- Class syntax.
public class InkDrawingAttributesPencilProperties : Windows.UI.Input.Inking.IInkDrawingAttributesPencilProperties
-->

# Windows.UI.Input.Inking.InkDrawingAttributesPencilProperties

## -description
Provides a set of static [InkDrawingAttributes](inkdrawingattributes.md) properties for rendering a pencil stroke on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

Get an instance of this class by calling [InkDrawingAttributes.CreateForPencil](inkdrawingattributes_createforpencil.md) and accessing [InkDrawingAttributes.PencilProperties](inkdrawingattributes_pencilproperties.md).

## -remarks

## -examples
This example demonstrates how to render an ink stroke using pencil attributes.

First, we declare the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) in XAML.

In the code-behind, we define a `SetPencilInkStyle()` function to specify the pencil stroke attributes.
+ Create a specialized [InkDrawingAttributes](inkdrawingattributes.md) object through the [CreateForPencil](inkdrawingattributes_createforpencil.md) method.
+ Set some general stroke attributes, such as [Color](inkdrawingattributes_color.md) and [Size](inkdrawingattributes_size.md).
+ If [InkDrawingAttributesKind](inkdrawingattributeskind.md) is [Pencil](inkdrawingattributeskind.md), set the [Opacity](inkdrawingattributespencilproperties_opacity.md) attribute.
+ Call [UpdateDefaultDrawingAttributes](inkpresenter_updatedefaultdrawingattributes.md) to set the [InkDrawingAttributes](inkdrawingattributes.md) used by the [InkPresenter](inkpresenter.md) when rendering a new [InkStroke](inkstroke.md) on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.


```csharp
<InkCanvas x:Name="inkCanvas"/>

public sealed partial class Sample : Page
{
  public SetPencilInkStyle()
  {
    // Initialize the pencil stroke attributes.
    InkDrawingAttributes pencilAttributes = InkDrawingAttributes.CreateForPencil();
    pencilAttributes.Color = Windows.UI.Colors.Red;
    pencilAttributes.Size = new Windows.Foundation.Size(3, 3);
    Debug.Assert(attributes.Kind == InkDrawingAttributesKind.Pencil);
    pencilAttributes.PencilProperties.Opacity = 0.5f;
    // Update InkPresenter with the pencil attributes.
    inkCanvas.InkPresenter.UpdateDefaultDrawingAttributes(pencilAttributes);
  }
} 
```

```cpp
<InkCanvas x:Name = "inkCanvas" / >

public sealed partial class Sample : Page
{
  public SetPencilInkStyle()
  {
    // Initialize the pencil stroke attributes.
    InkDrawingAttributes^ pencilAttributes = InkDrawingAttributes::CreateForPencil();
    pencilAttributes->Color = Windows::UI::Colors::Red;
    pencilAttributes->Size = Windows::Foundation::Size(3, 3);
    assert(pencilAttributes->Kind == InkDrawingAttributesKind::Pencil);
    pencilAttributes->PencilProperties->Opacity = 0.5f;
    // Update the InkPresenter with the pencil attributes.
    inkCanvas->InkPresenter->UpdateDefaultDrawingAttributes(pencilAttributes);
  }
} 
```



## -see-also
[InkToolbar](../windows.ui.xaml.controls/inktoolbar.md), [InkToolbarPencilButton](../windows.ui.xaml.controls/inktoolbarpencilbutton.md)