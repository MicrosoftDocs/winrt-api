---
-api-id: P:Windows.System.Profile.WindowsIntegrityPolicy.IsDisableSupported
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsDisableSupported { get; }
-->

# Windows.System.Profile.WindowsIntegrityPolicy.IsDisableSupported

## -description
Gets a value that indicates (see Remarks for other necessary conditions) whether or not there is any published way, or API, for third-party vendors to disable Windows 10 secure mode (10 S mode) at run time.

## -property-value
`true` (but see Remarks for other necessary conditions) if there is any published way, or API, for third-party vendors to disable Windows 10 secure mode (10 S mode) at run time, otherwise `false`.

## -remarks
If **IsDisableSupported** is `true`, and [IsEnabled](windowsintegritypolicy_isenabled.md) or [IsEnabledForTrial](windowsintegritypolicy_isenabledfortrial.md) is `true`, and [CanDisable](windowsintegritypolicy_candisable.md) is true, then there is a published way, or API, for third-party vendors to disable Windows 10 secure mode (10 S mode) at run time.

## -see-also

## -examples

