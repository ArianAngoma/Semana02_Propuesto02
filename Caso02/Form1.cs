using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace Caso02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Caso02"].ConnectionString);

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaPedidos();
        }

        public void ListaPedidos()
        {
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_Listado_Pedidos_Caso02", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;

                using (DataSet Da = new DataSet())
                {
                    df.Fill(Da, "Pedidos");
                    DgPedidos.DataSource = Da.Tables["Pedidos"];
                }
            }
        }

        private void DgPedidos_DoubleClick(object sender, EventArgs e)
        {
            int Codigo;

            Codigo = Convert.ToInt32(DgPedidos.CurrentRow.Cells[0].Value);

            using (SqlCommand cmd = new SqlCommand("Usp_Detalle_Pedido", cn))
            {
                using (SqlDataAdapter Da = new SqlDataAdapter())
                {
                    Da.SelectCommand = cmd;
                    Da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Da.SelectCommand.Parameters.AddWithValue("@idpedido", Codigo);

                    using (DataSet df = new DataSet())
                    {
                        Da.Fill(df, "detallesdepedidos");

                        DgDetalle.DataSource = df.Tables["detallesdepedidos"];
                    }
                }
            }
        }
    }
}
