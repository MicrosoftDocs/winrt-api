---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Deferral GetDeferral()
-->

# Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest.GetDeferral

## -description
Gets a Windows::Foundation::Deferral object to allow background processing if needed.

## -returns
The Deferral object.

## -remarks
When doing background processing, call GetDeferral() and store the result as well as the * PerceptionPropertyChangeRequest. When background processing is complete, set the Status on the PerceptionPropertyChangeRequest and call Complete() on the deferral before removing references to the objects.

## -examples

## -see-also
