---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivityChannel.GetOrCreateUserActivityAsync(System.String,Windows.Networking.HostName)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<UserActivity> UserActivityChannel.GetOrCreateUserActivityAsync(String activityId, HostName host)
-->

# Windows.ApplicationModel.UserActivities.UserActivityChannel.GetOrCreateUserActivityAsync

## -description

Create (or get) a [UserActivity](useractivity.md) with the specified identifier and optional host information.

## -params

## -param activityId

The identifier for the **UserActivity**.

## -param host

Host information. See remarks.

## -returns

An existing **UserActivity** if the **activityId** and **host** name match; otherwise a new **UserActivity** that is given the specified id and host.

## -remarks

The _host_ parameter can be used to identify (or map the identities) of apps across platforms (Windows, iOS, and Android). The app publisher creates a JSON file on the host that contains the app identities for each platform.

Activity Feed services (AFS) use the host information to stamp a cross-platform app identity on an activity so that when the app for a particular platform calls GetOrCreateUserActivityAsync() to get an existing user activity, they get the one associated with the platform they are calling from.

## -see-also

## -examples
