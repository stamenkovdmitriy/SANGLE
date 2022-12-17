using Microsoft.Win32;
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
using static System.Convert;

namespace Scolioz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {       

        public double Gipotenusa(double a, double b)
        {
            double gipot;
            gipot = Math.Sqrt((a * a) + (b * b));
            return gipot;
        }

        public double Catet(double a, double b)
        {
            double c;
            if (a < b)
            {
                c = b - a;
                return c;
            }
            else
            {
                c = a - b;
                return c;
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();

            
            
        }

        protected override void OnActivated(EventArgs e)
        {
            

        }
        // градус наклона линии
        private void LineAngle_Click(object sender, RoutedEventArgs e)
        {
            double a, b, d, angle;        

            if (lineUroven.Y1 > lineUroven.Y2)
            {               
                if (lineUroven.X1 > lineUroven.X2 )
                {
                    a = lineUroven.Y1 - lineUroven.Y2;
                    b = lineUroven.X1 - lineUroven.X2;
                    if (a < b)
                    {
                        d = Math.Tan(a / b);
                        angle = d * 180 / Math.PI;
                        gradusData.Text = angle.ToString();
                    }
                    else
                    {
                        d = Math.Tan(a / b);
                        angle = d * 180 / Math.PI;
                        gradusData.Text = angle.ToString();
                    }                    
                }
                else
                {
                    a = lineUroven.Y1 - lineUroven.Y2;
                    b = lineUroven.X2 - lineUroven.X1;
                    if (a < b)
                    {
                        d = Math.Tan(a / b);
                        angle = d * 180 / Math.PI;
                        gradusData.Text = angle.ToString();
                    }
                    else
                    {
                        d = Math.Tan(a / b);
                        angle = d * 180 / Math.PI;
                        gradusData.Text = angle.ToString();
                    }
                }
            }
            else
            {                
                if (lineUroven.X2 >= lineUroven.X1)
                {
                    a = lineUroven.Y2 - lineUroven.Y1;
                    b = lineUroven.X2 - lineUroven.X1;
                    if (a <= b)
                    {
                        d = Math.Tan(a/b);
                        angle = d * 180 / Math.PI;
                        gradusData.Text = angle.ToString();
                    }
                    else
                    {
                        d = Math.Tan(a / b);
                        angle = d * 180 / Math.PI;
                        gradusData.Text = angle.ToString();
                    }
                }
                else
                {
                    a = lineUroven.Y2 - lineUroven.Y1;
                    b = lineUroven.X1 - lineUroven.X2;
                    if (a <= b)
                    {
                        d = Math.Tan(a / b);
                        angle = d * 180 / Math.PI;
                        gradusData.Text = angle.ToString();
                    }
                    else
                    {
                        d = Math.Tan(a / b);
                        angle = d * 180 / Math.PI;
                        gradusData.Text = angle.ToString();
                    }
                }
            }        
                      
        }
        // градус углов

        private void Angle0_Click(object sender, RoutedEventArgs e)
        {
            double catetOne = Catet(sliderPointOneX.Value, sliderAngleX.Value);
            double catetOneProtivl = Catet(sliderPointOneY.Value, sliderAngleY.Value);
            double gipotenusaOne = Gipotenusa(catetOne,catetOneProtivl);
            double angleOne = Math.Cos(catetOneProtivl / gipotenusaOne);
            double degreeOne = (angleOne * 180) / Math.PI;

            double catetTwo = Catet(lineAngleTwo.X1, lineAngleTwo.X2);
            double catetTwoProtivl = Catet(lineAngleTwo.Y1, lineAngleTwo.Y2);
            double gipotenusaTwo = Gipotenusa(catetTwo, catetTwoProtivl);
            double angleTwo = Math.Cos(catetTwoProtivl / gipotenusaTwo);
            double degreeTwo = (angleTwo * 180) / Math.PI;            
            
            double degreeA = degreeOne+degreeTwo;
            gradusData0.Text = degreeA.ToString();

        }

        private void Angle1_Click(object sender, RoutedEventArgs e)
        {
            double catetOne = Catet(sliderPointOneX.Value, sliderAngleX.Value);
            double catetOneProtivl = Catet(sliderPointOneY.Value, sliderAngleY.Value);
            double gipotenusaOne = Gipotenusa(catetOne, catetOneProtivl);
            double angleOne = Math.Cos(catetOneProtivl / gipotenusaOne);
            double degreeOne = (angleOne * 180) / Math.PI;

            double catetTwo = Catet(lineAngleTwo.X1, lineAngleTwo.X2);
            double catetTwoProtivl = Catet(lineAngleTwo.Y1, lineAngleTwo.Y2);
            double gipotenusaTwo = Gipotenusa(catetTwo, catetTwoProtivl);
            double angleTwo = Math.Cos(catetTwoProtivl / gipotenusaTwo);
            double degreeTwo = (angleTwo * 180) / Math.PI;

            double degreeA = degreeOne + degreeTwo;
            gradusData2.Text = degreeA.ToString();
        }

        private void Angle2_Click(object sender, RoutedEventArgs e)
        {
            double catetOne = Catet(sliderPointOneX.Value, sliderAngleX.Value);
            double catetOneProtivl = Catet(sliderPointOneY.Value, sliderAngleY.Value);
            double gipotenusaOne = Gipotenusa(catetOne, catetOneProtivl);
            double angleOne = Math.Cos(catetOneProtivl / gipotenusaOne);
            double degreeOne = (angleOne * 180) / Math.PI;

            double catetTwo = Catet(lineAngleTwo.X1, lineAngleTwo.X2);
            double catetTwoProtivl = Catet(lineAngleTwo.Y1, lineAngleTwo.Y2);
            double gipotenusaTwo = Gipotenusa(catetTwo, catetTwoProtivl);
            double angleTwo = Math.Cos(catetTwoProtivl / gipotenusaTwo);
            double degreeTwo = (angleTwo * 180) / Math.PI;

            double degreeA = degreeOne + degreeTwo;
            gradusData3.Text = degreeA.ToString();
        }

        private void Angle3_Click(object sender, RoutedEventArgs e)
        {
            double catetOne = Catet(sliderPointOneX.Value, sliderAngleX.Value);
            double catetOneProtivl = Catet(sliderPointOneY.Value, sliderAngleY.Value);
            double gipotenusaOne = Gipotenusa(catetOne, catetOneProtivl);
            double angleOne = Math.Cos(catetOneProtivl / gipotenusaOne);
            double degreeOne = (angleOne * 180) / Math.PI;

            double catetTwo = Catet(lineAngleTwo.X1, lineAngleTwo.X2);
            double catetTwoProtivl = Catet(lineAngleTwo.Y1, lineAngleTwo.Y2);
            double gipotenusaTwo = Gipotenusa(catetTwo, catetTwoProtivl);
            double angleTwo = Math.Cos(catetTwoProtivl / gipotenusaTwo);
            double degreeTwo = (angleTwo * 180) / Math.PI;

            double degreeA = degreeOne + degreeTwo;
            gradusData4.Text = degreeA.ToString();
        }

        // добавление линий
        private void AddLine1_Click(object sender, RoutedEventArgs e)
        {
            lineUroven1.X1 = lineUroven.X1;
            lineUroven1.X2 = lineUroven.X2;
            lineUroven1.Y1 = lineUroven.Y1;
            lineUroven1.Y2 = lineUroven.Y2;
        }

        private void AddLine2_Click(object sender, RoutedEventArgs e)
        {
            lineUroven2.X1 = lineUroven.X1;
            lineUroven2.X2 = lineUroven.X2;
            lineUroven2.Y1 = lineUroven.Y1;
            lineUroven2.Y2 = lineUroven.Y2;
        }
        
        private void AddLine3_Click(object sender, RoutedEventArgs e)
        {
            lineUroven3.X1 = lineUroven.X1;
            lineUroven3.X2 = lineUroven.X2;
            lineUroven3.Y1 = lineUroven.Y1;
            lineUroven3.Y2 = lineUroven.Y2;
        }

        // добавление углов

        private void AddAngle1_Click(object sender, RoutedEventArgs e)
        {
            lineAngleOne1.X1 = lineAngleOne.X1;
            lineAngleOne1.X2 = lineAngleOne.X2;
            lineAngleOne1.Y1 = lineAngleOne.Y1;
            lineAngleOne1.Y2 = lineAngleOne.Y2;
            lineAngleTwo1.X1 = lineAngleTwo.X1;
            lineAngleTwo1.X2 = lineAngleTwo.X2;
            lineAngleTwo1.Y1 = lineAngleTwo.Y1;
            lineAngleTwo1.Y2 = lineAngleTwo.Y2;
        }

        private void AddAngle2_Click(object sender, RoutedEventArgs e)
        {
            lineAngleOne2.X1 = lineAngleOne.X1;
            lineAngleOne2.X2 = lineAngleOne.X2;
            lineAngleOne2.Y1 = lineAngleOne.Y1;
            lineAngleOne2.Y2 = lineAngleOne.Y2;
            lineAngleTwo2.X1 = lineAngleTwo.X1;
            lineAngleTwo2.X2 = lineAngleTwo.X2;
            lineAngleTwo2.Y1 = lineAngleTwo.Y1;
            lineAngleTwo2.Y2 = lineAngleTwo.Y2;
        }

        private void AddAngle3_Click(object sender, RoutedEventArgs e)
        {
            lineAngleOne3.X1 = lineAngleOne.X1;
            lineAngleOne3.X2 = lineAngleOne.X2;
            lineAngleOne3.Y1 = lineAngleOne.Y1;
            lineAngleOne3.Y2 = lineAngleOne.Y2;
            lineAngleTwo3.X1 = lineAngleTwo.X1;
            lineAngleTwo3.X2 = lineAngleTwo.X2;
            lineAngleTwo3.Y1 = lineAngleTwo.Y1;
            lineAngleTwo3.Y2 = lineAngleTwo.Y2;
        }               
        

        

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddImage_Click(object sender, RoutedEventArgs e)
        {
            lineUroven1.X1 = 0;
            lineUroven1.X2 = 0;
            lineUroven1.Y1 = 0;
            lineUroven1.Y2 = 0;

            lineUroven2.X1 = 0;
            lineUroven2.X2 = 0;
            lineUroven2.Y1 = 0;
            lineUroven2.Y2 = 0;

            lineUroven3.X1 = 0;
            lineUroven3.X2 = 0;
            lineUroven3.Y1 = 0;
            lineUroven3.Y2 = 0;

            lineAngleOne1.X1 = 0;
            lineAngleOne1.X2 = 0;
            lineAngleOne1.Y1 = 0;
            lineAngleOne1.Y2 = 0;
            lineAngleTwo1.X1 = 0;
            lineAngleTwo1.X2 = 0;
            lineAngleTwo1.Y1 = 0;
            lineAngleTwo1.Y2 = 0;

            lineAngleOne2.X1 = 0;
            lineAngleOne2.X2 = 0;
            lineAngleOne2.Y1 = 0;
            lineAngleOne2.Y2 = 0;
            lineAngleTwo2.X1 = 0;
            lineAngleTwo2.X2 = 0;
            lineAngleTwo2.Y1 = 0;
            lineAngleTwo2.Y2 = 0;

            lineAngleOne3.X1 = 0;
            lineAngleOne3.X2 = 0;
            lineAngleOne3.Y1 = 0;
            lineAngleOne3.Y2 = 0;
            lineAngleTwo3.X1 = 0;
            lineAngleTwo3.X2 = 0;
            lineAngleTwo3.Y1 = 0;
            lineAngleTwo3.Y2 = 0;

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == true)
            {
                img1.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }

        
    }
}
