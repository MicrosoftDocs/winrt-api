---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentDetectorManager.GetActivationSignalDetectorFromId(System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentDetectorManager.GetActivationSignalDetectorFromId(System.String)

<!--
public Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector GetActivationSignalDetectorFromId (string detectorId);
-->

## -description

Retrieves the [ActivationSignalDetector](activationsignaldetector.md) object available on the system that is associated with this manager and that has the [ActivationSignalDetector.DetectorId](activationsignaldetector_detectorid.md) specified.

> [!Important]
> To avoid possible concurrency issues, we recommend using [GetActivationSignalDetectorFromIdAsync(System.String)](conversationalagentdetectormanager_getactivationsignaldetectorfromidasync_78182550.md) instead.

## -parameters

### -param detectorId

The unique identifier of the [ActivationSignalDetector](activationsignaldetector.md).

## -returns

The hardware or software component that generated the activation signal based on input from the user's environment, such as spoken keyword(s), sound detection, or button press.

## -remarks

## -see-also

[GetActivationSignalDetectorFromIdAsync(System.String)](conversationalagentdetectormanager_getactivationsignaldetectorfromidasync_78182550.md)

## -examples
