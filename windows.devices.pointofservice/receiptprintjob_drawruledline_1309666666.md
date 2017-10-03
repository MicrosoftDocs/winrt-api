---
-api-id: M:Windows.Devices.PointOfService.ReceiptPrintJob.DrawRuledLine(System.String,Windows.Devices.PointOfService.PosPrinterLineDirection,System.UInt32,Windows.Devices.PointOfService.PosPrinterLineStyle,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void DrawRuledLine(System.String positionList, Windows.Devices.PointOfService.PosPrinterLineDirection lineDirection, System.UInt32 lineWidth, Windows.Devices.PointOfService.PosPrinterLineStyle lineStyle, System.UInt32 lineColor)
-->

# Windows.Devices.PointOfService.ReceiptPrintJob.DrawRuledLine

## -description
Adds an instruction to the print job to print a drawn, ruled line on the paper of the receipt printer station.

## -parameters
### -param positionList
The position parameters for the ruled line. The character string for *positionList* differs depending on whether *lineDirection* specifies a horizontal ruled line or a vertical ruled line (see remarks).

### -param lineDirection
The direction in which to print the ruled line.

### -param lineWidth
The width of the ruled line that the print should print. The unit of width is dot. If an unsupported value is specified, the best fit value for the printer is used.

### -param lineStyle
The appearance of the ruled line, such as whether it is solid or broken, or single or double.

### -param lineColor
The color of the ruled line, as an integer value that is equal to the value of the cartridge constant used in the [ClaimedReceiptPrinter.ColorCartridge](claimedreceiptprinter_colorcartridge.md) property. If an unsupported value is specified, the printing results may be unpredictable.

## -remarks
The *positionList* argument varies depending on whether a horizontal or vertical ruled line is being drawn.

For horizontal ruled lines, *positionList* consists of comma delimited numbers (units of measure are defined by the **MapMode** property),  which denote the starting position and length of each line. Each pair is followed by a semicolon if multiple ruled lines are specified. The pattern is repeated for all additional horizontal ruled lines. Consider this example:

```csharp
positionList = "0,500"
``` 

This *positionList* would result in a ruled line starting at MapMode unit position "0" continuing for 500 MapMode units of length. Here is another example demonstrating multiple horizontal lines:

```csharp
positionList = "0,200;300,100"
``` 

This *positionList* would result in a ruled line starting at unit position "0" and continuing for 200 units in length. Then, another line would begin at position 300 and continue for 100 units in length.

For vertical ruled lines, *positionList* consists of comma delimited numbers (units of measure are defined by the **MapMode** property) which denote the positions for the vertical drawn rules line(s). A continue vertical ruled line will be drawn from each position for the print lines that follow, until the vertical rules lines are changed or terminated by a call to **DrawRuledLine** or a ruled line escape sequence. An empty string in the *positionLine* argument causes the vertical ruled lines to be terminated. Consider this example:

```csharp
positionList = "0,100,400,500"
```

This *positionList* results in four drawn ruled lines starting at unit positions "0", "100", "400", and "500" when each line of data is printed.

## -examples

## -see-also
[IReceiptOrSlipJob.DrawRuledLine](ireceiptorslipjob_drawruledline.md), [ClaimedReceiptPrinter.ColorCartridge](claimedreceiptprinter_colorcartridge.md), [PosPrinterLineDirection](posprinterlinedirection.md), [PosPrinterLineStyle](posprinterlinestyle.md)