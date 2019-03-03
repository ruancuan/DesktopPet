using System.Drawing;
using System;
using System.Timers;
using System.Windows.Forms;

namespace Snowy
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
                      
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrDrag = new System.Windows.Forms.Timer(this.components);
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.天气ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.笑话ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开QQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开模拟器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开SteamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开战网ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开纸飞机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.眨眼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.衣柜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圣诞帽子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.樱花帽子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水手帽ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.风车帽子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圣诞衣服ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.和服ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反应Label = new System.Windows.Forms.Label();
            this.对话Form = new System.Windows.Forms.Form();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.rightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDrag
            // 
            this.tmrDrag.Tick += new System.EventHandler(this.tmrDrag_Tick);

            //
            //设置对话Form
            //
            this.对话Form.TopMost = true;
            this.对话Form.Location = new Point(-20 + Location.X, -10 + Location.Y);
            this.对话Form.FormBorderStyle = FormBorderStyle.None;
            this.对话Form.BackColor = Color.Fuchsia;
            this.对话Form.TransparencyKey = Color.Fuchsia;
            this.对话Form.Size = new Size(1080, 900);
            this.对话Form.Show();

            //
            //label赋值
            //
            this.反应Label.AutoSize = true;
            this.反应Label.Text = "我肥来了";
            this.反应Label.Parent = this.对话Form;
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.功能ToolStripMenuItem,
            this.眨眼ToolStripMenuItem,
            this.衣柜ToolStripMenuItem});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(176, 104);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            //
            //功能ToolStripMenuItem
            //
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.功能ToolStripMenuItem.Text = "功能";
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
                this.天气ToolStripMenuItem,
                this.笑话ToolStripMenuItem,
                this.打开QQToolStripMenuItem,
                this.打开音乐ToolStripMenuItem,
                this.打开模拟器ToolStripMenuItem,
                this.打开SteamToolStripMenuItem,
                this.打开战网ToolStripMenuItem,
                this.打开纸飞机ToolStripMenuItem
            });
            
            //
            //天气ToolStripMenuItem
            //
            this.天气ToolStripMenuItem.Name = "天气ToolStripMenuItem";
            this.天气ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.天气ToolStripMenuItem.Text = "天气";
            this.天气ToolStripMenuItem.Click += new System.EventHandler(this.天气ToolStripMenuItem_Click);
            //
            //笑话ToolStripMenuItem
            //
            // 
            this.笑话ToolStripMenuItem.Name = "笑话ToolStripMenuItem";
            this.笑话ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.笑话ToolStripMenuItem.Text = "讲个笑话";
            this.笑话ToolStripMenuItem.Click += new System.EventHandler(this.笑话ToolStripMenuItem_Click);
            //
            //打开QQToolStripMenu
            //
            //
            this.打开QQToolStripMenuItem.Name = "打开QQToolStripMenuItem";
            this.打开QQToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.打开QQToolStripMenuItem.Text = "打开QQ";
            this.打开QQToolStripMenuItem.Click += new System.EventHandler(this.打开QQToolStripMenuItem_Click);
            //
            //打开音乐ToolStripMenu
            //
            this.打开音乐ToolStripMenuItem.Name = "打开音乐ToolStripMenuItem";
            this.打开音乐ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.打开音乐ToolStripMenuItem.Text = "打开音乐";
            this.打开音乐ToolStripMenuItem.Click += new System.EventHandler(this.打开音乐ToolStripMenuItem_Click);
            //
            //打开模拟器ToolStripMenu
            //
            this.打开模拟器ToolStripMenuItem.Name = "打开模拟器ToolStripMenuItem";
            this.打开模拟器ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.打开模拟器ToolStripMenuItem.Text = "打开模拟器";
            this.打开模拟器ToolStripMenuItem.Click += new System.EventHandler(this.打开模拟器ToolStripMenuItem_Click);
            //
            //打开SteamToolStripMenu
            //
            this.打开SteamToolStripMenuItem.Name = "打开SteamToolStripMenuItem";
            this.打开SteamToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.打开SteamToolStripMenuItem.Text = "打开Steam";
            this.打开SteamToolStripMenuItem.Click += new System.EventHandler(this.打开SteamToolStripMenuItem_Click);
            //
            //打开战网ToolStripMenu
            //
            this.打开战网ToolStripMenuItem.Name = "打开战网ToolStripMenuItem";
            this.打开战网ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.打开战网ToolStripMenuItem.Text = "打开战网";
            this.打开战网ToolStripMenuItem.Click += new System.EventHandler(this.打开战网ToolStripMenuItem_Click);
            //
            //打开纸飞机ToolStripMenuItem
            //
            this.打开纸飞机ToolStripMenuItem.Name = "打开纸飞机ToolStripMenuItem";
            this.打开纸飞机ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.打开纸飞机ToolStripMenuItem.Text = "打开纸飞机";
            this.打开纸飞机ToolStripMenuItem.Click += new System.EventHandler(this.打开纸飞机ToolStripMenuItem_Click);
            //
            // 眨眼ToolStripMenuItem
            // 
            this.眨眼ToolStripMenuItem.Name = "眨眼ToolStripMenuItem";
            this.眨眼ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.眨眼ToolStripMenuItem.Text = "眨眼";
            this.眨眼ToolStripMenuItem.Click += new System.EventHandler(this.眨眼ToolStripMenuItem_Click);
            // 
            // 衣柜ToolStripMenuItem
            // 
            this.衣柜ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.圣诞帽子ToolStripMenuItem,
            this.樱花帽子ToolStripMenuItem,
            this.水手帽ToolStripMenuItem,
            this.风车帽子ToolStripMenuItem,
            this.圣诞衣服ToolStripMenuItem,
            this.和服ToolStripMenuItem});
            this.衣柜ToolStripMenuItem.Name = "衣柜ToolStripMenuItem";
            this.衣柜ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.衣柜ToolStripMenuItem.Text = "衣柜";
            // 
            // 圣诞帽子ToolStripMenuItem
            // 
            this.圣诞帽子ToolStripMenuItem.Name = "圣诞帽子ToolStripMenuItem";
            this.圣诞帽子ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.圣诞帽子ToolStripMenuItem.Text = "帽子 — 圣诞";
            this.圣诞帽子ToolStripMenuItem.Click += new System.EventHandler(this.帽子ToolStripMenuItem_Click);
            // 
            // 樱花帽子ToolStripMenuItem
            // 
            this.樱花帽子ToolStripMenuItem.Name = "樱花帽子ToolStripMenuItem";
            this.樱花帽子ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.樱花帽子ToolStripMenuItem.Text = "帽子 — 樱花";
            this.樱花帽子ToolStripMenuItem.Click += new System.EventHandler(this.帽子ToolStripMenuItem_Click);
            // 
            // 水手帽ToolStripMenuItem
            // 
            this.水手帽ToolStripMenuItem.Name = "水手帽ToolStripMenuItem";
            this.水手帽ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.水手帽ToolStripMenuItem.Text = "帽子 — 水手帽";
            this.水手帽ToolStripMenuItem.Click += new System.EventHandler(this.帽子ToolStripMenuItem_Click);
            // 
            // 风车帽子ToolStripMenuItem
            // 
            this.风车帽子ToolStripMenuItem.Name = "风车帽子ToolStripMenuItem";
            this.风车帽子ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.风车帽子ToolStripMenuItem.Text = "帽子 — 风车";
            this.风车帽子ToolStripMenuItem.Click += new System.EventHandler(this.帽子ToolStripMenuItem_Click);
            // 
            // 圣诞衣服ToolStripMenuItem
            // 
            this.圣诞衣服ToolStripMenuItem.Name = "圣诞衣服ToolStripMenuItem";
            this.圣诞衣服ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.圣诞衣服ToolStripMenuItem.Text = "衣服 — 圣诞";
            this.圣诞衣服ToolStripMenuItem.Click += new System.EventHandler(this.衣服ToolStripMenuItem_Click);
            // 
            // 和服ToolStripMenuItem
            // 
            this.和服ToolStripMenuItem.Name = "和服ToolStripMenuItem";
            this.和服ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.和服ToolStripMenuItem.Text = "衣服 — 和服";
            this.和服ToolStripMenuItem.Click += new System.EventHandler(this.衣服ToolStripMenuItem_Click);
            // 
            // tmrBlink
            // 
            this.tmrBlink.Tick += new System.EventHandler(this.tmrBlink_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.rightClickMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            #region 设置Icon
            Bitmap iconBit = new Bitmap(Application.StartupPath + "\\nico.ico");
            System.IntPtr iconHandle = iconBit.GetHicon();
            this.对话Form.Icon=Icon.FromHandle(iconHandle);
            this.Icon = Icon.FromHandle(iconHandle);
            #endregion

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 303);
            this.ContextMenuStrip = this.rightClickMenu;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.rightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrDrag;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem 眨眼ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 天气ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 笑话ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开QQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开音乐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开模拟器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开SteamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开战网ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开纸飞机ToolStripMenuItem;
        private System.Windows.Forms.Timer tmrBlink;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 衣柜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圣诞帽子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圣诞衣服ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 樱花帽子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水手帽ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 和服ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 风车帽子ToolStripMenuItem;
        private System.Windows.Forms.Label 反应Label;
        private System.Windows.Forms.Form 对话Form;
    }
}

