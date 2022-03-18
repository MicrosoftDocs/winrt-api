---
-api-id: M:Windows.UI.Input.PointerPointProperties.GetUsageValue(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public int GetUsageValue(System.UInt32 usagePage, System.UInt32 usageId)
-->

# Windows.UI.Input.PointerPointProperties.GetUsageValue

## -description
Gets the Human Interface Device (HID) usage value of the raw input.

## -parameters
### -param usagePage
The Human Interface Device (HID) usage page of the pointer device. Usage pages specify the class of device. For example, touch digitizers (0x0D) and generic input (0x01).

### -param usageId
Indicates a usage in a usage page.Usage ID specify a device or property in the **usagePage**. For example, for touch digitizers this includes tip switch (0x42) to indicate finger contact or tip pressure (0x30).

## -returns
The extended usage of the raw input pointer.

## -remarks

## -examples

## -see-also
[HasUsage](pointerpointproperties_hasusage_907430020.md), [HID Information](https://www.usb.org/developers/hidpage/)
