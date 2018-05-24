using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;

namespace LaserScannerGUI
{
    public partial class LaserScannerForm : Form
    {
        Timer uiTimer = new Timer();
        Stopwatch elapsed_time = new Stopwatch();
        bool emailEnabled = false;
        SerialPort port;
        List<int> Distances;
        bool alertCurrent = false;
        bool alertPrevious = false;
        bool messageEnabled = false;

        //LEDStripController ledController;

        public LaserScannerForm()
        {
            InitializeComponent();
        }
        private static bool checkDistances(double angle, double distance, int startAng, int endAng, int textDistnace)
        {
            return (angle > startAng & angle < endAng & angle != 222) & distance < textDistnace & distance != 0;

        }
        private void LaserScannerForm_Load(object sender, EventArgs e)
        {
            //Connect to laser here (serial port)
            port = new SerialPort("COM7", 115200, Parity.None, 8, StopBits.One);
            port.NewLine = "\n";

            Distances = new List<int>(new int[360]);
            elapsed_time.Start();

            port.DataReceived += port_DataReceived;
            // Begin communications
            port.Open();
            //Console.WriteLine()
            port.WriteLine("MotorOn");
            port.WriteLine("ShowDist");

            //ledController = new LEDStripController("COM10");
            //ledController.connect();
            //ledController.setLEDColor(0, 29, 0, 255, 0);


            uiTimer.Interval = 200;
            uiTimer.Tick += UiTimer_Tick;
            uiTimer.Start();
        }

        private void UiTimer_Tick(object sender, EventArgs e)
        {
            updateImage();
        }

        private void updateImage()
        {
            List<CoordData> Cartesian = convertPolarToCoordData(Distances);
            pictureBoxImage.Image = generateDataImage(1000, 1000, Cartesian);
            pictureBoxImage.Refresh();
        }

        private struct CoordData
        {
            public int x; // in millimeters (mm)
            public int y;// in millimeters (mm)
            public double angle;
            public double distance;

            public CoordData(int x, int y, double angle, double distance)
            {
                this.x = x;
                this.y = y;
                this.angle = angle;
                this.distance = distance;
            }
        }

        private static List<CoordData> convertPolarToCoordData(List<int> polarList)
        {
            List<CoordData> cartesianList = new List<CoordData>();

            for (int i = 0; i < polarList.Count; i++)
            {
                double angle = i; // in Degrees
                double distance = polarList[i]; // in mm

                CoordData point = convertPolarToCoordData(angle, distance);
                cartesianList.Add(point);

                //TODO: Do conversion here: convert (angle, distance) to (x,y) and add to cartesianList
                // e.g.  int x = ... ;  int y = ... ;
                //       CoordData newData = new CoordData(x, y);
                //       cartesianList.Add(newData);

            }

            return cartesianList;
        }

        private static CoordData convertPolarToCoordData(double angle, double distance)
        {
            double angleRadians = angle * Math.PI / 180; // convert Degrees to Radians

            int x = Convert.ToInt32(distance * Math.Cos(angleRadians));
            int y = -1 * Convert.ToInt32(distance * Math.Sin(angleRadians));

            CoordData point = new CoordData(x, y, angle, distance);

            return point;
        }

        /// <summary>
        /// Generates a Bitmap of points based on a list of (x,y) [cartesian] points.
        /// </summary>
        /// <param name="width">Width of the bitmap</param>
        /// <param name="height">Height of the bitmap</param>
        /// <param name="plotList">List of (theta, magnitude) points</param>
        /// <returns></returns>
        private Bitmap generateDataImage(int width, int height, List<CoordData> plotList)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);

            foreach (CoordData point in plotList)
            {
                int newX = Convert.ToInt32((point.x / 12.0f) + (width / 2.0f));
                int newY = Convert.ToInt32((point.y / 12.0f) + (height / 2.0f));

                if (newX > 3000 || newY > 3000 || newX < 0 || newY < 0)
                {
                    //Do nothing, outside bounds
                }
                else
                {
                    if (checkDistances(point.angle, point.distance, Convert.ToInt32(textStartAngle.Value), Convert.ToInt32(textEndAngle.Value), Convert.ToInt32(textDistance.Value)))
                    {
                        g.DrawEllipse(new Pen(Color.Red, 4), newX, newY, 4, 4);

                    }
                    else
                    {
                        //bmp.SetPixel(newX, newY, Color.Black);
                        g.DrawEllipse(new Pen(Color.Blue, 4), newX, newY, 4, 4);

                    }
                }
            }

            int originX = Convert.ToInt32(width / 2.0f);
            int originY = Convert.ToInt32(height / 2.0f);

            CoordData startAnglePoint = convertPolarToCoordData(Convert.ToDouble(textStartAngle.Value), Convert.ToDouble(textDistance.Value));
            startAnglePoint.x = Convert.ToInt32((startAnglePoint.x / 12.0f) + (width / 2.0f));
            startAnglePoint.y = Convert.ToInt32((startAnglePoint.y / 12.0f) + (height / 2.0f));

