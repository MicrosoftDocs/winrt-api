---
-api-id: M:Windows.UI.Xaml.Automation.Provider.ITextRangeProvider.GetBoundingRectangles(System.Double[]@)
-api-type: winrt method
---

<!-- Method syntax
public void GetBoundingRectangles(System.Double[] returnValue)
-->

# Windows.UI.Xaml.Automation.Provider.ITextRangeProvider.GetBoundingRectangles

## -description
Retrieves a collection of bounding rectangles for each fully or partially visible line of text in a text range.



## -parameters
### -param returnValue
An array of bounding rectangles for each full or partial line of text in a text range. An empty array for a degenerate range. An empty array for a text range that has screen coordinates placing it completely off-screen, scrolled out of view, or obscured by an overlapping window. 
<!--These are doubles not rects, so something is amiss or could be clarified, but this exactly how it is for .NET.-->

## -remarks

## -examples

## -see-also
