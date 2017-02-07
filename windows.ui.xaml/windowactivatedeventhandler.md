---
-api-id: T:Windows.UI.Xaml.WindowActivatedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void WindowActivatedEventHandler(System.Object sender, Windows.UI.Core.WindowActivatedEventArgs e)
-->
# Windows.UI.Xaml.WindowActivatedEventHandler

## -description
Represents the method that will handle the [Activated](window_activated.md) event.

## -parameters
### -param sender
The object where the handler is attached.

### -param e
Event data for the event.


## -remarks
This event occurs when a [Window](window.md) has been activated or deactivated by the system. An app can determine what the status of the [Window](window.md) activation is by checking the [WindowActivatedEventArgs.WindowActivationState](../windows.ui.core/windowactivatedeventargs_windowactivationstate.md) property. A [Window](window.md) could be visible on screen but not be active. Additionally, if any other parts of the system takes focus away from the window, this event will occur. This could happen as a result of user interaction or code, and the [WindowActivationState](../windows.ui.core/windowactivatedeventargs_windowactivationstate.md) will indicate which action has taken place.

App activation as opposed to [Window](window.md) activation has its own **Activated** event. For more info, see [OnActivated](application_onactivated.md) or [Handle app activation](http://msdn.microsoft.com/library/da9a6a43-f09d-4512-a2ab-9b6132431007).

## -examples
The following code example demonstrates a typical usage pattern for this event.

```csharp
void Current_Activated(object sender, Windows.UI.Core.WindowActivatedEventArgs e)
{
    if (e.WindowActivationState == 
        Windows.UI.Core.CoreWindowActivationState.Deactivated)
    {
        // Show the "paused" UI. 
        VisualStateManager.GoToState(this, "PauseUI", false);
    }
    else if (e.WindowActivationState == 
        Windows.UI.Core.CoreWindowActivationState.PointerActivated)
    {
        // Show the "active" UI. 
        VisualStateManager.GoToState(this, "ActivateUI", false);
    }
}

```



## -see-also
[Window](window.md)