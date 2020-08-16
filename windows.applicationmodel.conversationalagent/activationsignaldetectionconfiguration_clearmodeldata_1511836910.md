---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ClearModelData
-api-type: winrt method
---

<!-- Method syntax.
public void ActivationSignalDetectionConfiguration.ClearModelData()
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.ClearModelData

## -description

Deletes all model data for the digital assistant.

> [!Important]
> To avoid possible concurrency issues, we recommend using [ClearModelDataAsync](activationsignaldetectionconfiguration_clearmodeldataasync_1781166704.md) instead.

## -remarks

Digital assistant applications can train keyword detectors to more accurately recognize an individual user's voice by algorithmically applying customizations to the detector based on speech data.

This is achieved through a series of [ActivationSignalDetectionConfiguration](activationsignaldetectionconfiguration.md) training steps, where each step consumes a logical fragment of speech input data.  

## -see-also

[ClearModelDataAsync](activationsignaldetectionconfiguration_clearmodeldataasync_1781166704.md)

## -examples
