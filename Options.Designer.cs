namespace LSPU_dventure
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            backlinkLabel1 = new LinkLabel();
            label1 = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(267, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1415, 456);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderColor = Color.LemonChiffon;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(489, 12);
            button1.Name = "button1";
            button1.Size = new Size(299, 426);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            // 
            // backlinkLabel1
            // 
            backlinkLabel1.ActiveLinkColor = Color.DarkCyan;
            backlinkLabel1.AutoSize = true;
            backlinkLabel1.BackColor = Color.LightSeaGreen;
            backlinkLabel1.Cursor = Cursors.Hand;
            backlinkLabel1.Font = new Font("Arial", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            backlinkLabel1.ForeColor = Color.White;
            backlinkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            backlinkLabel1.LinkColor = Color.White;
            backlinkLabel1.Location = new Point(-1, -3);
            backlinkLabel1.Name = "backlinkLabel1";
            backlinkLabel1.Size = new Size(60, 24);
            backlinkLabel1.TabIndex = 14;
            backlinkLabel1.TabStop = true;
            backlinkLabel1.Text = "Back";
            backlinkLabel1.LinkClicked += backlinkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(502, 22);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 15;
            label1.Text = "Settings";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(502, 76);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(backlinkLabel1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Options";
            Text = "Lspu Simulator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button button1;
        private LinkLabel backlinkLabel1;
        private Label label1;
        private CheckBox checkBox1;
    }
}