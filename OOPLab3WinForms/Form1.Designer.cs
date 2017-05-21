namespace OOPLab3WinForms
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
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.radioStrangeCone = new System.Windows.Forms.RadioButton();
            this.radioCone = new System.Windows.Forms.RadioButton();
            this.radioEllipse = new System.Windows.Forms.RadioButton();
            this.radioColoredCircle = new System.Windows.Forms.RadioButton();
            this.radioCircle = new System.Windows.Forms.RadioButton();
            this.radioPoint = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.positionX = new System.Windows.Forms.NumericUpDown();
            this.positionY = new System.Windows.Forms.NumericUpDown();
            this.positionZ = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rotationSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.colorR = new System.Windows.Forms.NumericUpDown();
            this.colorG = new System.Windows.Forms.NumericUpDown();
            this.colorB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lineSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pointSize = new System.Windows.Forms.NumericUpDown();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionZ)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointSize)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl1
            // 
            this.openGLControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openGLControl1.DrawFPS = true;
            this.openGLControl1.Location = new System.Drawing.Point(251, 11);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(665, 526);
            this.openGLControl1.TabIndex = 0;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 526);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImportButton);
            this.groupBox2.Controls.Add(this.ExportButton);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.DrawButton);
            this.groupBox2.Controls.Add(this.radioStrangeCone);
            this.groupBox2.Controls.Add(this.radioCone);
            this.groupBox2.Controls.Add(this.radioEllipse);
            this.groupBox2.Controls.Add(this.radioColoredCircle);
            this.groupBox2.Controls.Add(this.radioCircle);
            this.groupBox2.Controls.Add(this.radioPoint);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.positionX);
            this.groupBox2.Controls.Add(this.positionY);
            this.groupBox2.Controls.Add(this.positionZ);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(0, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(208, 393);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create figure";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ClearButton.Location = new System.Drawing.Point(0, 223);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(196, 32);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.DrawButton.Location = new System.Drawing.Point(0, 259);
            this.DrawButton.Margin = new System.Windows.Forms.Padding(2);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(196, 32);
            this.DrawButton.TabIndex = 24;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // radioStrangeCone
            // 
            this.radioStrangeCone.AutoSize = true;
            this.radioStrangeCone.Location = new System.Drawing.Point(7, 163);
            this.radioStrangeCone.Margin = new System.Windows.Forms.Padding(2);
            this.radioStrangeCone.Name = "radioStrangeCone";
            this.radioStrangeCone.Size = new System.Drawing.Size(93, 17);
            this.radioStrangeCone.TabIndex = 23;
            this.radioStrangeCone.Text = "Strange cone";
            this.radioStrangeCone.UseVisualStyleBackColor = true;
            // 
            // radioCone
            // 
            this.radioCone.AutoSize = true;
            this.radioCone.Location = new System.Drawing.Point(7, 141);
            this.radioCone.Margin = new System.Windows.Forms.Padding(2);
            this.radioCone.Name = "radioCone";
            this.radioCone.Size = new System.Drawing.Size(52, 17);
            this.radioCone.TabIndex = 22;
            this.radioCone.Text = "Cone";
            this.radioCone.UseVisualStyleBackColor = true;
            // 
            // radioEllipse
            // 
            this.radioEllipse.AutoSize = true;
            this.radioEllipse.Location = new System.Drawing.Point(7, 119);
            this.radioEllipse.Margin = new System.Windows.Forms.Padding(2);
            this.radioEllipse.Name = "radioEllipse";
            this.radioEllipse.Size = new System.Drawing.Size(58, 17);
            this.radioEllipse.TabIndex = 21;
            this.radioEllipse.Text = "Ellipse";
            this.radioEllipse.UseVisualStyleBackColor = true;
            // 
            // radioColoredCircle
            // 
            this.radioColoredCircle.AutoSize = true;
            this.radioColoredCircle.Location = new System.Drawing.Point(7, 98);
            this.radioColoredCircle.Margin = new System.Windows.Forms.Padding(2);
            this.radioColoredCircle.Name = "radioColoredCircle";
            this.radioColoredCircle.Size = new System.Drawing.Size(95, 17);
            this.radioColoredCircle.TabIndex = 20;
            this.radioColoredCircle.Text = "Colored circle";
            this.radioColoredCircle.UseVisualStyleBackColor = true;
            // 
            // radioCircle
            // 
            this.radioCircle.AutoSize = true;
            this.radioCircle.Location = new System.Drawing.Point(7, 76);
            this.radioCircle.Margin = new System.Windows.Forms.Padding(2);
            this.radioCircle.Name = "radioCircle";
            this.radioCircle.Size = new System.Drawing.Size(53, 17);
            this.radioCircle.TabIndex = 19;
            this.radioCircle.Text = "Circle";
            this.radioCircle.UseVisualStyleBackColor = true;
            // 
            // radioPoint
            // 
            this.radioPoint.AutoSize = true;
            this.radioPoint.Checked = true;
            this.radioPoint.Location = new System.Drawing.Point(7, 54);
            this.radioPoint.Margin = new System.Windows.Forms.Padding(2);
            this.radioPoint.Name = "radioPoint";
            this.radioPoint.Size = new System.Drawing.Size(52, 17);
            this.radioPoint.TabIndex = 18;
            this.radioPoint.TabStop = true;
            this.radioPoint.Text = "Point";
            this.radioPoint.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Position:";
            // 
            // positionX
            // 
            this.positionX.DecimalPlaces = 3;
            this.positionX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.positionX.Location = new System.Drawing.Point(61, 24);
            this.positionX.Margin = new System.Windows.Forms.Padding(2);
            this.positionX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.positionX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.positionX.Name = "positionX";
            this.positionX.Size = new System.Drawing.Size(41, 22);
            this.positionX.TabIndex = 16;
            // 
            // positionY
            // 
            this.positionY.DecimalPlaces = 3;
            this.positionY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.positionY.Location = new System.Drawing.Point(106, 24);
            this.positionY.Margin = new System.Windows.Forms.Padding(2);
            this.positionY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.positionY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.positionY.Name = "positionY";
            this.positionY.Size = new System.Drawing.Size(41, 22);
            this.positionY.TabIndex = 15;
            // 
            // positionZ
            // 
            this.positionZ.DecimalPlaces = 3;
            this.positionZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.positionZ.Location = new System.Drawing.Point(155, 24);
            this.positionZ.Margin = new System.Windows.Forms.Padding(2);
            this.positionZ.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.positionZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.positionZ.Name = "positionZ";
            this.positionZ.Size = new System.Drawing.Size(41, 22);
            this.positionZ.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rotationSpeed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.colorR);
            this.groupBox1.Controls.Add(this.colorG);
            this.groupBox1.Controls.Add(this.colorB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lineSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pointSize);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(208, 133);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rotation speed:";
            // 
            // rotationSpeed
            // 
            this.rotationSpeed.Location = new System.Drawing.Point(106, 87);
            this.rotationSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.rotationSpeed.Name = "rotationSpeed";
            this.rotationSpeed.Size = new System.Drawing.Size(90, 22);
            this.rotationSpeed.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Color:";
            // 
            // colorR
            // 
            this.colorR.Location = new System.Drawing.Point(61, 64);
            this.colorR.Margin = new System.Windows.Forms.Padding(2);
            this.colorR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorR.Name = "colorR";
            this.colorR.Size = new System.Drawing.Size(41, 22);
            this.colorR.TabIndex = 16;
            this.colorR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colorG
            // 
            this.colorG.Location = new System.Drawing.Point(106, 64);
            this.colorG.Margin = new System.Windows.Forms.Padding(2);
            this.colorG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorG.Name = "colorG";
            this.colorG.Size = new System.Drawing.Size(41, 22);
            this.colorG.TabIndex = 15;
            this.colorG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colorB
            // 
            this.colorB.Location = new System.Drawing.Point(155, 64);
            this.colorB.Margin = new System.Windows.Forms.Padding(2);
            this.colorB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.colorB.Name = "colorB";
            this.colorB.Size = new System.Drawing.Size(41, 22);
            this.colorB.TabIndex = 14;
            this.colorB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Line width:";
            // 
            // lineSize
            // 
            this.lineSize.Location = new System.Drawing.Point(106, 41);
            this.lineSize.Margin = new System.Windows.Forms.Padding(2);
            this.lineSize.Name = "lineSize";
            this.lineSize.Size = new System.Drawing.Size(90, 22);
            this.lineSize.TabIndex = 12;
            this.lineSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Point size:";
            // 
            // pointSize
            // 
            this.pointSize.Location = new System.Drawing.Point(106, 19);
            this.pointSize.Margin = new System.Windows.Forms.Padding(2);
            this.pointSize.Name = "pointSize";
            this.pointSize.Size = new System.Drawing.Size(90, 22);
            this.pointSize.TabIndex = 10;
            this.pointSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportButton.Location = new System.Drawing.Point(0, 296);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(196, 34);
            this.ExportButton.TabIndex = 26;
            this.ExportButton.Text = "Export Image";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ImportButton
            // 
            this.ImportButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportButton.Location = new System.Drawing.Point(0, 336);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(196, 33);
            this.ImportButton.TabIndex = 27;
            this.ImportButton.Text = "Import Image";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.openGLControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionZ)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.RadioButton radioStrangeCone;
        private System.Windows.Forms.RadioButton radioCone;
        private System.Windows.Forms.RadioButton radioEllipse;
        private System.Windows.Forms.RadioButton radioColoredCircle;
        private System.Windows.Forms.RadioButton radioCircle;
        private System.Windows.Forms.RadioButton radioPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown positionX;
        private System.Windows.Forms.NumericUpDown positionY;
        private System.Windows.Forms.NumericUpDown positionZ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown rotationSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown colorR;
        private System.Windows.Forms.NumericUpDown colorG;
        private System.Windows.Forms.NumericUpDown colorB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lineSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pointSize;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
    }
}

