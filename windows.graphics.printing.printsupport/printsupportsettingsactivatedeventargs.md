---
-api-id: T:Windows.Graphics.Printing.PrintSupport.PrintSupportSettingsActivatedEventArgs
-api-type: winrt class
---

# Windows.Graphics.Printing.PrintSupport.PrintSupportSettingsActivatedEventArgs

<!--
public sealed class PrintSupportSettingsActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
-->


## -description

Enables a print support settings UI extension app to handle the activation parameters for the app.

## -remarks

To create print support settings UI extension, your app must declare a [uap4:Extension](/uwp/schemas/appxpackage/uapmanifestschema/element-uap4-extension) element with the category **windows.printSupportSettingsUI** in its package manifest. When the app is activated, the `OnActivated` method receives a **PrintSupportSettingsActivatedEventArgs** object that provides access to information about the print support UI session.

For more information, see [Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide).

## -see-also

[Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide)

## -examples


