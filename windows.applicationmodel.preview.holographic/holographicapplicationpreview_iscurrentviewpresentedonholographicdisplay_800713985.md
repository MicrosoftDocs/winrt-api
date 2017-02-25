---
-api-id: M:Windows.ApplicationModel.Preview.Holographic.HolographicApplicationPreview.IsCurrentViewPresentedOnHolographicDisplay
-api-type: winrt method
---

<!-- Method syntax.
public bool HolographicApplicationPreview.IsCurrentViewPresentedOnHolographicDisplay()
-->

# Windows.ApplicationModel.Preview.Holographic.HolographicApplicationPreview.IsCurrentViewPresentedOnHolographicDisplay

## -description
Gets whether the current app view will display in a Mixed Reality headset.

## -returns
Whether the current view will display in a headset.

## -remarks
On a Desktop PC, users can launch apps in either the desktop or holographic shell.  This method lets an app reason about whether the current thread's CoreApplicationView is displaying within a Mixed Reality headset, rather than on a monitor or other display.  This method is most useful for 2D views, as holographic views (i.e. views for which HolographicSpace.CreateForCoreWindow has been called) will always return true.

On HoloLens, all views are displayed within the headset, and so this will return true for all views.

It is an error to call this method when the current thread is not the dispatcher thread for a CoreApplicationView.

## -see-also

## -examples

