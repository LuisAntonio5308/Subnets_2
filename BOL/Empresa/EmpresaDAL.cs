using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BOL {
    public class EmpresaDAL {

        #region Singleton

        private static volatile EmpresaDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private EmpresaDAL() { }

        public static EmpresaDAL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new EmpresaDAL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public int Add(Empresa empresa) {
            try {
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@nombreEmpresa", empresa.nombreEmpresa);
                parameters[1] = new SqlParameter("@direccionEmpresa", empresa.direccionEmpresa);
                parameters[2] = new SqlParameter("@telefono", empresa.telefono);
                parameters[3] = new SqlParameter("@correoElectronico", empresa.correoElectronico);
                
                string query = "stp_empresa_add";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en EmpresaDAL: " + ex.Message);
            }

        }

        public int Remove(Empresa empresa) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idEmpresa", empresa.idEmpresa);
                string query = "stp_empresa_remove";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en EmpresaDAL: " + ex.Message);
            }
        }

        public int Update(Empresa empresa) {
            try {
                SqlParameter[] parameters = new SqlParameter[5];
                parameters[0] = new SqlParameter("@nombreEmpresa", empresa.nombreEmpresa);
                parameters[1] = new SqlParameter("@direccionEmpresa", empresa.direccionEmpresa);
                parameters[2] = new SqlParameter("@telefono", empresa.telefono);
                parameters[3] = new SqlParameter("@correoElectronico", empresa.correoElectronico);
                parameters[4] = new SqlParameter("idEmpresa", empresa.idEmpresa);
                string query = "stp_empresa_update";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en empresa: " + ex.Message);
            }

        }
        public Empresas GetAll() {
            try {
                string query = "stp_empresa_getAll";
                DataTable resultado = dataAccess.Query(query);
                Empresas empresas = new Empresas();

                foreach (DataRow item in resultado.Rows) {
                    empresas.Add(new Empresa() {
                        idEmpresa = (int)item["idEmpresa"],
                        nombreEmpresa = (string)item["nombreEmpresa"],
                        direccionEmpresa = (string)item["direccionEmpresa"],
                        telefono = (string)item["telefono"],
                        correoElectronico = (string)item["correoElectronico"],
                    });
                }

                return empresas;

            } catch (Exception ex) {
                throw new Exception("Error en EmpresaDAL: " + ex.Message);
            }
        }

        public Empresa GetByID(Empresa empresa) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idEmpresa", empresa.idEmpresa);
                string query = "stp_empresa_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {
                    empresa = new Empresa() {
                        idEmpresa = (int)resultado.Rows[0]["idEmpresa"],
                        nombreEmpresa = (string)resultado.Rows[0]["nombreEmpresa"],
                        direccionEmpresa = (string)resultado.Rows[0]["direccionEmpresa"],
                        telefono = (string)resultado.Rows[0]["telefono"],
                        correoElectronico = (string)resultado.Rows[0]["correoElectronico"]
                    };

                }
                return empresa;
            } catch (Exception ex) {
                throw new Exception("Error en empresaDAL: " + ex.Message);
            }
        }

        public int RemoveAll(Empresa empresa) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idEmpresa", empresa.idEmpresa);
                string query = "stp_empresa_removeAll";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en EmpresaDAL: " + ex.Message);
            }
        }

    }
}
