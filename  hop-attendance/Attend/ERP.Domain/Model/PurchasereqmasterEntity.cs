using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Web.Mvc;

namespace ERP.Domain.Model
{
	public class PurchasereqmasterEntity
	{
		public string Id
		{
			get;
			set;
		}
		public string Purchaseno
		{
			get;
			set;
		}
		public string Purchasedate
		{
			get;
			set;
		}
		public string Companyid
		{
			get;
			set;
		}
		public string Approvedby
		{
			get;
			set;
		}
		public string Status
		{
			get;
			set;
		}
		public string Purchasenotes
		{
			get;
			set;
		}
		public string Entrydate
		{
			get;
			set;
		}
		public string Modifydate
		{
			get;
			set;
		}

        public string ProductID
        {
            get;
            set;
        }
        public string Packsizeid
        {
            get;
            set;
        }
        public string Unitprice
        {
            get;
            set;
        }
        public string Stockqnty
        {
            get;
            set;
        }
        public string Totalprice
        {
            get;
            set;
        }
        public List<SelectListItem> ProductLists { get; set; }
        public List<SelectListItem> PackSizeLists { get; set; }

        public string StartDate
        {
            get;
            set;
        }
        public string EndDate
        {
            get;
            set;
        }
        public ArrayList Details
        {
            get;
            set;
        }
	}
}

