
namespace TCKimlikSorgulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.btn_Sorgula = new System.Windows.Forms.Button();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txt_isim
            // 
            resources.ApplyResources(this.txt_isim, "txt_isim");
            this.txt_isim.Name = "txt_isim";
            // 
            // txt_soyisim
            // 
            resources.ApplyResources(this.txt_soyisim, "txt_soyisim");
            this.txt_soyisim.Name = "txt_soyisim";
            // 
            // txt_yil
            // 
            resources.ApplyResources(this.txt_yil, "txt_yil");
            this.txt_yil.Name = "txt_yil";
            // 
            // txt_tc
            // 
            resources.ApplyResources(this.txt_tc, "txt_tc");
            this.txt_tc.Name = "txt_tc";
            // 
            // btn_Sorgula
            // 
            resources.ApplyResources(this.btn_Sorgula, "btn_Sorgula");
            this.btn_Sorgula.Name = "btn_Sorgula";
            this.btn_Sorgula.UseVisualStyleBackColor = true;
            this.btn_Sorgula.Click += new System.EventHandler(this.btn_Sorgula_Click);
            // 
            // lbl_Sonuc
            // 
            resources.ApplyResources(this.lbl_Sonuc, "lbl_Sonuc");
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.btn_Sorgula);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.txt_yil);
            this.Controls.Add(this.txt_soyisim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Button btn_Sorgula;
        private System.Windows.Forms.Label lbl_Sonuc;
    }
}

