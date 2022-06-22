---
-api-id: M:Windows.UI.Xaml.Controls.Image.GetAlphaMask
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.CompositionBrush GetAlphaMask()
-->

# Windows.UI.Xaml.Controls.Image.GetAlphaMask

## -description
Returns a mask that represents the alpha channel of an image as a [CompositionBrush](../windows.ui.composition/compositionbrush.md).


## -returns
A mask that represents the alpha channel of an image.

## -remarks
This method gets an alpha mask from an image as a [CompositionBrush](../windows.ui.composition/compositionbrush.md) that you can use as an input to composition shadows and effects. The alpha mask [CompositionBrush](../windows.ui.composition/compositionbrush.md) has the same alignment and stretch property values that the source XAML element applies to its rendered content so that you can use those values to correctly position shadows or effects relative to the XAML element.

### Version compatibility

The GetAlphaMask method is not available prior to Windows 10, version 1607. If your app’s 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you must design and test your app to account for this. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To avoid exceptions when your app runs on previous versions of Windows 10, do not call this method without first performing a runtime check. This example shows how to use the [ApiInformation](../windows.foundation.metadata/apiinformation.md) class to check for the presence of this method before you use it.

```csharp
if (ApiInformation.IsMethodPresent("Windows.UI.Xaml.Controls.Image", "GetAlphaMask"))
{
    var compositionBrush = image1.GetAlphaMask();
}

```



## -examples

## -see-also
