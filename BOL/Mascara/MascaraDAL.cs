using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BOL {
    public class MascaraDAL {

        #region Singleton

        private static volatile MascaraDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private MascaraDAL() { }

        public static MascaraDAL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new MascaraDAL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public int Add(Mascara mascara) {
            try {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@primerOct", mascara.primerOct);
                parameters[1] = new SqlParameter("@segundoOct", mascara.segundoOct);
                parameters[2] = new SqlParameter("@tercerOct", mascara.tercerOct);
                parameters[3] = new SqlParameter("@cuartoOct", mascara.cuartoOct);
                parameters[4] = new SqlParameter("@idPack", mascara.idPack);
                string query = "stp_mascara_add";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en MascaraDAL: " + ex.Message);
            }
        }

        public int Remove(Mascara mascara) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idMascara", mascara.id);
                string query = "stp_mascara_remove";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en MascaraDAL: " + ex.Message);
            }
        }

        public int Update(Mascara mascara) {
            try {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@primerOct", mascara.primerOct);
                parameters[1] = new SqlParameter("@segundoOct", mascara.segundoOct);
                parameters[2] = new SqlParameter("@tercerOct", mascara.tercerOct);
                parameters[3] = new SqlParameter("@cuartoOct", mascara.cuartoOct);
                parameters[4] = new SqlParameter("@idMascara", mascara.id);
                string query = "stp_mascara_update";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en MascaraDAL: " + ex.Message);
            }
        }

        public Mascaras GetAll() {
            try {
                string query = "stp_mascara_getAll";
                DataTable resultado = dataAccess.Query(query);
                Mascaras mascaras = new Mascaras();

                foreach (DataRow item in resultado.Rows) {
                    mascaras.Add(new Mascara() {
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"],
                        id = (int)item["idIPFinal"]
                    });
                }

                return mascaras;
            } catch (Exception ex) {
                throw new Exception("Error en MascaraDAL: " + ex.Message);
            }
        }

        public Mascara GetByID(Mascara mascara) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idMascara", mascara.id);
                string query = "stp_mascara_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {
                    mascara = new Mascara() {
                        id = (int)resultado.Rows[0]["idIPFinal"],
                        primerOct = (int)resultado.Rows[0]["primerOct"],
                        segundoOct = (int)resultado.Rows[0]["segundoOct"],
                        tercerOct = (int)resultado.Rows[0]["tercerOct"],
                        cuartoOct = (int)resultado.Rows[0]["cuartoOct"]
                    };
                }

                return mascara;
            } catch (Exception ex) {
                throw new Exception("Error en MascaraDAL: " + ex.Message);
            }
        }

        public Mascaras GetByPack(Mascara mascara) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idPack", mascara.idPack);
                string query = "stp_mascara_getByPack";
                DataTable resultado = dataAccess.Query(query, parameters);
                Mascaras redes = new Mascaras();

                foreach (DataRow item in resultado.Rows) {
                    redes.Add(new Mascara() {
                        primerOct = (int)item["primerOct"],
                        segundoOct = (int)item["segundoOct"],
                        tercerOct = (int)item["tercerOct"],
                        cuartoOct = (int)item["cuartoOct"],
                        id = (int)item["idMascara"]
                    });
                }

                return redes;

            } catch (Exception ex) {
                throw new Exception("Error en RedDAL: " + ex.Message);
            }
        }

    }
}
