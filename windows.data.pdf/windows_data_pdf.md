---
-api-id: N:Windows.Data.Pdf
-api-type: winrt namespace
---

# Windows.Data.Pdf

## -description

Contains classes for converting a page in a Portable Document Format (PDF) document to an image file.

## -remarks

We recommend using the following API for these types of apps:

+ Use the [RenderToStreamAsync](pdfpage_rendertostreamasync.md) method if your UWP app:
  + Uses JavaScript and HTML.
  + Uses C# and Extensible Application Markup Language (XAML), and you're not comfortable writing an interop layer over the corresponding Component Object Model (COM) API [RenderPageToSurface](http://msdn.microsoft.com/library/d4688c23-0122-40a7-908e-793c3f03fb37) or [RenderPageToDeviceContext](http://msdn.microsoft.com/library/5ec97d21-3160-48e7-9486-a8ea9ca9df92) by using C++.

+ Use the corresponding Component Object Model (COM) API **RenderPageToSurface** or **RenderPageToDeviceContext** if your UWP app:
  + Uses C++ and XAML.
  + Uses C++ and Microsoft DirectX.
  + Uses C# and XAML, and you are comfortable writing an interop layer over these corresponding Component Object Model (COM) API by using C++.
  + Needs to support a zoom factor of greater than 400%.

## -examples

## -see-also

[PDF document sample (Windows 10)](http://go.microsoft.com/fwlink/?LinkID=703785)
