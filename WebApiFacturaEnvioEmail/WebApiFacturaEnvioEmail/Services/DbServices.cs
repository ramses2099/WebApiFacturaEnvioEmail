using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using WebApiFacturaEnvioEmail.Models;

namespace WebApiFacturaEnvioEmail.Services
{
    public class DbServices
    {


        public static List<HDFactNotificacionEmail> GetHDFactNotificacionEmail()
        {

            List<HDFactNotificacionEmail> lst = new List<HDFactNotificacionEmail>();

            StringBuilder sql = new StringBuilder();
            
            sql.AppendLine("SELECT[Gkey],[NumFactura],[NCF],[TipoFactura],[TipoPago],[FechaFacturado],[MontoRecibido]");
            sql.AppendLine(",[RNC],[NumCliente],[Cliente],[NombreContacto],[Direccion],[CodigoEmail],[Email]");
            sql.AppendLine(",[Telefono],[Observacion],[NombreUsuario]");
            sql.AppendLine("FROM [dbo].[HDFact_Notificacion_Email]");
            
            try
            {

                using (SqlConnection connetion = new SqlConnection(ConnectionAndSettings.ConnectionString))
                {

                    if (connetion.State == System.Data.ConnectionState.Closed)
                    {
                        connetion.Open();
                    }

                    using (SqlCommand _DbCommand = new SqlCommand())
                    {
                        _DbCommand.Connection = connetion;

                        _DbCommand.CommandType = CommandType.Text;

                        _DbCommand.CommandText = sql.ToString();
                        
                        using (SqlDataReader dr = _DbCommand.ExecuteReader())
                        {

                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    HDFactNotificacionEmail fact = new HDFactNotificacionEmail();

                                    if (dr["Gkey"] != DBNull.Value)
                                    {
                                        fact.Gkey = dr["Gkey"].ToString();
                                    }
                                    //
                                    if (dr["NumFactura"] != DBNull.Value)
                                    {
                                        fact.NumFactura = dr["NumFactura"].ToString();
                                    }
                                    //
                                    if (dr["NCF"] != DBNull.Value)
                                    {
                                        fact.NCF = dr["NCF"].ToString();
                                    }
                                    //
                                    if (dr["TipoFactura"] != DBNull.Value)
                                    {
                                        fact.TipoFactura = dr["TipoFactura"].ToString();
                                    }
                                    //
                                    if (dr["TipoPago"] != DBNull.Value)
                                    {
                                        fact.TipoPago = dr["TipoPago"].ToString();
                                    }
                                    //
                                    if (dr["FechaFacturado"] != DBNull.Value)
                                    {
                                        fact.FechaFacturado = dr["FechaFacturado"].ToString();
                                    }
                                    //
                                    if (dr["MontoRecibido"] != DBNull.Value)
                                    {
                                        fact.MontoRecibido = dr["MontoRecibido"].ToString();
                                    }
                                    //
                                    if (dr["RNC"] != DBNull.Value)
                                    {
                                        fact.RNC = dr["RNC"].ToString();
                                    }
                                    //
                                    if (dr["NumCliente"] != DBNull.Value)
                                    {
                                        fact.NumCliente = dr["NumCliente"].ToString();
                                    }
                                    //
                                    if (dr["Cliente"] != DBNull.Value)
                                    {
                                        fact.Cliente = dr["Cliente"].ToString();
                                    }
                                    //
                                    if (dr["NombreContacto"] != DBNull.Value)
                                    {
                                        fact.NombreContacto = dr["NombreContacto"].ToString();
                                    }
                                    //
                                    if (dr["Direccion"] != DBNull.Value)
                                    {
                                        fact.Direccion = dr["Direccion"].ToString();
                                    }
                                    //
                                    if (dr["CodigoEmail"] != DBNull.Value)
                                    {
                                        fact.CodigoEmail = dr["CodigoEmail"].ToString();
                                    }
                                    //
                                    if (dr["Email"] != DBNull.Value)
                                    {
                                        fact.Email = dr["Email"].ToString();
                                    }
                                    //
                                    if (dr["Telefono"] != DBNull.Value)
                                    {
                                        fact.Telefono = dr["Telefono"].ToString();
                                    }
                                    //
                                    if (dr["Observacion"] != DBNull.Value)
                                    {
                                        fact.Observacion = dr["Observacion"].ToString();
                                    }
                                    //
                                    if (dr["NombreUsuario"] != DBNull.Value)
                                    {
                                        fact.NombreUsuario = dr["NombreUsuario"].ToString();
                                    }
                                    //

                                    lst.Add(fact);

                                }
                                //
                            }
                            //
                        }
                        
                    }

                }

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return lst;
        }




    }





}
}