namespace KarimiApp.Workstation.ModelFactory
{
    public class ModelFactory
    {
        private Interface.IWorkStationConverter _WorkStation;
        private Interface.IRecieptConverter _Reciept;
        private Interface.IPluConverter _Plu;
        private Interface.IHardKeyConverter _HardKey;

        public Interface.IWorkStationConverter WorkStation
        {
            get
            {
                if (_WorkStation == null)
                {
                    _WorkStation = new Class.WorkStationConvertor();
                }
                return _WorkStation;
            }
        }

        public Interface.IRecieptConverter Reciept
        {
            get
            {
                if (_Reciept == null)
                {
                    _Reciept = new Class.RecieptConvertor();
                }
                return _Reciept;
            }
        }

        public Interface.IPluConverter Plu
        {
            get
            {
                if (_Plu == null)
                {
                    _Plu = new Class.PluConvertor();
                }
                return _Plu;
            }
        }
        public Interface.IHardKeyConverter HardKey
        {
            get
            {
                if (_HardKey == null)
                {
                    _HardKey = new Class.HardKeyConveror();
                }
                return _HardKey;
            }
        }
    }
}
