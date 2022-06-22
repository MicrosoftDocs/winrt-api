---
-api-id: E:Windows.UI.Xaml.Printing.PrintDocument.AddPages
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Printing.AddPagesEventHandler AddPages
-->

# Windows.UI.Xaml.Printing.PrintDocument.AddPages

## -description
Occurs when the [PrintManager](../windows.graphics.printing/printmanager.md) requests the final collection of pages to send to the printer.



## -remarks
Provide Windows with printable pages by calling [AddPage](printdocument_addpage_533744783.md) for each page to be printed. Pass a [UIElement](../windows.ui.xaml/uielement.md) that is the printable content to the [AddPage](printdocument_addpage_533744783.md) method. Call [AddPagesComplete](printdocument_addpagescomplete_260689112.md) to signal that all of the pages to be printed have been added and Windows can continue with the print job.

If the user specifies particular pages or a range of pages in the print options UI, only the specified pages should be added to the print list.

<!--Add link when content is ready: For more info, see How to add page range settings to a UWP app print window. (This is the JS title, might want to shorten it a little.) -->

## -examples

## -see-also
[Print from your app](/windows/uwp/devices-sensors/print-from-your-app)
