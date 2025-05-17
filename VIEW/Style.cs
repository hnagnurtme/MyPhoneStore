using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class Style
{
    public static void ApplyStyleToFormControls(Form form)
    {
        form.BackColor = ColorTranslator.FromHtml("#000842");
        form.FormBorderStyle = FormBorderStyle.Sizable;
        form.MaximizeBox = true; // Cho phép phóng to form
        form.MinimizeBox = true; // Cho phép thu nhỏ form
        void StyleControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is GroupBox groupBox)
                {
                    groupBox.BackColor = ColorTranslator.FromHtml("#f5ecff");
                    ApplyRounded(groupBox, 20);
                }
                else
                if (ctrl is Panel panel)
                {
                    panel.BackColor = ColorTranslator.FromHtml("#f5ecff");
                    ApplyRounded(panel, 5);
                }
                else if (ctrl is Button btn)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#000842");
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.UseVisualStyleBackColor = false;
                    btn.Font = new Font(btn.Font, FontStyle.Bold);
                    ApplyRounded(btn, 5);
                }
                else if (ctrl is TextBox tb)
                {
                    tb.BorderStyle = BorderStyle.None;
                    tb.BackColor = ColorTranslator.FromHtml("#faf8ff");
                    tb.ForeColor = ColorTranslator.FromHtml("#000842");
                    tb.Font = new Font("Segoe UI", 10);
                }

                if (ctrl.HasChildren)
                {
                    StyleControls(ctrl);
                }
            }
        }

        StyleControls(form);
    }

    private static void ApplyRounded(Control control, int borderRadius)
    {
        if (control == null || borderRadius <= 0)
            return;

        Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);
        int diameter = borderRadius * 2;

        GraphicsPath path = new GraphicsPath();

        // Góc trên trái
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
        // Đường trên
        path.AddLine(rect.X + borderRadius, rect.Y, rect.Right - borderRadius, rect.Y);
        // Góc trên phải
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
        // Đường phải
        path.AddLine(rect.Right, rect.Y + borderRadius, rect.Right, rect.Bottom - borderRadius);
        // Góc dưới phải
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
        // Đường dưới
        path.AddLine(rect.Right - borderRadius, rect.Bottom, rect.X + borderRadius, rect.Bottom);
        // Góc dưới trái
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
        // Đường trái
        path.AddLine(rect.X, rect.Bottom - borderRadius, rect.X, rect.Y + borderRadius);

        path.CloseFigure();

        control.Region = new Region(path);
    }
}