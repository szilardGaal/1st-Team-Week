namespace processNote
{
    partial class Form2
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
            this.commentBox = new System.Windows.Forms.TextBox();
            this.addComment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commentBox
            // 
            this.commentBox.Location = new System.Drawing.Point(20, 12);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(348, 115);
            this.commentBox.TabIndex = 1;
            this.commentBox.TextChanged += new System.EventHandler(this.commentBox_TextChanged);
            // 
            // addComment
            // 
            this.addComment.Location = new System.Drawing.Point(20, 133);
            this.addComment.Name = "addComment";
            this.addComment.Size = new System.Drawing.Size(98, 23);
            this.addComment.TabIndex = 2;
            this.addComment.Text = "Add comment";
            this.addComment.UseVisualStyleBackColor = true;
            this.addComment.Click += new System.EventHandler(this.addComment_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 172);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addComment);
            this.Controls.Add(this.commentBox);
            this.Name = "Form2";
            this.Text = "Comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Button addComment;
        private System.Windows.Forms.Button button2;
    }
}