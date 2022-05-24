---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.SelectedScanRegion
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect SelectedScanRegion { get;  set; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.SelectedScanRegion

## -description
Gets or sets the origin coordinates (horizontal and vertical) and dimensions (width and height) of the selected scan area, in inches. This property is ignored when the [AutoCroppingMode](imagescannerflatbedconfiguration_autocroppingmode.md) property is not **Disabled**.

## -property-value
The location and size of a rectangle.

## -remarks
This table describes the property's restrictions. Default values are set at the beginning of a new scan session.

<table>
   <tr><th>Name</th><th>Default value</th><th>Valid flatbed values</th><th>Valid feeder values</th></tr>
   <tr><td>SelectedScanRegion.X</td><td>0</td><td>between 0 and MaximumScanArea.Width - 1</td><td>between 0 and PageSizeDimenstions.Width</td></tr>
   <tr><td>SelectedScanRegion.Y</td><td>0</td><td>between 0 and MaximumScanArea.Height - 1</td><td>between 0 and PageSizeDimenstions.Height</td></tr>
   <tr><td>SelectedScanRegion.Width</td><td>MaximumScanArea.Width</td><td>between MinimumScanArea.Width and (MaximumScanArea.Width – SelectedScanRegion.X)</td><td>between MinimumScanArea.Width and PageSizeDimensions.Width</td></tr>
   <tr><td>SelectedScanRegion.Height</td><td>MaximumScanArea.Height</td><td>between MinimumScanAreaHeight and (MaximumScanAreaHeight – SelectedScanRegion.Y)</td><td>between MinimumScanArea.Height and PageSizeDimensions.Height</td></tr>
</table>

## -examples

## -see-also
