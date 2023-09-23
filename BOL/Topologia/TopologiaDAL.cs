using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL {
    public class TopologiaDAL {

        #region Singleton

        private static volatile TopologiaDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private TopologiaDAL() { }

        public static TopologiaDAL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new TopologiaDAL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public int Add(Topologia topologia) {
            try {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@nombreTopologia" , topologia.nombreTopologia);
                parameters[1] = new SqlParameter("@fecha", topologia.fecha);
                parameters[2] = new SqlParameter("@idEmpresa", topologia.idEmpresa);
                string query = "stp_topologia_add";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en TopologiaDAL: " + ex.Message);
            }
        }

        public int Remove(Topologia topologia) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idTopologia", topologia.idTopologia);
                string query = "stp_topologia_remove";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en TopologiaDAL: " + ex.Message);
            }
        }

        public int Update(Topologia topologia) {
            try {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@nombreTopologia", topologia.nombreTopologia);
                parameters[1] = new SqlParameter("@fecha", topologia.fecha);
                parameters[2] = new SqlParameter("@idEmpresa", topologia.idEmpresa);
                parameters[3] = new SqlParameter("@idTopologia", topologia.idTopologia);
                string query = "stp_topologia_update";
                return dataAccess.Execute( query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en TopologiaDAL: " + ex.Message);
            }
        }

        public int RemoveAll(Topologia topologia) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("idTopologia", topologia.idTopologia);
                string query = "stp_topologia_removeAll";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en TopologiaDAL: " + ex.Message);
            }
        }

        public Topologias GetAll() {
            try {
                string query = "stp_topologia_getAll";
                DataTable resultado = dataAccess.Query(query);
                Topologias topologias = new Topologias();

                foreach (DataRow item in resultado.Rows) {
                    topologias.Add(new Topologia() {
                        nombreTopologia = (string)item["nombreTopologia"],
                        fecha = (DateTime)item["fecha"],
                        idEmpresa = (int)item["idEmpresa"],
                        idTopologia = (int)item["idTopologia"]
                    }); ;
                }

                return topologias;
            } catch (Exception ex) {
                throw new Exception("Error en TopologiaDAL: " + ex.Message);
            }
        }

        public Topologia GetByID(Topologia topologia) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idTopologia", topologia.idTopologia);
                string query = "stp_topologia_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {
                    topologia = new Topologia() {
                        nombreTopologia = (string)resultado.Rows[0]["nombreTopologia"],
                        fecha = (DateTime)resultado.Rows[0]["fecha"],
                        idEmpresa = (int)resultado.Rows[0]["idEmpresa"],
                        idTopologia = (int)resultado.Rows[0]["idTopologia"]
                    };
                }

                return topologia;
            } catch (Exception ex) {
                throw new Exception("Error en TopologiaDAL: " + ex.Message);
            }
        }

        public Topologia GetByNombre(Topologia topologia) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@nombreTopologia", topologia.nombreTopologia);
                string query = "stp_topologia_getByNombre";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {
                    topologia = new Topologia() {
                        nombreTopologia = (string)resultado.Rows[0]["nombreTopologia"],
                        fecha = (DateTime)resultado.Rows[0]["fecha"],
                        idEmpresa = (int)resultado.Rows[0]["idEmpresa"],
                        idTopologia = (int)resultado.Rows[0]["idTopologia"]
                    };
                }

                return topologia;
            } catch (Exception ex) {
                throw new Exception("Error en TopologiaDAL: " + ex.Message);
            }
        }

        public Topologias GetByEmpresa(Empresa empresa) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idEmpresa", empresa.idEmpresa);
                string query = "stp_topologia_getByEmpresa";
                DataTable resultado = dataAccess.Query(query, parameters);
                Topologias topologias = new Topologias();

                foreach (DataRow item in resultado.Rows) {
                    topologias.Add(new Topologia() {
                        nombreTopologia = (string)item["nombreTopologia"],
                        fecha = (DateTime)item["fecha"],
                        idEmpresa = (int)item["idEmpresa"],
                        idTopologia = (int)item["idTopologia"]
                    }); ;
                }

                return topologias;
            } catch (Exception ex) {
                throw new Exception("Error en TopologiaDAL: " + ex.Message);
            }
        }

    }
}
