using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AerolineaFrba.Mappings
{
    public class Aeronave
    {
        public int aero_id {get; set;}
        public string aero_matricula {get; set;}
        public string aero_modelo { get; set; }
        public DateTime aero_fecha_alta { get; set; }
        public int fabricante { get; set; }
        public long aero_kg_disp { get; set; }
        public int aero_cant_butac { get; set; }
        public int aero_cant_butac_pasillo { get; set; }
        public int aero_cant_butac_ventana { get; set; }
        public int estado_id { get; set; }
        public DateTime aero_fecha_baja_servicio { get; set; }
        public DateTime aero_fecha_reinicio_servicio { get; set; }
        public DateTime aero_fecha_baja_vida_servicio { get; set; }
        public Servicio servicio_tipo { get; set; }
        
        public Aeronave()
        { 
            servicio_tipo = new Servicio();
        }

        public List<Aeronave> GetAeronaves()
        {
            
            List<Aeronave> listaAeronaves = new List<Aeronave>();
            BasedeDatos bd = new BasedeDatos();
            string sSql = "SELECT * FROM VW_AERONAVES";
            DataTable dt = bd.select_query(sSql);
            
            Aeronave aero;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                 aero = new Aeronave();

                //Asigno cada fila del DT al atributo correspondiente de la clase.
                //dt.Rows[i][0]->[i]: fila
                //              [0]: columna
                aero.aero_id = dt.Rows[i][0] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i][0]);
                aero.aero_matricula = dt.Rows[i][1] == DBNull.Value ? string.Empty : dt.Rows[i][1].ToString();
                aero.servicio_tipo.servicio_id = dt.Rows[i][2] == DBNull.Value ? 0 : Convert.ToInt32(dt.Rows[i][2]);
                aero.servicio_tipo.servicio_tipo = dt.Rows[i][3] == DBNull.Value ? string.Empty : dt.Rows[i][3].ToString();

                listaAeronaves.Add(aero);
            }

            return listaAeronaves;
           
        }
    }
    
}
