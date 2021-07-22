---
-api-id: P:Windows.Devices.Scanners.ImageScannerFeederConfiguration.SelectedScanRegion
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect SelectedScanRegion { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFeederConfiguration.SelectedScanRegion

## -description
Gets or sets the origin coordinates (horizontal and vertical) and dimensions (width and height) of the selected scan area, in inches. This property is ignored when the [AutoCroppingMode](imagescannerfeederconfiguration_autocroppingmode.md) property is not **Disabled**.

## -property-value
The scan region, in inches.

## -remarks
This table describes the property's restrictions. Default values are set at the beginning of a new scan session.

<table>
   <tr><th>Name</th><th>Default value</th><th>Valid flatbed values</th><th>Valid feeder values</th></tr>
   <tr><td /><td>0</td><td>between 0 and  - 1</td><td>between 0 and </td></tr>
   <tr><td /><td>0</td><td>between 0 and  - 1</td><td>between 0 and </td></tr>
   <tr><td /><td /><td>between  and ( – )</td><td>between  and </td></tr>
   <tr><td /><td /><td>between  and ( – )</td><td>between  and </td></tr>
</table>

## -examples

## -see-also
