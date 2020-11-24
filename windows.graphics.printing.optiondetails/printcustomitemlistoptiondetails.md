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

Here is a code snippet that shows how to retrieve the object:

```csharp
// Create a new list option.
// This code creates a new item list option that will be shown to the user.
PrintCustomItemListOptionDetails pageFormat = 
    printDetailedOptions.CreateItemListOption("PageContent", "Pictures");
pageFormat.AddItem("PicturesText", "Pictures and text");
pageFormat.AddItem("PicturesOnly", "Pictures only");
pageFormat.AddItem("TextOnly", "Text only");

// Add the custom option to the option list.
printDetailedOptions.DisplayedOptions.Add("PageContent");

// Later in your app, when you want to access the list created above,
// but you don't have access to the pageFormat variable that was returned
// when the list was created, you can get it by looking up the same
// optionId that you used to create the list.
PrintCustomItemListOptionDetails printCustomItemListOptionDetails =
    (PrintCustomItemListOptionDetails)printDetailedOptions.Options["PageContent"];
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | AddItem(String,String,String,IRandomAccessStreamWithContentType) |
| 1803 | 17134 | Description |
| 1803 | 17134 | WarningText |

## -examples

## -see-also
