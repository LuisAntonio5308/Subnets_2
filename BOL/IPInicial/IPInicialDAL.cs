using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using DAL;

namespace BOL {
    public class IPInicialDAL {

        #region Singleton

        private static volatile IPInicialDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private IPInicialDAL() { }

        public static IPInicialDAL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new IPInicialDAL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public int Add(IPInicial iPInicial) {
            try {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@primerOct", iPInicial.primerOct);
                parameters[1] = new SqlParameter("@segundoOct", iPInicial.segundoOct);
                parameters[2] = new SqlParameter("@tercerOct", iPInicial.tercerOct);
                parameters[3] = new SqlParameter("@cuartoOct", iPInicial.cuartoOct);
                parameters[4] = new SqlParameter("@idPack", iPInicial.idPack);
                string query = "stp_ipinicial_add";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en IPInicialDAL: " + ex.Message);
            }
        }

        public int Remove(IPInicial iPInicial) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idIPFinal", iPInicial.id);
                string query = "stp_ipinicial_remove";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en IPInicialDAL: " + ex.Message);
            }
        }

        public int Update(IPInicial iPInicial) {
            try {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@primerOct", iPInicial.primerOct);
                parameters[1] = new SqlParameter("@segundoOct", iPInicial.segundoOct);
                parameters[2] = new SqlParameter("@tercerOct", iPInicial.tercerOct);
                parameters[3] = new SqlParameter("@cuartoOct", iPInicial.cuartoOct);
                parameters[4] = new SqlParameter("@idIPInicial", iPInicial.id);
                string query = "stp_ipinicial_update";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en IPInicialDAL: " + ex.Message);
            }
        }

        public IPIniciales GetAll() {
            try {
                string query = "stp_ipinicial_getAll";
                DataTable resultado = dataAccess.Query(query);
                IPIniciales iPIniciales = new IPIniciales();

                foreach (DataRow item in resultado.Rows) {
                    iPIniciales.Add(new IPInicial() {
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"],
                        id = (int)item["idIPInicial"]
                    });
                }

                return iPIniciales;

            } catch (Exception ex) {
                throw new Exception("Error en IPFinalDAL: " + ex.Message);
            }
        }

        public IPInicial GetByID(IPInicial iPInicial) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idIPInicial", iPInicial.id);
                string query = "stp_ipinicial_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {
                    iPInicial = new IPInicial() {
                        id = (int)resultado.Rows[0]["idIPIniciall"],
                        primerOct = (int)resultado.Rows[0]["primerOct"],
                        segundoOct = (int)resultado.Rows[0]["segundoOct"],
                        tercerOct = (int)resultado.Rows[0]["tercerOct"],
                        cuartoOct = (int)resultado.Rows[0]["cuartoOct"]
                    };
                }

                return iPInicial;

            } catch (Exception ex) {
                throw new Exception("Error en IPFinalDAL: " + ex.Message);
            }
        }

        public IPIniciales GetByPack(IPInicial iPInicial) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idPack", iPInicial.idPack);
                string query = "stp_ipinicial_getByPack";
                DataTable resultado = dataAccess.Query(query, parameters);
                IPIniciales redes = new IPIniciales();

                foreach (DataRow item in resultado.Rows) {
                    redes.Add(new IPInicial() {
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"],
                        id = (int)item["idIPInicial"]
                    });
                }

                return redes;

            } catch (Exception ex) {
                throw new Exception("Error en RedDAL: " + ex.Message);
            }
        }

    }
}
