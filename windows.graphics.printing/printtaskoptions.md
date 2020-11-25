---
-api-id: T:Windows.Graphics.Printing.PrintTaskOptions
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintTaskOptions : Windows.Graphics.Printing.IPrintTaskOptions, Windows.Graphics.Printing.IPrintTaskOptionsCore, Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties, Windows.Graphics.Printing.IPrintTaskOptionsCoreUIConfiguration
-->

# Windows.Graphics.Printing.PrintTaskOptions

## -description
Represents a collection of methods and properties for managing the options which define how the content is to be printed.

## -remarks
The PrintTaskOptions class provides access to the different values that define how the content in the print task is to be formatted during printing. The PrintTaskOptions object may contain information like the size of the printed page, its orientation, and the type of media on which the content will be printed. In addition the PrintTaskOptions object provides access to the list of options to be displayed in the print window.

While each option in PrintTaskOptions, for example [MediaSize](printtaskoptions_mediasize.md) or [MediaType](printmediatype.md), has a specific set of supported values, all the options support the same general pattern for representing some common cases. The common case values are *Default*, *NotAvailable* and *PrinterCustom*.

Each option contains a default value, and it is the value that is assigned to the option by the print target. When this value is retrieved via a property access, it is an indication that the print target has not yet determined the actual value for this option. When you set the default value for a particular option, it indicates to the print target that it must use the default value that it has for that option. If there is no default value for that option, then the option value is unchanged.

An option may also report a *NotAvailable* value. This indicates that the specific option is not available for the currently selected print target. For example, if the Duplex property returns a *NotAvailable* value, it indicates that the print target does not support duplex functionality. It is not possible to set an option to the *NotAvailable* value.

The final value that is common to all options is *PrinterCustom*. This indicates that the print target supports the functionality but the current selection is custom to this printer. For example, a print target may support a special method for binding the document that is not one of the standard values. In this case a property query on the Binding option will return the *PrinterCustom* value. Custom output sizes will also be represented as *PrinterCustom* values but the actual physical sizes will still be available via the [GetPageDescription](printtaskoptions_getpagedescription_1541239181.md) method.

An app may also use PrintTaskOptions to customize the options that appear in the print window. The [DisplayedOptions](printtaskoptions_displayedoptions.md) property returns a vector containing the list of option items that will be displayed. Modifications to this list by inserting, appending, removing, or re-ordering options will be reflected in the print window. If a particular print target does not support an option, the option will not be displayed to the user. For the names of the standard options, see [StandardPrintTaskOptions](standardprinttaskoptions.md).

Here is a code snippet that you could use, for example, to set the printed output to color, and also to set the size of the media on which it can be printed. The `PrintTaskOptions` object is accessed through the [PrintTask.Options](printtask_options.md) property.

```csharp
// Set output to color
printTask.Options.ColorMode = PrintColorMode.Color;

// Set the media size for printing
printTask.Options.MediaSize = PrintMediaSize.NorthAmericaLegal;

```

For more information about the allowed values for these print task options see [PrintColorMode](printcolormode.md) and [PrintMediaSize](printmediasize.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | Bordering |
| 1607 | 14393 | GetPagePrintTicket |
| 1803 | 17134 | CustomPageRanges |
| 1803 | 17134 | PageRangeOptions |

## -examples

## -see-also
[PrintColorMode](printcolormode.md), [PrintMediaSize](printmediasize.md), [StandardPrintTaskOptions](standardprinttaskoptions.md)
