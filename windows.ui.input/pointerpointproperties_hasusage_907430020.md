---
-api-id: M:Windows.UI.Input.PointerPointProperties.HasUsage(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public bool HasUsage(System.UInt32 usagePage, System.UInt32 usageId)
-->

# Windows.UI.Input.PointerPointProperties.HasUsage

## -description
Gets a value that indicates whether the input data from the pointer device contains the specified Human Interface Device (HID) usage information.

## -parameters
### -param usagePage
The Human Interface Device (HID) usage page of the pointer device. Usage pages specify the class of device. For example, touch digitizers (0x0D) and generic input (0x01).

### -param usageId
Indicates a usage in a usage page.Usage ID specify a device or property in the **usagePage**. For example, for touch digitizers this includes tip switch (0x42) to indicate finger contact or tip pressure (0x30).

## -returns
True if the input data includes usage information; otherwise false.

## -remarks
[PointerPoint](pointerpoint.md) and [PointerPointProperties](pointerpointproperties.md) expose common Human Interface Device (HID) usages directly.

Use HasUsage to query for additional, custom, and device-specific usages or when you need to verify that a device actually supports a property (where [PointerPoint](pointerpoint.md) and [PointerPointProperties](pointerpointproperties.md) return a default value).

The following table lists the Human Interface Device (HID) usages that are exposed directly through [PointerPoint](pointerpoint.md) and [PointerPointProperties](pointerpointproperties.md).

| Property | Usage page | Usage |
| --- | --- | --- |
|  [Position (X)](pointerpoint_position.md) | 0x01 | 0x30 |
|  [Position (Y)](pointerpoint_position.md) | 0x01 | 0x31 |
|  [RawPosition (X)](pointerpoint_rawposition.md) | 0x01 | 0x30 |
|  [RawPosition (Y)](pointerpoint_rawposition.md) | 0x01 | 0x31 |
|  [IsInContact](pointerpoint_isincontact.md) | 0x0D | 0x42 (tip) or 0x45 (eraser tip) |
|  [Pressure](pointerpointproperties_pressure.md) | 0x0D | 0x30 |
|  [IsInverted](pointerpointproperties_isinverted.md) | 0x0D | 0x3C |
|  [IsEraser](pointerpointproperties_iseraser.md) | 0x0D | 0x45 |
|  [Orientation](pointerpointproperties_orientation.md) | 0x0D | 0x3F |
|  [XTilt](pointerpointproperties_xtilt.md) | 0x0D | 0x3D |
|  [YTilt](pointerpointproperties_ytilt.md) | 0x0D | 0x3E |
|  [Twist](pointerpointproperties_twist.md) | 0x0D | 0x41 |
|  [ContactRect (Width)](pointerpointproperties_contactrect.md) | 0x0D | 0x48 |
|  [ContactRect (Height)](pointerpointproperties_contactrect.md) | 0x0D | 0x49 |
|  [ContactRectRaw (Width)](pointerpointproperties_contactrectraw.md) | 0x0D | 0x48 |
|  [ContactRectRaw (Height)](pointerpointproperties_contactrectraw.md) | 0x0D | 0x49 |
|  [TouchConfidence](pointerpointproperties_touchconfidence.md) | 0x0D | 0x47 |
|  [IsInRange](pointerpointproperties_isinrange.md) | 0x0D | 0x32 |


## -examples

## -see-also
[GetUsageValue](pointerpointproperties_getusagevalue_1941837333.md), [HID Information](https://www.usb.org/developers/hidpage/)
