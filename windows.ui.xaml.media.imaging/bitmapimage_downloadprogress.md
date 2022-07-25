---
-api-id: E:Windows.UI.Xaml.Media.Imaging.BitmapImage.DownloadProgress
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Media.Imaging.DownloadProgressEventHandler DownloadProgress
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.DownloadProgress

## -description
Occurs when a significant change has occurred in the download progress of the [BitmapImage](bitmapimage.md) content.



## -xaml-syntax
```xaml
<BitmapImage DownloadProgress="eventhandler"/>
```


## -remarks
For cases where the async loading and decoding of a [BitmapImage](bitmapimage.md) object are long enough to be noticeable to the user, an app can handle DownloadProgress on the source and display a [ProgressRing](../windows.ui.xaml.controls/progressring.md) or [ProgressBar](../windows.ui.xaml.controls/progressbar.md) to indicate the progress state. These might display in the UI region that the image eventually displays in, or somewhere else in the UI. Use [DownloadProgressEventArgs.Progress](downloadprogresseventargs_progress.md) to modify the UI for a [ProgressBar](../windows.ui.xaml.controls/progressbar.md).

## -examples
```csharp

// somewhere in initialization
bitmapImage.DownloadProgress += new EventHandler<DownloadProgressEventArgs>(bi_DownloadProgress);
bitmapImage.ImageOpened += new EventHandler<ExceptionRoutedEventArgs>(bi_ImageOpened);
...
//progressBar is an existing control defined in XAML or extracted from a XAML template

void bi_DownloadProgress(object sender, DownloadProgressEventArgs e)
{
     progressBar.Value = e.Progress;
}
void bi_ImageOpened(object sender, RoutedEventArgs e)
{
     progressBar.Visibility = Visibility.Collapsed;
}
```



## -see-also
[DownloadProgressEventArgs](downloadprogresseventargs.md), [ProgressBar](../windows.ui.xaml.controls/progressbar.md)
