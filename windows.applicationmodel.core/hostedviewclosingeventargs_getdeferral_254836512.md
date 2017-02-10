---
-api-id: M:Windows.ApplicationModel.Core.HostedViewClosingEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Deferral GetDeferral()
-->

# Windows.ApplicationModel.Core.HostedViewClosingEventArgs.GetDeferral

## -description
Provides an opportunity for hosted window scenarios to defer the tear down of the window, dispatcher, and Application Single-Threaded Apartment (ASTA) thread of the hosted view.

## -returns
The deferral you can call to defer the tear down of the hosted view.

## -remarks
If the deferral is taken, the hosted view's window, dispatcher, and Application Single-Threaded Apartment (ASTA) thread will not be torn down until the deferral is completed or a timeout value expires.

## -examples

## -see-also
