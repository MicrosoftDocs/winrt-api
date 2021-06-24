---
-api-id: T:Windows.Graphics.Printing.Workflow.PrintWorkflowJobBackgroundSession
-api-type: winrt class
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowJobBackgroundSession

<!--
public sealed class PrintWorkflowJobBackgroundSession
-->


## -description

Represents a single print workflow job session that runs in the background.

## -remarks

To create a print support workflow, your app must declare a [uap4:Extension](/uwp/schemas/appxpackage/uapmanifestschema/element-uap4-extension) element with the category **windows.printSupportWorkflow** in its package manifest that specifies the entry point of a background task. When the background task is activated, the [IBackgroundTask.Run](/uwp/api/windows.applicationmodel.background.ibackgroundtask.run) method receives an [IBackgroundTaskInstance](/uwp/api/windows.applicationmodel.background.ibackgroundtaskinstance) object. You can cast the [TriggerDetails](windows.applicationmodel.background.ibackgroundtaskinstance.triggerdetails) property of this object to a [PrintWorkflowJobTriggerDetails](printworkflowjobtriggerdetails.md) object to get more details about the print workflow job session.

For more information, see [Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide).

## -see-also

[Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide)

## -examples


