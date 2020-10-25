using HB.Rover.Domain.Enums;

namespace HB.Rover.Domain
{
    public class Position
    {
        private int _coordinateX;
        private int _coordinateY;
        private Orientation _orientation;

        public Position(int coordinateX, int coordinateY, Orientation orientation)
        {
            _coordinateX = coordinateX;
            _coordinateY = coordinateY;
            _orientation = orientation;
        }

        public int CoordinateX
        {
            get
            {
                return _coordinateX;
            }
            set
            {
                _coordinateX = value;
            }
        }

        public int CoordinateY
        {
            get
            {
                return _coordinateY;
            }
            set
            {
                _coordinateY = value;
            }
        }

        public Orientation Orienation
        {
            get
            {
                return _orientation;
            }
            set
            {
                _orientation = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", _coordinateX, _coordinateY, (char)_orientation);
        }
    }
}
