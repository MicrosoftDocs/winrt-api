---
-api-id: E:Windows.ApplicationModel.Core.CoreApplication.LeavingBackground
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler LeavingBackground<Windows.ApplicationModel.LeavingBackgroundEventArgs>
-->

# Windows.ApplicationModel.Core.CoreApplication.LeavingBackground

## -description
Fired just before application UI becomes visible.

## -remarks
Previously the best location to load UI was in your activated or resuming event handler. Now your handler for the [LeavingBackground](coreapplication_leavingbackground.md) event is the best place to do your final checks to ensure that the UI is ready for presentation. It is important to check that visual assets are ready by this time because this is the last opportunity to do work before your application is visible to the user.

## -examples

## -see-also
[LeavingBackgroundEventArgs](../windows.applicationmodel/leavingbackgroundeventargs.md)