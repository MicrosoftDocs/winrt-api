---
-api-id: T:Windows.Graphics.Printing.PrintSupport.PrintSupportSettingsUISession
-api-type: winrt class
---

# Windows.Graphics.Printing.PrintSupport.PrintSupportSettingsUISession

<!--
public sealed class PrintSupportSettingsUISession
-->


## -description

Represents a session of the print support settings UI.

## -remarks

To create a print support settings UI extension, your app must declare a [uap4:Extension](/uwp/schemas/appxpackage/uapmanifestschema/element-uap4-extension) element with the category **windows.printSupportSettingsUI** in its package manifest. When the app is activated, the `OnActivated` method receives a [PrintSupportSettingsActivatedEventArgs](printsupportsettingsactivatedeventargs.md) object that provides access to information about the print support UI session. The [Session](printsupportsettingsactivatedeventargs_session.md) property of that object returns a **PrintSupportSettingsUISession** object.

For more information, see [Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide).

## -see-also

[Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide),[Session](printsupportsettingsactivatedeventargs_session.md)

## -examples


