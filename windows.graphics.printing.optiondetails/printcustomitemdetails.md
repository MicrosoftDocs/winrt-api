---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintCustomItemDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintCustomItemDetails : Windows.Graphics.Printing.OptionDetails.IPrintCustomItemDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintCustomItemDetails

## -description
Allows apps to add a collection of enumerable options to the app print experience.

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

// printCustomItemDetails is available in the Items list from the
// PrintCustomItemsListOptionDetails object.
var printCustomItemDetails = printCustomItemListOptionDetails.Items;
```

## -examples

## -see-also