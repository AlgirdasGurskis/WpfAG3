/*
Author : Algirdas Gurskis
Date   : 2018.09.24
Note   : this module like a test for education purpuse.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAG3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] n = new string[10];
//        n[i] = i + 100;

        public int i = 0;
        public int quot_index = 0;
        public int det_index = 1;
        public string[] details_array1 = new string[10];
        public string[] details_array2 = new string[10];
        public string[] details_array3 = new string[10];
        public string[] details_array4 = new string[10];
        public string[] details_array5 = new string[10];
        public string[] details_array6 = new string[10];
        public string[] details_array7 = new string[10];
        public string[] details_array8 = new string[10];
        public string[] details_array9 = new string[10];
        public string[] details_array10 = new string[10];
        public string[] details_array11 = new string[10];
        public string[] details_array12 = new string[10];
        public string[] details_array14 = new string[10];
        public string[] details_array15 = new string[10];

        public MainWindow()
        {
            InitializeComponent();
            Quotes_Number.Text = "0";
            Quotes_Quantity.Text = "0";
            Quotes_Date.Text = "";
            Quotes_Date.SelectedDate = DateTime.Now.AddDays(0);

         //   for (int counter = 0; counter<10 ; counter++)
         //   { listBox.Items.Add(counter); }

//            string [] strArray = new string[10];

//            for (int counter=0; counter < listBox.Items.Count -1; counter++)
//            { strArray[counter] = listBox.Items(counter); }
                 
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {  //details
            _Canvas1.Visibility = Visibility.Hidden;
            _Canvas2.Visibility = Visibility.Visible;
            try
            {
                details_label.Content = _ListBox.SelectedItem.ToString();
                details_label_xx.Content = _ListBox.SelectedItem.ToString().Substring(1, 6);
                delaliEilute(int.Parse(Quotes_Number.Text));
            }
            catch { }
            //----------------------->>
            switch (int.Parse(Quotes_Number.Text))
            {
                case 1:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                        {
                            try
                            {
                            if (details_array1[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array1[counter]); }
                            }
                            catch { }
                        }
                    break;
                case 2:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                    {
                        try
                        {
                            if (details_array2[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array2[counter]); }
                        }
                        catch { }
                    }
                    break;
                case 3:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                    {
                        try
                        {
                            if (details_array3[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array3[counter]); }
                        }
                        catch { }
                    }
                    break;
                case 4:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                    {
                        try
                        {
                            if (details_array4[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array4[counter]); }
                        }
                        catch { }
                    }
                    break;
                case 5:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                    {
                        try
                        {
                            if (details_array5[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array5[counter]); }
                        }
                        catch { }
                    }
                    break;
                case 6:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                    {
                        try
                        {
                            if (details_array6[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array6[counter]); }
                        }
                        catch { }
                    }
                    break;
                case 7:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                    {
                        try
                        {
                            if (details_array7[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array7[counter]); }
                        }
                        catch { }
                    }
                    break;
                case 8:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                    {
                        try
                        {
                            if (details_array8[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array8[counter]); }
                        }
                        catch { }
                    }
                    break;
                case 9:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                    {
                        try
                        {
                            if (details_array9[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array9[counter]); }
                        }
                        catch { }
                    }
                    break;
                case 10:
                    _DetailsListBox.Items.Clear();
                    for (int counter = 0; counter < 10; counter++)
                    {
                        try
                        {
                            if (details_array10[counter].Length > 1)
                            { _DetailsListBox.Items.Add(details_array10[counter]); }
                        }
                        catch { }
                    }
                    break;
                default:
                    break;

            }
            //------------------------>>>
        }

            public void delaliEilute(int dokumentas)
        {
        }            
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _Canvas1.Visibility = Visibility.Visible;
            _Canvas2.Visibility = Visibility.Hidden;           
        }

        private void Insert_Button_Click(object sender, RoutedEventArgs e)
        {
            i = i + 1;
            Quotes_Number.Text = i.ToString();
            try
            {
                _ListBox.Items.Add(" " + Quotes_Number.Text+"     |     " + Quotes_Quantity.Text + "     |     " + Quotes_Date.Text);
                quot_index = quot_index + 1;
            } catch { }
        }

        private void Modify_Button_Click(object sender, RoutedEventArgs e)
        {
            int index = _ListBox.SelectedIndex;
            try
            {
                _ListBox.Items.RemoveAt(index);
                _ListBox.Items.Insert(index, " " + Quotes_Number.Text + "|     " + Quotes_Quantity.Text + "     |     " + Quotes_Date.Text);
            } catch { }
            }

        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
//            if (MessageBox.Show("Do You really want to delete?", "One pont", MessageBoxButton.YesNo)== DialogResult)
  //          {
                int index = _ListBox.SelectedIndex;
                try
                {
                    _ListBox.Items.RemoveAt(index);
                }
                catch { }
    //        }
        }

        private void _ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Quotes_Number.Text = _ListBox.SelectedItem.ToString().Substring(1,6);
                Quotes_Quantity.Text = _ListBox.SelectedItem.ToString().Substring(11,12).Replace(" ","").Replace("|","");
                Quotes_Date.Text = _ListBox.SelectedItem.ToString().Substring(15, 12).Replace(" ", "");
            } catch { }
        }

        private void Form1_Initialized(object sender, EventArgs e)
        {
            _Canvas2.Visibility = Visibility.Hidden;
        }

        private void btn_DetailAdd_Click(object sender, RoutedEventArgs e)
        {
                try
                {
                _DetailsListBox.Items.Add(" " + _ListBox.SelectedItem.ToString().Substring(1, 6)+ "   |   "+ comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text+"   |   "+ comboBlass.Text+"   |   "+ comboCombi.Text);
                //                int index = _DetailsListBox.SelectedIndex;
                switch (int.Parse(Quotes_Number.Text))
                {
                    case 1:
                        details_array1[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    case 2:
                        details_array2[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    case 3:
                        details_array3[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    case 4:
                        details_array4[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    case 5:
                        details_array5[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    case 6:
                        details_array6[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    case 7:
                        details_array7[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    case 8:
                        details_array8[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    case 9:
                        details_array9[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    case 10:
                        details_array10[det_index] = " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text;
                        break;
                    default:
                        break;
                }
                det_index = det_index  + 1;
           }
            catch { }

        }

        private void det_btn_delete_Click(object sender, RoutedEventArgs e)
        {
            int index = _DetailsListBox.SelectedIndex;
            try
            {
                _DetailsListBox.Items.RemoveAt(index);
            }
            catch { }

        }

        private void det_btn_Modify_Click(object sender, RoutedEventArgs e)
        {
            int index = _DetailsListBox.SelectedIndex;
            try
            {
                _DetailsListBox.Items.RemoveAt(index);
                _DetailsListBox.Items.Insert(index, " " + _ListBox.SelectedItem.ToString().Substring(1, 6) + "   |   " + comboColor.Text + "   |   " + comboLite.Text + "  |  " + comboPoly.Text + "   |   " + comboBlass.Text + "   |   " + comboCombi.Text);
            }
            catch { }

        }

        private void _DetailsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            { // comboLite.Text + "  |  " + comboPoly.Text+"   |   "+ comboBlass.Text+"   |   "+ comboCombi.Text
                comboColor.Text = _DetailsListBox.SelectedItem.ToString().Substring(14, 6);//.Replace(" ", "").Replace("|", "");
                comboLite.Text = _DetailsListBox.SelectedItem.ToString().Substring(27, 8);//.Replace(" ", "").Replace("|", "");
                comboPoly.Text = _DetailsListBox.SelectedItem.ToString().Substring(40, 8);//.Replace(" ", "").Replace("|", "");
                comboBlass.Text = _DetailsListBox.SelectedItem.ToString().Substring(55, 8);//.Replace(" ", "").Replace("|", "");
                comboCombi.Text = _DetailsListBox.SelectedItem.ToString().Substring(70, 8);//.Replace(" ", "").Replace("|", ""); 
            }
            catch { }

        }

        private void arr_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int counter = 0; counter < 10; counter++)
                {
                    try
                    {
                        listBox.Items.Add(details_array1[counter]);
  //                      MessageBox.Show(details_array[counter]);
                    }
                    catch { }
                }
            } catch { }
        }
    }
}

