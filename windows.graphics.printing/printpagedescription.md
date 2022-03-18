---
-api-id: T:Windows.Graphics.Printing.PrintPageDescription
-api-type: winrt struct
-api-device-family-note: xbox
---

<!-- Structure syntax.
public struct PrintPageDescription 
-->

# PrintPageDescription

## -description
Represents the data that describes a document page.

## -struct-fields

### -field DpiX
The resolution in dots per inch (DPI) for the X dimension of the page.
    

### -field DpiY
The resolution in dots per inch (DPI) for the Y dimension of the page.
    

### -field ImageableRect
The [Rect](../windows.foundation/rect.md) within the page size on which content may actually be printed. Content outside of the rectangle, whether less or greater than the page size, will be cropped by the print target. The  is specified in device independent pixels (DIPs).
    

### -field PageSize
The page size in device independent pixels (DIPs).
    

## -remarks

## -examples

## -see-also