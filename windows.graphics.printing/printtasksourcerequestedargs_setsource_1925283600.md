---
-api-id: M:Windows.Graphics.Printing.PrintTaskSourceRequestedArgs.SetSource(Windows.Graphics.Printing.IPrintDocumentSource)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetSource(Windows.Graphics.Printing.IPrintDocumentSource source)
-->

# Windows.Graphics.Printing.PrintTaskSourceRequestedArgs.SetSource

## -description
Informs the print task of the content to be printed.

## -parameters
### -param source
A pointer to the **IPrintDocumentSource** interface.

## -remarks
Content source information for the print task can come from either HTML (via [MSApp.GetHtmlPrintDocumentSource](https://msdn.microsoft.com/library/Hh772325)) or from XAML (via the XAML [PrintDocument.DocumentSource](https://docs.microsoft.com/uwp/api/windows.ui.xaml.printing.printdocument.documentsource)). Or you can create your own method to provide content source information to the print task.

## -examples

## -see-also
[IPrintDocumentSource](iprintdocumentsource.md), [MSApp.GetHtmlPrintDocumentSource](https://msdn.microsoft.com/library/Hh772325), [PrintDocument.DocumentSource](https://docs.microsoft.com/uwp/api/windows.ui.xaml.printing.printdocument.documentsource)
