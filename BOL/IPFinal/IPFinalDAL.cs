using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BOL {
    public class IPFinalDAL {

        #region Singleton

        private static volatile IPFinalDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private IPFinalDAL() { }

        public static IPFinalDAL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new IPFinalDAL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public int Add(IPFinal iPFinal) {
            try {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@primerOct" , iPFinal.primerOct);
                parameters[1] = new SqlParameter("@segundoOct", iPFinal.segundoOct);
                parameters[2] = new SqlParameter("@tercerOct", iPFinal.tercerOct);
                parameters[3] = new SqlParameter("@cuartoOct", iPFinal.cuartoOct);
                parameters[4] = new SqlParameter("@idPack", iPFinal.idPack);
                string query = "stp_ipfinal_add";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en IPFinalDAL: " + ex.Message);
            }
        }

        public int Remove(IPFinal iPFinal) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idIPFinal", iPFinal.id);
                string query = "stp_ipfinal_remove";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en IPFinalDAL: " + ex.Message);
            }
        }

        public int Update(IPFinal iPFinal) {
            try {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@primerOct", iPFinal.primerOct);
                parameters[1] = new SqlParameter("@segundoOct", iPFinal.segundoOct);
                parameters[2] = new SqlParameter("@tercerOct", iPFinal.tercerOct);
                parameters[3] = new SqlParameter("@cuartoOct", iPFinal.cuartoOct);
                parameters[4] = new SqlParameter("@idIPFinal", iPFinal.id);
                string query = "stp_ipfinal_update";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en IPFinalDAL: " + ex.Message);
            }
        }

        public IPFinales GetAll() {
            try {
                string query = "stp_ipfinal_getAll";
                DataTable resultado = dataAccess.Query(query);
                IPFinales iPFinales = new IPFinales();

                foreach (DataRow item in resultado.Rows) {
                    iPFinales.Add(new IPFinal() { 
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"],
                        id = (int)item["idIPFinal"]
                    });
                }
                
                return iPFinales;

            } catch (Exception ex) {
                throw new Exception("Error en IPFinalDAL: " + ex.Message);
            }
        }

        public IPFinal GetByID(IPFinal iPFinal) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idIPFinal", iPFinal.id);
                string query = "stp_ipfinal_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) { 
                    iPFinal = new IPFinal() { 
                        id = (int)resultado.Rows[0]["idIPFinal"],
                        primerOct = (int)resultado.Rows[0]["primerOct"],
                        segundoOct = (int)resultado.Rows[0]["segundoOct"],
                        tercerOct = (int)resultado.Rows[0]["tercerOct"],
                        cuartoOct = (int)resultado.Rows[0]["cuartoOct"]
                    };
                }

                return iPFinal;

            } catch (Exception ex) {
                throw new Exception("Error en IPFinalDAL: " + ex.Message);
            }
        }

        public IPFinales GetByPack(IPFinal iPFinal) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idPack", iPFinal.idPack);
                string query = "stp_ipfinal_getByPack";
                DataTable resultado = dataAccess.Query(query, parameters);
                IPFinales redes = new IPFinales();

                foreach (DataRow item in resultado.Rows) {
                    redes.Add(new IPFinal() {
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"],
                        id = (int)item["idIPFinal"]
                    });
                }

                return redes;

            } catch (Exception ex) {
                throw new Exception("Error en RedDAL: " + ex.Message);
            }
        }
    }
}
