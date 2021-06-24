---
-api-id: T:Windows.Devices.Display.Core.DisplaySourceStatus
-api-type: winrt enum
---

# Windows.Devices.Display.Core.DisplaySourceStatus

<!--
public enum DisplaySourceStatus
-->

## -description

Defines constants that specify a state that a display source (a [DisplaySource](displaysource.md) object) can be in.

The state affects the display source's usage, and how it affects other API calls. For example, if a display source is powered off, then you can expect that a call to (for example) [DisplayTaskPool.TryExecuteTask](displaytaskpool_tryexecutetask_474435703.md) won't be successful.

## -enum-fields

### -field Active: 0

Specifies that the display source is connected to a [DisplayTarget](displaytarget.md), and is valid and owned by the given [**DisplayDevice**](displaydevice.md). Also, it means that the underlying display's power status is powered on from the kernel's perspective. This is the most common status when a **DisplaySource** is set up correctly and is in use by a DirectDisplay client for presentation.

### -field PoweredOff: 1

Specifies that the display source is connected to a **DisplayTarget**, and is valid and owned by the given **DisplayDevice**. But the underlying display's power status is powered off from the kernel's perspective. 

### -field Invalid: 2

Specifies that the display source is not valid, and the DirectDisplay client needs to recreate the [DisplaySource](displaysource.md) object. A **DisplaySource** can become invalid for various reasons; for example, display mode changes, or hot plug detect (HPD) of the connected monitor.

### -field OwnedByAnotherDevice: 3

Specifies that the display source isn't currently owned by the current **DisplayDevice**, and is owned by either a different **DisplayDevice** (let's call that display device A), or by some other Direct3D device. If display device A has ownership, then the current **DisplayDevice** can try to recreate the display source (if the [**DisplayManager**](displaymanager.md) that created display device A used [**DisplayManagerOptions.None**](displaymanageroptions.md). If some other Direct3D device has ownership, then you can still try to recreate the **DisplaySource** if you believe that you're the right owner.

### -field Unowned: 4

Specifies that the display source isn't currently owned by the current **DisplayDevice**, and is in an unowned state. In this case you can try to recreate the **DisplaySource**; doing so will give you ownership implicitly.

## -remarks

## -see-also

## -examples
