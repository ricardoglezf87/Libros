using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDatosRYC
{
    public class clsRYC
    {

        #region "Propiedades y Variables"

            private Datos_Xml.DataSetXml _Datos;
	        public Datos_Xml.DataSetXml Datos
            {
                get { return _Datos; }
                set { _Datos = value; }
            }
                    
        #endregion

        #region "funciones publicas"

            public clsRYC(string RutaArchivo )
            {
                if (!(new System.IO.FileInfo(RutaArchivo).Exists))
                {
                    CrearBaseDatos(RutaArchivo);
                    
                }

                Datos = DesencriptarFichero(RutaArchivo);
            }

            public clsRYC(Datos_Xml.DataSetXml DatosDataSet)
            {
                Datos = DatosDataSet;
            }

            public clsRYC()
            {
                Datos = new Datos_Xml.DataSetXml();
            }

            public void CrearBaseDatos(String RutaFichero)
            {
                EncriptarFichero(Datos_Xml.Xml.XmlVacio, RutaFichero);             
            }
               
            public void EncriptarFichero(string TextoEncriptar, string RutaDestino)
            {

                System.IO.StringReader File = new System.IO.StringReader(TextoEncriptar);

                System.IO.StreamWriter wr = new System.IO.StreamWriter(RutaDestino, false);

                for (int i = 0; i < TextoEncriptar.Length; i++)
                {

                    wr.Write(File.Read() + 100);

                }

                File.Close();
                wr.Close();

            }

            public void EncriptarFichero(Datos_Xml.DataSetXml xDatos, string RutaDestino)
            {

                System.IO.StringWriter File = new System.IO.StringWriter();

                xDatos.WriteXml(File);
                                
                System.IO.StreamWriter wr = new System.IO.StreamWriter(RutaDestino, false);
                                
                for (int i = 0; i < File.GetStringBuilder().Length; i++)
                {
                    wr.Write((int)(File.GetStringBuilder()[i]) + 100);
                   
                }

                File.Close();
                wr.Close();

            }

            private char DesencriptarLetra(int Numero1, int Numero2, int Numero3)
            {
                Numero1 = (Numero1 - 48) * 100;
                Numero2 = (Numero2 - 48) * 10;
                Numero3 =  Numero3 - 48;

                Numero3 = (Numero3 + Numero2 + Numero1) - 100;

                return (char)Numero3;
            }
        
            public Datos_Xml.DataSetXml DesencriptarFichero(string Ruta)
            {

                if (new System.IO.FileInfo(Ruta).Exists)
                {
                                        
                    System.IO.StreamReader File = new System.IO.StreamReader(Ruta);
                    StringBuilder wr = new StringBuilder();
                    
                    while (!File.EndOfStream)
                    {
                        wr.Append(DesencriptarLetra(File.Read(), File.Read(), File.Read()));                                                                       
                    }
                    
                    File.Close();

                    Datos_Xml.DataSetXml xDatos = new Datos_Xml.DataSetXml();

                    xDatos.ReadXml(new System.IO.StringReader(wr.ToString()));

                    return xDatos;

                }
                else
                {

                    return null;

                }

            }

        #endregion
        
    }
}
