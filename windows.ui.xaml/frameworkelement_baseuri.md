---
-api-id: P:Windows.UI.Xaml.FrameworkElement.BaseUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri BaseUri { get; }
-->

# Windows.UI.Xaml.FrameworkElement.BaseUri

## -description
Gets a Uniform Resource Identifier (URI) that represents the base Uniform Resource Identifier (URI) for an XAML-constructed object at XAML load time. This property is useful for Uniform Resource Identifier (URI) resolution at run time.



## -property-value
The base Uniform Resource Identifier (URI) for an object at XAML load time.

## -remarks
The XAML parser can evaluate references to resources based on the context of the object in a page, and can thus evaluate what appear to be partial paths in a Uniform Resource Identifier (URI) property. For run-time code, the definition rules for the Uniform Resource Identifier (URI) types don't permit partial paths. At run time, you can use BaseUri from the scope of an object that was created by parsing a XAML page in order to get the "path" part of a Uniform Resource Identifier (URI), and then complete the Uniform Resource Identifier (URI) with a particular resource reference.

### Notes for previous versions

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 454698-->
> **Windows 8**
> In Windows 8, the **URI** returned by BaseUri from style or template parts could return values that represented a project default rather than a value that was specific for the XAML file that created an object. The BaseUri behavior has been corrected starting with Windows 8.1. But if you relied on the previous behavior of BaseUri and changed your XAML compositions or resource lookups because of it, you might want to examine the areas of your code that make BaseUri calls. Verify that the combined Uniform Resource Identifier (URI) you use for finding resources or localization info work as expected when your app is recompiled for Windows 8.1. Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

## -examples
This example uses BaseUri in an event handler that resets an image source to a backup/default. BaseUri is used for the "path" part of a new Uniform Resource Identifier (URI) that is used for a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) constructor call, the rest of the Uniform Resource Identifier (URI) points to an image file that the app has in its resources. To see this code in context, see the [CameraCaptureUI sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/CameraCaptureUI%20Sample).



[!code-cpp[FEBaseUri](../windows.ui.xaml/code/BaseElementEvents/cpp/PageWithAppBar.xaml.cpp#SnippetFEBaseUri)]

[!code-csharp[FEBaseUri](../windows.ui.xaml/code/BaseElementEvents/csharp/PageWithAppBar.xaml.cs#SnippetFEBaseUri)]

[!code-vb[FEBaseUri](../windows.ui.xaml/code/BaseElementEvents/vbnet/PageWithAppBar.xaml.vb#SnippetFEBaseUri)]

## -see-also
