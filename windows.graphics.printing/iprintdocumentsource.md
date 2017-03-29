---
-api-id: T:Windows.Graphics.Printing.IPrintDocumentSource
-api-type: winrt interface
-api-device-family-note: xbox
---

<!-- Interface syntax.
public interface IPrintDocumentSource : 
-->

# Windows.Graphics.Printing.IPrintDocumentSource

## -description
Initialized when a print task is initialized for the print system.

## -remarks
The **IPrintDocumentSource** describes the source of the print document. When you set the source for the print document using the [SetSource](printtasksourcerequestedargs_setsource.md) method in [PrintTaskSourceRequestedArgs](printtasksourcerequestedargs.md), you must provide a pointer to an implementation of the **IPrintDocumentSource** interface.

## -examples

## -see-also