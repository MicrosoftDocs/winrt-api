---
-api-id: E:Windows.Graphics.Printing.PrintSupport.PrintSupportExtensionSession.PrintTicketValidationRequested
-api-type: winrt event
---

# Windows.Graphics.Printing.PrintSupport.PrintSupportExtensionSession.PrintTicketValidationRequested

<!--
public event Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintSupport.PrintSupportExtensionSession,Windows.Graphics.Printing.PrintSupport.PrintSupportPrintTicketValidationRequestedEventArgs> PrintTicketValidationRequested;
-->


## -description

Raised when the system needs to validate a print ticket.

## -remarks

This event can be raised any time during a print job. After your code validates the print ticket, call [SetPrintTicketValidationStatus](printsupportprintticketvalidationrequestedeventargs_setprintticketvalidationstatus_920893354.md) to indicate whether the print ticket has been resolved, has conflicts, or is invalid.

## -see-also

## -examples


