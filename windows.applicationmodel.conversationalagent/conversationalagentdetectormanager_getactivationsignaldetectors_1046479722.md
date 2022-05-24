---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentDetectorManager.GetActivationSignalDetectors(Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectorKind)
-api-type: winrt method
---

<!-- Method syntax.
public IVectorView<ActivationSignalDetector> ConversationalAgentDetectorManager.GetActivationSignalDetectors(ActivationSignalDetectorKind kind)
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentDetectorManager.GetActivationSignalDetectors

## -description

Retrieves all [ActivationSignalDetector](activationsignaldetector.md) objects available on the system that are associated with this manager.

> [!Important]
> To avoid possible concurrency issues, we recommend using [GetActivationSignalDetectorsAsync](conversationalagentdetectormanager_getactivationsignaldetectorsasync_591441886.md) instead.

## -parameters

### -param kind

A supported [ActivationSignalDetector](activationsignaldetector.md) type.

## -returns

When this method completes successfully, it returns an activation signal detector.

## -remarks

## -see-also

[GetActivationSignalDetectorsAsync](conversationalagentdetectormanager_getactivationsignaldetectorsasync_591441886.md), [ActivationSignalDetector](activationsignaldetector.md)

## -examples
