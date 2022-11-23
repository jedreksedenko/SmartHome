using System;
namespace SmartHome.Entities
{
	public class Sensor
	{
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

            public virtual User Users { get; set; }
    }
}

