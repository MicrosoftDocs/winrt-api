---
-api-id: M:Windows.UI.Shell.WindowTabManager.IsSupported
-api-type: winrt method
---

# Windows.UI.Shell.WindowTabManager.IsSupported

<!--
public static bool IsSupported ();
-->

## -description

Gets a value that indicates whether tab management is supported by the current system shell.

## -returns

`true` if tab management is supported by the current system shell; otherwise, `false`.

## -remarks

Call `IsSupported` to ensure that tab management is supported by the current system shell before you call [GetForWindow](windowtabmanager_issupported_930300905.md) to request an instance of `WindowTabManager`.

## -examples
