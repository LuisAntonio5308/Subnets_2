using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class IPBroadcastDAL
    {

        #region Singleton

        private static volatile IPBroadcastDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private IPBroadcastDAL() { }

        public static IPBroadcastDAL Instance()
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new IPBroadcastDAL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public int Add(IPBroadcast iPBroadcast)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@primerOct", iPBroadcast.primerOct);
                parameters[1] = new SqlParameter("@segundoOct", iPBroadcast.segundoOct);
                parameters[2] = new SqlParameter("@tercerOct", iPBroadcast.tercerOct);
                parameters[3] = new SqlParameter("@cuartoOct", iPBroadcast.cuartoOct);
                parameters[4] = new SqlParameter("@idPack", iPBroadcast.idPack);
                string query = "stp_ipbroadcast_add";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en IPBroadcastDAL: " + ex.Message);
            }
        }

        public int Remove(IPBroadcast iPBroadcast)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@id", iPBroadcast.id);
                string query = "stp_ipbroadcast_remove";
                return dataAccess.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en IPBroadcastDAL: " + ex.Message);
            }
        }

        public int Update(IPBroadcast iPBroadcast)
        {
            try
            {
                SqlParameter[] parameteres = new SqlParameter[5];
                parameteres[0] = new SqlParameter("@primerOct", iPBroadcast.primerOct);
                parameteres[1] = new SqlParameter("@segundoOct", iPBroadcast.segundoOct);
                parameteres[2] = new SqlParameter("@tercerOct", iPBroadcast.tercerOct);
                parameteres[3] = new SqlParameter("@cuartoOct", iPBroadcast.cuartoOct);
                parameteres[4] = new SqlParameter("@idIPBroadcast", iPBroadcast.id);
                string query = "stp_ipbroadcast_update";
                return dataAccess.Execute(query, parameteres);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en IPBroadcastDAL: " + ex.Message);
            }
        }

        public IPBroadcasts GetAll()
        {
            try
            {
                string query = "stp_ipbroadcast_getAll";
                DataTable resultado = dataAccess.Query(query);
                IPBroadcasts iPBroadcasts = new IPBroadcasts();

                foreach (DataRow item in resultado.Rows)
                {
                    iPBroadcasts.Add(new IPBroadcast()
                    {
                        id = (int)item["idIPBroadcast"],
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"]
                    }); ;
                }

                return iPBroadcasts;

            }
            catch (Exception ex)
            {
                throw new Exception("Error en IPBroadcastDAL: " + ex.Message);
            }
        }

        public IPBroadcast GetByID(IPBroadcast iPBroadcast)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idIPBroadcast", iPBroadcast.id);
                string query = "stp_ipbroadcast_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0)
                {
                    iPBroadcast = new IPBroadcast()
                    {
                        id = (int)resultado.Rows[0]["idIPBroadcast"],
                        primerOct = (int)resultado.Rows[0]["primerOct"],
                        segundoOct = (int)resultado.Rows[0]["segundoOct"],
                        tercerOct = (int)resultado.Rows[0]["tercerOct"],
                        cuartoOct = (int)resultado.Rows[0]["cuartoOct"]
                    };
                }
                return iPBroadcast;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en IPBroadcastDAL: " + ex.Message);
            }
        }

        public IPBroadcasts GetByPack(IPBroadcast iPBroadcast) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idPack", iPBroadcast.idPack);
                string query = "stp_ipbroadcast_getByPack";
                DataTable resultado = dataAccess.Query(query, parameters);
                IPBroadcasts redes = new IPBroadcasts();

                foreach (DataRow item in resultado.Rows) {
                    redes.Add(new IPBroadcast() {
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"],
                        id = (int)item["idIPBroadcast"]
                    });
                }

                return redes;

            } catch (Exception ex) {
                throw new Exception("Error en RedDAL: " + ex.Message);
            }
        }

    }
}