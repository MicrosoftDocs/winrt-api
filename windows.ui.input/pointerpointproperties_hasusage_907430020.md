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

Use [HasUsage](pointerpointproperties_hasusage.md) to query for additional, custom, and device-specific usages or when you need to verify that a device actually supports a property (where [PointerPoint](pointerpoint.md) and [PointerPointProperties](pointerpointproperties.md) return a default value).

The following table lists the Human Interface Device (HID) usages that are exposed directly through [PointerPoint](pointerpoint.md) and [PointerPointProperties](pointerpointproperties.md).<table>
   <tr><th>Property</th><th>Usage Page</th><th>Usage</th></tr>
   <tr><td>[Position (X)](pointerpoint_position.md)</td><td>0x01</td><td>0x30</td></tr>
   <tr><td>[Position (Y)](pointerpoint_position.md)</td><td>0x01</td><td>0x31</td></tr>
   <tr><td>[RawPosition (X)](pointerpoint_rawposition.md)</td><td>0x01</td><td>0x30</td></tr>
   <tr><td>[RawPosition (Y)](pointerpoint_rawposition.md)</td><td>0x01</td><td>0x31</td></tr>
   <tr><td>[IsInContact](pointerpoint_isincontact.md)</td><td>0x0D</td><td>0x42 (tip) or 0x45 (eraser tip)</td></tr>
   <tr><td>[Pressure](pointerpointproperties_pressure.md)</td><td>0x0D</td><td>0x30</td></tr>
   <tr><td>[IsInverted](pointerpointproperties_isinverted.md)</td><td>0x0D</td><td>0x3C</td></tr>
   <tr><td>[IsEraser](pointerpointproperties_iseraser.md)</td><td>0x0D</td><td>0x45</td></tr>
   <tr><td>[Orientation](pointerpointproperties_orientation.md)</td><td>0x0D</td><td>0x3F</td></tr>
   <tr><td>[XTilt](pointerpointproperties_xtilt.md)</td><td>0x0D</td><td>0x3D</td></tr>
   <tr><td>[YTilt](pointerpointproperties_ytilt.md)</td><td>0x0D</td><td>0x3E</td></tr>
   <tr><td>[Twist](pointerpointproperties_twist.md)</td><td>0x0D</td><td>0x41</td></tr>
   <tr><td>[ContactRect (Width)](pointerpointproperties_contactrect.md)</td><td>0x0D</td><td>0x48</td></tr>
   <tr><td>[ContactRect (Height)](pointerpointproperties_contactrect.md)</td><td>0x0D</td><td>0x49</td></tr>
   <tr><td>[ContactRectRaw (Width)](pointerpointproperties_contactrectraw.md)</td><td>0x0D</td><td>0x48</td></tr>
   <tr><td>[ContactRectRaw (Height)](pointerpointproperties_contactrectraw.md)</td><td>0x0D</td><td>0x49</td></tr>
   <tr><td>[TouchConfidence](pointerpointproperties_touchconfidence.md)</td><td>0x0D</td><td>0x47</td></tr>
   <tr><td>[IsInRange](pointerpointproperties_isinrange.md)</td><td>0x0D</td><td>0x32</td></tr>
</table>

## -examples

## -see-also
[GetUsageValue](pointerpointproperties_getusagevalue.md), [HID Information](http://go.microsoft.com/fwlink/p/?linkid=233148)