            CoordData endAnglePoint = convertPolarToCoordData(Convert.ToDouble(textEndAngle.Value), Convert.ToDouble(textDistance.Value));
            endAnglePoint.x = Convert.ToInt32((endAnglePoint.x / 12.0f) + (width / 2.0f));
            endAnglePoint.y = Convert.ToInt32((endAnglePoint.y / 12.0f) + (height / 2.0f));


            g.DrawLine(new Pen(Color.Green, 2), originX, originY, startAnglePoint.x, startAnglePoint.y);
            g.DrawLine(new Pen(Color.Green, 2), originX, originY, endAnglePoint.x, endAnglePoint.y);

            //TODO: Add drawings to g here. Something like this would add a single point to the bitmap:
            //          g.DrawEllipse(new Pen(Color.Black, 2), x, y, 2, 2);
            // You could probably use a for loop or foreach loop to add more than one point in the list.  I prefer the foreach loop for this.


            return bmp;
        }


        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            while (port.BytesToRead > 0)
            {
                string message = port.ReadLine();
                string[] splitData = message.Split(',');
                if (splitData.Length == 4)
                {
                    int angle = Convert.ToInt32(splitData[1]);
                    int distance = Convert.ToInt32(splitData[2]);

                    if (angle >= 0 && angle <= 359)
                        Distances[angle] = distance;

                    if (elapsed_time.ElapsedMilliseconds > 5000)
                    {
                        int startAngle = 0;
                        int endAngle = 360;
                        int distancethres = 3000;

                        textStartAngle.Invoke((MethodInvoker)delegate
                        {
                            // Running on the UI thread
                            startAngle = Convert.ToInt32(textStartAngle.Value);
                        });

                        textEndAngle.Invoke((MethodInvoker)delegate
                        {
                            // Running on the UI thread
                            endAngle = Convert.ToInt32(textEndAngle.Value);
                        });

                        textEndAngle.Invoke((MethodInvoker)delegate
                        {
                            // Running on the UI thread
                            distancethres = Convert.ToInt32(textDistance.Value);
                        });



                        alertCurrent = checkDistances(angle, distance, startAngle, endAngle, distancethres);
                        if (alertCurrent != alertPrevious)
                        {
                            if (alertCurrent)
                            {
                                Console.WriteLine("Person Detected.");

                                if (emailEnabled)
                                {

                                    sendEmail();

                                }
                                if (messageEnabled)
                                {
                                    System.Windows.Forms.MessageBox.Show("Some one is behind you");

                                }


                                this.Invoke((MethodInvoker)delegate
                                {
                                    // Running on the UI thread
                                    //ledController.setLEDColor(0, 29, 255, 0, 0);
                                });

                                //  ledController.setLEDColor(0, 29, 255, 0, 0);
                                notifyIcon.Icon = new Icon(this.GetType(), "icon_red.ico");
                                notifyIcon.ShowBalloonTip(1000, "Laser Scanner", "Someone has entered the office.", ToolTipIcon.Warning);


                                elapsed_time.Restart();
                            }
                            else
                            {
                                notifyIcon.Icon = new Icon(this.GetType(), "icon_green.ico");
                                //  ledController.setLEDColor(0, 29, 0, 255, 0);
                                this.Invoke((MethodInvoker)delegate
                                {
                                    // Running on the UI thread
                                    // ledController.setLEDColor(0, 29, 0, 255, 0);
                                });
                            }
                        }
                        alertPrevious = alertCurrent;
                    }
                }
            }



            /* if (splitData.Length == 4)
             {
                 check_Distances(angle, distance);
             }*/
        }

        private void buttonMotorOn_Click(object sender, EventArgs e)
        {
            port.WriteLine("MotorOn");
        }

        private void buttonMotorOff_Click(object sender, EventArgs e)
        {
            port.WriteLine("MotorOff");
        }

        private void buttonEmailOff(object sender, EventArgs e)
        {
            emailEnabled = false;
        }

        public void buttonEmailOn(object sender, EventArgs e)
        {

            emailEnabled = true;


        }
        private void sendEmail()
        {
            //elapsed_time.Restart();
            MailMessage mail = new MailMessage("<from-email>", "<to-email>");
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("<email>", "<password>");
            client.Host = "smtp.gmail.com";
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            client.Send(mail);
            Console.WriteLine("sent email");
        }

        private void buttonMessageOn(object sender, EventArgs e)
        {
            messageEnabled = true;
        }

        private void buttonMessageOff(object sender, EventArgs e)
        {
            messageEnabled = false;
        }

        private void buttonUpdate(object sender, EventArgs e)
        {
            updateImage();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void LaserScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            port.WriteLine("MotorOff");
            //port.Close();

            // ledController.setLEDColor(0, 29, 0, 0, 0);
            //  ledController.disconnect();
        }
    }
}
