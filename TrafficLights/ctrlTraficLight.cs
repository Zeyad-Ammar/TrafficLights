using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLights.Properties;

namespace TrafficLights
{
    public partial class ctrlTraficLight : UserControl
    {

        public enum enColors { RED, YELLOW , GREEN };

        private enColors _currentColor;
        public enColors CurrentColor { get { return _currentColor; }
            
            set {

                if (value != _currentColor)
                {
                    _currentColor = value;

                    if (_currentColor == enColors.RED)
                    {
                        pbTrafficLight.Image = Resources.red;
                        lbTimer.ForeColor = Color.Red;

                    }
                    else if(_currentColor == enColors.YELLOW)
                    {
                        pbTrafficLight.Image = Resources.yello;
                        lbTimer.ForeColor = Color.Yellow;
                    }
                    else
                    {
                        pbTrafficLight.Image = Resources.Green;
                        lbTimer.ForeColor = Color.Green;
                    }
                }

            }
        }

        



        public enColors PreviousColor;

        public int RedTimer { get; set; }

        public int GreenTimer { get; set; }


        public int YellowTimer { get; set; }


        public int Timer;

        public ctrlTraficLight()
        {

            InitializeComponent();
            
        }
        
        public class CustomEventArgs : EventArgs
        {
            public int Timer { get; set; }
            public enColors Color { get; set; }
            

            public CustomEventArgs(int Timer,enColors Colors)
            {
                this.Timer= Timer;
                this.Color = Colors;
            }
        }

        public event EventHandler<CustomEventArgs> onRedLight;

        private void RaseRedLightEvent()
        {
            RaseRedLightEvent(new CustomEventArgs ( RedTimer,enColors.RED));
        }
        private void RaseRedLightEvent(CustomEventArgs e)
        {
            onRedLight?.Invoke(this, e);
        }


        public event EventHandler<CustomEventArgs> onGreenLight;

        private void RaseGreenLightEvent()
        {
            RaseGreenLightEvent(new CustomEventArgs(GreenTimer, enColors.GREEN));
        }
        private void RaseGreenLightEvent(CustomEventArgs e)
        {
            onRedLight?.Invoke(this, e);
        }

        public event EventHandler<CustomEventArgs> onYellowLight;

        private void RaseYellowLightEvent()
        {
            RaseYellowLightEvent(new CustomEventArgs(YellowTimer, enColors.YELLOW));
        }
        private void RaseYellowLightEvent(CustomEventArgs e)
        {
            onRedLight?.Invoke(this, e);
        }
        public void ctrlStart()
        {
            
            switch (CurrentColor)
            {
                case enColors.RED:
                    ChangeColorToRed();
                    break;
                case enColors.YELLOW:
                    ChangeColorToYellow();
                    break;
                case enColors.GREEN:
                    ChangeColorToGreen();
                    break;

                default:
                    ChangeColorToRed();
                    break;
            }
            
            timer1.Start();
            
        }

        
        private void ChangeColorToRed()
        {
            PreviousColor = CurrentColor;
            CurrentColor = enColors.RED;
            pbTrafficLight.Image = Resources.red;
            lbTimer.ForeColor= Color.Red;
            Timer = RedTimer;
            lbTimer.Text = Timer.ToString();

            RaseRedLightEvent();
        }


        private void ChangeColorToGreen()
        {
            PreviousColor = CurrentColor;
            CurrentColor = enColors.GREEN;
            pbTrafficLight.Image = Resources.Green;
            lbTimer.ForeColor = Color.Green;
            Timer = GreenTimer;
            lbTimer.Text = Timer.ToString();

            RaseGreenLightEvent();

        }

        private void ChangeColorToYellow()
        {
            PreviousColor = CurrentColor;
            CurrentColor= enColors.YELLOW;
            pbTrafficLight.Image = Resources.yello;
            lbTimer.ForeColor = Color.Yellow;
            Timer = YellowTimer;
            lbTimer.Text = Timer.ToString();

            RaseYellowLightEvent();

        }


        public void LightChange(enColors Color)
        {
            switch (Color)
            {
                case enColors.RED:
                    ChangeColorToRed();
                    break;
                case enColors.GREEN:   
                    ChangeColorToGreen();
                    break;
                case enColors.YELLOW:
                    ChangeColorToYellow();
                    break;

                default:
                    ChangeColorToRed();
                    break;
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer--;
            lbTimer.Text=Timer.ToString();

            if (Timer == 0)
            {

                if (CurrentColor == enColors.RED||CurrentColor==enColors.GREEN)
                {
                    ChangeColorToYellow();

                }else if (CurrentColor == enColors.YELLOW)
                {
                    if (PreviousColor == enColors.RED)
                    {
                        ChangeColorToGreen();
                    }
                    else
                    {
                        ChangeColorToRed();
                    }
                }


                
            }
        }

        
    }
}
