using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Escaneo
{
	public class RegisUsuario
	{
		[XmlAttribute("id")]
		public int _id;
		[XmlAttribute("name")]
		public string _name;

		public RegisUsuario()
		{
			_id = 0;
			_name = string.Empty;
		}

		public RegisUsuario(int id, string name)
		{
			_id = id;
			_name = name;
		}

		public int ID
		{
			get
			{
				return _id;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
		}
	}

	[XmlRoot("UserDatabase")]
	public class UsuarioBDD : List<RegisUsuario>
	{
		public void WriteToFile(string filename)
		{
			TextWriter w = null;
			try
			{
				XmlSerializer s = new XmlSerializer(typeof(UsuarioBDD));
				w = new StreamWriter(filename);
				s.Serialize(w, this);
				w.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				if (w != null)
				{
					w.Close();
					w = null;
				}
			}
		}

		public static UsuarioBDD ReadFromFile(string filename)
		{
            UsuarioBDD newUserDb = null;
			TextReader r = null;
			try
			{
				XmlSerializer s = new XmlSerializer(typeof(UsuarioBDD));
				r = new StreamReader(filename);
				newUserDb = (UsuarioBDD)s.Deserialize(r);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				r.Close();
			}

			return newUserDb;
		}

		public RegisUsuario Lookup(int id)
		{
			foreach (RegisUsuario userRec in this)
			{
				if (userRec.ID == id)
				{
					return userRec;
				}
			}

			return null;
		}
	}
}
