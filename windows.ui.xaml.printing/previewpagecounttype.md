---
-api-id: T:Windows.UI.Xaml.Printing.PreviewPageCountType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Printing.PreviewPageCountType : int
-->

# PreviewPageCountType

## -description
Describes the basis of the page count.



## -enum-fields
### -field Final:0
Page count is based on final print job total.

### -field Intermediate:1
Page count is based on an intermediate total.


## -remarks
During print preview, call [SetPreviewPageCount](printdocument_setpreviewpagecount_804693784.md) with the value **PreviewPageCountType.Intermediate**. This way, the print preview can show the first page while the app calculates the rest of the pages. If the actual page count to be printed is known, pass **PreviewPageCountType.Final**. When **PreviewPageCountType.Final** is passed to **SetPreviewPageCount**, [SetJobPageCount](/previous-versions/jj553558(v=vs.85)) method is called with the total number of pages.

## -examples

## -see-also
