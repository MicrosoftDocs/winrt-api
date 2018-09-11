---
-api-id: T:Windows.UI.Xaml.Automation.SynchronizedInputType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Automation.SynchronizedInputType : int
-->

# SynchronizedInputType


## -description
Provides a of set constants that identify, as used by the [ISynchronizedInputProvider](http://msdn.microsoft.com/library/70495eba-172a-432e-951d-1092fd676d5e)  Microsoft UI Automation interface.


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
Values of [SynchronizedInputType](synchronizedinputtype.md) are used as an input parameter by the [StartListening](../windows.ui.xaml.automation.provider/isynchronizedinputprovider_startlistening_125371983.md) method.

The values in [SynchronizedInputType](synchronizedinputtype.md) parallel the values in the [SynchronizedInputType](http://msdn.microsoft.com/library/28c66392-89f0-40eb-be19-ac84c64dacb7) enumeration.


## -examples


## -see-also
[StartListening](../windows.ui.xaml.automation.provider/isynchronizedinputprovider_startlistening_125371983.md)