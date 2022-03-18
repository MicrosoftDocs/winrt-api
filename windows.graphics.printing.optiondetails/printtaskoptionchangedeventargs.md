---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintTaskOptionChangedEventArgs : Windows.Graphics.Printing.OptionDetails.IPrintTaskOptionChangedEventArgs
-->

# Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs

## -description
Called when a print task option has changed.

## -remarks

Here is a code snippet that shows how to retrieve the object, when a print task option has changed. First, the app must register to listen for option changes. Once the option is changed, a callback is made to the event listener.

```csharp

//  Retrieve the advanced Print Task Options.
PrintTaskOptionDetails printDetailedOptions = PrintTaskOptionDetails.GetFromPrintTaskOptions(printTask.Options);

// Create a new list option.
PrintCustomItemListOptionDetails margins = printDetailedOptions.CreateItemListOption("Margins", "Margins");
margins.AddItem("WideMargins", "Wide", "Each margin is 20% of the paper size", await wideMarginsIconTask);
margins.AddItem("ModerateMargins", "Moderate", "Each margin is 10% of the paper size", await moderateMarginsIconTask);
margins.AddItem("NarrowMargins", "Narrow", "Each margin is 5% of the paper size", await narrowMarginsIconTask);

// Add the custom option to the option list
printDetailedOptions.DisplayedOptions.Add("Margins");

printDetailedOptions.OptionChanged += printDetailedOptions_OptionChanged;
```

```csharp
async void printDetailedOptions_OptionChanged(PrintTaskOptionDetails sender, PrintTaskOptionChangedEventArgs args)
{
    string optionId = args.OptionId as string;
    if (string.IsNullOrEmpty(optionId))
    {
        return;
    }

    if (optionId == "Margins")
    {
        PrintCustomItemListOptionDetails marginsOption = (PrintCustomItemListOptionDetails)sender.Options["Margins"];
        string marginsValue = marginsOption.Value.ToString();

        switch (marginsValue)
        {
            case "WideMargins":
                ApplicationContentMarginTop = 0.2;
                ApplicationContentMarginLeft = 0.2; 
                break;
            case "ModerateMargins":
                ApplicationContentMarginTop = 0.1;
                ApplicationContentMarginLeft = 0.1;
                break;
            case "NarrowMargins":
                ApplicationContentMarginTop = 0.05;
                ApplicationContentMarginLeft = 0.05;
                break;
        }
    }
}
```

To see the complete listing for this, and other printing scenarios using **PrintTask**, see [Printing](/windows/uwp/devices-sensors/print-from-your-app) and the [UWP print sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Printing).

## -examples

## -see-also