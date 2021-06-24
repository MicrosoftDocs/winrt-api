---
-api-id: T:Windows.Graphics.Printing.PrintSupport.PrintSupportExtensionSession
-api-type: winrt class
---

# Windows.Graphics.Printing.PrintSupport.PrintSupportExtensionSession

<!--
public sealed class PrintSupportExtensionSession
-->

## -description

Represents a session of a print support extension.

## -remarks

To a create print support extension, your app must declare a [uap4:Extension](/uwp/schemas/appxpackage/uapmanifestschema/element-uap4-extension) element with the category **windows.printSupportSettings** in its package manifest that specifies the entry point of a background task. When the background task is activated, the [IBackgroundTask.Run](/uwp/api/windows.applicationmodel.background.ibackgroundtask.run) method receives an [IBackgroundTaskInstance](/uwp/api/windows.applicationmodel.background.ibackgroundtaskinstance) object. You can cast the [TriggerDetails](windows.applicationmodel.background.ibackgroundtaskinstance.triggerdetails) property of this object to a [PrintSupportExtensionTriggerDetails](printsupportextensiontriggerdetails.md) object to get more details about the print support extension session.

For more information, see [Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide).

## -see-also

[Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide),[Session](printsupportextensiontriggerdetails_session.md)

## -examples


