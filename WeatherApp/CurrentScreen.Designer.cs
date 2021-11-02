
namespace WeatherApp
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.nextLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cityOutput.Location = new System.Drawing.Point(17, 67);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(52, 25);
            this.cityOutput.TabIndex = 0;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tempLabel.Location = new System.Drawing.Point(13, 110);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(56, 59);
            this.tempLabel.TabIndex = 1;
            this.tempLabel.Text = "0";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minOutput.Location = new System.Drawing.Point(231, 155);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(26, 25);
            this.minOutput.TabIndex = 2;
            this.minOutput.Text = "0";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maxOutput.Location = new System.Drawing.Point(231, 102);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(26, 25);
            this.maxOutput.TabIndex = 3;
            this.maxOutput.Text = "0";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateOutput
            // 
            this.dateOutput.AutoSize = true;
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateOutput.Location = new System.Drawing.Point(17, 17);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(52, 25);
            this.dateOutput.TabIndex = 4;
            this.dateOutput.Text = "Nov";
            this.dateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextLabel
            // 
            this.nextLabel.AutoSize = true;
            this.nextLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextLabel.Location = new System.Drawing.Point(17, 504);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(115, 25);
            this.nextLabel.TabIndex = 5;
            this.nextLabel.Text = "Next days";
            this.nextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextLabel.Click += new System.EventHandler(this.nextLabel_Click);
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.conditionLabel.Location = new System.Drawing.Point(18, 217);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(112, 25);
            this.conditionLabel.TabIndex = 6;
            this.conditionLabel.Text = "Condition";
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.Transparent;
            this.iconBox.Location = new System.Drawing.Point(124, 93);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(101, 102);
            this.iconBox.TabIndex = 7;
            this.iconBox.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.nextLabel);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.cityOutput);
            this.DoubleBuffered = true;
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(300, 550);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label nextLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.PictureBox iconBox;
    }
}
