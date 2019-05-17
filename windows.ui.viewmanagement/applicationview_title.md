---
-api-id: P:Windows.UI.ViewManagement.ApplicationView.Title
-api-type: winrt property
---

<!-- Property syntax
public string Title { get;  set; }
-->

# Windows.UI.ViewManagement.ApplicationView.Title

## -description
Gets or sets the displayed title of the window.

## -property-value
The title of the window.

## -remarks
The Title property provides a title for the window.

When the Title property is not set, the system shows the app's display name in the title bar, as specified in the **Display name** field in the app manifest (Package.appxmanifest). When you set the Title property, Windows may choose to append the app display name to the end of the Title value you set.

We recommend that you set a title that describes the window, not the app. If you have an app that can have multiple documents open, each window should have the document title, which is considered more informative than just showing the app name.

For example, assume you have an app named, "My Notes App", with a window showing a document named "Note 1". You should set the Title property to "Note 1". Windows appends the app display name so the title bar shows "Note 1 - My Notes App".

This property is a nonstatic member of the window object. For JavaScript, this means that it is a method of the window object that [getForCurrentView](applicationview_getforcurrentview_1363600702.md) creates, and not a method of the [ApplicationView](applicationview.md) class.

## -examples

## -see-also
