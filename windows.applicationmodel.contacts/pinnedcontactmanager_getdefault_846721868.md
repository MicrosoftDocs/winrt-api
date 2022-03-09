---
-api-id: M:Windows.ApplicationModel.Contacts.PinnedContactManager.GetDefault
-api-type: winrt method
---

<!-- Method syntax.
public PinnedContactManager PinnedContactManager.GetDefault()
-->

# Windows.ApplicationModel.Contacts.PinnedContactManager.GetDefault

## -description

Gets the default instance of a [PinnedContactManager](pinnedcontactmanager.md).

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -returns

the default [PinnedContactManager](pinnedcontactmanager.md).

## -remarks

This method must be called from the main UI thread.

## -see-also

## -examples

## -capabilities

contactsSystem

