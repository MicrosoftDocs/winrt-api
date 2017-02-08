---
-api-id: M:Windows.Media.Protection.MediaProtectionServiceCompletion.Complete(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void Complete(System.Boolean success)
-->

# Windows.Media.Protection.MediaProtectionServiceCompletion.Complete

## -description
Indicates whether a protection service has completed successfully.

## -parameters
### -param success
Indicates the successful completion of a protection service.

## -remarks
This method completes the interaction with the service request or component load failure. It should only be called when an interaction with the service request object or handling of component load failures is completed. If this method is not called at that time the media playback system will be stalled indefinitely.

## -examples

## -see-also
