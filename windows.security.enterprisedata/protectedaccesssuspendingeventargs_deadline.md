---
-api-id: P:Windows.Security.EnterpriseData.ProtectedAccessSuspendingEventArgs.Deadline
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime Deadline { get; }
-->

# Windows.Security.EnterpriseData.ProtectedAccessSuspendingEventArgs.Deadline

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

[DateTime](../windows.foundation/datetime.md) at which content protection will be suspended. The app can subtract **DateTime.Now** from this value to determine how much time there is to perform any processing before the suspension occurs.

## -property-value
[DateTime](../windows.foundation/datetime.md) at which content protection will be suspended.

## -remarks

## -examples

## -see-also
