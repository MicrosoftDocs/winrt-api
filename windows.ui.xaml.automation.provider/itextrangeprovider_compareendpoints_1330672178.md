---
-api-id: M:Windows.UI.Xaml.Automation.Provider.ITextRangeProvider.CompareEndpoints(Windows.UI.Xaml.Automation.Text.TextPatternRangeEndpoint,Windows.UI.Xaml.Automation.Provider.ITextRangeProvider,Windows.UI.Xaml.Automation.Text.TextPatternRangeEndpoint)
-api-type: winrt method
---

<!-- Method syntax
public int CompareEndpoints(Windows.UI.Xaml.Automation.Text.TextPatternRangeEndpoint endpoint, Windows.UI.Xaml.Automation.Provider.ITextRangeProvider textRangeProvider, Windows.UI.Xaml.Automation.Text.TextPatternRangeEndpoint targetEndpoint)
-->

# Windows.UI.Xaml.Automation.Provider.ITextRangeProvider.CompareEndpoints

## -description
Returns a value that indicates whether two text ranges have identical endpoints.



## -parameters
### -param endpoint
The **Start** or **End** endpoint of the caller.

### -param textRangeProvider
The target range for comparison.

### -param targetEndpoint
The **Start** or **End** endpoint of the target.

## -returns
Returns a negative value if the caller's endpoint occurs earlier in the text than the target endpoint. Returns zero if the caller's endpoint is at the same location as the target endpoint. Returns a positive value if the caller's endpoint occurs later in the text than the target endpoint.

## -remarks

## -examples

## -see-also
