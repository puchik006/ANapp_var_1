namespace ANapp_var_1
{
    public class SparePart
    {
        private string _partName;
        private int _partNumber;

        public SparePart(string partName, int partNumber)
        {
            _partName = partName;
            _partNumber = partNumber;
        }

        public override string ToString()
        {
            return _partName + " #" + _partNumber;
        }
    }


}
