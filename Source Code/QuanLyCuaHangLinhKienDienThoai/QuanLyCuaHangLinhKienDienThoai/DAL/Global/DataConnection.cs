using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyCuaHangBanXeMay.DTO.Global
{
    class DataConnection : Singleton<DataConnection>
    {
        #region "variable"
        public SqlConnection m_conn;
        public SqlCommand m_cmd;
        protected String m_connecstring;
        #endregion
        #region "method"
        public DataConnection()
        {
        }

        /// <summary>
        /// Ham nay tra ve chuoi ket noi duoc doc len tu file xml
        /// </summary>
        /// <returns>Neu co chuoi ket noi tra ve true, nguoc lai tra ve false</returns>
        private bool getConnectionString()
        {
            try
            {

                m_connecstring = System.Configuration.ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

                return true;
            }
            catch
            {
                return false;
            }


        }

        /// <summary>
        /// Ham nay dung de mo ket noi voi microsoft sql server
        /// </summary>
        /// <returns></returns>
        public bool openConnection()
        {
            if (getConnectionString())
            {
                try
                {
                    if (m_conn == null)
                    {
                        m_conn = new SqlConnection(m_connecstring);
                    }
                    if (m_conn.State == ConnectionState.Closed)
                    {
                        m_conn.Open();
                    }
                    return true;
                }
                catch (SqlException)
                {
                    //DevExpress.XtraEditors.XtraMessageBox.Show(ex.ToString());

                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Ham nay dung de dong ket noi voi sql server
        /// </summary>
        public bool closeConnection()
        {
            if (m_conn == null)
            {
                return false;
            }
            else
            {
                if (m_conn.State == ConnectionState.Open)
                {
                    m_conn.Close();
                }
                return true;
            }
        }

        #endregion
    }

}
