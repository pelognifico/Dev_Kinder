using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Dev_Kinder
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        Consultas obDatos = new Consultas();

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                loggear(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                MessageBox.Show("Tiene que llenar los campos");
                txtUsername.Focus();
            }

            
        }
        //Verify data login
        public void loggear(string username, string password)
        {
            try
            {
                obDatos.cn.Open();
                obDatos.cmd = new SqlCommand("SELECT nombre, cod_tipo FROM tblusuario WHERE username ='" +
                    username + "' AND password='" + password + "'", obDatos.cn);
                obDatos.da = new SqlDataAdapter(obDatos.cmd);
                DataTable dt = new DataTable();
                obDatos.da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if(dt.Rows[0][1].ToString() == "1")
                    {
                        new frmPrincipal(dt.Rows[0][0].ToString()).Show();
                    }
                    else if(dt.Rows[0][1].ToString() == "2")
                    {
                        new frmPrincipalUser(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    MessageBox.Show("Usuario y/o Contraseña incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                obDatos.cn.Close();
            }
        }
    }
}