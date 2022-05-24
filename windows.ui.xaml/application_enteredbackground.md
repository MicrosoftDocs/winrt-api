---
-api-id: E:Windows.UI.Xaml.Application.EnteredBackground
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.EnteredBackgroundEventHandler EnteredBackground
-->

# Windows.UI.Xaml.Application.EnteredBackground

## -description
Occurs when the app moves from the foreground to the background.

## -remarks
This event is fired when the user navigates away from the app. There is a limited amount of time that an event handler for this event can run. 

When your app moves into the background, the memory constraints enforced by the system may change. Use this event to check your current memory consumption and free resources in order to stay below the limit so that your app won't be suspended and possibly terminated while it is in the background.  See [Free memory when your app moves to the background](/windows/uwp/launch-resume/reduce-memory-usage) for more details.

The EnteredBackground event runs in the apartment it was registered in.

## -examples

## -see-also

[Processes threads and apartments](/windows/win32/com/processes--threads--and-apartments)
