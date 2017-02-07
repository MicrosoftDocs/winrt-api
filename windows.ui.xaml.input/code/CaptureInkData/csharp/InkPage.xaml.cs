// <SnippetCSInkPageComplete>
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// <SnippetNamespaces>
// <SnippetInkingNamespace>
using Windows.UI.Input.Inking;
// </SnippetInkingNamespace>
using Windows.Devices.Input;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Input;

using Windows.UI.Xaml.Shapes;
// </SnippetNamespaces>

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CaptureInkData
{
    public sealed partial class InkPage : Page
    {
        InkPage rootPage = null;

        // Scenario specific constants and variables.
        const double STROKETHICKNESS = 5;
        Point _previousContactPt;
        uint _penID = 0;
        uint _touchID = 0;

        // Create the InkManager instance.
        // <SnippetCreateInkManager>
        InkManager _inkManager = new Windows.UI.Input.Inking.InkManager();
        // </SnippetCreateInkManager>

        public InkPage()
        {
            this.InitializeComponent();

            // Add pointer event handlers to the Canvas object.
            // <SnippetAddEventHandlers>
            InkCanvas.PointerPressed += new PointerEventHandler(InkCanvas_PointerPressed);
            InkCanvas.PointerMoved += new PointerEventHandler(InkCanvas_PointerMoved);
            InkCanvas.PointerReleased += new PointerEventHandler(InkCanvas_PointerReleased);
            InkCanvas.PointerExited += new PointerEventHandler(InkCanvas_PointerReleased);
            // </SnippetAddEventHandlers>
        }

        // Initiate ink capture.
        // <SnippetPointerPressedHandler>     
        public void InkCanvas_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            // Get information about the pointer location.
            PointerPoint pt = e.GetCurrentPoint(InkCanvas);
            _previousContactPt = pt.Position;

            // Accept input only from a pen or mouse with the left button pressed. 
            PointerDeviceType pointerDevType = e.Pointer.PointerDeviceType;
            if (pointerDevType == PointerDeviceType.Pen ||
                    pointerDevType == PointerDeviceType.Mouse &&
                    pt.Properties.IsLeftButtonPressed)
            {
                // Pass the pointer information to the InkManager.
                _inkManager.ProcessPointerDown(pt);
                _penID = pt.PointerId;

                e.Handled = true;
            }

            else if (pointerDevType == PointerDeviceType.Touch)
            {
                // Process touch input
            }
        }
        // </SnippetPointerPressedHandler>  


        // Draw on the canvas and capture ink data as the pointer moves.
        // <SnippetPointerMovedHandler>
        public void InkCanvas_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerId == _penID)
            {
                PointerPoint pt = e.GetCurrentPoint(InkCanvas);

                // Render a red line on the canvas as the pointer moves. 
                // Distance() is an application-defined function that tests
                // whether the pointer has moved far enough to justify 
                // drawing a new line.
                Point currentContactPt = pt.Position;
                if (Distance(currentContactPt, _previousContactPt) > 2)
                {
                    Line line = new Line()
                    {
                        X1 = _previousContactPt.X,
                        Y1 = _previousContactPt.Y,
                        X2 = currentContactPt.X,
                        Y2 = currentContactPt.Y,
                        StrokeThickness = STROKETHICKNESS,
                        Stroke = new SolidColorBrush(Windows.UI.Colors.Red)
                    };

                    _previousContactPt = currentContactPt;

                    // Draw the line on the canvas by adding the Line object as
                    // a child of the Canvas object.
                    InkCanvas.Children.Add(line);

                    // Pass the pointer information to the InkManager.
                    _inkManager.ProcessPointerUpdate(pt);
                }
            }

            else if (e.Pointer.PointerId == _touchID)
            {
                // Process touch input
            }

            e.Handled = true;
        }
        // </SnippetPointerMovedHandler>

        // Finish capturing ink data and use it to render ink strokes on 
        // the canvas. 
        // <SnippetPointerReleasedHandler>
        public void InkCanvas_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (e.Pointer.PointerId == _penID)
            {
                PointerPoint pt = e.GetCurrentPoint(InkCanvas);

                // Pass the pointer information to the InkManager. 
                _inkManager.ProcessPointerUp(pt);
            }

            else if (e.Pointer.PointerId == _touchID)
            {
                // Process touch input
            }

            _touchID = 0;
            _penID = 0;

            // Call an application-defined function to render the ink strokes.
            RenderAllStrokes();

            e.Handled = true;
        }
        // </SnippetPointerReleasedHandler>

        // Render ink strokes as cubic bezier segments.
        // <SnippetRenderAllStrokes> 
        private void RenderAllStrokes()
        {
            // Clear the canvas.
            InkCanvas.Children.Clear();

            // Get the InkStroke objects.
            IReadOnlyList<InkStroke> inkStrokes = _inkManager.GetStrokes();

            // Process each stroke.
            foreach (InkStroke inkStroke in inkStrokes)
            {
                PathGeometry pathGeometry = new PathGeometry();
                PathFigureCollection pathFigures = new PathFigureCollection();
                PathFigure pathFigure = new PathFigure();
                PathSegmentCollection pathSegments = new PathSegmentCollection();

                // Create a path and define its attributes.
                Windows.UI.Xaml.Shapes.Path path = new Windows.UI.Xaml.Shapes.Path();
                path.Stroke = new SolidColorBrush(Colors.Red);
                path.StrokeThickness = STROKETHICKNESS;

                // Get the stroke segments.
                IReadOnlyList<InkStrokeRenderingSegment> segments;
                segments = inkStroke.GetRenderingSegments();

                // Process each stroke segment.
                bool first = true;
                foreach (InkStrokeRenderingSegment segment in segments)
                {
                    // The first segment is the starting point for the path.
                    if (first)
                    {
                        pathFigure.StartPoint = segment.BezierControlPoint1;
                        first = false;
                    }

                    // Copy each ink segment into a bezier segment.
                    BezierSegment bezSegment = new BezierSegment();
                    bezSegment.Point1 = segment.BezierControlPoint1;
                    bezSegment.Point2 = segment.BezierControlPoint2;
                    bezSegment.Point3 = segment.Position;

                    // Add the bezier segment to the path.
                    pathSegments.Add(bezSegment);
                }

                // Build the path geometerty object.
                pathFigure.Segments = pathSegments;
                pathFigures.Add(pathFigure);
                pathGeometry.Figures = pathFigures;

                // Assign the path geometry object as the path data.
                path.Data = pathGeometry;

                // Render the path by adding it as a child of the Canvas object.
                InkCanvas.Children.Add(path);
            }
        }
        // </SnippetRenderAllStrokes> 

        // <SnippetDistance> 
        private double Distance(Point currentContact, Point previousContact)
        {
            return Math.Sqrt(Math.Pow(currentContact.X - previousContact.X, 2) +
                    Math.Pow(currentContact.Y - previousContact.Y, 2));
        }
        // </SnippetDistance> 
        #region Template-Related Code - Do not remove
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Get a pointer to our main page
            rootPage = e.Parameter as InkPage;
        }
        #endregion

        /// <summary>
        /// Handles when the Save button is clicked on the app bar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        // <Snippetcs_show_savepicker>
        async void Save_Click(object sender, RoutedEventArgs e)
        {
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            savePicker.FileTypeChoices.Add("GIF file", new List<string>() { ".gif" });
            savePicker.DefaultFileExtension = ".gif";
            savePicker.SuggestedFileName = "New Ink Image";

            StorageFile savedItem = await savePicker.PickSaveFileAsync();
            if (null != savedItem)
            {
                WriteInk(savedItem);
            }
        }
        // </Snippetcs_show_savepicker>

        // <Snippetcs_write_ink>
        async void WriteInk(StorageFile storageFile)
        {
            if (storageFile != null)
            {
                IRandomAccessStream writeStream = await storageFile.OpenAsync(FileAccessMode.ReadWrite);
                IOutputStream outputStream = writeStream.GetOutputStreamAt(0);
                await _inkManager.SaveAsync(outputStream);
                await outputStream.FlushAsync();

                Windows.Storage.FileProperties.BasicProperties props = await storageFile.GetBasicPropertiesAsync();

                // Call an application-defined function to display the file size.
                DisplayStatus("Saved " + props.Size.ToString() + " bytes.");
            }
        }
        // </Snippetcs_write_ink>

        // <Snippetcs_show_openpicker>
        async void Load_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.List;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Clear();
            openPicker.FileTypeFilter.Add(".gif");
            StorageFile openedItem = await openPicker.PickSingleFileAsync();
            if (null != openedItem)
            {
                ReadInk(openedItem);
            }
        }
        // </Snippetcs_show_openpicker>

        // <Snippetcs_read_ink>
        async void ReadInk(StorageFile storageFile)
        {
            if (storageFile != null)
            {
                IRandomAccessStream readStream = await storageFile.OpenAsync(FileAccessMode.Read);
                IInputStream inputStream = readStream.GetInputStreamAt(0);
                await _inkManager.LoadAsync(inputStream);

                IReadOnlyList<InkStroke> strokes = _inkManager.GetStrokes();
                int c = strokes.Count;
                if (c == 0)
                {
                    DisplayStatus("File does not contain any ink strokes.");
                }
                else
                {
                    DisplayStatus("Loaded " + c + " strokes.");
                    RenderAllStrokes();
                }

                Windows.Storage.FileProperties.BasicProperties props = await storageFile.GetBasicPropertiesAsync();

                // Call an application-defined function to display the file size.
                DisplayStatus("Loaded " + props.Size.ToString() + " bytes.");
            }
        }
        // </Snippetcs_read_ink>

        async void DisplayStatus(String message)
        {
            Windows.UI.Popups.MessageDialog messagePopup = new Windows.UI.Popups.MessageDialog(message, "Status");
            await messagePopup.ShowAsync();
        }


    }
}
// </SnippetCSInkPageComplete>
