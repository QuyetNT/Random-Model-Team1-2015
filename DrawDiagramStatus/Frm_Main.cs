using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawDiagramStatus
{
    public partial class Frm_Main : Form
    {
        #region Fields
        RandomModelProgram mRandomModelProgram;

        #endregion

        #region Public Methods
        public Frm_Main()
        {
            InitializeComponent();
            InitMembers();
            InitUI();
        }
        #endregion

        #region Private Methods
        private void InitMembers()
        {
            mRandomModelProgram = new RandomModelProgram();
        }
              
        private void InitUI()
        {
            // 
            m_btn_save_matrix.Click += m_btn_save_matrix_Click;
            m_btn_check_transition.Click += m_btn_check_transition_Click;
            m_btn_check_connection.Click += m_btn_check_connection_Click;
        }

        private void showMessage(bool state, String stateTrue, String stateFalse)
        {
            //string message;
            if (state)
            {
                //message = stateTrue;
                //m_lbl_message.Text = "Thành công";
                m_lbl_message.Text = stateTrue;
                m_lbl_message.ForeColor = Color.Green;
            }
            else
            {
                //message = stateFalse;
                //m_lbl_message.Text = "Thất bại";
                m_lbl_message.Text = stateFalse;
                m_lbl_message.ForeColor = Color.Red;
            }

            //MessageBox.Show(message);
        }

        private bool checkisMatrixNull()
        {
            if (mRandomModelProgram.mMatrix == null)
                return true;
            return false;
        }
        #endregion

        #region Events
        void m_btn_check_connection_Click(object sender, EventArgs e)
        {
            int i = (int)m_num_node_i.Value;
            int j = (int)m_num_node_j.Value;

            showMessage(mRandomModelProgram.IsConnected(i, j),
                        "Hai trạng thái có liên thông",
                        "Hai trạng thái không liên thông");
        }

        void m_btn_check_transition_Click(object sender, EventArgs e)
        {
            showMessage(mRandomModelProgram.IsTransitionMatrix(mRandomModelProgram.mMatrix),
                        "Ma trận có là ma trận chuyển",
                        "Ma trận không là ma trận chuyển");
        }

        void m_btn_save_matrix_Click(object sender, EventArgs e)
        {
            String[] rows = m_txt_matrix.Text.Split('\n');
            int size = rows.Length;
            Double[,] matrix = new Double[size, size];
            for (int i = 0; i < size; i++)
            {
                String[] cols = rows[i].Split(' ');
                for (int j = 0; j < size; j++)
                {
                    try
                    {
                        matrix[i, j] = cols[j] != null ? Double.Parse(cols[j]) : 0;
                    }
                    catch (FormatException fe)
                    {
                        matrix[i, j] = 0;
                    }
                    catch (IndexOutOfRangeException ioore)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            mRandomModelProgram.mMatrix = matrix;

            mRandomModelProgram.checkConnectionBetweenNodes();

            btn_draw_diagram.Enabled = true;
            m_btn_check_connection.Enabled = true;
            m_btn_check_transition.Enabled = true;
            m_btn_phan_lop.Enabled = true;
            m_btn_hoi_quy.Enabled = true;

            m_num_node_i.Maximum = size - 1;
            m_num_node_j.Maximum = size - 1;

            m_lbl_message.Text = "Lưu ma trận thành công\n" + mRandomModelProgram.PrintMatrix(mRandomModelProgram.mMatrix);            
            m_lbl_message.ForeColor = Color.Green;
        }

        private void btn_draw_diagram_Click(object sender, EventArgs e)
        {
            Frm_Draw_Drg_Status frm_driagram = new Frm_Draw_Drg_Status(mRandomModelProgram.mMatrix);
            frm_driagram.Show();
        }

        #endregion                             

        private void m_btn_phan_lop_Click(object sender, EventArgs e)
        {
            m_lbl_message.ForeColor = Color.Green;
            m_lbl_message.Text = "Lớp các trạng thái:\n" + mRandomModelProgram.DSStateType(mRandomModelProgram.mMatrix);
        }

        private void m_btn_hoi_quy_Click(object sender, EventArgs e)
        {

        }
    }
}
