---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivityRequestManager.GetForCurrentView()
-api-type: winrt method
---

<!-- Method syntax.
public void UserActivityRequestManager.GetForCurrentView()
-->

# Windows.ApplicationModel.UserActivities.UserActivityRequestManager.GetForCurrentView

## -description
Gets the [UserActivityRequestManager](useractivityrequestmanager.md) associated with the current view.

## -parameters
### -param value
On return, set to the **UserActivityRequestManager** for the current view.

## -remarks

## -see-also

## -examples

```csharp
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    Windows.ApplicationModel.UserActivities.UserActivityRequestManager requestMgr = Windows.ApplicationModel.UserActivities.UserActivityRequestManager.GetForCurrentView();
}
```
