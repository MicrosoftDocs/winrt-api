---
-api-id: M:Windows.ApplicationModel.Contacts.PinnedContactManager.IsPinSurfaceSupported(Windows.ApplicationModel.Contacts.PinnedContactSurface)
-api-type: winrt method
---

<!-- Method syntax.
public bool PinnedContactManager.IsPinSurfaceSupported(PinnedContactSurface surface)
-->

# Windows.ApplicationModel.Contacts.PinnedContactManager.IsPinSurfaceSupported


## -description

Indicates whether the specified location in the Windows UI supports contact pinning.

## -parameters

### -param surface

A [pinnedContactSurface](pinnedcontactsurface.md) value that specifies a pinning location in the Windows UI. This property determines whether pinning is supported in that location.

## -returns

`true` if the location in the Windows UI supports contact pinning; otherwise, `false`.

## -remarks

This property can be useful if your app handles the [Window.SizeChanged](./windows.ui.xaml/window_sizechanged.md) event. That event is raised when the view changes between monitors. In the [WindowSizeChanged](./windows.ui.xaml/windowsizechangedeventhandler.md) event handler, your could use this property to determine whether the new monitor supports pinning.

## -see-also

## -examples

## -capabilities

contactsSystem

