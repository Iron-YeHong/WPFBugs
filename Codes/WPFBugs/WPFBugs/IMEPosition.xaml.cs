using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace WPFBugs
{
    /// <summary>
    /// Interaction logic for IMEPosition.xaml
    /// </summary>
    public partial class IMEPosition
    {
        [DllImport("User32.dll")]
        private static extern IntPtr SetFocus(IntPtr hWnd);

        public IMEPosition()
        {
            InitializeComponent();
            MyPopup.GotFocus += MyPopup_GotFocus;
        }

        private void MyPopup_GotFocus(object sender, RoutedEventArgs e)
        {
            var source = (HwndSource)PresentationSource.FromVisual(MyPopup.Child);
            if (source != null)
            {
                SetFocus(source.Handle);
                MyTextBox.Focus();
            }
        }
    }
}