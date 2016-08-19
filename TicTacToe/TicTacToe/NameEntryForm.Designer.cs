namespace TicTacToe
{
    partial class NameEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.TextBox();
            this.submit_names = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player One Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player Two  Name:";
            // 
            // Player1
            // 
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(154, 14);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(213, 26);
            this.Player1.TabIndex = 2;
            // 
            // Player2
            // 
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(154, 55);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(213, 26);
            this.Player2.TabIndex = 3;
            this.Player2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Player2_KeyPress);
            // 
            // submit_names
            // 
            this.submit_names.Location = new System.Drawing.Point(154, 87);
            this.submit_names.Name = "submit_names";
            this.submit_names.Size = new System.Drawing.Size(75, 23);
            this.submit_names.TabIndex = 4;
            this.submit_names.Text = "Submit";
            this.submit_names.UseVisualStyleBackColor = true;
            this.submit_names.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameEntryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(375, 123);
            this.Controls.Add(this.submit_names);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(391, 162);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(391, 162);
            this.Name = "NameEntryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Player1;
        private System.Windows.Forms.TextBox Player2;
        private System.Windows.Forms.Button submit_names;
    }
}