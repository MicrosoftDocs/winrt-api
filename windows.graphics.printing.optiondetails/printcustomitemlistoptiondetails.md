---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintCustomItemListOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintCustomItemListOptionDetails : Windows.Graphics.Printing.OptionDetails.IPrintCustomItemListOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintCustomOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintCustomItemListOptionDetails

## -description
Represents a list of the custom print task option items.

## -remarks
Here is a JavaScript code snippet that shows how to retrieve the object:

```javascript
// Create a new list option
// This code creates a new item list option that will be shown to the user
// pageFormat is an object of type: PrintCustomItemListOptionDetails
var pageFormat = 
     printDetailedOptions.createItemListOption("PageContent", "Pictures");
pageFormat.addItem("PicturesText", "Pictures and text");
pageFormat.addItem("PicturesOnly", "Pictures only");
pageFormat.addItem("TextOnly", "Text only");

// later in your app, when you want to access that list again 
// and don’t have access to the pageFormat variable that was 
// returned when the list was created, you can get it by   
// looking up the same optionId that you used to create the list. 
var printCustomItemListOptionDetails = 
     printDetailedOptions.options.lookup("PageContent");

```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | AddItem(String,String,String,IRandomAccessStreamWithContentType) |
| 1803 | 17134 | Description |
| 1803 | 17134 | WarningText |

## -examples

## -see-also
