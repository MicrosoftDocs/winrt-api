---
-api-id: T:Windows.UI.Xaml.Controls.Frame
-api-type: winrt class
---

<!-- Class syntax.
public class Frame : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IFrame, Windows.UI.Xaml.Controls.IFrame2, Windows.UI.Xaml.Controls.IFrame3, Windows.UI.Xaml.Controls.IFrame4, Windows.UI.Xaml.Controls.INavigate
-->

# Windows.UI.Xaml.Controls.Frame

## -description
Displays [Page](page.md) instances, supports navigation to new pages, and maintains a navigation history to support forward and backward navigation.



## -xaml-syntax
```xaml
<Frame .../>
```

## -remarks
You use the Frame control to support navigation to [Page](page.md) instances. You create as many different page types as needed to present the content in your app, and then navigate to those pages by calling the [Navigate](frame_navigate_1426351961.md) method and passing in the type of the page to navigate to. You can also pass in a parameter object to initialize the page to a particular state.

The frame maintains a history of pages it has navigated to. You can get the type of the current page through the [CurrentSourcePageType](frame_currentsourcepagetype.md) property, and navigate forward or backward with the [GoBack](frame_goback_1030386674.md) and [GoForward](frame_goforward_1537152893.md) methods. The [CanGoBack](frame_cangoback.md) and [CanGoForward](frame_cangoforward.md) properties indicate whether a page is available in the desired direction. One common practice is to bind the [IsEnabled](control_isenabled.md) properties of navigation buttons to [CanGoBack](frame_cangoback.md) and [CanGoForward](frame_cangoforward.md) so that users can't navigate to a page that doesn't exist.

You can handle the [Navigating](frame_navigating.md), [Navigated](frame_navigated.md), [NavigationStopped](frame_navigationstopped.md), and [NavigationFailed](frame_navigationfailed.md) events to perform high-level tasks such as starting and stopping a "navigation in progress" animation or displaying an error message. For page-level tasks, override the page [OnNavigatedTo](page_onnavigatedto_1083052518.md), [OnNavigatingFrom](page_onnavigatingfrom_425696585.md), and [OnNavigatedFrom](page_onnavigatedfrom_1389759661.md) methods. This is useful to perform tasks such as initializing and saving the page state.

By default, each navigation creates a new instance of the specific [Page](page.md) subclass requested, and disposes the previous page instance. This happens even when navigating back to a previously visited page or when the new page type is the same as the previous page type. Apps that involve frequent navigation to the same pages can cache and reuse the page instances to make navigation more efficient. To do this, set the [CacheSize](frame_cachesize.md) property to specify how many pages to cache. For each page type that you want to cache, you must also set the [Page.NavigationCacheMode](page_navigationcachemode.md) property to either **Enabled** or **Required**. Pages with a **Required** cache mode are cached regardless of the [CacheSize](frame_cachesize.md) value, and do not count against the [CacheSize](frame_cachesize.md) total.

### INavigate

The [INavigate](inavigate.md) interface is mainly infrastructure. It's not expected that typical app will implement this interface.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | SetNavigationState(String,Boolean) |
| 1809 | 17763 | IsNavigationStackEnabled |
| 1809 | 17763 | NavigateToType |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see the [Navigation design basics overview](/windows/uwp/design/basics/navigation-basics).
>
> If you have the **WinUI 2 Gallery** app installed, [open the app to see Page and Frame features in action](winui2gallery:).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

The following code example is from the Blank App template in Microsoft Visual Studio. This code shows how an [OnLaunched](../windows.ui.xaml/application_onlaunched_859642554.md) method override initializes the app window. If the app is resuming after being suspended, then the window might already be initialized. If not, this code sets the app window to a new Frame, then navigates the frame to the default initial page.

```csharp
protected override void OnLaunched(LaunchActivatedEventArgs e)
{
    Frame rootFrame = Window.Current.Content as Frame;

    // Do not repeat app initialization when the Window already has content,
    // just ensure that the window is active.
    if (rootFrame == null)
    {
        // Create a Frame to act as the navigation context and navigate to the first page.
        rootFrame = new Frame();

        rootFrame.NavigationFailed += OnNavigationFailed;

        if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
        {
            //TODO: Load state from previously suspended application.
        }

        // Place the frame in the current Window.
        Window.Current.Content = rootFrame;
    }

    if (rootFrame.Content == null)
    {
        // When the navigation stack isn't restored navigate to the first page,
        // configuring the new page by passing required information as a navigation
        // parameter.
        rootFrame.Navigate(typeof(MainPage), e.Arguments);
    }

    // Ensure the current window is active.
    Window.Current.Activate();
}

void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
{
    throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
}
```

