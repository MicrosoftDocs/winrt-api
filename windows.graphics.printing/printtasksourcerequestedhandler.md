---
-api-id: T:Windows.Graphics.Printing.PrintTaskSourceRequestedHandler
-api-type: winrt delegate
-api-device-family-note: xbox
---
<!-- Delegate syntax.
public delegate void PrintTaskSourceRequestedHandler(Windows.Graphics.Printing.PrintTaskSourceRequestedArgs args)
-->
# Windows.Graphics.Printing.PrintTaskSourceRequestedHandler

## -description
Occurs when a print task requests the document to print. The supplied print document must implement the [IPrintDocumentSource](iprintdocumentsource.md) interface.

## -parameters
### -param args
Pointer to a **PrintTaskSourceRequestedArgs** object.


## -remarks
The PrintTaskSourceRequestedHandler is called to complete the initialization of a [PrintTask](printtask.md) object. This two-phase initialization model is designed to enable an app to quickly respond to the [PrintTaskRequested](printmanager_printtaskrequested.md) event by creating the [PrintTask](printtask.md) object. Then later, when printing is actually invoked, **PrintTaskSourceRequestedHandler** does the work required to prepare the content to be previewed and eventually printed. The deadline for completing work in the PrintTaskSourceRequestedHandler is much larger than the deadline for completing work in the [PrintTaskRequested](printmanager_printtaskrequested.md) handler.

For example, consider an app that needs to download information from the Cloud to complete the printing operation for the details of a boarding pass. The app should respond quickly to the [PrintTaskRequested](printmanager_printtaskrequested.md) event by creating a [PrintTask](printtask.md) object and a name for the print operation, for example "Fabrikam Boarding Pass." The app then provides PrintTaskSourceRequestedHandler with a pointer the **PrintTask** object. When this handler is invoked the app then initiates the call to retrieve the actual content of the boarding pass so that print preview and printing can be performed.

An app has two options for creating a print document source object:
+ **Use a framework provided print document source.** Both the HTML5/JavaScript and XAML frameworks provide implementations of objects which implement the [IPrintDocumentSource](iprintdocumentsource.md) interface. For HTML5/JavaScript apps see [MSApp.getHtmlPrintDocumentSource](https://msdn.microsoft.com/library/Hh772325). For information about developing print-capable apps with the extensible application markup language (XAML), see [Windows.UI.Xaml.Printing.PrintDocument](../windows.ui.xaml.printing/printdocument.md).
+ **Provide a custom print document source.** An app may choose to provide its own custom implementation of an [IPrintDocumentSource](iprintdocumentsource.md) object. Doing so requires a good understanding of Direct2D and/or the XPS APIs. For an example of how an app can provide its own custom print document source, see the [D2D Printing sample](https://go.microsoft.com/fwlink/p/?linkid=242999).


## -examples

## -see-also
[PrintTaskRequested](printmanager_printtaskrequested.md), [PrintTaskSourceRequestedArgs](printtasksourcerequestedargs.md), [PrintTask](printtask.md), [IPrintDocumentSource](iprintdocumentsource.md), [MSApp.getHtmlPrintDocumentSource](https://msdn.microsoft.com/library/Hh772325), [Windows.UI.Xaml.Printing.PrintDocument](../windows.ui.xaml.printing/printdocument.md)
