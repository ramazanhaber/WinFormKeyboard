namespace WinFormKeyboard
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
            this.keyboardcontrol1 = new WinFormKeyboard.Keyboardcontrol();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnTamam = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // keyboardcontrol1
            // 
            this.keyboardcontrol1.Dock = System.Windows.Forms.DockStyle.Top;
            this.keyboardcontrol1.KeyboardType = WinFormKeyboard.BoW.Standard;
            this.keyboardcontrol1.Location = new System.Drawing.Point(0, 78);
            this.keyboardcontrol1.Name = "keyboardcontrol1";
            this.keyboardcontrol1.Size = new System.Drawing.Size(1034, 282);
            this.keyboardcontrol1.TabIndex = 2;
            this.keyboardcontrol1.UserKeyPressed += new WinFormKeyboard.KeyboardDelegate(this.keyboardcontrol1_UserKeyPressed);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAciklama.Location = new System.Drawing.Point(0, 0);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(1034, 78);
            this.txtAciklama.TabIndex = 3;
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnIptal.Location = new System.Drawing.Point(0, 360);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(184, 69);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İPTAL ET";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamam.Appearance.Options.UseFont = true;
            this.btnTamam.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTamam.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnTamam.Location = new System.Drawing.Point(850, 360);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(184, 69);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 429);
            this.ControlBox = false;
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.keyboardcontrol1);
            this.Controls.Add(this.txtAciklama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EKRAN KLAVYESİ";
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Keyboardcontrol keyboardcontrol1;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.SimpleButton btnTamam;
    }
}

