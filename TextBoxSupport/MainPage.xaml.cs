using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.Connectivity;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TextBoxSupport
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            //TextBox textBox = sender as TextBox;
            //Button deleteButton = FindVisualChild<Button>(textBox);
            //if (deleteButton != null)
            //{
            //    deleteButton.Click += async (ss, ee) =>
            //    {
            //        var dialog = new Windows.UI.Popups.MessageDialog("clicked...");
            //        await dialog.ShowAsync();
            //    };
            //}
        }

        private static T FindVisualChild<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        return (T)child;
                    }

                    T childItem = FindVisualChild<T>(child);
                    if (childItem != null) return childItem;
                }
            }
            return null;
        }

        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;

        // Handle the KeyDown event to determine the type of character entered into the control.
        //private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    // Initialize the flag to false.
        //    nonNumberEntered = false;

        //    // Determine whether the keystroke is a number from the top of the keyboard.
        //    if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
        //    {
        //        // Determine whether the keystroke is a number from the keypad.
        //        if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
        //        {
        //            // Determine whether the keystroke is a backspace.
        //            if (e.KeyCode != Keys.Back)
        //            {
        //                // A non-numerical keystroke was pressed.
        //                // Set the flag to true and evaluate in KeyPress event.
        //                nonNumberEntered = true;
        //            }
        //        }
        //    }
        //    //If shift key was pressed, it's not a number.
        //    if (Control.ModifierKeys == Keys.Shift)
        //    {
        //        nonNumberEntered = true;
        //    }
        //}

        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        //private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        //{
        //    // Check for the flag being set in the KeyDown event.
        //    if (nonNumberEntered == true)
        //    {
        //        // Stop the character from being entered into the control since it is non-numerical.
        //        e.Handled = true;
        //    }
        //}

        private void TextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            //var number = e.KeyStatus.ScanCode; 
            //if (number>= 71 && number<= 82&& number != 74&& number!=78)
            //{
            //    // the NumPad is pressed
            //}
            //else
            //{
            //    e.Handled = true;
            //}

            if (System.Text.RegularExpressions.Regex.IsMatch(e.Key.ToString(), "[0-9]"))
                e.Handled = false;
            else e.Handled = true;
        }

        //private void TextBox_KeyUp(object sender, KeyRoutedEventArgs e)
        //{
        //    if (nonNumberEntered == true)
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    Debug.WriteLine("textBox_TextChanged");
        //    //if(textBox.Text)

        //}
    }
}
