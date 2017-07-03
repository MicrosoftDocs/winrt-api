---
-api-id: M:Windows.Media.Core.InitializeMediaStreamSourceRequestedEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax.
public Deferral InitializeMediaStreamSourceRequestedEventArgs.GetDeferral()
-->

# Windows.Media.Core.InitializeMediaStreamSourceRequestedEventArgs.GetDeferral

## -description
Gets a [**Deferral**](https://docs.microsoft.com/en-us/uwp/api/windows.foundation.deferral) object that instructs the system to wait for the app service to complete media source stream initialization before continuing processing the request.

## -returns
A **Deferral** object.

## -remarks
You must request a deferral if your stream source initialization perfoms any asynchronous actions. Call [**Complete**](https://docs.microsoft.com/uwp/api/windows.foundation.deferral#Windows_Foundation_Deferral_Complete) when intitialization is complete to notify the system to continue processing the request.

## -see-also

## -examples

