using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using BlockPanelDemo;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BlockPanelDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage : Page
    {
        public BlankPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
    public class BlockPanel : Panel
    {
        public BlockPanel()
            : base()
        {
        }

        //<Snippet1>
        // First measure all children and return available size of panel
        protected override Size MeasureOverride(Size availableSize)
        {

            // Measure first 9 children giving them space up to 100x100, remaining children get 0x0 
            int i = 0;
            foreach (FrameworkElement child in Children)
            {
                if (i < 9)
                {
                    child.Measure(new Size(100, 100));
                }
                else
                {
                    child.Measure(new Size(0, 0));
                }

                i++;
            }


            // return the size available to the whole panel, which is 300x300
            return new Size(300, 300);
        }
        //</Snippet1>

        //<Snippet2>
        // Second arrange all children and return final size of panel
        protected override Size ArrangeOverride(Size finalSize)
        {
            // Get the collection of children
            UIElementCollection mychildren = Children;

            // Get total number of children
            int count = mychildren.Count;

            // Arrange children
            // We're only allowing 9 children in this panel.  More children will get a 0x0 layout slot.
            int i;
            for (i = 0; i < 9; i++)
            {

                // Get (left, top) origin point for the element in the 3x3 block
                Point cellOrigin = GetOrigin(i, 3, new Size(100, 100));

                // Arrange child
                // Get desired height and width. This will not be larger than 100x100 as set in MeasureOverride.
                double dw = mychildren[i].DesiredSize.Width;
                double dh = mychildren[i].DesiredSize.Height;

                mychildren[i].Arrange(new Rect(cellOrigin.X, cellOrigin.Y, dw, dh));

            }

            // Give the remaining children a 0x0 layout slot
            for (i = 9; i < count; i++)
            {
                mychildren[i].Arrange(new Rect(0, 0, 0, 0));
            }


            // Return final size of the panel
            return new Size(300, 300);
        }
        //</Snippet2>
        // Calculate point origin of the Block you are in
        protected Point GetOrigin(int blockNum, int blocksPerRow, Size itemSize)
        {
            // Get row number (zero-based)
            int row = (int)Math.Floor((decimal)blockNum / blocksPerRow);

            // Get column number (zero-based)
            int column = blockNum - blocksPerRow * row;

            // Calculate origin
            Point origin = new Point(itemSize.Width * column, itemSize.Height * row);
            return origin;

        }
    }
}
