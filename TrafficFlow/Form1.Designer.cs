namespace TrafficFlow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddNode = new System.Windows.Forms.Button();
            this.cbbNodeType = new System.Windows.Forms.ComboBox();
            this.flpNodes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtPcIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbNetwokOwner = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheckManet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbMaxDens = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbMasterDist = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbMasterBW = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMasterFreq = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLearningMode = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNode
            // 
            this.btnAddNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNode.Location = new System.Drawing.Point(9, 150);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(324, 52);
            this.btnAddNode.TabIndex = 0;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // cbbNodeType
            // 
            this.cbbNodeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNodeType.FormattingEnabled = true;
            this.cbbNodeType.Items.AddRange(new object[] {
            "VBAT",
            "OMNI",
            "Tracker"});
            this.cbbNodeType.Location = new System.Drawing.Point(62, 86);
            this.cbbNodeType.Name = "cbbNodeType";
            this.cbbNodeType.Size = new System.Drawing.Size(207, 45);
            this.cbbNodeType.TabIndex = 1;
            // 
            // flpNodes
            // 
            this.flpNodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpNodes.AutoScroll = true;
            this.flpNodes.AutoSize = true;
            this.flpNodes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpNodes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flpNodes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNodes.Location = new System.Drawing.Point(13, 583);
            this.flpNodes.MaximumSize = new System.Drawing.Size(1336, 1154);
            this.flpNodes.MinimumSize = new System.Drawing.Size(1336, 200);
            this.flpNodes.Name = "flpNodes";
            this.flpNodes.Size = new System.Drawing.Size(1336, 200);
            this.flpNodes.TabIndex = 2;
            this.flpNodes.WrapContents = false;
            this.flpNodes.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpNodes_ControlAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Node Type";
            // 
            // txtSubnet
            // 
            this.txtSubnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubnet.Location = new System.Drawing.Point(314, 127);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(292, 44);
            this.txtSubnet.TabIndex = 6;
            this.txtSubnet.Text = "255.128.0.0";
            this.txtSubnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPcIP
            // 
            this.txtPcIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcIP.Location = new System.Drawing.Point(24, 127);
            this.txtPcIP.Name = "txtPcIP";
            this.txtPcIP.Size = new System.Drawing.Size(283, 44);
            this.txtPcIP.TabIndex = 7;
            this.txtPcIP.Text = "10.60.80.101";
            this.txtPcIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "IPv4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Subnet Mask";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(213, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "Check Network";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(681, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Network Owner";
            // 
            // cbbNetwokOwner
            // 
            this.cbbNetwokOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNetwokOwner.FormattingEnabled = true;
            this.cbbNetwokOwner.Items.AddRange(new object[] {
            "MUAV",
            "MPU5 Backdoor",
            "MTS Backdoor"});
            this.cbbNetwokOwner.Location = new System.Drawing.Point(613, 126);
            this.cbbNetwokOwner.Name = "cbbNetwokOwner";
            this.cbbNetwokOwner.Size = new System.Drawing.Size(332, 45);
            this.cbbNetwokOwner.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNode);
            this.groupBox1.Controls.Add(this.cbbNodeType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 246);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Nerwork";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCheckManet);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbbMaxDens);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbbMasterDist);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbbMasterBW);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbbMasterFreq);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSubnet);
            this.groupBox2.Controls.Add(this.cbbNetwokOwner);
            this.groupBox2.Controls.Add(this.txtPcIP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(374, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 557);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configure GCS";
            // 
            // btnCheckManet
            // 
            this.btnCheckManet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckManet.Location = new System.Drawing.Point(213, 478);
            this.btnCheckManet.Name = "btnCheckManet";
            this.btnCheckManet.Size = new System.Drawing.Size(488, 52);
            this.btnCheckManet.TabIndex = 25;
            this.btnCheckManet.Text = "Check Manet";
            this.btnCheckManet.UseVisualStyleBackColor = true;
            this.btnCheckManet.Click += new System.EventHandler(this.btnCheckManet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(737, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 37);
            this.label10.TabIndex = 24;
            this.label10.Text = "Link Desnity";
            // 
            // cbbMaxDens
            // 
            this.cbbMaxDens.FormattingEnabled = true;
            this.cbbMaxDens.Items.AddRange(new object[] {
            "LOW(2)",
            "MED(3-8)",
            "HIGH(8+)"});
            this.cbbMaxDens.Location = new System.Drawing.Point(716, 409);
            this.cbbMaxDens.Name = "cbbMaxDens";
            this.cbbMaxDens.Size = new System.Drawing.Size(230, 45);
            this.cbbMaxDens.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 37);
            this.label9.TabIndex = 22;
            this.label9.Text = "Link Distance";
            // 
            // cbbMasterDist
            // 
            this.cbbMasterDist.FormattingEnabled = true;
            this.cbbMasterDist.Items.AddRange(new object[] {
            "5",
            "10",
            "18",
            "60",
            "90",
            "130"});
            this.cbbMasterDist.Location = new System.Drawing.Point(470, 409);
            this.cbbMasterDist.Name = "cbbMasterDist";
            this.cbbMasterDist.Size = new System.Drawing.Size(209, 45);
            this.cbbMasterDist.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 37);
            this.label8.TabIndex = 20;
            this.label8.Text = "Bandwidth";
            // 
            // cbbMasterBW
            // 
            this.cbbMasterBW.FormattingEnabled = true;
            this.cbbMasterBW.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.cbbMasterBW.Location = new System.Drawing.Point(233, 409);
            this.cbbMasterBW.Name = "cbbMasterBW";
            this.cbbMasterBW.Size = new System.Drawing.Size(209, 45);
            this.cbbMasterBW.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "Freq";
            // 
            // cbbMasterFreq
            // 
            this.cbbMasterFreq.FormattingEnabled = true;
            this.cbbMasterFreq.Items.AddRange(new object[] {
            "2235",
            "2257",
            "2275",
            "2297",
            "2317",
            "2337",
            "2357",
            "2363",
            "2377",
            "2410",
            "2420",
            "2463"});
            this.cbbMasterFreq.Location = new System.Drawing.Point(24, 409);
            this.cbbMasterFreq.Name = "cbbMasterFreq";
            this.cbbMasterFreq.Size = new System.Drawing.Size(183, 45);
            this.cbbMasterFreq.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(428, 37);
            this.label5.TabIndex = 16;
            this.label5.Text = "MPU5 Mission Requirements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Computer";
            // 
            // cbLearningMode
            // 
            this.cbLearningMode.AutoSize = true;
            this.cbLearningMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLearningMode.Location = new System.Drawing.Point(62, 292);
            this.cbLearningMode.Name = "cbLearningMode";
            this.cbLearningMode.Size = new System.Drawing.Size(262, 41);
            this.cbLearningMode.TabIndex = 17;
            this.cbLearningMode.Text = "Learning Mode";
            this.cbLearningMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1357, 1009);
            this.Controls.Add(this.cbLearningMode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpNodes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2139, 1790);
            this.Name = "Form1";
            this.Text = "TrafficFlow - a VBAT network building tool V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.ComboBox cbbNodeType;
        private System.Windows.Forms.FlowLayoutPanel flpNodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtPcIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbNetwokOwner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbMaxDens;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbMasterDist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbMasterBW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMasterFreq;
        private System.Windows.Forms.Button btnCheckManet;
        private System.Windows.Forms.CheckBox cbLearningMode;
    }
}

