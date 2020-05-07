namespace AIO_Remote
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.MessageGroup = new System.Windows.Forms.GroupBox();
            this.TxBox = new System.Windows.Forms.TextBox();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonInput = new System.Windows.Forms.Button();
            this.RemoteGroup = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.MessageGroup.SuspendLayout();
            this.RemoteGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageGroup
            // 
            this.MessageGroup.Controls.Add(this.buttonSend);
            this.MessageGroup.Controls.Add(this.TxBox);
            this.MessageGroup.Controls.Add(this.MessageBox);
            this.MessageGroup.Location = new System.Drawing.Point(12, 313);
            this.MessageGroup.Name = "MessageGroup";
            this.MessageGroup.Size = new System.Drawing.Size(318, 228);
            this.MessageGroup.TabIndex = 21;
            this.MessageGroup.TabStop = false;
            this.MessageGroup.Text = "RS232 Message";
            // 
            // TxBox
            // 
            this.TxBox.BackColor = System.Drawing.SystemColors.Window;
            this.TxBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxBox.Location = new System.Drawing.Point(6, 21);
            this.TxBox.Multiline = true;
            this.TxBox.Name = "TxBox";
            this.TxBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxBox.Size = new System.Drawing.Size(200, 48);
            this.TxBox.TabIndex = 1;
            // 
            // MessageBox
            // 
            this.MessageBox.BackColor = System.Drawing.SystemColors.Window;
            this.MessageBox.Location = new System.Drawing.Point(6, 75);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageBox.Size = new System.Drawing.Size(303, 147);
            this.MessageBox.TabIndex = 0;
            // 
            // buttonUp
            // 
            this.buttonUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonUp.Location = new System.Drawing.Point(109, 129);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(97, 48);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(109, 237);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(97, 48);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.ButtonDown_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(109, 183);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(97, 48);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(212, 183);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(97, 48);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(212, 21);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(97, 48);
            this.buttonPower.TabIndex = 4;
            this.buttonPower.Text = "Power";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.ButtonPower_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(6, 183);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(97, 48);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(6, 21);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(97, 48);
            this.buttonOpen.TabIndex = 16;
            this.buttonOpen.Text = "Open Com  Port";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(6, 75);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(97, 48);
            this.buttonMenu.TabIndex = 17;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // buttonInput
            // 
            this.buttonInput.Location = new System.Drawing.Point(212, 75);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(97, 48);
            this.buttonInput.TabIndex = 19;
            this.buttonInput.Text = "Input";
            this.buttonInput.UseVisualStyleBackColor = true;
            // 
            // RemoteGroup
            // 
            this.RemoteGroup.Controls.Add(this.buttonOpen);
            this.RemoteGroup.Controls.Add(this.buttonPower);
            this.RemoteGroup.Controls.Add(this.buttonInput);
            this.RemoteGroup.Controls.Add(this.buttonLeft);
            this.RemoteGroup.Controls.Add(this.buttonMenu);
            this.RemoteGroup.Controls.Add(this.buttonRight);
            this.RemoteGroup.Controls.Add(this.buttonEnter);
            this.RemoteGroup.Controls.Add(this.buttonDown);
            this.RemoteGroup.Controls.Add(this.buttonUp);
            this.RemoteGroup.Location = new System.Drawing.Point(12, 12);
            this.RemoteGroup.Name = "RemoteGroup";
            this.RemoteGroup.Size = new System.Drawing.Size(318, 295);
            this.RemoteGroup.TabIndex = 22;
            this.RemoteGroup.TabStop = false;
            this.RemoteGroup.Text = "Remote Controller";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(212, 21);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(97, 48);
            this.buttonSend.TabIndex = 20;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(342, 553);
            this.Controls.Add(this.MessageGroup);
            this.Controls.Add(this.RemoteGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIO Remote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MessageGroup.ResumeLayout(false);
            this.MessageGroup.PerformLayout();
            this.RemoteGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox MessageGroup;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.GroupBox RemoteGroup;
        private System.Windows.Forms.TextBox TxBox;
        private System.Windows.Forms.Button buttonSend;
    }
}

