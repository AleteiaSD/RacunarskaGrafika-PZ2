using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2.Model
{
    public class SubstationEntity
    {
        private long id;
        private string name;
        private double x;
        private double y;

        public SubstationEntity()
        {

        }
        public SubstationEntity(long id, string name, double x, double y)
        {
            this.Id = id;
            this.Name = name;
            this.X = x;
            this.Y = y;
        }

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name} \nID: {Id}\nName: {Name}";
        }
    }
}
