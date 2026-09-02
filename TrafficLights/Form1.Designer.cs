namespace TrafficLights
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
            this.ctrlTraficLight1 = new TrafficLights.ctrlTraficLight();
            this.SuspendLayout();
            // 
            // ctrlTraficLight1
            // 
            this.ctrlTraficLight1.CurrentColor = TrafficLights.ctrlTraficLight.enColors.YELLOW;
            this.ctrlTraficLight1.GreenTimer = 10;
            this.ctrlTraficLight1.Location = new System.Drawing.Point(303, 81);
            this.ctrlTraficLight1.Name = "ctrlTraficLight1";
            this.ctrlTraficLight1.RedTimer = 10;
            this.ctrlTraficLight1.Size = new System.Drawing.Size(190, 317);
            this.ctrlTraficLight1.TabIndex = 0;
            this.ctrlTraficLight1.YellowTimer = 3;
            this.ctrlTraficLight1.onRedLight += new System.EventHandler<TrafficLights.ctrlTraficLight.CustomEventArgs>(this.ctrlTraficLight1_onRedLight);
            this.ctrlTraficLight1.onGreenLight += new System.EventHandler<TrafficLights.ctrlTraficLight.CustomEventArgs>(this.ctrlTraficLight1_onGreenLight);
            this.ctrlTraficLight1.onYellowLight += new System.EventHandler<TrafficLights.ctrlTraficLight.CustomEventArgs>(this.ctrlTraficLight1_onYellowLight);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlTraficLight1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTraficLight ctrlTraficLight1;
    }
}

