---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.SetEnabledAsync(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction ActivationSignalDetectionConfiguration.SetEnabledAsync(Boolean value)
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetectionConfiguration.SetEnabledAsync

## -description

Asynchronously enables or disables the configuration in an application-level manner, independent of system-level settings. The configuration must be both allowed and enabled for its associated [ActivationSignalDetector](activationsignaldetector.md).

## -parameters

### -param value

True, if enabled. Otherwise, false.

## -returns

Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks

Configuration might not be active even if configuration is enabled successfully. For configuration to be active, all necessary resources must be available and configuration permissions must be granted by the user in Settings.

## -see-also

[DetectionConfigurationAvailabilityInfo](detectionconfigurationavailabilityinfo.md), [SetEnabled](activationsignaldetectionconfiguration_setenabled_1734893687.md) [SetEnabledWithResult(System.Boolean)](activationsignaldetectionconfiguration_setenabledwithresult_1176849337.md), [SetEnabledWithResultAsync(System.Boolean)](activationsignaldetectionconfiguration_setenabledwithresultasync_1777466107.md)

## -examples
