---
-api-id: P:Windows.UI.Input.PointerPointProperties.ContactRectRaw
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect ContactRectRaw { get; }
-->

# Windows.UI.Input.PointerPointProperties.ContactRectRaw

## -description
Gets the bounding rectangle of the raw input (typically from touch input).

## -property-value
The bounding rectangle of the raw input, in device-independent pixel (DIP)

## -remarks
ContactRectRaw contains the bounding rectangle of the raw input as reported by the input device. Under some circumstances, such as input prediction, this data can be modified by the system to compensate for hardware latency or message latency due to inherent delays in sensing and processing the pointer location on the digitizer.

See [ContactRect](pointerpointproperties_contactrect.md) for more information on handling modified input data.

## -examples

## -see-also
[ContactRect](pointerpointproperties_contactrect.md)
