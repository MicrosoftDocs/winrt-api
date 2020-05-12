---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.GetSupportedModelIdsForSignalId(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IVectorView<string> ActivationSignalDetector.GetSupportedModelIdsForSignalId(String signalId)
-->

# Windows.ApplicationModel.ConversationalAgent.ActivationSignalDetector.GetSupportedModelIdsForSignalId

## -description

Asynchronously gets the collection of model identifiers supported by this detector for the specified signal identifier. For example, all supported locales for language-specific versions of the "Hey Cortana" keyword.

> [!Important]
> To avoid possible concurrency issues, we recommend using [GetSupportedModelIdsForSignalIdAsync](activationsignaldetector_getsupportedmodelidsforsignalidasync_210362887.md) instead.

## -parameters

### -param signalId

The locale-independent identifier for this configuration.

## -returns

The collection of model identifiers supported through the specified signal.

## -remarks

## -see-also

[GetSupportedModelIdsForSignalIdAsync](activationsignaldetector_getsupportedmodelidsforsignalidasync_210362887.md)

## -examples
