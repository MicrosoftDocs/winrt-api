---
-api-id: P:Windows.UI.Xaml.Input.GettingFocusEventArgs.Cancel
-api-type: winrt property
---

<!-- Property syntax.
public bool Cancel { get;  set; }
-->

# Windows.UI.Xaml.Input.GettingFocusEventArgs.Cancel

## -description

Gets or sets whether focus navigation should be canceled.



## -property-value

**true** if focus navigation should be canceled. Otherwise, **false**.

## -remarks

Apps that target Windows 10, version 1803 or later should use [TryCancel](gettingfocuseventargs_trycancel_50138317.md) instead of this property. If your app also supports previous versions, see [Version adaptive apps: Use new APIs while maintaining compatibility with previous versions](/windows/uwp/debug-test-perf/version-adaptive-apps) for more info.

## -see-also

[Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)

## -examples

