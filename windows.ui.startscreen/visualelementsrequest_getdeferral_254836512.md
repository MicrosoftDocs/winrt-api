---
-api-id: M:Windows.UI.StartScreen.VisualElementsRequest.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.StartScreen.VisualElementsRequestDeferral GetDeferral()
-->

# Windows.UI.StartScreen.VisualElementsRequest.GetDeferral

## -description
 Retrieves a deferral object, which allows the app time to provide information and assets used in the **Pin to Start**  flyout. 

## -returns
The deferral object.

## -remarks
If you call this method, you must follow it with a call to [Complete](visualelementsrequestdeferral_complete.md) before the deferral period times out. If you don't, any properties set during the deferral period are ignored.

## -examples

## -see-also
