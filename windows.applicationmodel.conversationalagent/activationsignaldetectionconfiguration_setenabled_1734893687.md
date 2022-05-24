---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.SetEnabled(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public void ActivationSignalDetectionConfiguration.SetEnabled(Boolean value)
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.SetEnabled

## -description

Enables or disables the configuration in an application-level manner, independent of system-level settings. The configuration must be both allowed and enabled for its associated [ActivationSignalDetector](activationsignaldetector.md).

> [!Important]
> To avoid possible concurrency issues, we recommend using [SetEnabledAsync](activationsignaldetectionconfiguration_setenabledasync_103285310.md) instead.

## -parameters

### -param value

True, if enabled. Otherwise, false.

## -remarks

Configuration might not be active even if configuration is enabled successfully. For configuration to be active, all necessary resources must be available and configuration permissions must be granted by the user in Settings.

## -see-also

[SetEnabledAsync](activationsignaldetectionconfiguration_setenabledasync_103285310.md), [SetEnabledWithResult(System.Boolean)](activationsignaldetectionconfiguration_setenabledwithresult_1176849337.md), [SetEnabledWithResultAsync(System.Boolean)](activationsignaldetectionconfiguration_setenabledwithresultasync_1777466107.md)

## -examples
