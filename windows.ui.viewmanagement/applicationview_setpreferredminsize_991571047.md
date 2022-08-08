---
-api-id: M:Windows.UI.ViewManagement.ApplicationView.SetPreferredMinSize(Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax
public void SetPreferredMinSize(Windows.Foundation.Size minSize)
-->

# Windows.UI.ViewManagement.ApplicationView.SetPreferredMinSize

## -description
Sets the smallest size, in effective pixels, allowed for the app window.

## -parameters
### -param minSize
The smallest size allowed for the app window, or a [Size](../windows.foundation/size.md) whose height and width are both zero to use the system default minimum size.

## -remarks
To remove the preferred minimum size and use and system default minimum size instead, set the [Size](../windows.foundation/size.md) value to "0,0".

The smallest allowed minimum size is 192 x 48 effective pixels. The largest allowed minimum size is 500 x 500 effective pixels. If you set a value outside of these bounds, it is coerced to be within the allowed bounds. (To learn about effective pixels, see [Introduction to Windows app design](/windows/apps/design/basics).)

Setting the preferred minimum size affects only the view it was requested on; setting it on one view does not impact the preferred minimum size of the other views.

The preferred minimum size is not persisted after the app is closed. You should always set your preferred minimum size on your view before [Window.Activate](../windows.ui.xaml/window_activate_1797342875.md) is called to present it.

If you set a preferred minimum size that is larger than the current size, the app is resized so that the preferred minimum size is honored.



## -examples

## -see-also
[Window resizing sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ResizeAppView), [Introduction to Windows app design](/windows/apps/design/basics)
