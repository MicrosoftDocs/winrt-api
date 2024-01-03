---
-api-id: T:Windows.Security.Isolation.IsolatedWindowsEnvironmentClipboardCopyPasteDirections
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum IsolatedWindowsEnvironmentClipboardCopyPasteDirections : uint 
-->

# Windows.Security.Isolation.IsolatedWindowsEnvironmentClipboardCopyPasteDirections

## -description

**Deprecated.** Determines the direction in which copy pasting of content is allowed: host to Isolated Windows Environment or Isolated Windows Enviornment to host.

## -enum-fields

### -field None:0

Does not allow copy or paste.

### -field IsolatedWindowsEnvironmentToHost:2

Allow copy and paste from the Isolated Windows Environment to the host.

### -field HostToIsolatedWindowsEnvironment:1

Allow copy and paste from the host to the Isolated Windows Environment.

## -remarks

> [!WARNING]
> This is a deprecated API.

## -see-also

[Clipboard directions](isolatedwindowsenvironmentoptions_clipboardcopypastedirections.md)

## -examples
