using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PhoneHub.VIEW
{
    internal class Style
    {
        public static void ApplyModernStyle(Control parent)
        {
            if (parent == null || parent.IsDisposed) return;

            // Try Segoe UI, fallback to Arial
            Font commonFont = null;
            try
            {
                commonFont = new Font("Segoe UI", 10, FontStyle.Regular);
            }
            catch
            {
                commonFont = new Font("Arial", 10, FontStyle.Regular); // Fallback font
            }

            using (commonFont)
            {
                Color primaryColor = Color.FromArgb(0, 120, 215); // Modern blue
                Color secondaryColor = Color.FromArgb(0, 150, 255); // Gradient for buttons
                Color backColorTextBox = Color.FromArgb(245, 245, 245); // Light background
                Color backColorForm = Color.White;
                Color shadowColor = Color.FromArgb(50, 0, 0, 0); // Light shadow

                // Apply style to Form
                if (parent is Form form && form.IsHandleCreated)
                {
                    form.BackColor = backColorForm;
                    try
                    {
                        form.Font = commonFont;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error setting form font: {ex.Message}");
                    }
                    form.FormBorderStyle = FormBorderStyle.FixedSingle;
                    if (form.Width > 0 && form.Height > 0)
                    {
                        form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, 10, 10));
                    }
                }

                foreach (Control ctrl in parent.Controls)
                {
                    if (ctrl.IsDisposed) continue;

                    try
                    {
                        if (ctrl is TextBox tb && tb.IsHandleCreated)
                        {
                            try
                            {
                                tb.Font = commonFont;
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine($"Error setting TextBox font: {ex.Message}");
                            }
                            tb.BackColor = backColorTextBox;
                            tb.BorderStyle = BorderStyle.None;
                            if (tb.Width > 0 && tb.Height > 0)
                            {
                                tb.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tb.Width, tb.Height, 8, 8));
                            }
                            tb.ForeColor = Color.FromArgb(33, 33, 33);
                            tb.Padding = new Padding(5);
                            ApplyShadow(tb, shadowColor);
                        }
                        else if (ctrl is Label lbl && lbl.IsHandleCreated)
                        {
                            try
                            {
                                lbl.Font = new Font(commonFont.FontFamily, 10, FontStyle.Regular);
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine($"Error setting Label font: {ex.Message}");
                            }
                            lbl.ForeColor = Color.FromArgb(66, 66, 66);
                            lbl.AutoSize = true;
                        }
                        else if (ctrl is Button btn && btn.IsHandleCreated)
                        {
                            btn.FlatStyle = FlatStyle.Flat;
                            btn.BackColor = primaryColor;
                            btn.ForeColor = Color.White;
                            try
                            {
                                btn.Font = new Font(commonFont.FontFamily, 10, FontStyle.Bold);
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine($"Error setting Button font: {ex.Message}");
                            }
                            btn.FlatAppearance.BorderSize = 0;
                            if (btn.Width > 0 && btn.Height > 0)
                            {
                                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 12, 12));
                                btn.BackgroundImage = CreateGradientBackground(btn.Width, btn.Height, primaryColor, secondaryColor);
                            }
                            btn.BackgroundImageLayout = ImageLayout.Stretch;
                            btn.Cursor = Cursors.Hand;
                            ApplyShadow(btn, shadowColor);
                            btn.MouseEnter += (s, e) => btn.BackColor = ControlPaint.Light(primaryColor, 0.1f);
                            btn.MouseLeave += (s, e) =>
                            {
                                if (btn.Width > 0 && btn.Height > 0)
                                {
                                    btn.BackgroundImage = CreateGradientBackground(btn.Width, btn.Height, primaryColor, secondaryColor);
                                }
                            };
                        }
                        else if (ctrl is PictureBox pic && pic.IsHandleCreated)
                        {
                            pic.SizeMode = PictureBoxSizeMode.Zoom;
                            pic.BorderStyle = BorderStyle.None;
                            if (pic.Width > 0 && pic.Height > 0)
                            {
                                pic.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic.Width, pic.Height, 8, 8));
                            }
                            ApplyShadow(pic, shadowColor);
                        }
                        else if (ctrl is ComboBox cb && cb.IsHandleCreated)
                        {
                            try
                            {
                                cb.Font = commonFont;
                            }
                            catch (Exception ex)
                            {
                                System.Diagnostics.Debug.WriteLine($"Error setting ComboBox font: {ex.Message}");
                            }
                            cb.BackColor = backColorTextBox;
                            cb.FlatStyle = FlatStyle.Flat;
                            cb.ForeColor = Color.FromArgb(33, 33, 33);
                            if (cb.Width > 0 && cb.Height > 0)
                            {
                                cb.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cb.Width, cb.Height, 8, 8));
                            }
                            ApplyShadow(cb, shadowColor);
                        }
                        else if (ctrl.HasChildren)
                        {
                            ApplyModernStyle(ctrl); // Recursive for child controls
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error applying style to {ctrl.Name}: {ex.Message}");
                    }
                }
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Create gradient background
        private static Bitmap CreateGradientBackground(int width, int height, Color startColor, Color endColor)
        {
            if (width <= 0 || height <= 0)
                return new Bitmap(1, 1); // Return empty bitmap to avoid errors

            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, width, height),
                startColor,
                endColor,
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, 0, 0, width, height);
            }
            return bitmap;
        }

        // Apply shadow effect
        private static void ApplyShadow(Control control, Color shadowColor)
        {
            if (!control.IsHandleCreated) return;

            control.Paint += (s, e) =>
            {
                if (control.Width <= 0 || control.Height <= 0) return;

                using (Bitmap shadow = new Bitmap(control.Width + 10, control.Height + 10))
                using (Graphics g = Graphics.FromImage(shadow))
                {
                    g.Clear(Color.Transparent);
                    using (SolidBrush brush = new SolidBrush(shadowColor))
                    {
                        g.FillRectangle(brush, 5, 5, control.Width, control.Height);
                    }
                    e.Graphics.DrawImage(shadow, -5, -5);
                }
            };
        }

        public static void ApplyModernStyleToControl(Control control)
        {
            ApplyModernStyle(control);
        }
    }
}
