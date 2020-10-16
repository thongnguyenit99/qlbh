namespace Quản_Lý_Bán_Hàng.GUI
{
    partial class MuaHang
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
            this.ucFuction1 = new Quản_Lý_Bán_Hàng.ucFuction();
            this.SuspendLayout();
            // 
            // ucFuction1
            // 
            this.ucFuction1.Location = new System.Drawing.Point(89, 33);
            this.ucFuction1.Name = "ucFuction1";
            this.ucFuction1.Size = new System.Drawing.Size(552, 68);
            this.ucFuction1.TabIndex = 0;
            // 
            // MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 268);
            this.Controls.Add(this.ucFuction1);
            this.Name = "MuaHang";
            this.Tag = "21";
            this.Text = "MuaHang";
            this.ResumeLayout(false);

        }

        #endregion

        private ucFuction ucFuction1;
    }
}