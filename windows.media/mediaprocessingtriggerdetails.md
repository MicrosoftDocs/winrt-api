---
-api-id: T:Windows.Media.MediaProcessingTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class MediaProcessingTriggerDetails : Windows.Media.IMediaProcessingTriggerDetails
-->

# Windows.Media.MediaProcessingTriggerDetails

## -description
Provides a media processing background task access to the set of arguments supplied in the call to [MediaProcessingTrigger::RequestAsync](../windows.applicationmodel.background/mediaprocessingtrigger_requestasync_1089362155.md).

## -remarks
Get an instance of this class by casting the [TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md) property of the [IBackgroundTaskInstance](../windows.applicationmodel.background/ibackgroundtaskinstance.md) object, which is passed into the [Run](../windows.applicationmodel.background/ibackgroundtask_run.md) method of your background task, to a **MediaProcessingTriggerDetails** object.

## -examples

## -see-also
