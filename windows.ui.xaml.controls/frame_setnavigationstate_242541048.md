---
-api-id: M:Windows.UI.Xaml.Controls.Frame.SetNavigationState(System.String,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public void Frame.SetNavigationState(String navigationState, Boolean suppressNavigate)
-->

# Windows.UI.Xaml.Controls.Frame.SetNavigationState

## -description
Reads and restores the navigation history of a [Frame](frame.md) from a provided serialization string.

## -parameters
### -param navigationState
The serialization string that supplies the restore point for navigation history.

### -param suppressNavigate
**true** to restore navigation history without navigating to the current page; otherwise, **false**. 

## -remarks
If you call **SetNavigationState** with the **suppressNavigate** parameter set to **true**, [Page.OnNavigatedTo](page_onnavigatedto.md) is not called for the current page.

## -see-also

## -examples

