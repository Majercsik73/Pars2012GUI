
namespace Pars2012GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxNev = new System.Windows.Forms.ComboBox();
            this.labCsoport = new System.Windows.Forms.Label();
            this.labNemzet = new System.Windows.Forms.Label();
            this.labNemKod = new System.Windows.Forms.Label();
            this.labSorozat = new System.Windows.Forms.Label();
            this.labEredmeny = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxZaszlo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZaszlo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válasszon versenyzőt!";
            // 
            // cBoxNev
            // 
            this.cBoxNev.DropDownWidth = 150;
            this.cBoxNev.FormattingEnabled = true;
            this.cBoxNev.Location = new System.Drawing.Point(236, 77);
            this.cBoxNev.Name = "cBoxNev";
            this.cBoxNev.Size = new System.Drawing.Size(150, 24);
            this.cBoxNev.TabIndex = 1;
            this.cBoxNev.SelectedIndexChanged += new System.EventHandler(this.cBoxNev_SelectedIndexChanged);
            // 
            // labCsoport
            // 
            this.labCsoport.AutoSize = true;
            this.labCsoport.Location = new System.Drawing.Point(236, 123);
            this.labCsoport.Name = "labCsoport";
            this.labCsoport.Size = new System.Drawing.Size(38, 17);
            this.labCsoport.TabIndex = 2;
            this.labCsoport.Text = "csop";
            // 
            // labNemzet
            // 
            this.labNemzet.AutoSize = true;
            this.labNemzet.Location = new System.Drawing.Point(236, 169);
            this.labNemzet.Name = "labNemzet";
            this.labNemzet.Size = new System.Drawing.Size(54, 17);
            this.labNemzet.TabIndex = 3;
            this.labNemzet.Text = "nemzet";
            // 
            // labNemKod
            // 
            this.labNemKod.AutoSize = true;
            this.labNemKod.Location = new System.Drawing.Point(236, 211);
            this.labNemKod.Name = "labNemKod";
            this.labNemKod.Size = new System.Drawing.Size(31, 17);
            this.labNemKod.TabIndex = 4;
            this.labNemKod.Text = "kod";
            // 
            // labSorozat
            // 
            this.labSorozat.AutoSize = true;
            this.labSorozat.Location = new System.Drawing.Point(236, 250);
            this.labSorozat.Name = "labSorozat";
            this.labSorozat.Size = new System.Drawing.Size(28, 17);
            this.labSorozat.TabIndex = 5;
            this.labSorozat.Text = "sor";
            // 
            // labEredmeny
            // 
            this.labEredmeny.AutoSize = true;
            this.labEredmeny.Location = new System.Drawing.Point(236, 295);
            this.labEredmeny.Name = "labEredmeny";
            this.labEredmeny.Size = new System.Drawing.Size(37, 17);
            this.labEredmeny.TabIndex = 6;
            this.labEredmeny.Text = "ered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zászló:";
            // 
            // picBoxZaszlo
            // 
            this.picBoxZaszlo.Location = new System.Drawing.Point(236, 387);
            this.picBoxZaszlo.Name = "picBoxZaszlo";
            this.picBoxZaszlo.Size = new System.Drawing.Size(550, 400);
            this.picBoxZaszlo.TabIndex = 8;
            this.picBoxZaszlo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 829);
            this.Controls.Add(this.picBoxZaszlo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labEredmeny);
            this.Controls.Add(this.labSorozat);
            this.Controls.Add(this.labNemKod);
            this.Controls.Add(this.labNemzet);
            this.Controls.Add(this.labCsoport);
            this.Controls.Add(this.cBoxNev);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "London 2012 - Férfi kalapácsvetés - Selejtező";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxZaszlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxNev;
        private System.Windows.Forms.Label labCsoport;
        private System.Windows.Forms.Label labNemzet;
        private System.Windows.Forms.Label labNemKod;
        private System.Windows.Forms.Label labSorozat;
        private System.Windows.Forms.Label labEredmeny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxZaszlo;
    }
}

