
namespace CargoShipWinForm
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
            this.trackCycles = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackCars = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackTrucks = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackTrains = new System.Windows.Forms.TrackBar();
            this.buttonNewShip = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTrucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTrains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackCycles
            // 
            this.trackCycles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackCycles.Location = new System.Drawing.Point(12, 203);
            this.trackCycles.Name = "trackCycles";
            this.trackCycles.Size = new System.Drawing.Size(222, 45);
            this.trackCycles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cycles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "3 Units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "5 Units";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cars";
            // 
            // trackCars
            // 
            this.trackCars.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackCars.Location = new System.Drawing.Point(240, 203);
            this.trackCars.Name = "trackCars";
            this.trackCars.Size = new System.Drawing.Size(222, 45);
            this.trackCars.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "11 Units";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Trucks";
            // 
            // trackTrucks
            // 
            this.trackTrucks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackTrucks.Location = new System.Drawing.Point(12, 280);
            this.trackTrucks.Name = "trackTrucks";
            this.trackTrucks.Size = new System.Drawing.Size(222, 45);
            this.trackTrucks.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "17 Units";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Trains";
            // 
            // trackTrains
            // 
            this.trackTrains.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackTrains.Location = new System.Drawing.Point(240, 280);
            this.trackTrains.Name = "trackTrains";
            this.trackTrains.Size = new System.Drawing.Size(222, 45);
            this.trackTrains.TabIndex = 10;
            // 
            // buttonNewShip
            // 
            this.buttonNewShip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewShip.Location = new System.Drawing.Point(369, 331);
            this.buttonNewShip.Name = "buttonNewShip";
            this.buttonNewShip.Size = new System.Drawing.Size(93, 31);
            this.buttonNewShip.TabIndex = 13;
            this.buttonNewShip.Text = "New Ship";
            this.buttonNewShip.UseVisualStyleBackColor = true;
            this.buttonNewShip.Click += new System.EventHandler(this.buttonNewShip_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::CargoShipWinForm.Properties.Resources.cargoship;
            this.pictureBox1.Image = global::CargoShipWinForm.Properties.Resources.cargoship;
            this.pictureBox1.InitialImage = global::CargoShipWinForm.Properties.Resources.cargoship1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(96, 55);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 55);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 436);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonNewShip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackTrains);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackTrucks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackCars);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackCycles);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cargo Ship Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTrucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTrains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackCycles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackCars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackTrucks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackTrains;
        private System.Windows.Forms.Button buttonNewShip;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

