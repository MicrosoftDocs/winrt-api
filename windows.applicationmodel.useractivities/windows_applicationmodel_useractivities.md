---
-api-id: N:Windows.ApplicationModel.UserActivities
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.ApplicationModel.UserActivities
-->

# Windows.ApplicationModel.UserActivities

## -description

A User Activity encapsulates a user task that can be continued at a later time, and potentially on a different device.

For example, a mail app could create a User Activity when the user starts creating a new email message. The user could pause working on the email and start working on it again later on the same machine, or resume the activity of writing the email on another device.

The APIs in this namespace allow developers to:
- Create User Activities
- Provide a cross-platform context for User Activities.
- Start and stop Activities

See [Continue user activity, even across devices](/windows/uwp/launch-resume/useractivities) for more information about how to use User Activities with Windows Timeline to help users resume what they were doing on their PC, and across devices.

## -see-also

[UserActivity sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserActivity)