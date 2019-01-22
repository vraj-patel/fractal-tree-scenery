namespace Pythagoras_Tree
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
            this.components = new System.ComponentModel.Container();
            this.EntireScenePicBox = new System.Windows.Forms.PictureBox();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.AnimationButton = new System.Windows.Forms.Button();
            this.WindTrackBar = new System.Windows.Forms.TrackBar();
            this.WindForceLabel = new System.Windows.Forms.Label();
            this.TimeOfDayLabel = new System.Windows.Forms.Label();
            this.WinterRButton = new System.Windows.Forms.RadioButton();
            this.SpringRButton = new System.Windows.Forms.RadioButton();
            this.SummerRButton = new System.Windows.Forms.RadioButton();
            this.FallRButton = new System.Windows.Forms.RadioButton();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.TimeOfDayListBox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EntireScenePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // EntireScenePicBox
            // 
            this.EntireScenePicBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EntireScenePicBox.Location = new System.Drawing.Point(182, 18);
            this.EntireScenePicBox.Name = "EntireScenePicBox";
            this.EntireScenePicBox.Size = new System.Drawing.Size(790, 450);
            this.EntireScenePicBox.TabIndex = 0;
            this.EntireScenePicBox.TabStop = false;
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 90;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // AnimationButton
            // 
            this.AnimationButton.Location = new System.Drawing.Point(42, 408);
            this.AnimationButton.Name = "AnimationButton";
            this.AnimationButton.Size = new System.Drawing.Size(101, 46);
            this.AnimationButton.TabIndex = 2;
            this.AnimationButton.Text = "Start/Randomize Animation";
            this.AnimationButton.UseVisualStyleBackColor = true;
            this.AnimationButton.Click += new System.EventHandler(this.AnimationButton_Click);
            // 
            // WindTrackBar
            // 
            this.WindTrackBar.LargeChange = 1;
            this.WindTrackBar.Location = new System.Drawing.Point(15, 358);
            this.WindTrackBar.Name = "WindTrackBar";
            this.WindTrackBar.Size = new System.Drawing.Size(149, 45);
            this.WindTrackBar.TabIndex = 3;
            this.WindTrackBar.Scroll += new System.EventHandler(this.WindTrackBar_Scroll);
            // 
            // WindForceLabel
            // 
            this.WindForceLabel.AutoSize = true;
            this.WindForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindForceLabel.Location = new System.Drawing.Point(46, 329);
            this.WindForceLabel.Name = "WindForceLabel";
            this.WindForceLabel.Size = new System.Drawing.Size(90, 20);
            this.WindForceLabel.TabIndex = 4;
            this.WindForceLabel.Text = "Wind Force";
            // 
            // TimeOfDayLabel
            // 
            this.TimeOfDayLabel.AutoSize = true;
            this.TimeOfDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOfDayLabel.Location = new System.Drawing.Point(40, 94);
            this.TimeOfDayLabel.Name = "TimeOfDayLabel";
            this.TimeOfDayLabel.Size = new System.Drawing.Size(93, 20);
            this.TimeOfDayLabel.TabIndex = 5;
            this.TimeOfDayLabel.Text = "Time of Day";
            // 
            // WinterRButton
            // 
            this.WinterRButton.AutoSize = true;
            this.WinterRButton.Location = new System.Drawing.Point(59, 216);
            this.WinterRButton.Name = "WinterRButton";
            this.WinterRButton.Size = new System.Drawing.Size(56, 17);
            this.WinterRButton.TabIndex = 8;
            this.WinterRButton.TabStop = true;
            this.WinterRButton.Text = "Winter";
            this.WinterRButton.UseVisualStyleBackColor = true;
            // 
            // SpringRButton
            // 
            this.SpringRButton.AutoSize = true;
            this.SpringRButton.Location = new System.Drawing.Point(59, 239);
            this.SpringRButton.Name = "SpringRButton";
            this.SpringRButton.Size = new System.Drawing.Size(55, 17);
            this.SpringRButton.TabIndex = 9;
            this.SpringRButton.TabStop = true;
            this.SpringRButton.Text = "Spring";
            this.SpringRButton.UseVisualStyleBackColor = true;
            // 
            // SummerRButton
            // 
            this.SummerRButton.AutoSize = true;
            this.SummerRButton.Location = new System.Drawing.Point(59, 262);
            this.SummerRButton.Name = "SummerRButton";
            this.SummerRButton.Size = new System.Drawing.Size(63, 17);
            this.SummerRButton.TabIndex = 10;
            this.SummerRButton.TabStop = true;
            this.SummerRButton.Text = "Summer";
            this.SummerRButton.UseVisualStyleBackColor = true;
            // 
            // FallRButton
            // 
            this.FallRButton.AutoSize = true;
            this.FallRButton.Location = new System.Drawing.Point(59, 285);
            this.FallRButton.Name = "FallRButton";
            this.FallRButton.Size = new System.Drawing.Size(41, 17);
            this.FallRButton.TabIndex = 11;
            this.FallRButton.TabStop = true;
            this.FallRButton.Text = "Fall";
            this.FallRButton.UseVisualStyleBackColor = true;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonLabel.Location = new System.Drawing.Point(54, 178);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(64, 20);
            this.SeasonLabel.TabIndex = 12;
            this.SeasonLabel.Text = "Season";
            // 
            // TimeOfDayListBox
            // 
            this.TimeOfDayListBox.FormattingEnabled = true;
            this.TimeOfDayListBox.Items.AddRange(new object[] {
            "  Day Time",
            "  Night Time"});
            this.TimeOfDayListBox.Location = new System.Drawing.Point(53, 127);
            this.TimeOfDayListBox.Name = "TimeOfDayListBox";
            this.TimeOfDayListBox.Size = new System.Drawing.Size(70, 30);
            this.TimeOfDayListBox.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(22, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(135, 59);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "  The Life of Fractal Trees";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 480);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TimeOfDayListBox);
            this.Controls.Add(this.SeasonLabel);
            this.Controls.Add(this.FallRButton);
            this.Controls.Add(this.SummerRButton);
            this.Controls.Add(this.SpringRButton);
            this.Controls.Add(this.WinterRButton);
            this.Controls.Add(this.TimeOfDayLabel);
            this.Controls.Add(this.WindForceLabel);
            this.Controls.Add(this.WindTrackBar);
            this.Controls.Add(this.AnimationButton);
            this.Controls.Add(this.EntireScenePicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EntireScenePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EntireScenePicBox;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Button AnimationButton;
        private System.Windows.Forms.TrackBar WindTrackBar;
        private System.Windows.Forms.Label WindForceLabel;
        private System.Windows.Forms.Label TimeOfDayLabel;
        private System.Windows.Forms.RadioButton WinterRButton;
        private System.Windows.Forms.RadioButton SpringRButton;
        private System.Windows.Forms.RadioButton SummerRButton;
        private System.Windows.Forms.RadioButton FallRButton;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.ListBox TimeOfDayListBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

