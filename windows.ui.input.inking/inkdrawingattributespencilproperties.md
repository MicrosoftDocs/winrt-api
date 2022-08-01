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

Get an instance of this class by calling [InkDrawingAttributes.CreateForPencil](inkdrawingattributes_createforpencil_181700669.md) and accessing [InkDrawingAttributes.PencilProperties](inkdrawingattributes_pencilproperties.md).

## -remarks

By default, a pencil draws a soft-edged, textured, and semi-transparent stroke (useful for layered shading effects) with a Circle PenTip. The stroke color (darkness) is dependent on the pen pressure detected.

## -examples

This example demonstrates how to render an ink stroke using pencil attributes.

First, we declare the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) in XAML.

In the code-behind, we define a `SetPencilInkStyle()` function to specify the pencil stroke attributes.

+ Create a specialized [InkDrawingAttributes](inkdrawingattributes.md) object through the [CreateForPencil](inkdrawingattributes_createforpencil_181700669.md) method.
+ Set some general stroke attributes, such as [Color](inkdrawingattributes_color.md) and [Size](inkdrawingattributes_size.md).
+ If [InkDrawingAttributesKind](inkdrawingattributeskind.md) is [Pencil](inkdrawingattributeskind.md), set the [Opacity](inkdrawingattributespencilproperties_opacity.md) attribute.
+ Call [UpdateDefaultDrawingAttributes](inkpresenter_updatedefaultdrawingattributes_2083673367.md) to set the [InkDrawingAttributes](inkdrawingattributes.md) used by the [InkPresenter](inkpresenter.md) when rendering a new [InkStroke](inkstroke.md) on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

```xaml
<InkCanvas x:Name="inkCanvas"/>
```

```csharp
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

```cppwinrt
struct MainPage : MainPageT<MainPage>
{
    void SetPencilInkStyle()
    {
        // Initialize the pencil stroke attributes.
        auto pencilAttributes{ Windows::UI::Input::Inking::InkDrawingAttributes::CreateForPencil() };
        pencilAttributes.Color(Windows::UI::Colors::Red());
        pencilAttributes.Size({ 3, 3 });
        WINRT_ASSERT(pencilAttributes.Kind() == Windows::UI::Input::Inking::InkDrawingAttributesKind::Pencil);
        pencilAttributes.PencilProperties().Opacity(.5f);
        // Update the InkPresenter with the pencil attributes.
        m_inkCanvas.InkPresenter().UpdateDefaultDrawingAttributes(pencilAttributes);
    }
}
```

```cppcx
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

[InkToolbar](../windows.ui.xaml.controls/inktoolbar.md), [InkToolbarPencilButton](../windows.ui.xaml.controls/inktoolbarpencilbutton.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Get started: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink analysis sample (basic) (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-analysis-basic.zip), [Ink handwriting recognition sample (C#)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-handwriting-reco.zip), [Save and load ink strokes from an Ink Serialized Format (ISF) file](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store.zip), [Save and load ink strokes from the clipboard](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-store-clipboard.zip), [Ink toolbar location and orientation sample (basic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness.zip), [Ink toolbar location and orientation sample (dynamic)](https://github.com/MicrosoftDocs/windows-topic-specific-samples/archive/uwp-ink-toolbar-handedness-dynamic.zip), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample), [Inking sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple inking sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex inking sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink analysis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/InkAnalysis)


