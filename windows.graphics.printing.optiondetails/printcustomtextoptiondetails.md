---
-api-id: T:Windows.Graphics.Printing.OptionDetails.PrintCustomTextOptionDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PrintCustomTextOptionDetails : Windows.Graphics.Printing.OptionDetails.IPrintCustomOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintCustomTextOptionDetails, Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
-->

# Windows.Graphics.Printing.OptionDetails.PrintCustomTextOptionDetails

## -description
Represents a custom print task option.

## -remarks

Here is a code snippet that shows how to retrieve the object:

```csharp
// This code creates a new custom text option. 
PrintCustomTextOptionDetails customTextOption =
    printDetailedOptions.CreateTextOption("myCustomText", "Custom Options");

// Later in your app, when you want to access the custom text option created above,
// but you don't have access to the customTextOption variable that was returned
// when it was created, you can get it by looking up the same optionId that
// you used to create it. 
PrintCustomTextOptionDetails printCustomTextOptionDetails =
    (PrintCustomTextOptionDetails)printDetailedOptions.Options["myCustomText"];
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | Description |
| 1803 | 17134 | WarningText |

## -examples

## -see-also
