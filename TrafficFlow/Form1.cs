using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace TrafficFlow
{
    public partial class Form1 : Form
    {
        public int NodeCount = 0;
        public int Mpu5Count = 0;
        public int MtsCount = 0;
        Color vbatBG = Color.LightBlue;
        Color omniBG = Color.Goldenrod;
        Color trkrBG = Color.Teal;
        public IPAddress network = IPAddress.Parse("10.0.0.0");
        public IPAddress subnet = IPAddress.Parse("255.128.0.0");
        public List<TextBox> FrontDoorAddresses = new List<TextBox>();
        public Dictionary<string, Node> NodeTable = new Dictionary<string, Node>();
        

        public Dictionary<int, string> VbatDict = new Dictionary<int, string>()
        {
            { 1, "VBAT01" },
            { 2, "VBAT02" },
            { 3, "VBAT03" },
            { 4, "VBAT04" },
            { 5, "VBAT05" },
            { 6, "VBAT06" },
            { 7, "VBAT07" },
            { 8, "VBAT08" },
            { 9, "VBAT09" },
            { 10, "VBAT10" },
            { 11, "VBAT11" },
            { 12, "VBAT12" },
            { 13, "VBAT13" },
            { 14, "VBAT14" },
            { 15, "VBAT15" },
            { 16, "VBAT16" },
            { 17, "VBAT17" },
            { 18, "VBAT18" },
            { 19, "VBAT19" },
            { 20, "VBAT20" },

        };
        public Dictionary<int, string> Mpu5Dict = new Dictionary<int, string>()
        {
            { 1, "MPU501" },
            { 2, "MPU502" },
            { 3, "MPU503" },
            { 4, "MPU504" },
            { 5, "MPU505" },
            { 6, "MPU506" },
            { 7, "MPU507" },
            { 8, "MPU508" },
            { 9, "MPU509" },
            { 10, "MPU510" },
            { 11, "MPU511" },
            { 12, "MPU512" },
            { 13, "MPU13" },
            { 14, "MPU514" },
            { 15, "MPU515" },
            { 16, "MPU516" },
            { 17, "MPU517" },
            { 18, "MPU518" },
            { 19, "MPU519" },
            { 20, "MPU520" },

        };
        public Dictionary<int, string> MTSDict = new Dictionary<int, string>()
        {
            { 1, "MTS01" },
            { 2, "MTS02" },
            { 3, "MTS03" },
            { 4, "MTS04" },
            { 5, "MTS05" },
            { 6, "MTS06" },
            { 7, "MTS07" },
            { 8, "MTS08" },
            { 9, "MTS09" },
            { 10, "MTS10" },
            { 11, "MTS11" },
            { 12, "MTS12" },
            { 13, "MTS13" },
            { 14, "MTS14" },
            { 15, "MTS15" },
            { 16, "MTS16" },
            { 17, "MTS17" },
            { 18, "MTS18" },
            { 19, "MTS19" },
            { 20, "MTS20" },

        };
        public Form1()
        {
            InitializeComponent();
            flpNodes.FlowDirection = FlowDirection.TopDown;
            Random r = new Random();
            int Octet1 = r.Next(0, 255);
            int Octet2 = r.Next(0, 255);
            int Octet3 = r.Next(0, 255);
            int Octet4 = r.Next(0, 255);
            txtPcIP.Text = $"{Octet1}.{Octet2}.{Octet3}.{Octet4}";
            int Octet21 = r.Next(0, 255);
            int Octet22 = r.Next(0, 255);
            int Octet23 = r.Next(0, 255);
            int Octet24 = r.Next(0, 255);
            txtSubnet.Text = $"{Octet21}.{Octet22}.{Octet23}.{Octet24}";
            cbbNodeType.SelectedIndex = 1;
            cbbNetwokOwner.SelectedIndex = 0;
            cbbMasterFreq.SelectedIndex = 1;
            cbbMasterBW.SelectedIndex = 1;
            cbbMasterDist.SelectedIndex = 3;
            cbbMaxDens.SelectedIndex = 1;
            cbLearningMode.Checked = true;
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            
            string GBName = string.Empty;
            string GBText = string.Empty;
            Color bg = new Color();
            Node v = new Node() ;
            switch (cbbNodeType.SelectedItem.ToString())
            {
                case "VBAT":
                    ++NodeCount;
                    v.Name = VbatDict[NodeCount];
                    v.BackNetwork = IPAddress.Parse("10.3.1.0");
                    v.BackMask = IPAddress.Parse("255.255.255.0");
                    v.FrontMask = IPAddress.Parse("255.128.0.0");
                    v.DefaultRoute = IPAddress.Parse("10.1.0.1");
                    v.BackDoor = IPAddress.Parse("10.3.1.254");
                    GBName = $"Node_{VbatDict[NodeCount]}";
                    GBText = VbatDict[NodeCount];
                    bg = vbatBG;
                    break;
                case "OMNI":
                    ++NodeCount;
                    v.Name = VbatDict[NodeCount];
                    v.BackNetwork = IPAddress.Parse("10.3.1.0");
                    v.BackMask = IPAddress.Parse("255.255.255.0");
                    v.FrontMask = IPAddress.Parse("255.128.0.0");
                    v.DefaultRoute = IPAddress.Parse("10.1.0.1");
                    v.BackDoor = IPAddress.Parse("10.3.1.254");
                    GBName = $"Node_{Mpu5Dict[NodeCount]}";
                    GBText = Mpu5Dict[NodeCount];
                    bg = Color.Goldenrod;
                    break;
                case "Tracker":
                    ++NodeCount;
                    v.Name = MTSDict[NodeCount];
                    v.BackNetwork = IPAddress.Parse("10.4.0.0");
                    v.BackMask = IPAddress.Parse("255.255.0.0");
                    v.FrontMask = IPAddress.Parse("255.128.0.0");
                    v.DefaultRoute = IPAddress.Parse("10.1.0.1");
                    v.BackDoor = IPAddress.Parse("10.4.1.1");
                    GBName = $"Node_{MTSDict[NodeCount]}";
                    GBText = MTSDict[NodeCount];
                    bg = Color.Teal;
                    break;

            }
            NodeTable.Add(v.Name, v);
            GroupBox Gbox = new GroupBox()
            { 
                Name = GBName, 
                Text = GBText, 
                Size = new Size(645, 110), 
                BackColor = bg 
            };

            flpNodes.Controls.Add(Gbox);

            Random r = new Random();
            int Octet1 = r.Next(0, 255);
            int Octet2 = r.Next(0, 255);
            int Octet3 = r.Next(0, 255);
            int Octet4 = r.Next(0, 255);

            string frontIpAddress = $"{Octet1}.{Octet2}.{Octet3}.{Octet4}";
            v.FrontDoor = IPAddress.Parse(frontIpAddress);
            Font font = new Font("Microsoft Sans Serif", 12.0f);
            string txtName = $"txtFrontDoor_{GBText}";

            Label lblFrontDoor = new Label()
            {
                Text = "Front Door IPv4",
                Location = new Point(10, 11),
                Font = font,
                Size = new Size(150, 39),
                TextAlign = ContentAlignment.MiddleCenter
            };
            TextBox FrontDoor = new TextBox()
            {
                Name = $"txtFD{v.Name}",
                Text = v.FrontDoor.ToString(),
                Location = new Point(10, 40),
                Font = font,
                Size = new Size(150, 39),
                TextAlign = HorizontalAlignment.Center
            };
            TextBox FrontMask = new TextBox()
            {
                Name = $"txtFM{v.Name}",
                Text = v.FrontMask.ToString(),
                Location = new Point(10, 72),
                Font = font,
                Size = new Size(150, 39),
                TextAlign = HorizontalAlignment.Center
            };

            Label lblBackDoor = new Label()
            {
                Text = "Back Door IPv4",
                Location = new Point(175, 11),
                Font = font,
                Size = new Size(150, 39),
                TextAlign = ContentAlignment.MiddleCenter
            };
            TextBox BackDoor = new TextBox()
            {
                Name = $"txtBD{v.Name}",
                Text = v.BackDoor.ToString(),
                Location = new Point(175, 40),
                Font = font,
                Size = new Size(150, 39),
                TextAlign = HorizontalAlignment.Center
            };
            TextBox BackMask = new TextBox()
            {
                Name = $"txtBM{v.Name}",
                Text = v.BackMask.ToString(),
                Location = new Point(175, 72),
                Font = font,
                Size = new Size(150, 39),
                TextAlign = HorizontalAlignment.Center
            };

            Label lblfreq = new Label()
            {
                Text = "Freq",
                Location = new Point(330, 11),
                Font = font,
                Size = new Size(60,29),
                TextAlign = ContentAlignment.MiddleCenter
            };
            ComboBox freq = new ComboBox()
            {
                Name = $"txtfreq{v.Name}",
                Location = new Point(330, 40),
                DataSource = v.Frequency,
                Font = font,
                Size = new Size(60, 29)
            };
            TextBox ManetStatus = new TextBox()
            {
                Name = $"txtManetStatus{v.Name}",
                Text = "MANET STATUS",
                Location = new Point(330, 72),
                Font = font,
                Size = new Size(140, 29),
                TextAlign = HorizontalAlignment.Center
            };
            TextBox EthStatus = new TextBox()
            {
                Name = $"txtEthStatus{v.Name}",
                Text = "ETH STATUS",
                Location = new Point(480, 72),
                Font = font,
                Size = new Size(140, 29),
                TextAlign = HorizontalAlignment.Center
            };

            Label lblbw = new Label()
            {
                Text = "BW",
                Location = new Point(400, 11),
                Font = font,
                Size = new Size(40, 29),
                TextAlign = ContentAlignment.MiddleCenter
            };
            ComboBox bw = new ComboBox()
            {
                Name = $"txtbw{v.Name}",
                Location = new Point(400, 40),
                DataSource = v.Bandwidth,
                Font = font,
                Size = new Size(40, 29)
            };

            Label lblld = new Label()
            {
                Text = "Dist",
                Location = new Point(450, 11),
                Font = font,
                Size = new Size(50, 29),
                TextAlign = ContentAlignment.MiddleCenter
            };
            ComboBox ld = new ComboBox()
            {
                Name = $"txtld{v.Name}",
                Location = new Point(450, 40),
                DataSource = v.LinkDistance,
                Font = font,
                Size = new Size(50, 29)
            };

            Label lblnd = new Label()
            {
                Text = "Density",
                Location = new Point(510, 11),
                Font = font,
                Size = new Size(100, 29),
                TextAlign = ContentAlignment.MiddleCenter
            };
            ComboBox nd = new ComboBox()
            {
                Name = $"txtnd{v.Name}",
                Location = new Point(510, 40),
                DataSource = v.NodeDensity,
                Font = font,
                Size = new Size(100, 29)
            };
            

            FrontDoorAddresses.Add(FrontDoor);
            Gbox.Controls.Add(FrontDoor);
            Gbox.Controls.Add(lblFrontDoor);
            Gbox.Controls.Add(FrontMask);
            Gbox.Controls.Add(BackDoor);
            Gbox.Controls.Add(lblBackDoor);
            Gbox.Controls.Add(BackMask);
            Gbox.Controls.Add(freq);
            Gbox.Controls.Add(lblfreq);
            Gbox.Controls.Add(bw);
            Gbox.Controls.Add(lblbw);
            Gbox.Controls.Add(ld);
            Gbox.Controls.Add(lblld);
            Gbox.Controls.Add(nd);
            Gbox.Controls.Add(lblnd);
            Gbox.Controls.Add(ManetStatus);
            Gbox.Controls.Add(EthStatus);


        }

        private void flpNodes_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        public int RandomOctet(int bot, int top)
        {
            Random r = new Random();
            int rInt = r.Next(bot, top);
            return rInt;
        }
        private bool IPv4InNetwork(IPAddress address, IPAddress subnet, IPAddress network)
        {
            

            
            if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) // IPv4
            {
                Byte[] addressOctets = address.GetAddressBytes();
                Byte[] subnetOctets = subnet.GetAddressBytes();
                Byte[] networkOctets = network.GetAddressBytes();
                return
                    (networkOctets[0] == (addressOctets[0] & subnetOctets[0])) &&
                    (networkOctets[1] == (addressOctets[1] & subnetOctets[1])) &&
                    (networkOctets[2] == (addressOctets[2] & subnetOctets[2])) &&
                    (networkOctets[3] == (addressOctets[3] & subnetOctets[3]));
            }
            else // IPv6
            {
                return false;
            }
        }
        public string HandleNullIPField(string ip)
        {
            if (ip == "")
            {
                return "0.0.0.0";
            }
            else
            {
                return ip;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> lookup = new Dictionary<string, string>()
            {
                {"MUAV", "10.0.0.0" },
                {"MPU5 Backdoor", "10.3.1.0" },
                {"MTS Backdoor", "10.4.0.0" }
            };

            Dictionary<string, string> subnetLookup = new Dictionary<string, string>()
            {
                {"MUAV", "255.128.0.0" },
                {"MPU5 Backdoor", "255.255.255.0" },
                {"MTS Backdoor", "255.255.0.0" }
            };

            IPAddress NWO = IPAddress.Parse(lookup[cbbNetwokOwner.SelectedItem.ToString()]);

            txtPcIP.Text = HandleNullIPField(txtPcIP.Text);
            txtSubnet.Text = HandleNullIPField(txtSubnet.Text);

            string currentSubnet = cbbNetwokOwner.SelectedItem.ToString();
            if (txtSubnet.Text != subnetLookup[cbbNetwokOwner.SelectedItem.ToString()])
            {
                txtSubnet.BackColor = Color.Crimson;
                txtSubnet.ForeColor = Color.White;
                Debug.WriteLine(currentSubnet);
                if (cbLearningMode.Checked)
                {
                    MessageBox.Show(
                    "Incorrect subnet for network owner\n\n" +
                    "For MUAV: 255.128.0.0\n\n" +
                    "For MPU5 Backdoor: 255.255.255.0\n\n" +
                    "For MTS Backdoor: 255.255.0.0", "Subnet Violation"
                    );
                    return;
                }
                
            }
            else
            {
                txtSubnet.BackColor = Color.LightGreen;
                txtSubnet.ForeColor = Color.Black;
            }

            if (!IPv4InNetwork(IPAddress.Parse(txtPcIP.Text), IPAddress.Parse(txtSubnet.Text), NWO))
            {
                
                txtPcIP.BackColor = Color.Crimson;
                txtPcIP.ForeColor = Color.White;
                if (cbLearningMode.Checked)
                {
                    switch (currentSubnet)
                    {
                        case "MUAV":
                            MessageBox.Show(
                                "The GCS computer's IP address is violating the MUAV subnet\n\n" +
                                "It must fall within a valid range for the network 10.0.0.0\n\n" +
                                "First octet must match exactly!\n\n Second octet should be between 1 and 127\n\n" +
                                "Third and fourth octet should be between 0 and 255\n\n" +
                                "Example: 10.80.55.20", "MUAV Address Violation"
                                );
                            return;
                        case "MPU5 Backdoor":
                            MessageBox.Show(
                                "The GCS computer's IP address is violating the MPU5 Backdoor subnet\n\n" +
                                "It must fall within a valid range for the network 10.3.1.0\n\n" +
                                "First three octets must match exactly!\n\n" +
                                "The fourth octet should be between 0 and 255\n\n" +
                                "Example: 10.3.1.20", "MPU5 Backdoor Address Violation"
                                );
                            return;
                        case "MTS Backdoor":
                            MessageBox.Show(
                                "The GCS computer's IP address is violating the MTS Backdoor subnet\n\n" +
                                "It must fall within a valid range for the network 10.4.0.0\n\n" +
                                "First and second octets must match exactly!\n\n" +
                                "Third and fourth octet should be between 0 and 255\n\n" +
                                "Example: 10.4.55.20", "MTS Backdoor Address Violation"
                                );
                            return;
                    }
                    
                }
                
            }
            else
            {
                txtPcIP.BackColor = Color.LightGreen;
                txtPcIP.ForeColor = Color.Black;
                
            }
            bool Node_Failed = false;
            // checking all at once test
            //todo change to iterate thru NodeTable dict and operate on FrontDoor property
            foreach (var item in FrontDoorAddresses)
            {
                item.Text = HandleNullIPField(item.Text);
                if (!IPv4InNetwork(IPAddress.Parse(item.Text), IPAddress.Parse(txtSubnet.Text), NWO))
                {
                    item.BackColor = Color.Crimson;
                    item.ForeColor = Color.White;
                    Node_Failed = true;
                }
                else
                {
                    item.BackColor = Color.LightGreen;
                    item.ForeColor = Color.Black;
                }

            }
            if (cbLearningMode.Checked)
            {
                if (Node_Failed)
                {
                    switch (currentSubnet)
                    {
                        case "MUAV":
                            MessageBox.Show(
                                "One or more nodes IP address are violating the MUAV subnet\n\n" +
                                "It must fall within a valid range for the network 10.0.0.0\n\n" +
                                "First octet must match exactly!\n\n Second octet should be between 1 and 127\n\n" +
                                "Third and fourth octet should be between 0 and 255\n\n" +
                                "Example: 10.80.55.20", "MUAV Address Violation"
                                );
                            return;
                        case "MPU5 Backdoor":
                            MessageBox.Show(
                                "One or more nodes IP address are violating the MPU5 Backdoor subnet\n\n" +
                                "It must fall within a valid range for the network 10.3.1.0\n\n" +
                                "First three octets must match exactly!\n\n" +
                                "The fourth octet should be between 0 and 255\n\n" +
                                "Example: 10.3.1.20", "MPU5 Backdoor Address Violation"
                                );
                            return;
                        case "MTS Backdoor":
                            MessageBox.Show(
                                "One or more nodes IP address are violating the MTS Backdoor subnet\n\n" +
                                "It must fall within a valid range for the network 10.4.0.0\n\n" +
                                "First and second octets must match exactly!\n\n" +
                                "Third and fourth octet should be between 0 and 255\n\n" +
                                "Example: 10.4.55.20", "MTS Backdoor Address Violation"
                                );
                            return;
                    }
                }
            }
        }

        private void btnCheckManet_Click(object sender, EventArgs e)
        {
            string currentSubnet = cbbNetwokOwner.SelectedItem.ToString();
            bool Node_Failed = false;
            foreach (var kvp in NodeTable)
            {
                string freq_name = $"txtfreq{kvp.Key}";
                ComboBox freq = (ComboBox)GetControlByName(flpNodes, freq_name);

                string bandwidth_name = $"txtbw{kvp.Key}";
                ComboBox bandwidth = (ComboBox)GetControlByName(flpNodes, bandwidth_name);

                string link_dist_name = $"txtld{kvp.Key}";
                ComboBox link_dist = (ComboBox)GetControlByName(flpNodes, link_dist_name);

                string node_dens_name = $"txtnd{kvp.Key}";
                ComboBox node_dens = (ComboBox)GetControlByName(flpNodes, node_dens_name);

                string manet_status_name = $"txtManetStatus{kvp.Key}";
                TextBox manetStatus = (TextBox)GetControlByName(flpNodes, manet_status_name);

                if (freq.SelectedItem.ToString() == cbbMasterFreq.SelectedItem.ToString() &&
                    bandwidth.SelectedItem.ToString() == cbbMasterBW.SelectedItem.ToString() &&
                    link_dist.SelectedItem.ToString() == cbbMasterDist.SelectedItem.ToString() &&
                    node_dens.SelectedItem.ToString() == cbbMaxDens.SelectedItem.ToString())
                {
                    manetStatus.BackColor = Color.LightGreen;
                    manetStatus.ForeColor = Color.Black;
                }
                else
                {
                    manetStatus.BackColor = Color.Crimson;
                    manetStatus.ForeColor = Color.White;
                    Node_Failed = true;
                    
                }
                
            } 
            if(cbLearningMode.Checked)
            {
                if (Node_Failed)
                {
                    MessageBox.Show(
                       "One or more nodes are violating the MPU5 mission settings\n\n" +
                       "All node manet fields must match MPU5 mission settings otherwise comminication won't be possible\n\n" +
                       "Make settings match exactly!\n\n", "Manet Violation"
                       );
                    return;
                }
            }
            
        }
        public Control GetControlByName(Control ParentCntl, string NameToSearch)
        {
            if (ParentCntl.Name == NameToSearch)
                return ParentCntl;

            foreach (Control ChildCntl in ParentCntl.Controls)
            {
                Control ResultCntl = GetControlByName(ChildCntl, NameToSearch);
                if (ResultCntl != null)
                    return ResultCntl;
            }
            return null;
        }
    }
    public class Node
    {
        public string Name { get; set; }
        public IPAddress FrontDoor { get; set; }
        public IPAddress FrontMask { get; set; }
        public IPAddress BackDoor { get; set; }
        public IPAddress BackMask { get; set; }
        public IPAddress DefaultRoute { get; set; }
        public IPAddress BackNetwork { get; set; }
        public List<IPAddress> Neighbors { get; set; } = new List<IPAddress>();
        public List<int> Frequency { get; set; } = new List<int>() { 2235, 2257, 2275, 2297, 2317, 2337, 2357, 2363, 2377, 2410, 2420, 2463};
        public List<int> LinkDistance { get; set; } = new List<int>() { 5, 10, 18, 60, 90, 130 };
        public List<string> NodeDensity { get; set; } = new List<string>() { "LOW(2)", "MED(3-8)", "HIGH(8+)" };
        public List<int> Bandwidth { get; set; } = new List<int>() { 5, 10, 20};
        public bool PCLink { get; set; } = false;

        //public Node(/*string name, string fdoor, string fmask, string bdoor, string bmask, string bnet*/)
        //{
        //    Name = name;
        //    FrontDoor = string2IP(fdoor);
        //    FrontMask = string2IP(fmask);
        //    BackDoor = string2IP(bdoor);
        //    BackMask = string2IP(bmask);
        //    BackNetwork = string2IP(bnet);
        //}

        public IPAddress string2IP(string ip)
        {
            if (ip == "")
            {
                return IPAddress.Parse("0.0.0.0");
            }
            else
            {
                return IPAddress.Parse(ip);
            }
        }
    }
}
