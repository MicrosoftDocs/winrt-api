---
-api-id: M:Windows.Web.UI.IWebViewControl.NavigateToString(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public void IWebViewControl.NavigateToString(String text)
-->

# Windows.Web.UI.IWebViewControl.NavigateToString

## -description
Loads the specified HTML content as a new document.

## -parameters
### -param text
The HTML content to display in the IWebViewControl.

## -remarks
**NavigateToString** is asynchronous. Use the [NavigationCompleted](iwebviewcontrol_navigationcompleted.md) event to detect when navigation has completed.

**NavigateToString** supports content with references to external files such as CSS, scripts, images, and fonts. However, it does not provide a way to generate or provide these resources programmatically. [NavigateToLocalStreamUri](iwebviewcontrol_navigatetolocalstreamuri_1538250901.md) provide this support instead.

## -see-also

## -examples

