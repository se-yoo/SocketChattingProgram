﻿namespace _3510
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.myPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.myIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yourPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yourIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nickname = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.sendText = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.myPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.myIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "본인 정보";
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(56, 64);
            this.myPort.Name = "myPort";
            this.myPort.Size = new System.Drawing.Size(151, 22);
            this.myPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // myIP
            // 
            this.myIP.Location = new System.Drawing.Point(56, 35);
            this.myIP.Name = "myIP";
            this.myIP.Size = new System.Drawing.Size(151, 22);
            this.myIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yourPort);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.yourIP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(259, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상대방 정보";
            // 
            // yourPort
            // 
            this.yourPort.Location = new System.Drawing.Point(56, 64);
            this.yourPort.Name = "yourPort";
            this.yourPort.Size = new System.Drawing.Size(151, 22);
            this.yourPort.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port";
            // 
            // yourIP
            // 
            this.yourIP.Location = new System.Drawing.Point(56, 35);
            this.yourIP.Name = "yourIP";
            this.yourIP.Size = new System.Drawing.Size(151, 22);
            this.yourIP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(495, 13);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(93, 108);
            this.connect.TabIndex = 2;
            this.connect.Text = "연결";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 14);
            this.label5.TabIndex = 3;
            this.label5.Text = "내 이름(수정가능)";
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(157, 133);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(162, 22);
            this.nickname.TabIndex = 4;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(14, 172);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(573, 208);
            this.content.TabIndex = 5;
            // 
            // sendText
            // 
            this.sendText.Location = new System.Drawing.Point(15, 398);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(485, 22);
            this.sendText.TabIndex = 6;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(507, 395);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(80, 25);
            this.send.TabIndex = 7;
            this.send.Text = "전송";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 439);
            this.Controls.Add(this.send);
            this.Controls.Add(this.sendText);
            this.Controls.Add(this.content);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox myIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox yourIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yourPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nickname;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.TextBox sendText;
        private System.Windows.Forms.Button send;
    }
}

