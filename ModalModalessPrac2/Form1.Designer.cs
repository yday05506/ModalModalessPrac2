using System;
using System.Windows.Forms;

namespace ModalModalessPrac2
{
    partial class Form1 : Form
    {
        class CustomForm : Form
        {
            public CustomForm()
            {
                Text = "제목 글자";
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            // IsMdiContainer = true;
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");
            
            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            }while(result == DialogResult.Retry);
            if(result == DialogResult.Cancel)
            {
                MessageBox.Show("사용자가 취소하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            // form.MdiParent = this;
            form.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            // form.MdiParent = this;
            form.ShowDialog();
        }
    }
}

