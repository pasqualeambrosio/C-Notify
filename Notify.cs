using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomNotify
{
    public partial class Notify : Form
    {
        #region Resources

        private string base64ImgClose = "iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAACJUlEQVRoge1ZwVKDMBDddUw7TU9qO+N3+aH2UC/1iyoqXiQZywzrwcaWECAbgsWWN9MLXfa9l13IAgAjRlw20D5ARCF5+CcRrQDxgXsaYllyVwNBbh2o6KgNtAxcBxLGEm7n8zZicNWBrA+wc3Mq0KdwF49XNXwr8Ffi2Zw+Bk4h3ps75BoYFNoMnHL1DRo1NBkYgniDWi1n20L81c/zXS+xBzg1RakAafUMQkxJZS8esSkIMSWtn2JwVwmK4pEYKFS2ISIwvyL73DbEvpdilVpzuMgxqLmGOf/2yfMdCDGt5FDqFaVcWMfeUMqlI8cXCDHxpURrmuvWQkJMQKu0QiLl8ridSKvUJZ5UlnDEu9CtAgZafcBM3lZyqWwLiAJn8s7xX4JyXq1IC+wKxDEAUGvChVDxALFb6BgzeeNqJxtdxLsQdyNrMRFbPEAPOzE1b4JFbL6oBkir1HXBGqCc3/tsdhxEM9Am3iC2iVijhFM8qSxx7xPxK3EgZcIeD45GiuQ3SGVpTUzt2HHBowTRyjcZCDEhrTZloVliiwcAQCkXdjuR1mvWKOGjbV9ebhttKm1Th307hUyi5GiOuleLYQ80vqvJiS3D7qDGd6NDeiYG2Gu1DZztMzFAwIvWHlGrpa0CQzDRqOGsW8jglFVo5fatwClMeHFyvg+YhH3fXlmLFXIN9FkNdu7Qb2SxqxG8KF3vQggAyBoADX7OQRjGrXrEiH+Lb89TnSN7BQxPAAAAAElFTkSuQmCC";
        private string base64ImgInfo = "iVBORw0KGgoAAAANSUhEUgAAACIAAAAiCAYAAAA6RwvCAAAAzklEQVRYhe2YwQ7DMAhDYer//zI7ZcpSSBtwCZrmUw7FPJmkasoiQg5dFfGq4QFsbj17C+oOiCsypX4KNAOJAlh+KtArCeLSWwN5EsLsMYJkQKi9rNGkqwfJTOPUE5EIk+MFNqqBeNNgY70i6UG2KwoixnpZR9QAUE9EJD8zGpjKHd/t+oOMKgUS3mgAcalESqiB7BwPE63dayxBPqj60exI5dOz3B5pykzlq5eWSAbMqYc1midhVO/ZqWkFqGuG+xI+GiC+9EMgmiH8R80bHqUdU48rNRwAAAAASUVORK5CYII=";
        private string base64ImgSuccess = "iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAB8UlEQVRoge2ZS1LDMBBEe4TjXIFFjsOxyXFYZAkbwElp2FiULetvjWwK9y4qfV7PjCTbAQ4d+t8iu4GZS+bJHsTMVyJ6yR1HNEdea6DIrUMLDm9Hy0BXuGAtcHu+ZCNGasViEsqeO8fAe8kCBeJxrSSl7oEW4C4t+Ow9kJKB5GgIKBq4lAxsFX2jGWNuBraGByIMIQN7gDfyspQco7uSz0DT6DP4AYAePLwFuzm0eQYY/CDQCQA66i8REwstDDDzay24mDTrwcAbddRfAkMWWXAdo03KZxr5qTTrb0Wq940j6xzdpIRckR/bg/AuNTegWQ+K1NnRng0PNDZQGx5oaEACHlhh4K6HGwDSrIdYXyl4oNDAXQ+3k+qfAUCROodMSMID5cfoYpwLSAK+yjHK4LvdNmbiy/yWjrxR8UUWuIg+ASgpeDsDq25iX5Q9fevUfM2bWJHqXeVkq3bZzBjsBma+5kxAoC5koia8i833Tpz/qdCxJwQib1dQvZvYzoRk2czXtTTZw0WP1eZSE4AnIO/j7p5e6gGPgVAJZX9oFZSXJbYH9mAiyLD5S31EOtYhxcCWWXiKdUjNAAH4WMeSJY3EwJX8xSR9OgXBa1xkkiWVPXfpf2RmoeZ/8tlaewoRAMp9AAR+H8wI+ziqDx36s/oB1dUCfo1mTscAAAAASUVORK5CYII=";
        private string base64ImgWarning = "iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAAA9ElEQVRoge2XyxLDIAhFsdP//2W6KdPERuODq0Y4q66AyyGdkchxIARmRveQBgHZ5IUsTr8Q8W91kEGuBoeFQRsZBipIbvMQK24kQ8nG1a24kQQ1m1a1ohmkZTC1MH5aET2bVbHiRg5obLS7hhv5ovkX2lWrJ0hp40Dlb5HmMOZPC/lIaqpt2gj8kd/Sw6yRETaaetUEGRmiuqe505pho6q3KSMzbQi3M9wFWSGEkJ3FxGmtZENIzvSe2VyTlJEVbQiXs239jWjbqHkhlvI3Yxxk5ZOKOc265WmhbDC4NhFtaORJ30YME21m5Mk2BN7KiOM4aT7DJjcowzjDswAAAABJRU5ErkJggg==";
        private string base64ImgError = "iVBORw0KGgoAAAANSUhEUgAAADIAAAAyCAYAAAAeP4ixAAABD0lEQVRoge2YQRLDIAhFwen9r0xXZlLbCug3hgxvGwf4gkQkSpIkSZJxWESu8KM54VkHr1kDCtZdquuGBa0SMprmYUFl0GEPRK26baCFIA+cyxZSyIquYbbpPSO/DLPH4QBChjNjFdIL9JL+rWEprTsEqsagCbmDCBM9IWFEEK35j2whkpBuhfzqWqFKqtJm5O4ihP7EWJpFMzD5Lnve9We+BJXTh4gccSOv8d7NQG2eEBEXoMGtRGq/PeQpQh6TkWUzu9ZW4ecSLaQOWZZAoQMZqrRqBjyBTT8BnUEImd1Z0yirgRCy5fmnpRAotbt5SvvlKiRyVpjoMyMRxRwxt6U1MyNcTZQ4kyRJkiRx8wY6ZTA6nJpkBwAAAABJRU5ErkJggg==";

        #endregion

        public enum NotifyType
        {
            Success,
            Info,
            Warning,
            Error
        }

        public enum NotifyPosition
        {
            BottomLeft,
            BottomRight
        }

        public class NotifyOptions
        {
            public string Message { get; set; }
            public NotifyType NotifyType { get; set; } = NotifyType.Success;
            public NotifyPosition NotifyPosition { get; set; } = NotifyPosition.BottomRight;
            public int AutoHideDelay { get; set; }
            public int Gap { get; set; } = 5;
            public bool ClickToClose { get; set; } = true;
            public EventHandler<NotifyArgs> OnNotifyClosed { get; set; }
        }

        public event EventHandler<NotifyArgs> NotifyClosed;
        public class NotifyArgs : EventArgs
        {
            public string Status;
            public NotifyArgs(string status)
            {
                Status = status;
            }
        }

        private static int openedNotify = 0;
        private NotifyOptions notifyOption = new NotifyOptions();

        public Notify()
        {
            InitializeComponent();

            imgClose.Image = LoadImage(base64ImgClose);
            imgClose.Click += new EventHandler((e, s) => { Close(); });
            tmrClose.Tick += new EventHandler((e, s) => { Close(); });
        }

        /// <summary>
        /// Open notification
        /// </summary>
        /// <param name="notifyOptions"></param>
        public static void Open(NotifyOptions notifyOptions)
        {
            try
            {
                openedNotify++;

                Notify f = new Notify();
                f.notifyOption = notifyOptions;
                f.Opacity = 0;
                f.Name = "frmNotify_" + openedNotify;
                f.lblMessage.ForeColor = Color.White;
                f.lblMessage.Text = f.notifyOption.Message;
                f.lblTime.Text = DateTime.Now.ToString("HH:mm");

                if (f.notifyOption.OnNotifyClosed != null)
                    f.NotifyClosed += f.notifyOption.OnNotifyClosed;

                switch (f.notifyOption.NotifyType)
                {
                    case NotifyType.Info:
                        f.imgNotify.Image = f.LoadImage(f.base64ImgInfo);
                        f.BackColor = Color.FromArgb(61, 108, 232);
                        break;

                    case NotifyType.Success:
                        f.imgNotify.Image = f.LoadImage(f.base64ImgSuccess);
                        f.BackColor = Color.FromArgb(39, 126, 86);
                        break;

                    case NotifyType.Warning:
                        f.imgNotify.Image = f.LoadImage(f.base64ImgWarning);
                        f.BackColor = Color.FromArgb(255, 143, 0);
                        break;

                    case NotifyType.Error:
                        f.imgNotify.Image = f.LoadImage(f.base64ImgError);
                        f.BackColor = Color.FromArgb(151, 14, 0);
                        break;
                }

                switch (notifyOptions.NotifyPosition)
                {
                    case NotifyPosition.BottomRight:
                        f.Left = Screen.PrimaryScreen.WorkingArea.Width - f.Width - 1;
                        f.Top = Screen.PrimaryScreen.WorkingArea.Height - f.Height * openedNotify - f.notifyOption.Gap * openedNotify;
                        break;

                    case NotifyPosition.BottomLeft:
                        f.Left = 1;
                        f.Top = Screen.PrimaryScreen.WorkingArea.Height - f.Height * openedNotify - f.notifyOption.Gap * openedNotify;
                        break;
                }
                f.Location = new Point(f.Left, f.Top);

                if (f.notifyOption.AutoHideDelay != 0)
                {
                    f.imgClose.Visible = false;
                    f.tmrClose.Interval = f.notifyOption.AutoHideDelay;
                    f.tmrClose.Start();
                }

                if (f.notifyOption.ClickToClose)
                {
                    f.Click += new EventHandler((e, s) => { f.Close(); });
                    f.lblMessage.Click += new EventHandler((e, s) => { f.Close(); });
                    f.imgNotify.Click += new EventHandler((e, s) => { f.Close(); });
                }

                f.Show();

                f.tmrShow.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FrmNotify] Open(): " + ex.Message);
            }
        }

        private Image LoadImage(string base64)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(base64);
                Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                    image = Image.FromStream(ms);
                return image;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FrmNotify] LoadImage(): " + ex.Message);
                return null;
            }
        }

        private void Notify_FormClosing(object sender, FormClosingEventArgs e)
        {
            openedNotify--;

            try
            {
                int counter = 0;
                Application.OpenForms.Cast<Form>().Where(f => f.Name.StartsWith("frmNotify_") && f.Name != Name).ToList().ForEach(f =>
                {
                    counter++;
                    int id = int.Parse(f.Name.Replace("frmNotify_", ""));

                    switch (((Notify)f).notifyOption.NotifyPosition)
                    {
                        case NotifyPosition.BottomRight:
                            f.Left = Screen.PrimaryScreen.WorkingArea.Width - f.Width - 1;
                            f.Top = Screen.PrimaryScreen.WorkingArea.Height - f.Height * counter - ((Notify)f).notifyOption.Gap * counter;
                            break;

                        case NotifyPosition.BottomLeft:
                            f.Left = 1;
                            f.Top = Screen.PrimaryScreen.WorkingArea.Height - f.Height * counter - ((Notify)f).notifyOption.Gap * counter;
                            break;
                    }

                    f.Location = new Point(f.Left, f.Top);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FrmNotify] FormClosing(): " + ex.Message);
            }
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                tmrShow.Enabled = false;
                return;
            }
            Opacity += .1;
        }

        private void Notify_FormClosed(object sender, FormClosedEventArgs e)
        {
            NotifyClosed?.Invoke(this, new NotifyArgs("close"));
        }
    }
}
