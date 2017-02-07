using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Controls.Primitives;

namespace RichNotepad
{
    // This is an abstract base class that captures the building block functionality for a context menu
    // including constructing and displaying a blank menu and method for closing the menu (called by default when 
    // the mouse is clicked outside the context menu

    // Note that though this class is called ContextMenu after the most common usage for this pattern, you can use this
    // popup window to display any arbitrary control(s)/ 

    // A child class will have to implement the GetContent() method to return a FrameworkElement 
    // that encapsulates the controls that you need to be displayed on the context menu. 

    public abstract class ContextMenu
    {
        private Point _location;
        private bool _isShowing;
        private Popup _popup;
        private Grid _grid;
        private Canvas _canvas;
        private FrameworkElement _content;

        //<SnippetShow>
        //Intiialize and show the popup window. This is the public method to call, to display the ContextMenu at the desired location. 
        public void Show(Point location)
        {
            if (_isShowing)
                throw new InvalidOperationException();

            _isShowing = true;
            _location = location;
            ConstructPopup();
            _popup.IsOpen = true;
        }
        //</SnippetShow>

        //Close the popup window
        public void Close()
        {
            _isShowing = false;

            if (_popup != null)
            {
                _popup.IsOpen = false;
            }
        }

        //<SnippetGetContent1>
        //Abstract function that the child class needs to implement to return the framework element that needs to be displayed in the popup window.
        protected abstract FrameworkElement GetContent();
        //</SnippetGetContent1>

        //Default behavior for OnClickOutside() is to close the context menu when there is a mouse click event outside the context menu
        protected virtual void OnClickOutside() 
        {
            Close();
        }

        // Construct a popup window thats the size of the application with a grid layout
        // Add a canvas as a child of the grid layout to detect mouse clicks outside the context menu
        // Add the Framework Element returned by GetContent() to the grid and position it at _location

        private void ConstructPopup()
        {
            if (_popup != null)
                return;

            _popup = new Popup();
            _grid = new Grid();

            _popup.Child = _grid;

            _canvas = new Canvas();

            _canvas.PointerPressed += (sender, args) => { OnClickOutside(); };
            _canvas.RightTapped += (sender, args) => { args.Handled = true; OnClickOutside(); };

            _canvas.Background = new SolidColorBrush(Colors.Transparent);

            _grid.Children.Add(_canvas);

            _content = GetContent();

            _content.HorizontalAlignment = HorizontalAlignment.Left;
            _content.VerticalAlignment = VerticalAlignment.Top;
            _content.Margin = new Thickness(_location.X, _location.Y, 0, 0);


            _grid.Children.Add(_content);

            UpdateSize();
        }

        private void UpdateSize()
        {
            _grid.Width = Application.Current.Host.Content.ActualWidth;
            _grid.Height = Application.Current.Host.Content.ActualHeight;

            if (_canvas != null)
            {
                _canvas.Width = _grid.Width;
                _canvas.Height = _grid.Height;
            }
        }
    }
}
