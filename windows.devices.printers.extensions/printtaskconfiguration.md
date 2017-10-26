---
-api-id: T:Windows.Devices.Printers.Extensions.PrintTaskConfiguration
-api-type: winrt class
---

<!-- Class syntax.
public class PrintTaskConfiguration : Windows.Devices.Printers.Extensions.IPrintTaskConfiguration
-->

# Windows.Devices.Printers.Extensions.PrintTaskConfiguration

## -description
Allows a client to retrieve the print task extension context, and also to add an event handler to the print task.

## -remarks
When a UWP app is invoked from **More settings** in the print window, the activation event provides an event argument of type [Windows.UI.WebUI.WebUIPrintTaskSettingsActivatedEventArgs](../windows.ui.webui/webuiprinttasksettingsactivatedeventargs.md) that exposes a property, [Configuration](../windows.ui.webui/webuiprinttasksettingsactivatedeventargs_configuration.md), for controlling the printer. This property provides an object of type **PrintTaskConfiguration** that provides access to the print task extension context, and also allows you to add an event handler to update the print ticket.

The following JavaScript code snippet demonstrates how to access the **PrintTaskConfiguration** object, and then use that to access the [PrinterExtensionContext](printtaskconfiguration_printerextensioncontext.md) property.





```javascript
var configuration;
var printerExtesionContext;
 
function displayPrintSettings() {

    if (!configuration) {
        sdkSample.displayError("Configuration argument is null");
        return;
    }

    printerExtesionContext = configuration.printerExtensionContext;
    printHelper = new Microsoft.Samples.Printing.WwaDca.
        PrintHelperClass(printerExtensionContext);    

    var feature = "PageOrientation";

    // if printer's capabilities include this feature.
    if (!printHelper.featureExists(feature)) {
        continue;
    }

    // Get the selected option for this feature in the current
    // context's print ticket.
    var selectedOption = printHelper.getSelectedOptionIndex(feature);

    // Get the array of options in the current context’s print ticket
    var optionIndex = printHelper.getOptionInfo(feature, "Index"),
    var optionNames = printHelper.getOptionInfo(feature, 
        "DisplayName"),

    var selectedName;
    for (var i = 0; i < optionIndex.length; i++) {
        if (optionIndex[i] === selectedOption)
           selectedName = optionNames[i];

    // logic to display the orientation string here
}

```



## -examples

## -see-also
[PrinterExtensionContext](printtaskconfiguration_printerextensioncontext.md)