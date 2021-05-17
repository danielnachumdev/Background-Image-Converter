
namespace Background_Image_Convertor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ColorTrackBar = new System.Windows.Forms.TrackBar();
            this.ColorButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TopCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BottomCheckBox = new System.Windows.Forms.CheckBox();
            this.RightCheckBox = new System.Windows.Forms.CheckBox();
            this.LeftCheckBox = new System.Windows.Forms.CheckBox();
            this.TopNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BottomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LeftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OutlinePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ColorTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericUpDown)).BeginInit();
            this.OutlinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(13, 865);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(1553, 97);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preview:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Enabled = false;
            this.PathTextBox.Location = new System.Drawing.Point(138, 10);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(1428, 31);
            this.PathTextBox.TabIndex = 3;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(89, 8);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(43, 34);
            this.SelectButton.TabIndex = 4;
            this.SelectButton.Text = "...";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ColorTrackBar
            // 
            this.ColorTrackBar.Location = new System.Drawing.Point(13, 755);
            this.ColorTrackBar.Maximum = 9;
            this.ColorTrackBar.Name = "ColorTrackBar";
            this.ColorTrackBar.Size = new System.Drawing.Size(1176, 69);
            this.ColorTrackBar.TabIndex = 7;
            this.ColorTrackBar.Scroll += new System.EventHandler(this.ColorTrackBar_Scroll);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(1195, 756);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(77, 68);
            this.ColorButton.TabIndex = 8;
            this.ColorButton.Text = "...";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1292, 773);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selected Color:";
            // 
            // TopCheckBox
            // 
            this.TopCheckBox.AutoSize = true;
            this.TopCheckBox.Checked = true;
            this.TopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopCheckBox.Location = new System.Drawing.Point(1, 39);
            this.TopCheckBox.Name = "TopCheckBox";
            this.TopCheckBox.Size = new System.Drawing.Size(67, 29);
            this.TopCheckBox.TabIndex = 10;
            this.TopCheckBox.Text = "Top";
            this.TopCheckBox.UseVisualStyleBackColor = true;
            this.TopCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Remove dark Outline";
            // 
            // BottomCheckBox
            // 
            this.BottomCheckBox.AutoSize = true;
            this.BottomCheckBox.Checked = true;
            this.BottomCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BottomCheckBox.Location = new System.Drawing.Point(0, 74);
            this.BottomCheckBox.Name = "BottomCheckBox";
            this.BottomCheckBox.Size = new System.Drawing.Size(98, 29);
            this.BottomCheckBox.TabIndex = 12;
            this.BottomCheckBox.Text = "Bottom";
            this.BottomCheckBox.UseVisualStyleBackColor = true;
            this.BottomCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // RightCheckBox
            // 
            this.RightCheckBox.AutoSize = true;
            this.RightCheckBox.Location = new System.Drawing.Point(0, 109);
            this.RightCheckBox.Name = "RightCheckBox";
            this.RightCheckBox.Size = new System.Drawing.Size(80, 29);
            this.RightCheckBox.TabIndex = 13;
            this.RightCheckBox.Text = "Right";
            this.RightCheckBox.UseVisualStyleBackColor = true;
            this.RightCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // LeftCheckBox
            // 
            this.LeftCheckBox.AutoSize = true;
            this.LeftCheckBox.Location = new System.Drawing.Point(0, 144);
            this.LeftCheckBox.Name = "LeftCheckBox";
            this.LeftCheckBox.Size = new System.Drawing.Size(67, 29);
            this.LeftCheckBox.TabIndex = 14;
            this.LeftCheckBox.Text = "Left";
            this.LeftCheckBox.UseVisualStyleBackColor = true;
            this.LeftCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // TopNumericUpDown
            // 
            this.TopNumericUpDown.DecimalPlaces = 2;
            this.TopNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.TopNumericUpDown.Location = new System.Drawing.Point(137, 38);
            this.TopNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.TopNumericUpDown.Name = "TopNumericUpDown";
            this.TopNumericUpDown.Size = new System.Drawing.Size(96, 31);
            this.TopNumericUpDown.TabIndex = 15;
            this.TopNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TopNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "%";
            // 
            // BottomNumericUpDown
            // 
            this.BottomNumericUpDown.DecimalPlaces = 2;
            this.BottomNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.BottomNumericUpDown.Location = new System.Drawing.Point(137, 73);
            this.BottomNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.BottomNumericUpDown.Name = "BottomNumericUpDown";
            this.BottomNumericUpDown.Size = new System.Drawing.Size(96, 31);
            this.BottomNumericUpDown.TabIndex = 20;
            this.BottomNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.BottomNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // RightNumericUpDown
            // 
            this.RightNumericUpDown.DecimalPlaces = 2;
            this.RightNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.RightNumericUpDown.Location = new System.Drawing.Point(137, 108);
            this.RightNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.RightNumericUpDown.Name = "RightNumericUpDown";
            this.RightNumericUpDown.Size = new System.Drawing.Size(96, 31);
            this.RightNumericUpDown.TabIndex = 21;
            this.RightNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RightNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // LeftNumericUpDown
            // 
            this.LeftNumericUpDown.DecimalPlaces = 2;
            this.LeftNumericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.LeftNumericUpDown.Location = new System.Drawing.Point(137, 143);
            this.LeftNumericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.LeftNumericUpDown.Name = "LeftNumericUpDown";
            this.LeftNumericUpDown.Size = new System.Drawing.Size(96, 31);
            this.LeftNumericUpDown.TabIndex = 22;
            this.LeftNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.LeftNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // OutlinePanel
            // 
            this.OutlinePanel.Controls.Add(this.label3);
            this.OutlinePanel.Controls.Add(this.LeftNumericUpDown);
            this.OutlinePanel.Controls.Add(this.TopCheckBox);
            this.OutlinePanel.Controls.Add(this.RightNumericUpDown);
            this.OutlinePanel.Controls.Add(this.BottomCheckBox);
            this.OutlinePanel.Controls.Add(this.BottomNumericUpDown);
            this.OutlinePanel.Controls.Add(this.RightCheckBox);
            this.OutlinePanel.Controls.Add(this.label8);
            this.OutlinePanel.Controls.Add(this.LeftCheckBox);
            this.OutlinePanel.Controls.Add(this.label7);
            this.OutlinePanel.Controls.Add(this.TopNumericUpDown);
            this.OutlinePanel.Controls.Add(this.label6);
            this.OutlinePanel.Controls.Add(this.label4);
            this.OutlinePanel.Enabled = false;
            this.OutlinePanel.Location = new System.Drawing.Point(12, 116);
            this.OutlinePanel.Name = "OutlinePanel";
            this.OutlinePanel.Size = new System.Drawing.Size(239, 179);
            this.OutlinePanel.TabIndex = 23;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 974);
            this.Controls.Add(this.OutlinePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.ColorTrackBar);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 1030);
            this.MinimumSize = new System.Drawing.Size(1600, 1030);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Background Image Converter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ColorTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftNumericUpDown)).EndInit();
            this.OutlinePanel.ResumeLayout(false);
            this.OutlinePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.TrackBar ColorTrackBar;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox TopCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox BottomCheckBox;
        private System.Windows.Forms.CheckBox RightCheckBox;
        private System.Windows.Forms.CheckBox LeftCheckBox;
        private System.Windows.Forms.NumericUpDown TopNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown BottomNumericUpDown;
        private System.Windows.Forms.NumericUpDown RightNumericUpDown;
        private System.Windows.Forms.NumericUpDown LeftNumericUpDown;
        private System.Windows.Forms.Panel OutlinePanel;
    }
}

