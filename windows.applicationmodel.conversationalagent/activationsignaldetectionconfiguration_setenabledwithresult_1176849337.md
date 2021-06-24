---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.SetEnabledWithResult(System.Boolean)
-api-type: winrt method
---

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.SetEnabledWithResult(System.Boolean)

<!--
public Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfigurationStateChangeResult SetEnabledWithResult (bool value);
-->

## -description

Enables or disables the configuration in an application-level manner, independent of system-level settings, and returns an indicator of success. The configuration must be both allowed and enabled for its associated [ActivationSignalDetector](activationsignaldetector.md).

> [!Important]
> To avoid possible concurrency issues, we recommend using [SetEnabledAsync](activationsignaldetectionconfiguration_setenabledasync_103285310.md) instead.

## -parameters

### -param value

True, if enabled. Otherwise, false.

## -returns

A value that indicates whether the call succeeded or the reason it failed.

## -remarks

Configuration might not be active even if configuration is enabled successfully. For configuration to be active, all necessary resources must be available and configuration permissions must be granted by the user in Settings.

## -see-also

[SetEnabledWithResultAsync(System.Boolean)](activationsignaldetectionconfiguration_setenabledwithresultasync_1777466107.md), [SetEnabled](activationsignaldetectionconfiguration_setenabled_1734893687.md), [SetEnabledAsync](activationsignaldetectionconfiguration_setenabledasync_103285310.md)

## -examples