```cppwinrt
void App::OnLaunched(LaunchActivatedEventArgs const& e)
{
    Frame rootFrame{ nullptr };
    auto content = Window::Current().Content();
    if (content)
    {
        rootFrame = content.try_as<Frame>();
    }

    // Do not repeat app initialization when the Window already has content,
    // just ensure that the window is active
    if (rootFrame == nullptr)
    {
        // Create a Frame to act as the navigation context and associate it with
        // a SuspensionManager key
        rootFrame = Frame();

        rootFrame.NavigationFailed({ this, &App::OnNavigationFailed });

        if (e.PreviousExecutionState() == ApplicationExecutionState::Terminated)
        {
            // Restore the saved session state only when appropriate, scheduling the
            // final launch steps after the restore is complete
        }

        if (e.PrelaunchActivated() == false)
        {
            if (rootFrame.Content() == nullptr)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                rootFrame.Navigate(xaml_typename<BlankApp1::MainPage>(), box_value(e.Arguments()));
            }
            // Place the frame in the current Window
            Window::Current().Content(rootFrame);
            // Ensure the current window is active
            Window::Current().Activate();
        }
    }
    else
    {
        if (e.PrelaunchActivated() == false)
        {
            if (rootFrame.Content() == nullptr)
            {
                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter
                rootFrame.Navigate(xaml_typename<BlankApp1::MainPage>(), box_value(e.Arguments()));
            }
            // Ensure the current window is active
            Window::Current().Activate();
        }
    }
}

void App::OnNavigationFailed(IInspectable const&, NavigationFailedEventArgs const& e)
{
    throw hresult_error(E_FAIL, hstring(L"Failed to load Page ") + e.SourcePageType().Name);
}
```

```cppcx
void App::OnLaunched(LaunchActivatedEventArgs^ e)
{
 auto rootFrame = dynamic_cast<Frame^>(Window::Current->Content);
 
 // Do not repeat app initialization when the Window already has content,
 // just ensure that the window is active
 if (rootFrame == nullptr)
 {
  // Create a Frame to act as the navigation context and associate it with
  // a SuspensionManager key
  rootFrame = ref new Frame();

  rootFrame->NavigationFailed += ref new Windows::UI::Xaml::Navigation::NavigationFailedEventHandler(this, &App::OnNavigationFailed);

  if (e->PreviousExecutionState == ApplicationExecutionState::Terminated)
  {
   // TODO: Restore the saved session state only when appropriate, scheduling the
   // final launch steps after the restore is complete
  }

  if (rootFrame->Content == nullptr)
  {
   // When the navigation stack isn't restored navigate to the first page,
   // configuring the new page by passing required information as a navigation
   // parameter
   rootFrame->Navigate(TypeName(MainPage::typeid), e->Arguments);
  }
  // Place the frame in the current Window
  Window::Current->Content = rootFrame;
  // Ensure the current window is active
  Window::Current->Activate();
 }
 else
 {
  if (rootFrame->Content == nullptr)
  {
   // When the navigation stack isn't restored navigate to the first page,
   // configuring the new page by passing required information as a navigation
   // parameter
   rootFrame->Navigate(TypeName(MainPage::typeid), e->Arguments);
  }
  // Ensure the current window is active
  Window::Current->Activate();
 }
}

void App::OnNavigationFailed(Platform::Object ^sender, Windows::UI::Xaml::Navigation::NavigationFailedEventArgs ^e)
{
 throw ref new FailureException("Failed to load Page " + e->SourcePageType.Name);
}
```

```vb
Protected Overrides Sub OnLaunched(e As LaunchActivatedEventArgs)
    Dim rootFrame As Frame = TryCast(Window.Current.Content, Frame)

    ' Do not repeat app initialization when the Window already has content,
    ' just ensure that the window is active.

    If rootFrame Is Nothing Then
        ' Create a Frame to act as the navigation context and navigate to the first page.
        rootFrame = New Frame()

        AddHandler rootFrame.NavigationFailed, AddressOf OnNavigationFailed

        If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then
            ' TODO: Load state from previously suspended application.
        End If
        ' Place the frame in the current Window.
        Window.Current.Content = rootFrame
    End If
    If rootFrame.Content Is Nothing Then
        ' When the navigation stack isn't restored navigate to the first page,
        ' configuring the new page by passing required information as a navigation
        ' parameter.
        rootFrame.Navigate(GetType(MainPage), e.Arguments)
    End If

    ' Ensure the current window is active.
    Window.Current.Activate()
End Sub

Private Sub OnNavigationFailed(sender As Object, e As NavigationFailedEventArgs)
    Throw New Exception("Failed to load Page " + e.SourcePageType.FullName)
End Sub
```

## -see-also
[Page](page.md), [ContentControl](contentcontrol.md), [INavigate](inavigate.md)
