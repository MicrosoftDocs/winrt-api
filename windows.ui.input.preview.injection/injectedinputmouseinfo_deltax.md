---
-api-id: P:Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo.DeltaX
-api-type: winrt property
---

<!-- Property syntax
public int DeltaX { get;  set; }
-->

# Windows.UI.Input.Preview.Injection.InjectedInputMouseInfo.DeltaX

## -description
Gets or sets the change in value of an x-coordinate since the last mouse wheel event.

The x-coordinate value being changed is dependent on the flags set with [MouseOptions](injectedinputmouseinfo_mouseoptions.md). Some examples include:
+ [HWheel](injectedinputmouseinfo_mousedata.md): the distance that a mouse wheel has rotated around the x-axis (horizontal). The mouse wheel button has discrete, evenly spaced notches or distance thresholds (also called detents). When you rotate or tilt the wheel, a wheel message is sent as each detent is encountered.

The windows constant, WHEEL_DELTA (defined as a value of 120), describes one detent. Each detent marks the threshold for a single increment of an associated action (for example, scrolling a line or page).

> [!NOTE]
> The delta was set to 120 to enable finer-resolution wheels (such as freely-rotating wheels with no notches) that send more messages per rotation, but with smaller values per message.

A positive value indicates that the wheel was rotated forward (away from the user) or tilted to the right; a negative value indicates that the wheel was rotated backward (toward the user) or tilted to the left.
+ [XDown](injectedinputmouseinfo_mousedata.md) or [XUp](injectedinputmouseinfo_mousedata.md): 1 for XBUTTON1 or 2 for XBUTTON2XBUTTON1 and XBUTTON2 are additional buttons used on many mouse devices, often for forward and backward navigation in Web browsers. They return the same data as standard mouse buttons.


## -property-value
The number of notches or distance thresholds crossed since the last pointer event. The default value is 0.

## -remarks

## -examples

## -see-also
