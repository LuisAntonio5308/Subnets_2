using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL {
    public class UsuarioDAL {

        #region Singleton

        private static volatile UsuarioDAL instance = null;
        private static readonly object padlock = new object();
        private DataAccess dataAccess = DataAccess.Instance();

        private UsuarioDAL() { }

        public static UsuarioDAL Instance() {
            if (instance == null) {
                lock (padlock) {
                    if (instance == null) {
                        instance = new UsuarioDAL();
                    }
                }
            }
            return instance;
        }

        #endregion

        public int Add(Usuario usuario) {
            try {
                SqlParameter[] parameters = new SqlParameter[9];
                parameters[0] = new SqlParameter("@nickname" , usuario.nickname);
                parameters[1] = new SqlParameter("@contrasena", usuario.contrasena);
                parameters[2] = new SqlParameter("@administrador", usuario.administrador);
                parameters[3] = new SqlParameter("@nombre", usuario.nombre);
                parameters[4] = new SqlParameter("@apellidoP", usuario.apellidoP);
                parameters[5] = new SqlParameter("@apellidoM", usuario.apellidoM);
                parameters[6] = new SqlParameter("@direccionPersona", usuario.direccionUsuario);
                parameters[7] = new SqlParameter("@correoElectronico", usuario.correoElectronico);
                parameters[8] = new SqlParameter("@telefono", usuario.telefono);
                string query = "stp_usuario_add";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en UsuarioDAL: " + ex.Message);
            }
        }

        public int Remove(Usuario usuario) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idUsuario", usuario.idUsuario);
                string query = "stp_usuario_remove";
                return dataAccess.Execute(query, parameters);   
            } catch (Exception ex) {
                throw new Exception("Error en UsuarioDAL: " + ex.Message);
            }
        }

        public int Update(Usuario usuario) {
            try {
                SqlParameter[] parameters = new SqlParameter[10];
                parameters[0] = new SqlParameter("@nickname", usuario.nickname);
                parameters[1] = new SqlParameter("@contrasena", usuario.contrasena);
                parameters[2] = new SqlParameter("@administrador", usuario.administrador);
                parameters[3] = new SqlParameter("@nombre", usuario.nombre);
                parameters[4] = new SqlParameter("@apellidoP", usuario.apellidoP);
                parameters[5] = new SqlParameter("@apellidoM", usuario.apellidoM);
                parameters[6] = new SqlParameter("@direccionPersona", usuario.direccionUsuario);
                parameters[7] = new SqlParameter("@correoElectronico", usuario.correoElectronico);
                parameters[8] = new SqlParameter("@telefono", usuario.telefono);
                parameters[9] = new SqlParameter("@idUsuario" , usuario.idUsuario);
                string query = "stp_usuario_update";
                return dataAccess.Execute(query, parameters);
            } catch (Exception ex) {
                throw new Exception("Error en UsuarioDAL: " + ex.Message);
            }
        }

        public Usuarios GetAll() {
            try {
                string query = "stp_usuario_getAll";
                DataTable resultado = dataAccess.Query(query);
                Usuarios usuarios = new Usuarios();

                foreach (DataRow item in resultado.Rows) {
                    usuarios.Add(new Usuario() { 
                        idUsuario = (int)item["idUsuario"],
                        nickname = (string)item["nickname"],
                        contrasena = (string)item["contrasena"],
                        administrador = (bool)item["administrador"],
                        nombre = (string)item["nombre"],
                        apellidoP = (string)item["apellidoP"],
                        apellidoM = (string)item["apellidoM"],
                        direccionUsuario = (string)item["direccionPersona"],
                        correoElectronico = (string)item["correoElectronico"],
                        telefono = (string)item["telefono"]
                    });
                }

                return usuarios;

            } catch (Exception ex) {
                throw new Exception("Error en UsuarioDAL: " + ex.Message);
            }
        }

        public Usuario GetByID(Usuario usuario) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idUsuario", usuario.idUsuario);
                string query = "stp_usuario_getByID";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) { 
                    usuario = new Usuario() {
                        idUsuario = (int)resultado.Rows[0]["idUsuario"],
                        nickname = (string)resultado.Rows[0]["nickname"],
                        contrasena = (string)resultado.Rows[0]["contrasena"],
                        administrador = (bool)resultado.Rows[0]["administrador"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        apellidoP = (string)resultado.Rows[0]["apellidoP"],
                        apellidoM = (string)resultado.Rows[0]["apellidoM"],
                        direccionUsuario = (string)resultado.Rows[0]["direccionPersona"],
                        correoElectronico = (string)resultado.Rows[0]["correoElectronico"],
                        telefono = (string)resultado.Rows[0]["telefono"]
                    };
                }

                return usuario;

            } catch (Exception ex) {
                throw new Exception("Error en UsuarioDAL: " + ex.Message);
            }
        }

        public bool Login(Usuario usuario) {
            try {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@nickname", usuario.nickname);
                parameters[1] = new SqlParameter("@contrasena", usuario.contrasena);
                string query = "stp_usuario_login";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {

                    return true;
                    
                } else {
                    return false;
                }

            } catch (Exception ex) {
                throw new Exception("Error en UsuarioDAL: " + ex.Message);
            }
        }

        public Usuario GetByNickname(Usuario usuario) {
            try {
                SqlParameter[] parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("nickname", usuario.nickname);
                string query = "stp_usuario_getByNickname";
                DataTable resultado = dataAccess.Query(query, parameters);

                if (resultado.Rows.Count > 0) {
                    usuario = new Usuario() {
                        idUsuario = (int)resultado.Rows[0]["idUsuario"],
                        nickname = (string)resultado.Rows[0]["nickname"],
                        contrasena = (string)resultado.Rows[0]["contrasena"],
                        administrador = (bool)resultado.Rows[0]["administrador"],
                        nombre = (string)resultado.Rows[0]["nombre"],
                        apellidoP = (string)resultado.Rows[0]["apellidoP"],
                        apellidoM = (string)resultado.Rows[0]["apellidoM"],
                        direccionUsuario = (string)resultado.Rows[0]["direccionPersona"],
                        correoElectronico = (string)resultado.Rows[0]["correoElectronico"],
                        telefono = (string)resultado.Rows[0]["telefono"]
                    };
                }

                return usuario;
            }catch (Exception ex) {
                throw new Exception("Error en UsuarioDAL: " + ex.Message);
            }
        }

    }
}
