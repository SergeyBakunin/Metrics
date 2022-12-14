namespace Metrics_Manager.Models
{
    public class AgentPool
    {
        private static AgentPool _instanse;

        public static AgentPool Instanse
        {
            get
            {
                if (_instanse == null)
                    _instanse = new AgentPool();
                return _instanse;
            }
        }


        private Dictionary<int, AgentInfo> _values;

        public AgentPool()
        {
            _values = new Dictionary<int, AgentInfo>();
        }

        public void Add(AgentInfo value)
        {
            if (!_values.ContainsKey(value.AgentId))
                _values.Add(value.AgentId, value);
        }

        public AgentInfo[] Get()
        {
            return _values.Values.ToArray();
        }

        public Dictionary<int, AgentInfo> Values
        {
            get { return _values; }
            set { _values = value; }
        }
    }
}
