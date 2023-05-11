---
-api-id: T:Windows.Graphics.Display.ResolutionScale
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.Display.ResolutionScale : int
-->

# ResolutionScale

## -description
Describes the scale factor of the app window. The scale factor is determined by the operating system in response to high pixel density screens.

## -enum-fields
### -field Invalid:0
Specifies that the scale of a display is invalid.

### -field Scale100Percent:100
Specifies the scale of a display as 100 percent. This percentage indicates a minimum screen resolution for Windows all up is 1024x768.

### -field Scale120Percent:120
This value isn't used.

### -field Scale125Percent:125
Specifies the scale of a display as 125 percent.

### -field Scale140Percent:140
Specifies the scale of a display as 140 percent. This percentage indicates a minimum screen resolution to scale at 140 is 1440x1080.

### -field Scale150Percent:150
Specifies the scale of a display as 150 percent. Also applies to Windows Phone 8.

### -field Scale160Percent:160
Specifies the scale of a display as 160 percent. Applies to Windows Phone 8.

### -field Scale175Percent:175
Specifies the scale of a display as 175 percent.

### -field Scale180Percent:180
Specifies the scale of a display as 180 percent. This percentage indicates a minimum screen resolution to scale at 180 is 1920x1440.

### -field Scale200Percent:200
Specifies the scale of a display as 200 percent.

### -field Scale225Percent:225
This value isn't used.

### -field Scale250Percent:250
Specifies the scale of a display as 250 percent.

### -field Scale300Percent:300
Specifies the scale of a display as 300 percent.

### -field Scale350Percent:350
Specifies the scale of a display as 350 percent.

### -field Scale400Percent:400
Specifies the scale of a display as 400 percent.

### -field Scale450Percent:450
Specifies the scale of a display as 450 percent.

### -field Scale500Percent:500
Specifies the scale of a display as 500 percent.

## -remarks
The range of asset scale values that can be provided to MakeAppX for a UWP app is limited to 100, 125, 150, 200, 250, 300, 400 and 500.

For more info on scaling to pixel density, see [UX guidelines for layout and scaling](/windows/uwp/design/layout/screen-sizes-and-breakpoints-for-responsive-design).

The [Scaling according to DPI sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Scaling%20according%20to%20DPI%20sample) shows how to use the ResolutionScale enumeration.

For UWP apps and Windows Phone apps, we recommend these scale factors:

+ UWP app (100/140/180)
+ Windows Phone apps for Windows Phone 8.1 and later (100/140/240)
+ Windows Phone apps for Windows Phone 8 (100/150/160)

## -examples

## -see-also
[DisplayInformation.ResolutionScale property](/uwp/api/windows.graphics.display.displayinformation.resolutionscale#Windows_Graphics_Display_DisplayInformation_ResolutionScale)
