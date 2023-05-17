using System;
namespace Disaheim
{
	public interface IPersistable
	{
		void Save();
		void Save(string fileName);
		void Load();
		void Load(string fileName);
		
	}
}

