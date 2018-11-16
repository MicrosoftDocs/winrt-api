---
-api-id: T:Windows.Devices.Display.Core.DisplayPresentationRate
-api-type: winrt struct
ms.custom: RS5
---

<!-- Structure syntax.
public struct DisplayPresentationRate  {
	public Rational VerticalSyncRate 
	public int VerticalSyncsPerPresentation 
}
-->

# Windows.Devices.Display.Core.DisplayPresentationRate

## -description
Describes an overall presentation rate composed of a rational refresh rate and a divider.

## -struct-fields

### -field VerticalSyncRate
The refresh rate, also known as vertical sync rate, which controls how often the display pipeline scans out to a target. This rate is represented in Hertz (Hz) and stored as a two-part rational number.

### -field VerticalSyncsPerPresentation
Specifies an integer divider to scale down the rate of full-screen presentations as a fraction of vertical syncs. For example, if **VerticalSyncsPerPresentation** is set to 2, then one full-screen presentation will last for 2 vertical syncs before the next presentation can occur. Support for values other than 1 requires hardware support.

## -remarks

## -see-also

## -examples
