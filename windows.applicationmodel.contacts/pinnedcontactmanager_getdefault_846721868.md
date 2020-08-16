---
-api-id: M:Windows.ApplicationModel.Contacts.PinnedContactManager.GetDefault
-api-type: winrt method
---

<!-- Method syntax.
public PinnedContactManager PinnedContactManager.GetDefault()
-->

# Windows.ApplicationModel.Contacts.PinnedContactManager.GetDefault


## -description

Gets the default an instance of a [PinnedContactManager](pinnedcontactmanager.md).

## -returns

the default [PinnedContactManager](pinnedcontactmanager.md).

## -remarks

This method must be called from the main UI thread.

To use this object from a desktop app, use [the IInitializeWithWindow::Initialize method](https://docs.microsoft.com/en-us/windows/desktop/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) to associate the object with a window handle.

## -see-also

## -examples

## -capabilities

contactsSystem

