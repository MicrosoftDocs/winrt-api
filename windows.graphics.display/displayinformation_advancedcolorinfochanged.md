---
-api-id: E:Windows.Graphics.Display.DisplayInformation.AdvancedColorInfoChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler AdvancedColorInfoChanged<DisplayInformation,  object>
-->

# Windows.Graphics.Display.DisplayInformation.AdvancedColorInfoChanged



## -description

Raised when the advanced color information is changed.

## -remarks

This is an event registration API which will register an event notification for the UWP apps so that they can be notified whenever there is any change in the Advanced Color info on the monitor corresponding to their CoreWindow. The app can then call the GetAdvancedColorInfo API to know the latest capabilities and state. The app needs to track which values are changed and respond accordingly if needed, event API will not indicate which values changed. 
Note that this event will remove any existing notification which the app previously registered for changes in Advanced Color info. 


## -see-also

## -examples

