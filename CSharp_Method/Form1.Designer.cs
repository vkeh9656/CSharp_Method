namespace CSharp_Method
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxResult = new System.Windows.Forms.TextBox();
            this.tBoxNum1 = new System.Windows.Forms.TextBox();
            this.tBoxNum2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxResult
            // 
            this.tBoxResult.Enabled = false;
            this.tBoxResult.Location = new System.Drawing.Point(29, 23);
            this.tBoxResult.Name = "tBoxResult";
            this.tBoxResult.Size = new System.Drawing.Size(204, 21);
            this.tBoxResult.TabIndex = 0;
            this.tBoxResult.Text = "0";
            // 
            // tBoxNum1
            // 
            this.tBoxNum1.Location = new System.Drawing.Point(29, 50);
            this.tBoxNum1.Name = "tBoxNum1";
            this.tBoxNum1.Size = new System.Drawing.Size(100, 21);
            this.tBoxNum1.TabIndex = 1;
            this.tBoxNum1.Text = "0";
            // 
            // tBoxNum2
            // 
            this.tBoxNum2.Location = new System.Drawing.Point(133, 50);
            this.tBoxNum2.Name = "tBoxNum2";
            this.tBoxNum2.Size = new System.Drawing.Size(100, 21);
            this.tBoxNum2.TabIndex = 2;
            this.tBoxNum2.Text = "0";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(29, 92);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(45, 50);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(80, 92);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(45, 50);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(131, 92);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(45, 50);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(182, 92);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(45, 50);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 180);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.tBoxNum2);
            this.Controls.Add(this.tBoxNum1);
            this.Controls.Add(this.tBoxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxResult;
        private System.Windows.Forms.TextBox tBoxNum1;
        private System.Windows.Forms.TextBox tBoxNum2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivision;
    }
}

