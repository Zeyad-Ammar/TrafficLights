namespace TrafficLights
{
    partial class ctrlTraficLight
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
            this.components = new System.ComponentModel.Container();
            this.pbTrafficLight = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTrafficLight
            // 
            this.pbTrafficLight.Image = global::TrafficLights.Properties.Resources.AllLights;
            this.pbTrafficLight.Location = new System.Drawing.Point(0, 0);
            this.pbTrafficLight.Name = "pbTrafficLight";
            this.pbTrafficLight.Size = new System.Drawing.Size(190, 263);
            this.pbTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrafficLight.TabIndex = 0;
            this.pbTrafficLight.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(77, 277);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(36, 25);
            this.lbTimer.TabIndex = 1;
            this.lbTimer.Text = "??";
            // 
            // ctrlTraficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.pbTrafficLight);
            this.Name = "ctrlTraficLight";
            this.Size = new System.Drawing.Size(190, 317);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTrafficLight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTimer;
    }
}
