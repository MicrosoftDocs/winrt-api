---
-api-id: M:Windows.System.User.GetDefault
-api-type: winrt method
---

<!-- Method syntax.
public User User.GetDefault()
-->

# Windows.System.User.GetDefault

## -description
Provides a system managed default user that can be used in Multi-User Aware (MUA) apps.

## -returns
Returns the current user when called in a Single-User Aware (SUA) app; the default system managed account when called in a Multi-User Aware app.

## -remarks
For MUA apps, you sometimes need a default user. Rather than pass "null", which is equivalent to this default user in some APIs, but not others, use the default user returned by this method. This will simplify the logic for library developers who want to write APIs that work in MUA apps as well SUA apps, which run as the current user, without needing to specialize each case or handle a "null" default user.  

## -see-also

## -examples
