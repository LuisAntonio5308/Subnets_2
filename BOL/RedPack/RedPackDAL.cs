using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL {
    public class RedPackDAL {

        #region Singleton

        private static volatile RedPackDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private RedPackDAL() { }

        public static RedPackDAL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new RedPackDAL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public int Add(RedPack redPack) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idTopologia", redPack.idTopologia);
                string query = "stp_redpack_add";
                return dataAccess.Execute(query, parameters);
                
            } catch (Exception ex) {
                throw new Exception("Error en RedPackDAL: " + ex.Message);
            }
        }

        public int Remove(RedPack redPack) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idPack", redPack.idPack);
                string query = "stp_redpack_remove";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en RedPackDAL: " + ex.Message);
            }
        }

        public int Update(RedPack redPack) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idTopologia", redPack.idTopologia);
                string query = "stp_redpack_update";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en RedPackDAL: " + ex.Message);
            }
        }

        public RedPacks GetAll() {
            try {
                string query = "stp_redpack_getAll";
                DataTable resultado = dataAccess.Query(query);
                RedPacks redPacks = new RedPacks();

                foreach (DataRow item in resultado.Rows) {
                    redPacks.Add(new RedPack() { 
                        idTopologia = (int)item["idTopologia"],
                        idPack = (int)item["idPack"]
                    });
                }

                return redPacks;

            } catch (Exception ex) {
                throw new Exception("Error en RedPackDAL: " + ex.Message);
            }
        }

        public RedPack GetByID(RedPack redPack) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idPack" , redPack.idPack);
                string query = "stp_redpack_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {
                    redPack = new RedPack() {
                        idPack = (int)resultado.Rows[0]["idPack"],
                        idTopologia = (int)resultado.Rows[0]["idTopologia"]
                    };
                }

                return redPack;

            } catch (Exception ex) {
                throw new Exception("Error en RedPackDAL: " + ex.Message);
            }
        }

        public RedPack GetByIDTopologia(RedPack redPack) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idTopologia", redPack.idTopologia);
                string query = "stp_redpack_getByIDTopologia";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {
                    redPack = new RedPack() {
                        idPack = (int)resultado.Rows[0]["idPack"],
                        idTopologia = (int)resultado.Rows[0]["idTopologia"]
                    };
                }

                return redPack;

            } catch (Exception ex) {
                throw new Exception("Error en RedPackDAL: " + ex.Message);
            }
        }


    }
}
