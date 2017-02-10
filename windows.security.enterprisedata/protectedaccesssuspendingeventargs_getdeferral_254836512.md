---
-api-id: M:Windows.Security.EnterpriseData.ProtectedAccessSuspendingEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Deferral GetDeferral()
-->

# Windows.Security.EnterpriseData.ProtectedAccessSuspendingEventArgs.GetDeferral

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Gets the [Deferral](../windows.foundation/deferral.md) object that manages the protection suspension. The app must call **Deferral.Complete** before it returns from the event handler.

## -returns
The [Deferral](../windows.foundation/deferral.md) object.

## -remarks

## -examples

## -see-also
