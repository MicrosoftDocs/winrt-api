---
-api-id: M:Windows.UI.Shell.FocusSessionManager.TryStartFocusSession(Windows.Foundation.DateTime)
-api-type: winrt method
---

# Windows.UI.Shell.FocusSessionManager.TryStartFocusSession(Windows.Foundation.DateTime)

<!--
public Windows.UI.Shell.FocusSession TryStartFocusSession (System.DateTimeOffset endTime);
-->


## -description

Attempts to start a focus session that is active until explicitly cancelled.

> [!IMPORTANT]
> The **FocusSessionManager.TryStartFocusSession** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param endTime

The end time for the created focus session.

## -returns

A [FocusSession](focussession.md) object if a focus session was successfully started; otherwise, null.

## -remarks

## -see-also

## -examples


