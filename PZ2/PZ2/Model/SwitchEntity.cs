using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2.Model
{
    public class SwitchEntity
    {
        private long id;
        private string name;
        private string status;
        private double x;
        private double y;

        public SwitchEntity()
        {

        }
        public SwitchEntity(long id, string name, string status, double x, double y)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
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
        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
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
