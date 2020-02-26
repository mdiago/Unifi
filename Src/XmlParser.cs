using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace Unifi
{
    /// <summary>
    /// Clase responsable de la serialización xml.
    /// </summary>
    public class XmlParser<T>
    {

        /// <summary>
        /// Devuelve un objeto en forma de xml.
        /// </summary>
        /// <param name="instance">Objeto a serializar como xml.</param>
        /// <returns>Contenido binario del xml codificado en UTF8.</returns>
        public static byte[] ToXmlBin(T instance) 
        {

            byte[] buffXml = null;

            XmlSerializer ser = new XmlSerializer(instance.GetType());

            using (var ms = new MemoryStream()) 
            { 
                using(var writer = new StreamWriter(ms, Encoding.UTF8)) 
                {
                    ser.Serialize(writer, instance);
                    buffXml = ms.ToArray();
                }
            }

            return buffXml;
        }

        /// <summary>
        /// Devuelve un objeto en forma de xml.
        /// </summary>
        /// <param name="instance">Objeto a serializar como xml.</param>
        /// <returns>Contenido del xml.</returns>
        public static string ToXmlStr(T instance)
        {

            return Encoding.UTF8.GetString(ToXmlBin(instance));

        }

        /// <summary>
        /// Devuelve un objeto procedente de una
        /// deserialización xml.
        /// </summary>
        /// <param name="xml">Binario del xml.</param>
        /// <returns>Binario del xml.</returns>
        public static T FromXml(byte[] xml) 
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            var stream = new MemoryStream(xml);
            return (T)ser.Deserialize(stream);
        }


    }
}
