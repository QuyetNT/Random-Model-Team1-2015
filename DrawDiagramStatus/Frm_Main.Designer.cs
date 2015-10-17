namespace DrawDiagramStatus
{
    partial class Frm_Main
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
            this.m_txt_matrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_btn_check_connection = new System.Windows.Forms.Button();
            this.m_num_node_i = new System.Windows.Forms.NumericUpDown();
            this.m_num_node_j = new System.Windows.Forms.NumericUpDown();
            this.m_lbl_message = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_draw_diagram = new System.Windows.Forms.Button();
            this.m_btn_phan_lop = new System.Windows.Forms.Button();
            this.m_btn_hoi_quy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_btn_check_transition = new System.Windows.Forms.Button();
            this.m_btn_save_matrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_num_node_i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_num_node_j)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_txt_matrix
            // 
            this.m_txt_matrix.Location = new System.Drawing.Point(12, 65);
            this.m_txt_matrix.Multiline = true;
            this.m_txt_matrix.Name = "m_txt_matrix";
            this.m_txt_matrix.Size = new System.Drawing.Size(274, 189);
            this.m_txt_matrix.TabIndex = 0;
            this.m_txt_matrix.Text = "0.7 0 0.3 0 0 0 0\r\n0.2 0.8 0 0 0 0 0\r\n0 0.3 0 0.7 0 0 0\r\n0 0 0 0.4 0.4 0 0.2\r\n0 0" +
    " 0 0 0.5 0.5 0\r\n0 0 0 0.2 0 0.8 0\r\n0 0 0 0 0 0 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma trận";
            // 
            // m_btn_check_connection
            // 
            this.m_btn_check_connection.Enabled = false;
            this.m_btn_check_connection.Image = global::DrawDiagramStatus.Properties.Resources.Add_16x16;
            this.m_btn_check_connection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btn_check_connection.Location = new System.Drawing.Point(4, 73);
            this.m_btn_check_connection.Name = "m_btn_check_connection";
            this.m_btn_check_connection.Size = new System.Drawing.Size(160, 30);
            this.m_btn_check_connection.TabIndex = 2;
            this.m_btn_check_connection.Text = "Kiểm tra liên thông";
            this.m_btn_check_connection.UseVisualStyleBackColor = true;
            // 
            // m_num_node_i
            // 
            this.m_num_node_i.Location = new System.Drawing.Point(72, 47);
            this.m_num_node_i.Name = "m_num_node_i";
            this.m_num_node_i.Size = new System.Drawing.Size(40, 20);
            this.m_num_node_i.TabIndex = 3;
            // 
            // m_num_node_j
            // 
            this.m_num_node_j.Location = new System.Drawing.Point(72, 19);
            this.m_num_node_j.Name = "m_num_node_j";
            this.m_num_node_j.Size = new System.Drawing.Size(40, 20);
            this.m_num_node_j.TabIndex = 3;
            // 
            // m_lbl_message
            // 
            this.m_lbl_message.Enabled = false;
            this.m_lbl_message.Location = new System.Drawing.Point(12, 356);
            this.m_lbl_message.Name = "m_lbl_message";
            this.m_lbl_message.Size = new System.Drawing.Size(480, 176);
            this.m_lbl_message.TabIndex = 5;
            this.m_lbl_message.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kết quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_num_node_i);
            this.groupBox1.Controls.Add(this.m_num_node_j);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_btn_check_connection);
            this.groupBox1.Location = new System.Drawing.Point(16, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểm tra tính liên thông";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạng thái ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trạng thái ";
            // 
            // btn_draw_diagram
            // 
            this.btn_draw_diagram.Enabled = false;
            this.btn_draw_diagram.Image = global::DrawDiagramStatus.Properties.Resources.Add_16x16;
            this.btn_draw_diagram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_draw_diagram.Location = new System.Drawing.Point(20, 191);
            this.btn_draw_diagram.Name = "btn_draw_diagram";
            this.btn_draw_diagram.Size = new System.Drawing.Size(160, 30);
            this.btn_draw_diagram.TabIndex = 2;
            this.btn_draw_diagram.Text = "Sơ đồ các trạng thái";
            this.btn_draw_diagram.UseVisualStyleBackColor = true;
            this.btn_draw_diagram.Click += new System.EventHandler(this.btn_draw_diagram_Click);
            // 
            // m_btn_phan_lop
            // 
            this.m_btn_phan_lop.Enabled = false;
            this.m_btn_phan_lop.Image = global::DrawDiagramStatus.Properties.Resources.Add_16x16;
            this.m_btn_phan_lop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btn_phan_lop.Location = new System.Drawing.Point(20, 232);
            this.m_btn_phan_lop.Name = "m_btn_phan_lop";
            this.m_btn_phan_lop.Size = new System.Drawing.Size(160, 30);
            this.m_btn_phan_lop.TabIndex = 2;
            this.m_btn_phan_lop.Text = "Phân lớp trạng thái";
            this.m_btn_phan_lop.UseVisualStyleBackColor = true;
            this.m_btn_phan_lop.Click += new System.EventHandler(this.m_btn_phan_lop_Click);
            // 
            // m_btn_hoi_quy
            // 
            this.m_btn_hoi_quy.Enabled = false;
            this.m_btn_hoi_quy.Image = global::DrawDiagramStatus.Properties.Resources.Add_16x16;
            this.m_btn_hoi_quy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btn_hoi_quy.Location = new System.Drawing.Point(20, 268);
            this.m_btn_hoi_quy.Name = "m_btn_hoi_quy";
            this.m_btn_hoi_quy.Size = new System.Drawing.Size(160, 30);
            this.m_btn_hoi_quy.TabIndex = 2;
            this.m_btn_hoi_quy.Text = "Xét tính hồi quy";
            this.m_btn_hoi_quy.UseVisualStyleBackColor = true;
            this.m_btn_hoi_quy.Click += new System.EventHandler(this.m_btn_hoi_quy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(158, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Team I - Random Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(64, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_btn_check_transition);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_draw_diagram);
            this.groupBox2.Controls.Add(this.m_btn_phan_lop);
            this.groupBox2.Controls.Add(this.m_btn_hoi_quy);
            this.groupBox2.Location = new System.Drawing.Point(292, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 303);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // m_btn_check_transition
            // 
            this.m_btn_check_transition.Enabled = false;
            this.m_btn_check_transition.Image = global::DrawDiagramStatus.Properties.Resources.Add_16x16;
            this.m_btn_check_transition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btn_check_transition.Location = new System.Drawing.Point(20, 29);
            this.m_btn_check_transition.Name = "m_btn_check_transition";
            this.m_btn_check_transition.Size = new System.Drawing.Size(160, 30);
            this.m_btn_check_transition.TabIndex = 2;
            this.m_btn_check_transition.Text = "Kiểm tra ma trận chuyển";
            this.m_btn_check_transition.UseVisualStyleBackColor = true;
            // 
            // m_btn_save_matrix
            // 
            this.m_btn_save_matrix.Image = global::DrawDiagramStatus.Properties.Resources.Save_32x32;
            this.m_btn_save_matrix.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.m_btn_save_matrix.Location = new System.Drawing.Point(59, 273);
            this.m_btn_save_matrix.Name = "m_btn_save_matrix";
            this.m_btn_save_matrix.Size = new System.Drawing.Size(153, 36);
            this.m_btn_save_matrix.TabIndex = 2;
            this.m_btn_save_matrix.Text = "Lưu ma trận";
            this.m_btn_save_matrix.UseVisualStyleBackColor = true;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_lbl_message);
            this.Controls.Add(this.m_btn_save_matrix);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_txt_matrix);
            this.Name = "Frm_Main";
            this.Text = "Chương trình chính";
            ((System.ComponentModel.ISupportInitialize)(this.m_num_node_i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_num_node_j)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_matrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_btn_save_matrix;
        private System.Windows.Forms.Button m_btn_check_transition;
        private System.Windows.Forms.Button m_btn_check_connection;
        private System.Windows.Forms.NumericUpDown m_num_node_i;
        private System.Windows.Forms.NumericUpDown m_num_node_j;
        private System.Windows.Forms.RichTextBox m_lbl_message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_draw_diagram;
        private System.Windows.Forms.Button m_btn_phan_lop;
        private System.Windows.Forms.Button m_btn_hoi_quy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}