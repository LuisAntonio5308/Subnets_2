using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL {
    public class RedDAL {

        #region Singleton

        private static volatile RedDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private RedDAL() { }

        public static RedDAL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new RedDAL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public int Add(Red red) {
            try {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@primerOct", red.primerOct);
                parameters[1] = new SqlParameter("@segundoOct", red.segundoOct);
                parameters[2] = new SqlParameter("@tercerOct", red.tercerOct);
                parameters[3] = new SqlParameter("@cuartoOct", red.cuartoOct);
                parameters[4] = new SqlParameter("@idPack", red.idPack);
                string query = "stp_red_add";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en RedDAL: " + ex.Message);
            }
        }

        public int Remove(Red red) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idRed", red.id);
                string query = "stp_red_remove";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en RedDAL: " + ex.Message);
            }
        }

        public int Update(Red red) {
            try {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@primerOct", red.primerOct);
                parameters[1] = new SqlParameter("@segundoOct", red.segundoOct);
                parameters[2] = new SqlParameter("@tercerOct", red.tercerOct);
                parameters[3] = new SqlParameter("@cuartoOct", red.cuartoOct);
                parameters[4] = new SqlParameter("@idRed", red.id);
                string query = "stp_red_update";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en RedDAL: " + ex.Message);
            }
        }

        public Redes GetAll() {
            try {
                string query = "stp_red_getAll";
                DataTable resultado = dataAccess.Query(query);
                Redes redes = new Redes();

                foreach (DataRow item in resultado.Rows) {
                    redes.Add(new Red() {
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"],
                        id = (int)item["idRed"]
                    });
                }

                return redes;

            } catch (Exception ex) {
                throw new Exception("Error en RedDAL: " + ex.Message);
            }
        }

        public Red GetByID(Red red) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idRed", red.id);
                string query = "stp_red_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {
                    red = new Red() {
                        id = (int)resultado.Rows[0]["idRed"],
                        primerOct = (int)resultado.Rows[0]["primerOct"],
                        segundoOct = (int)resultado.Rows[0]["segundoOct"],
                        tercerOct = (int)resultado.Rows[0]["tercerOct"],
                        cuartoOct = (int)resultado.Rows[0]["cuartoOct"]
                    };
                }

                return red;

            } catch (Exception ex) {
                throw new Exception("Error en IPFinalDAL: " + ex.Message);
            }
        }

        public Redes GetByPack(Red red) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idPack", red.idPack);
                string query = "stp_red_getByPack";
                DataTable resultado = dataAccess.Query(query, parameters);
                Redes redes = new Redes();

                foreach (DataRow item in resultado.Rows) {
                    redes.Add(new Red() {
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"],
                        id = (int)item["idRed"]
                    });
                }

                return redes;

            } catch (Exception ex) {
                throw new Exception("Error en RedDAL: " + ex.Message);
            }
        }

    }
}
