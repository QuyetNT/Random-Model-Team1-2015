namespace DrawDiagramStatus
{
    partial class Frm_Draw_Drg_Status
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
            this.SuspendLayout();
            // 
            // Frm_Draw_Drg_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 458);
            this.Name = "Frm_Draw_Drg_Status";
            this.Text = "Random Model - Team I - Sơ đồ các trạng thái";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw_Diagram_Status_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}

