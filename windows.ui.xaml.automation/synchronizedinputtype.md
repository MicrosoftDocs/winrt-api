---
-api-id: T:Windows.UI.Xaml.Automation.SynchronizedInputType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Automation.SynchronizedInputType : int
-->

# SynchronizedInputType


## -description
Provides a of set constants that identify, as used by the [ISynchronizedInputProvider](/windows/desktop/api/uiautomationcore/nn-uiautomationcore-isynchronizedinputprovider)  Microsoft UI Automation interface.




## -enum-fields
### -field KeyUp:1
A key has been released.

### -field KeyDown:2
A key has been pressed.

### -field LeftMouseUp:4
The left mouse button has been released.

### -field LeftMouseDown:8
The left mouse button has been pressed.

### -field RightMouseUp:16
The right mouse button has been released.

### -field RightMouseDown:32
The right mouse button has been pressed.


## -remarks
Values of SynchronizedInputType are used as an input parameter by the [StartListening](../windows.ui.xaml.automation.provider/isynchronizedinputprovider_startlistening_125371983.md) method.

The values in SynchronizedInputType parallel the values in the [SynchronizedInputType](/windows/desktop/api/uiautomationcore/ne-uiautomationcore-synchronizedinputtype) enumeration.


## -examples


## -see-also
[StartListening](../windows.ui.xaml.automation.provider/isynchronizedinputprovider_startlistening_125371983.md)
