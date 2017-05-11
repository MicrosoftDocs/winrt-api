---
-api-id: P:Windows.ApplicationModel.UserActivities.UserActivity.ActivationUri
-api-type: winrt property
---

<!-- Property syntax.
public Uri ActivationUri { get;  set; }
-->

# Windows.ApplicationModel.UserActivities.UserActivity.ActivationUri

## -description

Gets and sets the activation Uniform Resource Identifier (URI).

## -property-value

The activation URI.

## -remarks

The activation URI provides a cross-platform activation context for the activity.

## -see-also

## -examples

If a **UserActivity** represented reading an RSS reader article, for example, you could  set the activation URI to the URI of the article so that when the user taps on the user activity tile in the Timeline, the RSS reader app is reactivated:

```cs
userActivity.ActivationUri = new Uri("rss-reader:article?" + article.Link);
```
