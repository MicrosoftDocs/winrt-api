---
-api-id: T:Windows.Graphics.Printing.Workflow.PrintWorkflowJobActivatedEventArgs
-api-type: winrt class
---

# Windows.Graphics.Printing.Workflow.PrintWorkflowJobActivatedEventArgs

<!--
public sealed class PrintWorkflowJobActivatedEventArgs : Windows.ApplicationModel.Activation.IActivatedEventArgsWithUser
-->


## -description

Enables a print support workflow UI extension app to handle the activation parameters for the app.

## -remarks

To create a print support workflow UI extension, your app must declare a [uap4:Extension](/uwp/schemas/appxpackage/uapmanifestschema/element-uap4-extension) element with the category **windows.printSupportJobUI** in its package manifest. When the app is activated, the `OnActivated` method receives a [PrintWorkflowJobActivatedEventArgs](printworkflowjobactivatedeventargs.md) object that provides access to information about the print support workflow UI session. The [Session](printworkflowjobactivatedeventargs_session.md) property of that object returns a [PrintWorkflowJobUISession](printworkflowjobuisession.md) object.

For more information, see [Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide).

## -see-also

[Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide)

## -examples


