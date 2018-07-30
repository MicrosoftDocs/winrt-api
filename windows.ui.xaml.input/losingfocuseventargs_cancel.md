---
-api-id: P:Windows.UI.Xaml.Input.LosingFocusEventArgs.Cancel
-api-type: winrt property
---

<!-- Property syntax.
public bool Cancel { get;  set; }
-->

# Windows.UI.Xaml.Input.LosingFocusEventArgs.Cancel

## -description
Gets or sets whether focus navigation should be canceled.

## -property-value
**true** if focus navigation should be canceled. Otherwise, **false**.

## -remarks
Apps that target the Windows 10, version 1803 or later should use [TryCancel](losingfocuseventargs_trycancel_50138317.md) instead of this property. If your app also supports previous versions, see [Version adaptive apps: Use new APIs while maintaining compatibility with previous versions](https://docs.microsoft.com/windows/uwp/debug-test-perf/version-adaptive-apps) for more info.

## -see-also
[Focus navigation for keyboard, gamepad, remote control, and accessibility tools](https://docs.microsoft.com/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](https://docs.microsoft.com/windows/uwp/design/input/focus-navigation-programmatic)

## -examples

