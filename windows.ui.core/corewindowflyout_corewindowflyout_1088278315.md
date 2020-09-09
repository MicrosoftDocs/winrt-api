---
-api-id: M:Windows.UI.Core.CoreWindowFlyout.#ctor(Windows.Foundation.Point,System.String)
-api-type: winrt method
---

<!-- Method syntax
public CoreWindowFlyout(Windows.Foundation.Point position, System.String title)
-->

# Windows.UI.Core.CoreWindowFlyout.CoreWindowFlyout

## -description
Creates an instance of the [CoreWindowFlyout](corewindowflyout.md) class at the specified position with the supplied title.

## -parameters
### -param position
The pixel position on the screen where the flyout is to originate. The position provides the upper-leftmost corner of the flyout.

### -param title
The title of the flyout.

## -remarks
To use this object from a desktop app, create the object, and then use [the IInitializeWithWindow::Initialize method](/en-us/windows/desktop/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) to associate the object with a window handle.

## -examples

## -see-also
[CoreWindowFlyout(Point)](corewindowflyout_corewindowflyout_203539093.md)