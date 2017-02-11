---
-api-id: P:Windows.Networking.BackgroundTransfer.ResponseInformation.ActualUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri ActualUri { get; }
-->

# Windows.Networking.BackgroundTransfer.ResponseInformation.ActualUri

## -description
Gets the URI that contains the requested data.

## -property-value
The URI that contains the requested data.

## -remarks
If a request sent by an operation never gets redirected, the value of this property is the same as the URI specified in the operation constructor. If a request gets redirected, this property contains the URI that returned the requested data.

## -examples

## -see-also
