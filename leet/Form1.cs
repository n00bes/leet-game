using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
namespace leet
{
    
    public partial class Form1 : Form
    {
        bool iconShowed = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = string.Format("{0:HH:mm tt}", DateTime.Now);
        }

       

        private void ThisPCPanel_MouseLeave(object sender, EventArgs e)
        {
           // ThisPCPanel.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void ThisPCPanel_MouseEnter(object sender, EventArgs e)
        {
            //ThisPCPanel.BackColor = Color.FromArgb(48, 58, 65);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            ThisPCPanel.BackColor = Color.FromArgb(48, 58, 65);
            label1.BackColor = Color.FromArgb(48, 58, 65);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            ThisPCPanel.BackColor = Color.FromArgb(0, 0, 0);
            label1.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            
            MessageBox.Show("NIGGA");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private Point MouseDownPic3;
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownPic3 = e.Location;
            if (desktopMenuContext.Visible) desktopMenuContext.Hide();
            if (e.Button == MouseButtons.Right)
            {
                isTHISPCsender = true;
                int newX = pictureBox3.Location.X + 60;
                int newy = pictureBox3.Location.Y + 60;
                ContentMenu.Location = new Point(newX, newy);
                ContentMenu.Show();
            }
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            
            openButton.BackColor = Color.FromArgb(63, 63, 70);
            label2.BackColor = Color.FromArgb(63, 63, 70);
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            openButton.BackColor = Color.FromArgb(45, 45, 48);
            label2.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void runAdminButton_MouseEnter(object sender, EventArgs e)
        {
            runAdminButton.BackColor = Color.FromArgb(63, 63, 70);
            label3.BackColor = Color.FromArgb(63, 63, 70);
        }

        private void runAdminButton_MouseLeave(object sender, EventArgs e)
        {
            runAdminButton.BackColor = Color.FromArgb(45, 45, 48);
            label3.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void delButton13_MouseEnter(object sender, EventArgs e)
        {
            delButton13.BackColor = Color.FromArgb(63, 63, 70);
            DeleteButton.BackColor = Color.FromArgb(63, 63, 70);
        }

        private void delButton13_MouseLeave(object sender, EventArgs e)
        {
            delButton13.BackColor = Color.FromArgb(45, 45, 48);
            DeleteButton.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            ContentMenu.Hide();
        }

       

        private void runAdminButton_Click(object sender, EventArgs e)
        {
            ContentMenu.Hide();
        }
        bool isTHISPCsender = false;
        bool isRETARDEXEsender = false;
        bool isTHISPCdestroy = false;
        bool isRETARDEXEdestroy = false;
        private void delButton13_Click(object sender, EventArgs e)
        {
            ContentMenu.Hide();
            if (isTHISPCsender) { ThisPCPanel.Hide(); isTHISPCdestroy = true; isTHISPCsender = false; bsod.Size = new Size(1487, 845); }
            if (isRETARDEXEsender) { CMDPanel.Hide(); isRETARDEXEdestroy = true; isRETARDEXEsender = false; }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
            int lolOLDy = Cursor.Position.Y;
            if (ContentMenu.Visible) ContentMenu.Hide();
            if (e.Button == MouseButtons.Right)
            {
                Point p = this.PointToClient(Cursor.Position);

                desktopMenuContext.Location = p;
                desktopMenuContext.Show();
            }
            else if (e.Button == MouseButtons.Left)
            {
               // blueDesktopDragThing.Size = new Size(Cursor.Position.X, lolOLDy);
            }
        }
        string firstMac;
        string secondMac;
        string thirdMac;
        private void refreshButton_Click(object sender, EventArgs e)
        {
            desktopMenuContext.Hide();
        }
        
        private void showiconsButton_Click(object sender, EventArgs e)
        {
            if (iconShowed)
            {if (!isTHISPCdestroy) { ThisPCPanel.Hide(); }
                if (!isRETARDEXEdestroy) { CMDPanel.Hide(); }

                iconShowed = false;
            }
            else
            {
                if (!isRETARDEXEdestroy) { CMDPanel.Show(); }
                if (!isTHISPCdestroy) { ThisPCPanel.Show(); }
                   iconShowed = true;
            }
            desktopMenuContext.Hide();
        }

        private void newTextFileButton_Click(object sender, EventArgs e)
        {
            desktopMenuContext.Hide();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (desktopMenuContext.Visible) desktopMenuContext.Hide();
            if (ContentMenu.Visible) ContentMenu.Hide();
        }

        private void CMDPanel_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void CMDPanel_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void CMDPanel_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            CMDPanel.BackColor = Color.FromArgb(48, 58, 65);
            label4.BackColor = Color.FromArgb(48, 58, 65);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            CMDPanel.BackColor = Color.FromArgb(0, 0, 0);
            label4.BackColor = Color.FromArgb(0, 0, 0);
        }
        private Point MouseDownPic4;
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownPic4 = e.Location;
            if (desktopMenuContext.Visible) desktopMenuContext.Hide();
            if (e.Button == MouseButtons.Right)
            {
                isRETARDEXEsender = true;
                int newX = pictureBox4.Location.X + 60;
                int newy = pictureBox4.Location.Y + 60;
                ContentMenu.Location = new Point(newX, newy);
                ContentMenu.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             }

        private void label7_Click(object sender, EventArgs e)
        {
            panel3.Hide();
            richTextBox1.Text = "";
            textBox1.Text = "help";
        }



        bool wepInit = false;
        
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "help")
            {if (!wepInit)
                richTextBox1.Text += " HELP\nWelcome back.\nAll commands are: crack <ip>, help\nSkid >\n";
                else
                {
                    richTextBox1.Text += " HELP\nCommands for WEP: scan, probe <BSSID> <min Port> <max Port>, crack <BSSID> <openedPort>\nSkid > WEP > ";
                }
            }

            else if (textBox1.Text == "wep")
            {
                wepInit = true;
                richTextBox1.Text = "Skid > WEP >";
            }
            else if (textBox1.Text.Contains( "probe"))
            {
                if (wepInit)
                {
                   // try
                   // {
                        var s = textBox1.Text;
                        var mac = s.Split(' ')[1];
                        var minport = Int32.Parse(s.Split(' ')[2]);
                        var maxport = Int32.Parse(s.Split(' ')[3]);
                        probeWEP(mac, minport, maxport);
                   // }
                   // catch (Exception ex)
                   // {
                      //  MessageBox.Show("Error occured, blocked it!");
                    //}
                    
                }


            }
            else if (textBox1.Text.Contains("crack"))
            {
                if (wepInit)
                {
                    // try
                    // {
                    var s = textBox1.Text;
                    var mac = s.Split(' ')[1];
                    var port = Int32.Parse(s.Split(' ')[2]);
                    crackWEP(mac, port);

                    // }
                    // catch (Exception ex)
                    // {
                    //  MessageBox.Show("Error occured, blocked it!");
                    //}

                }

            }
            else if (textBox1.Text == "scan")
            {
                
                if (wepInit)
                   
                scanWEP();
            }
            else
            {
                richTextBox1.Text = "Skid > \"Command not found!\"";
            }
            textBox1.Clear();

            /* string caseSwitch = textBox1.Text;

             switch (caseSwitch)
             {
                 case "help":

                     break;
                 case "hack vibes":

                     break;
                 case "crack":

                     break;
                 case "hack vibes":

                     break;
                 default:

                     break;
             }*/ //i left this variant cuz it won't satifsy what i want to do.
        }
        private Point MouseDownLocation;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownLocation = e.Location;//let's make it move
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)//let's make it move
            {
                panel3.Left = e.X + panel3.Left - MouseDownLocation.X;//let's make it move
                panel3.Top = e.Y + panel3.Top - MouseDownLocation.Y;//let's make it move
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ThisPCPanel.Left = e.X + ThisPCPanel.Left - MouseDownPic3.X;
                ThisPCPanel.Top = e.Y + ThisPCPanel.Top - MouseDownPic3.Y;
            }
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                CMDPanel.Left = e.X + CMDPanel.Left - MouseDownPic4.X;
                CMDPanel.Top = e.Y + CMDPanel.Top - MouseDownPic4.Y;
            }
        }

















        //something
       
        int port;
        Stopwatch stopWatch = new Stopwatch();
        void crackWEP(string mac, int portx)
        {
            var random = new Random();
            
            if (port != portx)
            {
                richTextBox1.Text = "Skid > WEP > Crack > Port doesn't match!\nSkid > Web > ";
            }
            else
            {
                richTextBox1.Text = "Master Key:  " + random.Next(1,3) + " "+ +random.Next(1, 3) + "" + random.Next(1, 3) + " " + +random.Next(1, 3) + "" + random.Next(1, 3) + " " + +random.Next(1, 3) + "" + random.Next(1, 3) + " " + +random.Next(1, 3) + "";
                

            }
        }
        void probeWEP(string mac,int minPort, int maxPort)
        {
            var random = new Random();
            int randomnumber = random.Next(minPort, maxPort);
            port = randomnumber;
            for (int i = minPort; i < maxPort + 1; i++)
            {if (randomnumber == i)
                {
                    richTextBox1.Text = "FOUND OPEN PORT! ON '" + mac + "'\nOpen Port #:"+port +"\nSkid > WEP > ";
                    break;
                }
                else
                {
                    stopWatch.Restart();
                    while (stopWatch.ElapsedMilliseconds <= 1)
                    {

                    }
                    richTextBox1.Text = "Targeting '" + mac + "'\nProbing port: " + i;
                }
                
            }
           
        }

        void scanWEP()
        {
            firstMac = MacAddress.GetRandomMac();
            secondMac = MacAddress.GetRandomMac();
            thirdMac = MacAddress.GetRandomMac();
            richTextBox1.Text = "Scanned WEP Network Results:\n(ESSID)PORNOKITTY --> (BSSID)"+firstMac+ "\n(ESSID)vaibzgiti --> (BSSID)" + secondMac + "\n(ESSID)cock --> (BSSID)" + thirdMac+"\n\nSkid > WEP >";
           
        }

      
    }
    public static class MacAddress
    {
        private static readonly Random Random = new Random();

        public static string GetSignatureRandomMac(string generic = "AA")
        {
            string[] macBytes = new[]
            {
            generic,
            generic,
            generic,
            Random.Next(1, 256).ToString("X"),
            Random.Next(1, 256).ToString("X"),
            Random.Next(1, 256).ToString("X")
        };

            return string.Join("-", macBytes);
        }

        public static string GetRandomMac()
        {
            string[] macBytes = new[]
            {
            Random.Next(1, 256).ToString("X"),
            Random.Next(1, 256).ToString("X"),
            Random.Next(1, 256).ToString("X"),
            Random.Next(1, 256).ToString("X"),
            Random.Next(1, 256).ToString("X"),
            Random.Next(1, 256).ToString("X")
        };

            return string.Join("-", macBytes);
        }
    }
}
