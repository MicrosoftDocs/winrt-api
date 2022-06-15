---
-api-id: T:Windows.UI.Xaml.Media.Imaging.BitmapCreateOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.Imaging.BitmapCreateOptions : uint
-->

# BitmapCreateOptions

## -description
Specifies initialization options for a bitmap image.

Equivalent **WinUI 2 API for UWP**: [BitmapCreateOptions](/windows/winui/api/microsoft.ui.xaml.media.imaging.bitmapcreateoptions) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields
### -field None:0
No options are specified.

### -field IgnoreImageCache:8
Loads images without using an existing image cache. This option should be selected only when images in a cache need to be refreshed.


## -remarks

This enumeration is used by the [BitmapImage.CreateOptions](bitmapimage_createoptions.md) property. For more info, see [CreateOptions](bitmapimage_createoptions.md).

## -examples

## -see-also
