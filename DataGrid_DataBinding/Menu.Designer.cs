
namespace DataGrid_DataBinding
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.binding = new System.Windows.Forms.PictureBox();
            this.gridv = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.binding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridv)).BeginInit();
            this.SuspendLayout();
            // 
            // binding
            // 
            this.binding.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("binding.BackgroundImage")));
            this.binding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.binding.Location = new System.Drawing.Point(78, 115);
            this.binding.Name = "binding";
            this.binding.Size = new System.Drawing.Size(171, 106);
            this.binding.TabIndex = 1;
            this.binding.TabStop = false;
            this.binding.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gridv
            // 
            this.gridv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridv.BackgroundImage")));
            this.gridv.Location = new System.Drawing.Point(309, 115);
            this.gridv.Name = "gridv";
            this.gridv.Size = new System.Drawing.Size(165, 106);
            this.gridv.TabIndex = 2;
            this.gridv.TabStop = false;
            this.gridv.Click += new System.EventHandler(this.gridv_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Cornsilk;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back.Location = new System.Drawing.Point(78, 294);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Menu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Menu
            // 
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(557, 378);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back);
            this.Controls.Add(this.gridv);
            this.Controls.Add(this.binding);
            this.Name = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.binding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox binding;
        private System.Windows.Forms.PictureBox gridv;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label6;
    }
}