namespace Practice1
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
            this.calculate = new System.Windows.Forms.Button();
            this.value1Box = new System.Windows.Forms.TextBox();
            this.value2Box = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(627, 174);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(148, 146);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // value1Box
            // 
            this.value1Box.Location = new System.Drawing.Point(33, 174);
            this.value1Box.Name = "value1Box";
            this.value1Box.Size = new System.Drawing.Size(175, 25);
            this.value1Box.TabIndex = 1;
            // 
            // value2Box
            // 
            this.value2Box.Location = new System.Drawing.Point(421, 176);
            this.value2Box.Name = "value2Box";
            this.value2Box.Size = new System.Drawing.Size(177, 25);
            this.value2Box.TabIndex = 2;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(230, 295);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(169, 25);
            this.resultBox.TabIndex = 3;
            // 
            // operation
            // 
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "곱하기",
            "나누기",
            "나머지",
            "Pow",
            "Max"});
            this.operation.Location = new System.Drawing.Point(230, 176);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(169, 23);
            this.operation.TabIndex = 4;
            this.operation.Text = "연산자를 선택하시오";
            this.operation.SelectedIndexChanged += new System.EventHandler(this.operation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Value1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Value2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.value2Box);
            this.Controls.Add(this.value1Box);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox value1Box;
        private System.Windows.Forms.TextBox value2Box;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.ComboBox operation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

