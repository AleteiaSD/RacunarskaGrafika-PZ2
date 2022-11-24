using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ2.Model
{
    public class LineEntity
    {
        private long id;
        private string name;
        private bool isUnderground;
        private float r;
        private string conductorMaterial;
        private string lineType;
        private long thermalConstantHeat;
        private long firstEnd;
        private long secondEnd;
        private List<Point> vertices = new List<Point>();

        public LineEntity()
        {
        }
        public LineEntity(long id, string name, bool isUnderground, float r, string conductorMaterial, string lineType, long thermalConstantHeat, long firstEnd, long secondEnd)
        {
            this.Id = id;
            this.name = name;
            this.isUnderground = isUnderground;
            this.r = r;
            this.conductorMaterial = conductorMaterial;
            this.lineType = lineType;
            this.thermalConstantHeat = thermalConstantHeat;
            this.firstEnd = firstEnd;
            this.secondEnd = secondEnd;
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
        public bool IsUnderground
        {
            get
            {
                return isUnderground;
            }

            set
            {
                isUnderground = value;
            }
        }
        public float R
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }
        public string ConductorMaterial
        {
            get
            {
                return conductorMaterial;
            }

            set
            {
                conductorMaterial = value;
            }
        }
        public string LineType
        {
            get
            {
                return lineType;
            }

            set
            {
                lineType = value;
            }
        }
        public long ThermalConstantHeat
        {
            get
            {
                return thermalConstantHeat;
            }

            set
            {
                thermalConstantHeat = value;
            }
        }
        public long FirstEnd
        {
            get
            {
                return firstEnd;
            }

            set
            {
                firstEnd = value;
            }
        }
        public long SecondEnd
        {
            get
            {
                return secondEnd;
            }

            set
            {
                secondEnd = value;
            }
        }
        public List<Point> Vertices
        {
            get
            {
                return vertices;
            }

            set
            {
                vertices = value;
            }
        }
    }
}
