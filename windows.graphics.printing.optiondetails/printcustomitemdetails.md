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

// Append the custom option to the current list
printDetailedOptions.displayedoptions.append("PageContent");

// later in your app, when you want to access that list again 
// and don’t have access to the pageFormat variable that was 
// returned when the list was created, you can get it by   
// looking up the same optionId that you used to create the list. 
var printCustomItemListOptionDetails = 
             printDetailedOptions.options.lookup("PageContent"); 

// printCustomItemDetails is available in the Items vector from the 
// PrintCustomItemsListOptionDetails object
var printCustomItemDetails = printCustomItemListOptionDetails.Items; 

```



## -examples

## -see-also