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






namespace Лабораторная_1__4_семестр_
{



    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateParallelepiped_Click(object sender, RoutedEventArgs e)
        {
            double sideA = Convert.ToDouble(SideATextBox.Text);
            double sideB = Convert.ToDouble(SideBTextBox.Text);
            double sideC = Convert.ToDouble(SideCTextBox.Text);

            Parallelepiped parallelepiped = new Parallelepiped
            {
                SideA = sideA,
                SideB = sideB,
                SideC = sideC
            };

            double parallelepipedSurfaceArea = parallelepiped.CalculateSurfaceArea();
            double parallelepipedVolume = parallelepiped.CalculateVolume();

            ParallelepipedResultsLabel.Content = $"Surface Area: {parallelepipedSurfaceArea}, Volume: {parallelepipedVolume}";

        }

        private void CalculateBall_Click(object sender, RoutedEventArgs e)
        {
            double radius = Convert.ToDouble(RadiusTextBox.Text);

            Ball ball = new Ball
            {
                Radius = radius
            };

            double ballSurfaceArea = ball.CalculateSurfaceArea();
            double ballVolume = ball.CalculateVolume();

            tb1.Text = $"Surface Area: {Math.Round(ballSurfaceArea,2)}, Volume: {Math.Round(ballVolume, 2)}";

            //BallResultsLabel.Content = $"Surface Area: {ballSurfaceArea}, Volume: {ballVolume}";










        }
    }



    public abstract class Body
    {
        public virtual double CalculateSurfaceArea()
        {
            throw new NotImplementedException("Surface area calculation not implemented for the base Body class.");
        }

        public virtual double CalculateVolume()
        {
            throw new NotImplementedException("Volume calculation not implemented for the base Body class.");
        }
    }

    public class Parallelepiped : Body
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double CalculateSurfaceArea()
        {
            return 2 * (SideA * SideB + SideA * SideC + SideB * SideC);
        }

        public override double CalculateVolume()
        {
            return SideA * SideB * SideC;
        }
    }

    public class Ball : Body
    {
        public double Radius { get; set; }

        public override double CalculateSurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }




}
