using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static bool isEnd;
        [STAThread]
        static void Main()
        {
            PrivateFontCollection fCollection = new PrivateFontCollection();
            fCollection.AddFontFile("Fonts/nosquare.otf");
            fCollection.AddFontFile("Fonts/square.ttf");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            do
            {
                isEnd = true;
                bool isExit = false;
                int ID = -1;
                while (!isExit)
                {
                    using (var logIn = new LogInForm(fCollection))
                    {
                        var result = logIn.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CourseWork"].ConnectionString))
                            {
                                var query = new SqlCommand("SELECT ID FROM Person WHERE P_Login = @Login AND P_Password = @Password");
                                query.Parameters.AddWithValue("@Login", logIn.loginBox.Text);
                                query.Parameters.AddWithValue("@Password", logIn.passBox.Text);
                                query.Connection = connect;

                                connect.Open();

                                var res = query.ExecuteScalar();
                                if (res != null)
                                {
                                    ID = (int)res;
                                    logIn.Close();
                                    isExit = true;
                                }
                                else
                                {
                                    ThreadStart str = new ThreadStart(() => MessageBox.Show("Invalid Login or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly));
                                    Thread thread = new Thread(str);
                                    thread.Start();
                                }
                            }
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            logIn.Close();
                            isExit = true;
                        }
                    }
                }
                if (ID != -1)
                    Application.Run(new MainForm(ID, fCollection));
            }
            while (!isEnd);
        }
    }
}
