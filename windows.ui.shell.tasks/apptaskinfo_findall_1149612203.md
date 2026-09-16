---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskInfo.FindAll
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskInfo.FindAll

<!--
public static Windows.UI.Shell.Tasks.AppTaskInfo[] FindAll ();
-->


## -description

Returns all app tasks that were created by the current application.

## -returns

An array of [AppTaskInfo](apptaskinfo.md) objects that represent all tasks created by the app that have not been removed.

## -remarks

Use this method at app startup to enumerate existing tasks that may have been created previously. Tasks are persisted beyond the lifetime of the calling app and also persist through reboots. The returned collection includes tasks that have been hidden by the user. If [IsSupported](apptaskinfo_issupported_930300905.md) returns `false`, this method returns an empty collection.

## -see-also

## -examples


