---
-api-id: N:Windows.Graphics.Printing.Workflow
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.Graphics.Printing.Workflow 
-->

# Windows.Graphics.Printing.Workflow

## -description
This namespace provides the functionality for writing a print workflow app. Print workflow apps are registered to print-capable source applications. They are launched in the background after the source application has elected to print something but before the print data is sent to the printer. Workflow apps are able to alter both the print ticket (printer device settings) and the actual content to be printed, and they can optionally expose this functionality to the user by launching a foreground app midway through the process. This allows for a greater degree of customization of the printing experience.

## -remarks

## -see-also
[Print support app design guide](/windows-hardware/drivers/devapps/print-support-app-design-guide), [PrintWorkflowBackgroundSession class](PrintWorkflowBackgroundSession.md), [PrintWorkflowForegroundSession class](PrintWorkflowForegroundSession.md), [Print Workflow sample](https://github.com/Microsoft/print-oem-samples), [Windows.Graphics.Printing.PrintTicket namespace](/uwp/api/windows.graphics.printing.printticket)

## -examples

