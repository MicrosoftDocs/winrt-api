---
-api-id: T:Windows.UI.Core.ICorePointerRedirector
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ICorePointerRedirector : 
-->

# Windows.UI.Core.ICorePointerRedirector

## -description
Defines pointer events for cross-process input handling.

An implementation of the ICorePointerRedirector interface is provided by the [CoreWindow](corewindow.md) class.

Input chaining refers to the interaction behavior of both a parent object (host) and a nested child object (component) when an input boundary is reached.

In a single process, chaining embedded (or nested) content is managed by the system (through [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal)).

For cross-process chaining, the pointer events defined in this interface provide input routing details.

## -remarks

## -examples

## -see-also
[Windows.UI.Core](windows_ui_core.md)
