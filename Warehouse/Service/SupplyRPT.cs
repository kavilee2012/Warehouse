using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse.Service
{
    public class SupplyRPT
    {
        private int _id;
        private string _supplyid;
        private string _agentname;
        private decimal _price;
        private string _operator;
        private DateTime _createtime;
        private decimal _sumprice;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SupplyID
        {
            set { _supplyid = value; }
            get { return _supplyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AgentName
        {
            set { _agentname = value; }
            get { return _agentname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price
        {
            set { _price = value; }
            get { return _price; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Operator
        {
            set { _operator = value; }
            get { return _operator; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal SumPrice
        {
            set { _sumprice = value; }
            get { return _sumprice; }
        }
    }
}
